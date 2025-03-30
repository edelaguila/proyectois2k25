using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Carrera
{
    public partial class frm_Promociones : Form
    {
        public frm_Promociones()
        {
            InitializeComponent();

            //idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            ///*********Prueba con la tabla inicial*********/
            //string[] alias = { "Id_Promocion", "fk_clave_empleado", "fecha", "Puesto Actual", "Salario Actual","Puesto Nuevo", "Salario Nuevo","Motivo","estado" };
            //navegador1.AsignarAlias(alias);
            //navegador1.AsignarSalida(this);
            //navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#ffd96b"));
            //navegador1.AsignarColorFuente(Color.Black);
            //navegador1.ObtenerIdAplicacion("1000");
            //navegador1.AsignarAyuda("1");
            //navegador1.ObtenerIdUsuario(idUsuario);
            //navegador1.AsignarTabla("tbl_promociones");
            //navegador1.AsignarNombreForm("Promociones");

            /////********Valores foraneos en Combobox************************/

            //navegador1.AsignarComboConTabla("tbl_empleados", "pk_clave", "empleados_nombre", 1);

            /////**************************************************/

            ///////************Se muestre en el dgv los nombres y no los numeros*******/

            ////navegador1.AsignarForaneas("Tbl_usuario", "DPI_usuario", "Fk_id_usuario", "Pk_id_usuario");
            ////navegador1.AsignarForaneas("Tbl_oficina", "nombre_oficina", "Fk_id_oficina", "Pk_id_oficina");
            ////navegador1.AsignarForaneas("Tbl_empleado", "nombre_empleado", "Fk_id_empleado", "Pk_id_empleado");




        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
