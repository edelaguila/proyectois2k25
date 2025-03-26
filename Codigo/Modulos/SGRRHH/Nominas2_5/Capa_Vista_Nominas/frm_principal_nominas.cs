using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_Vista_Nominas
{
    public partial class frm_principal_nominas : Form
    {
        string idUsuario;
        public frm_principal_nominas(String idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;

            Lbl_usuario2.Text= idUsuario;
            DateTime fechaHoraActual = DateTime.Now;
            Lbl_hora.Text = fechaHoraActual.ToString();

            //this.WindowState = FormWindowState.Maximized; // Maximiza el formulario al iniciar
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
           /* Btn_maximizar.Visible = false;
            Btn_restaurar.Visible = true;*/
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            ocultaSubMenu();
        }
        private void ocultaSubMenu()
        {
            if (Pnl_mantenimientos.Visible == true)
                Pnl_mantenimientos.Visible = false;
            if (Pnl_generacion.Visible == true)
                Pnl_generacion.Visible = false;
            if (Pnl_genproc.Visible == true)
                Pnl_genproc.Visible = false;
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
            this.Pnl_contenedor.Region = region;
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


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Btn_maximizar.Visible = true;
            Btn_restaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Form1>();
            //btnMenuCatalogos.BackColor = Color.FromArgb(12, 61, 92);
            muestraSubMenu(Pnl_mantenimientos);
        }

        private void btnMenuCatalogos_Click(object sender, EventArgs e)
        {
            
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Metodo para arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            Btn_maximizar.Visible = false;
            Btn_restaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios hijos abiertos
            foreach (Form form in Pnl_formularios.Controls.OfType<Form>().ToList())
            {
                form.Close();
            }
            ocultaSubMenu(); // Cerrar los submenús
        }

        private void Btn_mantenimientos_Click(object sender, EventArgs e)
        {
            muestraSubMenu(Pnl_mantenimientos);
        }

        private void Btn_puesto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_puesto>(); // Pasa el idUsuario
            Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void Btn_departamento_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_departamentos>();
            Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void Btn_empleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_empleados>();
            Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void Btn_percepdeduc_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_procesos_percepciones>();
            Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }


        private void Pic_logoformularios_Click(object sender, EventArgs e)
        {

        }

        private void Btn_generacion_Click(object sender, EventArgs e)
        {
            muestraSubMenu(Pnl_generacion);
        }

        private void Btn_horasextra_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_horasextra>(); // Pasa el idUsuario
            Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }


        private void Btn_contrato_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_gencontrato>(); // Pasa el idUsuario
            Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void Btn_planilla_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Capa_Vista_Planilla.Frm_GenPlanilla>(); // Pasa el idUsuario
            //Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            //ocultaSubMenu();
        }

        private void Btn_anticipo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_genanticipo>(); // Pasa el idUsuario
            Btn_planilla.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void Btn_faltas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_genfaltas>(); // Pasa el idUsuario
            Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void Btn_generacionpercep_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Capa_Vista_PercepcionesDeducciones.frm_generacionpercepciones>(); // Pasa el idUsuario
            //Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            //ocultaSubMenu();
        }

        private void Btn_generaciondeduc_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Capa_Vista_PercepcionesDeducciones.frm_generaciondeducciones>(); // Pasa el idUsuario
            //Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            //ocultaSubMenu();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_reportes>(); // Pasa el idUsuario
            Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<frm_liquidacionempleados>(); // Pasa el idUsuario
            Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void Btn_vacaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_vacacionesempleados>(); // Pasa el idUsuario
            Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            ocultaSubMenu();
        }

        private void Btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_generacionproc_Click(object sender, EventArgs e)
        {
            muestraSubMenu(Pnl_genproc);
        }

        private void Btn_procfaltas_Click(object sender, EventArgs e)
        {
            //frm_calculo_faltas falta = new frm_calculo_faltas();
            //falta.Show();
            //ocultaSubMenu();
           
        }

        private void Btn_procanticipos_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Capa_Vista_Anticipos.frm_anticipos>();
            //Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            //ocultaSubMenu(); ;
        }

        private void Btn_procliquidaciones_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Capa_Vista_Liquidaciones.Frm_calcular_liquidacion>();
            //Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            //ocultaSubMenu();
        }

        private void Btn_prochorasextra_Click(object sender, EventArgs e)
        {
            
            //AbrirFormulario<Capa_Vista_HorasExtras.frm_horasextra>(); // Pasa el idUsuario
            //Btn_puesto.BackColor = Color.FromArgb(12, 61, 92);
            //ocultaSubMenu();
        }

        #endregion
        //Metodo para abrir formularios dentro de panel contenedor
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = Pnl_formularios.Controls.OfType<MiForm>().FirstOrDefault(); // Busca en la colección el formulario

            // Si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;

                // Ajusta el formulario hijo al panel contenedor
                formulario.Dock = DockStyle.Fill; // Hace que el formulario se ajuste al tamaño del panel

                Pnl_formularios.Controls.Add(formulario);
                Pnl_formularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }



        //private void AbrirFormulario<T>(string idUsuario) where T : Form
        //{
        //     Usamos reflexión para crear una instancia del formulario con el idUsuario
        //    var formulario = (T)Activator.CreateInstance(typeof(T), idUsuario);
        //    formulario.Show(); // O formulario.ShowDialog();
        //}




        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] == null)
                Btn_puesto.BackColor = Color.FromArgb(4, 41, 68);
        }
    }
}
