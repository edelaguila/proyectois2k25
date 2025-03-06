using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Consulta;
using System.Data.Odbc;
using System.IO;
using static Capa_Controlador_Consulta.consultaControlador;

/*

    Forma creada por Carlos González y Salvador Martínez

 */

namespace Capa_Vista_Consulta
{
    public partial class ConsultaSimple : Form
    {
        consultaControlador csControlador = new consultaControlador();
        private string[] datos;
        public string BD;

        public ConsultaSimple(string Tabla)
        {
            InitializeComponent();
            BD = Tabla;
            //Agregado por sebastian luna
            var tt = new ToolTip();
            tt.SetToolTip(btnCancelar2, "Cancelar");
            tt.SetToolTip(btnConsultar2, "Consultar");
            tt.SetToolTip(btnAyuda, "Ayuda");
            llenarComboOperador(cboOperador);
            csControlador.obtenerColumbasPorTabla(cboCampo, Tabla);
        }

        private void llenarComboOperador(ComboBox comboBox1)
        {
            comboBox1.Items.Add("Seleccionar"); comboBox1.Items.Add("=");
            comboBox1.Items.Add("<"); comboBox1.Items.Add("<="); comboBox1.Items.Add(">");
            comboBox1.Items.Add(">="); comboBox1.Items.Add("LIKE"); comboBox1.Items.Add("NOT LIKE"); comboBox1.SelectedIndex = 0;
        }

        private void ConsultaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar2_Click_1(object sender, EventArgs e)
        {
            /********Codigo original****************************************************/
            try
            {
                //MessageBox.Show("Se presiono");
                datos = new string[] { cboCampo.Text, cboOperador.Text, txtValor.Text };
                DataTable resultados = csControlador.GenerarQuery(datos, BD);
                dgvConsultar2.DataSource = resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /******************************************************************************/
            //try
            //{
            //    // Obtener el nombre real de la columna seleccionada en el ComboBox
            //    var selectedItem = cboCampo.SelectedItem as ComboBoxItem;
            //    if (selectedItem != null)
            //    {
            //        // Usar el nombre real de la columna para evitar errores de sintaxis en MySQL
            //        datos = new string[] { selectedItem.RealColumnName, cboOperador.Text, txtValor.Text };

            //        // Generar la consulta con los valores corregidos
            //        DataTable resultados = csControlador.GenerarQuery(datos, BD);

            //        // Mostrar los resultados en el DataGridView
            //        dgvConsultar2.DataSource = resultados;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Por favor, selecciona un campo válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnCancelar2_Click_1(object sender, EventArgs e)
        {
            datos = new string[0];
            dgvConsultar2.DataSource = null;
            dgvConsultar2.Rows.Clear();
            txtValor.Clear();
            cboCampo.ResetText();
            cboOperador.SelectedIndex = 0;
        }



        //******************************************************* modificado por Kateryn De Leon (16/02/2025)************************************************
        // Declarar el ToolTip en el botón de Ayuda
        private ToolTip toolTipAyuda = new ToolTip();

        private void button1_Click(object sender, EventArgs e)
        {
            // Busca la carpeta raíz del proyecto llamada proyectois2k25 a partir de la ruta del ejecutable.
            // Si encuentra la carpeta, busca el archivo AyudaNavegador.chm dentro de ella y sus subcarpetas.
            //Si el archivo es encontrado, intenta abrirlo usando Help.ShowHelp().Si falla, lo abre directamente con el proceso del sistema.


            // Mostrar el ToolTip en el botón de ayuda
            toolTipAyuda.SetToolTip(btnAyuda, "Documento de ayuda");

            // Obtener la ruta del ejecutable
            string sExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Buscar la carpeta raíz "proyectois2k25" desde el ejecutable
            string sProjectPath = sFindProjectRootDirectory(sExecutablePath, "proyectois2k25");

            if (string.IsNullOrEmpty(sProjectPath))
            {
                MessageBox.Show("❌ ERROR: No se encontró la carpeta 'proyectois2k25'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar el archivo AyudaNavegador.chm en la carpeta raíz y subcarpetas
            string sPathAyuda = sfunFindFileInDirectory(sProjectPath, "ayudaConsultaSimple.chm");

            // Si el archivo fue encontrado, abrirlo
            if (!string.IsNullOrEmpty(sPathAyuda))
            {
                try
                {
                    Help.ShowHelp(null, sPathAyuda); //para abrir archivo si es encontrado 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("⚠️ Error al abrir el archivo con Help.ShowHelp(): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.Process.Start(sPathAyuda);
                }
            }
            else
            {
                MessageBox.Show("❌ ERROR: No se encontró el archivo ayudaConsultaSimple.chm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensaje de error
            }

        }

        /// Busca la carpeta raíz del proyecto "proyectois2k25" comenzando desde una ruta dada
        /// y subiendo niveles en la jerarquía de directorios hasta encontrarla.
        private string sFindProjectRootDirectory(string startPath, string stargetFolder)
        {
            DirectoryInfo dir = new DirectoryInfo(startPath);
            // aca estara subiendo niveles o  la jerarquía de directorios hasta encontrar la carpeta "proyectois2k25"
            while (dir != null)
            {
                if (dir.Name.Equals(stargetFolder, StringComparison.OrdinalIgnoreCase))
                {
                    return dir.FullName; // Retorna la ruta de la carpeta raíz
                }
                dir = dir.Parent; // Subir un nivel en la jerarquía
            }
            return null; // Retorna null si no encuentra la carpeta
        }

        //Busca el archivo (AyudaNavegador.chm) dentro de un directorio y sus subcarpetas.
        private string sfunFindFileInDirectory(string sDirectory, string sFileName)
        {
            try
            {
                if (Directory.Exists(sDirectory))


                {
                    // Buscar todos los archivos .chm dentro de la carpeta y subcarpetas
                    string[] sFiles = Directory.GetFiles(sDirectory, "*.chm", SearchOption.AllDirectories);
                    // Retornar el archivo que coincida con el nombre buscado
                    return sFiles.FirstOrDefault(file => Path.GetFileName(file).Equals(sFileName, StringComparison.OrdinalIgnoreCase));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Error al buscar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // mensaje de error
            }

            return null; //retorna a null
        }

        //  *******************************************Fin Katy*******************************************************************************













    }
}
