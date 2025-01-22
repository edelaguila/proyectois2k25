using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System.IO;//Para Ayudas
using Capa_Controlador_Presupuesto;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_Presupuesto
{
    public partial class ReportesPresupuesto : Form
    {
        public int iIdPres;
        Controlador control = new Controlador();
        logica logicaSeg = new logica();
        ToolTip toolTip = new ToolTip();
        public string sIdUsuario { get; set; } //Para Bitacora-------------!!!
        public ReportesPresupuesto(int iIdPresupuesto)
        { 
            InitializeComponent();
            this.iIdPres = iIdPresupuesto;
            toolTip.SetToolTip(Btn_reporte1, "Haz click para ver reporte");
            toolTip.SetToolTip(Btn_reporte2, "Haz click para ver reporte");
            toolTip.SetToolTip(Btn_reporte3, "Haz click para ver reporte");
            toolTip.SetToolTip(Btn_ayuda, "Haz click para ver ayuda");

        }
        private void ReportesPresupuesto_Load(object sender, EventArgs e)
        {
            control.CargarPresupuestosActivos(Cb_presupuestos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument reporte = new ReportDocument();
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

                // Construir la ruta a la carpeta del reporte
                string sReporteFolderPath = Path.Combine(projectRoot, "Reportes", "Modulos", "Contabilidad", "ReportePresupuesto");

                // Busca el archivo .rpt en la carpeta especificada
                string pathReporte = FindFileInDirectoryReporte(sReporteFolderPath, "ReportePresupuesto.rpt");

                if (!string.IsNullOrEmpty(pathReporte))
                {
                    // Cargar el reporte desde la ruta especificada
                    reporte.Load(pathReporte);
                    reporte.Refresh();

                    // Obtener el valor del ComboBox antes era STRING
                    int presupuestoSeleccionado = iIdPres;

                    // Pasar el parámetro al reporte
                    ParameterFieldDefinitions paramFieldDefinitions = reporte.DataDefinition.ParameterFields;
                    ParameterFieldDefinition paramFieldDefinition = paramFieldDefinitions["presupuesto"];

                    ParameterValues paramValues = new ParameterValues();
                    ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();
                    paramDiscreteValue.Value = presupuestoSeleccionado;
                    paramValues.Add(paramDiscreteValue);

                    paramFieldDefinition.ApplyCurrentValues(paramValues);

                    // Mostrar el reporte en un formulario de Crystal Report Viewer
                    Form viewerForm = new Form();
                    CrystalReportViewer viewer = new CrystalReportViewer();
                    viewer.Dock = DockStyle.Fill;
                    viewer.ReportSource = reporte;

                    viewerForm.Controls.Add(viewer);
                    viewerForm.WindowState = FormWindowState.Maximized;
                    viewerForm.ShowDialog();

                    // Bitacora------------------------!!!
                    logicaSeg.funinsertarabitacora(sIdUsuario, $"Se abrió el reporte de presupuesto: {presupuestoSeleccionado}", "Reporte Presupuesto", "8000");
                }
                else
                {
                    MessageBox.Show("El archivo de reporte no se encontró.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
            }
        }

        private string FindFileInDirectoryReporte(string directory, string fileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(directory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(directory, "*.rpt", SearchOption.TopDirectoryOnly);
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

        private void button2_Click(object sender, EventArgs e)
        {
            ReportDocument reporte = new ReportDocument();
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

                // Construir la ruta a la carpeta del reporte
                string sReporteFolderPath = Path.Combine(projectRoot, "Reportes", "Modulos", "Contabilidad", "ReportePresupuesto");

                // Busca el archivo .rpt en la carpeta especificada
                string pathReporte = FindFileInDirectoryReporte(sReporteFolderPath, "ReportePresupuesto2.rpt");

                if (!string.IsNullOrEmpty(pathReporte))
                {
                    // Cargar el reporte desde la ruta especificada
                    reporte.Load(pathReporte);
                    reporte.Refresh();

                    // Obtener el valor del ComboBox antes era STRING
                    int presupuestoSeleccionado = iIdPres;

                    // Pasar el parámetro al reporte
                    ParameterFieldDefinitions paramFieldDefinitions = reporte.DataDefinition.ParameterFields;
                    ParameterFieldDefinition paramFieldDefinition = paramFieldDefinitions["presupuesto"]; // Asegúrate de que "presupuesto" es el nombre correcto del parámetro en el reporte

                    ParameterValues paramValues = new ParameterValues();
                    ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();
                    paramDiscreteValue.Value = presupuestoSeleccionado;
                    paramValues.Add(paramDiscreteValue);

                    paramFieldDefinition.ApplyCurrentValues(paramValues);

                    // Mostrar el reporte en un formulario de Crystal Report Viewer
                    Form viewerForm = new Form();
                    CrystalReportViewer viewer = new CrystalReportViewer();
                    viewer.Dock = DockStyle.Fill;
                    viewer.ReportSource = reporte;

                    viewerForm.Controls.Add(viewer);
                    viewerForm.WindowState = FormWindowState.Maximized;
                    viewerForm.ShowDialog();

                    // Bitacora------------------------!!!
                    logicaSeg.funinsertarabitacora(sIdUsuario, $"Se abrió el reporte de presupuesto: {presupuestoSeleccionado}", "Reporte Presupuesto", "8000");
                }
                else
                {
                    MessageBox.Show("El archivo de reporte no se encontró.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Cb_presupuestos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un presupuesto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReportDocument reporte = new ReportDocument();
            var vItemSeleccionado = (KeyValuePair<string, string>)Cb_presupuestos.SelectedItem;
            //string sNombrePresupuesto = vItemSeleccionado.Value;
            string sIdPresupuesto = vItemSeleccionado.Key;
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

                // Construir la ruta a la carpeta del reporte
                string sReporteFolderPath = Path.Combine(projectRoot, "Reportes", "Modulos", "Contabilidad", "ReportePresupuesto");

                // Busca el archivo .rpt en la carpeta especificada
                string pathReporte = FindFileInDirectoryReporte(sReporteFolderPath, "ReportePresupuesto.rpt");

                if (!string.IsNullOrEmpty(pathReporte))
                {
                    // Cargar el reporte desde la ruta especificada
                    reporte.Load(pathReporte);
                    reporte.Refresh();

                    // Obtener el valor del ComboBox antes era STRING
                    string presupuestoSeleccionado = sIdPresupuesto;

                    // Pasar el parámetro al reporte
                    ParameterFieldDefinitions paramFieldDefinitions = reporte.DataDefinition.ParameterFields;
                    ParameterFieldDefinition paramFieldDefinition = paramFieldDefinitions["presupuesto"]; // Asegúrate de que "presupuesto" es el nombre correcto del parámetro en el reporte

                    ParameterValues paramValues = new ParameterValues();
                    ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();
                    paramDiscreteValue.Value = presupuestoSeleccionado;
                    paramValues.Add(paramDiscreteValue);

                    paramFieldDefinition.ApplyCurrentValues(paramValues);

                    // Mostrar el reporte en un formulario de Crystal Report Viewer
                    Form viewerForm = new Form();
                    CrystalReportViewer viewer = new CrystalReportViewer();
                    viewer.Dock = DockStyle.Fill;
                    viewer.ReportSource = reporte;

                    viewerForm.Controls.Add(viewer);
                    viewerForm.WindowState = FormWindowState.Maximized;
                    viewerForm.ShowDialog();

                    // Bitacora------------------------!!!
                    logicaSeg.funinsertarabitacora(sIdUsuario, $"Se abrió el reporte de presupuesto: {presupuestoSeleccionado}", "Reporte Presupuesto", "8000");
                }
                else
                {
                    MessageBox.Show("El archivo de reporte no se encontró.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
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
                string ayudaFolderPath = Path.Combine(projectRoot, "Ayuda", "Modulos", "Contabilidad", "AyudaPresupuesto");

                //MessageBox.Show("Ruta de búsqueda: " + ayudaFolderPath);

                // Busca el archivo .chm en la carpeta especificada
                string pathAyuda = FindFileInDirectory(ayudaFolderPath, "AyudaModPresupuesto.chm");

                if (!string.IsNullOrEmpty(pathAyuda))
                {
                    Help.ShowHelp(null, pathAyuda, "AyudaReportes.html");
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
