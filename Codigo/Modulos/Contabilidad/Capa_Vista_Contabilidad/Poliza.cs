using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Contabilidad
{
    public partial class Poliza : Form
    {
        public Poliza()
        {
            InitializeComponent();

            string[] alias = { "Codigo", "Cuenta", "Cargo/Abono", "Valor", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Poliza");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("polizas");
        }

        private void Poliza_Load(object sender, EventArgs e)
        {
            
        }
    }
}
