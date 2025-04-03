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



        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_puesto puestos = new frm_puesto();
            puestos.Show();


        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
           frm_departamentos deptos = new frm_departamentos();
            deptos.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_empleados deptos = new frm_empleados();
            deptos.Show();
        }

        private void percepcionesdeduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_procesos_percepciones deptos = new frm_procesos_percepciones();
            deptos.Show();

        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_gencontrato deptos = new frm_gencontrato();
            deptos.Show();
        }

        private void horasExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_horasextra deptos = new frm_horasextra();
            deptos.Show();
        }

        private void planillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GenPlanilla deptos = new Frm_GenPlanilla();
            deptos.Show();
        }

        private void anticiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            frm_genanticipo deptos = new frm_genanticipo();
            deptos.Show();
        }

        private void faltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frm_genfaltas deptos = new frm_genfaltas();
            deptos.Show();



        }

        private void liquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_liquidacionempleados deptos = new frm_liquidacionempleados();
            deptos.Show();

        }

        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_vacacionesempleados deptos = new frm_vacacionesempleados();
            deptos.Show();
        }

        private void faltasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_calculo_faltas deptos = new frm_calculo_faltas();
            deptos.Show();
        }

        private void anticiposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_anticipos deptos = new frm_anticipos();
            deptos.Show();

        }

        private void horasExtrasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_horasextra deptos = new frm_horasextra();
            deptos.Show();
        }

        private void liquidacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_calcular_liquidacion deptos = new Frm_calcular_liquidacion();
            deptos.Show();
        }

        private void percepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_generacionpercepciones deptos = new frm_generacionpercepciones();
            deptos.Show();
        }

        private void deduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_generaciondeducciones deptos = new frm_generaciondeducciones();
            deptos.Show();
        }

        private void promocionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Promociones deptos = new frm_Promociones();
            deptos.Show();
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Carrera deptos = new frm_Carrera();
            deptos.Show();
        }

        private void capacitacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mantenimiento_capacitaciones deptos = new mantenimiento_capacitaciones();
            deptos.Show();
        }

        private void instructoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimiento_instructores deptos = new mantenimiento_instructores();
            deptos.Show();
        }

        private void postulanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Postulante deptos = new Frm_Postulante();
            deptos.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_perfil deptos = new Frm_perfil();
            deptos.Show();
        }

        private void competenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_competencias deptos = new Frm_competencias();
            deptos.Show();
        }

        private void aTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ats deptos = new Frm_ats();
            deptos.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bonos_Promociones deptos = new Frm_Bonos_Promociones();
            deptos.Show();
        }

        private void promocionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Frm_Bonos_Promociones deptos = new Frm_Bonos_Promociones();
            //deptos.Show();
        }

        private void bonosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Bonos_Promociones deptos = new Frm_Bonos_Promociones();
            deptos.Show();
        }

        private void resultadosEvaluaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Resultados_Evaluacion deptos = new Frm_Resultados_Evaluacion();
            deptos.Show();
        }

        private void faltasDisciplinariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_registrodisciplinario GD = new frm_registrodisciplinario();
            GD.Show();
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_importar_asistencia asistencia = new frm_importar_asistencia();
            asistencia.Show();
        }

        private void permisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_permisos asistencia = new frm_permisos();
            asistencia.Show();
        }

        private void gestiónFaltasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestiónEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cierre_capacitacion asistencia = new cierre_capacitacion();
            asistencia.Show();
        }

        private void cierresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista_Capacitacion.notas_capacitación asistencia = new Capa_Vista_Capacitacion.notas_capacitación();
            asistencia.Show();
        }

        private void registrarEvidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_evidencias GD = new frm_evidencias();
            GD.Show();
        }

        private void aplicarSanciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sanciones GD = new frm_sanciones();
            GD.Show();
        }

        private void expedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Expediente exp = new Frm_Expediente();
            exp.Show();
        }

        private void evaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Evaluacion ev = new Frm_Evaluacion();
            ev.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Evaluacion_Desempenio repo = new Frm_Reporte_Evaluacion_Desempenio();
            repo.Show();    
        }
    }
}
