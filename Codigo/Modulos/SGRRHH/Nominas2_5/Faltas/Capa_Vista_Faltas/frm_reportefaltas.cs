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
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using Capa_Controlador_Faltas;

namespace Capa_Vista_Faltas
{
    public partial class frm_reportefaltas : Form
    {
        public string sRutaProyecto { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));
        private Controlador controlador = new Controlador();

        public frm_reportefaltas()
        {
            InitializeComponent();
        }

        private void Btn_general_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();
            // Retroceder varios niveles desde el directorio base de la aplicación
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));
            string sRutaReporte = Path.Combine(sRutaProyecto, "Nominas", "Faltas", "Reportes", "faltas.rpt");

            try
            {
                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                // Mostrar el reporte en un formulario de Crystal Report Viewer
                Form viewerForm = new Form();
                CrystalReportViewer viewer = new CrystalReportViewer();
                viewer.Dock = DockStyle.Fill;
                viewer.ReportSource = reporte;
                viewerForm.Controls.Add(viewer);
                viewerForm.WindowState = FormWindowState.Maximized;
                viewerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message +
                               "\nStack Trace: " + ex.StackTrace);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
            }
        }

        private void Cbo_reportemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mesSeleccionado = Cbo_reportemes.SelectedItem.ToString();
            
        }

        private void frm_reportefaltas_Load(object sender, EventArgs e)
        {

            // Obtener los meses con faltas usando el controlador
            DataTable mesesConFaltas = controlador.ObtenerMesesConFaltas();

            // Limpiamos el ComboBox antes de agregar los nuevos meses
            Cbo_reportemes.Items.Clear();

            // Agregamos los meses con faltas al ComboBox
            foreach (DataRow row in mesesConFaltas.Rows)
            {
                Cbo_reportemes.Items.Add(row["faltas_mes"].ToString());
            }

            // Opcionalmente, seleccionar un mes por defecto si hay datos
            if (Cbo_reportemes.Items.Count > 0)
            {
                Cbo_reportemes.SelectedIndex = 0;
            }
        }

        private void Btn_generar_Click(object sender, EventArgs e)
        {
            // Verificar que haya un valor seleccionado en el ComboBox de meses
            if (Cbo_reportemes.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un mes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el mes seleccionado
            string mesSeleccionado = Cbo_reportemes.SelectedItem.ToString();

            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();
            string sRutaReporte = Path.Combine(sRutaProyecto, "Nominas", "Faltas", "Reportes", "faltas.rpt");

            try
            {
                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                // Verificar los parámetros disponibles en el reporte
                ParameterFields parametros = reporte.ParameterFields;

                // Establecer el parámetro usando el nombre exacto del parámetro en el reporte
                if (parametros.Count > 0)
                {
                    string nombreParametro = parametros[0].Name; // Cambia esto al nombre exacto del parámetro en el reporte
                    reporte.SetParameterValue(nombreParametro, mesSeleccionado);
                   
                }

                // Mostrar el reporte en un formulario de Crystal Report Viewer
                Form viewerForm = new Form();
                CrystalReportViewer viewer = new CrystalReportViewer();
                viewer.Dock = DockStyle.Fill;
                viewer.ReportSource = reporte;
                viewerForm.Controls.Add(viewer);
                viewerForm.WindowState = FormWindowState.Maximized;
                viewerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message + "\nStack Trace: " + ex.StackTrace);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
            }
        }
    }
}