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
using Capa_Controlador_Seguridad;

namespace Modelo_Vista_AsistenciaYFaltas
{
    public partial class frm_importar_asistencia : Form
    {
        logica logicaSeg = new logica();
        

        private Controlador controlador = new Controlador();

       
        public string idUsuario { get; set; }


        public frm_importar_asistencia()
        {
            InitializeComponent(); // Aquí sí es correcto
        }
        private void frm_importar_asistencia_Load(object sender, EventArgs e)
        {

            dgvAsistencias.Rows.Clear();
        }


        private void CargarDatosEnGrid(string rutaArchivo)
        {
            var dt = new DataTable();
            dt.Columns.Add("Fecha", typeof(string));
            dt.Columns.Add("HoraEntrada", typeof(string));
            dt.Columns.Add("HoraSalida", typeof(string));
            dt.Columns.Add("IDEmpleado", typeof(string));

            string[] lineas;
            try
            {
                lineas = File.ReadAllLines(rutaArchivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Se leyeron {lineas.Length} líneas del archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var lineasErroneas = new List<string>();

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                int idx = linea.IndexOf("]:");
                if (idx < 0)
                {
                    lineasErroneas.Add(linea);
                    continue;
                }

                string fechaTexto = linea.Substring(1, idx - 1);
                string resto = linea.Substring(idx + 2);

                var partes = resto.Split(',');
                if (partes.Length != 2)
                {
                    lineasErroneas.Add(linea);
                    continue;
                }

                var horas = partes[0].Split('-');
                if (horas.Length != 2)
                {
                    lineasErroneas.Add(linea);
                    continue;
                }

                var idEmpleado = partes[1].TrimEnd('.');

                dt.Rows.Add(fechaTexto, horas[0], horas[1], idEmpleado);
            }

            dgvAsistencias.AutoGenerateColumns = true;
            dgvAsistencias.DataSource = dt;
            dgvAsistencias.AutoResizeColumns();

            if (lineasErroneas.Any())
            {
                MessageBox.Show($"Hubo {lineasErroneas.Count} línea(s) con formato inválido.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog
            {
                Filter = "Archivos de texto (*.txt)|*.txt",
                Title = "Seleccionar archivo de asistencia"
            })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txt_RutaArchivo.Text = dlg.FileName;
                    CargarDatosEnGrid(dlg.FileName);
                }
            }

            logicaSeg.funinsertarabitacora(idUsuario, "se cargo asistencia", "tbl_asistencia_preeliminar", "16002");
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
                // 1) Insertar cada línea en la tabla preliminar
                foreach (var linea in File.ReadAllLines(txt_RutaArchivo.Text))
                    controlador.InsertarAsistenciaPreliminar(linea);

                // 2) Procesar el staging para volcar en tbl_asistencias
                //controlador.ProcesarAsistenciasPreliminar();

                // 3) Abrir el formulario de validación
                using (var frmValida = new frm_validar_asistencia())
                    frmValida.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
           frm_reporte_asistencia formularioReporteAsi = new frm_reporte_asistencia();

            // Mostrar el formulario
            formularioReporteAsi.ShowDialog();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                // Buscar la carpeta raíz del proyecto (donde está la carpeta "Codigo")
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;
                string projectRoot = executablePath;

                // Buscar hacia arriba hasta encontrar la carpeta "Codigo"
                while (!Directory.Exists(Path.Combine(projectRoot, "Codigo")) &&
                       Directory.GetParent(projectRoot) != null)
                {
                    projectRoot = Directory.GetParent(projectRoot).FullName;
                }

                // Construir la ruta a la carpeta de ayuda
                string ayudaFolderPath = Path.Combine(projectRoot,
                    "Codigo", "Modulos", "SGRRHH", "Asistencia y Faltas", "Ayudas");

                //  MessageBox.Show("Ruta de búsqueda: " + ayudaFolderPath);

                // Busca el archivo .chm en la carpeta especificada
                string pathAyuda = FindFileInDirectory(ayudaFolderPath, "AyudaAsistencia.chm");

                if (!string.IsNullOrEmpty(pathAyuda))
                {
                    Help.ShowHelp(null, pathAyuda, "AyudaFaltas.html");
                }
                else
                {
                    MessageBox.Show("El archivo de ayuda no se encontró.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el archivo de ayuda: " + ex.Message);
            }
        }
        private string FindFileInDirectory(string directory, string fileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(directory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(directory, "*.chm", SearchOption.TopDirectoryOnly);
                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in files)
                    {
                        if (Path.GetFileName(file).Equals(fileName, StringComparison.OrdinalIgnoreCase))
                        {
                            //MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la carpeta: " + directory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }
            // Retorna null si no se encontró el archivo
            return null;
        }
    }

    }