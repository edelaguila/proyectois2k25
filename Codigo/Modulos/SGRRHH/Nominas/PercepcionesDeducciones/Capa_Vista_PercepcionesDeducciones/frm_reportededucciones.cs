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
using Capa_Controlador_PercepcionesDeducciones;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace Capa_Vista_PercepcionesDeducciones
{
    public partial class frm_reportededucciones : Form
    {
        public string sRutaProyecto { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));

        private Controlador controlador = new Controlador();
        public frm_reportededucciones()
        {
            InitializeComponent();
            CargarDepartamentos();
            Chk_filtros.CheckedChanged += Chk_filtros_CheckedChanged; // Conectar el evento
            Cbo_reportesdeducciones.DropDownStyle = ComboBoxStyle.DropDownList;
            //Crear un ToolTip
            ToolTip toolTip = new ToolTip();

            // Configuración de ToolTips para los botones
            toolTip.SetToolTip(Btn_general, "Ver reporte general");
            toolTip.SetToolTip(Btn_generar, "Generar reporte especifico");
        }

        private void CargarDepartamentos()
        {
            try
            {
                DataTable tablaDepartamentos = controlador.ObtenerDepartamentos();
                if (tablaDepartamentos != null && tablaDepartamentos.Rows.Count > 0)
                {
                    Cbo_reportesdeducciones.DataSource = tablaDepartamentos;
                    Cbo_reportesdeducciones.DisplayMember = "departamentos_nombre_departamento";
                    Cbo_reportesdeducciones.ValueMember = "pk_id_departamento";
                }
                else
                {
                    MessageBox.Show("No se encontraron departamentos activos.",
                                  "Información",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los departamentos: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void Btn_generar_Click(object sender, EventArgs e)
        {
            // Verificar que haya un valor seleccionado en el ComboBox
            if (Cbo_reportesdeducciones.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un departamento",
                               "Advertencia",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            // Obtener el nombre del departamento seleccionado
            string departamentoNombre = Cbo_reportesdeducciones.Text; // Esto obtiene el texto mostrado en el ComboBox

            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();
            // Retroceder varios niveles desde el directorio base de la aplicación
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));
            string sRutaReporte = Path.Combine(sRutaProyecto, "Nominas", "PercepcionesDeducciones", "Reportes", "deducciones.rpt");

            try
            {
                // Mostrar la ruta en un MessageBox para verificar
               // MessageBox.Show("Ruta del reporte: " + sRutaReporte, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                // Verificar los parámetros disponibles en el reporte
                ParameterFields parametros = reporte.ParameterFields;
                string nombresParametros = "";
                foreach (ParameterField param in parametros)
                {
                    nombresParametros += param.Name + "\n";
                }
                //MessageBox.Show("Parámetros disponibles en el reporte:\n" + nombresParametros);

                // Intentar establecer el parámetro usando el nombre exacto del primer parámetro
                if (parametros.Count > 0)
                {
                    string nombreParametro = parametros[0].Name;
                    reporte.SetParameterValue(nombreParametro, departamentoNombre);
                   // MessageBox.Show($"Parámetro establecido: {nombreParametro} = {departamentoNombre}");
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

        private void frm_reportededucciones_Load(object sender, EventArgs e)
        {
            Chk_filtros.Checked = false; // Inicialmente, el CheckBox está desmarcado
            Gbo_filtros.Enabled = false;  // Deshabilitar filtros al cargar el formulario
            Gbo_sinfiltros.Enabled = true; // Habilitar sin filtros al cargar el formulario
        }

        private void Btn_general_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();
            // Retroceder varios niveles desde el directorio base de la aplicación
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));
            string sRutaReporte = Path.Combine(sRutaProyecto, "Nominas", "PercepcionesDeducciones", "Reportes", "deduccionesgenerales.rpt");

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

        private void Chk_filtros_CheckedChanged(object sender, EventArgs e)
        {
            // Habilita o deshabilita los GroupBox según el estado del CheckBox
            Gbo_filtros.Enabled = Chk_filtros.Checked;         // Habilita Gbo_filtros si Cbx_filtros está marcado
            Gbo_sinfiltros.Enabled = !Chk_filtros.Checked;     // Habilita Gbo_sinFiltros si Cbx_filtros no está marcado
        }

    }
}
