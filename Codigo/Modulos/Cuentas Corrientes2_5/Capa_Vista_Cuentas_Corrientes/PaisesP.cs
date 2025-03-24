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
    public partial class PaisesP : Form
    {
        Capa_Controlador_Cuentas_Corrientes.Controlador controlador = new Capa_Controlador_Cuentas_Corrientes.Controlador();
        public PaisesP()
        {
            InitializeComponent();
            actualizarVistaPaisesP();
            getIdP();
        }

        void getIdP()
        {
            Txt_id_pais.Text = controlador.getNextIdP();
        }
        private void actualizarVistaPaisesP()
        {
            DataTable data = controlador.MostrarPaises();
            Dgv_paises.DataSource = data;
            Dgv_paises.Columns[0].HeaderText = "Pk_id_pais";
            Dgv_paises.Columns[1].HeaderText = "nombre_pais";
            Dgv_paises.Columns[2].HeaderText = "region_pais";
            Dgv_paises.Columns[3].HeaderText = "estatus_pais";
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            controlador.guardarPaises(Txt_id_pais, Txt_nombre_pais.Text, Txt_region_pais.Text, Cbo_estatus_pais.Text);
            actualizarVistaPaisesP();
            getIdP();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable data = controlador.queryPaises(Txt_nombre_pais);
            Dgv_paises.DataSource = data;
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizarVistaPaisesP();
            getIdP();

            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_buscar.Enabled = true;
            Btn_actualizar.Enabled = true;

            Txt_nombre_pais.Text = "";
            Txt_region_pais.Text = "";
            Cbo_estatus_pais.SelectedIndex = 0;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            controlador.borrarPais(Txt_id_pais);
            actualizarVistaPaisesP();
            getIdP();
        }

        private void Dgv_paises_DoubleClick(object sender, EventArgs e)
        {
            if (Dgv_paises.CurrentRow.Index != -1)
            {
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = true;
                Btn_eliminar.Enabled = true;
                Btn_buscar.Enabled = true;
                Btn_actualizar.Enabled = true;

                Txt_id_pais.Text = Dgv_paises.CurrentRow.Cells[0].Value.ToString();
                Txt_nombre_pais.Text = Dgv_paises.CurrentRow.Cells[1].Value.ToString();
                Txt_region_pais.Text = Dgv_paises.CurrentRow.Cells[2].Value.ToString();
                Cbo_estatus_pais.Text = Dgv_paises.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
