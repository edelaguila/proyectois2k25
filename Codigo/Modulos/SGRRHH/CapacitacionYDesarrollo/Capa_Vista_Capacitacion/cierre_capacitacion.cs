using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

using System.Windows.Forms;
using Capa_Controlador_Capacitacion;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_Capacitacion
{
    public partial class cierre_capacitacion : Form
    {
        public string sIdUsuario { get; set; }
        logica LogicaSeg = new logica();

        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));


        controlador cn = new controlador();

        public cierre_capacitacion()
        {
            InitializeComponent();
            //// Crear un ToolTip
            ToolTip toolTip = new ToolTip();

            // Configuración de ToolTips para los botones
            toolTip.SetToolTip(Btn_nuevo, "Insertar un nuevo registro");
            toolTip.SetToolTip(Btn_guardar, "Guardar el registro actual");
            toolTip.SetToolTip(Btn_cancelar, "Cancelar la operacion");
            //toolTip.SetToolTip(Btn_Editar, "Editar el registro seleccionado");
            //toolTip.SetToolTip(Btn_Buscar, "Abrir consulta inteligente");
            toolTip.SetToolTip(Btn_ayuda, "Ver la ayuda del formulario");
            toolTip.SetToolTip(Btn_reporte, "Ver el reporte asociado");
            toolTip.SetToolTip(Btn_salir, "Salir del formulario");
            toolTip.SetToolTip(Btn_editarparámetros, "Abrir el formulario para editar los parámetros del semáforo");

        }
        private ToolTip toolTipAyuda = new ToolTip();

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
            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se generó un cierre", "cierre_capacitacion", "14003");

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
            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se cerró el formulario", "cierre_capacitacion", "14003");

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

            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se guardó un cierre de capacitación", "cierre_capacitacion", "14003");

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
                LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se canceló la operación", "cierre_capacitacion", "14003");

            }
        }

        private void Btn_editarparámetros_Click(object sender, EventArgs e)
        {

            parámetros_capacitación pr = new parámetros_capacitación();
            pr.Show();
            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se ingresó a la ventana para editar los parámetros del semáforo", "cierre_capacitacion", "14003");

        }

        private string sfunFindFileInDirectory(string sDirectory, string sFileName)
        {
            try
            {
                if (Directory.Exists(sDirectory))


                {
                    // Buscar todos los archivos .chm dentro de la carpeta y subcarpetas
                    string[] sFiles = Directory.GetFiles(sDirectory, "*.chm", SearchOption.AllDirectories);
                    // Retornar el archivo que coincida con el nombre buscado
                    return sFiles.FirstOrDefault(file => Path.GetFileName(file).Equals(sFileName, StringComparison.OrdinalIgnoreCase));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Error al buscar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // mensaje de error
            }

            return null; //retorna a null
        } //  **FIN AYUDA**

        private void cbCapacitación_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {

            // Obtener la ruta del ejecutable
            string sExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Buscar la carpeta raíz "proyectois2k25" desde el ejecutable
            string sProjectPath = sFindProjectRootDirectory(sExecutablePath, "proyectois2k25");

            if (string.IsNullOrEmpty(sProjectPath))
            {
                MessageBox.Show("❌ ERROR: No se encontró la carpeta 'proyectois2k25'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar el archivo .chm en la carpeta raíz y subcarpetas
            string sPathAyuda = sfunFindFileInDirectory(sProjectPath, "AyudaCierreCapacitacion.chm");

            // Si el archivo fue encontrado, abrirlo
            if (!string.IsNullOrEmpty(sPathAyuda))
            {
                try
                {
                    Help.ShowHelp(null, sPathAyuda); //para abrir archivo si es encontrado 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("⚠️ Error al abrir el archivo con Help.ShowHelp(): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.Process.Start(sPathAyuda);
                }
            }
            else
            {
                MessageBox.Show("❌ ERROR: No se encontró el archivo AyudaSanciones.chm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensaje de error
            }
            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se presionó el botón ayuda", "cierre_capacitacion", "14003");

        }

        private string sFindProjectRootDirectory(string startPath, string stargetFolder)
        {
            DirectoryInfo dir = new DirectoryInfo(startPath);
            // aca estara subiendo niveles o  la jerarquía de directorios hasta encontrar la carpeta "proyectois2k25"
            while (dir != null)
            {
                if (dir.Name.Equals(stargetFolder, StringComparison.OrdinalIgnoreCase))
                {
                    return dir.FullName; // Retorna la ruta de la carpeta raíz
                }
                dir = dir.Parent; // Subir un nivel en la jerarquía
            }
            return null; // Retorna null si no encuentra la carpeta
        }


        private void Btn_reporte_Click(object sender, EventArgs e)
        {

            ReporteCierre frm = new ReporteCierre();
            frm.Show();

            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se presionó el botón reporte", "cierre_capacitacion", "14003");

        }
    }
}
