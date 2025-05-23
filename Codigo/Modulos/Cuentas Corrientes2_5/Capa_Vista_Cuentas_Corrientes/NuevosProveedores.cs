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
    public partial class NuevosProveedores : Form
    {
        Capa_Controlador_Cuentas_Corrientes.Controlador controlador = new Capa_Controlador_Cuentas_Corrientes.Controlador();
        public NuevosProveedores()
        {
            InitializeComponent(); 
            actualizarVistaProveedor();
            getIdP();
        }

        void getIdP()
        {
            Txt_id_proveedor.Text = controlador.getNextIdPr();
        }
        private void actualizarVistaProveedor()
        {
            DataTable data = controlador.MostrarProv();
            Dgv_proveedor.DataSource = data;
            Dgv_proveedor.Columns[0].HeaderText = "Pk_id_proveedor";
            Dgv_proveedor.Columns[1].HeaderText = "fecha_registro";
            Dgv_proveedor.Columns[2].HeaderText = "nombre_proveedor";
            Dgv_proveedor.Columns[3].HeaderText = "direccion";
            Dgv_proveedor.Columns[4].HeaderText = "telefono";
            Dgv_proveedor.Columns[5].HeaderText = "email";
            Dgv_proveedor.Columns[6].HeaderText = "saldo_cuenta";
            Dgv_proveedor.Columns[7].HeaderText = "estado_proveedor";
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            controlador.guardarProve(Txt_id_proveedor, dtp_fecha_registro.Text, Txt_nombre.Text, Txt_direccion.Text, Txt_telefono.Text, Txt_email.Text, Txt_saldo.Text, Cbo_estado.Text);
            actualizarVistaProveedor();
            getIdP();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable data = controlador.queryProv(Txt_nombre);
            Dgv_proveedor.DataSource = data;
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizarVistaProveedor();
            getIdP();

            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_buscar.Enabled = true;
            Btn_actualizar.Enabled = true;

            Txt_nombre.Text = "";
            dtp_fecha_registro.Text = "";
            Txt_direccion.Text = "";
            Txt_telefono.Text = "";
            Txt_email.Text = "";
            Txt_saldo.Text = "";
            Cbo_estado.SelectedIndex = 0;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            controlador.borrarProv(Txt_id_proveedor);
            actualizarVistaProveedor();
            getIdP();
        }
    }
}
