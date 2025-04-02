using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Evaluacion
{
    public partial class Frm_Resultados_Evaluacion : Form
    {
        public Frm_Resultados_Evaluacion()
        {
            InitializeComponent();

            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            string[] alias = { "ID Resultado", "ID Empleado", "Calificación Final", "Fecha Consolidación", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("17001");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarTabla("tbl_resultados_evaluacion");

            navegador1.AsignarNombreForm("RESULTADOS DE EVALUACIÓN");
            

        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
