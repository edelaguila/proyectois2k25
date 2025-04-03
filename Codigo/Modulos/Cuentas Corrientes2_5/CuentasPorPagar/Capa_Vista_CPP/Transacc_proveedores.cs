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
    public partial class Transacc_proveedores : Form
    {
        Capa_Controlador_CPP.Controlador controlador = new Capa_Controlador_CPP.Controlador();
        public Transacc_proveedores()
        {
            InitializeComponent();
        }

        private void Transacc_proveedores_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(218, 247, 245);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //int resultado = controlador.GuardarTransaccion(Txt_transaccion, Txt_proveedor, Txt_pais,
            //                                               Txt_fecha.Text, Cbo_cuenta.Text, Cbo_cuota.Text,
            //                                               Txt_monto.Text, Txt_pago, Cbo_moneda.Text,
            //                                               Txt_serie.Text, Cbo_estado.Text);

            //if (resultado == 1)
            //{
            //    CargarDatos();
            //}
        }

        //private void CargarDatos()
        //{
        //    try
        //    {
        //        OdbcDataAdapter adapter = controlador.DisplayTransaccion();
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        Dgv_transacciones_provee.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            //if (Dgv_transacciones_provee.SelectedRows.Count > 0)
            //{
            //    // Obtener los datos de la fila seleccionada
            //    Txt_transaccion.Text = Dgv_transacciones_provee.CurrentRow.Cells["Pk_id_transaccion"].Value.ToString();
            //    Txt_proveedor.Text = Dgv_transacciones_provee.CurrentRow.Cells["Fk_id_proveedor"].Value.ToString();
            //    Txt_pais.Text = Dgv_transacciones_provee.CurrentRow.Cells["Fk_id_pais"].Value.ToString();
            //    Txt_fecha.Text = Dgv_transacciones_provee.CurrentRow.Cells["fecha_transaccion"].Value.ToString();
            //    Cbo_cuenta.Text = Dgv_transacciones_provee.CurrentRow.Cells["tansaccion_cuenta"].Value.ToString();
            //    Cbo_cuota.Text = Dgv_transacciones_provee.CurrentRow.Cells["tansaccion_cuotas"].Value.ToString();
            //    Txt_monto.Text = Dgv_transacciones_provee.CurrentRow.Cells["transaccion_monto"].Value.ToString();
            //    Txt_pago.Text = Dgv_transacciones_provee.CurrentRow.Cells["Fk_id_pago"].Value.ToString();
            //    Cbo_moneda.Text = Dgv_transacciones_provee.CurrentRow.Cells["transaccion_tipo_moneda"].Value.ToString();
            //    Txt_serie.Text = Dgv_transacciones_provee.CurrentRow.Cells["transaccion_serie"].Value.ToString();
            //    Cbo_estado.Text = Dgv_transacciones_provee.CurrentRow.Cells["transaccion_estado"].Value.ToString();

            //    // Activar modo edición
            //    controlador.esEdicion = true;
            //    controlador.idTransaccionSeleccionada = Txt_transaccion.Text;
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione una fila para editar", "Advertencia",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            //Dgv_transacciones_provee.DataSource = controlador.DisplayTransaccion();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            //if (Dgv_transacciones_provee.SelectedRows.Count > 0)
            //{
            //    string idTransaccion = Dgv_transacciones_provee.CurrentRow.Cells["Pk_id_transaccion"].Value.ToString();

            //    var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
            //                                        "Confirmar eliminación",
            //                                        MessageBoxButtons.YesNo,
            //                                        MessageBoxIcon.Warning);

            //    if (confirmResult == DialogResult.Yes)
            //    {
            //        controlador.eliminarTransaccion(idTransaccion);
            //        MessageBox.Show("Registro eliminado correctamente.", "Éxito",
            //                        MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        // Actualizar DataGridView
            //        CargarDatos();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione un registro para eliminar.",
            //                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }


        private void limpiarCampos()
        {
            // Limpiar todos los TextBox
            //Txt_transaccion.Clear();
            //Txt_proveedor.Clear();
            //Txt_pais.Clear();
            //Txt_fecha.Clear();
            //Txt_monto.Clear();
            //Txt_pago.Clear();
            //Txt_serie.Clear();

            //// Restablecer el ComboBox a su estado inicial
            //Cbo_estado.SelectedIndex = -1;
            //Cbo_moneda.SelectedIndex = -1;
            //Cbo_cuenta.SelectedIndex = -1;
            //Cbo_cuota.SelectedIndex = -1;

            //// Opcional: Quitar la selección del DataGridView
            //Dgv_transacciones_provee.ClearSelection();
        }

        //private string determinarCampoDeBusqueda()
        //{
        //    //if (!string.IsNullOrEmpty(Txt_transaccion.Text))
        //    //    return "Pk_id_transaccion";
        //    //else if (!string.IsNullOrEmpty(Txt_proveedor.Text))
        //    //    return "Fk_id_proveedor";
        //    //else if (!string.IsNullOrEmpty(Txt_pago.Text))
        //    //    return "Fk_id_pago";
        //    //else if (!string.IsNullOrEmpty(Txt_pais.Text))
        //    //    return "Fk_id_pais";
        //    //else
        //    //    return null;
        //}

        //private string obtenerValorDeBusqueda()
        //{
        //    //if (!string.IsNullOrEmpty(Txt_transaccion.Text))
        //    //    return Txt_transaccion.Text;
        //    //else if (!string.IsNullOrEmpty(Txt_proveedor.Text))
        //    //    return Txt_proveedor.Text;
        //    //else if (!string.IsNullOrEmpty(Txt_pago.Text))
        //    //    return Txt_pago.Text;
        //    //else if (!string.IsNullOrEmpty(Txt_pais.Text))
        //    //    return Txt_pais.Text;
        //    //else
        //    //    return null;
        //}

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            //string campo = determinarCampoDeBusqueda();
            //string valor = obtenerValorDeBusqueda();

            //if (!string.IsNullOrEmpty(campo) && !string.IsNullOrEmpty(valor))
            //{
            //    OdbcDataAdapter da = controlador.buscarTransaccionPorCampo(campo, valor);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    Dgv_transacciones_provee.DataSource = dt;
            //}
            //else
            //{
            //    MessageBox.Show("Ingrese un valor en uno de los campos de ID para buscar.",
            //                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
