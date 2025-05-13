using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Capacitacion;

namespace Capa_Vista_Capacitacion
{
    public partial class parámetros_capacitación : Form
    {
        public parámetros_capacitación()
        {
            InitializeComponent();
        }


        private void parámetros_capacitación_Load(object sender, EventArgs e)
        {
            nudAumento.Value = ParametrosGlobales.LimiteVerde;
            nudNeutro.Value = ParametrosGlobales.LimiteAmarillo;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            ParametrosGlobales.LimiteVerde = nudAumento.Value;
            ParametrosGlobales.LimiteAmarillo = nudNeutro.Value;
            MessageBox.Show("Parámetros actualizados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
