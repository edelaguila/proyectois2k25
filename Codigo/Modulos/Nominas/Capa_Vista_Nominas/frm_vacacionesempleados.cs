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
    public partial class frm_vacacionesempleados : Form
    {
        public frm_vacacionesempleados()
        {
            InitializeComponent();

            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            // ---------------------------------- Gabriela Suc ----------------------------------
            // Utilizando navegador
            string[] alias = { "pk_registro_vacaciones", "asignacion_vacaciones_descripcion", "asignacion_vacaciones_fecha_inicio", "asignacion_vacaciones_fecha_fin", "fk_clave_empleado", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#AEA1D6"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_asignacion_vacaciones");
            navegador1.ObtenerIdAplicacion("1000");
           navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Asignación de vacaciones");


            navegador1.AsignarComboConTabla("tbl_empleados", "pk_clave", "empleados_nombre", 1);
        }
    }
}
