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
using Capa_Controlador_GD;

namespace Capa_Vista_GD
{
    public partial class frm_sanciones : Form
    {
        Controlador Ctrl;
        string idUsuario;
        public frm_sanciones(string idUsuario)
        {
            InitializeComponent();
            Ctrl = new Controlador(idUsuario);

            this.idUsuario = idUsuario;
            lbl_nombreUsuario.Text = idUsuario;
        }

        private void CargarFaltas()
        {
            try
            {
                DataTable dtFaltas = Ctrl.funconsultalogicafaltas();
                Cbo_idFalta.Items.Clear();
                foreach (DataRow row in dtFaltas.Rows)
                {
                    Cbo_idFalta.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar faltas: " + ex.Message);
            }
        }

        private void Lbl_idFalta_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Txt_tipoEvidencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_tipoEvidencia_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_idFalta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //**Para visualizar el reporte**
        public void meAbrirFormulario<T>() where T : Form, new()
        {
            //Form formulario = new T();
            //formulario.Show();
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            // meAbrirFormulario<Frm_visualizar_reporte>();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Declarar el ToolTip en el boton Ayuda
        private ToolTip toolTipAyuda = new ToolTip();

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            // Busca la carpeta raíz del proyecto llamada proyectois2k25 a partir de la ruta del ejecutable.
            // Si encuentra la carpeta, busca el archivo AyudaNavegador.chm dentro de ella y sus subcarpetas.
            //Si el archivo es encontrado, intenta abrirlo usando Help.ShowHelp().Si falla, lo abre directamente con el proceso del sistema.


            // Mostrar el ToolTip en el botón de ayuda
            toolTipAyuda.SetToolTip(Btn_Ayuda, "Documento de ayuda");

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
            string sPathAyuda = sfunFindFileInDirectory(sProjectPath, "AyudaNavegador.chm");//cambiar aca

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
                MessageBox.Show("❌ ERROR: No se encontró el archivo AyudaNavegador.chm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensaje de error
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
        } //  **FIN AYUDA**

        // Declarar el ToolTip en el boton cancelar
        private ToolTip toolTip = new ToolTip();

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            // Mostrar el ToolTip en el boton limpiar
            toolTip.SetToolTip(Btn_Cancelar, "Boton cancelar ");
            Cbo_idFalta.SelectedIndex = -1; 
            Cbo_tipoSancion.SelectedIndex = -1;
            Txt_descripcionSancion.Clear();

            Chk_sancion.Checked = false;
            Dtp_fechaSancion.Value = DateTime.Now;
        }

        private void frm_sanciones_Load(object sender, EventArgs e)
        {
            CargarFaltas();
        }
    }
}
