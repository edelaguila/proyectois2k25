using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_GD
{
    public partial class frm_registrodisciplinario : Form
    {
        String idUsuario;
        public frm_registrodisciplinario()
        {
            InitializeComponent();

            string[] alias = { "pk_id_falta", "fk_clave_empleado", "falta_fecha", " falta_tipo", "falta_descripcion", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_faltas_disciplinarias");
            navegador1.ObtenerIdAplicacion("15001");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("");
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
