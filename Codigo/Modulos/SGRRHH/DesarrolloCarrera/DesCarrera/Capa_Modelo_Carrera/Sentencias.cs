using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Modelo_Carrera
{
    public class Sentencias
    {
        Conexion cn = new Conexion();
        private string idUsuario;
        /*******************Ismar Leonel Cortez Sanchez  -0901-21-560*******************************************************/
        /****************************Combo box inteligente 2******************************************************************/
        public Sentencias(string idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public string[] funLlenarCmb2(string sTabla, string sCampo1, string sCampo2)
        {
            Conexion cn = new Conexion();
            string[] sCampos = new string[300];
            int iI = 0;

            string sql = "SELECT DISTINCT " + sCampo1 + "," + sCampo2 + " FROM " + sTabla;

            /* La sentencia consulta el modelo de la base de datos con cada campo */
            try
            {
                // Muestra la consulta SQL antes de ejecutarla
                Console.Write(sql);
                MessageBox.Show(sql);

                OdbcCommand command = new OdbcCommand(sql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[iI] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    iI++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + sTabla + "\n -" + sCampo1);
            }

            return sCampos;
        }


        public DataTable obtener2(string sTabla, string sCampo1, string sCampo2)
        {
            Conexion cn = new Conexion();
            string sql = "SELECT DISTINCT " + sCampo1 + "," + sCampo2 + " FROM " + sTabla;

            OdbcCommand command = new OdbcCommand(sql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }
        /****************************************************************************************************************/

        public DataRow ObtenerDatosEmpleado(string idEmpleado)
        {
            string sql = $@"
        SELECT 
            pt.puestos_nombre_puesto AS puesto,
            c.contratos_salario AS salario
        FROM tbl_empleados e
        INNER JOIN tbl_puestos_trabajo pt ON e.fk_id_puestos = pt.pk_id_puestos
        INNER JOIN tbl_contratos c ON e.pk_clave = c.fk_clave_empleado
        WHERE e.pk_clave = {idEmpleado} AND e.estado = 1 AND c.estado = 1
        ORDER BY c.pk_id_contrato DESC
        LIMIT 1;
    ";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, cn.conectar());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)
                    return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener puesto y salario: " + ex.Message);
            }

            return null;
        }

        public DataRow ObtenerDatosPuesto(string NombrePuesto)
        {
            string sql = @"
        SELECT 
            puestos_salario_rec AS salario
        FROM tbl_puestos_trabajo
        WHERE puestos_nombre_puesto = ? AND estado = 1
        LIMIT 1;
    ";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, cn.conectar());
                command.Parameters.AddWithValue("@puesto", NombrePuesto); // Aunque el placeholder es ?, este valor se asocia por orden
                OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)
                    return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al salario: " + ex.Message);
            }

            return null;
        }

        public OdbcDataAdapter funcConsultaPromociones()
        {
            try
            {
                string sql = "SELECT " +
                             "p.pk_id_promocion AS ID, " +
                             "e.empleados_nombre AS Empleado, " +
                             "p.promociones_fecha AS Fecha, " +
                             "p.promociones_puesto_actual AS PuestoActual, " +
                             "p.promociones_salario_actual AS SalarioActual, " +
                             "p.promociones_nuevo_puesto AS NuevoPuesto, " +
                             "p.promociones_nuevo_salario AS NuevoSalario, " +
                             "p.promociones_motivo AS Motivo, " +
                             "p.estado AS Estado " +
                             "FROM tbl_promociones p " +
                             "INNER JOIN tbl_empleados e ON p.fk_clave_empleado = e.pk_clave " +
                             "WHERE p.estado = 1 OR p.estado=0";

                return new OdbcDataAdapter(sql, cn.conectar());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcConsultaPromociones: " + ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter funcConsultaNomina(int idEmpleado)
        {
            try
            {
                string sql = "SELECT pd.*, pe.encabezado_fecha_inicio, pe.encabezado_fecha_final " +
                             "FROM tbl_planilla_detalle pd " +
                             "JOIN tbl_planilla_encabezado pe ON pd.fk_id_registro_planilla_Encabezado = pe.pk_registro_planilla_Encabezado " +
                             "WHERE pd.fk_clave_empleado = ? AND pd.estado = 1";

                OdbcCommand cmd = new OdbcCommand(sql, cn.conectar());
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                return new OdbcDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcConsultaNomina: " + ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter funcConsultaReclutamiento(int idEmpleado)
        {
            try
            {
                string sql = "SELECT " +
                             "ats.*, " +
                             "p.nombre_postulante, " +
                             "p.apellido_postulante, " +
                             "s.nombre_status " +
                             "FROM tbl_empleados e " +
                             "JOIN tbl_puestos_trabajo pt ON e.fk_id_puestos = pt.pk_id_puestos " +
                             "JOIN tbl_postulante p ON p.Fk_puesto_aplica_postulante = pt.pk_id_puestos " +
                             "JOIN tbl_ats ats ON ats.Fk_id_postulantes = p.Pk_id_postulante " +
                             "JOIN tbl_status_ats s ON ats.Fk_id_status = s.Pk_id_status " +
                             "WHERE e.pk_clave = ? AND ats.estado = 1";

                OdbcCommand cmd = new OdbcCommand(sql, cn.conectar());
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                return new OdbcDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcConsultaReclutamiento: " + ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter funcConsultaCapacitaciones(int idEmpleado)
        {
            try
            {
                string sql = "SELECT " +
                             "c.capacitaciones_nombre, " +
                             "c.capacitaciones_fecha, " +
                             "n.notas_puntaje " +
                             "FROM tbl_notas n " +
                             "JOIN tbl_capacitaciones c ON n.fk_id_capacitacion = c.pk_id_capacitacion " +
                             "WHERE n.fk_id_empleado = ? AND n.estado = 1";

                OdbcCommand cmd = new OdbcCommand(sql, cn.conectar());
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                return new OdbcDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcConsultaCapacitaciones: " + ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter funcConsultaDesempeno(int idEmpleado)
        {
            try
            {
                string sql = "SELECT " +
                             "e.*, " +
                             "d.calificacion AS calificacion_por_competencia, " +
                             "comp.nombre_competencia " +
                             "FROM tbl_evaluaciones e " +
                             "LEFT JOIN tbl_detalle_evaluacion d ON e.pk_id_evaluacion = d.fk_id_evaluacion " +
                             "LEFT JOIN tbl_competencias comp ON d.fk_id_competencia = comp.Pk_id_competencia " +
                             "WHERE e.fk_clave_empleado = ? AND e.estado = 1";

                OdbcCommand cmd = new OdbcCommand(sql, cn.conectar());
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                return new OdbcDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcConsultaDesempeno: " + ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter funcConsultaDisciplinaria(int idEmpleado)
        {
            try
            {
                string sql = "SELECT " +
                             "s.*, " +
                             "f.falta_fecha, " +
                             "f.falta_descripcion, " +
                             "g.gravedad " +
                             "FROM tbl_sanciones s " +
                             "JOIN tbl_faltas_disciplinarias f ON s.fk_id_falta = f.pk_id_falta " +
                             "JOIN tbl_gravedad_faltas g ON f.fk_id_gravedad = g.pk_id_gravedad " +
                             "WHERE f.fk_clave_empleado = ? AND s.estado = 1";

                OdbcCommand cmd = new OdbcCommand(sql, cn.conectar());
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                return new OdbcDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcConsultaDisciplinaria: " + ex.Message);
                return null;
            }
        }




        //public void funcInsertarPromocion(string empleado, string fecha, string puestoactual, string salarioactual, string puestonuevo, string salarionuevo, string motivo)
        //{
        //    OdbcConnection conn = null;
        //    try
        //    {
        //        string sql = "INSERT INTO tbl_promociones (fk_clave_empleado, promociones_fecha, promociones_puesto_actual, promociones_salario_actual, promociones_nuevo_puesto, promociones_nuevo_salario, promociones_motivo, estado) " +
        //                     "VALUES (?, ?, ?, ?, ?, ?, ?, 1)";

        //        conn = cn.conectar();
        //        if (conn.State != ConnectionState.Open)
        //        {
        //            conn.Open();
        //        }

        //        using (OdbcCommand cmd = new OdbcCommand(sql, conn))
        //        {
        //            // Agregar los parámetros en el orden de la consulta
        //            cmd.Parameters.Add("fk_clave_empleado", OdbcType.Int).Value = Convert.ToInt32(empleado);
        //            cmd.Parameters.Add("promociones_fecha", OdbcType.Date).Value = DateTime.Parse(fecha);
        //            cmd.Parameters.Add("promociones_puesto_actual", OdbcType.VarChar).Value = puestoactual;
        //            cmd.Parameters.Add("promociones_salario_actual", OdbcType.Decimal).Value = Convert.ToDecimal(salarioactual);
        //            cmd.Parameters.Add("promociones_nuevo_puesto", OdbcType.VarChar).Value = puestonuevo;
        //            cmd.Parameters.Add("promociones_nuevo_salario", OdbcType.Decimal).Value = Convert.ToDecimal(salarionuevo);
        //            cmd.Parameters.Add("promociones_motivo", OdbcType.VarChar).Value = motivo;

        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas <= 0)
        //            {
        //                throw new Exception("No se pudo insertar el registro de promoción.");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string mensaje = "Error en funcInsertarPromocion: " + ex.Message;
        //        Console.WriteLine(mensaje);
        //        throw new Exception(mensaje);
        //    }
        //    finally
        //    {
        //        if (conn != null && conn.State == ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

        //public void funcInsertarPromocion(string empleado, DateTime fecha, string puestoactual, string salarioactual, string puestonuevo, string salarionuevo, string motivo)
        //{
        //    OdbcConnection conn = null;
        //    try
        //    {
        //        string sql = "INSERT INTO tbl_promociones (fk_clave_empleado, promociones_fecha, promociones_puesto_actual, promociones_salario_actual, promociones_nuevo_puesto, promociones_nuevo_salario, promociones_motivo, estado) " +
        //                     "VALUES (?, ?, ?, ?, ?, ?, ?, 1)";

        //        conn = cn.conectar();
        //        if (conn.State != ConnectionState.Open)
        //        {
        //            conn.Open();
        //        }

        //        // Log de los valores que se intentan insertar
        //        Console.WriteLine($"Valores a insertar: Empleado: {empleado}, Fecha: {fecha}, PuestoActual: {puestoactual}, SalarioActual: {salarioactual}, PuestoNuevo: {puestonuevo}, SalarioNuevo: {salarionuevo}, Motivo: {motivo}");

        //        using (OdbcCommand cmd = new OdbcCommand(sql, conn))
        //        {
        //            cmd.Parameters.Add("fk_clave_empleado", OdbcType.Int).Value = Convert.ToInt32(empleado);
        //            cmd.Parameters.Add("promociones_fecha", OdbcType.Date).Value = DateTime.Parse(fecha);
        //            cmd.Parameters.Add("promociones_puesto_actual", OdbcType.VarChar).Value = puestoactual;
        //            cmd.Parameters.Add("promociones_salario_actual", OdbcType.Decimal).Value = Convert.ToDecimal(salarioactual);
        //            cmd.Parameters.Add("promociones_nuevo_puesto", OdbcType.VarChar).Value = puestonuevo;
        //            cmd.Parameters.Add("promociones_nuevo_salario", OdbcType.Decimal).Value = Convert.ToDecimal(salarionuevo);
        //            cmd.Parameters.Add("promociones_motivo", OdbcType.VarChar).Value = motivo;

        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas <= 0)
        //            {
        //                throw new Exception("No se pudo insertar el registro de promoción.");
        //            }
        //        }
        //    }
        //    catch (OdbcException odbcEx)
        //    {
        //        // Captura específicamente errores ODBC
        //        string mensaje = $"Error ODBC en funcInsertarPromocion: {odbcEx.Message}";
        //        Console.WriteLine(mensaje);
        //        Console.WriteLine($"Código de error: {odbcEx.ErrorCode}");
        //        //Console.WriteLine($"SQL State: {odbcEx.State}");
        //        throw new Exception(mensaje);
        //    }
        //    catch (Exception ex)
        //    {
        //        string mensaje = $"Error en funcInsertarPromocion: {ex.Message}";
        //        Console.WriteLine(mensaje);
        //        throw new Exception(mensaje);
        //    }
        //    finally
        //    {
        //        if (conn != null && conn.State == ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

        //public bool funcInsertarPromocion(int empleado, DateTime fecha, string puestoactual, string salarioactual, string puestonuevo, string salarionuevo, string motivo)
        //{
        //    string query = "INSERT INTO tbl_promociones (fk_clave_empleado, promociones_fecha, promociones_puesto_actual, promociones_salario_actual, promociones_nuevo_puesto, promociones_nuevo_salario, promociones_motivo, estado) " +
        //                   "VALUES (?, ?, ?, ?, ?, ?, ?, 1)";

        //    try
        //    {
        //        using (OdbcConnection conn = cn.conectar())
        //        {
        //            if (conn.State != ConnectionState.Open)
        //            {
        //                conn.Open();
        //            }

        //            using (OdbcCommand command = new OdbcCommand(query, conn))
        //            {
        //                // Agregar parámetros con valores correctos
        //                //command.Parameters.AddWithValue("@correlativoPlanilla", icorrelativoPlanilla);
        //                //command.Parameters.AddWithValue("@fechaInicio", dfechaInicio);
        //                //command.Parameters.AddWithValue("@fechaFinal", dfechaFinal);
        //                //command.Parameters.AddWithValue("@totalMes", detotalMes);

        //                command.Parameters.AddWithValue("@fk_clave_empleado", empleado);
        //                command.Parameters.AddWithValue("@promociones_fecha", fecha);  // Usando DateTime directamente
        //                command.Parameters.AddWithValue("@promociones_puesto_actual", puestoactual);
        //                command.Parameters.AddWithValue("@promociones_salario_actual", salarioactual);
        //                command.Parameters.AddWithValue("@promociones_nuevo_puesto",puestonuevo);
        //                command.Parameters.AddWithValue("@promociones_nuevo_salario", salarionuevo);
        //                command.Parameters.AddWithValue("@promociones_motivo", motivo);

        //                // Ejecutar la consulta
        //                int filasAfectadas = command.ExecuteNonQuery();
        //                if (filasAfectadas <= 0)
        //                {
        //                    throw new Exception("No se pudo insertar el registro de promoción.");
        //                }
        //            }

        //            return true; // Si todo salió bien
        //        }
        //    }
        //    catch (OdbcException ex)
        //    {
        //        Console.WriteLine("Error al insertar promoción: " + ex.Message);
        //        return false;  // Devolvemos false si ocurrió un error en la base de datos
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error general: " + ex.Message);
        //        return false;  // Devolvemos false si ocurrió un error genérico
        //    }
        //}

        //public bool funcInsertarPromocion(int empleado, DateTime fecha, string puestoactual, string salarioactual, string puestonuevo, string salarionuevo, string motivo)
        //{
        //    string queryPromocion = "INSERT INTO tbl_promociones (fk_clave_empleado, promociones_fecha, promociones_puesto_actual, promociones_salario_actual, promociones_nuevo_puesto, promociones_nuevo_salario, promociones_motivo, estado) " +
        //                            "VALUES (?, ?, ?, ?, ?, ?, ?, 1)";

        //    string queryAnularContrato = "UPDATE tbl_contratos SET estado = 0 WHERE fk_clave_empleado = ? AND estado = 1";

        //    string queryNuevoContrato = "INSERT INTO tbl_contratos (contratos_fecha_creacion, contratos_salario, contratos_tipo_contrato, fk_clave_empleado, estado) " +
        //                                "VALUES (?, ?, ?, ?, 1)";

        //    try
        //    {
        //        using (OdbcConnection conn = cn.conectar())
        //        {
        //            if (conn.State != ConnectionState.Open)
        //            {
        //                conn.Open();
        //            }

        //            using (OdbcTransaction transaccion = conn.BeginTransaction())
        //            {
        //                try
        //                {
        //                    // Insertar la promoción
        //                    using (OdbcCommand cmdPromocion = new OdbcCommand(queryPromocion, conn, transaccion))
        //                    {
        //                        cmdPromocion.Parameters.AddWithValue("@fk_clave_empleado", empleado);
        //                        cmdPromocion.Parameters.AddWithValue("@promociones_fecha", fecha);
        //                        cmdPromocion.Parameters.AddWithValue("@promociones_puesto_actual", puestoactual);
        //                        cmdPromocion.Parameters.AddWithValue("@promociones_salario_actual", salarioactual);
        //                        cmdPromocion.Parameters.AddWithValue("@promociones_nuevo_puesto", puestonuevo);
        //                        cmdPromocion.Parameters.AddWithValue("@promociones_nuevo_salario", salarionuevo);
        //                        cmdPromocion.Parameters.AddWithValue("@promociones_motivo", motivo);

        //                        if (cmdPromocion.ExecuteNonQuery() <= 0)
        //                        {
        //                            throw new Exception("No se pudo insertar el registro de promoción.");
        //                        }
        //                    }

        //                    // Anular contrato anterior
        //                    using (OdbcCommand cmdAnular = new OdbcCommand(queryAnularContrato, conn, transaccion))
        //                    {
        //                        cmdAnular.Parameters.AddWithValue("@fk_clave_empleado", empleado);
        //                        cmdAnular.ExecuteNonQuery();
        //                    }

        //                    // Insertar nuevo contrato
        //                    using (OdbcCommand cmdNuevoContrato = new OdbcCommand(queryNuevoContrato, conn, transaccion))
        //                    {
        //                        cmdNuevoContrato.Parameters.AddWithValue("@contratos_fecha_creacion", DateTime.Now.Date);
        //                        cmdNuevoContrato.Parameters.AddWithValue("@contratos_salario", Convert.ToDecimal(salarionuevo));
        //                        cmdNuevoContrato.Parameters.AddWithValue("@contratos_tipo_contrato", "Permanente");
        //                        cmdNuevoContrato.Parameters.AddWithValue("@fk_clave_empleado", empleado);

        //                        cmdNuevoContrato.ExecuteNonQuery();
        //                    }

        //                    transaccion.Commit();
        //                    return true;
        //                }
        //                catch (Exception exTransaccion)
        //                {
        //                    transaccion.Rollback();
        //                    Console.WriteLine("Error durante la transacción: " + exTransaccion.Message);
        //                    return false;
        //                }
        //            }
        //        }
        //    }
        //    catch (OdbcException ex)
        //    {
        //        Console.WriteLine("Error ODBC: " + ex.Message);
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error general: " + ex.Message);
        //        return false;
        //    }
        //}

        public bool funcInsertarPromocion(int empleado, DateTime fecha, string puestoactual, string salarioactual, string puestonuevo, string salarionuevo, string motivo)
        {
            string queryPromocion = "INSERT INTO tbl_promociones (fk_clave_empleado, promociones_fecha, promociones_puesto_actual, promociones_salario_actual, promociones_nuevo_puesto, promociones_nuevo_salario, promociones_motivo, estado) " +
                                    "VALUES (?, ?, ?, ?, ?, ?, ?, 1)";

            string queryAnularContrato = "UPDATE tbl_contratos SET estado = 0 WHERE fk_clave_empleado = ? AND estado = 1";

            string queryNuevoContrato = "INSERT INTO tbl_contratos (contratos_fecha_creacion, contratos_salario, contratos_tipo_contrato, fk_clave_empleado, estado) " +
                                        "VALUES (?, ?, ?, ?, 1)";

            string queryObtenerIdPuesto = "SELECT pk_id_puestos FROM tbl_puestos_trabajo WHERE puestos_nombre_puesto = ? AND estado = 1";

            string queryActualizarPuesto = "UPDATE tbl_empleados SET fk_id_puestos = ? WHERE pk_clave = ?";

            try
            {
                using (OdbcConnection conn = cn.conectar())
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    using (OdbcTransaction transaccion = conn.BeginTransaction())
                    {
                        try
                        {
                            // Obtener ID del nuevo puesto por nombre
                            int nuevoIdPuesto;
                            using (OdbcCommand cmdGetIdPuesto = new OdbcCommand(queryObtenerIdPuesto, conn, transaccion))
                            {
                                cmdGetIdPuesto.Parameters.AddWithValue("@puestos_nombre", puestonuevo);
                                object result = cmdGetIdPuesto.ExecuteScalar();
                                if (result == null)
                                    throw new Exception("No se encontró el puesto con nombre: " + puestonuevo);

                                nuevoIdPuesto = Convert.ToInt32(result);
                            }

                            // Insertar promoción
                            using (OdbcCommand cmdPromocion = new OdbcCommand(queryPromocion, conn, transaccion))
                            {
                                cmdPromocion.Parameters.AddWithValue("@fk_clave_empleado", empleado);
                                cmdPromocion.Parameters.AddWithValue("@promociones_fecha", fecha);
                                cmdPromocion.Parameters.AddWithValue("@promociones_puesto_actual", puestoactual);
                                cmdPromocion.Parameters.AddWithValue("@promociones_salario_actual", salarioactual);
                                cmdPromocion.Parameters.AddWithValue("@promociones_nuevo_puesto", puestonuevo);
                                cmdPromocion.Parameters.AddWithValue("@promociones_nuevo_salario", salarionuevo);
                                cmdPromocion.Parameters.AddWithValue("@promociones_motivo", motivo);

                                if (cmdPromocion.ExecuteNonQuery() <= 0)
                                    throw new Exception("No se pudo insertar el registro de promoción.");
                            }

                            // Anular contrato anterior
                            using (OdbcCommand cmdAnular = new OdbcCommand(queryAnularContrato, conn, transaccion))
                            {
                                cmdAnular.Parameters.AddWithValue("@fk_clave_empleado", empleado);
                                cmdAnular.ExecuteNonQuery();
                            }

                            // Insertar nuevo contrato
                            using (OdbcCommand cmdNuevoContrato = new OdbcCommand(queryNuevoContrato, conn, transaccion))
                            {
                                cmdNuevoContrato.Parameters.AddWithValue("@contratos_fecha_creacion", DateTime.Now.Date);
                                cmdNuevoContrato.Parameters.AddWithValue("@contratos_salario", Convert.ToDecimal(salarionuevo));
                                cmdNuevoContrato.Parameters.AddWithValue("@contratos_tipo_contrato", "Permanente");
                                cmdNuevoContrato.Parameters.AddWithValue("@fk_clave_empleado", empleado);
                                cmdNuevoContrato.ExecuteNonQuery();
                            }

                            // Actualizar fk_id_puestos del empleado
                            using (OdbcCommand cmdActualizarPuesto = new OdbcCommand(queryActualizarPuesto, conn, transaccion))
                            {
                                cmdActualizarPuesto.Parameters.AddWithValue("@fk_id_puestos", nuevoIdPuesto);
                                cmdActualizarPuesto.Parameters.AddWithValue("@pk_clave", empleado);
                                cmdActualizarPuesto.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                            return true;
                        }
                        catch (Exception exTransaccion)
                        {
                            transaccion.Rollback();
                            Console.WriteLine("Error en transacción: " + exTransaccion.Message);
                            return false;
                        }
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error ODBC: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                return false;
            }
        }

        /*******************************************************************************/
        public bool funcEliminarPromocion(int idPromocion)
        {
            string queryDatosPromocion = "SELECT fk_clave_empleado, promociones_puesto_actual FROM tbl_promociones WHERE pk_id_promocion = ? AND estado = 1";

            string queryDesactivarContratoNuevo = "UPDATE tbl_contratos SET estado = 0 WHERE fk_clave_empleado = ? AND estado = 1";

            string queryActivarContratoAnterior = "UPDATE tbl_contratos SET estado = 1 WHERE fk_clave_empleado = ? AND estado = 0 ORDER BY contratos_fecha_creacion DESC LIMIT 1";

            string queryObtenerIdPuesto = "SELECT pk_id_puestos FROM tbl_puestos_trabajo WHERE puestos_nombre_puesto = ? AND estado = 1";

            string queryActualizarPuestoEmpleado = "UPDATE tbl_empleados SET fk_id_puestos = ? WHERE pk_clave = ?";

            string queryDesactivarPromocion = "UPDATE tbl_promociones SET estado = 0 WHERE pk_id_promocion = ?";

            try
            {
                using (OdbcConnection conn = cn.conectar())
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    using (OdbcTransaction transaccion = conn.BeginTransaction())
                    {
                        try
                        {
                            int idEmpleado = 0;
                            string puestoAnterior = "";

                            // Obtener datos de la promoción
                            using (OdbcCommand cmdDatos = new OdbcCommand(queryDatosPromocion, conn, transaccion))
                            {
                                cmdDatos.Parameters.AddWithValue("", idPromocion);
                                using (OdbcDataReader reader = cmdDatos.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        idEmpleado = reader.GetInt32(0);
                                        puestoAnterior = reader.GetString(1);
                                    }
                                    else
                                    {
                                        throw new Exception("No se encontró la promoción activa con el ID proporcionado.");
                                    }
                                }
                            }

                            // Obtener ID del puesto anterior
                            int idPuestoAnterior;
                            using (OdbcCommand cmdIdPuesto = new OdbcCommand(queryObtenerIdPuesto, conn, transaccion))
                            {
                                cmdIdPuesto.Parameters.AddWithValue("", puestoAnterior);
                                object result = cmdIdPuesto.ExecuteScalar();
                                if (result == null)
                                    throw new Exception("No se encontró el ID del puesto anterior.");

                                idPuestoAnterior = Convert.ToInt32(result);
                            }

                            // Desactivar contrato actual (nuevo)
                            using (OdbcCommand cmdDesactivar = new OdbcCommand(queryDesactivarContratoNuevo, conn, transaccion))
                            {
                                cmdDesactivar.Parameters.AddWithValue("", idEmpleado);
                                cmdDesactivar.ExecuteNonQuery();
                            }

                            // Reactivar contrato anterior
                            using (OdbcCommand cmdReactivar = new OdbcCommand(queryActivarContratoAnterior, conn, transaccion))
                            {
                                cmdReactivar.Parameters.AddWithValue("", idEmpleado);
                                cmdReactivar.ExecuteNonQuery();
                            }

                            // Actualizar el puesto del empleado
                            using (OdbcCommand cmdActualizar = new OdbcCommand(queryActualizarPuestoEmpleado, conn, transaccion))
                            {
                                cmdActualizar.Parameters.AddWithValue("", idPuestoAnterior);
                                cmdActualizar.Parameters.AddWithValue("", idEmpleado);
                                cmdActualizar.ExecuteNonQuery();
                            }

                            // Desactivar promoción
                            using (OdbcCommand cmdDesactPromo = new OdbcCommand(queryDesactivarPromocion, conn, transaccion))
                            {
                                cmdDesactPromo.Parameters.AddWithValue("", idPromocion);
                                cmdDesactPromo.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            Console.WriteLine("Error al revertir promoción: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al eliminar promoción: " + ex.Message);
                return false;
            }
        }




    }
}
