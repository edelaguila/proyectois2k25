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

namespace Capa_Vista_CPP
{
    public partial class Deudas_Proveedores : Form
    {
        Capa_Controlador_CPP.Controlador controlador = new Capa_Controlador_CPP.Controlador();
        public Deudas_Proveedores()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            //try
            //{
            //    OdbcDataAdapter adapter = controlador.DisplayDeudas();
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);
            //    Dgv_deudas_provee.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            // Guardar deuda
            //int resultado = controlador.GuardarDeuda(Txt_deuda, Txt_proveedor, Txt_pago,
            //                                         Txt_monto.Text, Txt_fecha_ini.Text,
            //                                         Txt_fecha_venci.Text, Txt_descripcion.Text,
            //                                         Cbo_estado.Text);

            //if (resultado == 1)
            //{
            //    CargarDatos();
            //}
        }

        private void Deudas_proveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            //if (Dgv_deudas_provee.SelectedRows.Count > 0)
            //{
            //    // Obtener los datos de la fila seleccionada
            //    Txt_deuda.Text = Dgv_deudas_provee.CurrentRow.Cells["Pk_id_deuda"].Value.ToString();
            //    Txt_proveedor.Text = Dgv_deudas_provee.CurrentRow.Cells["Fk_id_proveedor"].Value.ToString();
            //    Txt_pago.Text = Dgv_deudas_provee.CurrentRow.Cells["Fk_id_pago"].Value.ToString();
            //    Txt_monto.Text = Dgv_deudas_provee.CurrentRow.Cells["deuda_monto"].Value.ToString();
            //    Txt_fecha_ini.Text = Dgv_deudas_provee.CurrentRow.Cells["deuda_fecha_inicio"].Value.ToString();
            //    Txt_fecha_venci.Text = Dgv_deudas_provee.CurrentRow.Cells["deuda_fecha_vencimiento"].Value.ToString();
            //    Txt_descripcion.Text = Dgv_deudas_provee.CurrentRow.Cells["deuda_descripcion"].Value.ToString();
            //    Cbo_estado.Text = Dgv_deudas_provee.CurrentRow.Cells["deuda_estado"].Value.ToString();

            //    // Activar modo edición
            //    controlador.esEdicion = true;
            //    controlador.idDeudaSeleccionada = Txt_deuda.Text;
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione una fila para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
        //    if (Dgv_deudas_provee.SelectedRows.Count > 0)
        //    {
        //        string idDeuda = Dgv_deudas_provee.CurrentRow.Cells["Pk_id_deuda"].Value.ToString();

        //        var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
        //                                            "Confirmar eliminación",
        //                                            MessageBoxButtons.YesNo,
        //                                            MessageBoxIcon.Warning);

        //        if (confirmResult == DialogResult.Yes)
        //        {
        //            controlador.EliminarDeuda(idDeuda);
        //            MessageBox.Show("Registro eliminado correctamente.", "Éxito",
        //                            MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            // Actualizar DataGridView
        //            CargarDatos();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Seleccione un registro para eliminar.",
        //                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        }

        //private string determinarCampoDeBusqueda()
        //{
        //    if (!string.IsNullOrEmpty(Txt_deuda.Text))
        //        return "Pk_id_deuda";
        //    else if (!string.IsNullOrEmpty(Txt_proveedor.Text))
        //        return "Fk_id_proveedor";
        //    else if (!string.IsNullOrEmpty(Txt_pago.Text))
        //        return "Fk_id_pago";
        //    else
        //        return null;
        //}

        //private string obtenerValorDeBusqueda()
        //{
        //    if (!string.IsNullOrEmpty(Txt_deuda.Text))
        //        return Txt_deuda.Text;
        //    else if (!string.IsNullOrEmpty(Txt_proveedor.Text))
        //        return Txt_proveedor.Text;
        //    else if (!string.IsNullOrEmpty(Txt_pago.Text))
        //        return Txt_pago.Text;
        //    else
        //        return null;
        //}

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            //string campo = determinarCampoDeBusqueda();
            //string valor = obtenerValorDeBusqueda();

            //if (!string.IsNullOrEmpty(campo) && !string.IsNullOrEmpty(valor))
            //{
            //    OdbcDataAdapter da = controlador.BuscarDeudaPorCampo(campo, valor);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    Dgv_deudas_provee.DataSource = dt;
            //}
            //else
            //{
            //    MessageBox.Show("Ingrese un valor en uno de los campos de ID para buscar.",
            //                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void limpiarCampos()
        {
            //// Limpiar todos los TextBox
            //Txt_deuda.Clear();
            //Txt_proveedor.Clear();
            //Txt_pago.Clear();
            //Txt_monto.Clear();
            //Txt_descripcion.Clear();
            //Txt_fecha_ini.Clear();
            //Txt_fecha_venci.Clear();

            //// Restablecer el ComboBox a su estado inicial
            //Cbo_estado.SelectedIndex = -1;

            //// Opcional: Quitar la selección del DataGridView
            //Dgv_deudas_provee.ClearSelection();
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
