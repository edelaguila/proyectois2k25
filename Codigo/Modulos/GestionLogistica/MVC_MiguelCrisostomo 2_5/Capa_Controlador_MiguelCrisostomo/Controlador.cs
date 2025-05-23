using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_MiguelCrisostomo;
using System.Windows.Forms;

namespace Capa_Controlador_MiguelCrisostomo
{
    public class controlador
    {
        //Capa_Modelo_MiguelCrisostomo.sentencias sentencias = new Capa_Modelo_MiguelCrisostomo.sentencias();
        private Capa_Modelo_MiguelCrisostomo.sentencias sentencias;
        private conexion conn;

        // Constructor sin parámetros
        public controlador()
        {
            sentencias = new Capa_Modelo_MiguelCrisostomo.sentencias();
            conn = new conexion();
        }

        // Constructor que acepta un mock de sentencias para pruebas unitarias
        public controlador(Capa_Modelo_MiguelCrisostomo.sentencias sentenciasMock)
        {
            sentencias = sentenciasMock;
            conn = new conexion();
        }

        public void registrarTrasladoProductos(string documento, string fecha, int costoTotal, int costoTotalGeneral, int precioTotal, int idProducto, int idGuia, int codigoProducto, string bodegaOrigen, string bodegaDestino)
        {
            // Verificación de campos vacíos
            if (string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(fecha) ||
                costoTotal < 0 || costoTotalGeneral < 0 || precioTotal < 0 || idProducto < 0 || idGuia < 0 || codigoProducto < 0)
            {
                MessageBox.Show("Existen campos vacíos, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Llama a registrarTrasladoProductos con los parámetros correctos
                sentencias.RealizarTraslado(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto, bodegaOrigen, bodegaDestino);
            }
        }

        public int ObtenerIdGuiaPorDestino(string destino)
        {
            sentencias modelo = new sentencias(); // Instancia de la clase sentencias
            return modelo.ObtenerIdGuiaPorDestino(destino); // Llama al método en la capa de modelo
        }

        // METODO para obtener la fecha de emisión por destino
        public DateTime ObtenerFechaEmisionPorDestino(string destino)
        {
            return sentencias.ObtenerFechaEmisionPorDestino(destino); // Llama al método en la capa de modelo
        }

        // METODO para obtener la FechaTraslado
        public DateTime ObtenerFechaTrasladoPorDestino(string destino)
        {
            return sentencias.ObtenerFechaTrasladoPorDestino(destino); // Llama al método en la capa de modelo
        }

        // Método para obtener código de producto
        public List<int> ObtenerCodigosProductos()
        {
            return sentencias.ObtenerCodigosProductos(); // Llama al método en Sentencias

        }

        // Método para obtener el nombre del producto
        public string ObtenerNombreProductoPorCodigo(int codigoProducto)
        {
            sentencias modelo = new sentencias(); // Instancia de la clase sentencias  
            return modelo.ObtenerNombreProductoPorCodigo(codigoProducto); // Llama al método en la capa de modelo  
        }

        // Método para obtener pesoProducto como texto por código de producto
        public string ObtenerPesoProductoPorCodigo(int codigoProducto)
        {
            return sentencias.ObtenerPesoProductoPorCodigo(codigoProducto); // Llama al método en Sentencias
        }

        // Método para obtener stockProducto por código de producto
        public int ObtenerStockProductoPorCodigo(int codigoProducto)
        {
            sentencias modelo = new sentencias(); // Instancia de la clase sentencias  
            return modelo.ObtenerStockProductoPorCodigo(codigoProducto); // Llama al método en la capa de modelo  
        }

        // Método para obtener Precio Del Producto por código de producto
        public decimal ObtenerPrecioProductoPorCodigo(int codigoProducto)
        {
            sentencias modelo = new sentencias(); // Instancia de la clase sentencias  
            return modelo.ObtenerPrecioProductoPorCodigo(codigoProducto); // Llama al método en la capa de modelo  
        }


        /// INSTRUCCIONES BOTON GUARDAR ******************************************************
        public int ObtenerIdVehiculoPorDestino(string destino)
        {
            return sentencias.ObtenerIdVehiculoPorDestino(destino);
        }

        public int ObteneridProductoPorCodigo(int codigoProducto)
        {
            sentencias modelo = new sentencias(); // Instancia de la clase sentencias
            return modelo.ObteneridProductoPorCodigo(codigoProducto); // Llama al método en la capa de modelo
        }

        public void registrarTrasladoProductos(int documento, string fecha, int costoTotal1, int costoTotal2, int precioUnitario, int idProducto, int idGuia)
        {
            throw new NotImplementedException();
        }

        //FORMATO PARA LA PARTE DEL DOCUMENTO
        public string ObtenerSiguienteDocumentoConFormato()
        {
            return sentencias.ObtenerSiguienteDocumentoConFormato();
        }

        // Método para actualizar el stock del producto por código  
        public void ActualizarStockProducto(int codigoProducto, int nuevoStock)
        {
            sentencias.ActualizarStockProducto(codigoProducto, nuevoStock);
        }

        public List<string> ObtenerNombresBodegas()
        {
            List<string> nombresBodegas = new List<string>();
            try
            {
                OdbcConnection connection = conn.Conexion();
                string query = "SELECT NOMBRE_BODEGA FROM TBL_BODEGAS WHERE estado = 1";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nombresBodegas.Add(reader["NOMBRE_BODEGA"].ToString());
                }

                reader.Close();
                conn.desconexion(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener nombres de bodegas: " + ex.Message);
            }
            return nombresBodegas;
        }

        public List<string> ObtenerMarcasVehiculos()
        {
            return sentencias.ObtenerMarcasVehiculos();
        }

        public List<string> ObtenerSucursales()
        {
            return sentencias.ObtenerSucursales();
        }

        public int ObtenerPesoTotalPorMarca(string marca)
        {
            return sentencias.ObtenerPesoTotalPorMarca(marca);
        }

        public List<string> ObtenerDestinosPorMarca(string marca)
        {
            return sentencias.ObtenerDestinosPorMarca(marca);
        }

        public string ObtenerDestinoPorMarca(string marca)
        {
            return sentencias.ObtenerDestinoPorMarca(marca);
        }

        public string ObtenerDestinoPorIdVehiculo(int idVehiculo)
        {
            return sentencias.ObtenerDestinoPorIdVehiculo(idVehiculo);
        }

        public int ObtenerIdVehiculoPorMarca(string marca)
        {
            return sentencias.ObtenerIdVehiculoPorMarca(marca);
        }

        public int ObtenerIdTrasladoPorDocumento(string documento)
        {
            OdbcConnection connection = null;
            try
            {
                connection = conn.Conexion();
                string query = "SELECT Pk_id_TrasladoProductos FROM Tbl_TrasladoProductos WHERE documento = ?";
                
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@documento", documento);
                    object result = cmd.ExecuteScalar();
                    
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    return -1; // Retorna -1 si no se encuentra el documento
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del traslado: " + ex.Message);
                return -1;
            }
            finally
            {
                if (connection != null)
                {
                    conn.desconexion(connection);
                }
            }
        }

        public DataTable ObtenerDetallesTraslado(string documento)
        {
            DataTable dt = new DataTable();
            OdbcConnection connection = null;
            try
            {
                connection = conn.Conexion();
                string query = @"
                    SELECT 
                        dtp.codigoProducto,
                        p.nombreProducto,
                        dtp.cantidad,
                        dtp.precioUnitario,
                        p.pesoProducto,
                        p.stock,
                        tp.bodega_origen,
                        tp.bodega_destino
                    FROM Tbl_TrasladoProductos tp
                    INNER JOIN Tbl_DetalleTrasladoProductos dtp ON tp.Pk_id_TrasladoProductos = dtp.Fk_id_TrasladoProductos
                    INNER JOIN Tbl_Productos p ON dtp.codigoProducto = p.codigoProducto
                    WHERE tp.documento = ?
                    ORDER BY dtp.codigoProducto";

                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@documento", documento);
                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

                // Agregar la columna calculada después de obtener los datos
                dt.Columns.Add("stockActual", typeof(int));
                dt.Columns.Add("stockRestante", typeof(int));

                foreach (DataRow row in dt.Rows)
                {
                    int stockOriginal = Convert.ToInt32(row["stock"]);
                    int cantidad = Convert.ToInt32(row["cantidad"]);
                    
                    row["stockActual"] = stockOriginal;
                    row["stockRestante"] = stockOriginal + cantidad;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles del traslado: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    conn.desconexion(connection);
                }
            }
            return dt;
        }

        // MÉTODOS PARA DOCUMENTOS DE ENTRADA
        public void registrarEntradaProductos(string documento, string fecha, int costoTotal, int costoTotalGeneral, int precioTotal, int codigoProducto, int idGuia, string bodegaOrigen, string bodegaDestino)
        {
            try
            {
                using (OdbcConnection connection = conn.Conexion())
                {
                    string query = @"INSERT INTO Tbl_EntradaProductos (documento, fecha, costoTotal, costoTotalGeneral, precioTotal, codigoProducto, Fk_id_guia, bodega_origen, bodega_destino)
                                     VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@documento", documento);
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@costoTotal", costoTotal);
                        cmd.Parameters.AddWithValue("@costoTotalGeneral", costoTotalGeneral);
                        cmd.Parameters.AddWithValue("@precioTotal", precioTotal);
                        cmd.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                        cmd.Parameters.AddWithValue("@Fk_id_guia", idGuia);
                        cmd.Parameters.AddWithValue("@bodega_origen", bodegaOrigen);
                        cmd.Parameters.AddWithValue("@bodega_destino", bodegaDestino);
                        cmd.ExecuteNonQuery();
                    }
                    conn.desconexion(connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el documento de entrada: " + ex.Message);
            }
        }

        public int ObtenerIdEntradaPorDocumento(string documento)
        {
            int idEntrada = -1;
            try
            {
                using (OdbcConnection connection = conn.Conexion())
                {
                    string query = "SELECT Pk_id_EntradaProductos FROM Tbl_EntradaProductos WHERE documento = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@documento", documento);
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            idEntrada = id;
                        }
                    }
                    conn.desconexion(connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID de entrada: " + ex.Message);
            }
            return idEntrada;
        }
    }
}
