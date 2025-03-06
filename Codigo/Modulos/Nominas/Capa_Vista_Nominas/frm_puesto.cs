using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Nominas
{
    public partial class frm_puesto : Form
    {
        public frm_puesto()
        {
            InitializeComponent();

            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            /*********Prueba con la tabla inicial*********/
            string[] alias = { "pk_id_puestos", "nombre_puesto", "descripcion", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#AEA1D6"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_puestos_trabajo");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Puesto");
            /**********************************************/


        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
