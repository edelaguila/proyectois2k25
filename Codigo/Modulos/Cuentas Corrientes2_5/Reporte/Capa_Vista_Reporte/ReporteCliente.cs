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
            //mostramos todos los reportes que hay en la base de datos según lo introducido en el textbox y la desplegamos
            
            DataTable data = controlador.queryDeudaC(textBox1);
            dataGridView1.DataSource = data;
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {

        }
    }
}
