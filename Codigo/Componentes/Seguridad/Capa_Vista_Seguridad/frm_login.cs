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
using System.Security.Cryptography;
using System.IO;
using Interfac_V3; // Necesario para Directory, File, Path y SearchOption
//Editado el 29 sep 2024 para evitar el acoplamiento circular

namespace Capa_Vista_Seguridad
{
    public partial class frm_login : Form
    {
        public string bExito = "Pendiente";

        public frm_login()
        {
            InitializeComponent();
            Txt_clave.UseSystemPasswordChar = true;

            // Vincula el evento KeyPress
            Txt_clave.KeyPress += new KeyPressEventHandler(Txt_clave_KeyPress);
            Txt_usuario.KeyPress += new KeyPressEventHandler(Txt_usuario_KeyPress);
        }

        string nombreUsuario = "";
        public string obtenerNombreUsuario()
        {
            nombreUsuario = Txt_usuario.Text;
            return nombreUsuario;
        }

        //Fernando García 0901-21-581 y Brandon Boch 0901-21-13093//


        private void Frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        private void Btn_entrar_Click_1(object sender, EventArgs e)
        {
            ProcedimientoLogin procedimientoLogin = new ProcedimientoLogin();

            if (Txt_usuario.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un usuario");
            }
            else
            {
                if (Txt_clave.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar su contraseña");
                }
                else
                {
                    try
                    {
                        // Hashear la contraseña antes de enviarla al procedimiento
                        string claveHasheada = HashPasswordSHA256(Txt_clave.Text.Trim());

                        bool bExisteUsuario = procedimientoLogin.llamarProcedimiento(Txt_usuario.Text, claveHasheada);

                        if (bExisteUsuario)
                        {
                            // Ocultar el formulario de login en lugar de cerrarlo
                            this.Hide();
 
                            logica l = new logica();
                            l.funinsertarabitacora(Txt_usuario.Text.Trim(), "Se logeo al sistema", "Login", "1000");

                            FormModulos formulario = new FormModulos(Txt_usuario.Text); // Asegúrate de que este es el nombre correcto de la clase                         
                            formulario.Show();


                            //Pasa el nombre de usuario al constructor de MDI_Seguridad
                            //MDI_Seguridad formMDI = new MDI_Seguridad(Txt_usuario.Text);
                            //formMDI.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña Incorrecta", "Verificación de Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        // Método para hashear la contraseña usando SHA-256
        private string HashPasswordSHA256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void Btn_cancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cb_ver_password_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Cb_ver_password.Checked == false)
            {
                Txt_clave.UseSystemPasswordChar = true;
            }
            else
            {
                Txt_clave.UseSystemPasswordChar = false;
            }
        }
        //------------------------------------------ Inicio: KATERYN DE LEON y Gabriela Suc ------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {

            // Obtener la ruta del directorio del ejecutable
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Retroceder a la carpeta del proyecto
            string projectPath = Path.GetFullPath(Path.Combine(executablePath, @"..\..\"));
            

            // Combinar con la ruta fija de "asis22k24proy2\Codigo\Componentes\Seguridad"
            //string basePath = Path.Combine(projectPath, @"asis22k24proy2\Codigo\Componentes\Seguridad");
            //MessageBox.Show("2" + basePath);


            string ayudaFolderPath = Path.Combine(projectPath, "Ayuda_Seguridad");

            // Imprimir la ruta de ayuda para verificar
            //MessageBox.Show("3: " + ayudaFolderPath);

            // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
            string pathAyuda = FindFileInDirectory(ayudaFolderPath, "AyudaLogin.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(pathAyuda))
            {
                
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, pathAyuda, "ayudaLogin_2024.html");
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

        //------------------------------------------ Fin KATERYN DE LEON y Gabriela Suc ------------------------------------------

        private void Btn_olvidocontrasenia_Click_1(object sender, EventArgs e)
        {
            // Mostrar el formulario de entrada con una pregunta
            using (var frm_cambio_contrasenia = new frm_cambio_contrasenia("Por favor, ingresa tu usuario:"))
            {
                if (frm_cambio_contrasenia.ShowDialog() == DialogResult.OK)
                {
                    // Obtener el resultado del formulario
                    string nombre = frm_cambio_contrasenia.Resultado;
                    MessageBox.Show("El nombre ingresado es: " + nombre);
                }
                /*else
                {
                    MessageBox.Show("Entrada cancelada.");
                }*/
            }
        }

        private void Txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Btn_entrar_Click_1(sender, e); // Llama al método de login al presionar Enter
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void Txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Cancela el evento para que el Enter no se procese y no mueva el cursor
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
