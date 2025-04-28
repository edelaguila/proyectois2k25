using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Compras
{
    public partial class Frm_Compras : Form
    {
        public Frm_Compras()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(218, 247, 245); // Color de fondo personalizado
        }

        private void Pic_Salir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Pic_Salir_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Pic_Ingresar_Click(object sender, EventArgs e)
        {

        }
    }
}

