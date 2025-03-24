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
    public partial class Cobrador_Clts : Form
    {
        Capa_Controlador_Cuentas_Corrientes.Controlador controlador = new Capa_Controlador_Cuentas_Corrientes.Controlador();
        public Cobrador_Clts()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void getIdC()
        {
            Txt_id_cobrador.Text = controlador.getNextIdC();
        }

        private void actualizarDataCobrador()
        {
            DataTable data = controlador.MostrarCobrador();
            DgvCobrador.DataSource = data;
            DgvCobrador.Columns[0].HeaderText = "Id";
            DgvCobrador.Columns[1].HeaderText = "Nombre";
            DgvCobrador.Columns[2].HeaderText = "Direccion";
            DgvCobrador.Columns[3].HeaderText = "Telefono";
            DgvCobrador.Columns[4].HeaderText = "Departamento";
            DgvCobrador.Columns[5].HeaderText = "Estado";
        }
        private void actualizarVistaCobrador()
        {
            DataTable data = controlador.MostrarCobrador();
            DgvCobrador.DataSource = data;
            DgvCobrador.Columns[0].HeaderText = "Id";
            DgvCobrador.Columns[1].HeaderText = "Nombre";
            DgvCobrador.Columns[2].HeaderText = "Direccion";
            DgvCobrador.Columns[3].HeaderText = "Telefono";
            DgvCobrador.Columns[4].HeaderText = "Departamento";
            DgvCobrador.Columns[5].HeaderText = "Estado";
        }


        private void Btn_buscar_Click_1(object sender, EventArgs e)
        {
            DataTable data = controlador.queryCobrador(Txt_nom_cobrador);
            DgvCobrador.DataSource = data;
        }

        private void Btn_guardar_Click_1(object sender, EventArgs e)
        {
            controlador.guardarCobrador(Txt_id_cobrador, Txt_nom_cobrador.Text, Txt_direc_cobrador.Text, Txt_tel_cobrador, Txt_depto_cobrador.Text, CmbBoxEstado.Text);
            actualizarDataCobrador();
            getIdC();
        }

        private void Btn_actualizar_Click_1(object sender, EventArgs e)
        {
            actualizarVistaCobrador();
            getIdC();

            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
            Btn_buscar.Enabled = true;
            Btn_actualizar.Enabled = true;

            Txt_id_cobrador.Text = "";
            Txt_nom_cobrador.Text = "";
            Txt_direc_cobrador.Text = "";
            Txt_tel_cobrador.Text = "";
            Txt_depto_cobrador.Text = "";
            CmbBoxEstado.Text = "";
        }

        private void Btn_borrar_Click_1(object sender, EventArgs e)
        {
            controlador.borrarCobrador(Txt_id_cobrador);
            actualizarVistaCobrador();
            getIdC();
        }
    }
}
