using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Capa_Modelo_Reclutamiento
{
    public class Sentencias
    {
        Conexion cn = new Conexion();

        public void Fun_guardar(int Fk_id_postulante, string curriculum, string doc_entrevista, int logica, int numerica, int verbal, int razonamiento, int tecnologica, string personalidad, string pruebas_completas)
        {
            using (OdbcConnection connection = cn.conexion())
            {
                try
                {

                    byte[] entrevistaBytes = File.Exists(doc_entrevista)
                             ? File.ReadAllBytes(doc_entrevista)
                             : null;
                    byte[] curriculumBytes = File.Exists(curriculum)
                             ? File.ReadAllBytes(curriculum)
                             : null;
                    byte[] pruebasBytes = File.Exists(pruebas_completas)
                             ? File.ReadAllBytes(pruebas_completas)
                             : null;

                    string nombreCurriculum = Path.GetFileName(curriculum);
                    string nombreEntrevista = Path.GetFileName(doc_entrevista);
                    string nombrePruebas = Path.GetFileName(pruebas_completas);


                    string queryguardar = @"INSERT INTO Tbl_expedientes 
                (Fk_id_postulante, curriculum, documento_entrevista, prueba_logica, prueba_numerica, prueba_verbal, 
                 razonamiento, prueba_tecnologica, prueba_personalidad, pruebas_psicometricas) 
                VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?,?)";

                    using (OdbcCommand cmd = new OdbcCommand(queryguardar, connection))
                    {
                        cmd.Parameters.AddWithValue("@Fk_id_postulante", Fk_id_postulante);
                        cmd.Parameters.Add("@curriculum", OdbcType.VarBinary).Value = curriculumBytes ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@doc_entrevista", OdbcType.VarBinary).Value = entrevistaBytes ?? (object)DBNull.Value;
                        cmd.Parameters.AddWithValue("@logica", logica);
                        cmd.Parameters.AddWithValue("@numerica", numerica);
                        cmd.Parameters.AddWithValue("@verbal", verbal);
                        cmd.Parameters.AddWithValue("@razonamiento", razonamiento);
                        cmd.Parameters.AddWithValue("@tecnologica", tecnologica);
                        cmd.Parameters.AddWithValue("@personalidad", personalidad);
                        cmd.Parameters.Add("@pruebas_psicometricas", OdbcType.VarBinary).Value = pruebasBytes ?? (object)DBNull.Value;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datos guardados correctamente.");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }

        public bool ExpedienteExiste(int idPostulante)
        {
            OdbcConnection conn = cn.conexion();
            try
            {
                string query = "SELECT COUNT(*) FROM Tbl_expedientes WHERE Fk_id_postulante = ?";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@Fk_id_postulante", idPostulante);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar existencia del expediente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cn.desconexion(conn);
            }
        }


            public void Fun_actualizar(int Pk_id_expediente, int Fk_id_postulante, string curriculum, string doc_entrevista, int logica, int numerica, int verbal, int razonamiento, int tecnologica, string personalidad, string pruebas_completas)
        {
            using (OdbcConnection connection = cn.conexion())
            {
                try
                {
                    byte[] entrevistaBytes = null;
                    byte[] curriculumBytes = null;
                    byte[] pruebasBytes = null;

                    // Obtener los valores actuales desde la base de datos
                    string selectQuery = "SELECT curriculum, documento_entrevista, pruebas_psicometricas FROM Tbl_expedientes WHERE Pk_id_expediente = ?";
                    using (OdbcCommand selectCmd = new OdbcCommand(selectQuery, connection))
                    {
                        selectCmd.Parameters.AddWithValue("@id", Pk_id_expediente);
                        using (OdbcDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                curriculumBytes = !reader.IsDBNull(reader.GetOrdinal("curriculum"))
                                    ? (byte[])reader["curriculum"]
                                    : null;

                                entrevistaBytes = !reader.IsDBNull(reader.GetOrdinal("documento_entrevista"))
                                    ? (byte[])reader["documento_entrevista"]
                                    : null;

                                pruebasBytes = !reader.IsDBNull(reader.GetOrdinal("pruebas_psicometricas"))
                                    ? (byte[])reader["pruebas_psicometricas"]
                                    : null;
                            }
                        }
                    }

                    // Intentar cargar los nuevos archivos si existen
                    if (!string.IsNullOrWhiteSpace(curriculum) && File.Exists(curriculum))
                        curriculumBytes = File.ReadAllBytes(curriculum);

                    if (!string.IsNullOrWhiteSpace(doc_entrevista) && File.Exists(doc_entrevista))
                        entrevistaBytes = File.ReadAllBytes(doc_entrevista);

                    if (!string.IsNullOrWhiteSpace(pruebas_completas) && File.Exists(pruebas_completas))
                        pruebasBytes = File.ReadAllBytes(pruebas_completas);

                    string queryActualizar = @"UPDATE Tbl_expedientes
                                       SET 
                                           Fk_id_postulante = ?, 
                                           curriculum = ?, 
                                           documento_entrevista = ?, 
                                           prueba_logica = ?, 
                                           prueba_numerica = ?, 
                                           prueba_verbal = ?, 
                                           razonamiento = ?, 
                                           prueba_tecnologica = ?, 
                                           prueba_personalidad = ?, 
                                           pruebas_psicometricas = ?
                                       WHERE Pk_id_expediente = ?";

                    using (OdbcCommand cmd = new OdbcCommand(queryActualizar, connection))
                    {
                        cmd.Parameters.AddWithValue("@Fk_id_postulante", Fk_id_postulante);
                        cmd.Parameters.Add("@curriculum", OdbcType.VarBinary).Value = curriculumBytes ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@doc_entrevista", OdbcType.VarBinary).Value = entrevistaBytes ?? (object)DBNull.Value;
                        cmd.Parameters.AddWithValue("@logica", logica);
                        cmd.Parameters.AddWithValue("@numerica", numerica);
                        cmd.Parameters.AddWithValue("@verbal", verbal);
                        cmd.Parameters.AddWithValue("@razonamiento", razonamiento);
                        cmd.Parameters.AddWithValue("@tecnologica", tecnologica);
                        cmd.Parameters.AddWithValue("@personalidad", personalidad);
                        cmd.Parameters.Add("@pruebas_psicometricas", OdbcType.VarBinary).Value = pruebasBytes ?? (object)DBNull.Value;
                        cmd.Parameters.AddWithValue("@Pk_id_expediente", Pk_id_expediente);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datos actualizados correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: "     );
                }
            }
        }

        public void Fun_Eliminar(int idExpediente)
        {
            Conexion con = new Conexion();
            using (OdbcConnection conn = con.conexion())
            {
                string query = "DELETE FROM Tbl_expedientes WHERE PK_id_expediente = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Pk_id_expediente", idExpediente);
                    cmd.ExecuteNonQuery();
                }
                con.desconexion(conn);
            }
        }




        public DataTable ObtenerExpedientes()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection connection = cn.conexion())
                {
                    string query = @"SELECT e.Pk_id_expediente, e.Fk_id_postulante, 
                                    p.nombre_postulante, 
                                    e.prueba_logica, e.prueba_numerica, e.prueba_verbal,
                                    e.razonamiento, e.prueba_tecnologica, 
                                    e.prueba_personalidad
                             FROM Tbl_expedientes e
                             INNER JOIN Tbl_postulante p ON e.Fk_id_postulante = p.Pk_id_postulante";

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener expedientes: " + ex.Message);
            }

            return tabla;
        }

        public List<KeyValuePair<int, string>> ObtenerPostulantes()
        {
            var lista = new List<KeyValuePair<int, string>>();

            try
            {
                using (OdbcConnection connection = cn.conexion())
                {
                    string query = "SELECT Pk_id_postulante, nombre_postulante FROM Tbl_postulante";
                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0); // ID del postulante
                                string nombre = reader.GetString(1); // Nombre del postulante
                                lista.Add(new KeyValuePair<int, string>(id, nombre));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener postulantes: " + ex.Message);
            }

            return lista;
        }

        public bool GuardarArchivoRecuperado(string campo, int idPostulante, string rutaDestino)
        {
            byte[] archivo = null;
            using (OdbcConnection connection = cn.conexion())
            {
                string query = $"SELECT {campo} FROM Tbl_expedientes WHERE Fk_id_postulante = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", idPostulante);
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            archivo = (byte[])reader[0];
                        }
                    }
                }
            }

            if (archivo != null)
            {
                string extension = ".bin";
                if (archivo.Length > 4)
                {
                    if (archivo[0] == 0x25 && archivo[1] == 0x50) extension = ".pdf";
                    else if (archivo[0] == 0x50 && archivo[1] == 0x4B) extension = ".docx";
                }

                string rutaCompleta = rutaDestino + extension;
                File.WriteAllBytes(rutaCompleta, archivo);
                return true;
            }

            return false;
        }




        public DataTable ObtenerExpedientePorId(int id)
        {
            Conexion cn = new Conexion(); 
            OdbcConnection conn = cn.conexion(); 

            try
            {
                string query = "SELECT * FROM Tbl_expedientes WHERE Fk_id_postulante = ?";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener expediente: " + ex.Message);
                return null;
            }
            finally
            {
                cn.desconexion(conn);
            }
        }

    }
}
