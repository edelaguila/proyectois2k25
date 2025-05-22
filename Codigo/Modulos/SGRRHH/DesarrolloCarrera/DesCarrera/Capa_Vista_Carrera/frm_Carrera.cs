using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Carrera;
using Capa_Controlador_Seguridad;
using static Capa_Vista_Carrera.frm_Promociones;

namespace Capa_Vista_Carrera
{
    public partial class frm_Carrera : Form
    {
        Controlador logica2;
        private int idSeleccionado = 0;
        private int excepcionActiva = 1;
        private int estadoActivo = 1;
        string valorSeleccionado;
        string valorSeleccionado2;

        logica logicaSeg = new logica();
        public string idUsuario { get; set; }
        public frm_Carrera(String idUsuario)
        {
            InitializeComponent();
            logica2 = new Controlador(idUsuario);
            string tabla = "tbl_empleados";
            string campo1 = "pk_clave";
            string campo2 = "empleados_nombre";

            // Llama al método para llenar el ComboBox
            llenarseModulos(tabla, campo1, campo2);
        }

        private void CargarDatosNominas(int idEmpleado)
        {
            try
            {
                DataTable dt = logica2.funcConsultarNomina(idEmpleado);
                if (dt != null)
                {
                    dgv_nominas.DataSource = dt;

                    // Aquí podrías hacer lo del ID si necesitas
                }
                else
                {
                    MessageBox.Show("Error al cargar los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }


        private void CargarDatosReclutamiento(int idEmpleado)
        {
            try
            {
                DataTable dt = logica2.funcConsultarReclutamiento(idEmpleado);
                if (dt != null)
                {
                    dgv_Reclutamiento.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Error al cargar los datos de reclutamiento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de reclutamiento: " + ex.Message);
            }
        }
        private void CargarDatosCapacitaciones(int idEmpleado)
        {
            try
            {
                DataTable dt = logica2.funcConsultarCapacitaciones(idEmpleado);
                if (dt != null)
                {
                    dgv_Capacitaciones.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Error al cargar los datos de capacitaciones.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de capacitaciones: " + ex.Message);
            }
        }

        private void CargarDatosDesempeno(int idEmpleado)
        {
            try
            {
                DataTable dt = logica2.funcConsultarDesempeno(idEmpleado);
                if (dt != null)
                {
                    dgv_desempenio.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Error al cargar los datos de desempeño.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de desempeño: " + ex.Message);
            }
        }

        private void CargarDatosDisciplinaria(int idEmpleado)
        {
            try
            {
                DataTable dt = logica2.funcConsultarDisciplinaria(idEmpleado);
                if (dt != null)
                {
                    dgv_disciplina.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Error al cargar los datos disciplinarios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos disciplinarios: " + ex.Message);
            }
        }




        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 1*****************************************************/

        public void llenarseModulos(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logica2.enviar(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            cmb_empleado.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                cmb_empleado.Items.Add(new ComboBoxItem
                {
                    Value = row[campo1].ToString(),
                    Display = row[campo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            cmb_empleado.AutoCompleteCustomSource = coleccion;
            cmb_empleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_empleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        private void cmb_modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_empleado.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItem)cmb_empleado.SelectedItem;
                string valorSeleccionado = selectedItem.Value;
                // Mostrar el valor en un MessageBox
                MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            }
        }

        private void cmb_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmb_empleado.SelectedItem != null)
            //{
            //    // Obtener el valor del ValueMember seleccionado
            //    var selectedItem = (ComboBoxItem)cmb_empleado.SelectedItem;
            //    string valorSeleccionado = selectedItem.Value;
            //    // Mostrar el valor en un MessageBox
            //    MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            //}

            if (cmb_empleado.SelectedItem != null)
            {
                var selectedItem = (ComboBoxItem)cmb_empleado.SelectedItem;
                valorSeleccionado = selectedItem.Value;
                // MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
                // Obtener datos del empleado
                DataRow datos = logica2.ObtenerPuestoYSalario(valorSeleccionado);
                //if (datos != null)
                //{
                //    txt_PuestoActual.Text = datos["puesto"].ToString();
                //    txt_SalarioActual.Text = datos["salario"].ToString();
                //}
                //else
                //{
                //    txt_PuestoActual.Text = "No encontrado";
                //    txt_SalarioActual.Text = "No encontrado";
                //}
            }




        }

        /***************************************************************************************************/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_empleado.SelectedItem != null)
            {
                var selectedItem = (ComboBoxItem)cmb_empleado.SelectedItem;
                valorSeleccionado = selectedItem.Value;
                 MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
                // Obtener datos del empleado
               
                DataRow datos = logica2.ObtenerPuestoYSalario(valorSeleccionado);
                //if (datos != null)
                //{
                //    txt_PuestoActual.Text = datos["puesto"].ToString();
                //    txt_SalarioActual.Text = datos["salario"].ToString();
                //}
                //else
                //{
                //    txt_PuestoActual.Text = "No encontrado";
                //    txt_SalarioActual.Text = "No encontrado";
                //}
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            int idEmpleado = Convert.ToInt32(valorSeleccionado); // o de donde obtengas el ID
            CargarDatosNominas(idEmpleado);
            CargarDatosReclutamiento(idEmpleado);
            CargarDatosCapacitaciones(idEmpleado);
            CargarDatosDesempeno(idEmpleado);
            CargarDatosDisciplinaria(idEmpleado);
            logicaSeg.funinsertarabitacora(idUsuario, "Se consulto carrera", "Varias", "12002");
        }
        // Declarar el ToolTip en el boton Ayuda
        private ToolTip toolTipAyuda = new ToolTip();
        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            logicaSeg.funinsertarabitacora(idUsuario, "Se vio ayuda", "Varias", "12002");
            // Busca la carpeta raíz del proyecto llamada proyectois2k25 a partir de la ruta del ejecutable.
            // Si encuentra la carpeta, busca el archivo .chm dentro de ella y sus subcarpetas.
            //Si el archivo es encontrado, intenta abrirlo usando Help.ShowHelp().Si falla, lo abre directamente con el proceso del sistema.


            // Mostrar el ToolTip en el botón de ayuda
            toolTipAyuda.SetToolTip(Btn_Ayuda, "Documento de ayuda");

            // Obtener la ruta del ejecutable
            string sExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Buscar la carpeta raíz "proyectois2k25" desde el ejecutable
            string sProjectPath = sFindProjectRootDirectory(sExecutablePath, "proyectois2k25");

            if (string.IsNullOrEmpty(sProjectPath))
            {
                MessageBox.Show("❌ ERROR: No se encontró la carpeta 'proyectois2k25'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar el archivo .chm en la carpeta raíz y subcarpetas
            string sPathAyuda = sfunFindFileInDirectory(sProjectPath, "AyudaCarrera.chm");

            // Si el archivo fue encontrado, abrirlo
            if (!string.IsNullOrEmpty(sPathAyuda))
            {
                try
                {
                    Help.ShowHelp(null, sPathAyuda); //para abrir archivo si es encontrado 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("⚠️ Error al abrir el archivo con Help.ShowHelp(): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.Process.Start(sPathAyuda);
                }
            }
            else
            {
                MessageBox.Show("❌ ERROR: No se encontró el archivo AyudaSanciones.chm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensaje de error
            }
        }


        /// Busca la carpeta raíz del proyecto "proyectois2k25" comenzando desde una ruta dada
        /// y subiendo niveles en la jerarquía de directorios hasta encontrarla.
        private string sFindProjectRootDirectory(string startPath, string stargetFolder)
        {
            DirectoryInfo dir = new DirectoryInfo(startPath);
            // aca estara subiendo niveles o  la jerarquía de directorios hasta encontrar la carpeta "proyectois2k25"
            while (dir != null)
            {
                if (dir.Name.Equals(stargetFolder, StringComparison.OrdinalIgnoreCase))
                {
                    return dir.FullName; // Retorna la ruta de la carpeta raíz
                }
                dir = dir.Parent; // Subir un nivel en la jerarquía
            }
            return null; // Retorna null si no encuentra la carpeta
        }

        //Busca el archivo (.chm) dentro de un directorio y sus subcarpetas.
        private string sfunFindFileInDirectory(string sDirectory, string sFileName)
        {
            try
            {
                if (Directory.Exists(sDirectory))


                {
                    // Buscar todos los archivos .chm dentro de la carpeta y subcarpetas
                    string[] sFiles = Directory.GetFiles(sDirectory, "*.chm", SearchOption.AllDirectories);
                    // Retornar el archivo que coincida con el nombre buscado
                    return sFiles.FirstOrDefault(file => Path.GetFileName(file).Equals(sFileName, StringComparison.OrdinalIgnoreCase));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Error al buscar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // mensaje de error
            }

            return null; //retorna a null
        } //  **FIN AYUDA**



    }
}