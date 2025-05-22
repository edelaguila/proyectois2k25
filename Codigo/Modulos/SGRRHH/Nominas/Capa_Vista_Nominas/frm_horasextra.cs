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
    public partial class frm_horasextra : Form
    {

        String idUsuario;

        public frm_horasextra()
        {
            InitializeComponent();
         //   string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            // Prueba con la tabla inicial/
            string[] alias = { "pk_registro_horas", "horas_mes ", "horas_cantidad_horas", " fk_clave_empleado", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightGray);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_horas_extra");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Horas Extra");
        }
    }
}
