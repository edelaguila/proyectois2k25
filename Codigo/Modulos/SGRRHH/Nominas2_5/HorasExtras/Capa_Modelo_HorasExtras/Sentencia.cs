using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Odbc;
using System.Windows.Forms;

using Capa_Modelo_Seguridad;

namespace Capa_Modelo_HorasExtras
{


    public class Sentencia
    {

        private Conexion cn = new Conexion();//conexion con la BD

        public string sIdUsuario { get; set; }// para bitacora 

        //*******************************Kateryn De Leon************************************************
        public List<string> funObtenerEmpleados()
        {
            List<string> sEmpleados = new List<string>();

            try
            {
                // Utilizar using para manejar la apertura y cierre de la conexión automáticamente
                using (var connection = cn.conectar())
                {
                    string sQuery = "SELECT empleados_nombre FROM tbl_empleados WHERE estado = 1;";

                    using (var command = new OdbcCommand(sQuery, connection))
                    {
                        // Ejecutar directamente sin abrir explícitamente la conexión
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sEmpleados.Add(reader.GetString(0));
                            }
                        } // El bloque using se encarga de liberar command automáticamente
                    } // El bloque using se encarga de liberar connection automáticamente
                }
            }
            catch (Exception ex)
            {
                // Muestra el mensaje de error para depuración
                MessageBox.Show($"Error en funObtenerEmpleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sEmpleados;
        }



        public List<string> funObtenerMesesPorEmpleado(string nombreEmpleado)
        {
            List<string> sMeses = new List<string>();
            try
            {
                // Usar using para manejar la apertura y cierre de la conexión automáticamente
                using (var connection = cn.conectar())
            {
                string sQuery = @"
            SELECT DISTINCT h.horas_mes
            FROM tbl_horas_extra h
            INNER JOIN tbl_empleados e ON e.pk_clave = h.fk_clave_empleado
            WHERE e.empleados_nombre = ? AND h.estado = 1;";

                using (var command = new OdbcCommand(sQuery, connection))
                {
                    // Añadir el parámetro directamente sin abrir la conexión manualmente
                    command.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sMeses.Add(reader.GetString(0));
                        }
                    }
                }
            } // El bloque using se encarga de cerrar connection automáticamente
            }
            catch (Exception ex)
            {
                // Muestra el mensaje de error para depuración
                MessageBox.Show($"Error en funObtenerMesesPorEmpleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sMeses;
        }

        // Calcular horas extras para un empleado y mes específico y guardar el cálculo
        public decimal funCalcularHorasExtrasEmpleadoMes(string sNombreEmpleado, string sMes)
        {
            decimal deTotalHorasExtras = 0;

            try
            {
                using (var connection = cn.conectar())
                {
                    string sQuery = @"
            SELECT e.pk_clave, c.contratos_salario, h.horas_cantidad_horas
            FROM tbl_horas_extra h
            INNER JOIN tbl_empleados e ON e.pk_clave = h.fk_clave_empleado
            INNER JOIN tbl_contratos c ON e.pk_clave = c.fk_clave_empleado
            WHERE e.empleados_nombre = ? AND h.horas_mes = ?;";

                    using (var command = new OdbcCommand(sQuery, connection))
                    {
                        command.Parameters.AddWithValue("@nombreEmpleado", sNombreEmpleado);
                        command.Parameters.AddWithValue("@mes", sMes);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int iFkClaveEmpleado = reader.GetInt32(0);    // Clave del empleado
                                decimal deSalario = reader.GetDecimal(1);      // Salario del empleado
                                decimal deCantidadHoras = reader.GetDecimal(2); // Cantidad de horas extras

                                // Calcular el pago por las horas extras
                                decimal dePagoHoraExtra = (deSalario / 30 / 8) * 1.5m * deCantidadHoras;

                                // Sumar al total de horas extras
                                deTotalHorasExtras += dePagoHoraExtra;

                                // Guardar el cálculo de horas extras en la tabla correspondiente
                                proGuardarHorasExtrasEmpleado(connection, iFkClaveEmpleado, dePagoHoraExtra, sMes);
                            }
                        }
                    }
                } // using asegura que la conexión principal se cierre automáticamente

                // Mostrar el mensaje con el total de horas extras
                MessageBox.Show($"El total de horas extras para {sNombreEmpleado} en {sMes} es: Q{deTotalHorasExtras:F2}", "Total Horas Extras", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Muestra el mensaje de error para depuración
                MessageBox.Show($"Error en funCalcularHorasExtrasEmpleadoMes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return deTotalHorasExtras;
        }

        //**********************
        private void proGuardarHorasExtrasEmpleado(OdbcConnection connection, int iFkClaveEmpleado, decimal dePagoHoraExtra, string sMes)
        {
            // consulta donde inserta el regirto en la tbl_dedu_perp_emp pero verifica que el concepto de horas extras en la tbl_dedu_perp exista ya que es fk de la tbl_dedu_perp_emp
            try
            {
                // Consulta donde inserta el registro en la tbl_dedu_perp_emp
                string sQueryInsertUpdate = @"
        INSERT INTO tbl_dedu_perp_emp (Fk_clave_empleado, Fk_dedu_perp, dedu_perp_emp_cantidad, dedu_perp_emp_mes, estado)
        VALUES (?, (SELECT pk_dedu_perp FROM tbl_dedu_perp WHERE dedu_perp_concepto = 'Horas Extras' LIMIT 1), ?, ?, 1) 
        ON DUPLICATE KEY UPDATE 
            dedu_perp_emp_cantidad = VALUES(dedu_perp_emp_cantidad), 
            dedu_perp_emp_mes = VALUES(dedu_perp_emp_mes), 
            estado = VALUES(estado);";

                using (var command = new OdbcCommand(sQueryInsertUpdate, connection))
                {
                    command.Parameters.AddWithValue("@Fk_clave_empleado", iFkClaveEmpleado);
                    command.Parameters.AddWithValue("@dedu_perp_emp_cantidad", dePagoHoraExtra);
                    command.Parameters.AddWithValue("@dedu_perp_emp_mes", sMes);

                    command.ExecuteNonQuery();
                }

                // Crear instancia de la clase Sentencia en Capa_modelo_seguridad
                var bitacora = new Capa_Modelo_Seguridad.sentencia();

                // Llama a la función de bitácora
                bitacora.funInsertarBitacora(sIdUsuario, "Realizó una inserción a la tabla tbl_dedu_perp_emp", "tbl_dedu_perp_emp", "6006");
            }
            catch (Exception ex)
            {
                // Muestra el mensaje de error para depuración
                MessageBox.Show($"Error en proGuardarHorasExtrasEmpleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
