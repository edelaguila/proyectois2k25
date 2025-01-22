using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_EstadosFinancieros;

namespace Capa_Vista_EstadosFinancieros
{
    public partial class consulta : Form
    {
        string cnt = "tbl_cuentas";
        controlador cn = new controlador();

        public consulta()
        {
            InitializeComponent();
        }


        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(cnt);
            DGV_prueba.DataSource = dt;
        }

        private void consulta_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
