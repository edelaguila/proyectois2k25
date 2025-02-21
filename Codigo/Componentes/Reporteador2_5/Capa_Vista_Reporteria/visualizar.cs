using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Capa_Vista_Reporteria
{
    public partial class visualizar : Form
    {
        public visualizar(String texto)
        {
            InitializeComponent();
            direccion_reporte.Text = texto;
            mostrar();
        }

        public void mostrar()
        {
            // Realizado por: José Daniel Sierra Cruz - 0901-21-12740
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\..\"));
            string sRutaReporte = Path.Combine(sRutaProyecto, "Reportes", direccion_reporte.Text);
            ReportDocument crystalrpt = new ReportDocument();
            try
            {
                crystalrpt.Load(sRutaReporte);
                crystalReportViewer1.ReportSource = crystalrpt;
                crystalReportViewer1.Refresh();
            }
            catch
            {
                MessageBox.Show("Error, no se puede encontrar el reporte en su equipo, verifique la ruta");
            }
        }
    }
}
