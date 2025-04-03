using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_AsistenciaYFaltas;
using System.IO;

namespace Modelo_Vista_AsistenciaYFaltas
{
    public partial class frm_importar_asistencia : Form
    {
        public frm_importar_asistencia()
        {
            InitializeComponent();
        }

        private Controlador controlador = new Controlador();

            //Aun sin funcionamiento 

            // Evento para seleccionar el archivo
            private void btnSeleccionar_Click(object sender, EventArgs e)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Archivos de texto (*.txt)|*.txt",
                    Title = "Seleccionar archivo de asistencia"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_RutaArchivo.Text = openFileDialog.FileName;
                    CargarDatosEnGrid(openFileDialog.FileName);
                }
            }

            // Evento para importar la asistencia
            private void btnImportar_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(txt_RutaArchivo.Text))
                {
                    MessageBox.Show("Seleccione un archivo antes de importar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ProcesarArchivoAsistencia(txt_RutaArchivo.Text);
            }

            // Cargar datos en el DataGridView antes de importar
            private void CargarDatosEnGrid(string rutaArchivo)
            {
                dgvAsistencias.Rows.Clear();

                try
                {
                    string[] lineas = File.ReadAllLines(rutaArchivo);

                    foreach (string linea in lineas)
                    {
                        string[] partes = linea.Split(':');
                        string fechaTexto = partes[0].Trim('[', ']');
                        string[] horarioEmpleado = partes[1].Split(',');
                        string[] horas = horarioEmpleado[0].Split('-');
                        string idEmpleado = horarioEmpleado[1].Trim('.');

                        dgvAsistencias.Rows.Add(fechaTexto, horas[0], horas[1], idEmpleado);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Procesar archivo e insertar en la BD
            private void ProcesarArchivoAsistencia(string rutaArchivo)
            {
                try
                {
                    string[] lineas = File.ReadAllLines(rutaArchivo);

                    foreach (string linea in lineas)
                    {
                        string[] partes = linea.Split(':');
                        string fechaTexto = partes[0].Trim('[', ']');
                        string[] horarioEmpleado = partes[1].Split(',');
                        string[] horas = horarioEmpleado[0].Split('-');
                        string idEmpleado = horarioEmpleado[1].Trim('.');

                        DateTime fecha = DateTime.ParseExact(fechaTexto, "dd-MM-yyyy", null);
                        TimeSpan horaEntrada = TimeSpan.Parse(horas[0]);
                        TimeSpan horaSalida = TimeSpan.Parse(horas[1]);

                        controlador.RegistrarAsistencia(idEmpleado, fecha, horaEntrada, horaSalida);
                    }

                    MessageBox.Show("Asistencias importadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void frm_importar_asistencia_Load(object sender, EventArgs e)
        {

        }
    }
}


    

