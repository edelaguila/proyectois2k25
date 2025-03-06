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
    public partial class Frm_usuario : Form
    {
        public Frm_usuario()
        {
            InitializeComponent();

            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            /*********Prueba con la tabla inicial*********/
            string[] alias = { "id", "nombre ", "apellido", "fecha_nacimiento", "genero", "DPI", "Boleto Ornato", "Fk_id_nacionalidad","direccion","telefono",
                "Correo","estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#ffd96b"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("Tbl_usuario");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Usuario");
            /**********************************************/

            ///********Valores foraneos en Combobox************************/

            navegador1.AsignarComboConTabla(" Tbl_nacionalidad", "Pk_id_nacionalidad", "nombre_nacionalidad ", 1);

            /**************************************************/

            ///************Se muestre en el dgv los nombres y no los numeros*******/

            navegador1.AsignarForaneas("Tbl_nacionalidad", "nombre_nacionalidad", "Fk_id_nacionalidad", "Pk_id_nacionalidad");


            ///*************************************************/



        }
    }
}
