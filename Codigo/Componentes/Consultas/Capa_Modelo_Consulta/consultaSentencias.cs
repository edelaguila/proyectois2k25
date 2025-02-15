using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Capa_Modelo_Consulta
{
    public class consultaSentencias
    {
        consultaConexion con = new consultaConexion();
        protected consultaConexion conn;
        private static string baseDatos = "";

        public consultaSentencias()
        {
            this.conn = new consultaConexion();
            baseDatos = this.conn.connection().Database;
        }

        /*
         Modificado por Carlos González 
         */

        public OdbcDataAdapter buscartbl(string BD)
        {
            string sql = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = ?";

            // Asegúrate de que la conexión esté funcionando
            OdbcConnection connection = con.connection();
            if (connection.State != ConnectionState.Open)
            {
                MessageBox.Show("No se pudo establecer la conexión con la base de datos.");
                return null;
            }

            // Crear el comando y agregar el parámetro
            OdbcCommand command = new OdbcCommand(sql, connection);
            command.Parameters.AddWithValue("@tableName", BD);

            // Pasar el comando al DataAdapter
            OdbcDataAdapter datatable = new OdbcDataAdapter(command);
            return datatable;
        }



        public void insertar(string dato, string tipo, string tabla)
        {
            try
            {
                string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
                OdbcCommand cmd = new OdbcCommand(sql, con.connection());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<string> ObtenerColumnas(string tabla)
        {
            List<string> columns = new List<string>();
            try
            {
                // Usa la variable 'baseDatos' ya definida en la clase
                string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS " +
                               "WHERE TABLE_SCHEMA = '" + baseDatos + "' AND TABLE_NAME = '" + tabla + "';";
                // Ejecutamos el comando con la conexión activa
                using (OdbcCommand cmd = new OdbcCommand(query, this.conn.connection()))
                {
                    OdbcDataReader reader = cmd.ExecuteReader();
                    // Añadimos las columnas a la lista
                    while (reader.Read())
                    {
                        string column = reader.GetString(0);
                        columns.Add(column);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al obtener columnas: " + e.Message);
            }
            return columns;
        }

        /*
         Fin de la participación de Carlos González
         */


        public void actualizar(string setClause, string tabla, string condicion)
        {
            try
            {
                // Construir la consulta UPDATE con la cláusula SET y la condición WHERE
                string sql = $"UPDATE {tabla} SET {setClause} WHERE {condicion}";
                OdbcCommand cmd = new OdbcCommand(sql, con.connection());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //////////////// FIN SALVADOR MARTÍNEZ ////////////////

        }

        public void insertarconsulta(string cadena)
        {
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, con.connection());
                consulta.ExecuteNonQuery();
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo" + Error);
            }
        }
        public OdbcDataAdapter llenartb2(string sql)
        {
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.connection());
            return datatable;
        }

        public string ObtenerTipoDeDato(string seleccion, string tablaN1)
        {
            string Tipo = string.Empty;
            using (OdbcConnection conn = con.connection())
            {
                string query = "SELECT DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA ='" + baseDatos + "' AND TABLE_NAME = '" + tablaN1 + "' AND COLUMN_NAME = '" + seleccion + "'";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        Tipo = result.ToString();
                    }
                }
            } return Tipo;
        }

        public DataTable BuscarPor2(string datobuscar, string buscaren, string operador, string tableN, DataTable dt, Label lbl_cadena)
        {
            OdbcConnection con = new OdbcConnection("Dsn=HotelSConexion");
            if (string.IsNullOrEmpty(buscaren))
            {
                String textalert = " El campo buscar, se encuentra vacio ";
                MessageBox.Show(textalert);
            }
            else
            {
                try
                {
                    String cadenaB = "";
                    con.Open();
                    cadenaB = "SELECT * FROM " + tableN + " WHERE " + buscaren + " " + operador + " '" + datobuscar + "';";
                    lbl_cadena.Text = "Buscando : " + datobuscar + " En Columna : " + buscaren;
                    OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                    datos.Fill(dt);
                    OdbcCommand comando = new OdbcCommand(cadenaB, con);
                    OdbcDataReader leer;
                    leer = comando.ExecuteReader();

                }
                catch (Exception ex)
                {
                    String textalert = "No se pudo";
                    MessageBox.Show("Error: " + ex.Message);
                    MessageBox.Show(textalert);
                }

                con.Close();
            }
            return dt;
        }




        //modficado por Sebastian Luna
        
        

        public List<string> ObtenerNombresConsultas()
        {
            List<string> nombresConsultas = new List<string>();
            try
            {
                // Consulta para obtener solo los nombres de las consultas
                string query = "SELECT consultaInteligente_nombre_consulta FROM tbl_consultaInteligente;";
                // Ejecutamos el comando con la conexión activa
                using (OdbcCommand cmd = new OdbcCommand(query, this.conn.connection()))
                {
                    OdbcDataReader reader = cmd.ExecuteReader();
                    // Añadimos los nombres de consulta a la lista
                    while (reader.Read())
                    {
                        string nombreConsulta = reader.GetString(0);
                        nombresConsultas.Add(nombreConsulta);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al obtener nombres de consultas: " + e.Message);
            }
            return nombresConsultas;
        }

        public string ObtenerQueryPorNombre(string nombreConsulta)
        {
            string query = string.Empty;
            try
            {
                // Consulta SQL para obtener el texto del query por su nombre
                string sql = "SELECT consultaInteligente_consulta_SQLE  FROM tbl_consultaInteligente WHERE  consultaInteligente_nombre_consulta = ?";
                using (OdbcConnection conn = this.conn.connection())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        // Usamos parámetros para evitar inyecciones SQL
                        cmd.Parameters.AddWithValue("?", nombreConsulta);

                        // Ejecutar el comando
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            query = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el query por nombre: " + ex.Message);
            } return query;
        }

        public OdbcDataAdapter EjecutarQuery(string query)
        {
            OdbcDataAdapter adapter = null;
            try
            {
                // Crear el adaptador de datos para ejecutar el query
                adapter = new OdbcDataAdapter(query, this.conn.connection());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el query: " + ex.Message);
            }
            return adapter;
        }

        public void EliminarConsulta(string nombreConsulta)
        {
            try
            {
                string sql = "UPDATE tbl_consultaInteligente SET  consultaInteligente_consulta_estatus = 0 WHERE consultaInteligente_nombre_consulta = ?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con.connection()))
                {
                    cmd.Parameters.AddWithValue("@nombreConsulta", nombreConsulta);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al eliminar la consulta: " + e.Message);
            }
        }
        //Fin de participacion de sebastian luna

        // para ayudas
        public string modIndice(string idAyuda)
        {
            string indice = "";
            string query = "SELECT indice FROM ayuda WHERE id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(query,this.conn.connection()))
            {
                command.Parameters.AddWithValue("Id_ayuda", idAyuda);
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        indice = reader.GetString(0); // Asignamos el valor de la columna Indice
                    }
                }
            }

            return indice;
        }
        public string modRuta(string idAyuda)
        {
            string ruta = "";
            string query = "SELECT Ruta FROM ayuda WHERE Id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(query,this.conn.connection()))
            {
                command.Parameters.AddWithValue("id_ayuda", idAyuda);
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ruta = reader.GetString(0); // Asignamos el valor de la columna Ruta
                    }
                }
            }

            return ruta;
        }
    }
}