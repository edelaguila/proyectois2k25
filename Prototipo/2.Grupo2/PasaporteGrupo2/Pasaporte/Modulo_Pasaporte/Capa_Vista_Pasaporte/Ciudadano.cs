using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Pasaporte
{
    public partial class Ciudadano : Form
    {
        public Ciudadano()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            string[] alias = { "ID Ciudadano", "Nombre", "Fecha Nac", "Correo", "DIRE", "Nombre Madre", "Nombre Padre", "Estado Civil", "Genero", "Nacionalidad", "Lugar Nacimiento", "Telefono", "No. Registro", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.AsignarTabla("Tbl_Ciudadanos");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Ciudadano");
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
