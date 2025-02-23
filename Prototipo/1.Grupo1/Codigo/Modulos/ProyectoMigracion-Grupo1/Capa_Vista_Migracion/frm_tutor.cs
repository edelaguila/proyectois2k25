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
    public partial class frm_tutor : Form
    {
        public frm_tutor()
        {
            InitializeComponent();


            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            /*********Prueba con la tabla inicial*********/
            string[] alias = { "Id_Tutor", "Fk_id_usuario","Fk_id_usuario_menor","estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#ffd96b"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("Tbl_tutor_menor");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Tutor");
            /**********************************************/


            /********Valores foraneos en Combobox************************/

            navegador1.AsignarComboConTabla("Tbl_usuario", "Pk_id_usuario", "DPI_usuario", 1);
            navegador1.AsignarComboConTabla("Tbl_usuario_menor", " Pk_id_usuario_menor", "acta_nacimiento_usuario_menor", 1);
            /**************************************************/

            /************Se muestre en el dgv los nombres y no los numeros*******/

            navegador1.AsignarForaneas("Tbl_usuario", "nombre_usuario", "Fk_id_usuario", "Pk_id_usuario");
            navegador1.AsignarForaneas("Tbl_usuario_menor", "nombre_usuario_menor", "Fk_id_usuario_menor", "Pk_id_usuario_menor");

            /*************************************************/


        }
    }
}
