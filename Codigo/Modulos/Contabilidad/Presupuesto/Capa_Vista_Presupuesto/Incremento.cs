using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Seguridad;
using System.IO;//Para Ayudas

namespace Capa_Vista_Presupuesto
{
    public partial class Incremento : Form
    {
        public int iDato;
        public bool bIncrementar;
        public bool bAnual;
        public bool bMes;
        public string sMesSelec;
        public string sLlenado;
        public string sIdUsuario { get; set; } //Para Bitacora-------------!!!
        ToolTip toolTip = new ToolTip();
        logica logicaSeg = new logica();
        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));

        public Incremento(string Llenado)//Cambios
        {
            InitializeComponent();
            toolTip.SetToolTip(Btn_Aceptar, "Haz clic para aceptar");
            toolTip.SetToolTip(Btn_cancelar, "Haz clic para cancelar");
            toolTip.SetToolTip(Btn_ayuda, "Haz clic para ver ayuda");
            toolTip.SetToolTip(Txt_incrementoB, "Campo para incrementar/decrementar. Si desea decrementar utilize '-' --> Ejemplo :'-50'");
        }
        private void Incremento_Load(object sender, EventArgs e)
        {
            switch (sLlenado)
            {
                case "Mensual":
                    Chb_anual.Enabled = false;
                    Chb_anual.Visible = false;
                    break;
                case "Anual":
                    Chb_mes.Enabled = false;
                    Chb_mes.Visible = false;
                    Chb_todos.Enabled = false;
                    Chb_todos.Visible = false;
                    Cb_meses.Enabled = false;
                    Cb_meses.Visible = false;
                    break;
            }
            Cb_meses.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si se presiona la tecla de control (para permitir borrar)
            if (char.IsControl(e.KeyChar))
            {
                return; // Permitir la entrada de control (como Backspace)
            }

            // Verifica si el carácter es un dígito
            if (char.IsDigit(e.KeyChar))
            {
                return; // Permitir dígitos
            }

            // Verifica si se presiona el signo negativo
            if (e.KeyChar == '-')
            {
                // Verifica si el texto ya tiene un signo negativo o si no es el primer carácter
                if (Txt_incrementoB.Text.Length > 0 || Txt_incrementoB.Text == "-")
                {
                    e.Handled = true;
                    // Cancelar la entrada del carácter
                }
                return; // Permitir el signo negativo solo si es el primer carácter
            }

            // Si no es un dígito, control o signo negativo, cancelar la entrada
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            logicaSeg.funinsertarabitacora(sIdUsuario, $"Se cancelo operacion", "Incremento", "8000");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Txt_incrementoB.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detenemos la ejecución si el campo está vacío
            }

            if (Txt_incrementoB.Text == "-")
            {
                MessageBox.Show("Por favor, ingresa un valor valido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            iDato = Convert.ToInt32(Txt_incrementoB.Text);
            bIncrementar = Chb_todos.Checked;
            bAnual = Chb_anual.Checked;

            if (!bIncrementar && !bAnual)
            {
                if (Cb_meses.SelectedItem != null)
                {
                    sMesSelec = Cb_meses.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor selecciona una opcion.");
                    return;
                }
            }

            // Establecemos el resultado como Aceptado
            logicaSeg.funinsertarabitacora(sIdUsuario, $"Se acepto operacion", "Incremento", "8000");
            this.DialogResult = DialogResult.OK;
            this.Close(); //Revisar
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb_todos.Checked == true)
            {
                Cb_meses.Enabled = false;
                Chb_mes.Checked = false;
                Chb_anual.Checked = false;
            }
        }

        private void Chb_anual_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb_anual.Checked == true)
            {
                Cb_meses.Enabled = false;
                Chb_mes.Checked = false;
                Chb_todos.Checked = false;
            }
        }

        private void Chb_mes_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb_mes.Checked == true)
            {
                Cb_meses.Enabled = true;
                Chb_anual.Checked = false;
                Chb_todos.Checked = false;
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
                    Help.ShowHelp(null, pathAyuda, "AyudaIncremento.html");
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

        private void Txtbx_incremento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
