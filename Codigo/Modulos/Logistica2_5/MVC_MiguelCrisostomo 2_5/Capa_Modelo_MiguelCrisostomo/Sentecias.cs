using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Windows.Forms;


namespace Capa_Modelo_MiguelCrisostomo
{
    public class sentencias
    {
        conexion conn = new conexion(); // Utiliza tu clase existente

        public void insertarTraslado(string destino, DateTime fecha, int cantidad, decimal costoTotal, decimal costoTotalGeneral, decimal precioTotal, int idProducto, int idGuia)
        {
            try
            {
                string query = "INSERT INTO Tbl_TrasladoProductos (destino, fecha, cantidad, costoTotal, costoTotalGeneral, precioTotal, Fk_id_Producto, Fk_id_guia) " +
                               "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(query, conn.Conexion()))
                {
                    cmd.Parameters.AddWithValue("@destino", destino);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@costoTotal", costoTotal);
                    cmd.Parameters.AddWithValue("@costoTotalGeneral", costoTotalGeneral);
                    cmd.Parameters.AddWithValue("@precioTotal", precioTotal);
                    cmd.Parameters.AddWithValue("@Fk_id_Producto", idProducto);
                    cmd.Parameters.AddWithValue("@Fk_id_guia", idGuia);

                    int ingreso = cmd.ExecuteNonQuery();
                    //return ingreso > 0;
                    MessageBox.Show(ingreso > 0 ? "Traslado registrado correctamente" : "Error al registrar el traslado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar traslado: " + ex.Message + "\nNo se pudo guardar el registro en la tabla Tbl_TrasladoProductos");
            }
        }    
        
        public string ObtenerNombreProductoPorCodigo(string codigoProducto)
        {
            throw new NotImplementedException();
        }

        //**********************************************************************************************************************************************
        // Método para obtener los códigos de productos desde Tbl_Productos  
        public List<int> ObtenerCodigosProductos()
        {
            List<int> codigosProductos = new List<int>();
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos

            try
            {
                string query = "SELECT codigoProducto FROM Tbl_Productos";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    codigosProductos.Add(reader.GetInt32(0)); // Agrega cada código de producto a la lista
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener códigos de productos: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión
            }

            return codigosProductos; // Retorna la lista de códigos de productos
        }

        // Método para obtener nombreProducto según el destino***************************************************************************
        public string ObtenerNombreProductoPorCodigo(int codigoProducto)
        {
            string nombreProducto = string.Empty;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos  

            try
            {
                string query = "SELECT nombreProducto FROM Tbl_Productos WHERE codigoProducto = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("codigoProducto", codigoProducto);

                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nombreProducto = reader.GetString(0); // Obtiene el nombre del producto  
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener nombre de producto por código: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión  
            }

            return nombreProducto; // Retorna el nombre del producto encontrado o vacío si no se encontró  
        }

        public int ObteneridProductoPorCodigo(int codigoProducto)
        {
            int nombreProducto = 0;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos  

            try
            {
                string query = "SELECT Pk_id_Producto FROM Tbl_Productos WHERE codigoProducto = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("codigoProducto", codigoProducto);

                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nombreProducto = reader.GetInt32(0); // Obtiene el nombre del producto  
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener id de producto por código: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión  
            }

            return nombreProducto; // Retorna el nombre del producto encontrado o vacío si no se encontró  
        }      

        // Método para obtener pesoProducto como texto según el código de producto
        public string ObtenerPesoProductoPorCodigo(int codigoProducto)
        {
            string pesoProducto = string.Empty;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos  

            try
            {
                string query = "SELECT pesoProducto FROM Tbl_Productos WHERE codigoProducto = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("codigoProducto", codigoProducto);

                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    pesoProducto = reader.GetString(0); // Obtiene el peso del producto como texto
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener peso del producto por código: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión  
            }

            return pesoProducto; // Retorna el peso del producto como texto
        }

        // Método para obtener stock según el código de producto
        public int ObtenerStockProductoPorCodigo(int codigoProducto)
        {
            int stockProducto = 0;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos  

            try
            {
                string query = "SELECT stock FROM Tbl_Productos WHERE codigoProducto = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("codigoProducto", codigoProducto);

                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    stockProducto = reader.GetInt32(0); // Obtiene el stock del producto  
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener stock de producto por código: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión  
            }

            return stockProducto; // Retorna el stock del producto encontrado o 0 si no se encontró  
        }

        // Método para obtener precio según el código de producto
        public decimal ObtenerPrecioProductoPorCodigo(int codigoProducto)
        {
            decimal precioProducto = 0;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos  

            try
            {
                string query = "SELECT precioUnitario FROM Tbl_Productos WHERE codigoProducto = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("codigoProducto", codigoProducto);

                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    precioProducto = reader.GetDecimal(0); // Obtiene el precio del producto  
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener precio de producto por código: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión  
            }

            return precioProducto; // Retorna el precio del producto encontrado o 0 si no se encontró  
        }

        public int ObtenerIdVehiculoPorDestino(string destino)
        {
            int idVehiculo = 0;
            using (OdbcConnection connection = conn.Conexion())
            {
                string query = "SELECT Fk_id_vehiculo FROM Tbl_vehiculos WHERE destino = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("destino", destino);

                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idVehiculo = reader.GetInt32(0);
                    }
                }
            }
            return idVehiculo;
        }

        //***************************************************************************************************************
        public DateTime ObtenerFechaTrasladoPorDestino(string destino)
        {
            DateTime fechaTraslado = DateTime.MinValue;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos

            try
            {
                string query = "SELECT fechaTraslado FROM Tbl_datos_pedido WHERE destino = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("destino", destino);

                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    fechaTraslado = reader.GetDateTime(0); // Asigna la fecha si se encuentra
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la fecha de traslado: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection);
            }

            return fechaTraslado; // Retorna la fecha o null si no se encontró
        }

        // METODO para obtener la fecha de emisión según el destino
        public DateTime ObtenerFechaEmisionPorDestino(string destino)
        {
            DateTime fechaEmision = DateTime.MinValue;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos

            try
            {
                string query = "SELECT fechaEmision FROM Tbl_datos_pedido WHERE destino = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("destino", destino);

                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    fechaEmision = reader.GetDateTime(0); // Obtiene la fecha de emisión
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener fecha de emisión: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión
            }

            return fechaEmision; // Retorna la fecha de emisión encontrada o DateTime.MinValue si no se encontró
        }


        // INSTRUCCION PARA OBTENER LA INFORMACION DEL LA TABLA: Tbl_datos_pedido ******************************************************
        // Método para obtener los destinos desde la base de datos
        // Nuevo método para obtener los destinos desde Tbl_datos_pedido
        public List<string> ObtenerDestinos()
        {
            List<string> destinos = new List<string>();
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos

            try
            {
                string query = "SELECT destino FROM Tbl_datos_pedido";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    destinos.Add(reader.GetString(0)); // Agrega cada destino a la lista
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener destinos: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión
            }
            return destinos; // Retorna la lista de destinos
        }

        // Método para obtener el ID (Pk_id_guia) según el destino***************************************************************************
        public int ObtenerIdGuiaPorDestino(string destino)
        {
            int idGuia = -1; // Valor predeterminado para indicar que no se encontró el ID
            OdbcConnection connection = conn.Conexion();

            try
            {
                string query = "SELECT Pk_id_guia FROM Tbl_datos_pedido WHERE destino = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("destino", destino);

                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idGuia = reader.GetInt32(0); // Obtiene el ID si se encontró
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener ID por destino: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection);
            }

            return idGuia; // Retorna el ID encontrado o -1 si no se encontró
        }

        // Método para obtener la marca del vehículo según el destino seleccionado *************************************************************
        public string ObtenerMarcaVehiculoPorDestino(string destino)
        {
            string marcaVehiculo = "";
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos

            try
            {
                // Consulta SQL para obtener la marca del vehículo relacionado con el destino
                string query = @"
                SELECT v.marca 
                FROM Tbl_datos_pedido dp
                INNER JOIN Tbl_vehiculos v ON dp.Fk_id_vehiculo = v.Pk_id_vehiculo
                WHERE dp.destino = ?";

                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("destino", destino);

                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    marcaVehiculo = reader.GetString(0); // Obtiene la marca del vehículo
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la marca del vehículo: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión
            }

            return marcaVehiculo; // Retorna la marca del vehículo encontrada
        }

        /// INSTRUCCIONES BOTON GUARDAR CLASE SENTECIAS.CS ******************************************************
        public void RealizarTraslado(string documento,string fecha, int costoTotal, int costoTotalGeneral, int precioTotal, int idProducto, int idGuia, int codigoProducto)
        {
            // Conexión a la base de datos
            OdbcConnection connection = conn.Conexion(); // Usar la instancia para obtener la conexión

            try
            {
                // Consulta para insertar datos en la tabla Tbl_TrasladoProductos
                string query = "INSERT INTO Tbl_TrasladoProductos (documento, fecha, costoTotal, costoTotalGeneral, precioTotal, Fk_id_Producto, Fk_id_guia, codigoProducto) " +
                               "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                // Crear el comando Odbc y asignar los parámetros
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("documento", documento);
                cmd.Parameters.AddWithValue("fecha", fecha);
                cmd.Parameters.AddWithValue("costoTotal", costoTotal);
                cmd.Parameters.AddWithValue("costoTotalGeneral", costoTotalGeneral);
                cmd.Parameters.AddWithValue("precioTotal", precioTotal);
                cmd.Parameters.AddWithValue("Fk_id_Producto", idProducto);
                cmd.Parameters.AddWithValue("Fk_id_guia", idGuia);
                cmd.Parameters.AddWithValue("codigoProducto", codigoProducto);

                // Ejecutar el comando de inserción

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Traslado realizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el traslado: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                //conn.Desconexion(connection); // Asegúrate de que este método se llame correctamente
                conn.desconexion(connection);

            }
        }

        // Método para obtener el peso total del vehículo según el destino seleccionado *********************************************************
        public int ObtenerPesoTotalVehiculoPorDestino(string destino)
        {
            int pesoTotal = 0;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos

            try
            {
                // Consulta SQL para obtener el peso total del vehículo relacionado con el destino
                string query = @"
                SELECT v.pesoTotal
                FROM Tbl_datos_pedido dp
                INNER JOIN Tbl_vehiculos v ON dp.Fk_id_vehiculo = v.Pk_id_vehiculo
                WHERE dp.destino = ?";

                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("destino", destino);

                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    pesoTotal = reader.GetInt32(0); // Obtiene el peso total del vehículo
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el peso total del vehículo: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión
            }

            return pesoTotal; // Retorna el peso total del vehículo encontrado
        }



        //FORMATO PARA LA PARTE DEL DOCUMENTO
        public string ObtenerSiguienteDocumentoConFormato()
        {
            string documentoGenerado = "";
            int siguienteNumero = 1; //Comienza con el primer número
            string prefijoDocumento = "TDProd-"; //Abreviatura que indica el "traslado del producto".

            OdbcConnection connection = conn.Conexion();

            try
            {
                // Obtener el último documento con el formato siguiente (Ej: TDProd-000001)
                string query = $"SELECT MAX(documento) FROM Tbl_TrasladoProductos WHERE documento LIKE '{prefijoDocumento}%'";

                OdbcCommand cmd = new OdbcCommand(query, connection);
                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    string ultimoDocumento = result.ToString();
                    // Extraer el número del documento actual (últimos 6 dígitos) y convertirlo a entero
                    string numeroStr = ultimoDocumento.Substring(7); // Comienza desde la posición 7 para saltar el "TDProd-", Ignora "TDProd-"
                    siguienteNumero = int.Parse(numeroStr) + 1; // Incrementa el número
                }

                // Formatear el nuevo número de documento con ceros a la izquierda
                documentoGenerado = $"{prefijoDocumento}{siguienteNumero.ToString("D6")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el siguiente documento: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection);
            }

            return documentoGenerado;
        }


        // Método para actualizar el stock según el código de producto  
        public void ActualizarStockProducto(int codigoProducto, int nuevoStock)
        {
            try
            {
                using (OdbcConnection connection = conn.Conexion())
                {
                    string query = "UPDATE Tbl_Productos SET stock = ? WHERE codigoProducto = ?";
                    using (OdbcCommand command = new OdbcCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", nuevoStock);
                        command.Parameters.AddWithValue("?", codigoProducto);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el stock: " + ex.Message);
            }
        }
    }
}
