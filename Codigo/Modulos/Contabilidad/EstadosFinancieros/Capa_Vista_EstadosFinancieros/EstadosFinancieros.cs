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
using System.IO;
using CrystalDecisions.Windows.Forms;
using Capa_Controlador_Seguridad;



namespace Capa_Vista_EstadosFinancieros
{
    public partial class EstadosFinancieros : Form
    {
        public string sRutaProyecto { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));
        logica lg = new logica();
        ToolTip toolTip = new ToolTip();

        public string idUsuario { get; set; }

        public EstadosFinancieros()
        {
            InitializeComponent();
        }

        private void btn_Ver_Balance_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();

            // Ruta del reporte
            string sRutaReporte = Path.Combine(sRutaProyecto, "Contabilidad", "EstadosFinancieros", "ReportesEstados", "Balance.rpt");

            try
            {
                // Mostrar la ruta en un MessageBox para verificar
                MessageBox.Show("Ruta del reporte: " + sRutaReporte, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                //Bitacora
                lg.funinsertarabitacora(idUsuario, "Se consulto el Balance", "Balance Actual", "8000");

                // Forzar la actualización del reporte
                reporte.Refresh();

                // Mostrar el reporte en un formulario de Crystal Report Viewer
                Form viewerForm = new Form();
                CrystalReportViewer viewer = new CrystalReportViewer();
                viewer.Dock = DockStyle.Fill;
                viewer.ReportSource = reporte;

                // Actualizar el reporte en el CrystalReportViewer
                viewer.RefreshReport();

                viewerForm.Controls.Add(viewer);
                viewerForm.WindowState = FormWindowState.Maximized;
                viewerForm.ShowDialog();
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


        private void btn_VerFlujo_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();

            // Ruta del reporte
            string sRutaReporte = Path.Combine(sRutaProyecto, "Contabilidad", "EstadosFinancieros", "ReportesEstados", "FlujoDeEfectivo.rpt");

            try
            {
                // Mostrar la ruta en un MessageBox para verificar
                MessageBox.Show("Ruta del reporte: " + sRutaReporte, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                //Bitacora
                lg.funinsertarabitacora(idUsuario, "Se consulto Flujo de Efectivo", "Flujo de Efectivo Actual", "8000");

                // Forzar la actualización del reporte
                reporte.Refresh();

                // Mostrar el reporte en un formulario de Crystal Report Viewer
                Form viewerForm = new Form();
                CrystalReportViewer viewer = new CrystalReportViewer();
                viewer.Dock = DockStyle.Fill;
                viewer.ReportSource = reporte;

                // Actualizar el reporte en el CrystalReportViewer
                viewer.RefreshReport();

                viewerForm.Controls.Add(viewer);
                viewerForm.WindowState = FormWindowState.Maximized;
                viewerForm.ShowDialog();
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


        private void btn_VerEstadoResultados_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();

            // Ruta del reporte
            string sRutaReporte = Path.Combine(sRutaProyecto, "Contabilidad", "EstadosFinancieros", "ReportesEstados", "EstadoDeResultados.rpt");

            try
            {
                // Mostrar la ruta en un MessageBox para verificar
                MessageBox.Show("Ruta del reporte: " + sRutaReporte, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                // Bitacora
                lg.funinsertarabitacora(idUsuario, "Se consulto Estado de Resultados", "Estado de Resultados Actual", "8000");

                // Forzar la actualización del reporte
                reporte.Refresh();

                // Mostrar el reporte en un formulario de Crystal Report Viewer
                Form viewerForm = new Form();
                CrystalReportViewer viewer = new CrystalReportViewer();
                viewer.Dock = DockStyle.Fill;
                viewer.ReportSource = reporte;

                // Actualizar el reporte en el CrystalReportViewer
                viewer.RefreshReport();

                viewerForm.Controls.Add(viewer);
                viewerForm.WindowState = FormWindowState.Maximized;
                viewerForm.ShowDialog();
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


        private void btn_Ver_BalanceHistorico_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();

            // Ruta del reporte
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\")); // Ajusta según sea necesario
            string sRutaReporte = Path.Combine(sRutaProyecto, "Contabilidad", "EstadosFinancieros", "ReportesEstados", "BalanceHistorico.rpt");

            try
            {
                // Mostrar la ruta en un MessageBox para verificar
                MessageBox.Show("Ruta del reporte: " + sRutaReporte, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                //Bitacora
                lg.funinsertarabitacora(idUsuario, "Se consulto Balance Historico", "Balance Historico", "8000");

                // Intentar obtener los valores seleccionados de los combo boxes
                try
                {
                    int mesSeleccionado = int.Parse(Cbo_BalanceMes.SelectedItem?.ToString() ?? throw new Exception("Seleccione un mes."));
                    int anioSeleccionado = int.Parse(Cbo_BalanceAnio.SelectedItem?.ToString() ?? throw new Exception("Seleccione un año."));

                    // Asignar los valores al reporte
                    reporte.SetParameterValue("Mes", mesSeleccionado);
                    reporte.SetParameterValue("Anio", anioSeleccionado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la selección de mes/año: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método si hay un error en los combo boxes
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
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
            }
        }




        private void btn_Ver_EResultadosHistorico_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();

            // Ruta del reporte
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\")); // Ajusta según sea necesario
            string sRutaReporte = Path.Combine(sRutaProyecto, "Contabilidad", "EstadosFinancieros", "ReportesEstados", "EstadoDeResultadosHistorico.rpt");

            try
            {
                // Mostrar la ruta en un MessageBox para verificar
                MessageBox.Show("Ruta del reporte: " + sRutaReporte, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);

                //Bitacora
                lg.funinsertarabitacora(idUsuario, "Se consulto Estado de Resultados Historico", "Estado de Resultados Historico", "8000");

                // Intentar obtener los valores seleccionados de los combo boxes
                try
                {
                    int mesSeleccionado = int.Parse(Cbo_EResultadosMes.SelectedItem?.ToString() ?? throw new Exception("Seleccione un mes."));
                    int anioSeleccionado = int.Parse(Cbo_EResultadosAnio.SelectedItem?.ToString() ?? throw new Exception("Seleccione un año."));

                    // Asignar los valores al reporte
                    reporte.SetParameterValue("Mes", mesSeleccionado);
                    reporte.SetParameterValue("Anio", anioSeleccionado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la selección de mes/año: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método si hay un error en los combo boxes
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
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
            }
        }


        private void btn_Ver_FEfectivoHistorico_Click(object sender, EventArgs e)
        {
            // Crear una instancia del reporte
            ReportDocument reporte = new ReportDocument();

            // Ruta del reporte
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\")); // Ajusta según sea necesario
            string sRutaReporte = Path.Combine(sRutaProyecto, "Contabilidad", "EstadosFinancieros", "ReportesEstados", "FlujoDeEfectivoHistorico.rpt");

            try
            {
                // Mostrar la ruta en un MessageBox para verificar
                MessageBox.Show("Ruta del reporte: " + sRutaReporte, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar el reporte desde la ruta especificada
                reporte.Load(sRutaReporte);
                reporte.Refresh(); // Asegurarse de que el reporte esté actualizado

                //Bitacora
                lg.funinsertarabitacora(idUsuario, "Se consulto Flujo de efectivo Historico", "Flujo de Efectivo Historico", "8000");

                // Intentar obtener los valores seleccionados de los combo boxes
                try
                {
                    int mesSeleccionado = int.Parse(Cbo_FEfectivoMes.SelectedItem?.ToString() ?? throw new Exception("Seleccione un mes."));
                    int anioSeleccionado = int.Parse(Cbo_FEfectivoAnio.SelectedItem?.ToString() ?? throw new Exception("Seleccione un año."));

                    // Asignar los valores al reporte
                    reporte.SetParameterValue("Mes", mesSeleccionado);
                    reporte.SetParameterValue("Anio", anioSeleccionado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la selección de mes/año: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método si hay un error en los combo boxes
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
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
            finally
            {
                // Libera los recursos del reporte
                reporte.Close();
                reporte.Dispose();
            }
        }



        private void btn_Ver_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {

                //string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));
                string sAyudaPath = Path.Combine(sRutaProyecto, "Contabilidad", "EstadosFinancieros", "ReportesEstados", "AyudaEstadosFinancieros.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");

                Help.ShowHelp(this, sAyudaPath, "Htmlayuda.html");
                //Bitacora
                lg.funinsertarabitacora(idUsuario, "Se consulto Ayuda", "Ayuda Estados Financieros", "8000");


            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\"));
                string sAyudaPath = Path.Combine(sRutaProyecto, "Contabilidad", "EstadosFinancieros", "ReportesEstados", "AyudaEstadosFinancieros.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");

                Help.ShowHelp(this, sAyudaPath, "Htmlayuda.html");
                //Bitacora
                lg.funinsertarabitacora(idUsuario, "Se consulto Ayuda", "Ayuda Estados Financieros", "8000");


            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }

        private void EstadosFinancieros_Load(object sender, EventArgs e)
        {
            // Configuración del tooltip
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            // Asignar textos a los botones
            toolTip.SetToolTip(Btn_Ver_Balance, "Ver el balance general");
            toolTip.SetToolTip(Btn_Ver_Flujo, "Ver el flujo de efectivo");
            toolTip.SetToolTip(Btn_Ver_EstadoResultados, "Ver el estado de resultados");
            toolTip.SetToolTip(Btn_Ver_EResultadosHistorico, "Ver el flujo de efectivo histórico");
            toolTip.SetToolTip(Btn_Ver_BalanceHistorico, "Ver el balance histórico");
            toolTip.SetToolTip(Btn_Ver_FEfectivoHistorico, "Ver el flujo de efectivo histórico");
            toolTip.SetToolTip(Btn_Ver_Ayuda, "Ver ayuda");
            toolTip.SetToolTip(Btn_Salir, "Salir del formulario");
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}