using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Reclutamiento
{
    public partial class Frm_ats : Form
    {
        public Frm_ats()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            // ---------------------------------- Brandon Boch ----------------------------------
            // Utilizando navegador
            string[] alias = { "Id ats", "Postulante", "Puesto", "Estado del Proceso", "Fecha", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("Tbl_ats");
            navegador1.ObtenerIdAplicacion("13004");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("");

            navegador1.AsignarComboConTabla("Tbl_postulante", "Pk_id_postulante", "nombre_postulante", 1);
            navegador1.AsignarComboConTabla("Tbl_puestos_trabajo", "Pk_id_puestos", "puestos_nombre_puesto", 1);
            navegador1.AsignarComboConTabla("Tbl_status_ats", "Pk_id_status", "nombre_status", 1);

            navegador1.AsignarForaneas("Tbl_postulante", "nombre_postulante", "Fk_id_postulantes", "Pk_id_postulante");
            navegador1.AsignarForaneas("Tbl_puestos_trabajo", "puestos_nombre_puesto", "Fk_id_puesto", "Pk_id_puestos");
            navegador1.AsignarForaneas("Tbl_status_ats", "nombre_status", "Fk_id_status", "Pk_id_status");


        }
    }
}
