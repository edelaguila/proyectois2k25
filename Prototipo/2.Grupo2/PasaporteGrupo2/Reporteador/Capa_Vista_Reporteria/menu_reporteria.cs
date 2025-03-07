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

namespace Capa_Vista_Reporteria
{
    public partial class menu_reporteria : Form
    {
        Capa_Controlador_Reporteria.Controlador controlador = new Capa_Controlador_Reporteria.Controlador();

        public menu_reporteria()
        {
            InitializeComponent();
        }

        private void Btn_RepUsuario_Click(object sender, EventArgs e)
        {
            reporteria_usuario rep = new reporteria_usuario();
            rep.MdiParent = this;
            rep.Show();
        }

        private void Btn_RepAdmin_Click(object sender, EventArgs e)
        {
            Inicio rep = new Inicio();
            rep.MdiParent = this;
            rep.Show();
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string idayuda = "2";
            string Ruta = controlador.MRuta(idayuda);
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\..\"));
            string AsRuta = Path.Combine(sRutaProyecto, "Ayuda", "AyudaReportes", Ruta);
            string AsIndice = controlador.MIndice(idayuda);

            // Validar que la ruta y el índice no estén vacíos
            if (!string.IsNullOrEmpty(AsRuta) && !string.IsNullOrEmpty(AsIndice))
            {
                // Mostrar la ayuda automáticamente cuando se llama a asignarAyuda
                Help.ShowHelp(this, AsRuta, AsIndice);
            }
            else
            {
                MessageBox.Show("La Ruta o el índice de la ayuda están vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
