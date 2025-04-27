using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace Capa_Modelo_Evaluacion
{
    public class Sentencias
    {
        private readonly Conexion cn = new Conexion();

        // Obtener lista de empleados
        public DataTable ObtenerEmpleados()
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = null;
            try
            {
                conn = cn.conexion();
                string query = "SELECT pk_clave AS IdEmpleado, CONCAT(empleados_nombre, ' ', empleados_apellido) AS NombreEmpleado FROM TBL_EMPLEADOS";
                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener empleados: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }
            return dt;
        }

        // Obtener lista de evaluadores
        public DataTable ObtenerEvaluadores()
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = null;
            try
            {
                conn = cn.conexion();
                string query = "SELECT pk_clave AS IdEvaluador, CONCAT(empleados_nombre, ' ', empleados_apellido) AS NombreEvaluador FROM TBL_EMPLEADOS";
                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener evaluadores: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }
            return dt;
        }


        // Insertar evaluación general
        public int InsertarEvaluacion(int fkEmpleado, int fkEvaluador, string tipoEvaluacion, decimal calificacion, string comentarios, DateTime fechaEvaluacion)
        {
            int idEvaluacion = -1;
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string query = @"INSERT INTO TBL_EVALUACIONES (Fk_Empleado, Fk_Evaluador, Tipo_Evaluacion, Calificacion, Comentarios, Fecha_Evaluacion)
                             VALUES (?, ?, ?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OdbcType.Int).Value = fkEmpleado;
                        cmd.Parameters.Add("?", OdbcType.Int).Value = fkEvaluador;
                        cmd.Parameters.Add("?", OdbcType.VarChar).Value = tipoEvaluacion;
                        cmd.Parameters.Add("?", OdbcType.Decimal).Value = calificacion;
                        cmd.Parameters.Add("?", OdbcType.Text).Value = comentarios;
                        cmd.Parameters.Add("?", OdbcType.Date).Value = fechaEvaluacion;

                        cmd.ExecuteNonQuery();
                    }

                    // Obtener último ID insertado de forma segura
                    string getIdQuery = "SELECT MAX(Pk_Evaluacion) FROM TBL_EVALUACIONES";
                    using (OdbcCommand getIdCmd = new OdbcCommand(getIdQuery, conn))
                    {
                        object result = getIdCmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            idEvaluacion = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar evaluación: " + ex.Message);
            }

            return idEvaluacion;
        }


        // Insertar detalles de la evaluación
        public void InsertarDetalleEvaluacion(int idEvaluacion, int idCompetencia, decimal calificacion, string comentarios)
        {
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string query = @"INSERT INTO tbl_detalle_evaluacion (fk_id_evaluacion, fk_id_competencia, calificacion, comentarios)
                             VALUES (?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OdbcType.Int).Value = idEvaluacion;
                        cmd.Parameters.Add("?", OdbcType.Int).Value = idCompetencia;
                        cmd.Parameters.Add("?", OdbcType.Decimal).Value = calificacion;
                        cmd.Parameters.Add("?", OdbcType.Text).Value = comentarios;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar detalle de evaluación: " + ex.Message);
            }
        }




    }
}
