using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace Capa_Modelo_Compras
{
    public class Sentencias
    {
        Conexion conn = new Conexion();

        public List<string> ObtenerSucursales()
        {
            List<string> sucursales = new List<string>();
            OdbcConnection connection = conn.conexion();

            try
            {
                string query = "SELECT Pk_prov_id FROM Tbl_proveedores WHERE estado = 1";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sucursales.Add(reader.GetString(0));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener sucursales: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection);
            }

            return sucursales;
        }

        public List<string> ObtenerProductos()
        {
            List<string> sucursales = new List<string>();
            OdbcConnection connection = conn.conexion();

            try
            {
                string query = "SELECT nombreProducto FROM Tbl_productos WHERE estado = 1";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sucursales.Add(reader.GetString(0));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener sucursales: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection);
            }

            return sucursales;
        }






    }


}