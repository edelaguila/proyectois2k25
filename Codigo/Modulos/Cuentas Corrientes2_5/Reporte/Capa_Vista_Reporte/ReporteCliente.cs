using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Reporte
{
    public partial class ReporteCliente : Form
    {
        Capa_Controlador_Reporte.controlador controlador = new Capa_Controlador_Reporte.controlador();

        public ReporteCliente()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string idCliente = textBox1.Text.Trim();
            DateTime fechaInicio = dateTimePicker1.Value.Date;
            DateTime fechaFin = dateTimePicker2.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.");
                return;
            }

            DataTable data = controlador.queryDeudaCConFecha(idCliente, fechaInicio, fechaFin);
            dataGridView1.DataSource = data;

            if (data.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados en ese rango de fechas.");
            }
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            ReporteClienteCR RprtFrmCli = new ReporteClienteCR();
            RprtFrmCli.Show();
        }
    }
}
