using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Capacitacion
{
    public partial class mantenimiento_capacitaciones : Form
    {
        public mantenimiento_capacitaciones()
        {
            InitializeComponent();

            string idusuario = Interfac_V3.UsuarioSesion.GetIdUsuario();


            string[] alias = { "ID", "Nombre", "Descripcion", "Departamento", "Instructor", "Fecha", "Hora", "Competencia", "Nivel_Final", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("14001");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idusuario);
            navegador1.AsignarTabla("tbl_capacitaciones");

            navegador1.AsignarNombreForm(" ");
            navegador1.AsignarComboConTabla("tbl_departamentos", "pk_id_departamento", "departamentos_nombre_departamento", 1);
            navegador1.AsignarComboConTabla("tbl_instructores", "pk_id_instructor", "instructores_nombre", 1);
            navegador1.AsignarComboConTabla("tbl_competencias", "Pk_id_competencia", "nombre_competencia", 1);
            navegador1.AsignarComboConTabla("tbl_nivelcompetencia", "pk_id_nivel", "nivel_nombre", 1);

            navegador1.AsignarForaneas("tbl_departamentos", "departamentos_nombre_departamento", "fk_id_departamento", "pk_id_departamento");
            navegador1.AsignarForaneas("tbl_instructores", "instructores_nombre", "fk_id_instructor", "pk_id_instructor");
            navegador1.AsignarForaneas("tbl_competencias", "nombre_competencia", "fk_id_competencia", "Pk_id_competencia");
            navegador1.AsignarForaneas("tbl_nivelcompetencia", "nivel_nombre", "fk_id_capacitaciones_nivelfinal", "pk_id_nivel");



        }
    }
}
