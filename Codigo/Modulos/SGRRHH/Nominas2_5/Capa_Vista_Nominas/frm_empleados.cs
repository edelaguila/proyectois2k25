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
    public partial class frm_empleados : Form
    {
     
        //Metodos para que se abra solamente una ventana y no multiples
        private static frm_empleados instancia = null;
        public static frm_empleados ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frm_empleados();
            }
            return instancia;
        }
        public frm_empleados()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            /***************Fernando Jose Garcia <3*********************/
            ///*****Con tabla que tenga comboboxs foraneas *****/
            string[] alias = { "ID", "Nombre", "Apellido", "Fecha_Nac", "No. Identificacion",

                "Codigo postal","Fecha_alta","Fecha_baja","Causa_baja"

                ,"ID Depto","ID Puesto","Estado" };

            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarTabla("tbl_empleados");

            ///***Valores foraneos en Combobox*********/

            navegador1.AsignarComboConTabla("tbl_puestos_trabajo", "pk_id_puestos", "puestos_nombre_puesto", 1);
            navegador1.AsignarComboConTabla("tbl_departamentos", "pk_id_departamento", "departamentos_nombre_departamento", 1);
            ///******************/

            ///*****Se muestre en el dgv los nombres y no los numeros**/

            navegador1.AsignarForaneas("tbl_puestos_trabajo", "puestos_nombre_puesto", "fk_id_puestos", "pk_id_puestos");
            navegador1.AsignarForaneas("tbl_departamentos", "departamentos_nombre_departamento", "fk_id_departamento", "pk_id_departamento");

            ///*****************/

            /**************************************************************/

        }
    }
}
