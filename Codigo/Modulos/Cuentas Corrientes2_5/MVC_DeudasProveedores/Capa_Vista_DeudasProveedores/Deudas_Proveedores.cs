using Capa_Controlador_DeudasProveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_DeudasProveedores
{
    public partial class Deudas_Proveedores : Form
    {
        Capa_Controlador_DeudasProveedores.Controlador controlador = new Capa_Controlador_DeudasProveedores.Controlador();
        public Deudas_Proveedores()
        {
            InitializeComponent();
        }

        public class ComboBoxItem
        {
            public string Value { get; set; }
            public string Text { get; set; }

            public ComboBoxItem(string value, string text)
            {
                Value = value;
                Text = text;
            }

            public override string ToString()
            {
                return Text;  // Esto es lo que se muestra en el ComboBox
            }
        }

        private void CargarDatos()
        {
            try
            {
                OdbcDataAdapter adapter = controlador.MostrarDeudas();
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Dgv_deudas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            // Limpiar campos
            limpiarCampos();

            // Habilitar botones para un nuevo registro
            HabilitarCampos(true);
            Btn_guardar.Enabled = true;
            Btn_eliminar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_Buscar.Enabled = true;
            Txt_id_deuda.ReadOnly = false;

            // Establecer que no estamos en modo edición
            controlador.esEdicion = false;

            // Actualizar datos del DataGridView
            CargarDatos();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            // Validaciones básicas
            if (string.IsNullOrEmpty(Txt_id_deuda.Text))
            {
                MessageBox.Show("Debe ingresar un ID de movimiento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_id_deuda.Focus();
                return;
            }

            if (Cbo_id_proveedor.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cbo_id_proveedor.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Txt_montoDeuda.Text))
            {
                MessageBox.Show("Debe ingresar un monto para el movimiento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_montoDeuda.Focus();
                return;
            }

            // Verificar que el monto sea un valor numérico
            if (!decimal.TryParse(Txt_montoDeuda.Text, out _))
            {
                MessageBox.Show("El monto debe ser un valor numérico válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_montoDeuda.Focus();
                return;
            }

            // Si no es una edición, verificar que el ID no exista ya
            if (!controlador.esEdicion && ExisteDeuda(Txt_id_deuda.Text))
            {
                MessageBox.Show("Ya existe un movimiento con este ID. Ingrese un ID diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_id_deuda.Focus();
                return;
            }

            var itemSeleccionado = (ComboBoxItem)Cbo_id_proveedor.SelectedItem;
            int idProveedor = Convert.ToInt32(itemSeleccionado.Value);

            // Si los campos de estado o tipo de transacción están vacíos, asignar valores predeterminados
            string estado = Cbo_estado.Text;
            if (string.IsNullOrEmpty(estado))
            {
                estado = "Pendiente";
                Cbo_estado.Text = estado;
            }

            string tipoTrans = Cbo_Tipotrans.Text;
            if (string.IsNullOrEmpty(tipoTrans))
            {
                tipoTrans = "Compra";
                Cbo_Tipotrans.Text = tipoTrans;
            }

            int resultado = controlador.GuardarDeuda(Txt_id_deuda.Text, idProveedor.ToString(), Txt_montoDeuda.Text,
                                              Dtp_Inicio.Value.ToString("yyyy-MM-dd"),
                                              Dtp_Vencimiento.Value.ToString("yyyy-MM-dd"),
                                              Txt_Descripcion.Text,
                                              estado, tipoTrans,
                                              Cbo_idfactura.SelectedItem != null ?
                                                  ((ComboBoxItem)Cbo_idfactura.SelectedItem).Value : "0");

            if (resultado == 1)
            {
                HabilitarCampos(false);
                CargarDatos();
                limpiarCampos();
                // Deshabilitar nuevamente después de guardar
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_eliminar.Enabled = false;
                Btn_Buscar.Enabled = false;
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {

            if (Cbo_id_proveedor.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var itemSeleccionado = (ComboBoxItem)Cbo_id_proveedor.SelectedItem;
            int idProveedor = Convert.ToInt32(itemSeleccionado.Value);

            if (string.IsNullOrEmpty(Txt_id_deuda.Text))
            {
                MessageBox.Show("Seleccione una deuda para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Establecer que estamos en modo edición
            controlador.idDeudaSeleccionada = Txt_id_deuda.Text;
            controlador.esEdicion = true;

            string idFactura = "0";
            if (Cbo_idfactura.SelectedItem != null)
            {
                idFactura = ((ComboBoxItem)Cbo_idfactura.SelectedItem).Value;
            }

            int resultado = controlador.GuardarDeuda(
                Txt_id_deuda.Text,
                idProveedor.ToString(),
                Txt_montoDeuda.Text,
                Dtp_Inicio.Value.ToString("yyyy-MM-dd"),
                Dtp_Vencimiento.Value.ToString("yyyy-MM-dd"),
                Txt_Descripcion.Text,
                Cbo_estado.Text,
                Cbo_Tipotrans.Text,
                idFactura);

            if (resultado == 1)
            {
                HabilitarCampos(false);
                CargarDatos();
                limpiarCampos();
                Btn_editar.Enabled = false;
                Btn_eliminar.Enabled = false;
                MessageBox.Show("Registro editado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_deudas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idDeuda = Dgv_deudas.CurrentRow.Cells["Pk_id_deuda"].Value.ToString();
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                "Confirmar eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes)
                return;

            int result = controlador.EliminarDeuda(idDeuda);
            if (result > 0)
            {
                MessageBox.Show("Registro eliminado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                limpiarCampos();
                HabilitarCampos(false);   // <--- Aquí bloqueas todo de nuevo
                Btn_eliminar.Enabled = false;
                Btn_editar.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se eliminó ningún registro.", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string idDeuda = Txt_id_deuda.Text.Trim();
            string proveedorId = Cbo_id_proveedor.SelectedItem != null ? ((ComboBoxItem)Cbo_id_proveedor.SelectedItem).Value : "";
            string facturaId = Cbo_idfactura.SelectedItem != null ? ((ComboBoxItem)Cbo_idfactura.SelectedItem).Value : "";
            string estado = Cbo_estado.Text.Trim(); // Espera "1" o "0"

            DataTable dt = controlador.BuscarDeudas(idDeuda, proveedorId, facturaId, estado);

            if (dt.Rows.Count > 0)
            {
                Dgv_deudas.DataSource = dt; // Muestra resultados en el DataGridView
                limpiarCampos();
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_eliminar.Enabled = false;
                Btn_Buscar.Enabled = false;
                MessageBox.Show("Resultados encontrados.");

            }
            else
            {
                MessageBox.Show("No se encontraron registros con los criterios ingresados.");
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            // Implementar salida
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir del formulario?",
                                                 "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void limpiarCampos()
        {
            Txt_id_deuda.Text = "";
            Cbo_id_proveedor.SelectedIndex = -1;
            Txt_montoDeuda.Text = "";
            Dtp_Inicio.Value = DateTime.Now;
            Dtp_Vencimiento.Value = DateTime.Now;
            Txt_Descripcion.Text = "";
            Cbo_estado.SelectedIndex = -1;
            Cbo_Tipotrans.SelectedIndex = -1;
            Cbo_idfactura.SelectedIndex = -1;
            Txt_saldo_restante.Text = "";
            Txt_saldoInicial.Text = "";
        }
        private void Deudas_Proveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarProveedores();
            CargarTiposTransaccion();
            limpiarCampos();
            HabilitarCampos(false);
            // Deshabilitar botones al iniciar
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_Buscar.Enabled = false;
        }

        private void CargarProveedores()
        {
            try
            {
                OdbcDataAdapter adapter = controlador.ObtenerProveedores();
                if (adapter == null) return;

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string id = row["Pk_prov_id"].ToString();
                    string nombre = row["Prov_nombre"].ToString();
                    Cbo_id_proveedor.Items.Add(new ComboBoxItem(id, nombre));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgv_deudas_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_deudas.SelectedRows.Count > 0)
            {
                try
                {
                    HabilitarCampos(true);

                    var filaSeleccionada = Dgv_deudas.SelectedRows[0];

                    // Habilitar el botón de editar cuando se selecciona un registro
                    Btn_guardar.Enabled = false;
                    Btn_editar.Enabled = true;
                    Btn_eliminar.Enabled = true;
                    Btn_Buscar.Enabled = false;

                    // Llenar los campos con la información del registro seleccionado
                    Txt_id_deuda.Text = filaSeleccionada.Cells["Pk_id_deuda"].Value.ToString();
                    Txt_id_deuda.ReadOnly = true; // No permitir editar el ID en modo edición

                    // Seleccionar el proveedor en el ComboBox
                    string idProveedorSeleccionado = filaSeleccionada.Cells["Fk_id_proveedor"].Value.ToString();
                    foreach (ComboBoxItem item in Cbo_id_proveedor.Items)
                    {
                        if (item.Value == idProveedorSeleccionado)
                        {
                            Cbo_id_proveedor.SelectedItem = item;
                            break;
                        }
                    }

                    Txt_montoDeuda.Text = filaSeleccionada.Cells["deuda_monto"].Value.ToString();

                    // Verificar si las fechas son válidas antes de asignarlas
                    if (DateTime.TryParse(filaSeleccionada.Cells["deuda_fecha_inicio"].Value.ToString(), out DateTime fechaInicio))
                    {
                        Dtp_Inicio.Value = fechaInicio;
                    }

                    if (DateTime.TryParse(filaSeleccionada.Cells["deuda_fecha_vencimiento"].Value.ToString(), out DateTime fechaVencimiento))
                    {
                        Dtp_Vencimiento.Value = fechaVencimiento;
                    }

                    Txt_Descripcion.Text = filaSeleccionada.Cells["deuda_descripcion"].Value.ToString();

                    // Asignar estado y tipo de transacción
                    string estado = filaSeleccionada.Cells["deuda_estado"].Value.ToString();
                    if (!string.IsNullOrEmpty(estado))
                    {
                        Cbo_estado.Text = estado;
                    }

                    string tipoTrans = filaSeleccionada.Cells["transaccion_tipo"].Value.ToString();
                    if (!string.IsNullOrEmpty(tipoTrans))
                    {
                        Cbo_Tipotrans.Text = tipoTrans;
                    }

                    // Seleccionar la factura en el ComboBox si existe
                    if (filaSeleccionada.Cells["Fk_id_factura"].Value != null)
                    {
                        string idFactura = filaSeleccionada.Cells["Fk_id_factura"].Value.ToString();
                        foreach (ComboBoxItem item in Cbo_idfactura.Items)
                        {
                            if (item.Value == idFactura)
                            {
                                Cbo_idfactura.SelectedItem = item;
                                break;
                            }
                        }
                    }

                    // Establecer que estamos en modo edición para el controlador
                    controlador.idDeudaSeleccionada = Txt_id_deuda.Text;
                    controlador.esEdicion = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos del registro seleccionado: {ex.Message}",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarFacturasPorProveedor(string idProveedor)
        {
            try
            {
                Cbo_idfactura.Items.Clear();

                OdbcDataAdapter adapter = controlador.ObtenerFacturasPorProveedor(idProveedor);
                if (adapter == null) return;

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string idFactura = row["Pk_id_FacturaProv"].ToString();
                    string numeroFactura = row["Fk_numero_factura"].ToString();
                    Cbo_idfactura.Items.Add(new ComboBoxItem(idFactura, numeroFactura));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar facturas: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTiposTransaccion()
        {
            try
            {
                OdbcDataAdapter adapter = controlador.ObtenerTiposTransaccion();
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Cbo_Tipotrans.DisplayMember = "tran_nombre";
                Cbo_Tipotrans.ValueMember = "tran_nombre";
                Cbo_Tipotrans.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de transacción: " + ex.Message);
            }
        }

        private bool ExisteDeuda(string idDeuda)
        {
            string query = "SELECT COUNT(*) FROM tbl_deudas_proveedores WHERE Pk_id_deuda = ?";
            using (OdbcConnection conn = new OdbcConnection("Dsn=colchoneria"))
            using (OdbcCommand cmd = new OdbcCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", idDeuda);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al verificar existencia de deuda: {ex.Message}",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void Dgv_deudas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cbo_id_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_id_proveedor.SelectedItem != null)
            {
                string idProveedor = ((ComboBoxItem)Cbo_id_proveedor.SelectedItem).Value;
                CargarFacturasPorProveedor(idProveedor);
            }
        }

        private void Cbo_idfactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_idfactura.SelectedItem != null)
            {
                string idFactura = ((ComboBoxItem)Cbo_idfactura.SelectedItem).Value;
                MostrarDatosFactura(idFactura);
            }
        }

        private void MostrarDatosFactura(string idFactura)
        {
            try
            {
                DataTable dt = controlador.ObtenerDatosFactura(idFactura);
                if (dt.Rows.Count > 0)
                {
                    Txt_saldo_restante.Text = dt.Rows[0]["saldo"].ToString();
                    Txt_saldoInicial.Text = dt.Rows[0]["Total_a_pagar"].ToString();
                }
                else
                {
                    Txt_saldo_restante.Clear();
                    Txt_saldoInicial.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar datos de factura: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitarCampos(bool habilitar)
        {
            Txt_id_deuda.Enabled = habilitar;
            Txt_montoDeuda.Enabled = habilitar;
            Txt_Descripcion.Enabled = habilitar;
            Dtp_Inicio.Enabled = habilitar;
            Dtp_Vencimiento.Enabled = habilitar;
            Cbo_estado.Enabled = habilitar;
            Cbo_Tipotrans.Enabled = habilitar;
            Cbo_id_proveedor.Enabled = habilitar;
            Cbo_idfactura.Enabled = habilitar;
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            Capa_Vista_Reporte.ReporteProv ReporProv = new Capa_Vista_Reporte.ReporteProv();
            ReporProv.Show();
        }
    }
}
