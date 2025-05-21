using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Capacitacion
{
    public partial class mantenimiento_instructores : Form
    {
        public mantenimiento_instructores()
        {
            InitializeComponent();

            string idusuario = Interfac_V3.UsuarioSesion.GetIdUsuario();


            string[] alias = { "ID", "nombre", "apellido", "especialidad", "email", "telefono", "estado"};
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("14002");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idusuario);
            navegador1.AsignarTabla("tbl_instructores");
    

            navegador1.AsignarNombreForm(" ");
        }

        private void mantenimiento_instructores_Load(object sender, EventArgs e)
        {

        }
    }
}
