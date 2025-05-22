using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_GD
{
    public class Sentencia
    {
        Conexion cn = new Conexion();
        private string idUsuario;

        public Sentencia(string idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        //Codigo para formulario Evidencias

        //Consulta para rellenar el combobox de idFalta
        public OdbcDataAdapter funconsultarfaltas()
        {
            cn.conexion();
            string sqlFaltas = "SELECT pk_id_falta FROM tbl_faltas_disciplinarias WHERE estado = 1";
            OdbcDataAdapter dataFaltas = new OdbcDataAdapter(sqlFaltas, cn.conexion());
            //funInsertarBitacora(idUsuario, "Realizo una consulta a perfiles", "Tbl_perfiles", "1000");
            return dataFaltas;
        }

        //Consulta para insertar datos en la base de datos
        public bool funInsertarEvidencia(int idFalta, string stipo, string sarchivo, int iestado)
        {
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string sql = "INSERT INTO tbl_evidencias (fk_id_falta, evidencia_tipo, evidencia_url, estado) VALUES (?, ?, ?, ?)";
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idFalta", idFalta);
                        cmd.Parameters.AddWithValue("@tipoEvidencia", stipo);
                        cmd.Parameters.AddWithValue("@urlEvidencia", sarchivo);
                        cmd.Parameters.AddWithValue("@estado", iestado);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar evidencia: " + ex.Message);
                throw;
            }
        }

        //Funcion para obtener el nombre del empleado segun el pk_id_falta
        public string funObtenerNombreEmpleado(int idFalta)
        {
            string nombreEmpleado = "";
            cn.conexion();

            string query = @"SELECT CONCAT(e.empleados_nombre, ' ', e.empleados_apellido) 
                     FROM tbl_faltas_disciplinarias f
                     JOIN tbl_empleados e ON f.fk_clave_empleado = e.pk_clave
                     WHERE f.pk_id_falta = ?";

            using (OdbcCommand cmd = new OdbcCommand(query, cn.conexion()))
            {
                cmd.Parameters.AddWithValue("?", idFalta);
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nombreEmpleado = reader.GetString(0);
                    }
                }
            }

            return nombreEmpleado;
        }

        public DataTable funObtenerEvidenciaPorId(int id)
        {
            DataTable table = new DataTable();
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string query = @"
                SELECT 
                    pk_id_evidencia AS 'ID',
                    fk_id_falta AS 'Falta',
                    evidencia_tipo AS 'Tipo',
                    evidencia_url AS 'Ubicacion Archivo',
                    estado AS 'Estado'
                FROM tbl_evidencias
                WHERE pk_id_evidencia = ?";

                    using (OdbcDataAdapter data = new OdbcDataAdapter(query, conn))
                    {
                        data.SelectCommand.Parameters.AddWithValue("?", id);
                        data.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener evidencia por ID: " + ex.Message);
            }

            return table;
        }

        //obtener la ultima evidencia ingresada
        public int ObtenerUltimoIdEvidencia()
        {
            int id = 0;
            try
            {
                cn.conexion();
                string query = "SELECT MAX(pk_id_evidencia) FROM tbl_evidencias";
                using (OdbcCommand cmd = new OdbcCommand(query, cn.conexion()))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                        id = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener último ID: " + ex.Message);
            }
            return id;
        }

        //obtener todas las evidencias
        public DataTable funObtenerTodasEvidencias()
        {
            cn.conexion();
            //uso de alias para que se muestre de mejor forma en el DataGridView
            string query = @"
            SELECT 
                pk_id_evidencia AS 'ID',
                fk_id_falta AS 'Falta',
                evidencia_tipo AS 'Tipo',
                evidencia_url AS 'Ubicacion Archivo',
                estado AS 'Estado'
            FROM tbl_evidencias
            WHERE estado = 1";

            OdbcDataAdapter data = new OdbcDataAdapter(query, cn.conexion());
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

        public bool funEditarEvidencia(int id, int idFalta, string stipo, string sarchivo, int iestado)
        {
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string query = "UPDATE tbl_evidencias SET fk_id_falta = ?, evidencia_tipo = ?, evidencia_url = ?, estado = ? WHERE pk_id_evidencia = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@falta", idFalta);
                        cmd.Parameters.AddWithValue("@tipo", stipo);
                        cmd.Parameters.AddWithValue("@url", sarchivo);
                        cmd.Parameters.AddWithValue("@estado", iestado);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al editar evidencia: " + ex.Message);
                throw;
            }
        }

        public bool funEliminarEvidencia(int id)
        {
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string query = "UPDATE tbl_evidencias SET estado = 0 WHERE pk_id_evidencia = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar evidencia: " + ex.Message);
                throw;
            }
        }

        //Mostrar solo evidencias con estado = 0 "eliminados"
        public DataTable funObtenerEvidenciasEliminadas()
        {
            string query = @"
            SELECT 
                pk_id_evidencia AS 'ID',
                fk_id_falta AS 'Falta',
                evidencia_tipo AS 'Tipo',
                evidencia_url AS 'Ubicacion Archivo',
                estado AS 'Estado'
            FROM tbl_evidencias
            WHERE estado = 0";

            OdbcDataAdapter data = new OdbcDataAdapter(query, cn.conexion());
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

        //FIN Codigo para formulario Evidencias

        //Codigo para formulario Sanciones

        public DataTable ObtenerOperadores()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT pk_clave, CONCAT(empleados_nombre, ' ', empleados_apellido) AS nombre_completo
                         FROM tbl_empleados
                         WHERE estado = 1 AND fk_id_departamento = 2";

                OdbcDataAdapter da = new OdbcDataAdapter(query, cn.conexion()); // conexión() es el método que devuelve la conexión ya abierta
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.Write("Error al obtener operadores: " + ex.Message);
            }

            return dt;
        }

        public static bool funInsertarSancion(int idFalta, string tipoSancion, string descripcion, DateTime fecha, bool noSeAplica, int operador)
        {
            try
            {
                using (OdbcConnection conn = new Conexion().conexion())
                {
                    string query = @"INSERT INTO tbl_sanciones 
                            (fk_id_falta, sancion_tipo, sancion_descripcion, sancion_fecha, estado, sancion_operador) 
                             VALUES (?, ?, ?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idFalta", idFalta);
                        cmd.Parameters.AddWithValue("@tipoSancion", tipoSancion);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@estado", noSeAplica ? 0 : 1);
                        cmd.Parameters.AddWithValue("@operador", operador);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write("Error al insertar la sanción: " + ex.Message);
                throw; // <-- Lanza la excepción a la vista para que ahí se vea completa
            }
        }

        public static DataTable funObtenerUltimaSancion()
        {
            using (OdbcConnection conn = new Conexion().conexion())
            {
                string query = @"SELECT 
                            pk_id_sancion AS 'ID Sancion',
                            fk_id_falta AS 'ID Falta',
                            sancion_tipo AS 'Tipo de Sancion',
                            sancion_descripcion AS 'Descripcion',
                            sancion_fecha AS 'Fecha',
                            estado AS 'Estado',
                            sancion_operador AS 'ID Operador'  
                         FROM tbl_sanciones
                         ORDER BY pk_id_sancion DESC
                         LIMIT 1";

                using (OdbcDataAdapter da = new OdbcDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable funObtenerSancionesActivas()
        {
            using (OdbcConnection conn = new Conexion().conexion())
            {
                string query = @"SELECT 
                            pk_id_sancion AS 'ID Sancion',
                            fk_id_falta AS 'ID Falta',
                            sancion_tipo AS 'Tipo de Sancion',
                            sancion_descripcion AS 'Descripcion',
                            sancion_fecha AS 'Fecha',
                            estado AS 'Estado',
                            sancion_operador AS 'ID Operador'
                         FROM tbl_sanciones
                         WHERE estado = 1
                         ORDER BY sancion_fecha DESC";

                using (OdbcDataAdapter da = new OdbcDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable consultarSancionesInactivas()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT 
                                pk_id_sancion AS 'ID Sancion',
                                fk_id_falta AS 'ID Falta',
                                sancion_tipo AS 'Tipo de Sancion',
                                sancion_descripcion AS 'Descripcion',
                                sancion_fecha AS 'Fecha',
                                estado AS 'Estado',
                                sancion_operador AS 'ID Operador'        
                            FROM Tbl_sanciones
                            WHERE estado = 0";

            using (OdbcConnection conexion = cn.conexion())
            {
                using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, conexion))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public bool funeditarSancion(int idSancion, int idFalta, string tipo, string descripcion, string fecha, int estado, int operador)
        {
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string query = @"
                            UPDATE Tbl_sanciones
                            SET 
                                fk_id_falta = ?,
                                sancion_tipo = ?,
                                sancion_descripcion = ?,
                                sancion_fecha = ?,
                                estado = ?,
                                sancion_operador = ?
                            WHERE pk_id_sancion = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("fk_id_falta", idFalta);
                        cmd.Parameters.AddWithValue("sancion_tipo", tipo);
                        cmd.Parameters.AddWithValue("sancion_descripcion", descripcion);
                        cmd.Parameters.AddWithValue("sancion_fecha", fecha);
                        cmd.Parameters.AddWithValue("estado", estado);
                        cmd.Parameters.AddWithValue("sancion_operador", operador);
                        cmd.Parameters.AddWithValue("pk_id_sancion", idSancion);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al editar sancion: " + ex.Message);
                throw;
            }
        }

        public DataTable funObtenerSancionPorId(int id)
        {
            DataTable table = new DataTable();
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string query = @"
                                    SELECT
                                        pk_id_sancion AS 'ID Sancion',
                                        fk_id_falta AS 'ID Falta',
                                        sancion_tipo AS 'Tipo de Sancion',
                                        sancion_descripcion AS 'Descripcion',
                                        sancion_fecha AS 'Fecha',
                                        estado AS 'Estado',
                                        sancion_operador AS 'ID Operador'
                                    FROM tbl_sanciones
                                    WHERE pk_id_sancion = ? ";

                    using (OdbcDataAdapter data = new OdbcDataAdapter(query, conn))
                    {
                        data.SelectCommand.Parameters.AddWithValue("?", id);
                        data.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener sancion por ID: " + ex.Message);
            }

            return table;
        }

        public bool funEliminarSanciones(int id)
        {
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string query = "UPDATE tbl_sanciones SET estado = 0 WHERE pk_id_sancion = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar sancion: " + ex.Message);
                throw;
            }
        }

    }
}
