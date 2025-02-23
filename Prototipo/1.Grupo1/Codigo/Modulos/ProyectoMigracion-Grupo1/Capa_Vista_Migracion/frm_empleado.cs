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
    public partial class frm_empleado : Form
    {
        public frm_empleado()
        {
            InitializeComponent();


            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            /*********Prueba con la tabla inicial*********/
            string[] alias = { "Id_Empleado", "Nombre", "Apellido", "Cargo", "Fk_id_oficina", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#ffd96b"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("Tbl_empleado");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");

            /**********************************************/

            ///********Valores foraneos en Combobox************************/

            navegador1.AsignarComboConTabla("Tbl_oficina", "Pk_id_oficina", "nombre_oficina", 1);

            /**************************************************/

            ///************Se muestre en el dgv los nombres y no los numeros*******/

            navegador1.AsignarForaneas("Tbl_oficina", "nombre_oficina", "Fk_id_oficina", "Pk_id_oficina");


            ///*************************************************/

            navegador1.AsignarNombreForm("Empleados");


            /***************************************************/




        }
    }
}
