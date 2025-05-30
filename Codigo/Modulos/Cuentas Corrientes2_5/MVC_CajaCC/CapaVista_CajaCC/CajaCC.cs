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
            LlenarComboDeudasProveedores(); // Nuevo método para cargar deudas de proveedores
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

            // Nuevo: Cargar deuda de proveedor si existe
            if (row.Cells["idDeudaProv"].Value != null && row.Cells["idDeudaProv"].Value != DBNull.Value)
                cbo_deuda_prov.SelectedValue = row.Cells["idDeudaProv"].Value;
            else
                cbo_deuda_prov.SelectedIndex = -1;

            // Campos eliminados: txt_mdcaja, txt_mmcaja, txt_mtcaja
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

        private void LlenarComboDeudasProveedores()
        {
            cbo_deuda_prov.DataSource = controlador.ObtenerDeudasProveedores();
            cbo_deuda_prov.DisplayMember = "deuda_descripcion";
            cbo_deuda_prov.ValueMember = "id_deuda";
        }
        // Validar que campos numéricos contengan números
        private bool ValidarCamposNumericos()
        {
            decimal temp;
            int tempInt;

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

            return true;

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

            // Validar que se haya seleccionado una deuda (cliente o proveedor)
            if (string.IsNullOrEmpty(cbo_deuda_caja.Text) && string.IsNullOrEmpty(cbo_deuda_prov.Text))
            {
                MessageBox.Show("Debe seleccionar una deuda de cliente o de proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool resultado = controlador.InsertarCaja(
                    txt_idcaja.Text,
                    cbo_cliente_caja.SelectedValue?.ToString(),
                    cbo_proveedor_caja.SelectedValue?.ToString(),
                    cbo_deuda_caja.SelectedValue?.ToString(),
                    cbo_deuda_prov.SelectedValue?.ToString(), // Nuevo parámetro para deuda de proveedor
                    txt_saldocaja.Text,
                    txt_estadocaja.Text,
                    dtp_caja.Value.ToString("yyyy-MM-dd")
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
                cbo_deuda_prov.Enabled = false; // Deshabilitar deudas de proveedor
                cbo_deuda_caja.Enabled = true;  // Habilitar deudas de cliente
            }
            else
            {
                cbo_proveedor_caja.Enabled = true;
                cbo_deuda_prov.Enabled = true;
                cbo_deuda_caja.Enabled = true;
            }
        }

        private void ProveedorSeleccionado(object sender, EventArgs e)
        {
            if (cbo_proveedor_caja.SelectedIndex >= 0 && cbo_proveedor_caja.SelectedValue != null)
            {
                cbo_cliente_caja.Enabled = false;
                cbo_deuda_caja.Enabled = false; // Deshabilitar deudas de cliente
                cbo_deuda_prov.Enabled = true;  // Habilitar deudas de proveedor
            }
            else
            {
                cbo_cliente_caja.Enabled = true;
                cbo_deuda_caja.Enabled = true;
                cbo_deuda_prov.Enabled = true;
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
                    cbo_deuda_caja.SelectedValue?.ToString(),
                    cbo_deuda_prov.SelectedValue?.ToString(), // Nuevo parámetro para deuda de proveedor
                    txt_saldocaja.Text,
                    txt_estadocaja.Text,
                    dtp_caja.Value.ToString("yyyy-MM-dd")
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
            txt_saldocaja.Enabled = true;
            txt_estadocaja.Enabled = true;
            dtp_caja.Enabled = true;
            cbo_cliente_caja.Enabled = true;
            cbo_proveedor_caja.Enabled = true;
            cbo_deuda_caja.Enabled = true;
            cbo_deuda_prov.Enabled = true; // Nuevo campo habilitado
        }
        private void BloquearCampos()
        {
            txt_idcaja.Enabled = false;
            txt_saldocaja.Enabled = false;
            txt_estadocaja.Enabled = false;
            dtp_caja.Enabled = false;
            cbo_cliente_caja.Enabled = false;
            cbo_proveedor_caja.Enabled = false;
            cbo_deuda_caja.Enabled = false;
            cbo_deuda_prov.Enabled = false; // Nuevo campo bloqueado
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
            string fecha = dtp_caja.Value.ToString("yyyy-MM-dd");

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
                    MostrarDatos();
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
                MessageBox.Show("Error al mostrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txt_idcaja.Clear();
            txt_saldocaja.Clear();
            txt_estadocaja.Clear();
            cbo_cliente_caja.SelectedIndex = -1;
            cbo_proveedor_caja.SelectedIndex = -1;
            cbo_deuda_caja.SelectedIndex = -1;
            cbo_deuda_prov.SelectedIndex = -1;
            dtp_caja.Value = DateTime.Now;
            HabilitarCampos(); // Opcional: puedes resetear los campos para nueva entrada

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

                    // Nuevo: Cargar deuda de proveedor
                    if (row.Cells["idDeudaProv"].Value != null && row.Cells["idDeudaProv"].Value != DBNull.Value)
                        cbo_deuda_prov.SelectedValue = row.Cells["idDeudaProv"].Value;
                    else
                        cbo_deuda_prov.SelectedIndex = -1;

                    txt_saldocaja.Text = row.Cells["saldoRestante"].Value?.ToString() ?? "0";
                    txt_estadocaja.Text = row.Cells["estado"].Value?.ToString() ?? "";

                    if (DateTime.TryParse(row.Cells["fechaRegistro"].Value?.ToString(), out DateTime fecha))
                        dtp_caja.Value = fecha;
                    else
                        dtp_caja.Value = DateTime.Now;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ayudas_Click(object sender, EventArgs e)
        {

            try
            {
                // Buscar la carpeta raíz del proyecto (donde está la carpeta "Codigo")
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;
                string projectRoot = executablePath;

                // Buscar hacia arriba hasta encontrar la carpeta "Codigo"
                while (!Directory.Exists(Path.Combine(projectRoot, "Codigo")) &&
                       Directory.GetParent(projectRoot) != null)
                {
                    projectRoot = Directory.GetParent(projectRoot).FullName;
                }

                // Construir la ruta a la carpeta de ayuda
                string ayudaFolderPath = Path.Combine(projectRoot,
                    "Codigo", "Modulos", "Cuentas Corrientes2_5", "MVC_CajaCC", "AyudasCaja"); //"Codigo", "Modulos", "Cuentas Corrientes2_5", "MVC_CajaCC", "Ayudas" asi debe quedar integrado

                //  MessageBox.Show("Ruta de búsqueda: " + ayudaFolderPath);

                // Busca el archivo .chm en la carpeta especificada
                string pathAyuda = FindFileInDirectory(ayudaFolderPath, "AyudaCaja.chm");

                if (!string.IsNullOrEmpty(pathAyuda))
                {
                    Help.ShowHelp(null, pathAyuda, "ayudascaja.html");
                }
                else
                {
                    MessageBox.Show("El archivo de ayuda no se encontró.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el archivo de ayuda: " + ex.Message);
            }
        }
        private string FindFileInDirectory(string directory, string fileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(directory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(directory, "*.chm", SearchOption.TopDirectoryOnly);
                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in files)
                    {
                        if (Path.GetFileName(file).Equals(fileName, StringComparison.OrdinalIgnoreCase))
                        {
                            //MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la carpeta: " + directory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }
            // Retorna null si no se encontró el archivo
            return null;
        }

    }
    }



