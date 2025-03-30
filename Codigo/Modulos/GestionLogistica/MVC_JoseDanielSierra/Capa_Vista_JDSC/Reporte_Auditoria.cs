using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_JDSC;

namespace Capa_Vista_JDSC
{
    public partial class Reporte_Auditoria : Form
    {
        Capa_Controlador_JDSC.Controlador controlador = new Capa_Controlador_JDSC.Controlador();
        public Reporte_Auditoria()
        {
            InitializeComponent();
        }

        private void Btn_GenerarReporte_Click(object sender, EventArgs e)
        {
            int idAuditoria;
            if (!int.TryParse(Txt_IDAuditoria.Text, out idAuditoria))
            {
                MessageBox.Show("Por favor, ingresa un ID de Auditoria válido.");
                return;
            }
            controlador.CargarReporte(idAuditoria);
        }

        private void Btn_ReporteGeneral_Click(object sender, EventArgs e)
        {
            Reporte report = new Reporte();
            report.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
