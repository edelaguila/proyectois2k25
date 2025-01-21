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
using System.Data.Odbc;
using System.Security.Cryptography;

using System.IO; // Necesario para Directory, File, Path y SearchOption

namespace Capa_Vista_Seguridad
{
    public partial class frm_cambioclave : Form
    {
        logica logica1;

        string usuario;
        public frm_cambioclave(string idUsuario)
        {
            InitializeComponent();
            logica1 = new logica(idUsuario);
            usuario = idUsuario;
        }


        public frm_cambioclave()
        {
        }

        string buscar;

        private void Button1_Click(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            txt_clave.Enabled = false;
            txt_nombres.Enabled = false;
            txt_apellidos.Enabled = false;
            btn_guardar1.Enabled = true;
            txt_nueva_clave.Enabled = true;
            txt_nueva_clave_repetida.Enabled = true;


            buscar = txt_idbuscar.Text.Trim();

            try
            {
                DataTable dtusuario = logica1.buscar(buscar);

                if (dtusuario.ToString() == null)
                {
                    MessageBox.Show("No existe el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    foreach (DataRow dt in dtusuario.Rows)
                    {

                        txt_id.Text = (dt[0].ToString());
                        txt_nombres.Text = (dt[1].ToString());
                        txt_apellidos.Text = (dt[2].ToString());
                        txt_clave.Text = (dt[3].ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }
        }

        string perfil;
        private void Frm_cambioclave_Load(object sender, EventArgs e)
        {
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(btn_guardar1, "Guardar contraseña");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_buscar, "Buscar usuario");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(btn_salir1, "Salir");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(btn_ayuda, "Ayuda");

            // Deshabilitar campos por defecto
            txt_id.Enabled = false;
            txt_clave.Enabled = false;
            txt_nombres.Enabled = false;
            txt_apellidos.Enabled = false;
            txt_nueva_clave.Enabled = false;
            txt_nueva_clave_repetida.Enabled = false;
            btn_guardar1.Enabled = false;
            txt_idbuscar.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            // Orden de tabulaciones
            txt_idbuscar.TabIndex = 0;
            Btn_buscar.TabIndex = 1;
            txt_id.TabIndex = 2;
            txt_clave.TabIndex = 3;
            txt_nombres.TabIndex = 4;
            txt_apellido.TabIndex = 5;
            txt_nueva_clave.TabIndex = 6;
            txt_nueva_clave_repetida.TabIndex = 7;
            btn_guardar1.TabIndex = 8;
            btn_salir1.TabIndex = 9;

            //limitar caracteres
            txt_id.MaxLength = 20; // Limita el texto a 50 caracteres
            txt_id.MaxLength = 50;
            txt_clave.MaxLength = 50;
            txt_nombres.MaxLength = 50;
            txt_nombre.MaxLength = 50;
            txt_apellidos.MaxLength = 50;
            txt_apellido.MaxLength = 50;
            txt_nueva_clave.MaxLength = 50;
            txt_nueva_clave_repetida.MaxLength = 50;

            try
            {
                // Obtener datos de usuario desde la lógica
                DataTable dtusuario = logica1.updateclave(usuario);

                // Verificar si dtusuario es nulo o no tiene filas
                if (dtusuario == null || dtusuario.Rows.Count == 0)
                {
                    return;
                }

                // Extraer el perfil del usuario
                foreach (DataRow dt in dtusuario.Rows)
                {
                    perfil = dt[0].ToString();
                }

                // Controlar la visibilidad de los elementos según el perfil
                if (perfil == "1")
                {
                    Gpb_modificar.Visible = true;
                    Gpb_datospersonales.Visible = true;
                    Gpb_datosusuario.Visible = true;
                    btn_ayuda.Visible = true;

                    Gpb_contraseniausuario.Visible = false;
                    btn_guardar1.Visible = false;
                    btn_salir1.Visible = false;
                }
                else
                {
                    Gpb_modificar.Visible = false;
                    Gpb_datospersonales.Visible = false;
                    Gpb_datosusuario.Visible = false;
                    btn_ayuda.Visible = false;

                    Gpb_contraseniausuario.Visible = true;
                    btn_guardar1.Visible = true;
                    btn_salir1.Visible = true;
                }
            }
            catch (Exception ex)
            {
                // Mostrar el error en la consola para depuración
                Console.WriteLine(ex);
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
            }

        }


        // Código por Brandon Boch - 0901-21-13093//////////////////////////////////////////////
        public string id, nombre, apellido, clave;

        private void Txt_idbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        public string contra, clave1, clave2;

        private void Btn_guardar1_Click(object sender, EventArgs e)
        {
            ProcedimientoLogin cambiarContraModulo = new ProcedimientoLogin();

            // Captura de las contraseñas desde los TextBox
            contra = txt_nueva_clave.Text.Trim();
            clave1 = txt_nueva_clave.Text.Trim();
            clave2 = txt_nueva_clave_repetida.Text.Trim();

            // Verificación de longitud mínima de la contraseña
            if (clave1.Length < 8 || clave2.Length < 8)
            {
                MessageBox.Show("La clave debe ser de al menos 8 caracteres", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Comprobación de coincidencia de las contraseñas
                if (clave1.Equals(clave2))
                {
                    try
                    {
                        // Hashear la nueva contraseña con SHA-256
                        string claveHasheada = HashPasswordSHA256(clave2);

                        // Intentar cambiar la contraseña en la base de datos
                        int id = int.Parse(txt_id.Text);  // Convertir el ID de usuario a entero
                        bool bCambioExitoso = cambiarContraModulo.cambiarContraModulo(id, claveHasheada);  // Llamar al método con la contraseña hasheada
                        
                        // Comprobar si el cambio fue exitoso
                        if (bCambioExitoso)
                        {
                            MessageBox.Show("Se cambió la contraseña exitosamente", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           // sn.insertarBitacora(usuario, "Se cambio contraseña ", "tbl_usuarios");
                            LimpiarTextBox();
                            txt_nueva_clave_repetida.Enabled = false;
                            txt_nueva_clave.Enabled = false;
                            btn_guardar1.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo cambiar la contraseña", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (FormatException)
                    {
                        // Manejar error si el ID no es un número válido
                        MessageBox.Show("El ID del usuario debe ser un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        // Mostrar cualquier otro error ocurrido
                        Console.WriteLine(ex);
                        MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las Contraseñas no coinciden", "Error de coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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


        private void LimpiarTextBox()
        {
            txt_id.Clear();
            txt_nueva_clave.Clear();
            txt_nueva_clave_repetida.Clear();
            txt_clave.Clear();
            txt_apellidos.Clear();
            txt_nombres.Clear();
            txt_idbuscar.Clear();
        }
        // Fin de código de Brandon Boch - 0901-21-13093 ///////////////////////////////

        private void Btn_salir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_claves_TextChanged(object sender, EventArgs e)
        {

        }
        //**********************GABRIELA SUC Y KATERYN DE LEON ******************************
        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            // Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "CambioContraseña.chm", "cambio_contraseña.html");
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
            string pathAyuda = FindFileInDirectory(ayudaFolderPath, "frmCambioClave.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(pathAyuda))
            {
               
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, pathAyuda, "cambio_clave.html");
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
        //************* Fin KATERYN DE LEON y Gabriela Suc ************************

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Fernando García 0901-21-581
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es un número o si es la tecla de Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número o la tecla de retroceso, cancelar el evento
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es una letra o una tecla de control como backspace
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Si no es una letra, espacio o tecla de control, cancela el evento
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
