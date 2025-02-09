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

namespace Capa_Vista_Seguridad
{
    public partial class frm_loginAlterno : Form
    {
        public string bExito = "Pendiente";
        public frm_loginAlterno()
        {
            InitializeComponent();
            Txt_clave.UseSystemPasswordChar = true;
        }


        private void Btn_entrar_Click(object sender, EventArgs e)
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
                        bool bExisteUsuario = procedimientoLogin.llamarProcedimiento(Txt_usuario.Text, Txt_clave.Text);

                        if (bExisteUsuario)

                        {
                            logica l = new logica();
                            l.funinsertarabitacora(Txt_usuario.Text.Trim(), "Se logeo al sistema", "Login", "1000");
                            MDI_Seguridad seguridad = new MDI_Seguridad(Txt_usuario.Text.Trim());
                            seguridad.Show();
                            seguridad.lbl_nombreUsuario.Text = Txt_usuario.Text;
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña Incorrecta", "Verificacion de Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //hacer en caso de no existe usuario o contrase;a incorrecto
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show("No Conecto La Base de Datos", "Verificar Conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cb_ver_password_CheckedChanged(object sender, EventArgs e)
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

        private void Frm_loginAlterno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "ayudaLogin.chm", "login.html");

        }

        private void frm_loginAlterno_Load(object sender, EventArgs e)
        {

        }
    }
}
