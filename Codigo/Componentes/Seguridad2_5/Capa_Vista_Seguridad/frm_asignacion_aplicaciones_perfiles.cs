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
    public partial class frm_asignacion_aplicaciones_perfiles : Form
    {
        logica logic;
        public frm_asignacion_aplicaciones_perfiles(string sidUsuario)
        {
            InitializeComponent();
            logic = new logica(sidUsuario);
            actualizardatagriew1();
        }

        public frm_asignacion_aplicaciones_perfiles()
        {
        }

//****************************************Kevin López***************************************************
        // Método para cargar los perfiles
        private void CargarPerfiles()
        {
            try
            {
                DataTable dtPerfiles = logic.funconsultalogicaperfiles();
                Cbo_perfiles.Items.Clear();
                foreach (DataRow row in dtPerfiles.Rows)
                {
                    Cbo_perfiles.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar perfiles: " + ex.Message);
            }
        }

        // Método para cargar los módulos
        private void CargarModulos()
        {
            try
            {
                DataTable dtModulos = logic.funconsultalogicamodulos();
                Cbo_modulos.Items.Clear();
                foreach (DataRow row in dtModulos.Rows)
                {
                    Cbo_modulos.Items.Add(row[0].ToString());
                }
                // Vincular el evento de selección de módulo
                Cbo_modulos.SelectedIndexChanged += new EventHandler(Cbo_modulos_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar módulos: " + ex.Message);
            }
        }

        // Método para cargar aplicaciones según el módulo seleccionado
        private void CargarAplicaciones(string snombreModulo)
        {
            try
            {
               DataTable dtAplicaciones = logic.funconsultaLogicaaplicacionesP(snombreModulo);
                Cbo_aplicaciones.Items.Clear();
                foreach (DataRow row in dtAplicaciones.Rows)
                {
                    Cbo_aplicaciones.Items.Add(row["nombre_aplicacion"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar aplicaciones: " + ex.Message);
            }
        }

        //**************************************** FIN Kevin López***************************************************
//****************************************Kevin López***************************************************
        private void Frm_asignacion_aplicaciones_perfiles_Load(object sender, EventArgs e)
        {
            CargarPerfiles();
            CargarModulos();
            Cbo_aplicaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_modulos.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_perfiles.DropDownStyle = ComboBoxStyle.DropDownList;
            Btn_guardar.Enabled = false;
            Btn_remover.Enabled = true;
            Btn_modificar.Enabled = false;
        }
//****************************************FIN Kevin López***************************************************
        void limpieza()
        {
            Cbo_perfiles.Text = "";
            Cbo_modulos.Text = "";
            Cbo_aplicaciones.Text = "";
        }

//****************************************Kevin López***************************************************
        private void Cbo_modulos_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Limpiar las aplicaciones antes de agregar nuevas


            if (Cbo_modulos.SelectedIndex != -1)
            {
                string smoduloSeleccionado = Cbo_modulos.SelectedItem.ToString();
                CargarAplicaciones(smoduloSeleccionado); // Cargar las aplicaciones del módulo seleccionado
            }
            /*
            if (cbo_modulos.SelectedItem != null)
            {
                string nombreModulo = cbo_modulos.SelectedItem.ToString();
                string ID_aplicacion = null;
                CargarAplicaciones(ID_aplicacion);
            }*/
            
        }
        //****************************************FIN Kevin López***************************************************


        //****** HECHO POR JOSUE PAZ Y KEVIN LOPEZ*************************************
        public static int iContadorFila = 0;




        private void dgv_asignacionesperfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 //****************************************Kevin López***************************************************
        private void cbo_aplicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Cbo_aplicaciones.SelectedItem != null)
            {
                string snombreAplicacion = Cbo_aplicaciones.SelectedItem.ToString();
                Console.WriteLine("Aplicación seleccionada: " + snombreAplicacion);
            }

        }
//****************************************FIN Kevin López***************************************************
        private void cbo_perfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        // ------------------------- Emerzon Garcia ----------------------------------------------

        public void actualizardatagriew()
        {
            DataTable dt = logic.funconsultarPerfiles("Tbl_permisos_aplicacion_perfil");

            if (dt != null && dt.Rows.Count > 0)
            {
                //MessageBox.Show("Datos recibidos: " + dt.Rows.Count.ToString());

                // Asignar los nombres de las columnas en el DataGridView
                Dgv_asignacionesperfiles.Columns["Perfil"].DataPropertyName = "Fk_id_perfil";
                Dgv_asignacionesperfiles.Columns["Aplicacion"].DataPropertyName = "nombre_aplicacion";
                Dgv_asignacionesperfiles.Columns["Ingresar"].DataPropertyName = "guardar_permiso";
                Dgv_asignacionesperfiles.Columns["Consultar"].DataPropertyName = "buscar_permiso"; // Asumo que 'Consultar' es 'buscar_permiso'
                Dgv_asignacionesperfiles.Columns["Modificar"].DataPropertyName = "modificar_permiso";
                Dgv_asignacionesperfiles.Columns["Eliminar"].DataPropertyName = "eliminar_permiso";
                Dgv_asignacionesperfiles.Columns["Imprimir"].DataPropertyName = "imprimir_permiso";

                // Configurar CheckBoxColumn para los permisos booleanos
                ConfigurarColumnasCheckBox();

                // Asignar el DataTable al DataGridView
                Dgv_asignacionesperfiles.DataSource = dt;
                Dgv_asignacionesperfiles.Refresh();
            }
            else
            {
                MessageBox.Show("No se encontraron datos.");
            }
        }

        // Método para configurar CheckBoxColumns en el DataGridView
        private void ConfigurarColumnasCheckBox()
        {
            if (Dgv_asignacionesperfiles.Columns["Ingresar"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Ingresar"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Ingresar"]).FalseValue = 0;
            }

            if (Dgv_asignacionesperfiles.Columns["Consultar"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Consultar"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Consultar"]).FalseValue = 0;
            }

            if (Dgv_asignacionesperfiles.Columns["Modificar"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Modificar"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Modificar"]).FalseValue = 0;
            }

            if (Dgv_asignacionesperfiles.Columns["Eliminar"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Eliminar"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Eliminar"]).FalseValue = 0;
            }

            if (Dgv_asignacionesperfiles.Columns["Imprimir"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Imprimir"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Imprimir"]).FalseValue = 0;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();

        }



        private void btn_remover_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se seleccionaron filas en Dgv_asignaciones
                if (Dgv_asignaciones.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona al menos un permiso para eliminar.");
                    return;
                }

                // Mostrar mensaje de advertencia antes de proceder
                DialogResult result = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar el/los permisos seleccionado(s)? Esta acción no se puede deshacer.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Verificar si el usuario presionó 'Sí'
                if (result == DialogResult.Yes)
                {
                    // Recorrer cada fila seleccionada para eliminar
                    foreach (DataGridViewRow fila in Dgv_asignaciones.SelectedRows)
                    {
                        string sIdPerfil = fila.Cells[0].Value.ToString(); // Código del perfil
                        string snombreaplicacion = fila.Cells[1].Value.ToString(); // Nombre de la aplicación

                        // Llamar al método que elimina los permisos
                        logic.funEliminarPermisosPerfil(sIdPerfil, snombreaplicacion);
                    }

                    MessageBox.Show("Registro(s) eliminado(s) correctamente.");
                    actualizardatagriew1(); // Refrescar la vista con los datos actualizados
                    limpieza(); // Limpiar campos si es necesario
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show($"Error al eliminar permisos: {ex.Message}");
            }
        }



        //***************************HECHO POR KEVIN LOPEZ********************************************
        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            if (Cbo_perfiles.SelectedItem == null || Cbo_aplicaciones.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado nada aún");
                return;
            }

            string sPerfil = Cbo_perfiles.SelectedItem.ToString();
            string sAplicacion = Cbo_aplicaciones.SelectedItem.ToString();

            // Verificar si ya existe una relación
            foreach (DataGridViewRow fila in Dgv_asignacionesperfiles.Rows)
            {
                if (fila.Cells["Perfil"].Value.ToString() == sPerfil && fila.Cells["Aplicacion"].Value.ToString() == sAplicacion)
                {
                    MessageBox.Show("Ya existe una relación del perfil con la aplicación.");
                    return;
                }
            }

            // Agregar la nueva relación
            Dgv_asignacionesperfiles.Rows.Add(sPerfil, sAplicacion);

            // Habilitar los botones de guardar y eliminar
            Btn_guardar.Enabled = true;
            Btn_remover.Enabled = true;

            Btn_agregar.Enabled = false;
            Btn_buscar.Enabled = false;

            // Opcional: deshabilitar los ComboBox para evitar cambios
            Cbo_aplicaciones.Enabled = false;
            Cbo_modulos.Enabled = false;
            Cbo_perfiles.Enabled = false;

            limpieza(); // Limpiar los combos
            //***************************HECHO POR KEVIN LOPEZ********************************************
        }
        //*******************TRABAJADO POR JOSUE PAZ 0901-21-5560**********************************************************
        private void btn_finalizar_Click_1(object sender, EventArgs e)
        {

            string singresar;
            string sconsulta;
            string smodificar;
            string seliminar;
            string simprimir;
            try
            {
                foreach (DataGridViewRow Fila in Dgv_asignacionesperfiles.Rows)
                {

                    string scodigoperfil = Fila.Cells[0].Value.ToString();
                    string snombreaplicacion = Fila.Cells[1].Value.ToString();


                    bool cheked = ((bool)(Fila.Cells["Ingresar"].EditedFormattedValue));
                    if (cheked)
                        singresar = "1";
                    else
                        singresar = "0";

                    bool chekedM = ((bool)(Fila.Cells["Modificar"].EditedFormattedValue));
                    if (chekedM)
                        smodificar = "1";
                    else
                        smodificar = "0";

                    bool chekedE = ((bool)(Fila.Cells["Eliminar"].EditedFormattedValue));
                    if (chekedE)
                        seliminar = "1";
                    else
                        seliminar = "0";

                    bool chekedC = ((bool)(Fila.Cells["Consultar"].EditedFormattedValue));
                    if (chekedC)
                        sconsulta = "1";
                    else
                        sconsulta = "0";

                    bool chekedI = ((bool)(Fila.Cells["Imprimir"].EditedFormattedValue));
                    if (chekedI)
                        simprimir = "1";
                    else
                        simprimir = "0";

                    DataTable dtAplicaciones = logic.funguardarpermisosperfil(scodigoperfil, snombreaplicacion, singresar, smodificar, seliminar, sconsulta, simprimir);

                }

                MessageBox.Show("Datos ingresados exitosamente");
                actualizardatagriew1();
                limpieza();
                Dgv_asignacionesperfiles.Rows.Clear();
                iContadorFila = 0;
                Btn_agregar.Enabled = true;
                Btn_buscar.Enabled = true;
                Btn_remover.Enabled = false;
                Btn_guardar.Enabled = false;
                Cbo_aplicaciones.SelectedIndex = -1;
                Cbo_modulos.SelectedIndex = -1;
                Cbo_perfiles.SelectedIndex = -1;
                Cbo_aplicaciones.Enabled = true;
                Cbo_modulos.Enabled = true;
                Cbo_perfiles.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // ------------------------- Emerzon Garcia ----------------------------------------------

        public void actualizardatagriew1()
        {
            DataTable dt = logic.funconsultarPerfiles("Tbl_permisos_aplicacion_perfil");

            if (dt != null && dt.Rows.Count > 0)
            {
                //MessageBox.Show("Datos recibidos: " + dt.Rows.Count.ToString());

                // Limpiar las columnas anteriores
                Dgv_asignaciones.Columns.Clear();

                // Crear y agregar las columnas manualmente
                Dgv_asignaciones.Columns.Add("Perfil", "Perfil");
                Dgv_asignaciones.Columns["Perfil"].DataPropertyName = "Fk_id_perfil";

                Dgv_asignaciones.Columns.Add("Aplicacion", "Aplicacion");
                Dgv_asignaciones.Columns["Aplicacion"].DataPropertyName = "nombre_aplicacion";

                // Agregar columnas de permisos como TextBox
                Dgv_asignaciones.Columns.Add("Ingresar", "Ingresar");
                Dgv_asignaciones.Columns["Ingresar"].DataPropertyName = "guardar_permiso";

                Dgv_asignaciones.Columns.Add("Consultar", "Consultar");
                Dgv_asignaciones.Columns["Consultar"].DataPropertyName = "buscar_permiso";

                Dgv_asignaciones.Columns.Add("Modificar", "Modificar");
                Dgv_asignaciones.Columns["Modificar"].DataPropertyName = "modificar_permiso";

                Dgv_asignaciones.Columns.Add("Eliminar", "Eliminar");
                Dgv_asignaciones.Columns["Eliminar"].DataPropertyName = "eliminar_permiso";

                Dgv_asignaciones.Columns.Add("Imprimir", "Imprimir");
                Dgv_asignaciones.Columns["Imprimir"].DataPropertyName = "imprimir_permiso";

                // Asegúrate de que las columnas son de texto y centrar el contenido
                foreach (var column in new[] { "Ingresar", "Consultar", "Modificar", "Eliminar", "Imprimir" })
                {
                    Dgv_asignaciones.Columns[column].ValueType = typeof(string);
                    Dgv_asignaciones.Columns[column].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                // Asignar el DataTable al DataGridView
                Dgv_asignaciones.DataSource = dt;

                // Convertir booleanos a "0" o "1"
                foreach (DataRow row in dt.Rows)
                {
                    row["guardar_permiso"] = (Convert.ToBoolean(row["guardar_permiso"]) ? "1" : "0");
                    row["buscar_permiso"] = (Convert.ToBoolean(row["buscar_permiso"]) ? "1" : "0");
                    row["modificar_permiso"] = (Convert.ToBoolean(row["modificar_permiso"]) ? "1" : "0");
                    row["eliminar_permiso"] = (Convert.ToBoolean(row["eliminar_permiso"]) ? "1" : "0");
                    row["imprimir_permiso"] = (Convert.ToBoolean(row["imprimir_permiso"]) ? "1" : "0");
                }

                Dgv_asignaciones.Refresh();
            }
            else
            {
                MessageBox.Show("No se encontraron datos.");
            }
        }

        
        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            Btn_agregar.Enabled = true;
            Btn_remover.Enabled = true;
            Btn_cancelar.Enabled = true;
            Btn_modificar.Enabled = true;
            Cbo_aplicaciones.Enabled = false;
            Cbo_modulos.Enabled = false;
            Cbo_perfiles.Enabled = false;

            // Verifica si hay una fila seleccionada en Dgv_asignaciones
            if (Dgv_asignaciones.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Dgv_asignaciones.SelectedRows[0]; // La primera fila seleccionada

                // Crear una nueva fila en Dgv_asignacionesperfiles y agregarle las celdas necesarias
                int rowIndex = Dgv_asignacionesperfiles.Rows.Add();
                DataGridViewRow newRow = Dgv_asignacionesperfiles.Rows[rowIndex];

                // Obtener el ID del perfil y convertirlo en nombre
                string idPerfil = selectedRow.Cells["Perfil"].Value.ToString();
                string nombrePerfil = logic.obtenerNombrePerfil(idPerfil);

                // Copiar los valores de la fila seleccionada
                newRow.Cells["Perfil"].Value = nombrePerfil;
                newRow.Cells["Aplicacion"].Value = selectedRow.Cells["Aplicacion"].Value;
                newRow.Cells["Ingresar"].Value = selectedRow.Cells["Ingresar"].Value;
                newRow.Cells["Consultar"].Value = selectedRow.Cells["Consultar"].Value;
                newRow.Cells["Modificar"].Value = selectedRow.Cells["Modificar"].Value;
                newRow.Cells["Eliminar"].Value = selectedRow.Cells["Eliminar"].Value;
                newRow.Cells["Imprimir"].Value = selectedRow.Cells["Imprimir"].Value;

                MessageBox.Show("Registro pasado a Dgv_asignacionesperfiles.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila en Dgv_asignaciones.");
            }

            Btn_agregar.Enabled = true;
            Cbo_aplicaciones.Enabled = false;
            Cbo_modulos.Enabled = false;
            Cbo_perfiles.Enabled = false;
            actualizardatagriew1();
        }
        //***************** KATERYN DE LEON y Gabriela Suc***************************************************
        private void btn_ayuda_Click_1(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "AyudaAsignacionAplicacionesPerfiles.chm", "Asignacion_Aplicaciones_Perfiles.html");
        
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
                string pathAyuda = FindFileInDirectory(ayudaFolderPath, "frmAsignacionAplicacionesPerfiles.chm");

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
            //************* Fin KATERYN DE LEON y Gabriela Suc ************************

        

            private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_asignacionesperfiles_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {


        }

        private void Cbo_aplicaciones_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpieza();
            Dgv_asignacionesperfiles.Rows.Clear();
            iContadorFila = 0;
            Btn_agregar.Enabled = true;
            Btn_buscar.Enabled = true;
            Btn_remover.Enabled = true;
            Btn_modificar.Enabled = false;
            Btn_guardar.Enabled = false;
            Cbo_aplicaciones.SelectedIndex = -1;
            Cbo_modulos.SelectedIndex = -1;
            Cbo_perfiles.SelectedIndex = -1;
            Cbo_aplicaciones.Enabled = true;
            Cbo_modulos.Enabled = true;
            Cbo_perfiles.Enabled = true;
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            string singresar;
            string sconsulta;
            string smodificar;
            string seliminar;
            string simprimir;
            try
            {
                foreach (DataGridViewRow Fila in Dgv_asignacionesperfiles.Rows)
                {
                    string scodigoperfil = Fila.Cells[0].Value.ToString(); // Utiliza la columna correcta
                    string snombreaplicacion = Fila.Cells[1].Value.ToString(); // Utiliza la columna correcta
                    bool cheked = ((bool)(Fila.Cells["Ingresar"].EditedFormattedValue));
                    singresar = cheked ? "1" : "0";

                    bool chekedM = ((bool)(Fila.Cells["Modificar"].EditedFormattedValue));
                    smodificar = chekedM ? "1" : "0";

                    bool chekedE = ((bool)(Fila.Cells["Eliminar"].EditedFormattedValue));
                    seliminar = chekedE ? "1" : "0";

                    bool chekedC = ((bool)(Fila.Cells["Consultar"].EditedFormattedValue));
                    sconsulta = chekedC ? "1" : "0";

                    bool chekedI = ((bool)(Fila.Cells["Imprimir"].EditedFormattedValue));
                    simprimir = chekedI ? "1" : "0";

                    DataTable dtAplicaciones = logic.funModificarPermisosPerfil(scodigoperfil, snombreaplicacion, singresar, smodificar, seliminar, sconsulta, simprimir);
                }

                MessageBox.Show("Datos modificados exitosamente");
                actualizardatagriew1();
                limpieza();
                Dgv_asignacionesperfiles.Rows.Clear();
                iContadorFila = 0;
                Btn_agregar.Enabled = true;
                Btn_buscar.Enabled = true;
                Btn_remover.Enabled = false;
                Btn_guardar.Enabled = false;
                Cbo_aplicaciones.SelectedIndex = -1;
                Cbo_modulos.SelectedIndex = -1;
                Cbo_perfiles.SelectedIndex = -1;
                Cbo_aplicaciones.Enabled = true;
                Cbo_modulos.Enabled = true;
                Cbo_perfiles.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
    //******************ACA TERMINA********************************************************
}
