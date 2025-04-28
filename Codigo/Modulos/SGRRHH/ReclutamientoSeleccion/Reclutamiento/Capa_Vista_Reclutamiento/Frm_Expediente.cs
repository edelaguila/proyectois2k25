using Capa_Controlador_Reclutamiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Reclutamiento
{
    public partial class Frm_Expediente : Form
    {
       
        Controlador controlador = new Controlador();
        public Frm_Expediente()
        {
            InitializeComponent();
            LlenarComboPostulantes();
            //Dgv_VisualizarDatos.DataSource = controlador.Pro_obtenerExpedientes();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                int pkPostulante = (int)Cmb_Idpostulante.SelectedValue;
                string pathCurriculum = Txt_Curriculum.Text;
                string pathEntrevista = Txt_DocEntrevista.Text;
                string pathPruebas = Txt_DocPruebas.Text;

                int logica = int.Parse(Txt_pruebaLogica.Text);
                int numerica = int.Parse(Txt_pruebaNumerica.Text);
                int verbal = int.Parse(Txt_pruebaVerbal.Text);
                int razonamiento = int.Parse(Txt_pruebaRazonamiento.Text);
                int tecnologica = int.Parse(Txt_pruebaTecnologica.Text);
                string personalidad = Cmb_PruebaPersonalidad.Text;

                controlador.Pro_guardar(pkPostulante, pathCurriculum, pathEntrevista,
                    logica, numerica, verbal, razonamiento, tecnologica, personalidad, pathPruebas);

                // Limpiar los controles después de guardar los datos
                Cmb_Idpostulante.SelectedIndex = -1;  // Limpiar ComboBox
                Txt_Curriculum.Clear();  // Limpiar TextBox
                Txt_DocEntrevista.Clear();  // Limpiar TextBox
                Txt_DocPruebas.Clear();  // Limpiar TextBox
                Txt_pruebaLogica.Clear();  // Limpiar TextBox
                Txt_pruebaNumerica.Clear();  // Limpiar TextBox
                Txt_pruebaVerbal.Clear();  // Limpiar TextBox
                Txt_pruebaRazonamiento.Clear();  // Limpiar TextBox
                Txt_pruebaTecnologica.Clear();  // Limpiar TextBox
                Cmb_PruebaPersonalidad.SelectedIndex = -1;  // Limpiar ComboBox
                                                            // Mostrar los datos actualizados
                Dgv_VisualizarDatos.DataSource = controlador.Pro_obtenerExpedientes();

                // Limpiar campos
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar datos: " + ex.Message);
            }
        }
            // Función para limpiar los campos
            private void LimpiarCampos()
            {
                Txt_Curriculum.Clear();
                Txt_DocEntrevista.Clear();
                Txt_DocPruebas.Clear();

                Txt_pruebaLogica.Clear();
                Txt_pruebaNumerica.Clear();
                Txt_pruebaVerbal.Clear();
                Txt_pruebaRazonamiento.Clear();
                Txt_pruebaTecnologica.Clear();

                Cmb_Idpostulante.SelectedIndex = -1;
                Cmb_PruebaPersonalidad.SelectedIndex = -1;
            }

        private void Btn_seleccionarCV_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del cuadro de diálogo para abrir archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configura el filtro para los tipos de archivo, por ejemplo, PDF
            openFileDialog.Filter = "Archivos PDF|*.pdf|Todos los archivos|*.*";

            // Muestra el cuadro de diálogo para seleccionar un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Asigna la ruta completa del archivo seleccionado al TextBox
                Txt_Curriculum.Text = openFileDialog.FileName;
            }
        }
        private void LlenarComboPostulantes()
        {
            var lista = controlador.ObtenerListaPostulantes();

            Cmb_Idpostulante.DataSource = lista;
            Cmb_Idpostulante.DisplayMember = "Value"; // lo que se muestra (nombre)
            Cmb_Idpostulante.ValueMember = "Key";     // el ID real
        }

        private void Btn_SeleccionarEntrevista_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del cuadro de diálogo para abrir archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configura el filtro para los tipos de archivo, por ejemplo, PDF
            openFileDialog.Filter = "Archivos PDF|*.pdf|Todos los archivos|*.*";

            // Muestra el cuadro de diálogo para seleccionar un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Asigna la ruta completa del archivo seleccionado al TextBox
                Txt_DocEntrevista.Text = openFileDialog.FileName;
            }
        }

        private void Btn_SeleccionarPruebas_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del cuadro de diálogo para abrir archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configura el filtro para los tipos de archivo, por ejemplo, PDF
            openFileDialog.Filter = "Archivos PDF|*.pdf|Todos los archivos|*.*";

            // Muestra el cuadro de diálogo para seleccionar un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Asigna la ruta completa del archivo seleccionado al TextBox
                Txt_DocPruebas.Text = openFileDialog.FileName;
            }
        }

        private void Btn_VerCv_Click(object sender, EventArgs e)
        {
            int idPostulante = (int)Cmb_Idpostulante.SelectedValue;
            controlador.VerArchivoPDF("curriculum", idPostulante);
        }

        private void Btn_DocEntrevista_Click(object sender, EventArgs e)
        {
            int idPostulante = (int)Cmb_Idpostulante.SelectedValue;
            controlador.VerArchivoPDF("documento_entrevista", idPostulante);
        }

        private void Btn_DocPruebas_Click(object sender, EventArgs e)
        {
             int idPostulante = (int)Cmb_Idpostulante.SelectedValue;
            controlador.VerArchivoPDF("pruebas_psicometricas", idPostulante);
        }

        private void Frm_Expediente_Load(object sender, EventArgs e)
        {

        }
    }
}

