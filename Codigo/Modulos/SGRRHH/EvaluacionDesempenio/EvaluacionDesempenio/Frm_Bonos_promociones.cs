using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionDesempenio
{
    public partial class Frm_Bonos_promociones : Form
    {
        public Frm_Bonos_promociones()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            string[] alias = { "ID", "resultado", "Tipo", "Monto", "Fecha", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarTabla("tbl_bonos_promociones");
            navegador1.AsignarNombreForm("Bonos y Promociones");
        }
    }
}
