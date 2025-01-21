using Capa_Vista_Seguridad;
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
using Capa_Vista_Nominas;    

using Capa_Vista_Banco;      
using Capa_Vista_Contabilidad; 
//using Capa_Vista_Produccion;
//using Capa_Vista_Banco;
using Capa_Vista_CompraVenta;


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

        }
        //Metodo para arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            var usuario = new Capa_Vista_Seguridad.frm_login();
            string idUsuario = usuario.Txt_usuario.ToString();

            frm_login login = new frm_login();
            login.ShowDialog();

            MDI_Seguridad formMDI = new MDI_Seguridad(idUsuario);
            formMDI.Show();
            this.Hide();
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

            frm_principal_nominas nominas = new frm_principal_nominas(UsuarioSesion.GetIdUsuario());
            nominas.Show();


        }

        private void Btn_Logistica_Click(object sender, EventArgs e)
        {
            Capa_Vista_Logistica.FormPrincipal logistica = new Capa_Vista_Logistica.FormPrincipal(UsuarioSesion.GetIdUsuario());
            logistica.Show();
        }

        private void Btn_Contabilidad_Click(object sender, EventArgs e)
        {
            Contabilidad_MDI conta = new Contabilidad_MDI(UsuarioSesion.GetIdUsuario());
            conta.Show();
        }

        private void Btn_Compras_Click(object sender, EventArgs e)
        {
            Frm_MDI_general_CompraVenta Cv = new Frm_MDI_general_CompraVenta(UsuarioSesion.GetIdUsuario());
            Cv.Show();

        }

        private void Btn_Bancos_Click(object sender, EventArgs e)
        {
            // Redirige a Modulo Bancos
            frm_principal_bancos banco = new frm_principal_bancos(UsuarioSesion.GetIdUsuario());
            banco.Show();

        }

        private void Btn_Produccion_Click(object sender, EventArgs e)
        {
            /*MDI_Produccion produccion = new MDI_Produccion(UsuarioSesion.GetIdUsuario());
            produccion.Show();*/
        }

        private void Btn_CuentasCorrientes_Click(object sender, EventArgs e)
        {
            //Capa_Vista_Cuentas_Corrientes.FormPrincipal cc = new Capa_Vista_Cuentas_Corrientes.FormPrincipal(UsuarioSesion.GetIdUsuario());
            //cc.Show();
        }
    }
}