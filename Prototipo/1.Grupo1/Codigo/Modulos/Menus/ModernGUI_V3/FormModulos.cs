using Capa_Vista_Seguridad;
using Capa_Controlador_Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Vista_Migracion;


namespace Interfac_V3
{
    public partial class FormModulos : Form
    {
        string idUsuario;
        public FormModulos(string idUsuario)
        {

            InitializeComponent();
            this.idUsuario = idUsuario;
            UsuarioSesion.SetIdUsuario(idUsuario);
        }

        private void FormModulos_Load(object sender, EventArgs e)
        {
            // Configuración inicial si es necesaria
            // Asignar los eventos MouseEnter y MouseLeave explícitamente al botón
            btnSeguridad.MouseEnter += btnSeguridad_MouseEnter;
            btnSeguridad.MouseLeave += btnSeguridad_MouseLeave;

            Btn_Migracion.MouseEnter += Btn_Nominas_MouseEnter;
            Btn_Migracion.MouseLeave += Btn_Nominas_MouseLeave;

            //btnSalir.MouseEnter += btnSalir_MouseEnter;
            //btnSalir.MouseLeave += btnSalir_MouseLeave;

        }

        // Métodos para mover la ventana sin bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            /*Esta parte la habia trabajado ya el compañero Jose Daiel Sierra, sin embargo,no se habian considerado ciertos elementos
              * es decir, no se habia considera la existencia de un solo Login, sino que habia 2, siendo que el compañero modifico el
              * login para que al darle "cancelar" no se terminara la ejecución, y ahora se maneja solo 1, y por ende modifique un poco
              * lo hecho, pero agradezco su trabajo.**/
            logica logica = new logica();

            try
            {
                // Lista de nombres de permisos que corresponden a las acciones posibles.
                string[] arrPermisosText = { "INGRESAR", "BUSCAR", "MODIFICAR", "ELIMINAR", "IMPRIMIR" };

                // Obtener el ID del usuario una sola vez
                string sIdUsuarioX = UsuarioSesion.GetIdUsuario();
                string sIdUsuario1 = logica.ObtenerIdUsuario(sIdUsuarioX);

                bool tieneTodosLosPermisos = true;

                for (int iIndex = 0; iIndex < arrPermisosText.Length; iIndex++)
                {
                    // Verifica si el usuario tiene permiso para la acción correspondiente.
                    bool bTienePermiso = logica.ConsultarPermisos(sIdUsuario1, "1000", iIndex + 1);

                    if (!bTienePermiso)
                    {
                        tieneTodosLosPermisos = false;
                        break; // Si falta un permiso, no es necesario seguir verificando.
                    }
                }

                // Si tiene todos los permisos, muestra el módulo MDI_Seguridad.
                if (tieneTodosLosPermisos)
                {
                    //MDI_Seguridad formMDI = new MDI_Seguridad(UsuarioSesion.GetIdUsuario());
                    //formMDI.Show();
                    //this.Hide(); // Oculta el formulario actual

                    //  MessageBox.Show("Tiene todos los permisos");
                    /***Se agrego aqui lo del compañero Jose Daniel Sierra *****/
                    // Ahora el MDI_Seguriidad se abrirá solamente si se hace login correctamente (Daniel Sierra 0901-21-12750 - 08-02-2025)
                    // Creamos y mostramos el formulario de login
                    //using (frm_login login = new Capa_Vista_Seguridad.frm_login())
                    //{
                    //    // Mostrar el formulario de login y esperar que regrese el resultado
                    //    if (login.ShowDialog() == DialogResult.OK) // Si el login es exitoso
                    //    {
                    //        string idUsuario = login.obtenerNombreUsuario(); // Obtener el usuario logueado

                    //        // Abrir MDI_Seguridad solo si el login fue exitoso
                    //        MDI_Seguridad formMDI = new MDI_Seguridad(idUsuario);
                    //        formMDI.Show();
                    //        this.Hide(); // Ocultar el formulario de inicio
                    //    }
                    //}
                    /**********************************************************/


                    // Abrir MDI_Seguridad solo si el login fue exitoso
                    MDI_Seguridad formMDI = new MDI_Seguridad(idUsuario);
                    formMDI.Show();
                    this.Hide();  // Ocultar el formulario de inicio*/

                }
                else
                {
                    MessageBox.Show("No tienes todos los permisos requeridos para acceder a este módulo.",
                                    "Acceso Denegado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Captura errores y muestra un mensaje en consola
                Console.WriteLine("Error al configurar los botones y permisos: " + ex.Message);
                MessageBox.Show("Ocurrió un error al verificar los permisos. Contacta al administrador.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSeguridad_MouseEnter(object sender, EventArgs e)
        {
            btnSeguridad.BackColor = Color.FromArgb(30, 90, 223);  // Cambia el color de fondo al pasar el cursor
        }
        private void btnSeguridad_MouseLeave(object sender, EventArgs e)
        {
            btnSeguridad.BackColor = Color.FromArgb(240, 240, 240);  // Restaura el color original al quitar el cursor
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Nominas_Click(object sender, EventArgs e)
        {

            /*
            Aqui debe de agregarse la referencia a nominas
            */

            frm_principal_migracion nominas = new frm_principal_migracion(UsuarioSesion.GetIdUsuario());
            nominas.Show();


        }

        private void Btn_Nominas_MouseEnter(object sender, EventArgs e)
        {
            Btn_Migracion.BackColor = Color.FromArgb(130, 165, 248);  // Cambia el color de fondo al pasar el cursor
        }
        private void Btn_Nominas_MouseLeave(object sender, EventArgs e)
        {
            Btn_Migracion.BackColor = Color.FromArgb(240, 240, 240);  // Restaura el color original al quitar el cursor
        }

      
    }
}