using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_ListaPrecios
{
    public partial class frm_MantenimientoListas : Form
    {
        public frm_MantenimientoListas(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "Codigo", "Nombre", "Descripcion", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LemonChiffon);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("Tbl_clasificacionLista");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Mantenimiento Clasificaciones");
        }
    }
}
