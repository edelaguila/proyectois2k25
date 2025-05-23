using System;
using System.Data;
using CapaModelo_CajaCC;

namespace CapaControlador_CajaCC
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();

        // Métodos para uso interno con tipos fuertes
        public bool InsertarCaja(int? idCliente, int? idProveedor, int? idDeuda, int? idDeudaProveedor,
            decimal saldoRestante, int estado, string fechaRegistro)
        {
            return sn.InsertarCaja(idCliente, idProveedor, idDeuda, idDeudaProveedor,
                saldoRestante, estado, fechaRegistro);
        }

        public bool ModificarCaja(int idCaja, int? idCliente, int? idProveedor, int? idDeuda, int? idDeudaProveedor,
            decimal saldoRestante, int estado, string fechaRegistro)
        {
            return sn.ModificarCaja(idCaja, idCliente, idProveedor, idDeuda, idDeudaProveedor,
                saldoRestante, estado, fechaRegistro);
        }

        public bool EliminarCaja(int idCaja)
        {
            return sn.EliminarCaja(idCaja);
        }

        public DataTable ObtenerClientes()
        {
            return sn.ObtenerClientes();
        }

        public DataTable ObtenerProveedores()
        {
            return sn.ObtenerProveedores();
        }

        public DataTable ObtenerDeudas()
        {
            return sn.ObtenerDeudas();
        }

        public DataTable ObtenerDeudasProveedores()
        {
            return sn.ObtenerDeudasProveedores();
        }

        public DataTable ObtenerCajas()
        {
            return sn.ObtenerCajas();
        }

        public DataTable ObtenerCajaPorId(int idCaja)
        {
            return sn.ObtenerCajaPorId(idCaja);
        }

        public DataTable BuscarCaja(string cliente, string proveedor, string estado, string fecha)
        {
            return sn.BuscarCaja(cliente, proveedor, estado, fecha);
        }

        public DataTable MostrarCaja()
        {
            return sn.MostrarCaja();
        }

        // Métodos públicos que reciben strings desde la capa de Vista y hacen parsing/validación
        public bool InsertarCaja(string idCaja, string idCliente, string idProveedor, string idDeuda, string idDeudaProveedor,
            string saldo, string estado, string fechaRegistro)
        {
            int? cliente = string.IsNullOrWhiteSpace(idCliente) ? (int?)null : Convert.ToInt32(idCliente);
            int? proveedor = string.IsNullOrWhiteSpace(idProveedor) ? (int?)null : Convert.ToInt32(idProveedor);
            int? deuda = string.IsNullOrWhiteSpace(idDeuda) ? (int?)null : Convert.ToInt32(idDeuda);
            int? deudaProveedor = string.IsNullOrWhiteSpace(idDeudaProveedor) ? (int?)null : Convert.ToInt32(idDeudaProveedor);

            decimal saldoRestante = Convert.ToDecimal(saldo);
            int estadoInt = Convert.ToInt32(estado);

            return InsertarCaja(cliente, proveedor, deuda, deudaProveedor, saldoRestante, estadoInt, fechaRegistro);
        }

        public bool ActualizarCaja(string idCaja, string idCliente, string idProveedor, string idDeuda, string idDeudaProveedor,
            string saldo, string estado, string fechaRegistro)
        {
            int id = Convert.ToInt32(idCaja);
            int? cliente = string.IsNullOrWhiteSpace(idCliente) ? (int?)null : Convert.ToInt32(idCliente);
            int? proveedor = string.IsNullOrWhiteSpace(idProveedor) ? (int?)null : Convert.ToInt32(idProveedor);
            int? deuda = string.IsNullOrWhiteSpace(idDeuda) ? (int?)null : Convert.ToInt32(idDeuda);
            int? deudaProveedor = string.IsNullOrWhiteSpace(idDeudaProveedor) ? (int?)null : Convert.ToInt32(idDeudaProveedor);

            decimal saldoRestante = Convert.ToDecimal(saldo);
            int estadoInt = Convert.ToInt32(estado);

            return ModificarCaja(id, cliente, proveedor, deuda, deudaProveedor, saldoRestante, estadoInt, fechaRegistro);
        }

        public bool EliminarCaja(string idCaja)
        {
            int id = Convert.ToInt32(idCaja);
            return EliminarCaja(id);
        }
    }
}