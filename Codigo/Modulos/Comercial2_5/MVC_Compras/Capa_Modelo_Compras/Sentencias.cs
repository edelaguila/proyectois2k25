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
        public string sIdUsuario { get; set; }

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

        public List<Tuple<string, double>> ObtenerProductosConPrecio()
        {
            List<Tuple<string, double>> productos = new List<Tuple<string, double>>();
            OdbcConnection connection = conn.conexion();

            try
            {
                string query = "SELECT nombreProducto, precioUnitario FROM Tbl_productos WHERE estado = 1";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Agregar nombre del producto y precio a la lista
                    productos.Add(new Tuple<string, double>(reader.GetString(0), reader.GetDouble(1)));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener productos: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection);
            }

            return productos;
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


                // Crear instancia de la clase Sentencia en Capa_modelo_seguridad
                var bitacora = new Capa_Modelo_Seguridad.sentencia();

                // Llama a la función de bitácora
                bitacora.funInsertarBitacora(sIdUsuario, "Realizó una insercion a la tabla de Compras", "Tbl_compras", "3000");


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
                // Crear instancia de la clase Sentencia en Capa_modelo_seguridad

                // Llama a la función de bitácora
                bitacora.funInsertarBitacora(sIdUsuario, "Realizó una insercion a la tabla de Movimiento Inventario", "tbl_movimiento_de_inventario", "3000");
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
                    bitacora.funInsertarBitacora(sIdUsuario, "Realizó una actualizacion a la tabla de existencias de bodega", "TBL_EXISTENCIAS_BODEGA", "3000");

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
                    bitacora.funInsertarBitacora(sIdUsuario, "Realizó una insercion a la tabla de existencias de bodega", "TBL_EXISTENCIAS_BODEGA", "3000");

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

        public OdbcDataAdapter Fun_DisplayMovimientos2()
        {
            string s_tablaMovimientoInventario = "tbl_vendedores";
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


        public void EliminarCompra(int idCompra)
        {
            OdbcConnection o_conn = conn.conexion();

            try
            {
                // Obtener datos necesarios: producto, cantidad y bodega
                string queryDatos = "SELECT producto, cantidad, Fk_ID_BODEGA FROM Tbl_compra WHERE Pk_ID_Compra = ?";
                OdbcCommand cmdDatos = new OdbcCommand(queryDatos, o_conn);
                cmdDatos.Parameters.AddWithValue("@idCompra", idCompra);
                OdbcDataReader reader = cmdDatos.ExecuteReader();

                string producto = "";
                int cantidad = 0;
                int idBodega = 0;

                if (reader.Read())
                {
                    producto = reader.GetString(0);
                    cantidad = (int)reader.GetDouble(1);
                    idBodega = reader.GetInt32(2);
                }
                else
                {
                    throw new Exception("Compra no encontrada.");
                }

                reader.Close();

                // Obtener ID del producto
                string queryProd = "SELECT Pk_id_Producto FROM Tbl_productos WHERE nombreProducto = ?";
                OdbcCommand cmdProd = new OdbcCommand(queryProd, o_conn);
                cmdProd.Parameters.AddWithValue("@nombreProducto", producto);
                int idProducto = Convert.ToInt32(cmdProd.ExecuteScalar());

                // Actualizar existencia (restar la cantidad)
                string queryExist = "SELECT Pk_ID_EXISTENCIA, CANTIDAD_ACTUAL FROM TBL_EXISTENCIAS_BODEGA WHERE Fk_ID_BODEGA = ? AND Fk_ID_PRODUCTO = ?";
                OdbcCommand cmdExist = new OdbcCommand(queryExist, o_conn);
                cmdExist.Parameters.AddWithValue("@Fk_ID_BODEGA", idBodega);
                cmdExist.Parameters.AddWithValue("@Fk_ID_PRODUCTO", idProducto);

                OdbcDataReader readerExist = cmdExist.ExecuteReader();
                if (readerExist.Read())
                {
                    int pkExistencia = readerExist.GetInt32(0);
                    int cantidadActual = readerExist.GetInt32(1);
                    readerExist.Close();

                    int nuevaCantidad = cantidadActual - cantidad;

                    if (nuevaCantidad < 0) nuevaCantidad = 0; // por seguridad

                    string queryUpdate = "UPDATE TBL_EXISTENCIAS_BODEGA SET CANTIDAD_ACTUAL = ? WHERE Pk_ID_EXISTENCIA = ?";
                    OdbcCommand cmdUpdate = new OdbcCommand(queryUpdate, o_conn);
                    cmdUpdate.Parameters.AddWithValue("@CANTIDAD_ACTUAL", nuevaCantidad);
                    cmdUpdate.Parameters.AddWithValue("@Pk_ID_EXISTENCIA", pkExistencia);
                    cmdUpdate.ExecuteNonQuery();
                }
                else
                {
                    readerExist.Close();
                    throw new Exception("No se encontró el registro en existencias.");
                }

                // Eliminar de Tbl_movimiento_de_inventario
                string queryMov = "DELETE FROM Tbl_movimiento_de_inventario WHERE Fk_id_compra = ?";
                OdbcCommand cmdMov = new OdbcCommand(queryMov, o_conn);
                cmdMov.Parameters.AddWithValue("@Fk_id_compra", idCompra);
                cmdMov.ExecuteNonQuery();

                // Eliminar de Tbl_compra
                string queryCompra = "DELETE FROM Tbl_compra WHERE Pk_ID_Compra = ?";
                OdbcCommand cmdCompra = new OdbcCommand(queryCompra, o_conn);
                cmdCompra.Parameters.AddWithValue("@Pk_ID_Compra", idCompra);
                cmdCompra.ExecuteNonQuery();
                // Crear instancia de la clase Sentencia en Capa_modelo_seguridad
                var bitacora = new Capa_Modelo_Seguridad.sentencia();

                // Llama a la función de bitácora
                bitacora.funInsertarBitacora(sIdUsuario, "Realizó una eliminación de compras", "Tbl_compras", "3000");
                bitacora.funInsertarBitacora(sIdUsuario, "Realizó una eliminación de movimiento", "Tbl_movimiento_de_inventario", "3000");

                bitacora.funInsertarBitacora(sIdUsuario, "Realizó una eliminación de existencias bodega", "TBL_EXISTENCIAS_BODEGA", "3000");


                MessageBox.Show("Compra eliminada correctamente, y stock actualizado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la compra: " + ex.Message);
            }
            finally
            {
                if (o_conn != null && o_conn.State == ConnectionState.Open)
                {
                    o_conn.Close();
                }
            }
        }

        public void ActualizarCompra(
    int idCompra,
    int proveedor,
    DateTime fechaCompra,
    int bod,
    string factura,
    string compro,
    string pago,
    double sub,
    double imp,
    double total,
    string prod,
    double cant,
    double pre,
    string desc)
        {
            OdbcConnection o_conn = conn.conexion();

            try
            {
                // 1. Obtener ID del producto (igual que en Insertar)
                string s_queryProd = "SELECT Pk_id_Producto FROM Tbl_productos WHERE nombreProducto = ?";
                OdbcCommand cmdProd = new OdbcCommand(s_queryProd, o_conn);
                cmdProd.Parameters.AddWithValue("@producto", prod);

                OdbcDataReader reader = cmdProd.ExecuteReader();
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

                // 2. Actualizar datos en Tbl_compra
                string s_queryUpdateCompra = @"
            UPDATE Tbl_compra SET 
                Fk_prov_id = ?, 
                fecha_compra = ?, 
                Fk_ID_BODEGA = ?, 
                numero_factura = ?, 
                tipo_comprobante = ?, 
                forma_pago = ?, 
                subtotal = ?, 
                impuestos = ?, 
                total = ?, 
                producto = ?, 
                cantidad = ?, 
                precio = ?, 
                descripcion = ? 
            WHERE Pk_ID_Compra = ?";

                OdbcCommand cmdUpdateCompra = new OdbcCommand(s_queryUpdateCompra, o_conn);

                cmdUpdateCompra.Parameters.AddWithValue("@Fk_prov_id", proveedor);
                cmdUpdateCompra.Parameters.AddWithValue("@fecha_compra", fechaCompra);
                cmdUpdateCompra.Parameters.AddWithValue("@Fk_ID_BODEGA", bod);
                cmdUpdateCompra.Parameters.AddWithValue("@numero_factura", factura);
                cmdUpdateCompra.Parameters.AddWithValue("@tipo_comprobante", compro);
                cmdUpdateCompra.Parameters.AddWithValue("@forma_pago", pago);
                cmdUpdateCompra.Parameters.AddWithValue("@subtotal", sub);
                cmdUpdateCompra.Parameters.AddWithValue("@impuestos", imp);
                cmdUpdateCompra.Parameters.AddWithValue("@total", total);
                cmdUpdateCompra.Parameters.AddWithValue("@producto", prod);
                cmdUpdateCompra.Parameters.AddWithValue("@cantidad", cant);
                cmdUpdateCompra.Parameters.AddWithValue("@precio", pre);
                cmdUpdateCompra.Parameters.AddWithValue("@descripcion", desc);
                cmdUpdateCompra.Parameters.AddWithValue("@Pk_ID_Compra", idCompra);

                cmdUpdateCompra.ExecuteNonQuery();
                // Crear instancia de la clase Sentencia en Capa_modelo_seguridad
                var bitacora = new Capa_Modelo_Seguridad.sentencia();

                // Llama a la función de bitácora
                bitacora.funInsertarBitacora(sIdUsuario, "Realizó una actualización de compras", "Tbl_compras", "3000");
                bitacora.funInsertarBitacora(sIdUsuario, "Realizó una actualización de movimiento", "Tbl_movimiento_de_inventario", "3000");

                bitacora.funInsertarBitacora(sIdUsuario, "Realizó una actualización de existencias bodega", "TBL_EXISTENCIAS_BODEGA", "3000");

                // 3. Actualizar movimiento en Tbl_movimiento_de_inventario
                string s_queryUpdateMov = @"
            UPDATE Tbl_movimiento_de_inventario SET 
                Fk_id_producto = ?, 
                stock = ?, 
                Fk_ID_BODEGA = ?, 
                Cantidad_almacen = ?,
                tipo_movimiento = 'Positivo'
            WHERE Fk_id_compra = ?";

                OdbcCommand cmdUpdateMov = new OdbcCommand(s_queryUpdateMov, o_conn);
                cmdUpdateMov.Parameters.AddWithValue("@Fk_id_producto", idProducto);
                cmdUpdateMov.Parameters.AddWithValue("@stock", cant);
                cmdUpdateMov.Parameters.AddWithValue("@Fk_ID_BODEGA", bod);
                cmdUpdateMov.Parameters.AddWithValue("@Cantidad_almacen", cant);
                cmdUpdateMov.Parameters.AddWithValue("@Fk_id_compra", idCompra);
                cmdUpdateMov.ExecuteNonQuery();

                // 4. Actualizar existencias en bodega (sumar la diferencia)
                // Primero obtener la existencia actual y cantidad inicial para este producto y bodega
                string s_queryExist = "SELECT Pk_ID_EXISTENCIA, CANTIDAD_ACTUAL, CANTIDAD_INICIAL FROM TBL_EXISTENCIAS_BODEGA WHERE Fk_ID_BODEGA = ? AND Fk_ID_PRODUCTO = ?";
                OdbcCommand cmdExist = new OdbcCommand(s_queryExist, o_conn);
                cmdExist.Parameters.AddWithValue("@Fk_ID_BODEGA", bod);
                cmdExist.Parameters.AddWithValue("@Fk_ID_PRODUCTO", idProducto);
                OdbcDataReader readerExist = cmdExist.ExecuteReader();

                if (readerExist.Read())
                {
                    int pkExistencia = readerExist.GetInt32(0);
                    int cantidadActual = readerExist.GetInt32(1);
                    int cantidadInicial = readerExist.GetInt32(2);
                    readerExist.Close();

                    // Obtener la cantidad anterior de la compra para calcular la diferencia
                    string s_queryCantAnterior = "SELECT cantidad FROM Tbl_compra WHERE Pk_ID_Compra = ?";
                    OdbcCommand cmdCantAnterior = new OdbcCommand(s_queryCantAnterior, o_conn);
                    cmdCantAnterior.Parameters.AddWithValue("@Pk_ID_Compra", idCompra);
                    int cantidadAnterior = Convert.ToInt32(cmdCantAnterior.ExecuteScalar());

                    int diferencia = (int)cant - cantidadAnterior;  // puede ser positivo o negativo

                    // Actualizar la cantidad actual sumando la diferencia
                    string s_queryUpdateExist = "UPDATE TBL_EXISTENCIAS_BODEGA SET CANTIDAD_ACTUAL = ? WHERE Pk_ID_EXISTENCIA = ?";
                    OdbcCommand cmdUpdateExist = new OdbcCommand(s_queryUpdateExist, o_conn);
                    cmdUpdateExist.Parameters.AddWithValue("@CANTIDAD_ACTUAL", cantidadActual + diferencia);
                    cmdUpdateExist.Parameters.AddWithValue("@Pk_ID_EXISTENCIA", pkExistencia);
                    cmdUpdateExist.ExecuteNonQuery();
                }
                else
                {
                    readerExist.Close();

                    // Si no existe registro, insertar nuevo
                    string s_queryInsertExist = "INSERT INTO TBL_EXISTENCIAS_BODEGA (Fk_ID_BODEGA, Fk_ID_PRODUCTO, CANTIDAD_INICIAL, CANTIDAD_ACTUAL) VALUES (?,?,?,?)";
                    OdbcCommand cmdInsertExist = new OdbcCommand(s_queryInsertExist, o_conn);
                    cmdInsertExist.Parameters.AddWithValue("@Fk_ID_BODEGA", bod);
                    cmdInsertExist.Parameters.AddWithValue("@Fk_ID_PRODUCTO", idProducto);
                    cmdInsertExist.Parameters.AddWithValue("@CANTIDAD_INICIAL", (int)cant);
                    cmdInsertExist.Parameters.AddWithValue("@CANTIDAD_ACTUAL", (int)cant);
                    cmdInsertExist.ExecuteNonQuery();
                }

                MessageBox.Show("Compra actualizada correctamente y movimiento registrado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar compra: " + ex.Message);
            }
            finally
            {
                if (o_conn != null && o_conn.State == ConnectionState.Open)
                    o_conn.Close();
            }
        }



        public void InsertarVendedor(int idVendedor, string nombre, string apellido, double sueldo, string direccion, string telefono, int fkEmpleado)
        {
            OdbcConnection o_conn = conn.conexion();
            try
            {
                string s_query = "INSERT INTO Tbl_vendedores " +
                                 "(Pk_id_vendedor, vendedores_nombre, vendedores_apellido, vendedores_sueldo, vendedores_direccion, vendedores_telefono, Fk_id_empleado, estado) " +
                                 "VALUES (?, ?, ?, ?, ?, ?, ?, 1)";

                OdbcCommand cmd = new OdbcCommand(s_query, o_conn);
                cmd.Parameters.AddWithValue("@Pk_id_vendedor", idVendedor);
                cmd.Parameters.AddWithValue("@vendedores_nombre", nombre);
                cmd.Parameters.AddWithValue("@vendedores_apellido", apellido);
                cmd.Parameters.AddWithValue("@vendedores_sueldo", sueldo);
                cmd.Parameters.AddWithValue("@vendedores_direccion", direccion);
                cmd.Parameters.AddWithValue("@vendedores_telefono", telefono);
                cmd.Parameters.AddWithValue("@Fk_id_empleado", fkEmpleado);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Vendedor insertado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar vendedor: " + ex.Message);
            }
            finally
            {
                if (o_conn != null && o_conn.State == ConnectionState.Open)
                {
                    o_conn.Close();
                }
            }
        }


        public void EliminarVendedor(int idVendedor)
        {
            OdbcConnection o_conn = conn.conexion();
            try
            {
                string s_query = "DELETE FROM Tbl_vendedores WHERE Pk_id_vendedor = ?";
                OdbcCommand cmd = new OdbcCommand(s_query, o_conn);
                cmd.Parameters.AddWithValue("@Pk_id_vendedor", idVendedor);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                    MessageBox.Show("Vendedor eliminado correctamente.");
                else
                    MessageBox.Show("No se encontró el vendedor para eliminar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar vendedor: " + ex.Message);
            }
            finally
            {
                if (o_conn != null && o_conn.State == ConnectionState.Open)
                    o_conn.Close();
            }
        }




    }


}