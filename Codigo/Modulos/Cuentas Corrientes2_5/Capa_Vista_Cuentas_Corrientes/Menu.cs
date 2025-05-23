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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btn_Mov_Clientes_Click(object sender, EventArgs e)
        {
            Movimientos_Clientes MovC = new Movimientos_Clientes();
            MovC.MdiParent = this;
            MovC.Show();
        }

        private void Btn_Mov_Prov_Click(object sender, EventArgs e)
        {
            Movimientos_Proveedor MovP = new Movimientos_Proveedor();
            MovP.MdiParent = this;
            MovP.Show();
        }

        private void Btn_Caja_Click(object sender, EventArgs e)
        {
            Caja Caja = new Caja();
            Caja.MdiParent = this;
            Caja.Show();
        }

        private void Btn_ReportC_Click(object sender, EventArgs e)
        {
            Reportes_Clientes RepC = new Reportes_Clientes();
            RepC.MdiParent = this;
            RepC.Show();
        }

        private void Btn_ReportesP_Click(object sender, EventArgs e)
        {
            Reportes_Proveedor RepP = new Reportes_Proveedor();
            RepP.MdiParent = this;
            RepP.Show();
        }

        private void Btn_ReporteM_Click(object sender, EventArgs e)
        {
            Reporte_Mantenimiento RepM = new Reporte_Mantenimiento();
            RepM.MdiParent = this;
            RepM.Show();
        }

        private void Btn_Mantenimiento_Click(object sender, EventArgs e)
        {
            Mantenimiento Mant = new Mantenimiento();
            Mant.MdiParent = this;
            Mant.Show();
        }

        private void Btn_Enlaces_Click(object sender, EventArgs e)
        {
            Enlaces enl = new Enlaces();
            enl.MdiParent = this;
            enl.Show();
        }
    }
}
