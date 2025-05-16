using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Capacitacion;

namespace Capa_Vista_Capacitacion
{
    public partial class notificacionSemaforo : Form
    {
        controlador cn = new controlador();
        private int idCapacitacion;
        private string nivel;
        private string nombreCompetencia;

        public notificacionSemaforo(decimal nota, decimal asistencia, string nivelActual, string nombreCompetencia)
        {
            this.nivel = nivelActual;
            this.nombreCompetencia = nombreCompetencia;

            lblPuntuacion.Text = $"Puntuación: {nota}%";
            lblAsistencia.Text = $"Asistencia: {asistencia}%";
            lblNivel.Text = $"Nivel actual: {nivelActual}";
            lblCompetencia.Text = $"Competencia: {nombreCompetencia}";
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario
           // this.idCapacitacion = idCapacitacion;

            EvaluarResultado(nota, asistencia);
        }
        public void EvaluarResultado(decimal promedio, decimal asistencia)
        {
            var parametros = cn.ObtenerParametros();
            decimal verde = parametros.LimiteVerde;
            decimal amarillo = parametros.LimiteAmarillo;

            if (promedio >= verde && asistencia >= 80)
            {
                this.BackColor = Color.Green;
                lblMensaje.Text = "NIVEL DE DEPARTAMENTO PROMOVIDO";
                lblMensaje.ForeColor = Color.White;
                cn.ActualizarNivelCompetencia(idCapacitacion, "verde");

            }
            else if ((promedio >= amarillo && promedio < verde) || asistencia < 80)
            {
                this.BackColor = Color.Goldenrod;
                lblMensaje.Text = "NO HAY CAMBIOS EN EL NIVEL DEL DEPARTAMENTO";
                lblMensaje.ForeColor = Color.Black;

            }
            else if (promedio < amarillo)
            {
                this.BackColor = Color.Red;
                lblMensaje.Text = "EL NIVEL DEL DEPARTAMENTO HA DISMINUIDO";
                lblMensaje.ForeColor = Color.White;
                cn.ActualizarNivelCompetencia(idCapacitacion, "rojo");

            }
        }
        private void notificacionSemaforo_Load(object sender, EventArgs e)
        {

        }
    }
}
