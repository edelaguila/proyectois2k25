using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CapaVista_CajaCC
{
    public partial class frm_CajaCC : Form
    {
        CapaControlador_CajaCC.Controlador controlador = new CapaControlador_CajaCC.Controlador();

        public frm_CajaCC()
        {
            InitializeComponent();
            LlenarComboClientes();
            LlenarComboProveedores();
            LlenarComboDeudas();
            MostrarDatos();
            dgv_caja_general.CellClick += new DataGridViewCellEventHandler(dgv_caja_general_CellClick);
        }

        private void dgv_caja_general_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implementar en lugar de lanzar excepción
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgv_caja_general.Rows[e.RowIndex];
                    // Llenar los campos con los datos de la fila seleccionada
                    CargarDatosDeFila(row);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CargarDatosDeFila(DataGridViewRow row)
        {
            txt_idcaja.Text = row.Cells["idCaja"].Value?.ToString() ?? "";
            cbo_deuda_caja.Text = row.Cells["idDeuda"].Value?.ToString() ?? "";

            if (row.Cells["idCliente"].Value != null && row.Cells["idCliente"].Value != DBNull.Value)
                cbo_cliente_caja.SelectedValue = row.Cells["idCliente"].Value;
            else
                cbo_cliente_caja.SelectedIndex = -1;

            if (row.Cells["idProveedor"].Value != null && row.Cells["idProveedor"].Value != DBNull.Value)
                cbo_proveedor_caja.SelectedValue = row.Cells["idProveedor"].Value;
            else
                cbo_proveedor_caja.SelectedIndex = -1;

            if (row.Cells["idDeuda"].Value != null && row.Cells["idDeuda"].Value != DBNull.Value)
                cbo_deuda_caja.SelectedValue = row.Cells["idDeuda"].Value;
            else
                cbo_deuda_caja.SelectedIndex = -1;

            txt_mdcaja.Text = row.Cells["montoDeuda"].Value?.ToString() ?? "0";
            txt_mmcaja.Text = row.Cells["montoMora"].Value?.ToString() ?? "0";
            txt_mtcaja.Text = row.Cells["montoTransaccion"].Value?.ToString() ?? "0";
            txt_saldocaja.Text = row.Cells["saldoRestante"].Value?.ToString() ?? "0";
            txt_estadocaja.Text = row.Cells["estado"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["fechaRegistro"].Value?.ToString(), out DateTime fecha))
                dtp_caja.Value = fecha;
            else
                dtp_caja.Value = DateTime.Now;
        }
        private void LlenarComboClientes()
        {
            cbo_cliente_caja.DataSource = controlador.ObtenerClientes();
            cbo_cliente_caja.DisplayMember = "nombre_cliente";
            cbo_cliente_caja.ValueMember = "id_cliente";
        }

        // Cargar proveedores al combo
        private void LlenarComboProveedores()
        {
            cbo_proveedor_caja.DataSource = controlador.ObtenerProveedores();
            cbo_proveedor_caja.DisplayMember = "nombre_proveedor";
            cbo_proveedor_caja.ValueMember = "id_proveedor";
        }

        private void LlenarComboDeudas()
        {
            cbo_deuda_caja.DataSource = controlador.ObtenerDeudas();
            cbo_deuda_caja.DisplayMember = "descripcion_deuda";
            cbo_deuda_caja.ValueMember = "id_deuda";
        }
        // Validar que campos numéricos contengan números
        private bool ValidarCamposNumericos()
        {
            decimal temp;
            int tempInt;

            if (!decimal.TryParse(txt_mdcaja.Text, out temp))
            {
                MessageBox.Show("El monto de deuda debe ser un valor numérico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txt_mmcaja.Text, out temp))
            {
                MessageBox.Show("El monto de mora debe ser un valor numérico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txt_mtcaja.Text, out temp))
            {
                MessageBox.Show("El monto de transacción debe ser un valor numérico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txt_saldocaja.Text, out temp))
            {
                MessageBox.Show("El saldo debe ser un valor numérico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txt_estadocaja.Text, out tempInt))
            {
                MessageBox.Show("El estado debe ser un valor numérico (0 o 1).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // <- Esto es lo que faltaba

        }


        private void CajaCC_Load(object sender, EventArgs e)
        { // Inicialización al cargar el formulario
            MostrarDatos();
            cbo_cliente_caja.SelectedIndexChanged += ClienteSeleccionado;
            cbo_proveedor_caja.SelectedIndexChanged += ProveedorSeleccionado;
            BloquearCampos();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposNumericos()) return;

            if (string.IsNullOrEmpty(cbo_deuda_caja.Text))
            {
                MessageBox.Show("El ID de deuda no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool resultado = controlador.InsertarCaja(
                    txt_idcaja.Text,
                    cbo_cliente_caja.SelectedValue?.ToString(),
                    cbo_proveedor_caja.SelectedValue?.ToString(),
                    cbo_deuda_caja.SelectedValue?.ToString(),  // Usar el ID de deuda del combo
                    txt_mdcaja.Text,
                    txt_mmcaja.Text,
                    txt_mtcaja.Text,
                    txt_saldocaja.Text,
                    txt_estadocaja.Text,
                    dtp_caja.Value.ToString("yyyy-MM-dd")  // <-- Se usa el DateTimePicker formateado
                );

                if (resultado)
                {
                    MessageBox.Show("Registro guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClienteSeleccionado(object sender, EventArgs e)
        {
            if (cbo_cliente_caja.SelectedIndex >= 0 && cbo_cliente_caja.SelectedValue != null)
            {
                cbo_proveedor_caja.Enabled = false;
            }
            else
            {
                cbo_proveedor_caja.Enabled = true;
            }
        }

        private void ProveedorSeleccionado(object sender, EventArgs e)
        {
            if (cbo_proveedor_caja.SelectedIndex >= 0 && cbo_proveedor_caja.SelectedValue != null)
            {
                cbo_cliente_caja.Enabled = false;
            }
            else
            {
                cbo_cliente_caja.Enabled = true;
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idcaja.Text))
            {
                MessageBox.Show("Seleccione un registro para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool resultado = controlador.EliminarCaja(txt_idcaja.Text);

                    if (resultado)
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarDatos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Btn_editar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_idcaja.Text))
            {
                MessageBox.Show("Seleccione un registro para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarCamposNumericos()) return;

            try
            {
                bool resultado = controlador.ActualizarCaja(
                    txt_idcaja.Text,
                    cbo_cliente_caja.SelectedValue?.ToString(),
                    cbo_proveedor_caja.SelectedValue?.ToString(),
                    cbo_deuda_caja.SelectedValue?.ToString(),  // Usar el ID de deuda del combo
                    txt_mdcaja.Text,
                    txt_mmcaja.Text,
                    txt_mtcaja.Text,
                    txt_saldocaja.Text,
                    txt_estadocaja.Text,
                    dtp_caja.Value.ToString("yyyy-MM-dd")  // <-- Ahora se usa correctamente el DateTimePicker
                );

                if (resultado)
                {
                    MessageBox.Show("Registro actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HabilitarCampos()
        {
            txt_mdcaja.Enabled = true;
            txt_mmcaja.Enabled = true;
            txt_mtcaja.Enabled = true;
            txt_saldocaja.Enabled = true;
            txt_estadocaja.Enabled = true;
            dtp_caja.Enabled = true; // Cambiado a dtp_caja
            cbo_cliente_caja.Enabled = true;
            cbo_proveedor_caja.Enabled = true;
            cbo_deuda_caja.Enabled = true;
        }
        private void BloquearCampos()
        {
            txt_idcaja.Enabled = false;
            txt_mdcaja.Enabled = false;
            txt_mmcaja.Enabled = false;
            txt_mtcaja.Enabled = false;
            txt_saldocaja.Enabled = false;
            txt_estadocaja.Enabled = false;
            dtp_caja.Enabled = false; // Cambiado a dtp_caja
            cbo_cliente_caja.Enabled = false;
            cbo_proveedor_caja.Enabled = false;
            cbo_deuda_caja.Enabled = false;
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string cliente = cbo_cliente_caja.Text;
            string proveedor = cbo_proveedor_caja.Text;
            string estado = txt_estadocaja.Text;
            string fecha = dtp_caja.Value.ToString("yyyy-MM-dd"); // <-- Corregido: usar DateTimePicker

            try
            {
                DataTable resultado = controlador.BuscarCaja(cliente, proveedor, estado, fecha);

                if (resultado.Rows.Count > 0)
                {
                    dgv_caja_general.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros con los criterios especificados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDatos(); // Volver a mostrar todos los datos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarDatos()
        {
            try
            {
                dgv_caja_general.DataSource = controlador.MostrarCaja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            // Limpiar campos de texto
            txt_idcaja.Clear();
            txt_mdcaja.Clear();
            txt_mmcaja.Clear();
            txt_mtcaja.Clear();
            txt_saldocaja.Clear();
            txt_estadocaja.Clear();

            // Reiniciar el DateTimePicker a la fecha actual
            dtp_caja.Value = DateTime.Now;

            // Resetear los combo box si tienen elementos
            if (cbo_cliente_caja.Items.Count > 0)
                cbo_cliente_caja.SelectedIndex = 0;
            if (cbo_proveedor_caja.Items.Count > 0)
                cbo_proveedor_caja.SelectedIndex = 0;
            if (cbo_deuda_caja.Items.Count > 0)
                cbo_deuda_caja.SelectedIndex = 0;

            // Establecer foco en el primer campo
            txt_idcaja.Focus();
        }

        private void dgv_caja_general_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgv_caja_general.Rows[e.RowIndex];
                    txt_idcaja.Text = row.Cells["idCaja"].Value?.ToString() ?? "";

                    if (row.Cells["idCliente"].Value != null && row.Cells["idCliente"].Value != DBNull.Value)
                        cbo_cliente_caja.SelectedValue = row.Cells["idCliente"].Value;
                    else
                        cbo_cliente_caja.SelectedIndex = -1;

                    if (row.Cells["idProveedor"].Value != null && row.Cells["idProveedor"].Value != DBNull.Value)
                        cbo_proveedor_caja.SelectedValue = row.Cells["idProveedor"].Value;
                    else
                        cbo_proveedor_caja.SelectedIndex = -1;

                    if (row.Cells["idDeuda"].Value != null && row.Cells["idDeuda"].Value != DBNull.Value)
                        cbo_deuda_caja.SelectedValue = row.Cells["idDeuda"].Value;
                    else
                        cbo_deuda_caja.SelectedIndex = -1;

                    txt_mdcaja.Text = row.Cells["montoDeuda"].Value?.ToString() ?? "0";
                    txt_mmcaja.Text = row.Cells["montoMora"].Value?.ToString() ?? "0";
                    txt_mtcaja.Text = row.Cells["montoTransaccion"].Value?.ToString() ?? "0";
                    txt_saldocaja.Text = row.Cells["saldoRestante"].Value?.ToString() ?? "0";
                    txt_estadocaja.Text = row.Cells["estado"].Value?.ToString() ?? "";

                    // Convertir la fecha al tipo de dato DateTime
                    if (DateTime.TryParse(row.Cells["fechaRegistro"].Value?.ToString(), out DateTime fecha))
                        dtp_caja.Value = fecha;
                    else
                        dtp_caja.Value = DateTime.Now; // Valor por defecto si falla la conversión
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }



