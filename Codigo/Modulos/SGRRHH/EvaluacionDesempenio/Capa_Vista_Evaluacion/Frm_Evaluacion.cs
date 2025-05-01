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
                controlador.InsertarDetalleEvaluacion(idEvaluacion, comp.idCompetencia, comp.calificacion, comp.comentarios);
            }
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se ha seleccionado un empleado y un evaluador
                if (Cmb_Empleado.SelectedValue == null || Cmb_Evaluador.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecciona un empleado y un evaluador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Detener la ejecución si los valores no son válidos
                }

                // Obtener datos desde los controles
                int idEmpleado = Convert.ToInt32(Cmb_Empleado.SelectedValue);  // Obtener el ID del empleado seleccionado
                int idEvaluador = Convert.ToInt32(Cmb_Evaluador.SelectedValue);  // Obtener el ID del evaluador seleccionado

                // Validar que se ha seleccionado un tipo de evaluación
                if (Cmb_Tipo_Ev.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona el tipo de evaluación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Detener la ejecución si no se seleccionó un tipo de evaluación
                }

                string tipoEvaluacion = Cmb_Tipo_Ev.SelectedItem.ToString();  // Obtener el tipo de evaluación
                decimal calificacionPromedio = 0;

                // Validar que la calificación sea un valor numérico válido
                if (!decimal.TryParse(Txt_calificacion.Text, out calificacionPromedio))
                {
                    MessageBox.Show("La calificación promedio no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string comentariosGenerales = Txt_ObservacionesGen.Text;  // Obtener los comentarios generales
                DateTime fechaEvaluacion = dateTimePicker1.Value;  // Obtener la fecha de evaluación

                // Insertar evaluación general y obtener ID generado
                int idEvaluacion = controlador.InsertarEvaluacion(
                    idEmpleado, idEvaluador, tipoEvaluacion, calificacionPromedio, comentariosGenerales, fechaEvaluacion
                );

                // Verificar si la evaluación fue insertada correctamente
                if (idEvaluacion > 0)
                {
                    // Insertar detalles de evaluación (competencias)
                    InsertarDetallesEvaluacion(idEvaluacion);

                    MessageBox.Show("¡Evaluación guardada correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar la evaluación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepción no manejada
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
