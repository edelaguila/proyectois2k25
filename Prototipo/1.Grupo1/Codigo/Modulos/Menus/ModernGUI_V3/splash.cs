using Capa_Vista_Seguridad;  
using System;
using System.Windows.Forms;
//Comentado por George Mayén 25/02/2023
namespace Interfac_V3   
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        //Método quemuestra una barra con su porcentaje y cuando llega al máximo que es un 100% muestra el formulario de login
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            label1.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();

                frm_login login = new frm_login();
               login.ShowDialog();


                //FormModulos b = new FormModulos();
                //b.Show();
                ////b.ShowDialog();
            }
        }
    }
}
