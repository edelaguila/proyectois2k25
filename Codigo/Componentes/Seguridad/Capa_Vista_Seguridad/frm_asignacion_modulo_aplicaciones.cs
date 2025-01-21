using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Necesario para Directory, File, Path y SearchOption
using Capa_Controlador_Seguridad;

namespace Capa_Vista_Seguridad
{
    public partial class frm_asignacion_modulo_aplicaciones : Form
    {
        /******************************Ismar Leonel Cortez Sanchez*******************************************************/
        logica logica2;

        public frm_asignacion_modulo_aplicaciones(String idUsuario)
        {
            InitializeComponent();
            logica2 = new logica(idUsuario); // Inicializa logica2 con idUsuario
            string tabla = "tbl_modulos";
            string campo1 = "Pk_id_modulos";
            string campo2 = "nombre_modulo";

            string tablaApli = "tbl_aplicaciones";
            string campo1Apli = "Pk_id_aplicacion";
            string campo2Apli = "nombre_aplicacion";


            // Llama al método para llenar el ComboBox
            llenarseModulos(tabla, campo1, campo2);
            llenarseApli(tablaApli, campo1Apli, campo2Apli);

            // Asocia el evento SelectedIndexChanged después de poblar el ComboBox
            Cmb_modulo.SelectedIndexChanged += new EventHandler(cmb_modulo_SelectedIndexChanged);
            Cmb_aplicacion.SelectedIndexChanged += new EventHandler(cmb_apli_SelectedIndexChanged2);
            funmostrardatos();
        }

        public frm_asignacion_modulo_aplicaciones() { }

        void funmostrardatos() {
            try
            {
                // Llamar a la capa lógica para obtener los datos de la asignación (modulo-aplicación)
                DataTable dtResultado = logica2.consultaLogicaAsigncacionModuloAplicaciones();

                if (dtResultado != null && dtResultado.Rows.Count > 0)
                {
                    // Asignar el DataTable al DataGridView
                    Dgv_asignaciones_modulo_aplicacion.DataSource = dtResultado;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar los datos: {ex.Message}");
            }

        }

        private void frm_asignacion_modulo_aplicaciones_Load(object sender, EventArgs e) 
        {
            Cmb_aplicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_modulo.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_ver, "Buscar");
            ToolTip tcrear = new ToolTip();
            tcrear.SetToolTip(Btn_crear, "Crear");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "Ayuda");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(btn_salir, "Salir");
        }


        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 1*****************************************************/

        public void llenarseModulos(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logica2.enviar(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cmb_modulo.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cmb_modulo.Items.Add(new ComboBoxItem
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

            Cmb_modulo.AutoCompleteCustomSource = coleccion;
            Cmb_modulo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cmb_modulo.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            if (Cmb_modulo.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItem)Cmb_modulo.SelectedItem;
                string valorSeleccionado = selectedItem.Value;
                // Mostrar el valor en un MessageBox
                MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            }
        }
        /***************************************************************************************************/



        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 2*****************************************************/

        public void llenarseApli(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logica2.enviar2(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cmb_aplicacion.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cmb_aplicacion.Items.Add(new ComboBoxItem
                {
                    Value = row[campo1].ToString(),
                    Display = row[campo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion2 = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion2.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion2.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            Cmb_aplicacion.AutoCompleteCustomSource = coleccion2;
            Cmb_aplicacion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cmb_aplicacion.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem2
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        private void cmb_apli_SelectedIndexChanged2(object sender, EventArgs e)
        {
            if (Cmb_modulo.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItem)Cmb_aplicacion.SelectedItem;
                string valorSeleccionado = selectedItem.Value;
                // Mostrar el valor en un MessageBox
                MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            }
        }

        //*********************KATERYN DE LEON**********************************************
        //boton ver
        private void btn_ver_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la capa lógica para obtener los datos de la asignación (modulo-aplicación)
                DataTable dtResultado = logica2.consultaLogicaAsigncacionModuloAplicaciones();

                if (dtResultado != null && dtResultado.Rows.Count > 0)
                {
                    // Asignar el DataTable al DataGridView
                    Dgv_asignaciones_modulo_aplicacion.DataSource = dtResultado;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar los datos: {ex.Message}");
            }
        }
        // *******************************KATERYN DE LEON******************************/
        //boton crear
        private void btn_crear_Click(object sender, EventArgs e)
        {   
            try
            {
                // Obtener los valores seleccionados de los ComboBox
                var selectedModulo = (ComboBoxItem)Cmb_modulo.SelectedItem;
                var selectedAplicacion = (ComboBoxItem)Cmb_aplicacion.SelectedItem;

                if (selectedModulo != null && selectedAplicacion != null)
                {
                    // Obtener nombres
                    string nombreModulo = selectedModulo.Display;
                    string nombreAplicacion = selectedAplicacion.Display;

                    // Obtener o insertar módulo y aplicación
                    int idModulo = logica2.ObtenerOInsertarModulo(nombreModulo);
                    int idAplicacion = logica2.ObtenerOInsertarAplicacion(nombreAplicacion);

                    if (idModulo > 0 && idAplicacion > 0)
                    {
                        // Insertar en la tabla intermedia
                        bool resultado = logica2.InsertarLogicaAsignacionModuloAplicacion(idModulo, idAplicacion);

                        if (resultado)
                        {
                            MessageBox.Show("Asignación creada exitosamente.");
                            funmostrardatos();
                        }
                        else
                        {
                            MessageBox.Show("Error al crear la asignación.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron obtener los IDs del módulo o la aplicación.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un módulo y una aplicación válidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la asignación: {ex.Message}");
            }


        }

        private void cmb_modulo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //*******************************************KATERYN DE LEON**********************************************
            //****************ComboBox1 (Modulos) ********************

            if (Cmb_modulo.SelectedItem != null)
            {
                // Obtener el valor del ComboBoxItem seleccionado
                var selectedItem = (ComboBoxItem)Cmb_modulo.SelectedItem;
                string valorSeleccionado = selectedItem.Value;

                // Mostrar el valor en el TextBox txt_modulo
                Txt_modulo.Text = $"{selectedItem.Value}-{selectedItem.Display}";

                // O solo el nombre del módulo (Display)
                // txt_modulo.Text = selectedItem.Display;
            }
        }
        //*******************************************************************************/

        private void cmb_apli_SelectedIndexChanged(object sender, EventArgs e)
        {  //*************************************KATERYN DE LEON**********************************************
           //****************ComboBox2 (Aplicaciones)********************

            if (Cmb_aplicacion.SelectedItem != null)
            {
                // Obtener el valor del ComboBoxItem2 seleccionado
                var selectedItem = (ComboBoxItem)Cmb_aplicacion.SelectedItem;
                string valorSeleccionado = selectedItem.Value;

                // Mostrar el valor en el TextBox txt_aplicacion
                Txt_aplicacion.Text = $"{selectedItem.Value}-{selectedItem.Display}";

                // O solo el nombre de la aplicación (Display)
                // txt_aplicacion.Text = selectedItem.Display;
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //**********************GABRIELA SUC Y KATERYN DE LEON ******************************
        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            // Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "CreacionUsuario.chm", "Creacion_Usuario.html");

            // Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "CreacionUsuario.chm", "Creacion_Usuario.html");
            // Obtener la ruta del directorio del ejecutable
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Retroceder a la carpeta del proyecto
            string projectPath = Path.GetFullPath(Path.Combine(executablePath, @"..\..\"));
            

            // Combinar con la ruta fija de "asis22k24proy2\Codigo\Componentes\Seguridad"
            //string basePath = Path.Combine(projectPath, @"asis22k24proy2\Codigo\Componentes\Seguridad");
            //MessageBox.Show("2" + basePath);


            string ayudaFolderPath = Path.Combine(projectPath, "Ayuda_Seguridad");

            // Imprimir la ruta de ayuda para verificar
            //MessageBox.Show("3: " + ayudaFolderPath);

            // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
            string pathAyuda = FindFileInDirectory(ayudaFolderPath, "frmAsignancionModuloAplicaciones.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(pathAyuda))
            {
               
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, pathAyuda, "Asignacion_Modulo_Aplicaciones.html");
            }
            else
            {
                // Si el archivo no existe, muestra un mensaje de error
                MessageBox.Show("El archivo de ayuda no se encontró.");
            }
        }

        private string FindFileInDirectory(string directory, string fileName)
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
                            MessageBox.Show("Archivo encontrado: " + file);
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
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }
        //************* Fin KATERYN DE LEON y Gabriela Suc ************************

    }

    /***************************************************************************************************/
}

    

