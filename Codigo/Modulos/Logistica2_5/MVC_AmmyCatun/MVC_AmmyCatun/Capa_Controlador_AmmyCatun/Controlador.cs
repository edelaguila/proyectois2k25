using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc; // Para OdbcDataReader
using Capa_Modelo_AmmyCatun; // Para Sentencias
using System.Windows.Forms;
using System.Data;
using System;


namespace Capa_Controlador_AmmyCatun
{
    // Creacion de clase de control datos pedido Realizado por Ammy Patricia Catun Lopez 0901-21-4857
    public class ControladorPedido
    {
        private Capa_Modelo_AmmyCatun.Sentencias sentencias = new Capa_Modelo_AmmyCatun.Sentencias();

        public ControladorPedido(Sentencias @object)
        {
        }

        public ControladorPedido()
        {
        }

        public object getNextId()
        {
            int nextId = sentencias.getMaxIdPedido();
            nextId++;
            return nextId.ToString();
        }

        public DataTable CargarPedidos()
        {
            return sentencias.cargarPedidos();
        }

        // Método para obtener el próximo ID de pedido
        public object GetNextIdPedido()
        {
            int nextId = sentencias.getMaxIdPedido(); // Asegúrate de que este método esté definido en tu clase Sentencias
            return (nextId + 1).ToString();
        }

        // Método para guardar un datos pedido Realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public int guardarPedido(string sDireccionPartida, string sDireccionLlegada, string sNumeroOrdenRecojo, ComboBox cmbFormaPago, string sDestino, DateTime dFechaEmision, DateTime dFechaTraslado, int iIdRemitente, int iIdDestinatario, int iIdvehiculo)
        {

            string sFormaPago = cmbFormaPago.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(sDireccionPartida) || string.IsNullOrEmpty(sDireccionLlegada) || string.IsNullOrEmpty(sFormaPago) || string.IsNullOrEmpty(sDestino))

            {
                MessageBox.Show("Existen campos vacíos, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarPedido(dFechaEmision, dFechaTraslado, sDireccionPartida, sDireccionLlegada, sNumeroOrdenRecojo, sFormaPago, sDestino, iIdRemitente, iIdDestinatario, iIdvehiculo);
                MessageBox.Show("Pedido ingresado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }
        }
        // Método para eliminar  datos pedido Realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public void eliminarPedido(string idGuia)
        {
            if (string.IsNullOrEmpty(idGuia))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sentencias.eliminarPedido(idGuia);
            }
        }
        // Método para modificar datos pedido Realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public int modificarPedido(string sDireccionPartida, string sDireccionLlegada, string sNumeroOrdenRecojo, ComboBox cmbFormaPago, string sDestino, DateTime dFechaEmision, DateTime dFechaTraslado, int iIdRemitente, int iIdDestinatario, int iIdvehiculo, int iIdGuia)
        {

            string sFormaPago = cmbFormaPago.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(sDireccionPartida) || string.IsNullOrEmpty(sDireccionLlegada) || string.IsNullOrEmpty(sFormaPago) || string.IsNullOrEmpty(sDestino))

            {
                MessageBox.Show("Existen campos vacíos, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.modificarPedido(dFechaEmision, dFechaTraslado, sDireccionPartida, sDireccionLlegada, sNumeroOrdenRecojo, sFormaPago, sDestino, iIdRemitente, iIdDestinatario, iIdvehiculo, iIdGuia);
                MessageBox.Show("Pedido modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }
        }
        public string sMIndice(string sIndice1)
        {
            string sIndice = sentencias.ModIndice(sIndice1);

            return sIndice;
        }

        public string sMRuta(string sRuta1)
        {
            string sRuta = sentencias.ModRuta(sRuta1);

            return sRuta;
        }
    }


    //Clase de controlador  de Transporte-Vehiculo Realizado por Ammy Patricia Catun Lopez 0901-21-4857
    public class ControladorVehiculo
    {
        private Capa_Modelo_AmmyCatun.Sentencias sentencias = new Capa_Modelo_AmmyCatun.Sentencias();

        public ControladorVehiculo(Sentencias @object)
        {
        }

        public ControladorVehiculo()
        {
        }

        public DataTable CargarVehiculos()
        {
            return sentencias.cargarVehiculos();
        }

        public object getNextId()
        {
            int nextId = sentencias.getMaxIdVehiculo();
            nextId++;
            return nextId.ToString();
        }

        public int guardarVehiculo(string sNumeroPlaca, string sMarca, string sColor, string sDescripcion, string sHoraLlegada, string sHoraSalida, double doPesoTotal, int iIdChofer)
        {
            if (string.IsNullOrEmpty(sNumeroPlaca) || string.IsNullOrEmpty(sMarca) || string.IsNullOrEmpty(sColor) ||
               doPesoTotal <= 0 || iIdChofer <= 0)
            {
                MessageBox.Show("Existen campos vacíos, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarVehiculo(sNumeroPlaca, sMarca, sColor, sDescripcion, sHoraLlegada, sHoraSalida, doPesoTotal, iIdChofer);
                return 1;
            }
        }
        // Método para modificar vehiculos Realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public int modificarVehiculo(int iIdVehiculo, string sNumeroPlaca, string sMarca, string sColor, string sDescripcion, string sHoraLlegada, string sHoraSalida, double doPesoTotal, int iIdChofer)
        {
            if (iIdVehiculo <= 0 || string.IsNullOrEmpty(sNumeroPlaca) || string.IsNullOrEmpty(sMarca) || string.IsNullOrEmpty(sColor) || string.IsNullOrEmpty(sDescripcion) || string.IsNullOrEmpty(sHoraLlegada) ||
               string.IsNullOrEmpty(sHoraSalida) || doPesoTotal <= 0 || iIdChofer <= 0)
            {
                MessageBox.Show("Existen campos vacíos, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.modificarVehiculo(iIdVehiculo, sNumeroPlaca, sMarca, sColor, sDescripcion, sHoraLlegada, sHoraSalida, doPesoTotal, iIdChofer);
                return 1;
            }
        }

        // Método para Eliminar vehiculos Realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public void eliminarVehiculo(string sIdVehiculo)
        {

            if (string.IsNullOrEmpty(sIdVehiculo))
            {
                MessageBox.Show("Existen campos vacíos, revise y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sentencias.eliminarVehiculo(sIdVehiculo);
            }

        }
        // // Método para agregar la ayuda en  formulario Realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public string MIndice(string Indice1)
        {
            string Indice = sentencias.ModIndice(Indice1);

            return Indice;
        }

        public string MRuta(string Ruta1)
        {
            string sRuta = sentencias.ModRuta(Ruta1);

            return sRuta;
        }
    }
}


   

      











