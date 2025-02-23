using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Migracion
{
    public partial class frm_citas : Form
    {
        public frm_citas()
        {
            InitializeComponent();

            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            /*********Prueba con la tabla inicial*********/
            string[] alias = { "Id_Cita", "Fk_id_usuario ", "fecha", "Fk_id_oficina", "Fk_id_empleado", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#ffd96b"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarTabla("Tbl_cita");
            navegador1.AsignarNombreForm("Citas");

            ///********Valores foraneos en Combobox************************/

            navegador1.AsignarComboConTabla("Tbl_usuario", "Pk_id_usuario", "DPI_usuario", 1);
            navegador1.AsignarComboConTabla("Tbl_oficina", "Pk_id_oficina", "nombre_oficina ", 1);
            navegador1.AsignarComboConTabla("Tbl_empleado", "Pk_id_empleado", "nombre_empleado", 1);
            ///**************************************************/

            ///************Se muestre en el dgv los nombres y no los numeros*******/

            navegador1.AsignarForaneas("Tbl_usuario", "DPI_usuario", "Fk_id_usuario", "Pk_id_usuario");
            navegador1.AsignarForaneas("Tbl_oficina", "nombre_oficina", "Fk_id_oficina", "Pk_id_oficina");
            navegador1.AsignarForaneas("Tbl_empleado", "nombre_empleado", "Fk_id_empleado", "Pk_id_empleado");

            ///*************************************************/
        }
    }
}
