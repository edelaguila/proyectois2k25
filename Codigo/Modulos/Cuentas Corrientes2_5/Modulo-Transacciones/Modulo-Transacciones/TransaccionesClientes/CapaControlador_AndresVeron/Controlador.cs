using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CapaControlador_AndresVeron
{
    public class Controlador
    {
        private CapaModelo_AndresVeron.Sentencias sn = new CapaModelo_AndresVeron.Sentencias();

        // Método para insertar una nueva transacción
        public bool InsertarTransaccion(int idCliente, string fecha, string monto,
            string tipoMoneda, int estado, int idFactura, int idTransC, string tipo)
        {
            return sn.InsertarTransaccion(idCliente, fecha, monto, tipoMoneda,
                estado, idFactura, idTransC, tipo);
        }

        // Método para modificar una transacción existente
        public bool ModificarTransaccion(int idTransaccion, int idCliente, string fecha,
            string monto, string tipoMoneda, int estado, int idFactura, int idTransC, string tipo)
        {
            return sn.ModificarTransaccion(idTransaccion, idCliente, fecha, monto,
                tipoMoneda, estado, idFactura, idTransC, tipo);
        }

        // Método para eliminar una transacción
        public bool EliminarTransaccion(int idTransaccion)
        {
            return sn.EliminarTransaccion(idTransaccion);
        }

        // Método para obtener todas las transacciones
        public DataTable ObtenerTransacciones()
        {
            return sn.ObtenerTransacciones();
        }

        // Método para obtener una transacción específica
        public DataTable ObtenerTransaccionPorId(int idTransaccion)
        {
            return sn.ObtenerTransaccionPorId(idTransaccion);
        }
    }
}