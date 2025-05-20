using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Faltas;
using Capa_Vista_Nominas;
using Capa_Vista_Planilla;
using Capa_Vista_Anticipos;
using Capa_Vista_Liquidaciones;
using Capa_Vista_PercepcionesDeducciones;
using Capa_Vista_Carrera;
using Capa_Vista_Capacitacion;
using Capa_Vista_Reclutamiento;
using Capa_Vista_Evaluacion;
using Capa_Vista_GD;
using Modelo_Vista_AsistenciaYFaltas;

namespace Capa_Vista_RRHH
{
    public partial class MDI_RRHH : Form
    {
        private int childFormNumber = 0;
        string idUsuario;
        private Timer timer;

        public MDI_RRHH(string idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            lbl_nombreUsuario.Text = idUsuario;
            timer = new Timer();
            timer.Interval = 1000; // 1000 ms = 1 segundo
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void MDI_RRHH_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

        }

        private void Pnl_NominaSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_FechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Lbl_FechaActual_Click(object sender, EventArgs e)
        {

        }

        bool ventanaMostrarUsuarios = false;
        frm_puesto MostrarUsuarios = new frm_puesto();

        private void CentrarFormulario(Form hijo)
        {
            hijo.StartPosition = FormStartPosition.Manual;
            int x = (this.ClientSize.Width - hijo.Width) / 2;
            int y = (this.ClientSize.Height - hijo.Height) / 2;
            hijo.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
        }


        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_puesto puestos = new frm_puesto();
            //puestos.Show();

            frm_puesto GD = new frm_puesto();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();

        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //frm_departamentos deptos = new frm_departamentos();
            // deptos.Show();

            frm_departamentos GD = new frm_departamentos();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();



        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_empleados deptos = new frm_empleados();
            //deptos.Show();
            frm_empleados GD = new frm_empleados();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }

        private void percepcionesdeduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_procesos_percepciones deptos = new frm_procesos_percepciones();
            //deptos.Show();

            frm_procesos_percepciones GD = new frm_procesos_percepciones();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();

        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_gencontrato deptos = new frm_gencontrato();
            //deptos.Show();

            frm_gencontrato GD = new frm_gencontrato();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();


        }

        private void horasExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_horasextra deptos = new frm_horasextra();
            //deptos.Show();

            frm_horasextra GD = new frm_horasextra();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }

        private void planillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_GenPlanilla deptos = new Frm_GenPlanilla();
            //deptos.Show();

            Frm_GenPlanilla GD = new Frm_GenPlanilla();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }

        private void anticiposToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //frm_genanticipo deptos = new frm_genanticipo();
            //deptos.Show();

            frm_genanticipo GD = new frm_genanticipo();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();


        }

        private void faltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //frm_genfaltas deptos = new frm_genfaltas();
            //deptos.Show();

            frm_genfaltas GD = new frm_genfaltas();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();


        }

        private void liquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //frm_liquidacionempleados deptos = new frm_liquidacionempleados();
            //deptos.Show();

            frm_liquidacionempleados GD = new frm_liquidacionempleados();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();



        }

        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_vacacionesempleados deptos = new frm_vacacionesempleados();
            //deptos.Show();

            frm_vacacionesempleados GD = new frm_vacacionesempleados();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }

        private void faltasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frm_calculo_faltas deptos = new frm_calculo_faltas();
            //deptos.Show();

            frm_calculo_faltas GD = new frm_calculo_faltas();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }

        private void anticiposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frm_anticipos deptos = new frm_anticipos();
            //deptos.Show();

            frm_anticipos GD = new frm_anticipos();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();


        }

        private void horasExtrasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frm_horasextra deptos = new frm_horasextra();
            //deptos.Show();

            Capa_Vista_HorasExtras.frm_horasextra GD = new Capa_Vista_HorasExtras.frm_horasextra();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();

        }

        private void liquidacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Frm_calcular_liquidacion deptos = new Frm_calcular_liquidacion();
            //deptos.Show();

            Frm_calcular_liquidacion GD = new Frm_calcular_liquidacion();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();

        }

        private void percepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_generacionpercepciones deptos = new frm_generacionpercepciones();
            //deptos.Show();

            frm_generacionpercepciones GD = new frm_generacionpercepciones();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();


        }

        private void deduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_generaciondeducciones deptos = new frm_generaciondeducciones();
            //deptos.Show();

            frm_generaciondeducciones GD = new frm_generaciondeducciones();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }

        private void promocionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_Promociones deptos = new frm_Promociones(idUsuario);
            //deptos.Show();

            frm_Promociones GD = new frm_Promociones(idUsuario);
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();



        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_Carrera deptos = new frm_Carrera();
            //deptos.Show();

            frm_Carrera GD = new frm_Carrera(idUsuario);
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }

        private void capacitacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //mantenimiento_capacitaciones deptos = new mantenimiento_capacitaciones();
            //deptos.Show();

            mantenimiento_capacitaciones GD = new mantenimiento_capacitaciones();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }

        private void instructoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mantenimiento_instructores deptos = new mantenimiento_instructores();
            //deptos.Show();

            mantenimiento_instructores GD = new mantenimiento_instructores();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();


        }

        private void postulanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_Postulante deptos = new Frm_Postulante();
            //deptos.Show();

            Frm_Postulante GD = new Frm_Postulante();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();


        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_perfil deptos = new Frm_perfil();
            //deptos.Show();

            Frm_perfil GD = new Frm_perfil();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }

        private void competenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_competencias deptos = new Frm_competencias();
            //deptos.Show();

            Frm_competencias GD = new Frm_competencias();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }

        private void aTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_ats deptos = new Frm_ats();
            //deptos.Show();

            Frm_ats GD = new Frm_ats();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_Bonos_Promociones deptos = new Frm_Bonos_Promociones();
            //deptos.Show();

            Frm_Bonos_Promociones GD = new Frm_Bonos_Promociones();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();



        }

        private void promocionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Frm_Bonos_Promociones deptos = new Frm_Bonos_Promociones();
            //deptos.Show();


        }

        private void bonosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Frm_Bonos_Promociones deptos = new Frm_Bonos_Promociones();
            //deptos.Show();

            Frm_Bonos_Promociones GD = new Frm_Bonos_Promociones();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();


        }

        private void resultadosEvaluaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_Resultados_Evaluacion deptos = new Frm_Resultados_Evaluacion();
            //deptos.Show();

            Frm_Resultados_Evaluacion GD = new Frm_Resultados_Evaluacion();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();




        }

        private void faltasDisciplinariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_registrodisciplinario GD = new frm_registrodisciplinario();
            //GD.Show();

            frm_registrodisciplinario GD = new frm_registrodisciplinario();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();



        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_importar_asistencia asistencia = new frm_importar_asistencia();
            //asistencia.Show();

            frm_importar_asistencia GD = new frm_importar_asistencia();
            GD.MdiParent = this;
            GD.StartPosition = FormStartPosition.CenterScreen; // O CenterParent
            GD.Show();
        }

        private void permisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_permisos asistencia = new frm_permisos();
            //asistencia.Show();

            frm_permisos GD = new frm_permisos();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();



        }

        private void gestiónFaltasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestiónEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Capa_Vista_Capacitacion.notas_capacitación asistencia = new Capa_Vista_Capacitacion.notas_capacitación();
            //asistencia.Show();

            Capa_Vista_Capacitacion.notas_capacitación GD = new Capa_Vista_Capacitacion.notas_capacitación();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }

        private void cierresToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //cierre_capacitacion asistencia = new cierre_capacitacion();
            //asistencia.Show();


            cierre_capacitacion GD = new cierre_capacitacion();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }

        private void registrarEvidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_evidencias GD = new frm_evidencias(idUsuario);
            //GD.Show();

            frm_evidencias GD = new frm_evidencias(idUsuario);
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }

        private void aplicarSanciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_sanciones GD = new frm_sanciones(idUsuario);
            //GD.Show();

            frm_sanciones GD = new frm_sanciones(idUsuario);
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();



        }

        private void expedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_Expediente exp = new Frm_Expediente();
            //exp.Show();

           Frm_Expediente GD = new Frm_Expediente();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();



        }

        private void evaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_Evaluacion ev = new Frm_Evaluacion();
            //ev.Show();

            Frm_Evaluacion GD = new Frm_Evaluacion();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();


        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_Reporte_Evaluacion_Desempenio repo = new Frm_Reporte_Evaluacion_Desempenio();
            //repo.Show();    

            Frm_Reporte_Evaluacion_Desempenio GD = new Frm_Reporte_Evaluacion_Desempenio();
            GD.MdiParent = this;
            CentrarFormulario(GD);
            GD.Show();
        }
    }
}
