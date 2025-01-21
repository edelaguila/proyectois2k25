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
using System.Data.Odbc;

using System.IO; // Necesario para Directory, File, Path y SearchOption



namespace Capa_Vista_Seguridad
{
    public partial class frm_asignacion_aplicaciones : Form
    {
        logica logic;

        //########## INICIA ALYSON RODRIGUEZ 9959-21-829
        public frm_asignacion_aplicaciones(string idUsuario)
        {
            InitializeComponent();
            Btn_guardar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_limpiar.Enabled = false;
            Cbo_usuarios.Enabled = false;
            Cbo_modulos.Enabled = false;
            Cbo_aplicaciones.Enabled = false;
            Dgv_asignaciones.Enabled = false;
            Dgv_aplicaciones_asignados.Enabled = true;
            Btn_modificar.Enabled = false;
            Btn_actualizar.Enabled = false;
            logic = new logica(idUsuario);
            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(Btn_agregar, "Crear Asignación");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_buscar, "Buscar Asignación");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(Btn_limpiar, "Limpiar Datos");
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(Btn_guardar, "Guardar Asignación");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(Btn_salir, "Salir Módulo de Asignación");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "Ayuda");
            ToolTip teliminar = new ToolTip();
            teliminar.SetToolTip(Btn_eliminar, "Cancelar Asignación");
            ToolTip tmodificar = new ToolTip();
            tnuevo.SetToolTip(Btn_modificar, "Modificar ");
            ToolTip tactualizar = new ToolTip();
            tnuevo.SetToolTip(Btn_agregar, "Actualizar Permisos");
            actualizardatagriew();
        }
        //####  FINALIZA ALYSON RODRIGUEZ 9959-21-829

        public frm_asignacion_aplicaciones()
        {
        }


        //María José Véliz 
        // Método para cargar los usuarios
        private void CargarUsuarios()
        {
            try
            {
                DataTable dtPerfiles = logic.funconsultaLogicaUsuariosAplicaciones();
                Cbo_usuarios.Items.Clear();
                foreach (DataRow row in dtPerfiles.Rows)
                {
                    // Aquí usamos el índice 1 para obtener el nombre del usuario en lugar del ID
                    Cbo_usuarios.Items.Add(row["Nombre"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar usuarios: " + ex.Message);
            }
        }

        //termina

        //Trabajado María José Véliz
        private void Frm_asignacion_aplicaciones_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarModulos();
            Cbo_aplicaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_modulos.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_usuarios.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        //termina

        void limpieza()
        {
            Cbo_usuarios.Text = " ";
            Cbo_modulos.Text = " ";
            Cbo_aplicaciones.Text = " ";
            Cbo_usuarios.SelectedIndex = -1;
            Cbo_modulos.SelectedIndex = -1;
            Cbo_aplicaciones.SelectedIndex = -1;
        }

        void limpieza2()
        {
            Cbo_usuarios.Text = " ";
            Cbo_modulos.Text = " ";
            Cbo_aplicaciones.Text = " ";
            Cbo_usuarios.SelectedIndex = -1;
            Cbo_modulos.SelectedIndex = -1;
            Cbo_aplicaciones.SelectedIndex = -1;
            Dgv_aplicaciones_asignados.Columns.Clear();


            if (iContadorFila > 0)
            {
                Dgv_asignaciones.Rows.RemoveAt(Dgv_asignaciones.CurrentRow.Index);
                iContadorFila--;
            }
            else
            {
            }
        }

        // TRABAJADO POR ALYSON RODRIGURZ 9959-21-829
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
                Cbo_modulos.SelectedIndexChanged += new EventHandler(Cbo_modulos_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar módulos: " + ex.Message);
            }
        }
        //FIN ALYSON RODRIGUEZ 9959-21-829

        // TRABAJADO POR ALYSON RODRIGURZ 9959-21-829
        // Método para cargar aplicaciones según el módulo seleccionado
        private void CargarAplicaciones(string nombreModulo)
        {
            try
            {
                DataTable dtAplicaciones = logic.funConsultaLogicaAplicaciones(nombreModulo);
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
        //FIN ALYSON RODRIGURZ 9959-21-829


        // TRABAJADO POR ALYSON RODRIGURZ 9959-21-829
        private void Cbo_modulos_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Limpiar las aplicaciones antes de agregar nuevas

            if (Cbo_modulos.SelectedIndex != -1)
            {
                string moduloSeleccionado = Cbo_modulos.SelectedItem.ToString();
                CargarAplicaciones(moduloSeleccionado);
            }

        }
        //FIN ALYSON RODRIGURZ 9959-21-829



        //Trabajado María José Véliz
        private void Cbo_aplicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Cbo_aplicaciones.SelectedItem != null)
            {
                string nombreAplicacion = Cbo_aplicaciones.SelectedItem.ToString();
                Console.WriteLine("Aplicación seleccionada: " + nombreAplicacion);
            }

        }
        //Termina


        public static int iContadorFila = 0;

        //Trabajado María José Véliz   //Cambios Trabajados por Alyson Rodriguez 9959-21-829
        // Método para configurar CheckBoxColumns en el DataGridView
        private void ConfigurarColumnasCheckBox()
        {

            // Asegurarte de que el DataGridView esté vacío antes de configurar columnas
            Dgv_asignaciones.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Fk_id_usuario", HeaderText = "Usuario" });
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "nombre_aplicacion", HeaderText = "Aplicación" });
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "guardar_permiso", HeaderText = "Ingresar" });
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "buscar_permiso", HeaderText = "Consultar" });
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "modificar_permiso", HeaderText = "Modificar" });
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "eliminar_permiso", HeaderText = "Eliminar" });
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "imprimir_permiso", HeaderText = "Imprimir" });


            // Lista de las columnas que son CheckBox y necesitan configuración
            string[] sPermisosColumnas = { "Ingresar", "Consultar", "Modificar", "Eliminar", "Imprimir" };

            foreach (string columna in sPermisosColumnas)
            {
                // Verificar si la columna existe en el DataGridView
                if (Dgv_asignaciones.Columns.Contains(columna))
                {
                    if (Dgv_asignaciones.Columns[columna] is DataGridViewCheckBoxColumn checkBoxColumn)
                    {
                        // Configurar permisos habilitados o deshabilitados para cada columna CheckBox
                        checkBoxColumn.TrueValue = 1;
                        checkBoxColumn.FalseValue = 0;
                    }
                }
            }
        }
        //Termina


        //Trabajado por Alyson Rodriguez 9959-21-829
        public void actualizardatagriew()
        {


            try
            {
                // Obtener los datos desde la base de datos
                DataTable dt = logic.funConsultaLogicaUsuarios("Tbl_permisos_aplicaciones_usuario");

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Asignar el DataTable al DataGridView
                    Dgv_aplicaciones_asignados.DataSource = dt;
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
        //##################Finaliza##################


        private void Dgv_asignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
           
        }


        //Trabajado María José Véliz
        private bool isInitialized = false;
        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            if (!isInitialized)
            {
                // Primera vez que se presiona el botón
                Btn_guardar.Enabled = false;
                Cbo_usuarios.Enabled = true;
                Cbo_modulos.Enabled = true;
                Cbo_aplicaciones.Enabled = true;
                Dgv_asignaciones.Enabled = true;
                Btn_eliminar.Enabled = false;
                Btn_limpiar.Enabled = true;
                Btn_buscar.Enabled = false;
                Btn_modificar.Enabled = false;
                Btn_actualizar.Enabled = false;
                MessageBox.Show("Empieza la asignación.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isInitialized = true;
                return;
            }
            else
            {
                // Segunda vez que se presiona el botón
                if (Cbo_usuarios.SelectedItem != null && Cbo_modulos.SelectedItem != null && Cbo_aplicaciones.SelectedItem != null)
                {
                    // Deshabilitar ComboBox
                    Cbo_usuarios.Enabled = false;
                    Cbo_modulos.Enabled = false;
                    Cbo_aplicaciones.Enabled = false;
                    Btn_limpiar.Enabled = true;
                    Btn_eliminar.Enabled = false;
                    Btn_guardar.Enabled = true;
                    Btn_agregar.Enabled = false;
                    Btn_buscar.Enabled = false;
                    Btn_modificar.Enabled = false;
                    Btn_actualizar.Enabled = false;

                    string sUsuario = Cbo_usuarios.SelectedItem.ToString();
                    string sAplicacion = Cbo_aplicaciones.SelectedItem.ToString();

                    bool bUsuario_aplicacion_existente = false;
                    foreach (DataGridViewRow Fila in Dgv_asignaciones.Rows)
                    {
                        if (Fila.Cells[0].Value?.ToString() == sUsuario && Fila.Cells[1].Value?.ToString() == sAplicacion)
                        {
                            bUsuario_aplicacion_existente = true;
                            break;
                        }
                    }

                    if (!bUsuario_aplicacion_existente)
                    {
                        Dgv_asignaciones.Rows.Add(sUsuario, sAplicacion);
                        iContadorFila++;
                        // No llamamos a limpieza() aquí para mantener los valores seleccionados
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una relación del usuario con la aplicación");
                    }
                }
                else
                {
                    MessageBox.Show("Faltan Datos Por Seleccionar", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        //Termina


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            Btn_eliminar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_agregar.Enabled = false;
            Btn_limpiar.Enabled = true;
            Cbo_aplicaciones.Enabled = false;
            Cbo_modulos.Enabled = false;
            Cbo_usuarios.Enabled = false;
            Dgv_aplicaciones_asignados.Enabled = true;
            Dgv_asignaciones.Enabled = true;
            Btn_modificar.Enabled = true;
            Btn_actualizar.Enabled = false;




            // Método para manejar el evento de búsqueda al hacer clic en el botón
            try
            {
                // Verificar si se ha seleccionado al menos una fila en Dgv_aplicaciones_asignados
                if (Dgv_aplicaciones_asignados.CurrentRow != null)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow filaSeleccionada = Dgv_aplicaciones_asignados.CurrentRow;

                    // Crear una nueva fila para el DataGridView Dgv_asignaciones
                    DataGridViewRow nuevaFila = new DataGridViewRow();
                    nuevaFila.CreateCells(Dgv_asignaciones);

                    // Asignar los valores de cada celda de la fila seleccionada a la nueva fila
                    for (int i = 0; i < filaSeleccionada.Cells.Count; i++)
                    {
                        nuevaFila.Cells[i].Value = filaSeleccionada.Cells[i].Value;
                    }

                    // Agregar la nueva fila a Dgv_asignaciones
                    Dgv_asignaciones.Rows.Add(nuevaFila);

                    MessageBox.Show("Datos transferidos correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para transferir los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al transferir datos: {ex.Message}");
            }
        }

        //termina

        private void btn_remover_Click_1(object sender, EventArgs e)
        {
            ReiniciarEstado();
        }

        private void ReiniciarEstado()
        {
            isInitialized = false;
            Btn_guardar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_limpiar.Enabled = false;
            Cbo_usuarios.Enabled = false;
            Cbo_modulos.Enabled = false;
            Cbo_aplicaciones.Enabled = false;
            Dgv_asignaciones.Enabled = false;
            Dgv_aplicaciones_asignados.Enabled = true;
            Btn_agregar.Enabled = true;
            Btn_buscar.Enabled = true;
            Btn_modificar.Enabled = false;
            Btn_actualizar.Enabled = false;

            limpieza();
            Dgv_asignaciones.Rows.Clear();
            iContadorFila = 0;
        }

        // FINALIZA ALYSON RODRIGUEZ 9959-21-829 
        private void btn_guardar_Click(object sender, EventArgs e)
        {

            string sIngresar;
            string sConsulta;
            string sModificar;
            string sEliminar;
            string sImprimir;

            try
            {
                bool hayCheckboxMarcado = false; // Variable para verificar checkboxes

                foreach (DataGridViewRow Fila in Dgv_asignaciones.Rows)
                {
                    // Verificar si hay algún checkbox marcado
                    if ((bool)(Fila.Cells["Ingresar"].EditedFormattedValue) ||
                        (bool)(Fila.Cells["Modificar"].EditedFormattedValue) ||
                        (bool)(Fila.Cells["Eliminar"].EditedFormattedValue) ||
                        (bool)(Fila.Cells["Consultar"].EditedFormattedValue) ||
                        (bool)(Fila.Cells["Imprimir"].EditedFormattedValue))
                    {
                        hayCheckboxMarcado = true; // Al menos un checkbox está marcado
                        break; // Salir del bucle si encontramos al menos un checkbox marcado
                    }
                }

                // Si no hay checkboxes marcados, mostrar mensaje y salir
                if (!hayCheckboxMarcado)
                {
                    MessageBox.Show("Debe seleccionar al menos una opción antes de guardar.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método
                }
           

                foreach (DataGridViewRow Fila in Dgv_asignaciones.Rows)
                {
                    string sUsuario = Fila.Cells[0].Value.ToString();
                    string sAplicacion = Fila.Cells[1].Value.ToString();


                    bool cheked = ((bool)(Fila.Cells["Ingresar"].EditedFormattedValue));
                    if (cheked)
                        sIngresar = "1";
                    else
                        sIngresar = "0";

                    bool chekedM = ((bool)(Fila.Cells["Modificar"].EditedFormattedValue));
                    if (chekedM)
                        sModificar = "1";
                    else
                        sModificar = "0";

                    bool chekedE = ((bool)(Fila.Cells["Eliminar"].EditedFormattedValue));
                    if (chekedE)
                        sEliminar = "1";
                    else
                        sEliminar = "0";

                    bool chekedC = ((bool)(Fila.Cells["Consultar"].EditedFormattedValue));
                    if (chekedC)
                        sConsulta = "1";
                    else
                        sConsulta = "0";

                    bool chekedI = ((bool)(Fila.Cells["Imprimir"].EditedFormattedValue));
                    if (chekedI)
                        sImprimir = "1";
                    else
                        sImprimir = "0";

                    // Mostrar mensaje con los datos de cada fila antes de insertar
                    MessageBox.Show(
                        $"Datos de la fila:\n" +
                        $"Usuario: {sUsuario}\n" +
                        $"Aplicación: {sAplicacion}\n" +
                        $"Ingresar: {sIngresar}\n" +
                        $"Consultar: {sConsulta}\n" +
                        $"Modificar: {sModificar}\n" +
                        $"Eliminar: {sEliminar}\n" +
                        $"Imprimir: {sImprimir}",
                        "Datos de la Fila",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    DataTable dtAplicaciones = logic.funConsultaLogicaPermisosUsuarioAplicacion(sUsuario, sAplicacion, sIngresar, sConsulta, sModificar, sEliminar, sImprimir);

                }

                MessageBox.Show("Datos ingresados exitosamente");
                actualizardatagriew();
                Btn_modificar.Enabled = false;
                Btn_actualizar.Enabled = false;
                Btn_guardar.Enabled = false;
                Btn_eliminar.Enabled = false;
                Btn_limpiar.Enabled = false;
                Cbo_usuarios.Enabled = true;
                Cbo_modulos.Enabled = true;
                Cbo_aplicaciones.Enabled = true;
                Dgv_asignaciones.Enabled = true;
                Dgv_aplicaciones_asignados.Enabled = true;
                Btn_agregar.Enabled = true;
                Btn_buscar.Enabled = true;
                limpieza();
                Dgv_asignaciones.Rows.Clear();
                iContadorFila = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        // FINALIZA ALYSON RODRIGUEZ 9959-21-829 

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //*****************KATERYN DE LEON y Gabriela Suc*************
        private void btn_ayuda_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "AyudaAsignacionAplicacionesUsuarios.chm", "Asignacion_Aplicaciones_Usuarios.html");

            //Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "AyudaAsignacionAplicacionesUsuarios.chm", "Asignacion_Aplicaciones_Usuarios.html");
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
            string pathAyuda = FindFileInDirectory(ayudaFolderPath, "frmAsignacionAplicaciones.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(pathAyuda))
            {
              
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, pathAyuda, "Asignacion_Aplicaciones.html");
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


        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
                     Btn_agregar.Enabled = true;
            Btn_buscar.Enabled = true;
            Btn_eliminar.Enabled = false;
            Btn_actualizar.Enabled = false;


            {
                try
                {
                    // Verificar si se seleccionaron filas
                    if (Dgv_asignaciones.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Por favor, selecciona al menos un permiso para eliminar.");
                        return;
                    }

                    // Recorrer cada fila seleccionada para eliminar
                    foreach (DataGridViewRow fila in Dgv_asignaciones.SelectedRows)
                    {
                        string sUsuario = fila.Cells["Usuarios"].Value.ToString();
                        string sAplicacion = fila.Cells["Aplicacion"].Value.ToString();

                        // Llamar al método que elimina los permisos
                        logic.funEliminarRegistroUA(sUsuario, sAplicacion); // Llamar a la lógica


                    }

                    actualizardatagriew(); // Refrescar la vista con los datos actualizados
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar permisos: {ex.Message}");
                }
                ReiniciarEstado();
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            Cbo_usuarios.Enabled = true;
            Cbo_aplicaciones.Enabled = true;
            Cbo_modulos.Enabled = true;
            Dgv_asignaciones.Enabled = true;
            Btn_actualizar.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_modificar.Enabled = false;
            Btn_limpiar.Enabled = true;

        }
        //Termina

        //Trabajado María José Véliz Ochoa, 9959-21-5909

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
                Btn_agregar.Enabled = true;
                Btn_buscar.Enabled = true;
                Btn_actualizar.Enabled = false;
                Btn_eliminar.Enabled = false;
                try
                {
                    foreach (DataGridViewRow Fila in Dgv_asignaciones.Rows)
                    {
                        string sUsuario = Fila.Cells["Usuarios"].Value.ToString();
                        string sAplicacion = Fila.Cells["Aplicacion"].Value.ToString();

                        string sIngresar = (bool)(Fila.Cells["Ingresar"].EditedFormattedValue) ? "1" : "0";
                        string sConsulta = (bool)(Fila.Cells["Consultar"].EditedFormattedValue) ? "1" : "0";
                        string sModificar = (bool)(Fila.Cells["Modificar"].EditedFormattedValue) ? "1" : "0";
                        string sEliminar = (bool)(Fila.Cells["Eliminar"].EditedFormattedValue) ? "1" : "0";
                        string sImprimir = (bool)(Fila.Cells["Imprimir"].EditedFormattedValue) ? "1" : "0";

                        // Llamar al método que actualiza los permisos en la base de datos
                        logic.funactualizarpermisos(sUsuario, sAplicacion, sIngresar, sConsulta, sModificar, sEliminar, sImprimir);
                    }

                    MessageBox.Show("Permisos actualizados correctamente.");
                    actualizardatagriew(); // Refrescar la vista con los datos actualizados
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar permisos: {ex.Message}");
                }

                limpieza();
                Dgv_asignaciones.Rows.Clear();

            }


        }
    //Termina 
}
