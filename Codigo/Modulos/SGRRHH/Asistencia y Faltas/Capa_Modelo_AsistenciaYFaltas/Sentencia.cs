using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_AsistenciaYFaltas
{
    public class Sentencia
    {
        Conexion cn = new Conexion();

        public void InsertarAsistencia(string idEmpleado, DateTime fecha, TimeSpan horaEntrada, TimeSpan horaSalida)
        {
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string query = "INSERT INTO tbl_asistencias (fk_id_empleado, fecha, hora_entrada, hora_salida) " +
                                   "VALUES (?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", idEmpleado);
                        cmd.Parameters.AddWithValue("?", fecha.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?", horaEntrada.ToString(@"hh\:mm"));
                        cmd.Parameters.AddWithValue("?", horaSalida.ToString(@"hh\:mm"));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar asistencia: " + ex.Message);
            }
        }


    }
}
