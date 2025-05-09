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






        public void InsertarCompra(int proveedor, DateTime fechaCompra, int bod, string factura, string compro, string pago, double sub, double imp, double total, string prod, double cant, double pre, string desc)
        {
            OdbcConnection o_conn = conn.conexion();
            try
            {
                // SQL para insertar en Tbl_compra
                string s_query = "INSERT INTO Tbl_compra (Fk_prov_id ,fecha_compra,Fk_ID_BODEGA ,numero_factura,tipo_comprobante,forma_pago,subtotal, impuestos, total ,producto,cantidad,precio,descripcion) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?)";
                OdbcCommand cmd = new OdbcCommand(s_query, o_conn);

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

                // Obtener ID del producto
                string s_query2 = "SELECT Pk_id_Producto FROM Tbl_productos WHERE nombreProducto = ?";
                OdbcCommand cmd2 = new OdbcCommand(s_query2, o_conn);
                cmd2.Parameters.AddWithValue("@producto", prod);

                OdbcDataReader reader = cmd2.ExecuteReader();
                int idProducto = -1;

                if (reader.Read())
                {
                    idProducto = reader.GetInt32(0);
                }
                reader.Close();

                if (idProducto == -1)
                {
                    throw new Exception("Producto no encontrado.");
                }

                // Ejecutar insert en Tbl_compra
                cmd.ExecuteNonQuery();

                // Obtener el ID de la compra recién insertada
                OdbcCommand cmdLastId = new OdbcCommand("SELECT LAST_INSERT_ID()", o_conn);
                int idCompra = Convert.ToInt32(cmdLastId.ExecuteScalar());

                // Insertar en Tbl_movimiento_de_inventario
                string s_query3 = "INSERT INTO Tbl_movimiento_de_inventario (Fk_id_producto, stock, Fk_ID_BODEGA, Cantidad_almacen, Fk_id_compra, tipo_movimiento) VALUES (?,?,?,?,?,?)";
                OdbcCommand cmd3 = new OdbcCommand(s_query3, o_conn);
                cmd3.Parameters.AddWithValue("@Fk_id_producto", idProducto);
                cmd3.Parameters.AddWithValue("@stock", cant); // stock inicial = cantidad comprada
                cmd3.Parameters.AddWithValue("@Fk_ID_BODEGA", bod);
                cmd3.Parameters.AddWithValue("@Cantidad_almacen", cant);
                cmd3.Parameters.AddWithValue("@Fk_id_compra", idCompra);
                cmd3.Parameters.AddWithValue("@tipo_movimiento", "Positivo");
                cmd3.ExecuteNonQuery();

                // SQL para actualizar las existencias en la bodega
                string s_query4 = "SELECT Pk_ID_EXISTENCIA, CANTIDAD_ACTUAL, CANTIDAD_INICIAL FROM TBL_EXISTENCIAS_BODEGA WHERE Fk_ID_BODEGA = ? AND Fk_ID_PRODUCTO = ?";
                OdbcCommand cmd4 = new OdbcCommand(s_query4, o_conn);
                cmd4.Parameters.AddWithValue("@Fk_ID_BODEGA", bod);
                cmd4.Parameters.AddWithValue("@Fk_ID_PRODUCTO", idProducto);
                OdbcDataReader reader2 = cmd4.ExecuteReader();

                if (reader2.Read())
                {
                    // Si el producto ya existe, actualizar la cantidad actual
                    int pkExistencia = reader2.GetInt32(0);
                    int cantidadActual = reader2.GetInt32(1);
                    int cantidadInicial = reader2.GetInt32(2);

                    // Actualizar la cantidad actual sumando la nueva cantidad
                    string s_query5 = "UPDATE TBL_EXISTENCIAS_BODEGA SET CANTIDAD_ACTUAL = ? WHERE Pk_ID_EXISTENCIA = ?";
                    OdbcCommand cmd5 = new OdbcCommand(s_query5, o_conn);
                    cmd5.Parameters.AddWithValue("@CANTIDAD_ACTUAL", cantidadActual + (int)cant); // Sumamos la cantidad
                    cmd5.Parameters.AddWithValue("@Pk_ID_EXISTENCIA", pkExistencia);
                    cmd5.ExecuteNonQuery();
                }
                else
                {
                    // Si el producto no existe en la bodega, insertar nuevo registro
                    string s_query6 = "INSERT INTO TBL_EXISTENCIAS_BODEGA (Fk_ID_BODEGA, Fk_ID_PRODUCTO, CANTIDAD_INICIAL, CANTIDAD_ACTUAL) VALUES (?,?,?,?)";
                    OdbcCommand cmd6 = new OdbcCommand(s_query6, o_conn);
                    cmd6.Parameters.AddWithValue("@Fk_ID_BODEGA", bod);
                    cmd6.Parameters.AddWithValue("@Fk_ID_PRODUCTO", idProducto);
                    cmd6.Parameters.AddWithValue("@CANTIDAD_INICIAL", (int)cant); // La cantidad inicial es igual a la cantidad comprada
                    cmd6.Parameters.AddWithValue("@CANTIDAD_ACTUAL", (int)cant); // La cantidad actual es igual a la cantidad comprada
                    cmd6.ExecuteNonQuery();
                }

                MessageBox.Show("Compra insertada correctamente y movimiento registrado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar compra: " + ex.Message);
            }
            finally
            {
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