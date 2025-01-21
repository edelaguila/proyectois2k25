using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_CompraVenta
{
    public partial class Frm_clientes : Form
    {
        public Frm_clientes(String idUsuario)
        {
            InitializeComponent();
            string[] alias = { "Codigo", "Nombre", "apellido", "nit", "telefono", "direccion", "No.cuenta", "estado", "Tipo", "deuda", "vendedor acargo", "lista precios" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.FromArgb(255, 255, 192));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("Tbl_clientes");
            navegador1.ObtenerIdAplicacion("3000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Mantenimiento clientes");
        }
    }
}
