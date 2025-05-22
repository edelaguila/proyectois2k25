using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_PercepcionesDeducciones;
using Capa_Controlador_Seguridad;
using Capa_Modelo_Seguridad;
using System.IO; // Necesario para Directory, File, Path y SearchOption

namespace Capa_Vista_PercepcionesDeducciones
{
    public partial class frm_generacionpercepciones : Form
    {
        private Controlador cn = new Controlador();
        logica logicaSeg = new logica();
        public string idUsuario { get; set; }
        public frm_generacionpercepciones()
        {
            InitializeComponent();
            CargarPercepciones();
            Dgv_genpercepciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Crear un ToolTip
            ToolTip toolTip = new ToolTip();
            // Configuración de ToolTips para los botones
            toolTip.SetToolTip(Btn_ayuda, "Ver ayuda");
            toolTip.SetToolTip(Btn_reportes, "Generar reporte");
        }

        private void CargarPercepciones()
        {
            try
            {
                DataTable percepciones = cn.ObtenerPercepciones();
                if (percepciones.Rows.Count > 0)
                {
                    Dgv_genpercepciones.DataSource = percepciones;
                    logicaSeg.funinsertarabitacora(idUsuario, "Se consulto percepciones y se encontraron datos", "tbl_dedu_perp_emp", "6005");
                }
                else
                {
                    MessageBox.Show("No se encontraron percepciones.");
                    logicaSeg.funinsertarabitacora(idUsuario, "Se consulto percepciones y no se encontraron datos", "tbl_dedu_perp_emp", "6005");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar percepciones: " + ex.Message);
            }
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
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
                    "Codigo", "Modulos", "Nominas", "PercepcionesDeducciones", "Ayudas");

               // MessageBox.Show("Ruta de búsqueda: " + ayudaFolderPath);

                // Busca el archivo .chm en la carpeta especificada
                string pathAyuda = FindFileInDirectory(ayudaFolderPath, "AyudaPercepciones.chm");

                if (!string.IsNullOrEmpty(pathAyuda))
                {
                    Help.ShowHelp(null, pathAyuda, "ayudaPercepciones_2024.html");
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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            frm_reportepercepciones frm_reportes = new frm_reportepercepciones();
            frm_reportes.Show();
        }
    }
}
