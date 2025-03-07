using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel;
using System.Windows.Forms;


namespace Capa_Vista_Reporteria
{
    public partial class Inicio : Form
    {
        Capa_Controlador_Reporteria.Controlador controlador = new Capa_Controlador_Reporteria.Controlador();
        Boolean bConfirmRuta = true;
        ToolTip Ayuda = new ToolTip();
        public Inicio()
        {
            InitializeComponent();
            actualizarVistaReportes();
            cargarCategorias();
            cargarModulos();
            getId();

            Ayuda.InitialDelay = 1000;
            Ayuda.ReshowDelay = 500;
            Ayuda.ShowAlways = true;
            Ayuda.AutoPopDelay = 5000;
            Ayuda.IsBalloon = true;

            Ayuda.SetToolTip(Btn_Guardar, "Guarda un reporte con todos los datos ingresados al sistema.");
            Ayuda.SetToolTip(Btn_Modificar, "Modifica un reporte con los datos deseados.");
            Ayuda.SetToolTip(Btn_Eliminar, "Elimina un reporte en base al número de identificación");
            Ayuda.SetToolTip(Btn_Actualizar, "Limpia todas las cajas de texto para ingresar nuevos datos.");
            Ayuda.SetToolTip(Btn_VerReporte, "Muestra el reporte seleccionado en CrystalReports para su visualización.");
        }

        private void actualizarVistaReportes()
        {
            DataTable data = controlador.MostrarReportes();
            Dgv_Regreporteria.DataSource = data;
            Dgv_Regreporteria.Columns[0].HeaderText = "Id";
            Dgv_Regreporteria.Columns[1].HeaderText = "Ruta";
            Dgv_Regreporteria.Columns[2].HeaderText = "Nombre";
            Dgv_Regreporteria.Columns[3].HeaderText = "Aplicación";
            Dgv_Regreporteria.Columns[4].HeaderText = "Estado";
            Dgv_Regreporteria.Columns[5].HeaderText = "Módulo";
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }


        void getId()
        {
            Txt_IDReporte.Text = controlador.getNextId();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void Dgv_Regreporteria_DoubleClick(object sender, EventArgs e)
        {
            //se habilita la función de modificar y eliminar para el reporte seleccionado 
            if (Dgv_Regreporteria.CurrentRow.Index != -1)
            {
                Btn_Guardar.Enabled = false;
                Btn_Modificar.Enabled = true;
                Btn_Eliminar.Enabled = true;

                Txt_IDReporte.Text = Dgv_Regreporteria.CurrentRow.Cells[0].Value.ToString();
                Txt_Ruta.Text = Dgv_Regreporteria.CurrentRow.Cells[1].Value.ToString();
                Txt_NombreA.Text = Dgv_Regreporteria.CurrentRow.Cells[2].Value.ToString();
                Cbo_Aplicacion.Text = Dgv_Regreporteria.CurrentRow.Cells[3].Value.ToString();
                Cbo_Estado.Text = Dgv_Regreporteria.CurrentRow.Cells[4].Value.ToString();
            }
        }


        private void cargarCategorias()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_Aplicacion.DataSource = limpiarTexbox;
            List<string> applicationCodes = controlador.listadoAplicaciones();
            Cbo_Aplicacion.DataSource = applicationCodes;
        }

        // Realizado por: José Daniel Sierra Cruz - 0901-21-12740
        private void cargarModulos()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_Modulo.DataSource = limpiarTexbox;
            List<string> moduleCodes = controlador.listadoModulos();
            Cbo_Modulo.DataSource = moduleCodes;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            controlador.guardarReporte(Txt_IDReporte, Txt_Ruta.Text, Txt_NombreA.Text, Cbo_Aplicacion.Text, Cbo_Estado.Text, Cbo_Modulo.Text);
            actualizarVistaReportes();
            bConfirmRuta = true;
            getId();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            //aquí recibimos los nuevos datos en los diferente textbox y se lo mandamos a la función ModReporteria que esta en controlador.cs
            if (bConfirmRuta)
            {
                Txt_Ruta.Text = Txt_Ruta.Text.Replace("\\", "\\\\");
            }
            controlador.ModReporteria(Txt_Ruta.Text, Txt_NombreA.Text, Cbo_Aplicacion.Text, Cbo_Estado.Text, Txt_IDReporte, Cbo_Modulo.Text);
            actualizarVistaReportes();
            getId();
            bConfirmRuta = true;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            controlador.borrar_reporte(Txt_IDReporte);
            actualizarVistaReportes();
            bConfirmRuta = true;
            getId();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            actualizarVistaReportes();
            cargarCategorias();
            getId();

            Btn_Guardar.Enabled = true;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;

            Txt_Ruta.Text = "";
            Txt_NombreA.Text = "";
            Cbo_Aplicacion.SelectedIndex = 0;
            Cbo_Estado.SelectedIndex = 0;
        }

        // Realizado por: Shelly Marysabel Ordoñez Matias - 0901-21-1795
        public async void visualizar(string sRuta)
        {
            if (!string.IsNullOrEmpty(sRuta))
            {
                string sEstado = Convert.ToString(Cbo_Estado.Text);

                // aqui realizamos una comprobación de ver si el reporte esta en estado visible y el usuario lo pueda ver si no esta visible entonces le saldrá un mensaje al usuario
                if (sEstado == "Visible")
                {
                    using (Cargar cargar = new Cargar())
                    {
                        cargar.Show();

                        await Task.Run(() => System.Threading.Thread.Sleep(3000));
                        visualizar ver = new visualizar(sRuta);
                        ver.Show();

                        cargar.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Reporte No_visible");
                }
            }
        }

        private void Btn_VerReporte_Click(object sender, EventArgs e)
        {
            string sRuta = Txt_Ruta.Text;
            visualizar(sRuta);
        }

        private void Btn_Examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Ofd_Reporte = new OpenFileDialog();
            Ofd_Reporte.Filter = "All files (*.*)|*.*";
            if (Ofd_Reporte.ShowDialog() == DialogResult.OK)
            {
                Txt_Ruta.Text = Ofd_Reporte.FileName;
                string[] sSeparatingStrings = { "\\" };
                string sText = Txt_Ruta.Text;
                string[] sWords = sText.Split(sSeparatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string db = "";
                Boolean bRuta = false;
                for (int i = 0; i < sWords.Length; i++)
                {
                    if (bRuta)
                    {
                        if (i < sWords.Length - 1)
                        {
                            db += sWords[i] + '\\' + '\\';
                        }
                        else
                        {
                            db += sWords[i];
                        }
                    }
                    if (sWords[i].Equals("Reportes"))
                    {
                        bRuta = true;
                    }
                }

                if (bRuta == true)
                {
                    Txt_Ruta.Text = db;
                }
                else
                {
                    Txt_Ruta.Clear();
                    MessageBox.Show("El reporte buscado no se encuentra en la carpeta de Reportes, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                bConfirmRuta = false;
            }
        }
    }
}
