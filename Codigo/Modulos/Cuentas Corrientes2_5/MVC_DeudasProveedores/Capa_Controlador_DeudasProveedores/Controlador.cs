using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Modelo_DeudasProveedores;

namespace Capa_Controlador_DeudasProveedores
{
    public class Controlador
    {
        Capa_Modelo_DeudasProveedores.Sentencias sentencias = new Capa_Modelo_DeudasProveedores.Sentencias();
        public string idDeudaSeleccionada;
        public bool esEdicion = false;

        // Método para mostrar todas las deudas
        public OdbcDataAdapter MostrarDeudas()
        {
            try
            {
                return sentencias.ObtenerDeudas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar deudas: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Guardar o actualizar deuda
        public int GuardarDeuda(string id_deuda, string id_proveedor, string monto, string Txt_fecha_ini, string Txt_fecha_venci,
                        string descripcion, string estado, string transaccionTipo, string id_factura)
        {
            // 1) Validaciones básicas...
            if (string.IsNullOrEmpty(id_deuda) ||
                string.IsNullOrEmpty(id_proveedor) ||
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
                // Llamamos al método que devuelve un DataTable con columnas "totalPagar" y "saldo"
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
                    sentencias.ActualizarDeuda(idDeudaSeleccionada, id_proveedor, monto, Txt_fecha_ini,
                                               Txt_fecha_venci, descripcion, estado, transaccionTipo, id_factura);
                    MessageBox.Show("Registro actualizado correctamente", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    esEdicion = false;
                }
                else
                {
                    sentencias.InsertarDeuda(id_deuda, id_proveedor, monto, Txt_fecha_ini, Txt_fecha_venci,
                                              descripcion, estado, transaccionTipo, id_factura);
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

        // Método para eliminar una deuda
        public int EliminarDeuda(string idDeuda)
        {
            if (string.IsNullOrEmpty(idDeuda))
            {
                MessageBox.Show("No se pudo eliminar el registro. El ID es nulo o vacío.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            try
            {
                // Llama al método mejorado que revierte el saldo y luego elimina
                int filas = sentencias.EliminarDeuda(idDeuda);
                return filas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar deuda: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public DataTable BuscarDeudas(string idDeuda, string proveedorId, string facturaId, string estado)
        {
            return sentencias.BuscarDeudas(idDeuda, proveedorId, facturaId, estado);
        }

        // Método para verificar si existe una deuda con el ID proporcionado
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

        public OdbcDataAdapter ObtenerTiposTransaccion()
        {
            Sentencias sentencia = new Sentencias();
            return sentencia.ObtenerTiposTransaccion();
        }


        // Método para obtener proveedores para llenar combobox
        public OdbcDataAdapter ObtenerProveedores()
        {
            try
            {
                return sentencias.ObtenerProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener proveedores: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

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

        public OdbcDataAdapter ObtenerFacturasPorProveedor(string idProveedor)
        {
            try
            {
                return sentencias.ObtenerFacturasPorProveedor(idProveedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener facturas del proveedor: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}