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
using System.Security.Cryptography;
using System.IO; // Necesario para Directory, File, Path y SearchOption

namespace Capa_Vista_Seguridad
{
    public partial class frm_usuarios : Form
    {
        logica logica1;

        bool boton_ingreso = false;

        public frm_usuarios(string idUsuario)
        {
            InitializeComponent();
            logica1 = new logica(idUsuario);

            // Configurar el ComboBox con las opciones exactas que se usan en la base de datos
            Cmb_Pregunta.Items.Clear();
            Cmb_Pregunta.Items.AddRange(new string[] {
            "Color favorito",
            "Nombre de familiar",
            "Nombre de mascota"
        });
            Cmb_Pregunta.DropDownStyle = ComboBoxStyle.DropDownList;
            // Asociar el evento KeyPress a los TextBox
            Txt_nomb.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            Txt_apellido.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            Txt_respuesta.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            Txt_buscar.KeyPress += new KeyPressEventHandler(txt_buscar_KeyPress);
            funmostrarusuarios();
            Rdb_activos.CheckedChanged += Rdb_activos_CheckedChanged;
            Rdb_inactivos.CheckedChanged += Rdb_inactivos_CheckedChanged;
            Rdb_activos.Checked = true;
        }

        public frm_usuarios()
        {
        }

        private void Dgv_asignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }



        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string buscar;


        void limpiar()
        {
            Txt_id.Text = "";
            Txt_nombreusername.Text = "";
            Txt_buscar.Text = "";
            Txt_clave.Text = "";
            Txt_apellido.Text = "";
            Txt_nomb.Text = "";

            Txt_correo.Text = "";
            Rdb_habilitado.Checked = false;
            Rdb_inhabilitado.Checked = false;
            Dgv_usuarios.Columns.Clear();
            //txt_estadousuario.Text = "";
            // txt_pregunta.Text = "";
            Txt_respuesta.Text = "";
            Cmb_Pregunta.SelectedIndex = -1;
        }

        void limpiarsindgv()
        {
            Txt_id.Text = "";
            Txt_nombreusername.Text = "";
            Txt_buscar.Text = "";
            Txt_clave.Text = "";
            Txt_apellido.Text = "";
            Txt_nomb.Text = "";

            Txt_correo.Text = "";
            Rdb_habilitado.Checked = false;
            Rdb_inhabilitado.Checked = false;
            Txt_respuesta.Text = "";
            Cmb_Pregunta.SelectedIndex = -1;

        }


        /********************Ismar Cortez*****************************************************/

        private void Rdb_activos_CheckedChanged(object sender, EventArgs e)
        {
            funmostrarusuarios();
        }

        private void Rdb_inactivos_CheckedChanged(object sender, EventArgs e)
        {
            funmostrarusuarios();
        }
        void funmostrarusuarios()
        {
            try
            {
                DataTable dtusuario;
                if (string.IsNullOrEmpty(buscar))
                {
                    string estadoFiltro;
                    // Verificar qué RadioButton está seleccionado
                    if (Rdb_activos.Checked)
                        estadoFiltro = "1";
                    else if (Rdb_inactivos.Checked)
                        estadoFiltro = "0";
                    else
                        estadoFiltro = "todos"; // Por si ninguno está seleccionado

                    dtusuario = logica1.funconsultaLogicaUsuarios(estadoFiltro);
                }
                else
                {
                    dtusuario = logica1.buscar(buscar);
                }

                if (dtusuario == null || dtusuario.Rows.Count == 0)
                {
                    MessageBox.Show("No existen registros.", "Verificación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Dgv_usuarios.DataSource = dtusuario;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al encontrar usuarios " + ex.Message);
            }      
    }
    /****************************************************************************************/

    private void Button1_Click_1(object sender, EventArgs e)
        {
            buscar = Txt_buscar.Text.Trim();

            try
            {
                DataTable dtusuario;

                if (string.IsNullOrEmpty(buscar))
                {
                    dtusuario = logica1.funconsultaLogicaUsuarios();
                }
                else
                {
                    dtusuario = logica1.buscar(buscar);
                }

                if (dtusuario == null || dtusuario.Rows.Count == 0)
                {
                    MessageBox.Show("No existen registros.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Dgv_usuarios.DataSource = dtusuario;

                    if (dtusuario != null && dtusuario.Rows.Count > 0)
                    {
                        DataRow row = dtusuario.Rows[0];

                        Txt_id.Text = row["Usuario"].ToString();
                        Txt_nomb.Text = row["Nombre"].ToString();
                        Txt_apellido.Text = row["Apellido"].ToString();
                        Txt_correo.Text = row["Email"].ToString();
                        Txt_respuesta.Text = row["Respuesta"].ToString();
                        Txt_nombreusername.Text = row["Username"].ToString();
                        Txt_clave.Text = row["Password"].ToString();

                        if (row["Estado"].ToString() == "1")
                        {
                            Rdb_habilitado.Checked = true;
                        }
                        else
                        {
                            Rdb_inhabilitado.Checked = true;
                        }

                        // Asignar la pregunta al ComboBox de manera simple
                        string preguntaDB = row["Pregunta"].ToString();
                        Cmb_Pregunta.SelectedItem = preguntaDB;

                        // Si la pregunta no está en la lista, añadirla
                        if (Cmb_Pregunta.SelectedIndex == -1)
                        {
                            Cmb_Pregunta.Items.Add(preguntaDB);
                            Cmb_Pregunta.SelectedItem = preguntaDB;
                        }

                        Txt_nomb.Enabled = true;
                        Txt_apellido.Enabled = true;
                        Txt_correo.Enabled = true;
                        txt_estadousuario.Enabled = true;
                        Txt_nombreusername.Enabled = false;
                        Txt_clave.Enabled = false;
                        Cmb_Pregunta.Enabled = true;
                        Txt_respuesta.Enabled = true;
                        Btn_modificar.Enabled = true;
                        Btn_eliminar.Enabled = true;
                        Btn_salir.Enabled = true;
                        Btn_guardar.Enabled = false;
                        Btn_nuevo.Enabled = true;
                        Rdb_habilitado.Enabled = true;
                        Rdb_inhabilitado.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_usuarios_Load(object sender, EventArgs e)
        {
            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(Btn_nuevo, "Crear nuevo usuario");
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(Btn_guardar, "Guardar nuevo usuario");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_buscar, "Buscar usuario");
            ToolTip tremover = new ToolTip();
            tremover.SetToolTip(Btn_eliminar, "Eliminar usuario");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(Btn_salir, "Salir");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "Ayuda");
            ToolTip teditar = new ToolTip();
            teditar.SetToolTip(Btn_modificar, "Modificar usuario");

            Txt_buscar.Enabled = true;
            Txt_id.Enabled = false;
            Btn_buscar.Enabled = true;
            Txt_nombreusername.Enabled = false;
            Txt_clave.Enabled = false;
            Txt_apellido.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_eliminar.Enabled = false;

            Txt_nombreusername.Enabled = false;
            Txt_nomb.Enabled = false;

            Txt_correo.Enabled = false;
            txt_estadousuario.Enabled = false;
            //txt_pregunta.Enabled = false;
            Txt_respuesta.Enabled = false;
            Cmb_Pregunta.Enabled = false;
            Rdb_habilitado.Enabled = false;
            Rdb_inhabilitado.Enabled = false;
            Dgv_usuarios.CellClick += Dgv_usuarios_CellClick;
            Btn_buscar.Click += Button1_Click_1;

            // Orden de tabulaciones
            Btn_buscar.TabIndex = 0;
            Btn_nuevo.TabIndex = 1; // Botón Nuevo
            Btn_guardar.TabIndex = 2;
            Btn_modificar.TabIndex = 3;
            Btn_eliminar.TabIndex = 4;
            Btn_salir.TabIndex = 5;

            Txt_nombreusername.TabIndex = 6;
            Txt_clave.TabIndex = 7;
            Txt_nomb.TabIndex = 8;
            Txt_apellido.TabIndex = 9;
            Txt_correo.TabIndex = 10;

            Rdb_habilitado.TabIndex = 11;
            Rdb_inhabilitado.TabIndex = 12;

            Cmb_Pregunta.TabIndex = 13;
            Txt_respuesta.TabIndex = 14;

            //limitar caracteres
            Txt_nomb.MaxLength = 50; // Limita el texto a 50 caracteres
            Txt_apellido.MaxLength = 50;
            Txt_nombreusername.MaxLength = 20;
            Txt_correo.MaxLength = 50;
            Txt_respuesta.MaxLength = 50;
            Txt_clave.MaxLength = 50;
        }


        //---------------------------------------------------- Inicio: GABRIELA SUC ----------------------------------------------------

        private void Button2_Click(object sender, EventArgs e)
        {   //Botón ELIMINAR

            // Botón ELIMINAR
            string idUsuario = Txt_id.Text.Trim(); // Eliminar usando el ID real del usuario

            if (string.IsNullOrEmpty(idUsuario))
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                // Llamar a la capa lógica para cambiar el estado del usuario
                bool resultado = logica1.EliminarUsuario(idUsuario);

                if (resultado)
                {
                    MessageBox.Show("El usuario ha sido eliminado correctamente (cambiado a estado Inactivo).", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar(); // Limpiar los campos después de la actualización
                    Dgv_usuarios.DataSource = logica1.funconsultaLogicaUsuarios(); // Actualizar DataGridView
                }
                else
                {
                    MessageBox.Show("Hubo un error al intentar eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            funmostrarusuarios();
            limpiarsindgv();
            Txt_nomb.Enabled = false;
            Txt_apellido.Enabled = false;
            Txt_correo.Enabled = false;
            Rdb_habilitado.Enabled = false;
            Rdb_inhabilitado.Enabled = false;
            Cmb_Pregunta.Enabled = false;
            Txt_respuesta.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_eliminar.Enabled = false;
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            // Botón MODIFICAR
            // Valida todos los campos antes de continuar
            if (!ValidarCampos())
            {
                return; // Si hay un error, no continúa
            }
            DialogResult result = MessageBox.Show("¿Está seguro de modificar este registro?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                // Obtener los valores de los controles
                string idUsuario = Txt_id.Text.Trim();
                string nombre = Txt_nomb.Text.Trim();
                string apellido = Txt_apellido.Text.Trim();
                string correo = Txt_correo.Text.Trim();
                string respuesta = Txt_respuesta.Text.Trim();
                int estado_usuario = Rdb_habilitado.Checked ? 1 : 0; // Estado del usuario

                // Asegúrate de obtener la pregunta del ComboBox
                string preguntaSeleccionada = Cmb_Pregunta.SelectedItem?.ToString(); // Si no está seleccionada, retorna null

                if (string.IsNullOrEmpty(idUsuario))
                {
                    MessageBox.Show("Debe seleccionar un usuario para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verifica si la pregunta es válida antes de proceder
                if (string.IsNullOrEmpty(preguntaSeleccionada))
                {
                    MessageBox.Show("Debe seleccionar una pregunta de seguridad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar a la lógica para modificar
                bool exito = logica1.ModificarUsuario(idUsuario, nombre, apellido, correo, estado_usuario, preguntaSeleccionada, respuesta);

                if (exito)
                {
                    MessageBox.Show("Registro modificado con éxito.", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    //Dgv_usuarios.DataSource = logica1.consultaLogicaUsuarios(); // Actualizar el DataGridView después de la modificación
                    Btn_modificar.Enabled = false;
                    Btn_eliminar.Enabled = false;
                    Txt_nomb.Enabled = false;
                    Txt_apellido.Enabled = false;
                    Txt_correo.Enabled = false;
                    Rdb_habilitado.Enabled = false;
                    Rdb_inhabilitado.Enabled = false;
                    Cmb_Pregunta.Enabled = false;
                    Txt_respuesta.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al intentar modificar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //---------------------------------------------------- Fin: GABRIELA SUC ----------------------------------------------------

        public string id, nombre, apellido, clave, correo, estadousuario, pregunta, respuesta;

        private void txt_estadousuario_TextChanged(object sender, EventArgs e)
        {

        }


        //------------------------------------------ Inicio: KATERYN DE LEON y Gabriela Suc ------------------------------------------
        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            // Obtener la ruta del directorio del ejecutable
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Retroceder a la carpeta del proyecto
            string projectPath = Path.GetFullPath(Path.Combine(executablePath, @"..\..\"));
            MessageBox.Show("1" + projectPath);

            // Combinar con la ruta fija de "asis22k24proy2\Codigo\Componentes\Seguridad"
            //string basePath = Path.Combine(projectPath, @"asis22k24proy2\Codigo\Componentes\Seguridad");
            //MessageBox.Show("2" + basePath);


            string ayudaFolderPath = Path.Combine(projectPath, "Ayuda_Seguridad");

            // Imprimir la ruta de ayuda para verificar
            //MessageBox.Show("3: " + ayudaFolderPath);

            // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
            string pathAyuda = FindFileInDirectory(ayudaFolderPath, "ayudaUsuarios.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(pathAyuda))
            {
                MessageBox.Show("El archivo sí está.");
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, pathAyuda, "ayudaUsuarios_2024.html");
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

        //------------------------------------------ Fin KATERYN DE LEON y Gabriela Suc ------------------------------------------

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.CampoAlfanumerico(e);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //BOTON NUEVO

            Txt_id.Enabled = false;

            Txt_clave.Enabled = true;
            Txt_nomb.Enabled = true;
            Txt_apellido.Enabled = true;
            Txt_nombreusername.Enabled = true;

            Txt_buscar.Enabled = true;
            Btn_buscar.Enabled = true;
            Btn_eliminar.Enabled = false;
            Btn_modificar.Enabled = false;
            boton_ingreso = true;
            Btn_guardar.Enabled = true;


            Rdb_inhabilitado.Enabled = true;
            Rdb_habilitado.Enabled = true;
            Txt_correo.Enabled = true;
            txt_estadousuario.Enabled = true;
            Cmb_Pregunta.Enabled = true;
            Txt_respuesta.Enabled = true;

            Btn_nuevo.Enabled = false;

            //limpiar

            limpiarsindgv();

        }

        private string HashPasswordSHA256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void cmb_Pregunta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
  
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //**********************Kateryn De León************************/
            // BOTON GUARDAR

            // Valida todos los campos antes de continuar
            if (!ValidarCampos())
            {
                return; // Si hay un error, no continúa
            }

            nombre = Txt_nomb.Text;////nombre usuario
            apellido = Txt_apellido.Text;
            id = Txt_nombreusername.Text;// nombre username
            clave = Txt_clave.Text;
            correo = Txt_correo.Text;  // Nueva línea para el correo
            DateTime fechaActual = DateTime.Now;
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
            string estadousuario = "";//guarda lo del txt

            pregunta = Cmb_Pregunta.SelectedItem.ToString(); // Asignar la pregunta seleccionada en cmb;  // Nueva línea para la pregunta de seguridad
            respuesta = Txt_respuesta.Text;  // Nueva línea para la respuesta de seguridad

            // int boton;

            if (Txt_nomb.Text == " " || Txt_nombreusername.Text == "" || Txt_apellido.Text == "" || Txt_clave.Text == "")//corregir aca
            {
                MessageBox.Show("Faltan Campos Por Llenar", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (clave.Length < 8)
            {
                MessageBox.Show("La contraseña debe de contener 8 caracteres como mínimo", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (boton_ingreso == true)//boton_ingreso
                {
                    // boton = 1;

                    try
                    {
                        // Hash de la clave con SHA-256
                        string claveHasheada = HashPasswordSHA256(clave);

                        // Asegúrate de pasar la clave hasheada a la lógica

                        if (Rdb_habilitado.Checked)
                        {
                            estadousuario = "1";
                        }

                        if (Rdb_inhabilitado.Checked)
                        {
                            estadousuario = "0";
                        }
                        else
                        {
                            estadousuario = "1";
                        }

                        // Asegúrate de pasar todos los parámetros necesarios
                        DataTable dtusuario = logica1.usuarios(nombre, apellido, id, claveHasheada, correo, fecha, estadousuario, pregunta, respuesta);

                       // // Mostrar el mensaje en un MessageBox
                       // MessageBox.Show(mensaje, "Detalles del Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Usuario creado correctamente", "Nuevo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Actualiza el DataGridView para mostrar el nuevo usuario
                        funmostrarusuarios();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        return;
                    }
                }


                limpiarsindgv();
                Txt_clave.Enabled = false;
                Txt_nomb.Enabled = false;
                Txt_apellido.Enabled = false;
                Txt_nombreusername.Enabled = false;
                Txt_buscar.Enabled = true;
                Btn_guardar.Enabled = false;
                Btn_buscar.Enabled = true;
                Btn_eliminar.Enabled = false;
                Btn_modificar.Enabled = false;
                Btn_nuevo.Enabled = true;
                Btn_salir.Enabled = true;
                Btn_ayuda.Enabled = true;
                Txt_correo.Enabled = false;
                txt_estadousuario.Enabled = false;
                Txt_respuesta.Enabled = false;
                Rdb_habilitado.Enabled = false;
                Rdb_inhabilitado.Enabled = false;
                Txt_respuesta.Enabled = false;
                Cmb_Pregunta.Enabled = false;
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Fernando García - 0901-21-581 inicio
        private void Dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se haya seleccionado una fila válida
            {
                DataGridViewRow row = Dgv_usuarios.Rows[e.RowIndex];

                // Asignar valores a los TextBox
                Txt_id.Text = row.Cells["Usuario"].Value.ToString();
                Txt_nomb.Text = row.Cells["Nombre"].Value.ToString();
                Txt_apellido.Text = row.Cells["Apellido"].Value.ToString();
                Txt_correo.Text = row.Cells["Email"].Value.ToString();
                Txt_respuesta.Text = row.Cells["Respuesta"].Value.ToString();
                Txt_nombreusername.Text = row.Cells["Username"].Value.ToString();
                Txt_clave.Text = row.Cells["Password"].Value.ToString();

                // Asignar el estado a los RadioButton
                if (row.Cells["Estado"].Value.ToString() == "1")
                {
                    Rdb_habilitado.Checked = true;
                }
                else
                {
                    Rdb_inhabilitado.Checked = true;
                }

                // Asignar la pregunta de seguridad al ComboBox
                Cmb_Pregunta.SelectedItem = row.Cells["Pregunta"].Value.ToString();

                // Habilitar los TextBox y otros controles
                Txt_nomb.Enabled = true;
                Txt_apellido.Enabled = true;
                Txt_correo.Enabled = true;
                Txt_respuesta.Enabled = true;
                Cmb_Pregunta.Enabled = true;
                Rdb_habilitado.Enabled = true;
                Rdb_inhabilitado.Enabled = true;
                Btn_modificar.Enabled = true;
                Btn_eliminar.Enabled = true;
            }
        }

        private bool ValidarCampos()
        {
            // Validar campos de texto
            if (string.IsNullOrWhiteSpace(Txt_nomb.Text) ||
                string.IsNullOrWhiteSpace(Txt_apellido.Text) ||
                string.IsNullOrWhiteSpace(Txt_nombreusername.Text) ||
                string.IsNullOrWhiteSpace(Txt_clave.Text) ||
                string.IsNullOrWhiteSpace(Txt_correo.Text) ||
                string.IsNullOrWhiteSpace(Txt_respuesta.Text))
            {
                MessageBox.Show("Todos los campos de texto son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar ComboBox de pregunta de seguridad
            if (Cmb_Pregunta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una pregunta de seguridad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que un RadioButton esté seleccionado
            if (!Rdb_habilitado.Checked && !Rdb_inhabilitado.Checked)
            {
                MessageBox.Show("Debe seleccionar el estado del usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar el formato del correo electrónico
            if (!EsCorreoValido(Txt_correo.Text))
            {
                MessageBox.Show("El formato del correo electrónico es incorrecto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Todos los campos son válidos
        }

        // Función auxiliar para validar el formato del correo electrónico
        private bool EsCorreoValido(string correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch
            {
                return false;
            }
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es una letra o una tecla de control como backspace
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Si no es una letra, espacio o tecla de control, cancela el evento
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es un número o si es la tecla de Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número o la tecla de retroceso, cancelar el evento
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //Fernando García - 0901-21-581 fin
    }
}
