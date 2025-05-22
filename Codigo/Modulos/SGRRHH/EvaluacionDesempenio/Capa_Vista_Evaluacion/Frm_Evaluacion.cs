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
            ConfigurarDataGridView();
            CargarCompetencias();
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


        private void ConfigurarDataGridView()
        {
            Dgv_competencias.Columns.Clear();
            Dgv_competencias.AutoGenerateColumns = false;

            // Columna de selección
            Dgv_competencias.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Seleccionar",
                HeaderText = "Seleccionar",
                Width = 70
            });

            Dgv_competencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdCompetencia",
                HeaderText = "ID",
                DataPropertyName = "Pk_id_competencia",
                Visible = false
            });

            Dgv_competencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreCompetencia",
                HeaderText = "Competencia",
                DataPropertyName = "nombre_competencia",
                ReadOnly = true
            });

            Dgv_competencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descripcion",
                HeaderText = "Descripción",
                DataPropertyName = "descripcion",
                ReadOnly = true,
                Width = 200
            });

            Dgv_competencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Calificacion",
                HeaderText = "Calificación",
                ValueType = typeof(decimal)
            });

            Dgv_competencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Observacion",
                HeaderText = "Observación",
                ValueType = typeof(string),
                Width = 200
            });
        }


        private void CargarCompetencias()
        {
            DataTable competencias = controlador.ObtenerCompetenciasActivas();
            Dgv_competencias.DataSource = competencias;
        }


        private void InsertarDetallesEvaluacion(int idEvaluacion)
        {
            foreach (DataGridViewRow row in Dgv_competencias.Rows)
            {
                if (row.IsNewRow) continue;

                bool seleccionada = Convert.ToBoolean(row.Cells["Seleccionar"].Value ?? false);

                if (!seleccionada)
                    continue; // Solo evaluamos las seleccionadas

                object calificacionObj = row.Cells["Calificacion"].Value;

                if (calificacionObj == null || string.IsNullOrWhiteSpace(calificacionObj.ToString()))
                    continue;

                if (!decimal.TryParse(calificacionObj.ToString(), out decimal calificacion))
                    continue;

                int idCompetencia = Convert.ToInt32(row.Cells["IdCompetencia"].Value);
                string observacion = row.Cells["Observacion"].Value?.ToString() ?? "";

                controlador.InsertarDetalleEvaluacion(idEvaluacion, idCompetencia, calificacion, observacion);
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

            // Limpiar las columnas de calificación y observación en el DataGridView
            foreach (DataGridViewRow row in Dgv_competencias.Rows)
            {
                if (row.IsNewRow) continue;

                // Limpiar campos específicos
                row.Cells["Calificacion"].Value = null;
                row.Cells["Observacion"].Value = null;

                // (Opcional) también puedes desmarcar la casilla "Seleccionar"
                row.Cells["Seleccionar"].Value = false;
            }
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
