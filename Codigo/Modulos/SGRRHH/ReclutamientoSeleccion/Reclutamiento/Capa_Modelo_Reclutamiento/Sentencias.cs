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

        public void Fun_guardar(int Pk_id_postulante, string curriculum, string doc_entrevista, int logica, int numerica, int verbal, int razonamiento, int tecnologica, string personalidad, string pruebas_completas)
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


                    string queryguardar = @"INSERT INTO Tbl_expedientes 
                (Fk_id_postulante, curriculum, documento_entrevista, prueba_logica, prueba_numerica, prueba_verbal, 
                 razonamiento, prueba_tecnologica, prueba_personalidad, pruebas_psicometricas) 
                VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?,?)";

                    using (OdbcCommand cmd = new OdbcCommand(queryguardar, connection))
                    {
                        cmd.Parameters.AddWithValue("@Fk_id_postulante", Pk_id_postulante);
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
                // Usamos el 'using' para que la conexión se maneje automáticamente
                using (OdbcConnection connection = cn.conexion()) // Esto abre la conexión
                {
                    string query = "SELECT Pk_id_postulante, nombre_postulante FROM Tbl_postulante";
                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        // La conexión se abre en el método 'conexion' de la clase 'Conexion', por lo que no es necesario volver a abrirla
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0); // ID del postulante
                                string nombre = reader.GetString(1); // Nombre del postulante
                                lista.Add(new KeyValuePair<int, string>(id, nombre));  // Añadimos el par clave-valor a la lista
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al obtener postulantes: " + ex.Message);
            }

            return lista;  // Retornamos la lista después de ejecutar todo el proceso
        }

        public byte[] ObtenerArchivo(string campo, int idPostulante)
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
            return archivo;
        }
    }
}
