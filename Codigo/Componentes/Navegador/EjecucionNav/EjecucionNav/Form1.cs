using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjecucionNav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] alias = { "ID", "Nombre", "clasi", "Genero", "Sub", "Idioma", "precio", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.AsignarTabla("peliculas");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario("peter");
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("PELICULAS");
        }
    }
}
