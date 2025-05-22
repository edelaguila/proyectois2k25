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
    public partial class Frm_Reporte_Evaluacion_Desempenio : Form
    {
        private Controlador controlador; // Instancia del controlador
        public Frm_Reporte_Evaluacion_Desempenio()
        {
            InitializeComponent();
            controlador = new Controlador(); // Inicializar controlador
            this.Load += Frm_Reporte_Evaluacion_Desempenio_Load;
        }

        private void Frm_Reporte_Evaluacion_Desempenio_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }


        private void CargarEmpleados()
        {
            DataTable empleados = controlador.ObtenerEmpleados();
            Cmb_Empleados.DataSource = empleados;
            Cmb_Empleados.DisplayMember = "NombreEmpleado";  // Mostrar nombre completo
            Cmb_Empleados.ValueMember = "IdEmpleado";        // Usar ID como valor
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (Cmb_Empleados.SelectedValue != null)
            {
                int idEmpleado = Convert.ToInt32(Cmb_Empleados.SelectedValue);
                DataTable evaluaciones = controlador.ObtenerEvaluacionesPorEmpleado(idEmpleado);

                // Verifica si se obtuvieron resultados
                if (evaluaciones.Rows.Count > 0)
                {
                    Dgv_Reporte.DataSource = evaluaciones;  // Asignamos el DataTable al DataGridView
                }
                else
                {
                    MessageBox.Show("No se encontraron evaluaciones para el empleado seleccionado.", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para realizar la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

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
        private void button3_Click(object sender, EventArgs e)
        {
            // Mostrar el ToolTip en el boton ayuda
            toolTipAyuda.SetToolTip(button3, " Documento de ayuda ");

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

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte frm = new Reporte();
            frm.Show();
        }
    }
}
