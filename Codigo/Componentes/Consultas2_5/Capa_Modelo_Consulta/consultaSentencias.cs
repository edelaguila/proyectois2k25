﻿using System;
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

        //Cierre de conexiones (Daniel Sierra 0901-21-12740) 14/02/2025
        //Parametros agregados (Joel López 0901-21-4188) 14/02/2025
        public OdbcDataAdapter buscartbl(string BD)
        {
            string sql = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = ?";

            try
            {
                OdbcConnection connection = con.connection();
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (OdbcCommand command = new OdbcCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("?", BD);

                    // OdbcDataAdapter no debe estar dentro de using, ya que lo retornamos
                    return new OdbcDataAdapter(command);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
                return null;
            }
        }


        //Cierre de conexiones (Daniel Sierra 0901-21-12740) 14/02/2025
        //Validaciones de Nombre de tabla (Joel López 0901-21-4188) 14/02/2025
        public void insertar(string dato, string tipo, string tabla)
        {
            // Validar nombres de tabla y columna para evitar inyección SQL
            if (!EsNombreValido(tabla) || !EsNombreValido(tipo))
            {
                MessageBox.Show("Nombre de tabla o columna no válido.");
                return;
            }

            string sql = $"INSERT INTO {tabla} ({tipo}) VALUES (?)";

            try
            {
                using (OdbcConnection connection = con.connection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (OdbcCommand cmd = new OdbcCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("?", dato);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar datos: " + e.Message);
            }
        }

        // Método auxiliar para validar nombres de tablas y columnas
        private bool EsNombreValido(string nombre)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-Z0-9_]+$");
        }



        //Cierre de conexiones (Daniel Sierra 0901-21-12740) 14/02/2025
        //Parámetros colocados (Joel López 0901-21-4188) 14/02/2025
        public List<string> ObtenerColumnas(string tabla)
        {
            List<string> columns = new List<string>();

            // Validar que el nombre de la tabla sea seguro
            if (!EsNombreValido(tabla))
            {
                Console.WriteLine("Nombre de tabla no válido.");
                return columns;
            }

            string query = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS " +
                           $"WHERE TABLE_SCHEMA = ? AND TABLE_NAME = ?;";

            try
            {
                using (OdbcConnection connection = this.conn.connection()) // Se abre la conexión
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?", baseDatos); // Parámetro seguro
                        cmd.Parameters.AddWithValue("?", tabla); // Parámetro seguro

                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                columns.Add(reader.GetString(0));
                            }
                        }
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


        //Cierre de conexiones (Daniel Sierra 0901-21-12740) 14/02/2025
        public void actualizar(string setClause, string tabla, string condicion)
        {
            try
            {
                string sql = $"UPDATE {tabla} SET {setClause} WHERE {condicion}";

                using (OdbcConnection connection = con.connection()) // Se abre la conexión
                {
                    connection.Open();

                    using (OdbcCommand cmd = new OdbcCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                } // La conexión se cierra automáticamente aquí
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al actualizar: " + e.Message);
            }
        }



        //modficado por Sebastian Luna

        //Cierre de conexiones (Daniel Sierra 0901-21-12740) 14/02/2025
        public List<string> ObtenerNombresConsultas()
        {
            List<string> nombresConsultas = new List<string>();
            try
            {
                // Consulta para obtener solo los nombres de las consultas
                string query = "SELECT consultaInteligente_nombre_consulta FROM tbl_consultaInteligente;";

                // Ejecutamos el comando con la conexión activa usando 'using'
                using (OdbcConnection con = this.conn.connection()) // Asegúrate de que esta es la conexión activa
                {
                    con.Open();
                    using (OdbcCommand cmd = new OdbcCommand(query, con)) // Utilizamos el comando dentro de 'using'
                    using (OdbcDataReader reader = cmd.ExecuteReader()) // El 'OdbcDataReader' también debe ser usado dentro de 'using'
                    {
                        // Añadimos los nombres de consulta a la lista
                        while (reader.Read())
                        {
                            string nombreConsulta = reader.GetString(0);
                            nombresConsultas.Add(nombreConsulta);
                        }
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

        //Cierre de conexiones (Daniel Sierra 0901-21-12740) 14/02/2025
        public OdbcDataAdapter EjecutarQuery(string query)
        {
            try
            {
                // Usamos 'using' para asegurar que la conexión y adaptador se cierren correctamente
                using (OdbcConnection con = this.conn.connection()) // Crea y maneja la conexión
                {
                    con.Open(); // Abre la conexión

                    // Usamos el 'using' para el adaptador de datos, asegurando su cierre adecuado
                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, con))
                    {
                        return adapter; // Retornamos el adaptador para que se pueda usar fuera de esta función
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el query: " + ex.Message);
                return null; // Retorna null en caso de error
            }
        }


        public void EliminarConsulta(string nombreConsulta)
        {
            string sql = "UPDATE tbl_consultaInteligente SET consultaInteligente_consulta_estatus = 0 WHERE consultaInteligente_nombre_consulta = ?";

            try
            {
                using (OdbcConnection connection = con.connection())
                {
                    connection.Open();

                    using (OdbcCommand cmd = new OdbcCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("?", nombreConsulta);
                        cmd.ExecuteNonQuery();
                    }
                } // La conexión se cierra automáticamente aquí
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al eliminar la consulta: " + e.Message);
            }
        }

        //Fin de participacion de sebastian luna
        //Parametros colocados (Joel López 0901-21-4188)
        // para ayudas
        public string modIndice(string idAyuda)
        {
            string indice = "";
            string query = "SELECT indice FROM ayuda WHERE id_ayuda = ?"; // Consulta segura

            try
            {
                using (OdbcConnection connection = this.conn.connection())
                {
                    connection.Open(); // Asegurar que la conexión está abierta

                    using (OdbcCommand command = new OdbcCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", idAyuda);

                        using (OdbcDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                indice = reader.GetString(0); // Asignamos el valor de la columna 'indice'
                            }
                        }
                    }
                } // La conexión se cierra automáticamente aquí
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el índice: " + ex.Message);
            }

            return indice;
        }

        //Parametros colocados (Joel López 0901-21-4188)

        public string modRuta(string idAyuda)
        {
            string ruta = "";
            string query = "SELECT Ruta FROM ayuda WHERE Id_ayuda = ?"; // Consulta segura

            try
            {
                using (OdbcConnection connection = this.conn.connection())
                {
                    connection.Open(); // Asegurar que la conexión está abierta

                    using (OdbcCommand command = new OdbcCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", idAyuda);

                        using (OdbcDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ruta = reader.GetString(0); // Asignamos el valor de la columna 'Ruta'
                            }
                        }
                    }
                } // La conexión se cierra automáticamente aquí
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la ruta: " + ex.Message);
            }

            return ruta;
        }

    }
}