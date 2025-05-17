using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using Capa_Controlador_Capacitacion;

namespace Capa_Vista_Capacitacion
{
    public partial class cierre_capacitacion : Form
    {
        controlador cn = new controlador();

        public cierre_capacitacion()
        {
            InitializeComponent();
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Btn_cancelar.Enabled = true;
            Btn_guardar.Enabled = true;
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                cbDepartamento.SelectedValue == null ||
                cbCapacitación.SelectedValue == null)
            {
                MessageBox.Show("Por favor complete todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCierre = int.Parse(txtID.Text);
            int idDepartamento = Convert.ToInt32(cbDepartamento.SelectedValue);
            int idCapacitacion = Convert.ToInt32(cbCapacitación.SelectedValue);

            // Obtener promedio de puntaje
            decimal promedioPuntaje = cn.ObtenerPromedioNotas(idDepartamento, idCapacitacion);

            // Mostrar en TrackBar de porcentaje
            int porcentajeRedondeado = (int)Math.Round(promedioPuntaje);
            tbPorcentaje.Value = Math.Max(tbPorcentaje.Minimum, Math.Min(porcentajeRedondeado, tbPorcentaje.Maximum));

            // Calcular porcentaje de asistencia
            int porcentajeAsistencia = (int)Math.Round(cn.CalcularPorcentajeAsistencia(idDepartamento, idCapacitacion));
            tbAsistencia.Value = Math.Max(tbAsistencia.Minimum, Math.Min(porcentajeAsistencia, tbAsistencia.Maximum));

            // Mostrar los valores numéricos en los Label
            lblMostrarporcentaje.Text = porcentajeRedondeado.ToString("F2") + " %";
            lblAsistencia.Text = porcentajeAsistencia.ToString("F2") + " %";

            MessageBox.Show("Datos calculados correctamente.\nAhora puedes guardar el cierre si lo deseas.", "Cálculo exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbPorcentaje_Scroll(object sender, EventArgs e)
        {

            //lblMostrarporcentaje.Text = tbPorcentaje.Value.ToString() + "%";

        }

        private void cierre_capacitacion_Load(object sender, EventArgs e)
        {
            CargarCierres();
            dtpFecha.MaxDate = DateTime.Today;
            dtpFecha.Value = DateTime.Today;
            int nuevoID = cn.ObtenerSiguienteCierre();
            txtID.Text = nuevoID.ToString();

            cbDepartamento.DataSource = cn.CargarDepartamentos();
            cbDepartamento.DisplayMember = "Value";
            cbDepartamento.ValueMember = "Key";
            cbDepartamento.SelectedValue = -1;

        }

        private void CargarCapacitacionesDesdeDepartamento()
        {
            if (cbDepartamento.SelectedValue != null && int.TryParse(cbDepartamento.SelectedValue.ToString(), out int idDepartamento))
            {
                List<KeyValuePair<int, string>> capacitaciones = cn.CargarCapacitacionesPorDepartamento(idDepartamento);
                cbCapacitación.DataSource = capacitaciones;
                cbCapacitación.DisplayMember = "Value";
                cbCapacitación.ValueMember = "Key";
            }
        }


        private void Btn_salir_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show(
           "¿Seguro que desea salir?",
             "Salir del formulario",
          MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
                    );

            // Si el usuario confirma (presiona Sí)
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCapacitacionesDesdeDepartamento();
            cbCapacitación.Enabled = true;

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            int idDepartamento = Convert.ToInt32(cbDepartamento.SelectedValue);
            int idCapacitacion = Convert.ToInt32(cbCapacitación.SelectedValue);
            string textoPuntuacion = lblMostrarporcentaje.Text.Replace("%", "").Trim();

            if (!decimal.TryParse(textoPuntuacion, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal puntuacion))
            {
                MessageBox.Show("El valor de la puntuación no es válido. Asegúrate de que sea un número.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string textoAsistencia = lblAsistencia.Text.Replace("%", "").Trim();

            if (!decimal.TryParse(textoAsistencia, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal porcentajeAsistencia))
            {
                MessageBox.Show("El valor de la asistencia no es válido. Asegúrate de que sea un número.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime fecha = DateTime.Now;

            try
            {
                cn.InsertarCierre(idDepartamento, idCapacitacion, puntuacion, porcentajeAsistencia, fecha);
                // Cambiar estado de la capacitación a 0
                cn.CambiarEstadoCapacitacion(idCapacitacion, 0);
                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCierres(); // para refrescar el DataGridView
                                 // Obtener ID de competencia a partir de la capacitación
                int idCompetencia = cn.ObtenerIdCompetenciaDesdeCapacitacion(idCapacitacion);

                // Obtener nivel actual desde tbl_departamentos_competencia
                string nivelActual = cn.ObtenerNivelActual(idDepartamento, idCompetencia);

                // Obtener nombre de la competencia (opcional, si no lo tienes en el comboBox)
                string nombreCompetencia = cn.ObtenerNombreCompetencia(idCompetencia);

                // Mostrar notificación semáforo con datos
                notificacionSemaforo noti = new notificacionSemaforo(puntuacion, porcentajeAsistencia);
                noti.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

            //Habilitar botones
            Btn_guardar.Enabled = false;
            Btn_cancelar.Enabled = false;
            Btn_nuevo.Enabled = true;

            // Limpiar ComboBoxes
            cbDepartamento.SelectedIndex = -1;
            cbCapacitación.SelectedIndex = -1;

            // Reiniciar TrackBars y Labels
            tbPorcentaje.Value = 0;
            tbAsistencia.Value = 0;
            lblMostrarporcentaje.Text = "0%";
            lblAsistencia.Text = "0%";

            // Obtener el siguiente ID para mostrarlo
            int nuevoID = cn.ObtenerSiguienteCierre();
            txtID.Text = nuevoID.ToString();


        }

        private void CargarCierres()
        {
            dgv_Cierres.DataSource = cn.ObtenerCierres();
        }


        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
           "¿Quiere cancelar la operación en curso?",
             "Confirmar cancelación",
          MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
                    );

            // Si el usuario confirma (presiona Sí)
            if (resultado == DialogResult.Yes)
            {
                Btn_guardar.Enabled = false;
                Btn_cancelar.Enabled = false;
                Btn_nuevo.Enabled = true;

                // Limpiar ComboBoxes
                cbDepartamento.SelectedIndex = -1;
                cbCapacitación.SelectedIndex = -1;

                // Reiniciar TrackBars y Labels
                tbPorcentaje.Value = 0;
                tbAsistencia.Value = 0;
                lblMostrarporcentaje.Text = "0%";
                lblAsistencia.Text = "0%";
            }
            }

        private void Btn_editarparámetros_Click(object sender, EventArgs e)
        {
            parámetros_capacitación pr = new parámetros_capacitación();
            pr.Show();
        }

        private void cbCapacitación_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
