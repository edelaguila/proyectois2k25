using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Cuentas_Corrientes
{
    public partial class Vendedores_Clts : Form
    {
        Capa_Controlador_Cuentas_Corrientes.Controlador controlador = new Capa_Controlador_Cuentas_Corrientes.Controlador();
        public Vendedores_Clts()
        {
            InitializeComponent();
            actualizarVistaVendedor();
            getIdV();
        }
        void getIdV()
        {
            Txt_id_vendedor.Text = controlador.getNextIdV();
        }
        private void actualizarVistaVendedor()
        {
            DataTable data = controlador.MostrarVendedores();
            Dgv_Vendedor.DataSource = data;
            Dgv_Vendedor.Columns[0].HeaderText = "Pk_id_vendedor";
            Dgv_Vendedor.Columns[1].HeaderText = "nombre_vendedor";
            Dgv_Vendedor.Columns[2].HeaderText = "direccion_vendedor";
            Dgv_Vendedor.Columns[3].HeaderText = "telefono_vendedor";
            Dgv_Vendedor.Columns[4].HeaderText = "departamento_vendedor";
            Dgv_Vendedor.Columns[5].HeaderText = "estado_vendedor";
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            controlador.guardarVendedor(Txt_id_vendedor, Txt_nombre_vendedor.Text, Txt_direccion_vendedor.Text, Txt_telefono_vendedor.Text, Txt_depto_ven.Text, Cbo_estadoV.Text);
            actualizarVistaVendedor();
            getIdV();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable data = controlador.queryVendedor(Txt_nombre_vendedor);
            Dgv_Vendedor.DataSource = data;
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizarVistaVendedor();
            getIdV();

            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_buscar.Enabled = true;
            Btn_actualizar.Enabled = false;

            Txt_nombre_vendedor.Text = "";
            Txt_direccion_vendedor.Text = "";
            Txt_direccion_vendedor.Text = "";
            Txt_telefono_vendedor.Text = "";
            Txt_depto_ven.Text = "";
            Cbo_estadoV.SelectedIndex = 0;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            controlador.borrarVendedor(Txt_id_vendedor);
            actualizarVistaVendedor();
            getIdV();
        }

        private void Dgv_Vendedor_DoubleClick(object sender, EventArgs e)
        {
            if (Dgv_Vendedor.CurrentRow.Index != -1)
            {
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = true;
                Btn_eliminar.Enabled = true;
                Btn_buscar.Enabled = true;
                Btn_actualizar.Enabled = true;

                Txt_id_vendedor.Text = Dgv_Vendedor.CurrentRow.Cells[0].Value.ToString();
                Txt_nombre_vendedor.Text = Dgv_Vendedor.CurrentRow.Cells[1].Value.ToString();
                Txt_direccion_vendedor.Text = Dgv_Vendedor.CurrentRow.Cells[2].Value.ToString();
                Txt_telefono_vendedor.Text = Dgv_Vendedor.CurrentRow.Cells[3].Value.ToString();
                Txt_depto_ven.Text = Dgv_Vendedor.CurrentRow.Cells[4].Value.ToString();
                Cbo_estadoV.Text = Dgv_Vendedor.CurrentRow.Cells[5].Value.ToString();
            }
        }
    }
}
