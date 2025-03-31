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
    public partial class frm_gencontrato : Form
    {
        public frm_gencontrato()
        {
   
            InitializeComponent();

            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            // ---------------------------------- Gabriela Suc ----------------------------------
            //Utilizando navegador
            string[] alias = { "pk_id_contrato", "contratos_fecha_creacion", "contratos_salario", "contratos_tipo_contrato", "fk_clave_empleado", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_contratos");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Contratos");


            navegador1.AsignarComboConTabla("tbl_empleados", "pk_clave", "empleados_nombre", 1);
        }
    }
}
