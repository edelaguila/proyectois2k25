using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Consulta;
using System.Data.Odbc;
using System.IO;

/*

    Forma creada por Carlos González y Salvador Martínez

 */

namespace Capa_Vista_Consulta
{
    public partial class ConsultaSimple : Form
    {
        consultaControlador csControlador = new consultaControlador();
        private string[] datos;
        public string BD;

        public ConsultaSimple(string Tabla)
        {
            InitializeComponent();
            BD = Tabla;
            //Agregado por sebastian luna
            var tt = new ToolTip();
            tt.SetToolTip(btnCancelar2, "Cancelar");
            tt.SetToolTip(btnConsultar2, "Consultar");
            tt.SetToolTip(btnAyudas, "Ayuda");
            llenarComboOperador(cboOperador);
            csControlador.obtenerColumbasPorTabla(cboCampo, Tabla);
        }

        private void llenarComboOperador(ComboBox comboBox1)
        {
            comboBox1.Items.Add("Seleccionar"); comboBox1.Items.Add("=");
            comboBox1.Items.Add("<"); comboBox1.Items.Add("<="); comboBox1.Items.Add(">");
            comboBox1.Items.Add(">="); comboBox1.Items.Add("LIKE"); comboBox1.Items.Add("NOT LIKE"); comboBox1.SelectedIndex = 0;
        }

        private void ConsultaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar2_Click_1(object sender, EventArgs e)
        {
            try
            {
                datos = new string[] { cboCampo.Text, cboOperador.Text, txtValor.Text };
                DataTable resultados = csControlador.GenerarQuery(datos, BD);
                dgvConsultar2.DataSource = resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar2_Click_1(object sender, EventArgs e)
        {
            datos = new string[0];
            dgvConsultar2.DataSource = null;
            dgvConsultar2.Rows.Clear();
            txtValor.Clear();
            cboCampo.ResetText();
            cboOperador.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idayuda = "5";
            string Ruta = csControlador.MRuta(idayuda);
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\..\"));
            string AsRuta = Path.Combine(sRutaProyecto, "Ayuda", "ayudasConsultaSimple", Ruta);
            string AsIndice = csControlador.MIndice(idayuda);

            // Validar que la ruta y el índice no estén vacíos
            if (!string.IsNullOrEmpty(AsRuta) && !string.IsNullOrEmpty(AsIndice))
            {
                // Mostrar la ayuda automáticamente cuando se llama a asignarAyuda
                Help.ShowHelp(this, AsRuta, AsIndice);
            }
            else
            {
                MessageBox.Show("La Ruta o el índice de la ayuda están vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
