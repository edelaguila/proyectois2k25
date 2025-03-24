using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Cuentas_Corrientes
{
    public partial class Nav_Transaccion_Cuentas : Form
    {
        public Nav_Transaccion_Cuentas()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            string[] alias = { "id_transaccion", "nombre_transaccion", "efecto", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("Tbl_transaccion_cuentas");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Transaccion de Cuentas");

        }
    }
}
