using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Nominas
{
    public partial class frm_liquidacionempleados : Form
    {
        public frm_liquidacionempleados()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            // ---------------------------------- Gabriela Suc ----------------------------------
            // Utilizando navegador
            string[] alias = { "ID Liquidacion", "Aguinaldo", "Bono_14", "Vacaciones", "Tipo_operacion", "ID Empleado", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#AEA1D6"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_liquidacion_trabajadores");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Liquidación de empleados");


            navegador1.AsignarComboConTabla("tbl_empleados", "pk_clave", "empleados_nombre", 1);
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
