using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

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

        public List<string> ObtenerSucursal()
        {
            List<string> sucursales = new List<string>();
            OdbcConnection connection = conn.conexion();

            try
            {
                string query = "SELECT Pk_ID_BODEGA FROM tbl_bodegas";
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






        public void InsertarCompra(int proveedor ,DateTime fechaCompra,int bod, string factura,string compro, string pago, double sub , double imp , double total ,string prod, double cant ,double pre , string desc)
        {
            OdbcConnection o_conn = conn.conexion();
            try
            {
                // SQL para insertar solo fecha_compra
                string s_query = "INSERT INTO Tbl_compra (Fk_prov_id ,fecha_compra,Fk_ID_BODEGA ,numero_factura,tipo_comprobante,forma_pago,subtotal, impuestos, total ,producto,cantidad,precio,descripcion) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?)";
                OdbcCommand cmd = new OdbcCommand(s_query, o_conn);

                // Agregar el parámetro 'fecha_compra'
                cmd.Parameters.AddWithValue("@Fk_prov_id", proveedor);
                cmd.Parameters.AddWithValue("@fecha_compra", fechaCompra);
                cmd.Parameters.AddWithValue("@Fk_ID_BODEGA", bod);

                
                cmd.Parameters.AddWithValue("@numero_factura", factura);
                cmd.Parameters.AddWithValue("@tipo_comprobante", compro);
                cmd.Parameters.AddWithValue("@forma_pago", pago);



                cmd.Parameters.AddWithValue("@subtotal", sub);
                cmd.Parameters.AddWithValue("@impuestos", imp);
                cmd.Parameters.AddWithValue("@total", total);

                cmd.Parameters.AddWithValue("@producto", prod);
                cmd.Parameters.AddWithValue("@cantidad", cant);


                cmd.Parameters.AddWithValue("@precio", pre);

                cmd.Parameters.AddWithValue("@descripcion", desc);




                string s_query2 = "SELECT  Pk_id_Producto FROM Tbl_productos WHERE nombreProducto = ?";
                OdbcCommand cmd2 = new OdbcCommand(s_query2, o_conn);

                cmd2.Parameters.AddWithValue("@producto", prod);

                OdbcDataReader reader = cmd2.ExecuteReader();

                int idProducto = -1; // Variable para guardar el valor (ajusta el tipo si es string, etc.)

                if (reader.Read())
                {
                    idProducto = reader.GetInt32(0); // 0 es el índice de la columna en la consulta
                }

                reader.Close(); // Cierra el lector después de usarlo



               /* // SQL para insertar solo fecha_compra
                string s_query3 = "INSERT INTO Tbl_compra (Fk_prov_id ,fecha_compra,numero_factura,tipo_comprobante,forma_pago,subtotal, impuestos, total ,producto,cantidad,precio,descripcion) VALUES (?,?,?,?,?)";
                OdbcCommand cmd3 = new OdbcCommand(s_query3, o_conn);

                // Agregar el parámetro 'fecha_compra'
                cmd3.Parameters.AddWithValue("@Fk_prov_id", proveedor);*/






                // Ejecutar el comando
                cmd.ExecuteNonQuery();
                MessageBox.Show("Compra insertada correctamente");
            }
            catch (Exception ex)
            {
                // Si hay un error, mostrar el mensaje
                MessageBox.Show("Error al insertar compra: " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (o_conn != null && o_conn.State == ConnectionState.Open)
                {
                    o_conn.Close();
                }
            }
        }

        public OdbcDataAdapter Fun_DisplayMovimientos()
        {
            string s_tablaMovimientoInventario = "tbl_compra";
            string s_sql = "SELECT * FROM " + s_tablaMovimientoInventario;
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(s_sql, conn.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + s_tablaMovimientoInventario);
            }
            return dataTable;
        }



    }


}