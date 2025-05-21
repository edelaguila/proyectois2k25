using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Liquidaciones
{
    public class Sentencias
    {
        /* ------------------------------------------- Código por Gabriela Suc ------------------------------------------- */

        Conexion con = new Conexion();

        public class Empleado
        {
            public string sClave { get; set; }
            public decimal deContratosSalario { get; set; }
        }


        // Método para obtener todos los empleados cuya fecha de baja esté en el año actual
        public DataTable funObtenerEmpleados()
        {
            DataTable empleados = new DataTable();
            using (var connection = con.conexion())
            {
                // Obtiene el año actual con la función YEAR(CURDATE()) en la consulta
                string sQuery = @"
                SELECT e.pk_clave,
                       CONCAT(e.empleados_nombre, ' ', e.empleados_apellido) as empleados_nombre
                FROM tbl_empleados e
                WHERE e.estado = 1
                AND YEAR(e.empleados_fecha_baja) = YEAR(CURDATE())"; // Filtrar por año actual
                using (var command = new OdbcCommand(sQuery, connection))
                using (var adapter = new OdbcDataAdapter(command))
                {
                    adapter.Fill(empleados);
                }
            }
            return empleados;
        }


        // Método para obtener el salario de un empleado
        public decimal meObtenerSalario(int empleadoId)
        {
            try
            {
                using (OdbcConnection conn = new Conexion().conexion())
                {
                    string sQuery = "SELECT contratos_salario FROM tbl_contratos WHERE fk_clave_empleado = ?";
                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@empleadoId", empleadoId);
                        var result = cmd.ExecuteScalar();

                        // Verifica si el resultado es nulo y retorna el salario
                        return result != null ? Convert.ToDecimal(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el salario: " + ex.Message);
            }
        }

        // Método para obtener la fecha de alta del empleado
        public DateTime? meObtenerFechaAlta(int empleadoId)
        {
            try
            {
                using (OdbcConnection conn = new Conexion().conexion())
                {
                    string sQuery = "SELECT empleados_fecha_alta FROM tbl_empleados WHERE pk_clave = ?";
                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@empleadoId", empleadoId);
                        var result = cmd.ExecuteScalar();

                        return result != null ? Convert.ToDateTime(result) : (DateTime?)null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la fecha de alta: " + ex.Message);
            }
        }

        // Método para obtener la fecha de baja del empleado
        public DateTime? meObtenerFechaBaja(int empleadoId)
        {
            try
            {
                using (OdbcConnection conn = new Conexion().conexion())
                {
                    string sQuery = "SELECT empleados_fecha_baja FROM tbl_empleados WHERE pk_clave = ?";
                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@empleadoId", empleadoId);
                        var result = cmd.ExecuteScalar();

                        return result != null ? Convert.ToDateTime(result) : (DateTime?)null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la fecha de baja: " + ex.Message);
            }
        }

        public int meCalcularDiasLaborados(int empleadoId)
        {
            DateTime? dFechaAlta = meObtenerFechaAlta(empleadoId);
            DateTime? dFechaBaja = meObtenerFechaBaja(empleadoId);

            if (!dFechaAlta.HasValue) return 0;

            DateTime dInicioAnio = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime dFinAnio = new DateTime(DateTime.Now.Year, 12, 31);  // Fin del año actual

            // Usar la fecha de baja o la fecha actual si no hay fecha de baja
            DateTime dFechaFinal = dFechaBaja.HasValue ? dFechaBaja.Value : DateTime.Now;

            // Si la fecha final es posterior al fin de año, ajustarla al fin de año
            if (dFechaFinal > dFinAnio)
            {
                dFechaFinal = dFinAnio;
            }

            // Asegurar que se cuenta desde el inicio del año
            DateTime dRangoInicio = dFechaAlta < dInicioAnio ? dInicioAnio : dFechaAlta.Value;

            // Solo contar si el rango es válido (el inicio debe ser anterior o igual a la fecha final)
            if (dRangoInicio <= dFechaFinal)
            {
                return (dFechaFinal - dRangoInicio).Days + 1;  // Sumar 1 para incluir el día de inicio
            }

            return 0;  // No hay días trabajados en el rango
        }


        // Método para calcular el aguinaldo
        public decimal meCalcularAguinaldo(int iEmpleadoId, int iDiasLaborados, decimal deSalario)
        {
            // Si los días laborados son 365 o 366, usar el cálculo completo
            if (iDiasLaborados == 365 || iDiasLaborados == 366)
            {
                decimal deMontoAguinaldo = deSalario * 12;

                // Obtener el monto del aguinaldo desde tbl_dedu_perp
                decimal deDeduccionMonto = meObtenerMontoAguinaldo();
                return deMontoAguinaldo * deDeduccionMonto;
            }
            else
            {
                // Si no es un año completo, se calcula proporcionalmente
                return (deSalario * iDiasLaborados) / 365;
            }
        }

        // Obtener el monto del aguinaldo de la tabla tbl_dedu_perp
        private decimal meObtenerMontoAguinaldo()
        {
            using (OdbcConnection conn = con.conexion())
            {
                string sQuery = "SELECT dedu_perp_monto FROM tbl_dedu_perp WHERE dedu_perp_concepto = 'Aguinaldo'";
                using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                {
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        public void meInsertarAguinaldoDeduPerpEmp(int iEmpleadoId, decimal deAguinaldo)
        {
            string sMesTexto = DateTime.Now.ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));

            try
            {
                using (OdbcConnection conn = con.conexion())
                {

                    string sQuery = "INSERT INTO tbl_dedu_perp_emp (Fk_clave_empleado, Fk_dedu_perp, dedu_perp_emp_cantidad, dedu_perp_emp_mes, estado)" +
                                   "VALUES (?, (SELECT pk_dedu_perp FROM tbl_dedu_perp WHERE dedu_perp_concepto = 'Aguinaldo' LIMIT 1),?, ?, 1)";
                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@empleadoId", iEmpleadoId);
                        cmd.Parameters.AddWithValue("@aguinaldo", deAguinaldo);
                        cmd.Parameters.AddWithValue("@mes", sMesTexto);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el aguinaldo en tbl_dedu_perp_emp: " + ex.Message);
            }
        }

        public void meInsertarAguinaldoLiquidacionTrabajadores(int iEmpleadoId, decimal deAguinaldo, int iDiasLaborados, decimal deVacaciones, decimal deBono14)
        {
            try
            {
                string sTipoOperacion = (iDiasLaborados == 365 || iDiasLaborados == 366) ? "Completa" : "Proporcional";

                using (OdbcConnection conn = con.conexion())
                {
                    string sQuery = "INSERT INTO tbl_liquidacion_trabajadores (liquidacion_aguinaldo, liquidacion_bono_14, liquidacion_vacaciones, " +
                                   "liquidacion_tipo_operacion, fk_clave_empleado, estado) " +
                                   "VALUES (?, ?, ?, ?, ?, 1)";

                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@aguinaldo", deAguinaldo);
                        cmd.Parameters.AddWithValue("@aguinaldo", deBono14);
                        cmd.Parameters.AddWithValue("@aguinaldo", deVacaciones);
                        cmd.Parameters.AddWithValue("@tipoOperacion", sTipoOperacion);
                        cmd.Parameters.AddWithValue("@empleadoId", iEmpleadoId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el aguinaldo en tbl_liquidacion_trabajadores: " + ex.Message);
            }
        }

        // Método para calcular las vacaciones
        public decimal meCalcularVacaciones(int iEmpleadoId, int iDiasLaborados, decimal deSalario)
        {
            // Si los días laborados son 365 o 366, usar el cálculo completo
            if (iDiasLaborados == 365 || iDiasLaborados == 366)
            {
                decimal deMontoVacaciones = deSalario * 12;

                // Obtener el monto de las vacaciones desde tbl_dedu_perp
                decimal deDeduccionMonto = meObtenerMontoVacaciones();
                return deMontoVacaciones * deDeduccionMonto;
            }
            else
            {
                // Si no es un año completo, se calcula proporcionalmente
                decimal deDeduccionMonto = meObtenerMontoVacaciones();
                return deSalario * (iDiasLaborados / 365m) * deDeduccionMonto;
            }
        }

        // Obtener el monto de las vacaciones de la tabla tbl_dedu_perp
        private decimal meObtenerMontoVacaciones()
        {
            using (OdbcConnection conn = con.conexion())
            {
                string sQuery = "SELECT dedu_perp_monto FROM tbl_dedu_perp WHERE dedu_perp_concepto = 'Vacaciones'";
                using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                {
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        // Insertar vacaciones en tbl_dedu_perp_emp
        public void proInsertarVacacionesDeduPerpEmp(int iEmpleadoId, decimal deVacaciones)
        {
            string sMesTexto = DateTime.Now.ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));

            try
            {
                using (OdbcConnection conn = con.conexion())
                {

                    string sQuery = "INSERT INTO tbl_dedu_perp_emp (Fk_clave_empleado, Fk_dedu_perp, dedu_perp_emp_cantidad, dedu_perp_emp_mes, estado)" +
                                   "VALUES (?, (SELECT pk_dedu_perp FROM tbl_dedu_perp WHERE dedu_perp_concepto = 'Vacaciones' LIMIT 1),?, ?, 1)";
                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@empleadoId", iEmpleadoId);
                        cmd.Parameters.AddWithValue("@vacaciones", deVacaciones);
                        cmd.Parameters.AddWithValue("@mes", sMesTexto);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar las vacaciones en tbl_dedu_perp_emp: " + ex.Message);
            }
        }


        // Método para calcular el Bono 14
        public decimal meCalcularBono14(int iEmpleadoId, decimal deSalario)
        {
            // Obtener el monto para el Bono 14
            decimal deDeduccionMonto = meObtenerMontoBono14();

            // Obtener la fecha actual
            DateTime dFechaActual = DateTime.Now;

            // Si estamos en el primer semestre (01 de enero - 30 de junio)
            if (dFechaActual.Month >= 1 && dFechaActual.Month <= 6)
            {
                // Definir las fechas de inicio y fin del primer y segundo semestre del año
                DateTime dFechaInicioSegundoSemestreAnterior = new DateTime(dFechaActual.Year - 1, 7, 1);
                DateTime dFechaFinPrimerSemestreActual = new DateTime(dFechaActual.Year, 6, 30);

                // Calcular los meses laborados entre estos dos rangos
                int iMesesLaborados = meCalcularMesesLaborados(iEmpleadoId, dFechaInicioSegundoSemestreAnterior, dFechaFinPrimerSemestreActual);

                // Fórmula para calcular Bono 14
                return deSalario * iMesesLaborados * deDeduccionMonto;
            }
            else
            {
                // Si estamos en el segundo semestre (01 de julio - 31 de diciembre)
                DateTime dFechaInicioSegundoSemestreActual = new DateTime(dFechaActual.Year, 7, 1);
                DateTime dFechaFinSegundoSemestreActual = new DateTime(dFechaActual.Year, 12, 31);

                // Calcular los meses laborados en el segundo semestre
                int iMesesLaborados = meCalcularMesesLaborados(iEmpleadoId, dFechaInicioSegundoSemestreActual, dFechaFinSegundoSemestreActual);

                // Fórmula para calcular Bono 14
                return deSalario * iMesesLaborados * deDeduccionMonto;
            }
        }

        // Obtener el monto para el Bono 14 de la tabla tbl_dedu_perp
        private decimal meObtenerMontoBono14()
        {
            using (OdbcConnection conn = con.conexion())
            {
                string sQuery = "SELECT dedu_perp_monto FROM tbl_dedu_perp WHERE dedu_perp_concepto = 'Bono 14'";
                using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                {
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        // Método para calcular los meses laborados dentro de un rango específico
        private int meCalcularMesesLaborados(int iEmpleadoId, DateTime dFechaInicio, DateTime dFechaFin)
        {
            DateTime? dFechaAlta = meObtenerFechaAlta(iEmpleadoId);
            DateTime? dFechaBaja = meObtenerFechaBaja(iEmpleadoId);

            if (dFechaAlta.HasValue)
            {
                // Asegurarse de que la fecha de inicio no sea antes de la fecha de alta
                if (dFechaInicio < dFechaAlta.Value)
                {
                    dFechaInicio = dFechaAlta.Value;
                }

                // Asegurarse de que la fecha de fin no sea después de la fecha de baja (o fecha actual si no está dada)
                if (dFechaBaja.HasValue && dFechaFin > dFechaBaja.Value)
                {
                    dFechaFin = dFechaBaja.Value;
                }

                // Contar los meses laborados entre fechaInicio y fechaFin
                int iMeses = 0;

                // Recorrer mes a mes desde fechaInicio hasta fechaFin
                while (dFechaInicio <= dFechaFin)
                {
                    iMeses++;
                    dFechaInicio = dFechaInicio.AddMonths(1);  // Avanzar al siguiente mes
                }

                return iMeses;
            }

            return 0;
        }

        public void meInsertarBono14DeduPerpEmp(int iEmpleadoId, decimal deBono14)
        {
            string sMesTexto = DateTime.Now.ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));

            try
            {
                using (OdbcConnection conn = con.conexion())
                {
                    // Consulta para insertar el Bono 14 en tbl_dedu_perp_emp

                    string sQuery = "INSERT INTO tbl_dedu_perp_emp (Fk_clave_empleado, Fk_dedu_perp, dedu_perp_emp_cantidad, dedu_perp_emp_mes, estado)" +
                                   "VALUES (?, (SELECT pk_dedu_perp FROM tbl_dedu_perp WHERE dedu_perp_concepto = 'Bono 14' LIMIT 1),?, ?, 1)";

                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        // Parámetros para la consulta
                        cmd.Parameters.AddWithValue("@empleadoId", iEmpleadoId);
                        cmd.Parameters.AddWithValue("@bono14", deBono14);
                        cmd.Parameters.AddWithValue("@mes", sMesTexto);

                        // Ejecutar la consulta para insertar el Bono 14
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el Bono 14 en tbl_dedu_perp_emp: " + ex.Message);
            }
        }

        public bool meVerificarExistenciaLiquidacion(int iEmpleadoId)
        {
            try
            {
                using (OdbcConnection conn = con.conexion())
                {
                    // Consulta para verificar si existe un registro en tbl_dedu_perp_emp para el empleado
                    //string sQuery = "SELECT COUNT(*) FROM tbl_dedu_perp_emp WHERE Fk_clave_empleado = ?";
                    string sQuery = "SELECT COUNT(*) FROM tbl_liquidacion_trabajadores WHERE Fk_clave_empleado = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@empleadoId", iEmpleadoId);

                        // Ejecutar la consulta y obtener el resultado (cuántos registros existen)
                        int iCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // Si el conteo es mayor que 0, significa que ya existe un registro
                        return iCount > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar la existencia de la liquidación: " + ex.Message);
            }
        }

        public DataTable funObtenerLiquidacionesTrabajadores()
        {
            DataTable dt = new DataTable();
            using (var connection = con.conexion())
            {
                string sQuery = "SELECT * FROM tbl_liquidacion_trabajadores";
                using (var command = new OdbcCommand(sQuery, connection))
                using (var adapter = new OdbcDataAdapter(command))
                {
                    adapter.Fill(dt); // Carga los datos en el DataTable
                }
            }
            return dt;
        }


    }
}
