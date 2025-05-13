using System;
using System.Data;
using CapaModelo_CajaCC;

namespace CapaControlador_CajaCC
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();

        // Métodos para uso interno con tipos fuertes
        public bool InsertarCaja(int? idCliente, int? idProveedor, int idDeuda,
            decimal deudaMonto, decimal moraMonto, decimal transaccionMonto,
            decimal saldoRestante, int estado, string fechaRegistro)
        {
            return sn.InsertarCaja(idCliente, idProveedor, idDeuda, deudaMonto,
                moraMonto, transaccionMonto, saldoRestante, estado, fechaRegistro);
        }

        public bool ModificarCaja(int idCaja, int? idCliente, int? idProveedor, int idDeuda,
            decimal deudaMonto, decimal moraMonto, decimal transaccionMonto,
            decimal saldoRestante, int estado, string fechaRegistro)
        {
            return sn.ModificarCaja(idCaja, idCliente, idProveedor, idDeuda, deudaMonto,
                moraMonto, transaccionMonto, saldoRestante, estado, fechaRegistro);
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
        public bool InsertarCaja(string idCaja, string idCliente, string idProveedor, string idDeuda,
            string montoDeuda, string montoMora, string montoTransaccion,
            string saldo, string estado, string fechaRegistro)
        {
            int? cliente = string.IsNullOrWhiteSpace(idCliente) ? (int?)null : Convert.ToInt32(idCliente);
            int? proveedor = string.IsNullOrWhiteSpace(idProveedor) ? (int?)null : Convert.ToInt32(idProveedor);

            // Usar el idDeuda proporcionado
            int deuda = Convert.ToInt32(idDeuda);

            decimal deudaMonto = Convert.ToDecimal(montoDeuda);
            decimal moraMonto = Convert.ToDecimal(montoMora);
            decimal transMonto = Convert.ToDecimal(montoTransaccion);
            decimal saldoRestante = Convert.ToDecimal(saldo);
            int estadoInt = Convert.ToInt32(estado);

            return InsertarCaja(cliente, proveedor, deuda, deudaMonto, moraMonto, transMonto, saldoRestante, estadoInt, fechaRegistro);
        }

        public bool ActualizarCaja(string idCaja, string idCliente, string idProveedor, string idDeuda,
            string montoDeuda, string montoMora, string montoTransaccion,
            string saldo, string estado, string fechaRegistro)
        {
            int id = Convert.ToInt32(idCaja);
            int? cliente = string.IsNullOrWhiteSpace(idCliente) ? (int?)null : Convert.ToInt32(idCliente);
            int? proveedor = string.IsNullOrWhiteSpace(idProveedor) ? (int?)null : Convert.ToInt32(idProveedor);

            // Usar el idDeuda proporcionado en lugar de idCaja
            int deuda = Convert.ToInt32(idDeuda);

            decimal deudaMonto = Convert.ToDecimal(montoDeuda);
            decimal moraMonto = Convert.ToDecimal(montoMora);
            decimal transMonto = Convert.ToDecimal(montoTransaccion);
            decimal saldoRestante = Convert.ToDecimal(saldo);
            int estadoInt = Convert.ToInt32(estado);

            return ModificarCaja(id, cliente, proveedor, deuda, deudaMonto, moraMonto, transMonto, saldoRestante, estadoInt, fechaRegistro);
        }

        public bool EliminarCaja(string idCaja)
        {
            int id = Convert.ToInt32(idCaja);
            return EliminarCaja(id);
        }
    }
}