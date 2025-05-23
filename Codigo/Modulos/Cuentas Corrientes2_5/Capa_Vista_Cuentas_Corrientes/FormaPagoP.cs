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
    public partial class FormaPagoP : Form
    {
        Capa_Controlador_Cuentas_Corrientes.Controlador controlador = new Capa_Controlador_Cuentas_Corrientes.Controlador();
        public FormaPagoP()
        {
            InitializeComponent();
        }

        private void actualizarDataFormaPago()
        {
            DataTable data = controlador.MostrarFrmPago();
            DgvFormaPago.DataSource = data;
            DgvFormaPago.Columns[0].HeaderText = "Id";
            DgvFormaPago.Columns[1].HeaderText = "Nombre";
            DgvFormaPago.Columns[2].HeaderText = "Moneda";
            DgvFormaPago.Columns[3].HeaderText = "Estado";
        }

        void getIdF()
        {
            Txt_id_pago.Text = controlador.getNextIdF();
        }

        private void Btn_guardar_Click_1(object sender, EventArgs e)
        {
            controlador.guardarFormaPago(Txt_id_pago, Cbo_Nombre.Text, Cbo_Moneda.Text, Cbo_Estado.Text);
            actualizarDataFormaPago();
            getIdF();
        }

        private void Btn_buscar_Click_1(object sender, EventArgs e)
        {
            DataTable data = controlador.queryFrmPago(Txt_id_pago);
            DgvFormaPago.DataSource = data;
        }

        private void Btn_actualizar_Click_1(object sender, EventArgs e)
        {
            actualizarVistaFrmPago();
            getIdF();

            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
            Btn_buscar.Enabled = true;
            Btn_actualizar.Enabled = true;

            Txt_id_pago.Text = "";
            Cbo_Nombre.Text = "";
            Cbo_Moneda.Text = "";
            Cbo_Estado.Text = "";
        }

        private void Btn_borrar_Click_1(object sender, EventArgs e)
        {
            controlador.borrarFrmPago(Txt_id_pago);
            actualizarVistaFrmPago();
            getIdF();

        }

        private void actualizarVistaFrmPago()
        {
            DataTable data = controlador.MostrarFrmPago();
            DgvFormaPago.DataSource = data;
            DgvFormaPago.Columns[0].HeaderText = "Id";
            DgvFormaPago.Columns[1].HeaderText = "Nombre";
            DgvFormaPago.Columns[2].HeaderText = "Moneda";
            DgvFormaPago.Columns[3].HeaderText = "Estado";
        }
    }
}