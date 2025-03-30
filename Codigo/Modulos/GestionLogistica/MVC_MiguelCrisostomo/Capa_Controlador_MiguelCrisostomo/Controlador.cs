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

        // Constructor sin parámetros
        public controlador()
        {
            sentencias = new Capa_Modelo_MiguelCrisostomo.sentencias();
        }

        // Constructor que acepta un mock de sentencias para pruebas unitarias
        public controlador(Capa_Modelo_MiguelCrisostomo.sentencias sentenciasMock)
        {
            sentencias = sentenciasMock;
        }

        private conexion conn = new conexion(); // Instancia de la clase Conexion
              
        public void registrarTrasladoProductos(string documento, string fecha, int costoTotal, int costoTotalGeneral, int precioTotal, int idProducto, int idGuia, int codigoProducto)
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
                sentencias.RealizarTraslado(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto);
               
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
            sentencias modelo = new sentencias(); // Instancia de la clase sentencias  
            modelo.ActualizarStockProducto(codigoProducto, nuevoStock); // Llama al método en la capa de modelo  
        }

    }
}
