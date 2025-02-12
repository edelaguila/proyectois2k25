
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Necesario para Directory, File, Path y SearchOption
using Capa_Controlador_Seguridad;
namespace Capa_Vista_Seguridad
{
    public partial class MDI_Seguridad : Form
    {
        private int childFormNumber = 0;
        string idUsuario;

        public MDI_Seguridad(string idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            lbl_nombreUsuario.Text = idUsuario;
            DateTime fechaHoraActual = DateTime.Now;
            Lbl_fecha.Text = fechaHoraActual.ToString();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        bool ventanaMostrarAsignacionAplicaciones = false;
        frm_asignacion_aplicaciones mostrarAsignacionAplicaciones = new frm_asignacion_aplicaciones();

        private void AsignacionDeAplicacionesAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_asignacion_aplicaciones);
            if (ventanaMostrarAsignacionAplicaciones == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarAsignacionAplicaciones = new frm_asignacion_aplicaciones(idUsuario);
                }

                mostrarAsignacionAplicaciones.MdiParent = this;
                mostrarAsignacionAplicaciones.Show();
                Application.DoEvents();
                ventanaMostrarAsignacionAplicaciones = true;
            }
            else
            {
                mostrarAsignacionAplicaciones.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMostrarPerfilesUsuario = false;
        frm_asignacion_perfiles mostrarUsuariosPerfiles = new frm_asignacion_perfiles();

        private void AsignacionDePerfilesAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_asignacion_perfiles);
            if (ventanaMostrarPerfilesUsuario == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarUsuariosPerfiles = new frm_asignacion_perfiles(idUsuario);
                }

                mostrarUsuariosPerfiles.MdiParent = this;
                mostrarUsuariosPerfiles.Show();
                Application.DoEvents();
                ventanaMostrarPerfilesUsuario = true;
            }
            else
            {
                mostrarUsuariosPerfiles.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMostrarModulos = false;
        frmMantemientoMódulos mostrarModulos = new frmMantemientoMódulos();

        private void ModulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMantemientoMódulos);
            if (ventanaMostrarModulos == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarModulos = new frmMantemientoMódulos(idUsuario);
                }

                mostrarModulos.MdiParent = this;
                mostrarModulos.Show();
                Application.DoEvents();
                ventanaMostrarModulos = true;
            }
            else
            {
                mostrarModulos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMostrarPerfiles = false;
        frm_perfiles_mantenimiento mostrarPerfiles = new frm_perfiles_mantenimiento();

        private void PerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_perfiles_mantenimiento);
            if (ventanaMostrarPerfiles == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarPerfiles = new frm_perfiles_mantenimiento(idUsuario);
                }

                mostrarPerfiles.MdiParent = this;
                mostrarPerfiles.Show();
                Application.DoEvents();
                ventanaMostrarPerfiles = true;
            }
            else
            {
                mostrarPerfiles.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarAplicacion();
        }


        private void CerrarAplicacion()
        {
            logica l = new logica(idUsuario);
            l.funinsertarabitacora(idUsuario, "Cerro sesion en el sistema", "Login", "1301");

            // Crear y mostrar el nuevo login
            frm_login login = new frm_login();
            login.FormClosed += (s, args) =>
            {
                if (login.DialogResult != DialogResult.OK)
                {
                    Application.Exit();
                }
            };

            // Ocultar la ventana actual
            this.Hide();

            // Mostrar el login
            login.Show();

            // Cerrar el MDI_Seguridad
            this.Close();
        }

        bool ventanaMostrarUsuarios = false;
        frm_usuarios mostrarUsuarios = new frm_usuarios();

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_usuarios);
            if (ventanaMostrarUsuarios == false || frmC == null)
            {
                if (frmC == null)
                {
                    MostrarUsuarios = new frm_usuarios(idUsuario);
                }

                MostrarUsuarios.MdiParent = this;
                MostrarUsuarios.Show();
                Application.DoEvents();
                ventanaMostrarUsuarios = true;
            }
            else
            {
                MostrarUsuarios.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMostrarAplicaciones = false;
        frm_aplicaciones mostrarAplicaciones = new frm_aplicaciones();

        private void AplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_aplicaciones);
            if (ventanaMostrarAplicaciones == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarAplicaciones = new frm_aplicaciones(idUsuario);
                }

                mostrarAplicaciones.MdiParent = this;
                mostrarAplicaciones.Show();
                Application.DoEvents();
                ventanaMostrarAplicaciones = true;
            }
            else
            {
                mostrarAplicaciones.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void MDI_Seguridad_Load(object sender, EventArgs e)
        {
        }


        bool ventanaMostrarAplicacionesPerfiles = false;
        frm_asignacion_aplicaciones_perfiles mostrarApliacionesPerfiles = new frm_asignacion_aplicaciones_perfiles();

        private void AsignacionDeAplicacionesAPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_asignacion_aplicaciones_perfiles);
            if (ventanaMostrarAplicacionesPerfiles == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarApliacionesPerfiles = new frm_asignacion_aplicaciones_perfiles(idUsuario);
                }

                mostrarApliacionesPerfiles.MdiParent = this;
                mostrarApliacionesPerfiles.Show();
                Application.DoEvents();
                ventanaMostrarAplicacionesPerfiles = true;
            }
            else
            {
                mostrarApliacionesPerfiles.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMostrarClave = false;
        frm_cambioclave mostrarCambioClave = new frm_cambioclave();

        public frm_usuarios MostrarUsuarios { get => mostrarUsuarios; set => mostrarUsuarios = value; }

        private void CambioContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_cambioclave);
            if (ventanaMostrarClave == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarCambioClave = new frm_cambioclave(idUsuario);
                }

                mostrarCambioClave.MdiParent = this;
                mostrarCambioClave.Show();
                Application.DoEvents();
                ventanaMostrarClave = true;
            }
            else
            {
                mostrarCambioClave.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

      
        private void BitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_mostrar_bitacora mostrar_Bitacora = new frm_mostrar_bitacora(idUsuario);
            mostrar_Bitacora.MdiParent = this;
            mostrar_Bitacora.Show();

        }

        /***************************Ismar Leonel Cortez Sanchez**********************************************/
        /**************************Nuevo Formulario**********************************************************/
        bool ventanaMostrarModulosAplicaciones = false;
        frm_asignacion_modulo_aplicaciones mostrarAplicacionesModulos = new frm_asignacion_modulo_aplicaciones();


        private void asignacionModuloAAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_asignacion_modulo_aplicaciones);
            if (ventanaMostrarModulosAplicaciones == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarAplicacionesModulos = new frm_asignacion_modulo_aplicaciones(idUsuario);
                }

                mostrarAplicacionesModulos.MdiParent = this;
                mostrarAplicacionesModulos.Show();
                Application.DoEvents();
                ventanaMostrarModulosAplicaciones = true;
            }
            else
            {
                mostrarAplicacionesModulos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }


        //------------------------------------------ Inicio: KATERYN DE LEON y Gabriela Suc ------------------------------------------
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Obtener la ruta del directorio del ejecutable
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Retroceder a la carpeta del proyecto
            string projectPath = Path.GetFullPath(Path.Combine(executablePath, @"..\..\"));
            MessageBox.Show("1" + projectPath);

            // Combinar con la ruta fija de "asis22k24proy2\Codigo\Componentes\Seguridad"
            //string basePath = Path.Combine(projectPath, @"asis22k24proy2\Codigo\Componentes\Seguridad");
            //MessageBox.Show("2" + basePath);


            string ayudaFolderPath = Path.Combine(projectPath, "Ayuda_Seguridad");

            // Imprimir la ruta de ayuda para verificar
            //MessageBox.Show("3: " + ayudaFolderPath);

            // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
            string pathAyuda = FindFileInDirectory(ayudaFolderPath, "ayudaMDI_Seguridad.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(pathAyuda))
            {
                MessageBox.Show("El archivo sí está.");
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, pathAyuda, "ayudaMDI_Seguridad_2024.html");
            }
            else
            {
                // Si el archivo no existe, muestra un mensaje de error
                MessageBox.Show("El archivo de ayuda no se encontró.");
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
                            MessageBox.Show("Archivo encontrado: " + file);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            // Asignar el texto que quieras mostrar
      

        }

        private void lbl_nombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }

        //------------------------------------------ Fin KATERYN DE LEON y Gabriela Suc ------------------------------------------


    }
}
