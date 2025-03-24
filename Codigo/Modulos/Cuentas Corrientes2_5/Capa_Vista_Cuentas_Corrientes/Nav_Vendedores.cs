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
    public partial class Nav_Vendedores : Form
    {
        public Nav_Vendedores()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            string[] alias = { "Pk_id_vendedor", "nombre", "apellido", "sueldo", "direccion", "telefono", "FK_idemp", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("Tbl_vendedores");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Registro Vendedores");
        }
    }
}
