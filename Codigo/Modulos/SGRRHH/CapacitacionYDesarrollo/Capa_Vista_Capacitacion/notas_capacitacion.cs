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
    public partial class notas_capacitación : Form
    {
        public notas_capacitación()
        {
            InitializeComponent();
        }

        private void tbPorcentaje_Scroll(object sender, EventArgs e)
        {
            tbPorcentaje.Minimum = 0;   // 0%
            tbPorcentaje.Maximum = 100; // 100%
            tbPorcentaje.TickFrequency = 5; // Incrementos de 5%

            lblMostrarporcentaje.Text = tbPorcentaje.Value.ToString() + "%";
        }
    }
}
