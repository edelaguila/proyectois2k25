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
    public partial class Nav_TransaccionProv : Form
    {
        public Nav_TransaccionProv()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            string[] alias = { "id_Transacción", "id_proveedor", "fecha", "monto", "tipo_moneda", "estado", "Tipo_pago" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.FromArgb(218, 247, 245));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("Tbl_Transaccion_proveedor");
            navegador1.ObtenerIdAplicacion("3000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Registro de las transacciones de los proveedores");
        }
    }
}
