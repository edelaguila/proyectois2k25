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
using Capa_Vista_Seguridad;
using System.Data.Odbc;
using System.Security.Cryptography;
using Capa_Modelo_Seguridad;

namespace Capa_Vista_Seguridad
{
    // Código realizado por Brandon Boch - 0901-21-13093///////////////////////////////////////////////////////
    public partial class frm_cambio_contrasenia : Form
    {
        public string Resultado { get; private set; }
        public frm_cambio_contrasenia(string pregunta)
        {
            InitializeComponent();
            Txt_usuario.Text = pregunta;
            Txt_contrasenia.UseSystemPasswordChar = true;
            Txt_confirmacion.UseSystemPasswordChar = true;
        }

        private void Btn_verificar_Click(object sender, EventArgs e)
        {
            ProcedimientoLogin cambioContrasenia = new ProcedimientoLogin();

            if (Txt_pregunta.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    bool bExisteUsuario = cambioContrasenia.cambioContrasenia(Txt_pregunta.Text);
                    if (bExisteUsuario)
                    {
                        // Obtener la pregunta de seguridad del usuario
                        string preguntaSeguridad = ObtenerPreguntaSeguridad(Txt_pregunta.Text);

                        if (!string.IsNullOrEmpty(preguntaSeguridad))
                        {
                            // Mostrar la pregunta en el Label
                            Txt_preguntaoriginal.Text = preguntaSeguridad;
                            Txt_preguntaoriginal.Visible = true;

                            // Mostrar los campos para cambiar la contraseña
                            Txt_nuevacontrasenia.Visible = true;
                            Txt_confirmacionusuario.Visible = true;
                            Txt_contrasenia.Visible = true;
                            Txt_confirmacion.Visible = true;
                            Txt_preguntaoriginal.Visible = true;
                            Txt_color.Visible = true;
                            Btn_confirmar.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo obtener la pregunta de seguridad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario incorrecto", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("No se pudo conectar a la base de datos", "Verificar Conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Método para obtener la pregunta de seguridad desde la base de datos
        private string ObtenerPreguntaSeguridad(string nombreUsuario)
        {
            string pregunta = string.Empty;

            // Instancia de tu clase de conexión
            conexion conexion = new conexion();

            try
            {
                // Abrir la conexión dentro del using para asegurar su cierre
                using (OdbcConnection connection = conexion.conectar())
                {
                    string query = "SELECT pregunta FROM tbl_usuarios WHERE username_usuario = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        // Agregar el parámetro sin el `@` para ODBC
                        cmd.Parameters.AddWithValue("@username_usuario", nombreUsuario);

                        // Ejecutar el comando y leer la pregunta
                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                pregunta = reader["pregunta"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la pregunta de seguridad: " + ex.Message);
            }

            return pregunta;
        }

        private void frm_cambio_contrasenia_Load(object sender, EventArgs e)
        {

            Txt_pregunta.Height = 40; // Establece el ancho del TextBox
            Txt_pregunta.Width = 200; // Establece el ancho del TextBox
            Txt_color.Height = 40; // Establece el ancho del TextBox
            Txt_color.Width = 200;

            Txt_nuevacontrasenia.Visible = false;
            Txt_confirmacionusuario.Visible = false;
            Txt_contrasenia.Visible = false;
            Txt_confirmacion.Visible = false;
            Txt_color.Visible = false;
            Btn_confirmar.Visible = false;
            Txt_preguntaoriginal.Visible = false;

            Txt_pregunta.TabIndex = 0;
            Txt_color.TabIndex = 2;
            Btn_verificar.TabIndex = 1;
            Txt_contrasenia.TabIndex = 3;
            Txt_confirmacion.TabIndex = 4;
            Btn_confirmar.TabIndex = 5;
        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            ProcedimientoLogin cambiarContrasenia = new ProcedimientoLogin();

            if (Txt_contrasenia.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Txt_contrasenia.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres", "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Txt_confirmacion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la confirmación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Txt_color.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la respuesta a la pregunta de seguridad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Txt_contrasenia.Text.Trim() != Txt_confirmacion.Text.Trim())
            {
                MessageBox.Show("Las contraseñas no coinciden", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Mensaje de confirmación
                DialogResult confirmResult = MessageBox.Show("¿Está seguro de que desea modificar la contraseña?", "Confirmar cambio de contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Hashear la nueva contraseña ingresada con SHA-256
                        string claveHasheada = HashPasswordSHA256(Txt_confirmacion.Text.Trim());

                        // Obtener la respuesta ingresada
                        string respuestaIngresada = Txt_color.Text.Trim();

                        // Pasar la contraseña hasheada y la respuesta ingresada al método cambiarContrasenia
                        bool bCambioExitoso = cambiarContrasenia.cambiarContrasenia(Txt_pregunta.Text, claveHasheada, respuestaIngresada);

                        if (bCambioExitoso)
                        {
                            MessageBox.Show("Se cambió la contraseña exitosamente", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("La respuesta de seguridad es incorrecta o no se pudo cambiar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Si el usuario selecciona "No", simplemente no pasa nada
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
    }
}/////////////////////////////////////////////////////////////////////////////////////////////////////////////
