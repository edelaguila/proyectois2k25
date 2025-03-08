using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Capa_Vista_Reporteria
{
    public partial class visualizar : Form
    {
        public visualizar(String texto)
        {
            InitializeComponent();
            direccion_reporte.Text = texto;
            mostrar();
        }

        // *Nuevo / MC*

        // Basado en el código de [Kateryn De Leon].
        // Fuente: Método [Btn_Ayuda_Click]
        //________________________________________________________________________________________________________________________________

        public void mostrar()
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

            // Obtener el nombre del reporte asegurando que tenga extensión .rpt
            string reporteNombre = direccion_reporte.Text.Trim();
            if (!reporteNombre.EndsWith(".rpt", StringComparison.OrdinalIgnoreCase))
            {
                reporteNombre += ".rpt";
            }

            //MessageBox.Show($"Buscando reporte: {reporteNombre}", "Depuración");

            // Buscar el archivo del reporte en la carpeta "Reportes"
            string sRutaReportes = Path.Combine(sProjectPath, "Reportes");
            //MessageBox.Show($"Buscando en: {sRutaReportes}", "Depuración");

            string sRutaReporte = sfunFindFileInDirectory(sRutaReportes, reporteNombre);

            if (!string.IsNullOrEmpty(sRutaReporte))
            {
                try
                {
                    ReportDocument crystalrpt = new ReportDocument();
                    crystalrpt.Load(sRutaReporte);
                    crystalReportViewer1.ReportSource = crystalrpt;
                    crystalReportViewer1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"⚠️ Error al cargar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"❌ ERROR: No se encontró el archivo del reporte '{reporteNombre}' en {sRutaReportes}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Busca la carpeta raíz del proyecto "proyectois2k25"
        private string sFindProjectRootDirectory(string startPath, string targetFolder)
        {
            DirectoryInfo dir = new DirectoryInfo(startPath);
            while (dir != null)
            {
                if (dir.Name.Equals(targetFolder, StringComparison.OrdinalIgnoreCase))
                {
                    return dir.FullName;
                }
                dir = dir.Parent; // Subir un nivel en la jerarquía
            }
            return null;
        }

        // Busca el archivo dentro de un directorio y sus subcarpetas.
        private string sfunFindFileInDirectory(string sDirectory, string sFileName)
        {
            try
            {
                if (Directory.Exists(sDirectory))
                {
                    //MessageBox.Show($"Explorando directorio: {sDirectory}", "Depuración");

                    string[] sFiles = Directory.GetFiles(sDirectory, "*.rpt", SearchOption.AllDirectories);
                    foreach (string file in sFiles)
                    {
                        //MessageBox.Show($"Encontrado: {file}", "Depuración");
                    }

                    return sFiles.FirstOrDefault(file => Path.GetFileName(file).Equals(sFileName, StringComparison.OrdinalIgnoreCase));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al buscar el archivo del reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }


        //________________________________________________________________________________________________________________________________

    }
}
