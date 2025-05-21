using Capa_Modelo_Nominas;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Capa_Modelo_Planilla
{
    public class Sentencias
    {
        private readonly Conexion cn = new Conexion();

        //public OdbcDataAdapter funObtenerEncabezado()
        //{
        //    // Consulta SQL solo con los campos de tbl_planilla_Encabezado
        //    string query = @"
        //SELECT 
        //    pk_registro_planilla_Encabezado AS ClaveEncabezado,
        //    encabezado_correlativo_planilla AS Correlativo,
        //    encabezado_fecha_inicio AS FechaInicio,
        //    encabezado_fecha_final AS FechaFinal,
        //    encabezado_total_mes AS TotalMes,
        //    estado AS Estado
        //FROM 
        //    tbl_planilla_Encabezado
        //WHERE 
        //    estado = 1;";

        //    try
        //    {
        //        OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conexion());
        //        return adapter;
        //    }
        //    catch (OdbcException ex)
        //    {
        //        Console.WriteLine("Error al obtener el encabezado: " + ex.Message);
        //        return null;
        //    }
        //}


        private int ConvertirMesANumero(string mesTexto)
        {
            Dictionary<string, int> meses = new Dictionary<string, int>
    {
        {"enero", 1},
        {"febrero", 2},
        {"marzo", 3},
        {"abril", 4},
        {"mayo", 5},
        {"junio", 6},
        {"julio", 7},
        {"agosto", 8},
        {"septiembre", 9},
        {"octubre", 10},
        {"noviembre", 11},
        {"diciembre", 12}
    };

            return meses.TryGetValue(mesTexto.ToLower(), out int numeroMes) ? numeroMes : 0;
        }

        private string GetPercepcionesCols(string mesTexto)
        {
            try
            {
                List<string> columnas = new List<string>();
                string query = @"
            SELECT dedu_perp_concepto
            FROM tbl_dedu_perp 
            WHERE dedu_perp_clase = 'Percepcion'";

                using (OdbcCommand cmd = new OdbcCommand(query, cn.conexion()))
                {
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string concepto = reader["dedu_perp_concepto"].ToString();
                            // Usando CASE WHEN y comillas invertidas para los nombres de columnas
                            columnas.Add($@"IFNULL(SUM(CASE 
                        WHEN dp.dedu_perp_concepto = '{concepto}' 
                        AND LOWER(de.dedu_perp_emp_mes) = '{mesTexto}'
                        THEN de.dedu_perp_emp_cantidad 
                        ELSE 0 
                    END), 0) AS `{concepto}`");
                        }
                    }
                }
                return string.Join(", ", columnas);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en GetPercepcionesCols: {ex.Message}");
                return string.Empty;
            }
        }

        private string GetDeduccionesCols(string mesTexto)
        {
            try
            {
                List<string> columnas = new List<string>();
                string query = @"
            SELECT dedu_perp_concepto
            FROM tbl_dedu_perp 
            WHERE dedu_perp_clase = 'Deduccion'
            AND dedu_perp_concepto NOT IN ('Aguinaldo', 'Bono 14', 'Vacaciones')";

                using (OdbcCommand cmd = new OdbcCommand(query, cn.conexion()))
                {
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string concepto = reader["dedu_perp_concepto"].ToString();
                            // Usando CASE WHEN y comillas invertidas para los nombres de columnas
                            columnas.Add($@"IFNULL(SUM(CASE 
                        WHEN dp.dedu_perp_concepto = '{concepto}' 
                        AND LOWER(de.dedu_perp_emp_mes) = '{mesTexto}'
                        THEN de.dedu_perp_emp_cantidad 
                        ELSE 0 
                    END), 0) AS `{concepto}`");
                        }
                    }
                }
                return string.Join(", ", columnas);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en GetDeduccionesCols: {ex.Message}");
                return string.Empty;
            }
        }

        public OdbcDataAdapter funObtenerPlanillaConDetalleCompleto(string mesTexto)
        {
            try
            {
                int mesNumero = ConvertirMesANumero(mesTexto);
                if (mesNumero == 0)
                {
                    throw new ArgumentException("Mes no válido");
                }

                string percepcionesCols = GetPercepcionesCols(mesTexto.ToLower());
                string deduccionesCols = GetDeduccionesCols(mesTexto.ToLower());

                string query = $@"
            SELECT 
                e.pk_clave AS `Correlativo`,
                e.empleados_nombre AS `Nombre`,
                e.empleados_apellido AS `Apellido`,
                pt.puestos_nombre_puesto AS `Puesto`,
                d.departamentos_nombre_departamento AS `Departamento`,
                c.contratos_salario AS `SueldoBase`,
                ph.encabezado_correlativo_planilla AS `CorrelativoPlanilla`,
                ph.encabezado_fecha_inicio AS `FechaInicio`,
                ph.encabezado_fecha_final AS `FechaFinal`,
                {percepcionesCols},
                IFNULL(SUM(CASE 
                    WHEN dp.dedu_perp_clase = 'Percepcion' 
                    AND LOWER(de.dedu_perp_emp_mes) = '{mesTexto.ToLower()}'
                    THEN de.dedu_perp_emp_cantidad 
                    ELSE 0 
                END), 0) AS `TotalPercepciones`,
                {deduccionesCols},
                IFNULL(SUM(CASE 
                    WHEN dp.dedu_perp_clase = 'Deduccion' 
                    AND LOWER(de.dedu_perp_emp_mes) = '{mesTexto.ToLower()}'
                    THEN de.dedu_perp_emp_cantidad 
                    ELSE 0 
                END), 0) AS `TotalDeducciones`,
                (c.contratos_salario +
                    IFNULL(SUM(CASE 
                        WHEN dp.dedu_perp_clase = 'Percepcion' 
                        AND LOWER(de.dedu_perp_emp_mes) = '{mesTexto.ToLower()}'
                        THEN de.dedu_perp_emp_cantidad 
                        ELSE 0 
                    END), 0) - 
                    IFNULL(SUM(CASE 
                        WHEN dp.dedu_perp_clase = 'Deduccion' 
                        AND LOWER(de.dedu_perp_emp_mes) = '{mesTexto.ToLower()}'
                        THEN de.dedu_perp_emp_cantidad 
                        ELSE 0 
                    END), 0)
                ) AS `TotalDevengado`
            FROM 
                tbl_empleados e
                JOIN tbl_contratos c ON e.pk_clave = c.fk_clave_empleado
                JOIN tbl_departamentos d ON e.fk_id_departamento = d.pk_id_departamento
                JOIN tbl_puestos_trabajo pt ON e.fk_id_puestos = pt.pk_id_puestos
                LEFT JOIN tbl_dedu_perp_emp de ON e.pk_clave = de.Fk_clave_empleado
                LEFT JOIN tbl_dedu_perp dp ON dp.pk_dedu_perp = de.Fk_dedu_perp
                JOIN tbl_planilla_Encabezado ph ON 
                    MONTH(ph.encabezado_fecha_inicio) = {mesNumero} AND 
                    YEAR(ph.encabezado_fecha_inicio) = YEAR(CURDATE()) AND
                ph.estado = 1
            WHERE 
                e.estado = 1
                AND ph.pk_registro_planilla_Encabezado IS NOT NULL
            GROUP BY 
                e.pk_clave, e.empleados_nombre, e.empleados_apellido, pt.puestos_nombre_puesto, 
                d.departamentos_nombre_departamento, c.contratos_salario, 
                ph.encabezado_correlativo_planilla, ph.encabezado_fecha_inicio, ph.encabezado_fecha_final
            LIMIT 0, 1000";

                OdbcCommand cmd = new OdbcCommand(query, cn.conexion());
                return new OdbcDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el detalle de la planilla: {ex.Message}");
                return null;
            }
        }

        public OdbcDataAdapter funObtenerDedu()
        {
            // Consulta detallada para obtener los detalles de planilla y otras tablas relacionadas
            string query = @"
            SELECT 
                dedu_perp_emp.pk_dedu_perp_emp AS ID_Deduccion,
                empleados.empleados_nombre AS nombre_empleado,
                empleados.empleados_apellido AS apellido_empleado,
                dedu_perp.dedu_perp_concepto AS concepto_deduccion_percepcion,
                dedu_perp.dedu_perp_tipo AS tipo_deduccion_percepcion,
                dedu_perp_emp.dedu_perp_emp_cantidad AS cantidad_deduccion_percepcion,
                dedu_perp_emp.dedu_perp_emp_mes AS mes_deduccion_percepcion,
                dedu_perp_emp.estado AS estado_deduccion_percepcion
            FROM 
                tbl_dedu_perp_emp AS dedu_perp_emp
            JOIN 
                tbl_empleados AS empleados ON dedu_perp_emp.Fk_clave_empleado = empleados.pk_clave
            JOIN 
                tbl_dedu_perp AS dedu_perp ON dedu_perp_emp.Fk_dedu_perp = dedu_perp.pk_dedu_perp
            ORDER BY 
                empleados.empleados_nombre, dedu_perp_emp.dedu_perp_emp_mes; ";

            try
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conexion());
                return adapter;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al obtener el detalle: " + ex.Message);
                return null;
            }
        }


        public OdbcDataAdapter proCargarTotalMes()
        {
            // Consulta para obtener percepciones y deducciones con totales por cada mes y un total anual
            string query = @"
    SELECT 
        dedu_perp.dedu_perp_concepto AS concepto,
        dedu_perp.dedu_perp_tipo AS tipo,
        SUM(CASE WHEN dedu_perp_emp.dedu_perp_emp_mes = 'enero' THEN dedu_perp_emp.dedu_perp_emp_cantidad ELSE 0 END) AS enero,
        SUM(CASE WHEN dedu_perp_emp.dedu_perp_emp_mes = 'febrero' THEN dedu_perp_emp.dedu_perp_emp_cantidad ELSE 0 END) AS febrero,
        SUM(CASE WHEN dedu_perp_emp.dedu_perp_emp_mes = 'marzo' THEN dedu_perp_emp.dedu_perp_emp_cantidad ELSE 0 END) AS marzo,
        SUM(CASE WHEN dedu_perp_emp.dedu_perp_emp_mes = 'abril' THEN dedu_perp_emp.dedu_perp_emp_cantidad ELSE 0 END) AS abril,
        SUM(CASE WHEN dedu_perp_emp.dedu_perp_emp_mes = 'mayo' THEN dedu_perp_emp.dedu_perp_emp_cantidad ELSE 0 END) AS mayo,
        SUM(CASE WHEN dedu_perp_emp.dedu_perp_emp_mes = 'junio' THEN dedu_perp_emp.dedu_perp_emp_cantidad ELSE 0 END) AS junio,
        SUM(CASE WHEN dedu_perp_emp.dedu_perp_emp_mes = 'julio' THEN dedu_perp_emp.dedu_perp_emp_cantidad ELSE 0 END) AS julio,
        SUM(CASE WHEN dedu_perp_emp.dedu_perp_emp_mes = 'agosto' THEN dedu_perp_emp.dedu_perp_emp_cantidad ELSE 0 END) AS agosto,
        SUM(CASE WHEN dedu_perp_emp.dedu_perp_emp_mes = 'septiembre' THEN dedu_perp_emp.dedu_perp_emp_cantidad ELSE 0 END) AS septiembre,
        SUM(CASE WHEN dedu_perp_emp.dedu_perp_emp_mes = 'octubre' THEN dedu_perp_emp.dedu_perp_emp_cantidad ELSE 0 END) AS octubre,
        SUM(CASE WHEN dedu_perp_emp.dedu_perp_emp_mes = 'noviembre' THEN dedu_perp_emp.dedu_perp_emp_cantidad ELSE 0 END) AS noviembre,
        SUM(CASE WHEN dedu_perp_emp.dedu_perp_emp_mes = 'diciembre' THEN dedu_perp_emp.dedu_perp_emp_cantidad ELSE 0 END) AS diciembre,
        -- Columna de total anual sumando los valores de los 12 meses
        SUM(CASE WHEN dedu_perp_emp.dedu_perp_emp_mes IN ('enero', 'febrero', 'marzo', 'abril', 'mayo', 'junio', 'julio', 'agosto', 'septiembre', 'octubre', 'noviembre', 'diciembre') 
                 THEN dedu_perp_emp.dedu_perp_emp_cantidad ELSE 0 END) AS total_anual
    FROM 
        tbl_dedu_perp AS dedu_perp
    LEFT JOIN 
        tbl_dedu_perp_emp AS dedu_perp_emp ON dedu_perp.pk_dedu_perp = dedu_perp_emp.Fk_dedu_perp
    GROUP BY 
        dedu_perp.dedu_perp_concepto, dedu_perp.dedu_perp_tipo
    ORDER BY 
        dedu_perp.dedu_perp_concepto;";

            try
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conexion());
                return adapter;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al obtener el detalle: " + ex.Message);
                return null;
            }
        }


        public OdbcDataAdapter funObtenerEncabezadoInicial()
        {
            // Consulta para obtener únicamente los datos del encabezado de planilla
            string query = @"
    SELECT 
        pk_registro_planilla_Encabezado AS ID_Encabezado,
        encabezado_correlativo_planilla AS Correlativo,
        encabezado_fecha_inicio AS Fecha_Inicio,
        encabezado_fecha_final AS Fecha_Final,
        encabezado_total_mes AS Total_Mes,
        estado AS Estado
    FROM 
        tbl_planilla_Encabezado
    WHERE estado = 1
    ORDER BY 
        encabezado_correlativo_planilla;";

            try
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conexion());
                return adapter;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al obtener el encabezado: " + ex.Message);
                return null;
            }
        }


        /********************************************************************************/

        public bool funInsertarPlanillaEncabezado(int icorrelativoPlanilla, DateTime dfechaInicio, DateTime dfechaFinal, string smesTexto)
        {
            string query = "INSERT INTO tbl_planilla_Encabezado (encabezado_correlativo_planilla, encabezado_fecha_inicio, encabezado_fecha_final, encabezado_total_mes, estado) " +
                   "VALUES (?, ?, ?, ?, 1)";
            decimal detotalMes = 0;
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Open();

                    using (OdbcCommand command = new OdbcCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@correlativoPlanilla", icorrelativoPlanilla);
                        command.Parameters.AddWithValue("@fechaInicio", dfechaInicio);
                        command.Parameters.AddWithValue("@fechaFinal", dfechaFinal);
                        command.Parameters.AddWithValue("@totalMes", detotalMes);
                        command.ExecuteNonQuery();
                    }

                    int idEncabezado = ObtenerUltimoIdEncabezado(conn);
                    List<int> listaEmpleados = ObtenerListaEmpleados(conn);
                    foreach (var empleadoId in listaEmpleados)
                    {
                        if (funCalcularPlanillaDetalle(idEncabezado, empleadoId, conn, out decimal sueldoLiquido, smesTexto))
                        {
                            detotalMes += sueldoLiquido;
                        }
                    }

                    ActualizarTotalEncabezado(conn, idEncabezado, detotalMes);
                    return true;
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al insertar planilla encabezado: " + ex.Message);
                return false;
            }
        }

        /**********************************************************************************************/

        // Método para obtener el ID del último encabezado insertado
        private int ObtenerUltimoIdEncabezado(OdbcConnection connection)
        {
            string query = "SELECT MAX(pk_registro_planilla_Encabezado) FROM tbl_planilla_Encabezado";
            using (OdbcCommand command = new OdbcCommand(query, connection))
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        // Método para obtener la lista de todos los empleados
        private List<int> ObtenerListaEmpleados(OdbcConnection connection)
        {
            List<int> empleados = new List<int>();
            string query = "SELECT pk_clave FROM tbl_empleados WHERE estado = 1";
            using (OdbcCommand command = new OdbcCommand(query, connection))
            using (OdbcDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    empleados.Add(reader.GetInt32(0));
                }
            }
            return empleados;
        }

        //Modificar funCalcularPlanillaDetalle para aceptar OdbcConnection y devolver sueldo líquido
        public bool funCalcularPlanillaDetalle(int ifkIdRegistroPlanillaEncabezado, int ifkClaveEmpleado, OdbcConnection connection, out decimal sueldoLiquido, string smesTexto)
        {
            try
            {
                decimal salarioBase = funObtenerSalarioBase(connection, ifkClaveEmpleado, out int contratoId);
                decimal totalPercepciones = funObtenerTotalPercepciones(connection, ifkClaveEmpleado, smesTexto);
                decimal totalDeducciones = funObtenerTotalDeducciones(connection, ifkClaveEmpleado, smesTexto);

                sueldoLiquido = salarioBase + totalPercepciones - totalDeducciones;

                funInsertarDetallePlanilla(connection, totalPercepciones, totalDeducciones, sueldoLiquido, ifkClaveEmpleado, contratoId, ifkIdRegistroPlanillaEncabezado);

                return true;
            }
            catch
            {
                sueldoLiquido = 0;
                return false;
            }
        }

        // Método para actualizar el total en el encabezado de planilla
        private void ActualizarTotalEncabezado(OdbcConnection connection, int idEncabezado, decimal totalMes)
        {
            string query = "UPDATE tbl_planilla_Encabezado SET encabezado_total_mes = ? WHERE pk_registro_planilla_Encabezado = ?";
            using (OdbcCommand command = new OdbcCommand(query, connection))
            {
                command.Parameters.AddWithValue("@totalMes", totalMes);
                command.Parameters.AddWithValue("@idEncabezado", idEncabezado);
                command.ExecuteNonQuery();
            }
        }

        /********************************************************************************/


        private decimal funObtenerSalarioBase(OdbcConnection connection, int ifkClaveEmpleado, out int icontratoId)
        {
            icontratoId = 0;
            decimal desalarioBase = 0;

            string query = @"
        SELECT pk_id_contrato, contratos_salario 
        FROM tbl_contratos 
        WHERE fk_clave_empleado = ? 
        ORDER BY contratos_fecha_creacion DESC 
        LIMIT 1";

            using (OdbcCommand cmd = new OdbcCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@fk_clave_empleado", ifkClaveEmpleado);

                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && !reader.IsDBNull(0) && !reader.IsDBNull(1))
                    {
                        icontratoId = reader.GetInt32(0);
                        desalarioBase = reader.GetDecimal(1);
                    }
                    else
                    {
                        throw new Exception("No se encontró un contrato para este empleado.");
                    }
                }
            }

            return desalarioBase;
        }

        // Modificar funObtenerTotalPercepciones para incluir el mes
        private decimal funObtenerTotalPercepciones(OdbcConnection connection, int ifkClaveEmpleado, string smesTexto)
        {
            string query = @"
    SELECT SUM(dpe.dedu_perp_emp_cantidad)
    FROM tbl_dedu_perp_emp dpe
    INNER JOIN tbl_dedu_perp dp ON dpe.Fk_dedu_perp = dp.pk_dedu_perp
    WHERE dpe.Fk_clave_empleado = ? 
    AND dp.dedu_perp_clase = 'Percepcion' 
    AND dpe.estado = 1
    AND dp.dedu_perp_concepto NOT IN ('Aguinaldo', 'Bono 14', 'Vacaciones')
    AND LOWER(dpe.dedu_perp_emp_mes) = LOWER(?) OR LOWER(dpe.dedu_perp_emp_mes) = 'Permanente';";

            try
            {
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fk_clave_empleado", ifkClaveEmpleado);
                    cmd.Parameters.AddWithValue("@smesTexto", smesTexto);

                    object result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine($"Error al obtener total de percepciones: {ex.Message}");
                return 0; // O manejar el error de otra manera según sea necesario.
            }
        }

        // Modificar funObtenerTotalDeducciones para incluir el mes
        private decimal funObtenerTotalDeducciones(OdbcConnection connection, int ifkClaveEmpleado, string smesTexto)
        {
            string query = @"
    SELECT SUM(dpe.dedu_perp_emp_cantidad)
    FROM tbl_dedu_perp_emp dpe
    INNER JOIN tbl_dedu_perp dp ON dpe.Fk_dedu_perp = dp.pk_dedu_perp
    WHERE dpe.Fk_clave_empleado = ? 
    AND dp.dedu_perp_clase = 'Deduccion' 
    AND dpe.estado = 1
    AND dp.dedu_perp_concepto NOT IN ('Aguinaldo', 'Bono 14', 'Vacaciones')
    AND LOWER(dpe.dedu_perp_emp_mes) = LOWER(?) OR LOWER(dpe.dedu_perp_emp_mes) = 'Permanente';";

            try
            {
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fk_clave_empleado", ifkClaveEmpleado);
                    cmd.Parameters.AddWithValue("@smesTexto", smesTexto);

                    object result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine($"Error al obtener total de deducciones: {ex.Message}");
                return 0; // O manejar el error de otra manera según sea necesario.
            }
        }

        private void funInsertarDetallePlanilla(OdbcConnection connection, decimal detotalPercepciones, decimal detotalDeducciones, decimal detotalLiquido, int ifkClaveEmpleado, int icontratoId, int ifkIdRegistroPlanillaEncabezado)
        {
            string query = @"
        INSERT INTO tbl_planilla_Detalle 
        (detalle_total_Percepciones, detalle_total_Deducciones, detalle_total_liquido, fk_clave_empleado, fk_id_contrato, fk_id_registro_planilla_Encabezado, estado)
        VALUES (?, ?, ?, ?, ?, ?, 1)";

            try
            {
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@detalle_total_Percepciones", detotalPercepciones);
                    cmd.Parameters.AddWithValue("@detalle_total_Deducciones", detotalDeducciones);
                    cmd.Parameters.AddWithValue("@detalle_total_liquido", detotalLiquido);
                    cmd.Parameters.AddWithValue("@fk_clave_empleado", ifkClaveEmpleado);
                    cmd.Parameters.AddWithValue("@fk_id_contrato", icontratoId);
                    cmd.Parameters.AddWithValue("@fk_id_registro_planilla_Encabezado", ifkIdRegistroPlanillaEncabezado);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine($"Error al insertar detalle de planilla: {ex.Message}");
                // Aquí podrías agregar más lógica, como registrar el error en un log o lanzar una excepción personalizada.
            }
        }


        public DataTable funobtener1(string sTabla, string sCampo1, string sCampo2)
        {
            /*****Para empleado*****/
            Conexion cn = new Conexion();
            string sql = "SELECT DISTINCT " + sCampo1 + "," + sCampo2 + " FROM " + sTabla;

            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }


        public DataTable funobtener2(string sTabla, string sCampo1, string sCampo2)
        {
            // Conexión a la base de datos
            Conexion cn = new Conexion();

            // Consulta SQL modificada
            string sql = $@"
        SELECT DISTINCT {sCampo1}, {sCampo2}
        FROM {sTabla}
        WHERE {sCampo2} NOT IN ('Horas Extras', 'Anticipo', 'Faltas', 'Bono 14', 'Aguinaldo', 'Vacaciones')";

            // Ejecutar la consulta
            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;
        }

        /****************************************/
        public void funcActualizarEncabezado(int iidSeleccionado, int icorrelativo, DateTime dfechaInicio, DateTime dfechaFinal, string smesTexto)
        {
            try
            {
                decimal detotalMes = 0; // Variable para acumular el total del mes

                // Primero, actualizamos la información del encabezado con los nuevos datos.
                string sqlEncabezado = "UPDATE tbl_planilla_Encabezado SET " +
                                       "encabezado_correlativo_planilla = ?, " +
                                       "encabezado_fecha_inicio = ?, " +
                                       "encabezado_fecha_final = ? " +
                                       "WHERE pk_registro_planilla_Encabezado = ?";

                using (OdbcConnection conn = cn.conexion())
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }

                    conn.Open();

                    // Actualiza los datos del encabezado en tbl_planilla_Encabezado
                    using (OdbcCommand cmdEncabezado = new OdbcCommand(sqlEncabezado, conn))
                    {
                        cmdEncabezado.Parameters.AddWithValue("?", icorrelativo);
                        cmdEncabezado.Parameters.AddWithValue("?", dfechaInicio);
                        cmdEncabezado.Parameters.AddWithValue("?", dfechaFinal);
                        cmdEncabezado.Parameters.AddWithValue("?", iidSeleccionado);
                        cmdEncabezado.ExecuteNonQuery();
                    }

                    // Obtiene la lista de empleados para actualizar sus detalles
                    List<int> listaEmpleados = ObtenerListaEmpleados(conn);
                    foreach (var empleadoId in listaEmpleados)
                    {
                        // Recalcula las percepciones, deducciones y sueldo líquido para cada empleado
                        if (funCalcularPlanillaDetalleActualizado(iidSeleccionado, empleadoId, conn, out decimal sueldoLiquido, smesTexto))
                        {
                            detotalMes += sueldoLiquido; // Acumula el sueldo líquido en el total del mes

                            // Actualiza el detalle de planilla para el empleado en tbl_planilla_Detalle
                            ActualizarDetallePlanilla(conn, iidSeleccionado, empleadoId, sueldoLiquido, smesTexto  );
                        }
                    }

                    // Actualiza el total del mes calculado en el encabezado
                    ActualizarTotalEncabezado(conn, iidSeleccionado, detotalMes);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcActualizarEncabezado: " + ex.Message);
            }
        }

        //Este calcula y devuelve, pero no ingresa como tal

        public bool funCalcularPlanillaDetalleActualizado(int ifkIdRegistroPlanillaEncabezado, int ifkClaveEmpleado, OdbcConnection connection, out decimal sueldoLiquido, string smesTexto)
        {
            try
            {
                decimal salarioBase = funObtenerSalarioBase(connection, ifkClaveEmpleado, out int contratoId);
                decimal totalPercepciones = funObtenerTotalPercepciones(connection, ifkClaveEmpleado, smesTexto);
                decimal totalDeducciones = funObtenerTotalDeducciones(connection, ifkClaveEmpleado, smesTexto);

                sueldoLiquido = salarioBase + totalPercepciones - totalDeducciones;

                //funInsertarDetallePlanilla(connection, totalPercepciones, totalDeducciones, sueldoLiquido, ifkClaveEmpleado, contratoId, ifkIdRegistroPlanillaEncabezado);

                return true;
            }
            catch
            {
                sueldoLiquido = 0;
                return false;
            }
        }

        // Método para actualizar cada registro en tbl_planilla_Detalle
        private void ActualizarDetallePlanilla(OdbcConnection connection, int ifkIdRegistroPlanillaEncabezado, int ifkClaveEmpleado, decimal sueldoLiquido, string smesTexto)
        {
            decimal totalPercepciones = funObtenerTotalPercepciones(connection, ifkClaveEmpleado, smesTexto);
            decimal totalDeducciones = funObtenerTotalDeducciones(connection, ifkClaveEmpleado, smesTexto);

            string queryDetalle = @"
    UPDATE tbl_planilla_Detalle 
    SET detalle_total_Percepciones = ?, 
        detalle_total_Deducciones = ?, 
        detalle_total_liquido = ? 
    WHERE fk_clave_empleado = ? 
    AND fk_id_registro_planilla_Encabezado = ?";

            using (OdbcCommand cmdDetalle = new OdbcCommand(queryDetalle, connection))
            {
                cmdDetalle.Parameters.AddWithValue("?", totalPercepciones);
                cmdDetalle.Parameters.AddWithValue("?", totalDeducciones);
                cmdDetalle.Parameters.AddWithValue("?", sueldoLiquido);
                cmdDetalle.Parameters.AddWithValue("?", ifkClaveEmpleado);
                cmdDetalle.Parameters.AddWithValue("?", ifkIdRegistroPlanillaEncabezado);

                cmdDetalle.ExecuteNonQuery();
            }
        }

  
        /***************************************/


        public void funcEliminarEncabezado(int iidSeleccionado)
        {
            try
            {
                string sqlEncabezado = "UPDATE tbl_planilla_Encabezado SET estado = 0 WHERE pk_registro_planilla_Encabezado = ?";
                string sqlDetalle = "UPDATE tbl_planilla_Detalle SET estado = 0 WHERE fk_id_registro_planilla_Encabezado = ?";

                using (OdbcConnection conn = cn.conexion())
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }

                    conn.Open();

                    // Desactivar el registro en tbl_planilla_Encabezado
                    using (OdbcCommand cmdEncabezado = new OdbcCommand(sqlEncabezado, conn))
                    {
                        cmdEncabezado.Parameters.AddWithValue("?", iidSeleccionado);
                        cmdEncabezado.ExecuteNonQuery();
                    }

                    // Desactivar los registros en tbl_planilla_Detalle vinculados al encabezado
                    using (OdbcCommand cmdDetalle = new OdbcCommand(sqlDetalle, conn))
                    {
                        cmdDetalle.Parameters.AddWithValue("?", iidSeleccionado);
                        cmdDetalle.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcEliminarEncabezado: " + ex.Message);
            }
        }

        public void funcActualizarDetalle(int iidSeleccionado2, int ifkIdRegistroPlanillaEncabezado, int ifkClaveEmpleado)
        {
            try
            {
                string sql = "UPDATE tbl_planilla_Detalle SET " +
                             "fk_clave_empleado = ?, " +
                             "fk_id_registro_planilla_Encabezado = ? " + 
                             "WHERE pk_registro_planilla_Detalle = ?";

                using (OdbcConnection conn = cn.conexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", ifkClaveEmpleado);
                        cmd.Parameters.AddWithValue("?", ifkIdRegistroPlanillaEncabezado);
                        cmd.Parameters.AddWithValue("?", iidSeleccionado2);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcActualizarDetalle: " + ex.Message);
            }
        }

        public void funcEliminarDetalle(int iidSeleccionado2)
        {
            try
            {
                string sql = "UPDATE tbl_planilla_Detalle SET estado = 0 WHERE pk_registro_planilla_Detalle = ?";
                using (OdbcConnection conn = cn.conexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", iidSeleccionado2);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcEliminarDetall: " + ex.Message);
            }
        }



        public bool funCalcularPlanillaDetalleSimulado(int ifkIdRegistroPlanillaEncabezado, int ifkClaveEmpleado)
        {
            try
            {
                // Simulación de obtener valores de salario base, percepciones y deducciones
                decimal desalarioBase = funObtenerSalarioBaseSimulado(ifkClaveEmpleado, out int icontratoId);
                decimal detotalPercepciones = funObtenerTotalPercepcionesSimulado(ifkClaveEmpleado);
                decimal detotalDeducciones = funObtenerTotalDeduccionesSimulado(ifkClaveEmpleado);

                // Calculo del total líquido
                decimal detotalLiquido = desalarioBase + detotalPercepciones - detotalDeducciones;

                // Simulación de la inserción del detalle de la planilla
                funInsertarDetallePlanillaSimulado(detotalPercepciones, detotalDeducciones, detotalLiquido, ifkClaveEmpleado, icontratoId, ifkIdRegistroPlanillaEncabezado);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        private decimal funObtenerSalarioBaseSimulado(int ifkClaveEmpleado, out int icontratoId)
        {
            // Valores simulados para el salario base y el ID del contrato
            icontratoId = 1; // Simulamos que el contrato ID es 1
            decimal desalarioBase = 1000.00m; // Salario base simulado
            Console.WriteLine($"Salario base simulado: {desalarioBase} para empleado {ifkClaveEmpleado} con contrato ID {icontratoId}");
            return desalarioBase;
        }

        private decimal funObtenerTotalPercepcionesSimulado(int ifkClaveEmpleado)
        {
            // Valor simulado para el total de percepciones
            decimal detotalPercepciones = 500.00m; // Percepciones simuladas
            Console.WriteLine($"Total percepciones simulado: {detotalPercepciones} para empleado {ifkClaveEmpleado}");
            return detotalPercepciones;
        }

        private decimal funObtenerTotalDeduccionesSimulado(int ifkClaveEmpleado)
        {
            // Valor simulado para el total de deducciones
            decimal detotalDeducciones = 200.00m; // Deducciones simuladas
            Console.WriteLine($"Total deducciones simulado: {detotalDeducciones} para empleado {ifkClaveEmpleado}");
            return detotalDeducciones;
        }

        private void funInsertarDetallePlanillaSimulado(decimal detotalPercepciones, decimal detotalDeducciones, decimal detotalLiquido,
                                                        int ifkClaveEmpleado, int icontratoId, int ifkIdRegistroPlanillaEncabezado)
        {
            // Simulación de la inserción del detalle de la planilla
            Console.WriteLine("Insertando detalle de planilla simulado:");
            Console.WriteLine($"Percepciones: {detotalPercepciones}, Deducciones: {detotalDeducciones}, Total Líquido: {detotalLiquido}");
            Console.WriteLine($"Empleado ID: {ifkClaveEmpleado}, Contrato ID: {icontratoId}, Encabezado ID: {ifkIdRegistroPlanillaEncabezado}");
        }



        public bool funInsertarDeduccionPercepcion(int ifkClaveEmpleado, int ifkDeduPerp, string sMesTexto)
        {
            string queryInsert = @"
        INSERT INTO tbl_dedu_perp_emp 
        (Fk_clave_empleado, Fk_dedu_perp, dedu_perp_emp_cantidad, dedu_perp_emp_mes, estado) 
        VALUES (?, ?, ?, ?, 1)";

            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Open();

                    // Consultamos el tipo y monto de la deducción/percepción
                    string queryTipoMonto = @"
                SELECT dedu_perp_tipo, dedu_perp_monto 
                FROM tbl_dedu_perp 
                WHERE pk_dedu_perp = ?";

                    string deduPerpTipo = "";
                    decimal deduPerpMonto = 0;

                    using (OdbcCommand cmdTipoMonto = new OdbcCommand(queryTipoMonto, conn))
                    {
                        cmdTipoMonto.Parameters.AddWithValue("@pk_dedu_perp", ifkDeduPerp);
                        using (OdbcDataReader reader = cmdTipoMonto.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                deduPerpTipo = reader["dedu_perp_tipo"].ToString();
                                deduPerpMonto = Convert.ToDecimal(reader["dedu_perp_monto"]);
                            }
                        }
                    }

                    // Obtener la lista de empleados si `ifkClaveEmpleado` es "Todos", o solo el empleado específico
                    List<int> listaEmpleados = new List<int>();

                    if (ifkClaveEmpleado == 0)
                    {
                        // Query para obtener todos los empleados activos
                        string queryTodosEmpleados = "SELECT pk_clave FROM tbl_empleados WHERE estado = 1";
                        using (OdbcCommand cmdEmpleados = new OdbcCommand(queryTodosEmpleados, conn))
                        using (OdbcDataReader reader = cmdEmpleados.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaEmpleados.Add(Convert.ToInt32(reader["pk_clave"]));
                            }
                        }
                    }
                    else
                    {
                        listaEmpleados.Add(Convert.ToInt32(ifkClaveEmpleado));
                    }

                    // Procesar la inserción para cada empleado en la lista
                    foreach (int empleadoId in listaEmpleados)
                    {
                        // Calculamos dedu_perp_emp_cantidad según el tipo de deducción/percepción
                        decimal deduPerpEmpCantidad = 0;
                        if (deduPerpTipo == "Porcentaje")
                        {
                            // Consultamos el sueldo base del contrato del empleado
                            string querySueldo = @"
                        SELECT contratos_salario 
                        FROM tbl_contratos 
                        WHERE fk_clave_empleado = ? AND estado = 1";

                            using (OdbcCommand cmdSueldo = new OdbcCommand(querySueldo, conn))
                            {
                                cmdSueldo.Parameters.AddWithValue("@fk_clave_empleado", empleadoId);
                                object result = cmdSueldo.ExecuteScalar();

                                if (result != null)
                                {
                                    decimal sueldoBase = Convert.ToDecimal(result);
                                    deduPerpEmpCantidad = sueldoBase * (deduPerpMonto / 100); // Si es porcentaje, calculamos
                                }
                            }
                        }
                        else
                        {
                            deduPerpEmpCantidad = deduPerpMonto; // Si es monto fijo, lo asignamos directamente
                        }

                        // Ejecutamos la inserción en tbl_dedu_perp_emp
                        using (OdbcCommand cmdInsert = new OdbcCommand(queryInsert, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@Fk_clave_empleado", empleadoId);
                            cmdInsert.Parameters.AddWithValue("@Fk_dedu_perp", ifkDeduPerp);
                            cmdInsert.Parameters.AddWithValue("@dedu_perp_emp_cantidad", deduPerpEmpCantidad);
                            cmdInsert.Parameters.AddWithValue("@dedu_perp_emp_mes", sMesTexto);

                            cmdInsert.ExecuteNonQuery();
                        }
                    }

                    return true;
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al insertar deducción/percepción: " + ex.Message);
                return false;
            }
        }



        public void funcActualizarLogicaDeduPerp(int iidSeleccionado, int iempleado, int idedu, string mes)
        {
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Open();

                    // Consultamos el tipo y monto de la deducción/percepción
                    string queryTipoMonto = @"
                SELECT dedu_perp_tipo, dedu_perp_monto 
                FROM tbl_dedu_perp 
                WHERE pk_dedu_perp = ?";

                    string deduPerpTipo = "";
                    decimal deduPerpMonto = 0;

                    using (OdbcCommand cmdTipoMonto = new OdbcCommand(queryTipoMonto, conn))
                    {
                        cmdTipoMonto.Parameters.AddWithValue("?", idedu);
                        using (OdbcDataReader reader = cmdTipoMonto.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                deduPerpTipo = reader["dedu_perp_tipo"].ToString();
                                deduPerpMonto = Convert.ToDecimal(reader["dedu_perp_monto"]);
                            }
                        }
                    }

                    // Calculamos dedu_perp_emp_cantidad según el tipo de deducción/percepción
                    decimal deduPerpEmpCantidad = 0;
                    if (deduPerpTipo == "Porcentaje")
                    {
                        // Consultamos el sueldo base del contrato del empleado
                        string querySueldo = @"
                    SELECT contratos_salario 
                    FROM tbl_contratos 
                    WHERE fk_clave_empleado = ? AND estado = 1";

                        using (OdbcCommand cmdSueldo = new OdbcCommand(querySueldo, conn))
                        {
                            cmdSueldo.Parameters.AddWithValue("?", iempleado);
                            object result = cmdSueldo.ExecuteScalar();

                            if (result != null)
                            {
                                decimal sueldoBase = Convert.ToDecimal(result);
                                deduPerpEmpCantidad = sueldoBase * (deduPerpMonto / 100); // Si es porcentaje, calculamos
                            }
                        }
                    }
                    else
                    {
                        deduPerpEmpCantidad = deduPerpMonto; // Si es monto fijo, lo asignamos directamente
                    }

                    // Ejecutamos la actualización en tbl_dedu_perp_emp
                    string sql = "UPDATE tbl_dedu_perp_emp SET " +
                                 "Fk_clave_empleado = ?, " +
                                 "Fk_dedu_perp = ?, " +
                                 "dedu_perp_emp_cantidad = ?, " +
                                 "dedu_perp_emp_mes = ? " +
                                 "WHERE pk_dedu_perp_emp = ?";

                    using (OdbcCommand cmdUpdate = new OdbcCommand(sql, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("?", iempleado);
                        cmdUpdate.Parameters.AddWithValue("?", idedu);
                        cmdUpdate.Parameters.AddWithValue("?", deduPerpEmpCantidad);
                        cmdUpdate.Parameters.AddWithValue("?", mes);
                        cmdUpdate.Parameters.AddWithValue("?", iidSeleccionado);

                        cmdUpdate.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcActualizarLogicaDeduPerp: " + ex.Message);
            }
        }



        public void funcEliminarLogicaDeduPerp(int iidSeleccionado2)
        {
            try
            {
                string sql = "UPDATE tbl_dedu_perp_emp SET estado = 0 WHERE pk_dedu_perp_emp = ?";
                using (OdbcConnection conn = cn.conexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", iidSeleccionado2);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcEliminarDetall: " + ex.Message);
            }
        }




    }
}
