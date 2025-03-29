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
    public partial class Frm_perfil : Form
    {
        public Frm_perfil()
        {
            InitializeComponent();

            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            // ---------------------------------- Brandon Boch ----------------------------------
            // Utilizando navegador
            string[] alias = { "Id Perfil", "Puesto", "Esperincia necesitada", "Nivel educativo esperado", "Titulo esperado", "Salario mínimo", "Salario máximo", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.FromArgb(145, 79, 219));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_perfil_postulante");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Perfil del puesto");


            navegador1.AsignarComboConTabla("tbl_puestos_trabajo", "pk_id_puestos", "puestos_nombre_puesto", 1);
            navegador1.AsignarComboConTabla("Tbl_nivel_educativo", "Pk_id_nivel", "nivel", 1);

            navegador1.AsignarForaneas("tbl_puestos_trabajo", "puestos_nombre_puesto", "Fk_id_puestos", "pk_id_puestos");
            navegador1.AsignarForaneas("Tbl_nivel_educativo", "nivel", "Fk_nivel_educativo_esperado", "Pk_id_nivel");
        }
    }
}
