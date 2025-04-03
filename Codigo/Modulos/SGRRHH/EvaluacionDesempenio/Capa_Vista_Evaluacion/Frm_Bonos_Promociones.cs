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
    public partial class Frm_Bonos_Promociones : Form
    {
        public Frm_Bonos_Promociones()
        {
            InitializeComponent();

            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            string[] alias = { "ID Bono", "ID Resultado", "Tipo", "Monto", "Fecha Recomendación", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("17002");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarTabla("tbl_bonos_promociones");

            navegador1.AsignarNombreForm("BONOS Y PROMOCIONES");
            
        }
    }
}
