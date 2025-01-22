using Capa_Vista_Contabilidad;
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
using Capa_Vista_EstadosFinancieros;
using Capa_Vista_CierreContable;
using Capa_Vista_Presupuesto;
using Capa_Vista_Polizas;
using System.IO;

namespace Capa_Vista_Contabilidad   
{
    public partial class Contabilidad_MDI : Form
    {
        string idUsuario;
        public Contabilidad_MDI(String idUsuario)
        {
            InitializeComponent();
            ocultaSubMenu();

            this.idUsuario = idUsuario;

            //Primera label
            lbl_usuario2.Text = idUsuario;

            Capa_Vista_Polizas.frmPolizas formulario = new Capa_Vista_Polizas.frmPolizas();
            formulario.SetParametro(idUsuario);

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
            if (panelMenuProc.Visible == true)
                panelMenuProc.Visible = false;
            if (panelMenuMant.Visible == true)
                panelMenuMant.Visible = false;
            if (panelMenuPolizasLocales.Visible == true)
                panelMenuPolizasLocales.Visible = false;
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
            muestraSubMenu(panelMenuProc);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelMenuProc);
        }

       

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelformularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenuCatalogosOpcion1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Presupuesto>();
            btnPresupuestos.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }
        private void btnMenuCatalogosOpcion2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMenuProcesos_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelMenuMant);
        }

        private void btnMenuCatalogosOpcion2_Click_1(object sender, EventArgs e)
        {
            //boton cierre por cuenta
        }

        private void btnMenuProcesosOpcion1_Click(object sender, EventArgs e)
        {
            
        }

        /*private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        public string FindFileInDirectory(string directory, string fileName)
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
                            //MessageBox.Show("Archivo encontrado: " + file);
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
                MessageBox.Show("Error al buscar ayuda: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta del directorio del ejecutable
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Retroceder a la carpeta del proyecto
                string projectPath = Path.GetFullPath(Path.Combine(executablePath, @"..\..\"));
                //MessageBox.Show("1" + projectPath);

                // Combinar con la ruta fija de "asis22k24proy2\Codigo\Componentes\Seguridad"
                //string basePath = Path.Combine(projectPath, @"asis22k24proy2\Codigo\Componentes\Seguridad");
                //MessageBox.Show("2" + basePath);


                string ayudaFolderPath = Path.Combine(projectPath, "AyudaConta");

                // Imprimir la ruta de ayuda para verificar
                //MessageBox.Show("3: " + ayudaFolderPath);

                // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
                string pathAyuda = FindFileInDirectory(ayudaFolderPath, "AyudaConta.chm");

                // Verifica si el archivo existe antes de intentar abrirlo
                if (!string.IsNullOrEmpty(pathAyuda))
                {
                    //MessageBox.Show("El archivo sí está.");
                    // Abre el archivo de ayuda .chm en la sección especificada
                    Help.ShowHelp(null, pathAyuda, "AyudaConta.html");
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

        private void btnmTipoPoliza_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Mantenimiento_Tipo_Poliza>();
            btnmTipoPoliza.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void btnmTipoCuenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MantenimientoTipoCuenta>();
            btnmTipoCuenta.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void btnCierreGeneral_Click(object sender, EventArgs e)
        {

        }

        private void btnEstadosFin_Click(object sender, EventArgs e)
        {
            AbrirFormulario<EstadosFinancieros>();
            btnEstadosFin.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void btnPolizasLocales_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelMenuPolizasLocales);
        }

        private void btnmCuenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Mantenimiento_Cuentas>();
            btnmCuenta.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmActivosFijos_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario<Mantenimientoactivofijo>();
            btnmCuenta.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void lbl_usuario_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Mantenimientotipoactivo>();
            btnmCuenta.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<mantenimientomarca>();
            btnmCuenta.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
          
        }

        private void btnmAreaCuenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MantenimientoEncabezadoCuenta>();
            btnmAreaCuenta.BackColor = Color.FromArgb(255, 51, 51);
            ocultaSubMenu();
        }

        private void btnmTipoCuenta_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<MantenimientoTipoCuenta>();
            btnmTipoCuenta.BackColor = Color.FromArgb(255, 51, 51);
            ocultaSubMenu();
        }

        private void btnmCuenta_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Mantenimiento_Cuentas>();
            btnmCuenta.BackColor = Color.FromArgb(255, 51, 51);
            ocultaSubMenu();
        }

        private void btnmTipoPoliza_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Mantenimiento_Tipo_Poliza>();
            btnmTipoPoliza.BackColor = Color.FromArgb(255, 51, 51);
            ocultaSubMenu();
        }

        private void btnmActivosFijos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Mantenimientoactivofijo>();
            btnmAreaCuenta.BackColor = Color.FromArgb(255, 51, 51);
            ocultaSubMenu();
        }

        private void btnmActivoFijo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Mantenimientotipoactivo>();
            btnmAreaCuenta.BackColor = Color.FromArgb(255, 51, 51);
            ocultaSubMenu();
        }

        private void btnmMarca_Click(object sender, EventArgs e)
        {
            AbrirFormulario<mantenimientomarca>();
            btnmMarca.BackColor = Color.FromArgb(255, 51, 51);
            ocultaSubMenu();
        }

        private void btnPresupuestos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Capa_Vista_Presupuesto.Presupuesto>();
            btnPresupuestos.BackColor = Color.FromArgb(255, 51, 51);
            ocultaSubMenu();
        }

        private void BtnCierreCuentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCierre>();
           BtnCierreCuentas.BackColor = Color.FromArgb(255, 51, 51);
           ocultaSubMenu();
        }

        private void btnActivosFijos_Click(object sender, EventArgs e)
        {
            /*AbrirFormulario<Capa_Vista_activosfijos.activos>();
           btnActivosFijos.BackColor = Color.FromArgb(255, 51, 51);
           ocultaSubMenu();*/
        }

        private void btnEstadosFin_Click_1(object sender, EventArgs e)
        {
           AbrirFormulario<Capa_Vista_EstadosFinancieros.EstadosFinancieros>();
           btnEstadosFin.BackColor = Color.FromArgb(255, 51, 51);
           ocultaSubMenu();
        }

        private void btnPolizas_Click(object sender, EventArgs e)
        {
           AbrirFormulario<Capa_Vista_Polizas.frmPolizas>();
           btnPolizas.BackColor = Color.FromArgb(255, 51, 51);
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
                btnPresupuestos.BackColor = Color.FromArgb(4, 41, 68);            
        }
    }
}
