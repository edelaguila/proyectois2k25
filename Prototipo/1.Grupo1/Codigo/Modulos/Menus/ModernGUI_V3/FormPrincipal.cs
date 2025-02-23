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

namespace Interfac_V3   
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            ocultaSubMenu();
        }
        private void ocultaSubMenu() 
        {
            if (panelMenuCatalogos.Visible == true)
                panelMenuCatalogos.Visible = false;
            if (panelMenuProcesos.Visible == true)
                panelMenuProcesos.Visible = false;
        }
        private void muestraSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultaSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
        #region Funcionalidades del formulario
        //Metodo para Redimensionar el tamaño del forumulario en tiempo de ejecuciòn
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //Dibujar panel y/o excluir esquina del panel
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //Color y Grip de rectangulo inferior
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar. Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true ;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw,sh);
            this.Location = new Point(lx,ly);
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Metodo para arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void btnMenuCatalogos_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelMenuCatalogos);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Form1>();
            //btnMenuCatalogos.BackColor = Color.FromArgb(12, 61, 92);
            muestraSubMenu(panelMenuCatalogos);
        }

       

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelformularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenuCatalogosOpcion1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form1>();
            btnMenuCatalogosOpcion1.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }
        private void btnMenuCatalogosOpcion2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMenuProcesos_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelMenuProcesos);
        }

        private void btnMenuCatalogosOpcion2_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Form2>();
            btnMenuCatalogosOpcion2.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void btnMenuProcesosOpcion1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form3>();
            btnMenuCatalogosOpcion2.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        //Metodo para abrir formularios dentro de panel contenedor
        private void AbrirFormulario<MiForm>() where MiForm : Form, new() {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                //Descomentar si se quiere las formas hijas sin controles automaticos de cerrar, minimizar, etc
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms );
            }
            //si el formulario/instancia existe
            else {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender,FormClosedEventArgs e) {
            if (Application.OpenForms["Form1"] == null)
                btnMenuCatalogosOpcion1.BackColor = Color.FromArgb(4, 41, 68);            
        }
    }
}
