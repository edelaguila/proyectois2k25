using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Evaluacion;
using System.IO;

namespace Capa_Vista_Evaluacion
{
    public partial class Frm_Evaluacion : Form
    {

        private Controlador controlador; // Instancia del controlador
        public Frm_Evaluacion()
        {
            InitializeComponent();
            controlador = new Controlador(); // Inicializar controlador
        }

        // Método para cargar los empleados en el ComboBox al iniciar el formulario
        private void Frm_Evaluacion_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarEvaluadores();
            CargarTiposEvaluacion();
        }

        // Método para cargar los empleados en el ComboBox
        private void CargarEmpleados()
        {
            DataTable empleados = controlador.ObtenerEmpleados();
            Cmb_Empleado.DataSource = empleados;
            Cmb_Empleado.DisplayMember = "NombreEmpleado";  // Mostrar nombre completo
            Cmb_Empleado.ValueMember = "IdEmpleado";        // Usar ID como valor
        }

        // Método para cargar los evaluadores en el ComboBox
        private void CargarEvaluadores()
        {
            DataTable evaluadores = controlador.ObtenerEvaluadores();
            Cmb_Evaluador.DataSource = evaluadores;
            Cmb_Evaluador.DisplayMember = "NombreEvaluador";  // Mostrar nombre completo
            Cmb_Evaluador.ValueMember = "IdEvaluador";        // Usar ID como valor
        }


        private void CargarTiposEvaluacion()
        {
            List<string> tiposEvaluacion = new List<string>
    {
        "Autoevaluación",
        "Evaluación de Compañero",
        "Evaluación de subordinado",
        "Evaluación de jefe de area"
    };

            Cmb_Tipo_Ev.DataSource = tiposEvaluacion;
        }


        // Método para insertar los detalles de la evaluación
        private void InsertarDetallesEvaluacion(int idEvaluacion)
        {
            var competencias = new List<(int idCompetencia, decimal calificacion, string comentarios)>
    {
        (1, Nud_Liderazgo.Value, Txt_competencia1.Text),
        (2, Nud_Trabajo_equipo.Value, Txt_competencia2.Text),
        (3, Nud_Comunicacion.Value, Txt_competencia3.Text),
        (4, Nud_Resolucion_Problemas.Value, Txt_competencia4.Text),
        (5, nud_Innovacion_creatividad.Value, Txt_competencia5.Text),
        (6, Nud_Tiempo.Value, Txt_competencia6.Text),
        (7, Nud_adaptabilidad.Value, Txt_competencia7.Text),
        (8, Nud_productividad.Value, Txt_competencia8.Text),
        (9, nud_orientacion_cliente.Value, Txt_competencia9.Text),
        (10, nud_responsabilidad.Value, Txt_competencia10.Text)
    };

            foreach (var comp in competencias)
            {
                try
                {
                    controlador.InsertarDetalleEvaluacion(idEvaluacion, comp.idCompetencia, comp.calificacion, comp.comentarios);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar competencia {comp.idCompetencia}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selección de empleado y evaluador
                if (Cmb_Empleado.SelectedValue == null || Cmb_Evaluador.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecciona un empleado y un evaluador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idEmpleado, idEvaluador;
                try
                {
                    idEmpleado = Convert.ToInt32(Cmb_Empleado.SelectedValue);
                    idEvaluador = Convert.ToInt32(Cmb_Evaluador.SelectedValue);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Los valores seleccionados no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar tipo de evaluación
                if (Cmb_Tipo_Ev.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona el tipo de evaluación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cmb_Tipo_Ev.Focus();
                    return;
                }

                string tipoEvaluacion = Cmb_Tipo_Ev.SelectedItem.ToString();

                // Validar calificación promedio
                if (!decimal.TryParse(Txt_calificacion.Text, out decimal calificacionPromedio))
                {
                    MessageBox.Show("La calificación promedio no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_calificacion.Focus();
                    return;
                }

                string comentariosGenerales = Txt_ObservacionesGen.Text;
                DateTime fechaEvaluacion = dateTimePicker1.Value;

                int idEvaluacion = 0;

                try
                {
                    // Insertar evaluación
                    idEvaluacion = controlador.InsertarEvaluacion(
                        idEmpleado, idEvaluador, tipoEvaluacion, calificacionPromedio, comentariosGenerales, fechaEvaluacion
                    );
                }
                catch (Exception exEval)
                {
                    MessageBox.Show("Error al guardar la evaluación general: " + exEval.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (idEvaluacion > 0)
                {
                    try
                    {
                        InsertarDetallesEvaluacion(idEvaluacion);
                        MessageBox.Show("¡Evaluación guardada correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exDetalles)
                    {
                        MessageBox.Show("La evaluación general fue guardada, pero ocurrió un error al guardar los detalles: " + exDetalles.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Error al guardar la evaluación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Captura general de errores no anticipados
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Opcional: escribir en log de errores
                // File.AppendAllText("log_errores.txt", $"{DateTime.Now} - {ex.ToString()}{Environment.NewLine}");
            }
        }


        private void Btn_Salir_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Frm_Reporte_Evaluacion_Desempenio
            Frm_Reporte_Evaluacion_Desempenio reporteForm = new Frm_Reporte_Evaluacion_Desempenio();

            // Mostrar el formulario como una ventana modal (el usuario no podrá interactuar con el formulario actual hasta que cierre este formulario)
            reporteForm.ShowDialog();
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar observaciones generales y calificación final
            Txt_ObservacionesGen.Text = "";
            Txt_calificacion.Text = "";

            // Reiniciar NumericUpDowns a 0 (o cualquier valor predeterminado)
            Nud_Liderazgo.Value = 0;
            Nud_Trabajo_equipo.Value = 0;
            Nud_Comunicacion.Value = 0;
            Nud_Resolucion_Problemas.Value = 0;
            nud_Innovacion_creatividad.Value = 0;
            Nud_Tiempo.Value = 0;
            Nud_adaptabilidad.Value = 0;
            Nud_productividad.Value = 0;
            nud_orientacion_cliente.Value = 0;
            nud_responsabilidad.Value = 0;

            // Limpiar TextBox de observaciones por competencia
            Txt_competencia1.Text = "";
            Txt_competencia2.Text = "";
            Txt_competencia3.Text = "";
            Txt_competencia4.Text = "";
            Txt_competencia5.Text = "";
            Txt_competencia6.Text = "";
            Txt_competencia7.Text = "";
            Txt_competencia8.Text = "";
            Txt_competencia9.Text = "";
            Txt_competencia10.Text = "";
        }

        // Declarar el ToolTip en el boton Ayuda
        private ToolTip toolTipAyuda = new ToolTip();
        private string funFindFileInDirectory(string sDirectory, string sFileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(sDirectory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] sFiles = Directory.GetFiles(sDirectory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in sFiles)
                    {
                        if (Path.GetFileName(file).Equals(sFileName, StringComparison.OrdinalIgnoreCase))
                        {
                            // MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {   //Mensaje de No se encontro la carpeta
                    // MessageBox.Show("No se encontró la carpeta: " + sDirectory);
                }
            }
            catch (Exception ex)
            {       //Mensaje de error al buscar el archivo
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }
        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            
                // Mostrar el ToolTip en el boton ayuda
                toolTipAyuda.SetToolTip(Btn_ayuda, " Documento de ayuda ");

                // Obtener la ruta del directorio del ejecutable
                string sExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Retroceder a la carpeta del proyecto
                string sProjectPath = Path.GetFullPath(Path.Combine(sExecutablePath, @"..\..\..\..\..\..\Ayuda\"));
                //  MessageBox.Show("1" + sProjectPath);


                string sAyudaFolderPath = Path.Combine(sProjectPath, "AyudaEvaluacion");

                string sPathAyuda = funFindFileInDirectory(sAyudaFolderPath, "AyudaEvaluacionYDesempenio.chm");

                // Verifica si el archivo existe antes de intentar abrirlo
                if (!string.IsNullOrEmpty(sPathAyuda))
                {
                    // MessageBox.Show("El archivo sí está.");
                    // Abre el archivo de ayuda .chm en la sección especificada
                    Help.ShowHelp(null, sPathAyuda, "AyudaEvaluacionYDesempenio.html");
                }
                else
                {
                    // Si el archivo no existe, muestra un mensaje de error
                    MessageBox.Show("El archivo de ayuda no se encontró.");
                }


            
        }
    }
}
