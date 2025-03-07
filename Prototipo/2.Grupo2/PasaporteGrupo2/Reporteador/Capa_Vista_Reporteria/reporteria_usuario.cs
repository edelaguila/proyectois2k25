using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_Vista_Reporteria
{
    public partial class reporteria_usuario : Form
    {
        Capa_Controlador_Reporteria.Controlador controlador = new Capa_Controlador_Reporteria.Controlador();
        String sEstado = "";

        public reporteria_usuario()
        {
            InitializeComponent();
            actualizarVistaReportes();
        }

        private void actualizarVistaReportes()
        {
            //mostramos todos los reportes que hay en la base de datos y la desplegamos
            DataTable data = controlador.MostrarReportes();
            Dgv_Regreporteria.DataSource = data;
            Dgv_Regreporteria.Columns[0].HeaderText = "Id";
            Dgv_Regreporteria.Columns[1].HeaderText = "Ruta";
            Dgv_Regreporteria.Columns[2].HeaderText = "Nombre";
            Dgv_Regreporteria.Columns[3].HeaderText = "Aplicación";
            Dgv_Regreporteria.Columns[4].HeaderText = "Estado";
            Dgv_Regreporteria.Columns[5].HeaderText = "Módulo";
        }

        private void reporteria_usuario_Load(object sender, EventArgs e)
        {

        }

        private void tabla_registro_DoubleClick(object sender, EventArgs e)
        {
            //se habilita la función de modificar y eliminar para el reporte seleccionado 
            if (Dgv_Regreporteria.CurrentRow.Index != -1)
            {
                Txt_nombre.Text = Dgv_Regreporteria.CurrentRow.Cells[2].Value.ToString();
                Txt_ruta.Text = Dgv_Regreporteria.CurrentRow.Cells[1].Value.ToString();
                sEstado = Dgv_Regreporteria.CurrentRow.Cells[4].Value.ToString();

                if (sEstado.Equals("Visible"))
                {
                    Btn_VerReporte.Enabled = true;
                }
                else
                {
                    Btn_VerReporte.Enabled = false;
                }
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            //mostramos todos los reportes que hay en la base de datos según lo introducido en el textbox y la desplegamos
            DataTable data = controlador.queryReporteria(Txt_nombre);
            Dgv_Regreporteria.DataSource = data;
        }

        private async void Btn_VerReporte_Click(object sender, EventArgs e)
        {
            // Realizado por: Cristyan Emilio Lorenzana Hernández - 0901-21-12546
            //si el reporte tiene estado visible entonces se ejecuta otra forma para mostrar el reporte
            if (sEstado.Equals("Visible"))
            {
                string sRuta = Txt_ruta.Text;

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
                MessageBox.Show("No esta habilitado el reporte");
            }
        }
    }
}
