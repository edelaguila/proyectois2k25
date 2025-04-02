using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Capacitacion
{
    public partial class cierre_capacitacion : Form
    {
        public cierre_capacitacion()
        {
            InitializeComponent();
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {

        }

        private void tbPorcentaje_Scroll(object sender, EventArgs e)
        {
            tbPorcentaje.Minimum = 0;   // 0%
            tbPorcentaje.Maximum = 100; // 100%
            tbPorcentaje.TickFrequency = 5; // Incrementos de 5%

            lblMostrarporcentaje.Text = tbPorcentaje.Value.ToString() + "%";

        }

        private void cierre_capacitacion_Load(object sender, EventArgs e)
        {

        }
    }
}
