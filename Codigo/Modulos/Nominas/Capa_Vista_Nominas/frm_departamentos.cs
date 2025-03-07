using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Vista_Nominas
{
    public partial class frm_departamentos : Form
    {


        //Metodos para que se abra solamente una ventana y no multiples
        private static frm_departamentos instancia = null;
        public static frm_departamentos ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frm_departamentos();
            }
            return instancia;
        }
        public frm_departamentos()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            /*Marco Alejandro Monroy**/
            /****Prueba con la tabla inicial****/
            string[] alias = { "ID Depto", "Nombre_Depto", "Descripcion", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#AEA1D6"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_departamentos");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Departamento");
            /****************/




            /***************************/

        }
    }
}
