﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Capa_Modelo_Consulta
{
    public class consultaSentencias
    {
        consultaConexion con = new consultaConexion();
        protected consultaConexion conn;
        private static string s_base_datos = "";

        public consultaSentencias()
        {
            this.conn = new consultaConexion();
            s_base_datos = this.conn.connection().Database;
        }

        /*
         Modificado por Carlos González 
         */

        //Cierre de conexiones (Daniel Sierra 0901-21-12740) 14/02/2025
        //Parametros agregados (Joel López 0901-21-4188) 14/02/2025
        public OdbcDataAdapter obtener_tablas(string s_bd)
        {
            string s_sql = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = ?";
            try
            {
                using (OdbcConnection conn = this.conn.connection())
                {
                    conn.Open();
                    using (OdbcCommand cmd = new OdbcCommand(s_sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", s_bd);
                        return new OdbcDataAdapter(cmd);
                    }
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
        public void insertar_dato(string s_dato, string s_tipo, string s_tabla)
        {
            //if (!es_nombre_valido(s_tabla) || !es_nombre_valido(s_tipo))
            //{
            //    MessageBox.Show("Nombre de tabla o columna no válido.");
            //    return;
            //}
            string s_sql = $"INSERT INTO {s_tabla} ({s_tipo}) VALUES (?)";
            try
            {
                using (OdbcConnection conn = this.conn.connection())
                {
                    conn.Open();
                    using (OdbcCommand cmd = new OdbcCommand(s_sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", s_dato);
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
        //private bool es_nombre_valido(string s_nombre)
        //{
        //    return Regex.IsMatch(s_nombre, "^[a-zA-Z0-9_]+$");
        //}



        ////Cierre de conexiones (Daniel Sierra 0901-21-12740) 14/02/2025
        ////Parámetros colocados (Joel López 0901-21-4188) 14/02/2025
        //public List<string> obtener_columnas(string s_tabla)
        //{
        //    List<string> lst_columnas = new List<string>();
        //    if (!es_nombre_valido(s_tabla))
        //    {
        //        Console.WriteLine("Nombre de tabla no válido.");
        //        return lst_columnas;
        //    }
        //    string s_query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = ? AND TABLE_NAME = ?;";
        //    try
        //    {
        //        using (OdbcConnection conn = this.conn.connection())
        //        {
        //            conn.Open();
        //            using (OdbcCommand cmd = new OdbcCommand(s_query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("?", s_base_datos);
        //                cmd.Parameters.AddWithValue("?", s_tabla);
        //                using (OdbcDataReader reader = cmd.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        lst_columnas.Add(reader.GetString(0));
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Error al obtener columnas: " + e.Message);
        //    }
        //    return lst_columnas;
        //}

        /***********Original - Combobox************************/
        public List<string> obtener_columnas(string s_tabla)
        {
            List<string> columns = new List<string>();
            try
            {
                // Usa la variable 'baseDatos' ya definida en la clase
                string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS " +
                               "WHERE TABLE_SCHEMA = '" + s_base_datos + "' AND TABLE_NAME = '" + s_tabla + "';";
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
        /*******************************************************/


        /*
         Fin de la participación de Carlos González
         */


        //Cierre de conexiones (Daniel Sierra 0901-21-12740) 14/02/2025
        public void actualizar_datos(string s_set_clause, string s_tabla, string s_condicion)
        {
            try
            {
                string s_sql = $"UPDATE {s_tabla} SET {s_set_clause} WHERE {s_condicion}";
                using (OdbcConnection conn = this.conn.connection())
                {
                    conn.Open();
                    using (OdbcCommand cmd = new OdbcCommand(s_sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al actualizar: " + e.Message);
            }
        }



        //modficado por Sebastian Luna

        //Cierre de conexiones (Daniel Sierra 0901-21-12740) 14/02/2025
        public List<string> obtener_nombres_consultas()
        {
            List<string> lst_nombres = new List<string>();
            try
            {
                string s_query = "SELECT consultaInteligente_nombre_consulta FROM tbl_consultaInteligente;";
                using (OdbcConnection conn = this.conn.connection())
                {
                    conn.Open();
                    using (OdbcCommand cmd = new OdbcCommand(s_query, conn))
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lst_nombres.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al obtener nombres de consultas: " + e.Message);
            }
            return lst_nombres;
        }

        public string obtener_query_por_nombre(string s_nombre_consulta)
        {
            string s_query = "SELECT consultaInteligente_consulta_SQLE FROM tbl_consultaInteligente WHERE consultaInteligente_nombre_consulta = ?";
            try
            {
                using (OdbcConnection conn = this.conn.connection())
                {
                    conn.Open();
                    using (OdbcCommand cmd = new OdbcCommand(s_query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", s_nombre_consulta);
                        object result = cmd.ExecuteScalar();
                        return result != DBNull.Value ? result.ToString() : string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el query por nombre: " + ex.Message);
                return string.Empty;
            }
        }

        //Cierre de conexiones (Daniel Sierra 0901-21-12740) 14/02/2025
        public OdbcDataAdapter EjecutarQuery(string query)
        {
            /*****Original******/
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
            /*********************/
            //try
            //{
            //    // Usamos 'using' para asegurar que la conexión y adaptador se cierren correctamente
            //    using (OdbcConnection con = this.conn.connection()) // Crea y maneja la conexión
            //    {
            //        con.Open(); // Abre la conexión

            //        // Usamos el 'using' para el adaptador de datos, asegurando su cierre adecuado
            //        using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, con))
            //        {
            //            return adapter; // Retornamos el adaptador para que se pueda usar fuera de esta función
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error al ejecutar el query: " + ex.Message);
            //    return null; // Retorna null en caso de error
            //}
        }


        public void eliminar_consulta(string s_nombre_consulta)
        {
            string s_sql = "UPDATE tbl_consultaInteligente SET consultaInteligente_consulta_estatus = 0 WHERE consultaInteligente_nombre_consulta = ?";
            try
            {
                using (OdbcConnection conn = this.conn.connection())
                {
                    conn.Open();
                    using (OdbcCommand cmd = new OdbcCommand(s_sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", s_nombre_consulta);
                        cmd.ExecuteNonQuery();
                    }
                }
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