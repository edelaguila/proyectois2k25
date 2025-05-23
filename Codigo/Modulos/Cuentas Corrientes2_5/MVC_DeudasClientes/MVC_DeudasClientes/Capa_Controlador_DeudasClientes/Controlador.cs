using Capa_Modelo_DeudasClientes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Controlador_DeudasClientes
{
    public class Controlador
    {
        Capa_Modelo_DeudasClientes.Sentencias sentencias = new Capa_Modelo_DeudasClientes.Sentencias();

        public string idDeudaSeleccionada;
        public bool esEdicion = false;

        // Mostrar deudas
        public OdbcDataAdapter MostrarDeudas()
        {
            try
            {
                return sentencias.ObtenerDeudas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar deudas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Guardar o actualizar deuda cliente
        public int GuardarDeuda(string id_deuda, string id_cliente, string id_cobrador, string monto,
                                       string Txt_fecha_ini, string Txt_fecha_venci,
                                       string descripcion, string estado, string transaccionTipo, string id_factura)
        {
            // 1) Validaciones básicas...
            if (string.IsNullOrEmpty(id_deuda) ||
                string.IsNullOrEmpty(id_cliente) ||
                string.IsNullOrEmpty(id_cobrador) ||
                string.IsNullOrEmpty(monto) ||
                string.IsNullOrEmpty(Txt_fecha_ini) ||
                string.IsNullOrEmpty(Txt_fecha_venci) ||
                string.IsNullOrEmpty(descripcion) ||
                string.IsNullOrEmpty(estado) ||
                string.IsNullOrEmpty(transaccionTipo))
            {
                MessageBox.Show("Existen campos vacíos, revise y vuelva a intentarlo", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            // 2) Verificar que el monto sea numérico
            if (!decimal.TryParse(monto, out decimal montoDecimal))
            {
                MessageBox.Show("El monto debe ser un valor numérico válido.", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            // 3) Validación contra saldo de factura
            if (!string.IsNullOrEmpty(id_factura) && id_factura != "0")
            {
                DataTable dtFactura = sentencias.ObtenerDatosFactura(id_factura);
                if (dtFactura.Rows.Count > 0)
                {
                    decimal saldoFactura = Convert.ToDecimal(dtFactura.Rows[0]["saldo"]);
                    if (montoDecimal > saldoFactura)
                    {
                        MessageBox.Show($"El monto de la deuda ({montoDecimal:C}) no puede ser mayor al saldo restante de la factura ({saldoFactura:C}).",
                                        "Monto inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return 0;
                    }
                }
            }

            // 4) Verificar duplicados si no es edición
            if (!esEdicion && ExisteDeuda(id_deuda))
            {
                MessageBox.Show("Ya existe una deuda con este ID. Ingrese un ID diferente.", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            // 5) Insertar o actualizar
            try
            {
                if (esEdicion)
                {
                    sentencias.ActualizarDeuda(idDeudaSeleccionada, id_cliente, id_cobrador, monto, Txt_fecha_ini,
                                                      Txt_fecha_venci, descripcion, estado, transaccionTipo, id_factura);
                    MessageBox.Show("Registro actualizado correctamente", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    esEdicion = false;
                }
                else
                {
                    sentencias.InsertarDeuda(id_deuda, id_cliente, id_cobrador, monto, Txt_fecha_ini,
                                                    Txt_fecha_venci, descripcion, estado, transaccionTipo, id_factura);
                    MessageBox.Show("Registro guardado correctamente", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar/actualizar deuda: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        // Eliminar deuda
        public int EliminarDeuda(string idDeuda)
        {
            if (string.IsNullOrEmpty(idDeuda))
            {
                MessageBox.Show("No se pudo eliminar el registro. El ID es nulo o vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            try
            {
                // Llamar al método de sentencias para eliminar deuda de cliente
                return sentencias.EliminarDeuda(idDeuda);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar deuda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        // Verificar existencia de deuda
        public bool ExisteDeuda(string idDeuda)
        {
            try
            {
                return sentencias.ExisteDeuda(idDeuda);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar existencia de deuda: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Cargar combobox de clientes
        public OdbcDataAdapter ObtenerClientes()
        {
            return sentencias.ObtenerClientes();
        }

        // Cargar combobox de cobradores
        public OdbcDataAdapter ObtenerCobradores()
        {
            return sentencias.ObtenerCobradores();
        }

        // Cargar tipos de transacción
        public OdbcDataAdapter ObtenerTiposTransaccion()
        {
            return sentencias.ObtenerTiposTransaccion();
        }

        // Cargar facturas por cliente
        public OdbcDataAdapter ObtenerFacturasPorCliente(string idCliente)
        {
            return sentencias.ObtenerFacturasPorCliente(idCliente);
        }

        // Obtener saldo y total de factura
        public DataTable ObtenerDatosFactura(string idFactura)
        {
            try
            {
                return sentencias.ObtenerDatosFactura(idFactura);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos de la factura: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Buscar deudas
        public DataTable BuscarDeudas(string idDeuda, string clienteId, string facturaId, string estado)
        {
            return sentencias.BuscarDeudas(idDeuda, clienteId, facturaId, estado);
        }


    }
}
