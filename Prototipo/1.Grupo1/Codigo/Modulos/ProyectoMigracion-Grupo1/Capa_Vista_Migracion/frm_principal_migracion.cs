using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Odbc;
using Capa_Controlador_Migracion;

namespace Capa_Vista_Migracion
{

    public partial class frm_principal_migracion : Form
    {

        

        string idUsuario;
        Controlador cn = new Controlador();
        public frm_principal_migracion(String idUsuario)
        {
            this.idUsuario = idUsuario;
            InitializeComponent();
            PersonalizarDiseño();


            //this.WindowState = FormWindowState.Maximized; // Maximiza el formulario al iniciar
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            /* Btn_maximizar.Visible = false;
             Btn_restaurar.Visible = true;*/
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void PersonalizarDiseño()
        {
            pnl_SubmenuMantenimientos.Visible = false;
            pnl_Generacionpasaporte.Visible = false;
            pnl_Generacionpasaportemenor.Visible = false;
        }

        private void OcualtarSubmenu()
        {
            if (pnl_SubmenuMantenimientos.Visible == true)
                pnl_SubmenuMantenimientos.Visible = false;
            if (pnl_Generacionpasaporte.Visible == true)
                pnl_Generacionpasaporte.Visible = false;
            if (pnl_Generacionpasaportemenor.Visible == true)
                pnl_Generacionpasaportemenor.Visible = false;

        }

        private void MostrarSubmenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                OcualtarSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
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
            this.Pnl_Formulario.Region = region;
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




        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int lx, ly;
        int sw, sh;

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



  

     
        private void btn_Mantenimientos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pnl_SubmenuMantenimientos);
        }

        private void btn_Usuario_Click_1(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            
            OcualtarSubmenu();
        }

        private void btn_Pago_Click_1(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            AbrirFormulario<frm_pago>();
            OcualtarSubmenu();
        }

        private void btn_Citas_Click(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            AbrirFormulario<frm_oficina>();

            OcualtarSubmenu();
        }

        private void btn_GeneracionPasaporte_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pnl_Generacionpasaporte);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            OcualtarSubmenu();
        }

        private void btn_Renovacion_Click(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            OcualtarSubmenu();
        }

        private void btn_GeneracionPasaporteMenor_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pnl_Generacionpasaportemenor);
        }

        private void btn_NuevoMenor_Click(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            OcualtarSubmenu();
        }

        private void btn_RenovacionMenor_Click(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            OcualtarSubmenu();
        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            //Codigo para mostrar otro formulario
            AbrirFormulario<frm_empleado>();

            OcualtarSubmenu();
        }

        private void btn_Nacionalidad_Click(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            AbrirFormulario<frm_nacionalidad>();
            OcualtarSubmenu();
        }

        private void btn_Usuario_Click(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            //Codigo para mostrar otro formulario
            AbrirFormulario<Frm_usuario>();
            OcualtarSubmenu();
        }

        private void btn_Menordeedad_Click(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            AbrirFormulario<frm_menor>();
            OcualtarSubmenu();
        }

        private void btn_Tutorlegal_Click(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            AbrirFormulario<frm_tutor>();
            OcualtarSubmenu();
        }

        private void btn_Cita_Click(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            AbrirFormulario<frm_citas>();
            OcualtarSubmenu();
        }

        private void btn_Citamenor_Click(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            AbrirFormulario<frm_citaMenor>();
            OcualtarSubmenu();
        }

        private void btn_Pago_Click(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            OcualtarSubmenu();
        }

        private void btn_Generaciondepasaporte_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pnl_Generacionpasaporte);
        }

        private void btn_Generaciondepasaportemenor_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pnl_Generacionpasaportemenor);
        }

        private void btn_Nuevo_Click_1(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            OcualtarSubmenu();
        }

        private void btn_Renovacion_Click_1(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            OcualtarSubmenu();
        }

        private void btn_Nuevomenor_Click_1(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            OcualtarSubmenu();
        }

        private void btn_Renovacionmenor_Click_1(object sender, EventArgs e)
        {
            //Codigo para mostrar otro formulario
            OcualtarSubmenu();
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = Pnl_Formulario.Controls.OfType<MiForm>().FirstOrDefault(); // Busca en la colección el formulario

            // Si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;

                // Ajusta el formulario hijo al panel contenedor
                formulario.Dock = DockStyle.Fill; // Hace que el formulario se ajuste al tamaño del panel

                Pnl_Formulario.Controls.Add(formulario);
                Pnl_Formulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] == null)
                btn_Salir.BackColor = Color.FromArgb(4, 41, 68);
        }

    }
}
#endregion