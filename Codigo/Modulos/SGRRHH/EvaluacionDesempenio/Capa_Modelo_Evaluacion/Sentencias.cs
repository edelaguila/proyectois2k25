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

        //public int InsertarEvaluacion(int fkEmpleado, int fkEvaluador, string tipoEvaluacion, decimal calificacion, string comentarios, DateTime fechaEvaluacion)
        //{
        //    int idEvaluacion = -1;
        //    OdbcConnection conn = null;

        //    try
        //    {
        //        conn = cn.conexion();
        //        if (conn.State != ConnectionState.Open)
        //        {
        //            conn.Open();
        //        }

        //        string query = @"INSERT INTO TBL_EVALUACIONES 
        //                (fk_clave_empleado, fk_evaluador, tipo_evaluacion, calificacion, comentarios, fecha_evaluacion, estado)
        //                VALUES (?, ?, ?, ?, ?, ?, ?)";

        //        using (OdbcCommand cmd = new OdbcCommand(query, conn))
        //        {
        //            cmd.Parameters.Add("?", OdbcType.Int).Value = fkEmpleado;
        //            cmd.Parameters.Add("?", OdbcType.Int).Value = fkEvaluador;
        //            cmd.Parameters.Add("?", OdbcType.VarChar).Value = tipoEvaluacion;
        //            cmd.Parameters.Add("?", OdbcType.Decimal).Value = calificacion;
        //            cmd.Parameters.Add("?", OdbcType.Text).Value = comentarios;
        //            cmd.Parameters.Add("?", OdbcType.DateTime).Value = fechaEvaluacion;
        //            cmd.Parameters.Add("?", OdbcType.TinyInt).Value = 1; // estado



        //            cmd.ExecuteNonQuery();
        //        }

        //        // Obtener el último ID insertado
        //        string getIdQuery = "SELECT LAST_INSERT_ID()";
        //        using (OdbcCommand getIdCmd = new OdbcCommand(getIdQuery, conn))
        //        {
        //            object result = getIdCmd.ExecuteScalar();
        //            if (result != null && result != DBNull.Value)
        //            {
        //                idEvaluacion = Convert.ToInt32(result);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error al insertar evaluación: " + ex.Message);
        //    }
        //    finally
        //    {
        //        if (conn != null && conn.State == ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }
        //    }

        //    return idEvaluacion;
        //}

        public int InsertarEvaluacion(int fkEmpleado, int fkEvaluador, string tipoEvaluacion, decimal calificacion, string comentarios, DateTime fechaEvaluacion)
        {
            int idEvaluacion = -1;
            OdbcConnection conn = null;

            try
            {
                conn = cn.conexion();
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = @"INSERT INTO TBL_EVALUACIONES 
                (fk_clave_empleado, fk_evaluador, tipo_evaluacion, calificacion, comentarios, fecha_evaluacion, estado)
                VALUES (?, ?, ?, ?, ?, ?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    // Validaciones básicas
                    if (string.IsNullOrEmpty(comentarios))
                        comentarios = "";

                    if (fechaEvaluacion == DateTime.MinValue)
                        fechaEvaluacion = DateTime.Now;

                    // Parámetros
                    cmd.Parameters.Add("?", OdbcType.Int).Value = fkEmpleado;
                    cmd.Parameters.Add("?", OdbcType.Int).Value = fkEvaluador;
                    cmd.Parameters.Add("?", OdbcType.VarChar).Value = tipoEvaluacion;
                    cmd.Parameters.Add("?", OdbcType.Double).Value = Convert.ToDouble(calificacion);
                    cmd.Parameters.Add("?", OdbcType.Text).Value = comentarios;
                    cmd.Parameters.Add("?", OdbcType.DateTime).Value = fechaEvaluacion;
                    cmd.Parameters.Add("?", OdbcType.TinyInt).Value = 1;

                    // Log
                    Console.WriteLine("📝 Ejecutando inserción...");

                    cmd.ExecuteNonQuery();
                }

                // Obtener ID
                string getIdQuery = "SELECT LAST_INSERT_ID()";
                using (OdbcCommand getIdCmd = new OdbcCommand(getIdQuery, conn))
                {
                    object result = getIdCmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        idEvaluacion = Convert.ToInt32(result);
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("❌ ODBC Exception al insertar evaluación:");
                foreach (OdbcError error in ex.Errors)
                {
                    Console.WriteLine($"-> {error.Message} (SQL State: {error.SQLState})");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Excepción general al insertar evaluación:");
                Console.WriteLine($"Mensaje: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return idEvaluacion;
        }


        // Insertar detalles de la evaluación
        public void InsertarDetalleEvaluacion(int idEvaluacion, int idCompetencia, decimal calificacion, string comentarios)
        {
            OdbcConnection conn = null;

            try
            {
                conn = cn.conexion(); // Abre la conexión explícitamente
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

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
            catch (Exception ex)
            {
               Console.WriteLine("Error al insertar detalle de evaluación: " + ex.Message);
            }
            finally
            {
                // Asegurarse de que la conexión se cierre
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        public DataTable ObtenerEvaluacionesPorEmpleado(int idEmpleado)
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = null;
            try
            {
                conn = cn.conexion();  // Establecer la conexión con la base de datos
                string query = @"
            SELECT e.pk_id_evaluacion, e.tipo_evaluacion, e.calificacion AS calificacion_general, e.comentarios AS comentario_general, 
                   d.calificacion AS calificacion_detalle, c.nombre_competencia, d.comentarios AS comentario_detalle
            FROM tbl_evaluaciones e
            INNER JOIN tbl_detalle_evaluacion d ON e.pk_id_evaluacion = d.fk_id_evaluacion
            INNER JOIN tbl_competencias c ON d.fk_id_competencia = c.Pk_id_competencia
            WHERE e.fk_clave_empleado = ?";  // Filtramos por el ID del empleado
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idEmpleado);  // Se agrega el parámetro del empleado
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);  // Llenamos el DataTable con los resultados
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener evaluaciones: " + ex.Message);
            }
            finally
            {
                conn?.Close();  // Cerramos la conexión
            }
            return dt;
        }

        // Obtener competencias activas
        public DataTable ObtenerCompetenciasActivas()
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = null;
            try
            {
                conn = cn.conexion();
                string query = "SELECT Pk_id_competencia, nombre_competencia, descripcion FROM tbl_competencias WHERE estado = 1";
                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener competencias: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }
            return dt;
        }

    }
}
