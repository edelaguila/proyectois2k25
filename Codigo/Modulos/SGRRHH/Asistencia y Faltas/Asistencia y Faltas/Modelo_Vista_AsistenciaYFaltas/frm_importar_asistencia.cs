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

       

        // Evento para seleccionar el archivo
        private void frm_importar_asistencia_Load(object sender, EventArgs e)
        {
            // Init DataGridView: asegurate de tener 4 columnas configuradas en el diseñador:
            // Fecha, HoraEntrada, HoraSalida, IDEmpleado
            dgvAsistencias.Rows.Clear();
        }

      

        // 2) Cargar previsualización en el DataGridView
        private void CargarDatosEnGrid(string rutaArchivo)
        {
            var dt = new DataTable();
            dt.Columns.Add("Fecha", typeof(string));
            dt.Columns.Add("HoraEntrada", typeof(string));
            dt.Columns.Add("HoraSalida", typeof(string));
            dt.Columns.Add("IDEmpleado", typeof(string));

            var lineas = File.ReadAllLines(rutaArchivo);
            MessageBox.Show($"Se leyeron {lineas.Length} líneas del archivo."); // ← Para verificar que sí lee

            List<string> lineasErroneas = new List<string>(); // <--- Declaramos aquí

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                try
                {
                    int idx = linea.IndexOf("]:"); // <-- Corrige aquí (sin "v")
                    if (idx == -1)
                    {
                        lineasErroneas.Add(linea);
                        continue;
                    }

                    string fechaTexto = linea.Substring(0, idx + 1).Trim('[', ']');
                    string resto = linea.Substring(idx + 2); // después del ]:

                    string[] horarioEmpleado = resto.Split(',');
                    if (horarioEmpleado.Length != 2)
                    {
                        lineasErroneas.Add(linea);
                        continue;
                    }

                    string[] horas = horarioEmpleado[0].Split('-');
                    if (horas.Length != 2)
                    {
                        lineasErroneas.Add(linea);
                        continue;
                    }

                    string idEmpleado = horarioEmpleado[1].Trim('.');

                    dt.Rows.Add(fechaTexto, horas[0], horas[1], idEmpleado); // <-- Agrega al DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error procesando línea:\n{linea}\n\nError: {ex.Message}");
                }
            }

            dgvAsistencias.DataSource = dt;  // <-- al final ligamos el DataTable al DGV
            dgvAsistencias.AutoResizeColumns();

            if (lineasErroneas.Any())
            {
                MessageBox.Show($"Hubo {lineasErroneas.Count} línea(s) que no pudieron procesarse.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog()
            {
                Filter = "Archivos de texto (*.txt)|*.txt",
                Title = "Seleccionar archivo de asistencia"
            })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txt_RutaArchivo.Text = dlg.FileName;
                    
                }
                CargarDatosEnGrid(dlg.FileName);
            }
        }

        private void btn_importar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_RutaArchivo.Text))
            {
                MessageBox.Show("Seleccione un archivo antes de importar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Inserta cada línea cruda en tbl_asistencias_preeliminar
                foreach (var linea in File.ReadAllLines(txt_RutaArchivo.Text))
                {
                    controlador.InsertarAsistenciaPreliminar(linea);
                }

                // Abre el formulario de validación (selección mes/año, días laborados, excepciones...)
                using (var frmValida = new frm_validar_asistencia())
                {
                    frmValida.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el archivo: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAsistencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

 
    }



    

