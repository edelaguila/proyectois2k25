using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Seguridad;

using System.IO; // Necesario para Directory, File, Path y SearchOption


namespace Capa_Vista_Seguridad
{
    public partial class frm_asignacion_perfiles : Form
    {
        logica logic;
        string valorSeleccionadousuario;
        string valorSeleccionadoperfiles;
        //###################  empieza lo que hizo Karla  Sofia Gómez Tobar #######################
        public frm_asignacion_perfiles(string sidUsuario)
        {
            InitializeComponent();

            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(Btn_agregar, "Crea nueva asignación");
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(Btn_guardar, "Guardar nueva asignación");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_bsucar, "Buscar todas las asignaciones");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(Btn_cancelar, "reestablecer");
            ToolTip tremover = new ToolTip();
            tremover.SetToolTip(Btn_remover, "Quita la nueva asignación");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(Btn_salir, "Salir de asignacion perfil");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "Ayuda");

            logic = new logica(sidUsuario);
            string stablaU = "Tbl_usuarios";
            string scampo1U = "Pk_id_usuario";
            string scampo2U = "nombre_usuario";

            string stablaP = "Tbl_perfiles";
            string scampo1P = "Pk_id_perfil";
            string scampo2P = "nombre_perfil";

            prollenarseUsuario(stablaU, scampo1U, scampo2U);
            prollenarsePerfil(stablaP, scampo1P, scampo2P);



            // Asocia el evento SelectedIndexChanged después de poblar el ComboBox
            Cbo_usuario.SelectedIndexChanged += new EventHandler(Cbo_usuario_SelectedIndexChanged);
            Cbo_perfiles.SelectedIndexChanged += new EventHandler(Cbo_perfiles_SelectedIndexChanged2);
            proactualizardatagriew();
        }


        public void prollenarseUsuario(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logic.funenviarUsuario(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_usuario.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_usuario.Items.Add(new ComboBoxItemU
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

            Cbo_usuario.AutoCompleteCustomSource = coleccion;
            Cbo_usuario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_usuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItemU
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        private void Cbo_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_usuario.SelectedItem != null)
            {
                
                var selectedItem = (ComboBoxItemU)Cbo_usuario.SelectedItem;
                valorSeleccionadousuario = selectedItem.Value;
                
               // MessageBox.Show($"Valor seleccionado: {valorSeleccionadousuario}", "Valor Seleccionado");
            }
        }


// /////////////////////////////////////////////////////////////////////////////////
        public void prollenarsePerfil(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logic.funenviarPerfiles(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_perfiles.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_perfiles.Items.Add(new ComboBoxItemP
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

            Cbo_perfiles.AutoCompleteCustomSource = coleccion2;
            Cbo_perfiles.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_perfiles.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItemP
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        private void Cbo_perfiles_SelectedIndexChanged2(object sender, EventArgs e)
        {
            if (Cbo_perfiles.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItemP)Cbo_perfiles.SelectedItem;
                valorSeleccionadoperfiles = selectedItem.Value;
                // Mostrar el valor en un MessageBox
               // MessageBox.Show($"Valor seleccionado: {valorSeleccionadoperfiles}", "Valor Seleccionado");
            }
        }



        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        public frm_asignacion_perfiles()
        {
        }

        private void Frm_asignacion_perfiles_Load(object sender, EventArgs e)
        {
            Cbo_perfiles.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_usuario.DropDownStyle = ComboBoxStyle.DropDownList;
            Btn_guardar.Enabled = false;
            Btn_remover.Enabled = false;
        }

        private void Dgv_perfiles_asignados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        void prolimpieza()
        {
            Cbo_usuario.Text = " ";
            Cbo_perfiles.Text = " ";
            Cbo_perfiles.SelectedIndex = -1;
            Cbo_usuario.SelectedIndex = -1;
            
            //Dgv_perfiles_asignados.Columns.Clear();
            proactualizardatagriew();

            if (iContadorFila > 0)
            {
                Dgv_asignacion_perfiles.Rows.RemoveAt(Dgv_asignacion_perfiles.CurrentRow.Index);
                iContadorFila--;
            }
            else
            {
                
            }
            Btn_salir.Enabled = true;
        }

        void prolimpiezaIngreso()
        {
            Cbo_usuario.Text = " ";
            Cbo_perfiles.Text = " ";
            Cbo_perfiles.SelectedIndex = -1;
            Cbo_usuario.SelectedIndex = -1;
        }

        public static int iContadorFila = 0;




        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "ayudaAsignacionPerfiles.chm", "Asignacion_Perfil_Usuarios.html");
        }



        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Cbo_usuario.Enabled = true;
            Cbo_perfiles.Enabled = true;
            Btn_agregar.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_cancelar.Enabled = true;
            Btn_bsucar.Enabled = true;
            Btn_remover.Enabled = false;
            Gpb_consulta.Enabled = true;
            prolimpieza();
        }

        public void proactualizardatagriew()
        {     
            try
            {
                // Llamar a la capa lógica para obtener los datos de la asignación (modulo-aplicación)
                DataTable dt = logic.funconsultaLogicaPerfilesUsuarios();

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Asignar el DataTable al DataGridView
                    Dgv_perfiles_asignados.DataSource = dt;
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


        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            Btn_salir.Enabled = false;
            if (Cbo_usuario.SelectedItem == null || Cbo_perfiles.SelectedItem == null)
            {
                MessageBox.Show("Faltan Datos Por Seleccionar", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool bUsuario_perfil_existente = false;

                string sUsuario = valorSeleccionadousuario;
                string sPerfil = valorSeleccionadoperfiles;

                if (iContadorFila == 0)
                {
                    Dgv_asignacion_perfiles.Rows.Add(sUsuario, sPerfil);

                    iContadorFila++;

                }
                else
                {
                    foreach (DataGridViewRow Fila in Dgv_asignacion_perfiles.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == Cbo_usuario.SelectedItem.ToString() && Fila.Cells[1].Value.ToString() == Cbo_perfiles.SelectedItem.ToString())
                        {
                            bUsuario_perfil_existente = true;
                        }
                    }

                    if (bUsuario_perfil_existente == true)
                    {
                        MessageBox.Show("Ya existe una relacion del usuario con el perfil");
                    }
                    else
                    {
                        Dgv_asignacion_perfiles.Rows.Add(sUsuario, sPerfil);
                        iContadorFila++;
                    }
                    Btn_agregar.Enabled = true;
                    Btn_remover.Enabled = true;
                    Btn_guardar.Enabled = true;
                    Btn_bsucar.Enabled = false;
                    Btn_cancelar.Enabled = false;
                    Gpb_consulta.Enabled = false;
                }

               // prolimpiezaIngreso();
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            // Deshabilitar los ComboBox después de la selección
            Cbo_usuario.Enabled = false;
            Cbo_perfiles.Enabled = false;

            // Validar si los ComboBox están vacíos
            if (Cbo_usuario.SelectedItem == null)
            {
                MessageBox.Show("Falta seleccionar un usuario.");
                Btn_agregar.Enabled = false;
                Cbo_usuario.Enabled = false;
                Cbo_perfiles.Enabled = false;
            }
            else if (Cbo_perfiles.SelectedItem == null)
            {
                MessageBox.Show("Falta seleccionar un perfil.");
                Btn_agregar.Enabled = false;
                Cbo_usuario.Enabled = false;
                Cbo_perfiles.Enabled = false;
            }
            else
            {
                // Obtener los valores seleccionados de los ComboBox
                string susuarioSeleccionado = valorSeleccionadousuario;
                string sperfilSeleccionado = valorSeleccionadoperfiles;

                // Insertar en la base de datos utilizando los valores de los ComboBox
                logic.funconsultaLogicaInsertarPerfilUsuario(susuarioSeleccionado, sperfilSeleccionado);

                MessageBox.Show("Asignación de usuario y perfil ingresada correctamente.");

                prolimpieza();

                // Configuración de botones y controles después de la inserción


                Cbo_usuario.Enabled = true;
                Cbo_perfiles.Enabled = true;
                Btn_agregar.Enabled = true;
                Btn_guardar.Enabled = false;
                Btn_cancelar.Enabled = true;
                Btn_remover.Enabled = false;
                Btn_bsucar.Enabled = true;
                Gpb_consulta.Enabled = true;
                prolimpieza();
                proactualizardatagriew();
            }
        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {

            try
            {
                // Verificar si hay una fila seleccionada en el DataGridView
                if (Dgv_perfiles_asignados.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la columna que contiene el código (suponiendo que sea la columna 0)
                    string scodigo = Dgv_perfiles_asignados.SelectedRows[0].Cells[0].Value.ToString();

                    // Confirmar la eliminación con el usuario
                    DialogResult confirmacion = MessageBox.Show(
                        "¿Está seguro de que desea eliminar esta asignación?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        // Llamar a la función de eliminación en la capa lógica
                        bool eliminado = logic.funeliminarPerfilUsuario(scodigo);

                        if (eliminado)
                        {
                            // Eliminar la fila del DataGridView para reflejar los cambios
                            Dgv_perfiles_asignados.Rows.RemoveAt(Dgv_perfiles_asignados.SelectedRows[0].Index);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            proactualizardatagriew();
            Cbo_usuario.Enabled = false;
            Cbo_perfiles.Enabled = false;
            Btn_agregar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_remover.Enabled = false;
        }



        private void Btn_cancelar_Click(object sender, EventArgs e)
        {

            if (iContadorFila > 0)
            {
                Dgv_asignacion_perfiles.Rows.RemoveAt(Dgv_asignacion_perfiles.CurrentRow.Index);
                iContadorFila--;
            }
            else
            {
                MessageBox.Show("No hay relaciones que eliminar");
            }
            Cbo_usuario.Enabled = true;
            Cbo_perfiles.Enabled = true;
            Btn_agregar.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_cancelar.Enabled = true;
            Btn_bsucar.Enabled = true;
            Btn_remover.Enabled = false;
            Gpb_consulta.Enabled = true;
            prolimpieza();
            Cbo_usuario.SelectedIndex = -1;
            Cbo_perfiles.SelectedIndex = -1;
            Btn_guardar.Enabled = false;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            prolimpieza();
        }
        //******************************************Gabriela Suc y Kateryn De Leon***********
        private void Btn_ayuda_Click_1(object sender, EventArgs e)
        {

            // Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "ayudaAsignacionPerfiles.chm", "Asignacion_Perfil_Usuarios.html");

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
            string pathAyuda = FindFileInDirectory(ayudaFolderPath, "frmAsignacionPerfiles.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(pathAyuda))
            {
                
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, pathAyuda, "Asignacion_Aplicaciones_Perfiles.html");
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

        private void Cbo_perfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_guardar.Enabled = true;
        }
        //************* Fin KATERYN DE LEON y Gabriela Suc ************************
    }
}
