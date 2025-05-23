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
    public partial class ClienteNuevo : Form
    {
        Capa_Controlador_Cuentas_Corrientes.Controlador controlador = new Capa_Controlador_Cuentas_Corrientes.Controlador();
        public ClienteNuevo()
        {
            InitializeComponent();
            actualizarVistaClientes();
            cargarVendedor();
            getIdC();
        }
        void getIdC()
        {
            Txt_id_cliente.Text = controlador.getNextIdC();
        }
        private void actualizarVistaClientes()
        {
            DataTable data = controlador.MostrarClientes();
            Dgv_clientes.DataSource = data;
            Dgv_clientes.Columns[0].HeaderText = "Pk_id_cliente";
            Dgv_clientes.Columns[1].HeaderText = "Fk_id_vendedor";
            Dgv_clientes.Columns[2].HeaderText = "nombre_cliente";
            Dgv_clientes.Columns[3].HeaderText = "telefono_cliente";
            Dgv_clientes.Columns[4].HeaderText = "direccion_cliente";
            Dgv_clientes.Columns[5].HeaderText = "saldo_cuenta";
            Dgv_clientes.Columns[6].HeaderText = "estado_cliente";

        }
        private void cargarVendedor()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_Vendedor.DataSource = limpiarTexbox;
            List<string> vendedorCodes = controlador.listadoVendedor();
            Cbo_Vendedor.DataSource = vendedorCodes;
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            controlador.guardarClientes(Txt_id_cliente, Cbo_Vendedor.Text, Txt_nombre.Text, Txt_telefono.Text, Txt_direccion.Text, Txt_saldo.Text, Cbo_estado.Text);
            actualizarVistaClientes();
            getIdC();
        }

        private void Dgv_clientes_DoubleClick(object sender, EventArgs e)
        {
            if (Dgv_clientes.CurrentRow.Index != -1)
            {
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = true;
                Btn_eliminar.Enabled = true;
                Btn_buscar.Enabled = true;
                Btn_actualizar.Enabled = true;

                Txt_id_cliente.Text = Dgv_clientes.CurrentRow.Cells[0].Value.ToString();
                Cbo_Vendedor.Text = Dgv_clientes.CurrentRow.Cells[1].Value.ToString();
                Txt_nombre.Text = Dgv_clientes.CurrentRow.Cells[2].Value.ToString();
                Txt_telefono.Text = Dgv_clientes.CurrentRow.Cells[3].Value.ToString();
                Txt_direccion.Text = Dgv_clientes.CurrentRow.Cells[4].Value.ToString();
                Txt_saldo.Text = Dgv_clientes.CurrentRow.Cells[5].Value.ToString();
                Cbo_estado.Text = Dgv_clientes.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable data = controlador.queryCliente(Txt_nombre);
            Dgv_clientes.DataSource = data;
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizarVistaClientes();
            getIdC();

            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_buscar.Enabled = true;
            Btn_actualizar.Enabled = false;

            Txt_nombre.Text = "";
            Cbo_Vendedor.SelectedIndex = 0;
            Txt_nombre.Text = "";
            Txt_telefono.Text = "";
            Txt_direccion.Text = "";
            Txt_saldo.Text = "";
            Cbo_estado.SelectedIndex = 0;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            controlador.borrarCliente(Txt_id_cliente);
            actualizarVistaClientes();
            getIdC();
        }
    }
}
