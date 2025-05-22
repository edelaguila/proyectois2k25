using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_DeudasClientes
{
    public partial class Deudas_Clientes : Form
    {
        Capa_Controlador_DeudasClientes.Controlador controlador = new Capa_Controlador_DeudasClientes.Controlador();
        public Deudas_Clientes()
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
                return Text;
            }
        }

        private void Deudas_Clientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarClientes();
            CargarCobradores();
            CargarTiposTransaccion();
            limpiarCampos();
            HabilitarCampos(false);
            // Deshabilitar botones al iniciar
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_Buscar.Enabled = false;
        }

        private void CargarClientes()
        {
            OdbcDataAdapter adapter = controlador.ObtenerClientes();
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Cbo_id_clientes.Items.Add(new ComboBoxItem(row["Pk_id_cliente"].ToString(), row["Clientes_nombre"].ToString()));
            }
        }

        private void CargarCobradores()
        {
            OdbcDataAdapter adapter = controlador.ObtenerCobradores();
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Cbo_id_cobrador.Items.Add(new ComboBoxItem(row["Pk_id_cobrador"].ToString(), row["cobrador_nombre"].ToString()));
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

        private void CargarFacturasPorCliente(string idProveedor)
        {
            try
            {
                Cbo_idfactura.Items.Clear();

                OdbcDataAdapter adapter = controlador.ObtenerFacturasPorCliente(idProveedor);
                if (adapter == null) return;

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string idFactura = row["Pk_id_FacturaCli"].ToString();
                    string numeroFactura = row["Fk_No_de_facV"].ToString();
                    Cbo_idfactura.Items.Add(new ComboBoxItem(idFactura, numeroFactura));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar facturas: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al cargar deudas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCampos()
        {
            Txt_id_deuda.Text = "";
            Cbo_id_clientes.SelectedIndex = -1;
            Cbo_id_cobrador.SelectedIndex = -1;
            Txt_montoDeuda.Text = "";
            Dtp_FechaI.Value = DateTime.Now;
            Dtp_FechaV.Value = DateTime.Now;
            Txt_Descripcion.Text = "";
            Cbo_estado.SelectedIndex = -1;
            Cbo_Tipotrans.SelectedIndex = -1;
            Cbo_idfactura.SelectedIndex = -1;
            Txt_saldo_restante.Text = "";
            Txt_saldoInicial.Text = "";
        }

        private void HabilitarCampos(bool habilitar)
        {
            Txt_id_deuda.Enabled = habilitar;
            Txt_montoDeuda.Enabled = habilitar;
            Txt_Descripcion.Enabled = habilitar;
            Cbo_id_clientes.Enabled = habilitar;
            Cbo_id_cobrador.Enabled = habilitar;
            Cbo_Tipotrans.Enabled = habilitar;
            Cbo_idfactura.Enabled = habilitar;
            Cbo_estado.Enabled = habilitar;
            Dtp_FechaI.Enabled = habilitar;
            Dtp_FechaV.Enabled = habilitar;
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

            if (Cbo_id_clientes.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cbo_id_clientes.Focus();
                return;
            }

            if (Cbo_id_cobrador.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cobrador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cbo_id_cobrador.Focus();
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

            var itemCliente = (ComboBoxItem)Cbo_id_clientes.SelectedItem;
            string idCliente = itemCliente.Value.ToString();

            var itemCobrador = (ComboBoxItem)Cbo_id_cobrador.SelectedItem;
            string idCobrador = itemCobrador.Value.ToString();

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
                tipoTrans = "Cobro";
                Cbo_Tipotrans.Text = tipoTrans;
            }

            string idFactura = "0";
            if (Cbo_idfactura.SelectedItem != null)
            {
                var itemFactura = (ComboBoxItem)Cbo_idfactura.SelectedItem;
                idFactura = itemFactura.Value.ToString();
            }

            int resultado = controlador.GuardarDeuda(
                Txt_id_deuda.Text, idCliente, idCobrador, Txt_montoDeuda.Text,
                Dtp_FechaI.Value.ToString("yyyy-MM-dd"),
                Dtp_FechaV.Value.ToString("yyyy-MM-dd"),
                Txt_Descripcion.Text,
                estado, tipoTrans, idFactura);

            if (resultado == 1)
            {
                HabilitarCampos(false);
                CargarDatos();
                limpiarCampos();
                // Deshabilitar botones después de guardar
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_eliminar.Enabled = false;
                Btn_Buscar.Enabled = false;
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (Cbo_id_clientes.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Cbo_id_cobrador.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cobrador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var itemCliente = (ComboBoxItem)Cbo_id_clientes.SelectedItem;
            string idCliente = itemCliente.Value.ToString();

            var itemCobrador = (ComboBoxItem)Cbo_id_cobrador.SelectedItem;
            string idCobrador = itemCobrador.Value.ToString();

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
                idFactura = ((ComboBoxItem)Cbo_idfactura.SelectedItem).Value.ToString();
            }

            int resultado = controlador.GuardarDeuda(
                Txt_id_deuda.Text,
                idCliente,
                idCobrador,
                Txt_montoDeuda.Text,
                Dtp_FechaI.Value.ToString("yyyy-MM-dd"),
                Dtp_FechaV.Value.ToString("yyyy-MM-dd"),
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

            // Obtener el ID de la deuda seleccionada
            string idDeuda = Dgv_deudas.CurrentRow.Cells["Pk_id_deuda"].Value?.ToString();

            if (string.IsNullOrEmpty(idDeuda))
            {
                MessageBox.Show("El registro seleccionado no tiene un ID válido.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                "Confirmar eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult != DialogResult.Yes)
                return;

            // Llamar al controlador para eliminar la deuda de cliente
            int result = controlador.EliminarDeuda(idDeuda);

            if (result > 0)
            {
                MessageBox.Show("Registro eliminado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                limpiarCampos();
                HabilitarCampos(false);
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
            string clienteId = Cbo_id_clientes.SelectedItem != null ? ((ComboBoxItem)Cbo_id_clientes.SelectedItem).Value : "";
            string cobradorId = Cbo_id_cobrador.SelectedItem != null ? ((ComboBoxItem)Cbo_id_cobrador.SelectedItem).Value : "";
            string facturaId = Cbo_idfactura.SelectedItem != null ? ((ComboBoxItem)Cbo_idfactura.SelectedItem).Value : "";
            string estado = Cbo_estado.Text.Trim();

            DataTable dt = controlador.BuscarDeudas(idDeuda, clienteId, facturaId, estado);

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

        private void Cbo_id_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_id_clientes.SelectedItem != null)
            {
                string idCliente = ((ComboBoxItem)Cbo_id_clientes.SelectedItem).Value;
                CargarFacturasPorCliente(idCliente);
            }
        }

        private void Cbo_idfactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_idfactura.SelectedItem != null)
            {
                string idFactura = ((ComboBoxItem)Cbo_idfactura.SelectedItem).Value;
                DataTable dt = controlador.ObtenerDatosFactura(idFactura);
                if (dt.Rows.Count > 0)
                {
                    Txt_saldoInicial.Text = dt.Rows[0]["Total_a_pagar"].ToString();
                    Txt_saldo_restante.Text = dt.Rows[0]["saldo"].ToString();
                }
            }
        }

        private void Cbo_Tipotrans_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private bool ExisteDeuda(string idDeuda)
        {
            string query = "SELECT COUNT(*) FROM tbl_deudas_clientes WHERE Pk_id_deuda = ?";
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

        private void Dgv_deudas_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_deudas.SelectedRows.Count > 0)
            {
                try
                {
                    HabilitarCampos(true);

                    var filaSeleccionada = Dgv_deudas.SelectedRows[0];

                    // Habilitar botones correspondientes
                    Btn_guardar.Enabled = false;
                    Btn_editar.Enabled = true;
                    Btn_eliminar.Enabled = true;
                    Btn_Buscar.Enabled = false;

                    // Llenar campos con datos del registro seleccionado
                    Txt_id_deuda.Text = filaSeleccionada.Cells["Pk_id_deuda"].Value.ToString();
                    Txt_id_deuda.ReadOnly = true;

                    // Seleccionar el cliente en el ComboBox
                    string idClienteSeleccionado = filaSeleccionada.Cells["Fk_id_cliente"].Value.ToString();
                    foreach (ComboBoxItem item in Cbo_id_clientes.Items)
                    {
                        if (item.Value == idClienteSeleccionado)
                        {
                            Cbo_id_clientes.SelectedItem = item;
                            break;
                        }
                    }

                    // Seleccionar el cobrador en el ComboBox
                    string idCobradorSeleccionado = filaSeleccionada.Cells["Fk_id_cobrador"].Value.ToString();
                    foreach (ComboBoxItem item in Cbo_id_cobrador.Items)
                    {
                        if (item.Value == idCobradorSeleccionado)
                        {
                            Cbo_id_cobrador.SelectedItem = item;
                            break;
                        }
                    }

                    Txt_montoDeuda.Text = filaSeleccionada.Cells["deuda_monto"].Value.ToString();

                    if (DateTime.TryParse(filaSeleccionada.Cells["deuda_fecha_inicio_deuda"].Value.ToString(), out DateTime fechaInicio))
                    {
                        Dtp_FechaI.Value = fechaInicio;
                    }

                    if (DateTime.TryParse(filaSeleccionada.Cells["deuda_fecha_vencimiento_deuda"].Value.ToString(), out DateTime fechaVencimiento))
                    {
                        Dtp_FechaV.Value = fechaVencimiento;
                    }

                    Txt_Descripcion.Text = filaSeleccionada.Cells["deuda_descripcion_deuda"].Value.ToString();

                    string estado = filaSeleccionada.Cells["deuda_estado"].Value.ToString();
                    if (!string.IsNullOrEmpty(estado))
                    {
                        Cbo_estado.Text = estado;
                    }

                    string tipoTrans = filaSeleccionada.Cells["Fk_id_pago"].Value.ToString(); // Corresponde a tran_nombre
                    if (!string.IsNullOrEmpty(tipoTrans))
                    {
                        Cbo_Tipotrans.Text = tipoTrans;
                    }

                    // Seleccionar factura si existe
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

                    // Establecer estado de edición
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

        private void Btn_Ayudas_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta del directorio del ejecutable
                string sexecutablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Retroceder a la carpeta del proyecto
                string sprojectPath = Path.GetFullPath(Path.Combine(sexecutablePath, @"..\..\"));
                //MessageBox.Show("1" + projectPath);

                string sayudaFolderPath = Path.Combine(sprojectPath, "AyudaMovimientos");

                // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
                string spathAyuda = FindFileInDirectory(sayudaFolderPath, "AyudaMovimientos.chm");

                // Verifica si el archivo existe antes de intentar abrirlo
                if (!string.IsNullOrEmpty(spathAyuda))
                {
                    // Abre el archivo de ayuda .chm en la sección especificada
                    //Help.ShowHelp(null, spathAyuda, "AyudaTrasladoDeProductos.html");
                    Help.ShowHelp(null, spathAyuda, "AyudaMovProveedores.html");
                }
                else
                {
                    // Si el archivo no existe, muestra un mensaje de error
                    MessageBox.Show("El archivo de ayuda no se encontró.");
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }
        public string FindFileInDirectory(string sdirectory, string sfileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(sdirectory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(sdirectory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in files)
                    {
                        if (Path.GetFileName(file).Equals(sfileName, StringComparison.OrdinalIgnoreCase))
                        {
                            //MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la carpeta: " + sdirectory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar ayuda: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            Capa_Vista_Reporte.ReporteCliente frm_reporte = new Capa_Vista_Reporte.ReporteCliente();
            frm_reporte.Show();
        }
    }
}
