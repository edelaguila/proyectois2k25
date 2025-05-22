using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Faltas;
using Capa_Controlador_Seguridad;
using System.IO;

namespace Capa_Vista_Faltas
{
    public partial class frm_calculo_faltas : Form
    {
        private readonly Controlador controlador = new Controlador();
        logica logicaSeg = new logica();
        public string idUsuario { get; set;}
        ToolTip toolTip = new ToolTip();

        

        public frm_calculo_faltas()
        {
            InitializeComponent();
            CargarEmpleados();
            CargarTodasLasFaltas();
            CargarMeses();
            toolTip.SetToolTip(Btn_Ayudas, "Ver ayuda");
            toolTip.SetToolTip(Btn_Reportes, "Generar reporte");
        }

        private void CargarEmpleados()
        {
            try
            {
                DataTable empleados = controlador.ObtenerEmpleados();
                Cbo_Empleados.DataSource = empleados;
                Cbo_Empleados.DisplayMember = "empleados_nombre";
                Cbo_Empleados.ValueMember = "pk_clave";
                Cbo_Empleados.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }

        private void CargarTodasLasFaltas()
        {
            try
            {
                DataTable faltas = controlador.ObtenerTodasLasFaltas();
                Dgv_Faltas.DataSource = faltas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar faltas: " + ex.Message);
            }
        }

        private void CargarMeses()
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            Cbo_Mes.DataSource = meses;
            Cbo_Mes.SelectedIndex = -1;
        }

        private void Btn_Calculo_Falta_Click_1(object sender, EventArgs e)
        {
            if (Cbo_Empleados.SelectedIndex != -1 && Cbo_Mes.SelectedIndex != -1)
            {
                int idEmpleado = Convert.ToInt32(Cbo_Empleados.SelectedValue);
                string mesSeleccionado = Cbo_Mes.SelectedItem.ToString();

                Console.WriteLine($"Empleado seleccionado: {Cbo_Empleados.Text}, ID: {Cbo_Empleados.SelectedValue}");
                Console.WriteLine($"Mes seleccionado: {mesSeleccionado}");

                try
                {
                    // Calcular el descuento
                    decimal descuento = controlador.CalcularDescuentoPorFaltas(idEmpleado, mesSeleccionado);

                    Console.WriteLine($"Descuento calculado: {descuento}");

                    // Mostrar mensaje con el descuento calculado
                    string mensaje = $"Resultados para {Cbo_Empleados.Text} en {mesSeleccionado}:\n\n" +
                                     $"Descuento a aplicar: ${descuento:F2}";

                    MessageBox.Show(mensaje, "Resultado del Cálculo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Guardar el descuento en la base de datos
                    controlador.GuardarDeduccionPorFaltas(idEmpleado, mesSeleccionado);
                    MessageBox.Show("La deducción por faltas se ha guardado correctamente.");
                    Console.WriteLine("Descuento guardado en la base de datos correctamente.");

                    // Actualizar el DataGridView después del cálculo
                    CargarTodasLasFaltas();
                    Console.WriteLine("Total de registros en DataGridView: " + Dgv_Faltas.Rows.Count);

                    logicaSeg.funinsertarabitacora(idUsuario, "se calculo faltas", "tbl_dedu_perp_emp", "6007");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado y un mes.",
                                "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Dgv_Faltas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Cbo_Empleados_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frm_calculo_faltas_Load(object sender, EventArgs e)
        {
        }

        private void Lbl_ControlFaltas_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ayudas_Click(object sender, EventArgs e)
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
                    "Codigo", "Modulos", "Nominas", "Faltas", "Ayudas");

                //  MessageBox.Show("Ruta de búsqueda: " + ayudaFolderPath);

                // Busca el archivo .chm en la carpeta especificada
                string pathAyuda = FindFileInDirectory(ayudaFolderPath, "AyudaFaltas.chm");

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

        private void Btn_Reportes_Click(object sender, EventArgs e)
        {
            frm_reportefaltas formularioReporteFaltas = new frm_reportefaltas();

            // Mostrar el formulario
            formularioReporteFaltas.ShowDialog();
        }
    }
}