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
    public partial class Movimientos_Clientes : Form
    {
        public Movimientos_Clientes()
        {
            InitializeComponent();
        }

        private void creacionClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mensualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MovimientoMensual.Show();
        }

        private void mensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // SaldoCliente.Show();
        }

        private void mensualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CreditoCliente.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ClienteNuevo man = new ClienteNuevo();///este es nuevo *****
            man.Show();
        }

        private void tiposDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaPago man = new FormaPago();
            man.Show();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pais_Cliente man = new Pais_Cliente();
            man.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendedores_Clts man = new Vendedores_Clts();
            man.Show();
        }

        private void cobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobrador_Clts man = new Cobrador_Clts();
            man.Show();
        }

        private void deudasClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deuda_Clts man = new Deuda_Clts();
            man.Show();
        }
    }
}




        