using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_MiguelCrisostomo;

namespace Capa_Vista_MiguelCrisostomo
{
    public partial class NuevoTraslado : Form
    {
        private controlador controlador = new controlador();

        public NuevoTraslado()
        {
            InitializeComponent();
            CargarBodegas();
            BloquearComboBox();
        }

        private void CargarBodegas()
        {
            try
            {
                List<string> nombresBodegas = controlador.ObtenerNombresBodegas();
                Cbo_Sucursal.Items.Clear();
                foreach (string nombreBodega in nombresBodegas)
                {
                    Cbo_Sucursal.Items.Add(nombreBodega);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las bodegas: " + ex.Message);
            }
        }

        private void BloquearComboBox()
        {
            Cbo_Sucursal.Enabled = true;
            Cbo_Sucursal.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
