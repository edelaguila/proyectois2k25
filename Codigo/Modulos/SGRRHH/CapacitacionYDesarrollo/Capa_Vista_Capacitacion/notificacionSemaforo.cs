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

        public notificacionSemaforo(decimal promedioPuntuacion, decimal porcentajeAsistencia)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            EvaluarResultado(promedioPuntuacion, porcentajeAsistencia);
        }

        private void EvaluarResultado(decimal promedio, decimal asistencia)
        {
            var parametros = cn.ObtenerParametros();
            decimal verde = parametros.LimiteVerde;
            decimal amarillo = parametros.LimiteAmarillo;

            if (promedio >= verde && asistencia >= 80)
            {
                this.BackColor = Color.Green;
                lblMensaje.Text = "NIVEL DE DEPARTAMENTO PROMOVIDO";
                lblMensaje.ForeColor = Color.White;
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
            }
        }

        private void notificacionSemaforo_Load(object sender, EventArgs e)
        {
        }
    }
}