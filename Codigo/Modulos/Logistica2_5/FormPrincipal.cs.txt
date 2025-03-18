using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Logistica
{
    public partial class FormPrincipal : Form
    {
        // Realizado por: Pedro Alejandro Citalán Herrera - 0901-20-16151
        string idUsuario;
        public FormPrincipal(String idUsuario)
        {
            InitializeComponent();
            ocultaSubMenu();

            this.idUsuario = idUsuario;

            //Primera label
            lbl_usuario2.Text = idUsuario;

            //Segunda label
            DateTime fechaHoraActual = DateTime.Now;
            lbl_fecha2.Text = fechaHoraActual.ToString();

            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            /*Btn_maximizar.Visible = false;
             Btn_restaurar.Visible = true;*/
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
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
            AbrirFormulario<TrasDProductos>();
            ocultaSubMenu();
        }

        private void btnMenuProcesos_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelMenuProcesos);
        }

        private void btnMenuCatalogosOpcion2_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Locales>();
            ocultaSubMenu();
        }

        private void btnMenuProcesosOpcion1_Click(object sender, EventArgs e)
        {
            /*AbrirFormulario<Capa_Vista_AmmyCatun.Transporte>();
            ocultaSubMenu();*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_MenuCatalogosOpcion3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Almacenes>();
            ocultaSubMenu();
        }

        private void Btn_MenuCatalogosOpcion4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MarcaNav>();
            ocultaSubMenu();
        }

        private void Btn_MenuCatalogosOpcion5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<LineaNav>();
            ocultaSubMenu();
        }

        private void Btn_MenuCatalogosOpcion6_Click(object sender, EventArgs e)
        {
            /*AbrirFormulario<Capa_Vista_AmmyCatun.frm_Chofer>();
            ocultaSubMenu();*/
        }

        private void Btn_MenuProcesosOpcion2_Click(object sender, EventArgs e)
        {
            /*AbrirFormulario<Capa_Vista_AmmyCatun.Transporte_Vehiculos>();
            ocultaSubMenu();*/
        }

        private void Btn_MenuProcesosOpcion3_Click(object sender, EventArgs e)
        {
            /*AbrirFormulario<Capa_Vista_MiguelCrisostomo.TrasladoDeProductos>();
            ocultaSubMenu();*/
        }

        private void Btn_MenuProcesosOpcion4_Click(object sender, EventArgs e)
        {
            /*AbrirFormulario<MVC_JavierChamo.Mantenimiento_de_Vehiculos>();
            ocultaSubMenu();*/
        }

        private void Btn_MenuProcesosOpcion5_Click(object sender, EventArgs e)
        {
            /*AbrirFormulario<MVC_JavierChamo.Movimiento_de_Inventario>();
            ocultaSubMenu();*/
        }

        private void Btn_MenuProcesosOpcion6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Capa_Vista_JDSC.MonitoreoAlmacen>();
            ocultaSubMenu();
        }

        private void Btn_MenuProcesosOpcion7_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Polizas>();
            ocultaSubMenu();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta del directorio del ejecutable
                string sexecutablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Retroceder a la carpeta del proyecto
                string sprojectPath = Path.GetFullPath(Path.Combine(sexecutablePath, @"..\..\"));
                //MessageBox.Show("1" + projectPath);


                string sayudaFolderPath = Path.Combine(sprojectPath, "AyudaLogistica");


                // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
                string spathAyuda = FindFileInDirectory(sayudaFolderPath, "AyudaLogistica.chm");

                // Verifica si el archivo existe antes de intentar abrirlo
                if (!string.IsNullOrEmpty(spathAyuda))
                {
                    // Abre el archivo de ayuda .chm en la sección especificada
                    Help.ShowHelp(null, spathAyuda, "AyudaLogistica.html");
                }
                else
                {
                    // Si el archivo no existe, muestra un mensaje de error
                    MessageBox.Show("El archivo de ayuda no se encontró.");
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }

        public string FindFileInDirectory(string sdirectory, string sfileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(sdirectory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(sdirectory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in files)
                    {
                        if (Path.GetFileName(file).Equals(sfileName, StringComparison.OrdinalIgnoreCase))
                        {
                            //MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la carpeta: " + sdirectory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar ayuda: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
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
                Btn_MenuCatalogosOpcion1.BackColor = Color.FromArgb(4, 41, 68);            
        }
    }
}
