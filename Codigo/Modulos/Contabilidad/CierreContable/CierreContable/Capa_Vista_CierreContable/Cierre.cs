using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_CierreContable
{
    public partial class Cierre : UserControl
    {
        public string idUsuario { get; set; }
        logica LogicaSeg = new logica();
        public Cierre()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill; // Para que ocupe todo el espacio disponible
        }



        private void Cierre_Load(object sender, EventArgs e)
        {
  

            // Crear las pestañas solo si no se han creado antes
            TabCierre.TabPages[0].Text = "Consultar Cierres";
            TabCierre.TabPages[1].Text = "Cierre Mensual";


            // Cargar el formulario PartidaCierre en la primera pestaña
            ConsultasCierre partidaCierreForm = new ConsultasCierre();
            partidaCierreForm.TopLevel = false;
            partidaCierreForm.FormBorderStyle = FormBorderStyle.None;
            partidaCierreForm.Dock = DockStyle.Fill;
            TabCierre.TabPages[0].Controls.Add(partidaCierreForm);
            partidaCierreForm.Show();

            // Cargar el formulario CierreContable en la segunda pestaña
            CierreMensual cierreContableForm = new CierreMensual();
            cierreContableForm.TopLevel = false;
            cierreContableForm.FormBorderStyle = FormBorderStyle.None;
            cierreContableForm.Dock = DockStyle.Fill;
            TabCierre.TabPages[1].Controls.Add(cierreContableForm);
            cierreContableForm.Show();


        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {

        }
    }
}

