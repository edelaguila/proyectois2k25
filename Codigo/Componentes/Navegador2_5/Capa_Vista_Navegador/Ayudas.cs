using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Navegador;

namespace Capa_Vista_Navegador
{
    public partial class Ayudas : Form
    {

        String tbl = "ayuda";
        logicaNav logic = new logicaNav();  // Instancia de la lógica del navegador
        //OdbcConnection conn = new OdbcConnection("Dsn=colchoneria");  // Conexión a la base de datos usando ODBC


        
        string[] arrAliasC = new string[40];  // Arreglo para almacenar alias de campos

        //Boolean bConfirmRuta = true;

        public Ayudas()
        {
            InitializeComponent();
            LlenarTabla();  // Llenar la tabla al iniciar el formulario
        }

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 
        private void Btn_Ruta_Click(object sender, EventArgs e)
        {

            OpenFileDialog Ofd_Reporte = new OpenFileDialog();
            Ofd_Reporte.Filter = "All files (*.*)|*.*";
            if (Ofd_Reporte.ShowDialog() == DialogResult.OK)
            {
                // Obtén solo el nombre del archivo
                txt_ruta.Text = System.IO.Path.GetFileName(Ofd_Reporte.FileName);

                // Ahora txtruta.Text solo contiene "AyudaNavegador.chm" o el nombre del archivo seleccionado
                //bConfirmRuta = false;
            }
         }

            private void Button2_Click(object sender, EventArgs e)
            {
                OpenFileDialog rutaFile = new OpenFileDialog();
                rutaFile.InitialDirectory = "c:\\";
                rutaFile.Filter = "chm files (*.html)|*.html";  // Filtro para seleccionar archivos .html
                if (rutaFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txt_indice.Text = rutaFile.FileName;  // Asignar la ruta seleccionada al campo de texto
                }
            }

            // Método para llenar la tabla con los registros de la tabla 'ayuda'
            void LlenarTabla()
            {
                DataTable dt = logic.LlenarTblAyuda(tbl);
                Dgv_ayudas.DataSource = dt;
            }

            //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 

            //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 

            // Método para crear el query de INSERT para agregar un nuevo registro en 'ayuda'
            string CrearInsert()
            {
                string sQuery = "INSERT INTO ayuda (Ruta, indice, estado) VALUES  ('" + txt_ruta.Text.Replace("\\", "/") + "', '" + txt_indice.Text + "', '1')";
                return sQuery;
            }

            // Método para crear el query de DELETE, que marca como eliminada una ayuda cambiando su estado
            string CrearDelete()
            {
                string sQuery = "UPDATE ayuda SET estado = 0 WHERE Id_ayuda = " + Dgv_ayudas.CurrentRow.Cells[0].Value.ToString();
                return sQuery;
            }

            // Método para crear el query de UPDATE, para modificar la ruta y el índice de una ayuda
            string CrearUpdate()
            {
                string sQuery = "UPDATE ayuda SET Ruta = '" + txt_ruta.Text.Replace("\\", "/") + "', indice = '" + txt_indice.Text + "' WHERE Id_ayuda = " + Dgv_ayudas.CurrentRow.Cells[0].Value.ToString();
                return sQuery;
            }

            // Evento del botón para agregar una nueva ayuda
            private void Btn_guardar_Click(object sender, EventArgs e)
            {
                if (txt_ruta.Text == "" || txt_indice.Text == "")
                {
                    MessageBox.Show("Por favor, llene los campos de ruta e índice");
                }
                else
                {
                    logic.NuevoQuery(CrearInsert());
                    txt_indice.Clear();
                    txt_ruta.Clear();
                    MessageBox.Show("Ayuda agregada Correctamente!");
                    LlenarTabla();  // Actualizar la tabla
                }
            }

            // Evento al hacer clic en una celda del DataGrid para seleccionar una ayuda y mostrarla en los campos de texto
            private void Dgv_ayudas_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (Dgv_ayudas.SelectedRows.Count == 1)
                {
                    txt_ruta.Text = Dgv_ayudas.CurrentRow.Cells[1].Value.ToString();
                    txt_indice.Text = Dgv_ayudas.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un registro de la tabla");
                }
            }

            // Evento del botón para modificar una ayuda seleccionada
            private void Btn_modificar_Click(object sender, EventArgs e)
            {
                if (txt_ruta.Text == "" || txt_indice.Text == "")
                {
                    MessageBox.Show("Por favor, llene ambos campos para continuar...");
                }
                else
                {
                    logic.NuevoQuery(CrearUpdate());
                    txt_indice.Clear();
                    txt_ruta.Clear();
                    MessageBox.Show("Ayuda modificada correctamente");
                    LlenarTabla();  // Actualizar la tabla
                }
            }

            // Evento del botón para eliminar una ayuda seleccionada (cambia su estado)
            private void Btn_eliminar_Click(object sender, EventArgs e)
            {
                if (txt_ruta.Text == "" || txt_indice.Text == "")
                {
                    MessageBox.Show("Hola");
                }
                else
                {
                    logic.NuevoQuery(CrearDelete());
                    txt_indice.Clear();
                    txt_ruta.Clear();
                    MessageBox.Show("Ayuda eliminada Correctamente");
                    LlenarTabla();  // Actualizar la tabla
                }
            }

            private void Ayudas_Load(object sender, EventArgs e)
            {
                // Evento que ocurre cuando se carga el formulario, sin implementación
            }

            private void Label1_Click(object sender, EventArgs e)
            {
                // Evento que ocurre cuando se hace clic en el label, sin implementación
            }

            // Método que permite seleccionar un archivo HTML desde un diálogo
            private void Btn_indice_Click_1(object sender, EventArgs e)
            {
                // Obtener el directorio base de la aplicación
                string sBasePath = AppDomain.CurrentDomain.BaseDirectory;

                // Combinar la ruta base con la carpeta "HTML"
                string sHtmlDirectory = Path.Combine(sBasePath, @"..\..\..\HTML");

                OpenFileDialog rutaFile = new OpenFileDialog();
                rutaFile.InitialDirectory = Path.GetFullPath(sHtmlDirectory);  // Establecer el directorio inicial como la carpeta "HTML"
                rutaFile.Filter = "HTML files (*.html)|*.html";  // Filtro para solo mostrar archivos .html
                if (rutaFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Obtener solo el nombre del archivo (sin la ruta completa)
                    string sFileName = Path.GetFileName(rutaFile.FileName);

                    // Asignar el nombre del archivo al campo de texto
                    txt_indice.Text = sFileName;
                }
            }

            //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        
    }
}
