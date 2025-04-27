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
//using Capa_Vista_Nominas;

//using Capa_Vista_Banco;
using Capa_Vista_Contabilidad;
//using Capa_Vista_Produccion;
//using Capa_Vista_Banco;
using Capa_Vista_CompraVenta;
//using Capa_Vista_Carrera;


using Capa_Vista_RRHH;

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

            Btn_Nominas.MouseEnter += Btn_Nominas_MouseEnter;
            Btn_Nominas.MouseLeave += Btn_Nominas_MouseLeave;
            Btn_Logistica.MouseEnter += Btn_Logistica_MouseEnter;
            Btn_Logistica.MouseLeave += Btn_Logistica_MouseLeave;
            Btn_Contabilidad.MouseEnter += Btn_Contabilidad_MouseEnter;
            Btn_Contabilidad.MouseLeave += Btn_Contabilidad_MouseLeave;
            Btn_Compras.MouseEnter += Btn_Compras_MouseEnter;
            Btn_Compras.MouseLeave += Btn_Compras_MouseLeave;
            Btn_Bancos.MouseEnter += Btn_Bancos_MouseEnter;
            Btn_Bancos.MouseLeave += Btn_Bancos_MouseLeave;
            Btn_Produccion.MouseEnter += Btn_Produccion_MouseEnter;
            Btn_Produccion.MouseLeave += Btn_Produccion_MouseLeave;
            Btn_CuentasCorrientes.MouseEnter += Btn_CuentasCorrientes_MouseEnter;
            Btn_CuentasCorrientes.MouseLeave += Btn_CuentasCorrientes_MouseLeave;

            Btn_Empresa.MouseEnter += Btn_Empresa_MouseEnter;
            Btn_Empresa.MouseLeave += Btn_Empresa_MouseLeave;
            btnSalir.MouseEnter += btnSalir_MouseEnter;
            btnSalir.MouseLeave += btnSalir_MouseLeave;

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
                    this.Hide(); // Ocultar el formulario de inicio*/

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

            //frm_principal_nominas nominas = new frm_principal_nominas(UsuarioSesion.GetIdUsuario());
            //nominas.Show();

            //frm_Promociones promociones = new frm_Promociones(UsuarioSesion.GetIdUsuario());
            // promociones.Show();

            MDI_RRHH Recursos = new MDI_RRHH(UsuarioSesion.GetIdUsuario());
            Recursos.Show();


        }

        private void Btn_Nominas_MouseEnter(object sender, EventArgs e)
        {
            Btn_Nominas.BackColor = Color.FromArgb(130, 165, 248);  // Cambia el color de fondo al pasar el cursor
        }
        private void Btn_Nominas_MouseLeave(object sender, EventArgs e)
        {
            Btn_Nominas.BackColor = Color.FromArgb(240, 240, 240);  // Restaura el color original al quitar el cursor
        }

        private void Btn_Logistica_Click(object sender, EventArgs e)
        {
            Capa_Vista_Logistica.FormPrincipal logistica = new Capa_Vista_Logistica.FormPrincipal(UsuarioSesion.GetIdUsuario());
            logistica.Show();
        }

        private void Btn_Logistica_MouseEnter(object sender, EventArgs e)
        {
            Btn_Logistica.BackColor = Color.FromArgb(50, 105, 228);  // Cambia el color de fondo al pasar el cursor
        }
        private void Btn_Logistica_MouseLeave(object sender, EventArgs e)
        {
            Btn_Logistica.BackColor = Color.FromArgb(240, 240, 240);  // Restaura el color original al quitar el cursor
        }

        private void Btn_Contabilidad_Click(object sender, EventArgs e)
        {
            Contabilidad_MDI conta = new Contabilidad_MDI(UsuarioSesion.GetIdUsuario());
            conta.Show();
        }

        private void Btn_Contabilidad_MouseEnter(object sender, EventArgs e)
        {
            Btn_Contabilidad.BackColor = Color.FromArgb(70, 120, 233);  // Cambia el color de fondo al pasar el cursor
        }
        private void Btn_Contabilidad_MouseLeave(object sender, EventArgs e)
        {
            Btn_Contabilidad.BackColor = Color.FromArgb(240, 240, 240);  // Restaura el color original al quitar el cursor
        }

        private void Btn_Compras_Click(object sender, EventArgs e)
        {
            //Frm_MDI_general_CompraVenta Cv = new Frm_MDI_general_CompraVenta(UsuarioSesion.GetIdUsuario());
            //Cv.Show();

        }

        private void Btn_Compras_MouseEnter(object sender, EventArgs e)
        {
            Btn_Compras.BackColor = Color.FromArgb(90, 135, 238);  // Cambia el color de fondo al pasar el cursor
        }
        private void Btn_Compras_MouseLeave(object sender, EventArgs e)
        {
            Btn_Compras.BackColor = Color.FromArgb(240, 240, 240);  // Restaura el color original al quitar el cursor
        }

        private void Btn_Bancos_Click(object sender, EventArgs e)
        {
            // Redirige a Modulo Bancos
            //frm_principal_bancos banco = new frm_principal_bancos(UsuarioSesion.GetIdUsuario());
            //banco.Show();

        }

        private void Btn_Bancos_MouseEnter(object sender, EventArgs e)
        {
            Btn_Bancos.BackColor = Color.FromArgb(110, 150, 243);  // Cambia el color de fondo al pasar el cursor
        }
        private void Btn_Bancos_MouseLeave(object sender, EventArgs e)
        {
            Btn_Bancos.BackColor = Color.FromArgb(240, 240, 240);  // Restaura el color original al quitar el cursor
        }

        private void Btn_Produccion_Click(object sender, EventArgs e)
        {
            /*MDI_Produccion produccion = new MDI_Produccion(UsuarioSesion.GetIdUsuario());
            produccion.Show();*/
        }

        private void Btn_Produccion_MouseEnter(object sender, EventArgs e)
        {
            Btn_Produccion.BackColor = Color.FromArgb(150, 180, 253);  // Cambia el color de fondo al pasar el cursor
        }
        private void Btn_Produccion_MouseLeave(object sender, EventArgs e)
        {
            Btn_Produccion.BackColor = Color.FromArgb(240, 240, 240);  // Restaura el color original al quitar el cursor
        }

        private void Btn_CuentasCorrientes_Click(object sender, EventArgs e)
        {
            //Capa_Vista_Cuentas_Corrientes.FormPrincipal cc = new Capa_Vista_Cuentas_Corrientes.FormPrincipal(UsuarioSesion.GetIdUsuario());
            //cc.Show();
        }

        private void Btn_CuentasCorrientes_MouseEnter(object sender, EventArgs e)
        {
            Btn_CuentasCorrientes.BackColor = Color.FromArgb(170, 195, 255);  // Cambia el color de fondo al pasar el cursor
        }
        private void Btn_CuentasCorrientes_MouseLeave(object sender, EventArgs e)
        {
            Btn_CuentasCorrientes.BackColor = Color.FromArgb(240, 240, 240);  // Restaura el color original al quitar el cursor
        }

        //ultimos dos botones
        private void Btn_Empresa_MouseEnter(object sender, EventArgs e)
        {
            Btn_Empresa.BackColor = Color.FromArgb(190, 210, 255);  // Cambia el color de fondo al pasar el cursor
        }
        private void Btn_Empresa_MouseLeave(object sender, EventArgs e)
        {
            Btn_Empresa.BackColor = Color.FromArgb(240, 240, 240);  // Restaura el color original al quitar el cursor
        }


        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(210, 225, 255);  // Cambia el color de fondo al pasar el cursor
        }
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(240, 240, 240);  // Restaura el color original al quitar el cursor
        }
    }
}