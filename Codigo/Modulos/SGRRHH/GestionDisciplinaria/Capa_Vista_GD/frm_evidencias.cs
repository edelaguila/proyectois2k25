using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_GD;
using System.IO;

namespace Capa_Vista_GD
{
    public partial class frm_evidencias : Form
    {
        Controlador Ctrl;

        public frm_evidencias(string sidUsuario)
        {
            InitializeComponent();
            Ctrl = new Controlador(sidUsuario);

            Btn_Guardar.Enabled = false;
            Btn_Editar.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Cbo_idFalta.Enabled = false;
            Cbo_tipoEvindencia.Enabled = false;
            Txt_cargarArchivo.Enabled = false;
            Rdb_Si.Enabled = false;
            Rdb_no.Enabled = false;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cbo_idFalta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frm_evidencias_Load(object sender, EventArgs e)
        {
            //combobox que carga las faltas que ya se han creado en el mantenimiento de registro disciplinario
            CargarFaltas();

            //Listado de tipos de evidencias que se cargan en el combobox al iniciar el formulario
            List<string> tiposDeEvidenciasDisciplinarias = new List<string>
            {
                "Ninguna",
                "Fotografía",
                "Video",
                "Captura de pantalla",
                "Correo electrónico relevante",
                "Informe del supervisor",
                "Declaración de testigo",
                "Acta administrativa",
                "Copia de citatorio",
                "Bitácora de incidencias",
                "Documentos firmados (avisos, sanciones previas)",
                "Reporte de Recursos Humanos",
                "Registro de acceso (entradas y salidas)",
                "Grabación de llamada",
                "Informe de seguridad interna",
                "Constancia de capacitación",
                "Resultados de alcoholemia o antidoping",
                "Acta de comparecencia",
                "Documento de descargo del implicado",
                "Carta de queja (interna o externa)",
                "Evaluación de desempeño",
                "Informe de daños a bienes",
                "Registro de sanciones anteriores",
                "Análisis forense digital (en caso de uso indebido de sistemas)",
                "Notas médicas (en caso de lesiones)",
                "Informe policial",
                "Registro biométrico (huella, tarjeta, etc.)",
                "Captura de geolocalización (GPS)",
                "Chats de mensajería interna",
                "Videos de testigos",
                "Audio de entrevistas",
                "Evidencias en redes sociales",
                "Grabaciones de cámaras",
                "Reporte de vigilancia",
                "Orden de trabajo",
                "Informe de comité disciplinario"
            };

            Cbo_tipoEvindencia.DataSource = tiposDeEvidenciasDisciplinarias;
            Cbo_tipoEvindencia.SelectedIndex = 0;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (Cbo_idFalta.SelectedIndex == -1 || Cbo_tipoEvindencia.SelectedIndex == -1 || string.IsNullOrWhiteSpace(Txt_cargarArchivo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            if (!Rdb_Si.Checked && !Rdb_no.Checked)
            {
                MessageBox.Show("Debe seleccionar si la evidencia es válida o no.");
                return;
            }

            // Recolectar datos del formulario
            int idFalta = Convert.ToInt32(Cbo_idFalta.SelectedItem);
            string tipoEvidencia = Cbo_tipoEvindencia.SelectedItem.ToString();
            string urlEvidencia = Txt_cargarArchivo.Text;
            int estado = Rdb_Si.Checked ? 1 : 0; // <--- Aquí obtenemos el estado basado en los RadioButtons

            try
            {
                Ctrl.funInsertarEvidencia(idFalta, tipoEvidencia, urlEvidencia, estado);
                MessageBox.Show("Evidencia guardada exitosamente");

                // Opcional: Limpiar formulario
                Cbo_idFalta.SelectedIndex = -1;
                Cbo_tipoEvindencia.SelectedIndex = 0;
                Txt_cargarArchivo.Clear();
                Rdb_Si.Checked = false;
                Rdb_no.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la evidencia: " + ex.Message);
            }

            limpiar();
            Btn_Cancelar.Enabled = false;
            Btn_Nuevo.Enabled = true;
        }

        private void Txt_cargarArchivo_TextChanged(object sender, EventArgs e)
        {
            string texto = Txt_cargarArchivo.Text.Trim().ToLower();

            // Validar que no esté vacío ni contenga "ninguna" o "ninguno"
            if (!string.IsNullOrEmpty(texto) && texto != "ninguna" && texto != "ninguno" && texto != "Ninguna" && texto != "Ninguno")
            {
                Rdb_Si.Checked = true;
            }
            else
            {
                // No marcar automáticamente "Sí"
                Rdb_Si.Checked = false;
            }

            CambiarColorFondo();
            ValidarRadioButtonSi(); // Llamamos a la validación cada vez que se cambia el texto del TextBox
        }

        private void Rdb_no_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_no.Checked)
            {
                // Deshabilitar los controles cuando "No" está seleccionado
                Cbo_tipoEvindencia.Enabled = false;  // Deshabilitar ComboBox de tipo de evidencia
                Cbo_idFalta.Enabled = false;        // Deshabilitar ComboBox de ID de falta
                Txt_cargarArchivo.Enabled = false;  // Deshabilitar TextBox de cargar archivo

                // Rellenar los valores automáticamente para indicar "Ninguna"
                Txt_cargarArchivo.Text = "Ninguna";
                if (Cbo_tipoEvindencia.Items.Count > 0)
                    Cbo_tipoEvindencia.SelectedIndex = 0; // Selecciona "Ninguna"
            }
            else
            {
                // Habilitar los controles cuando "No" NO está seleccionado
                Cbo_tipoEvindencia.Enabled = true;   // Habilitar ComboBox de tipo de evidencia
                Cbo_idFalta.Enabled = true;         // Habilitar ComboBox de ID de falta
                Txt_cargarArchivo.Enabled = true;   // Habilitar TextBox de cargar archivo
            }
            CambiarColorFondo();
            ValidarBotonGuardar(); // Verifica el estado del botón al cambiar "No"
        }

        private void CambiarColorFondo()
        {
            if (Rdb_Si.Checked)
            {
                this.BackColor = Color.LightGreen; // Fondo verde claro si es "Sí"
            }
            else if (Rdb_no.Checked)
            {
                this.BackColor = Color.LightCoral; // Fondo rojo claro si es "No"
            }
            else
            {
                // Restaurar el color original de fondo del formulario (RGB: 180, 210, 240)
                this.BackColor = Color.FromArgb(180, 210, 240); // Fondo original
            }
        }

        private void ValidarRadioButtonSi()
        {
            // Definir las palabras prohibidas que no deben aparecer en el TextBox
            List<string> palabrasProhibidas = new List<string> { "Ninguna", "Ninguno", "ninguna", "ninguno" };

            // Verificamos si el ComboBox de tipo de evidencia no está en "Ninguna" y si el TextBox de cargar archivo no está vacío
            if (Cbo_tipoEvindencia.SelectedIndex != 0 && !palabrasProhibidas.Any(p => Txt_cargarArchivo.Text.Contains(p)))
            {
                Rdb_Si.Enabled = true; // Habilitamos el RadioButton de "Sí"
            }
            else
            {
                Rdb_Si.Enabled = false; // Deshabilitamos el RadioButton de "Sí"
            }
        }

        private void Cbo_tipoEvindencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarRadioButtonSi(); // Llamamos a la validación cada vez que se cambia el tipo de evidencia
        }

        private void ValidarBotonGuardar()
        {
            // Si el radioButton "Sí" está seleccionado o el radioButton "No" está seleccionado
            if (Rdb_Si.Enabled || Rdb_no.Checked)
            {
                Btn_Guardar.Enabled = true; // Habilitar el botón de guardar
            }
            else
            {
                Btn_Guardar.Enabled = false; // Deshabilitar el botón de guardar
            }
        }

        private void Rdb_Si_CheckedChanged(object sender, EventArgs e)
        {
            ValidarBotonGuardar(); // Verifica el estado del botón al cambiar "Sí"
        }

        // Declarar el ToolTip en el boton cancelar
        private ToolTip toolTip = new ToolTip();

        private void limpiar()
        {
            Cbo_idFalta.SelectedIndex = -1;
            Cbo_tipoEvindencia.SelectedIndex = -1;
            Txt_cargarArchivo.Clear();

            Cbo_tipoEvindencia.Enabled = true;
            Cbo_idFalta.Enabled = true;
            Txt_cargarArchivo.Enabled = true;

            Rdb_Si.Checked = false;
            Rdb_no.Checked = false;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            // Mostrar el ToolTip en el boton limpiar
            toolTip.SetToolTip(Btn_Cancelar, "Boton cancelar ");
            limpiar();
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

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Btn_Nuevo.Enabled = false;
            Btn_Guardar.Enabled = true;
            Btn_Cancelar.Enabled = true;
            Cbo_idFalta.Enabled = true;
            Cbo_tipoEvindencia.Enabled = true;
            Txt_cargarArchivo.Enabled = true;
            Rdb_Si.Enabled = true;
            Rdb_no.Enabled = true;
            Btn_Buscar.Enabled = false;
        }

    }
}
