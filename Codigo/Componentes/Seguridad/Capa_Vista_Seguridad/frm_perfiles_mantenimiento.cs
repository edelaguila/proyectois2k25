
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
    public partial class frm_perfiles_mantenimiento : Form
    {
        logica logic;

        public frm_perfiles_mantenimiento(string sidUsuario)
        {
            InitializeComponent();
            Btn_modificar.Enabled = false;
            Btn_actualizar.Enabled = false;
            Btn_cancelar.Enabled = false;
            logic = new logica(sidUsuario);
            //Txt_codigo.Enabled = false;
            //Txt_nombre.Enabled = false;
            //Txt_descipcion.Enabled = false;
            Btn_guardar.Enabled = false;
            Gpb_estado.Enabled = false;
            Btn_eliminar.Enabled = false;   // se agrega el boton eliminar 
            mostrarperfiles();

        }

        public frm_perfiles_mantenimiento()
        {
        }

        void limpiar()
        {
            Cbo_buscar.Text = "";
            Txt_codigo.Text = "";
            Txt_descipcion.Text = "";
            Txt_nombre.Text = "";
            Rdb_habilitado.Checked = false;
            Rdb_inhabilitado.Checked = false;
            Txt_codigo.Focus();
        }

        /*Ismar Cortez/
        /Mostrar perfiles*/
        void mostrarperfiles()
        {
            try
            {
                DataTable dtperfiles;

                dtperfiles = logic.Funmostrarperfiles();


                if (dtperfiles == null || dtperfiles.Rows.Count == 0)
                {
                    MessageBox.Show("No existen registros.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Dgv_perfiles.DataSource = dtperfiles;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }

        }
        /********************************************************************/


     

        private void Frm_perfiles_mantenimiento_Load(object sender, EventArgs e)
        {
            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(Btn_ingreso, "Crea un nuevo perfil");
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(Btn_guardar, "Guardar nuevo perfil");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_actualizar, "Actualizar el perfil");
            ToolTip tmodificar = new ToolTip();
            tmodificar.SetToolTip(Btn_modificar, "Modificar el perfil");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(Btn_cancelar, "Cancelar");
            ToolTip tborrar = new ToolTip();
            tborrar.SetToolTip(Btn_eliminar, "Elimina el perfil");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(Btn_salir, "Salir");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "Ayuda");

            Fun_cargar_busqueda();
        }

    

        private void rbhabilitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //Txt_codigo.Enabled=false;
            //Txt_nombre.Enabled = false;
            //Txt_descipcion.Enabled = false;

            if (Txt_codigo.Text == "")
            {
                MessageBox.Show("Falta el código");

                Btn_ingreso.Enabled = true;

            }


            if (Txt_nombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Perfil");

                Btn_ingreso.Enabled = true;

            }
            else if (Txt_descipcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion del Perfil");
                Btn_ingreso.Enabled = true;

            }

            else
            {
                string sestado = "";
                if (Rdb_habilitado.Checked)
                {
                    sestado = "1";
                }

                if (Rdb_inhabilitado.Checked)
                {
                   sestado = "0";
                }
                else
                {
                    sestado = "1";
                }

                logic.funingresarperfiles(Txt_codigo.Text.ToString(), Txt_nombre.Text.ToString(), Txt_descipcion.Text.ToString(), sestado.ToString());
                MessageBox.Show("Perfil Ingresado Correctamente");
                mostrarperfiles();
                limpiar();
                Gpb_buscarperfiles.Enabled = true;
                Btn_ingreso.Enabled = true;
                Btn_guardar.Enabled = false;
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (Txt_nombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Perfil");
                Btn_ingreso.Enabled = true;

            }
            else if (Txt_descipcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion del Perfil");
                Btn_ingreso.Enabled = true;

            }

            else
            {
                string sestado = "";
                if (Rdb_habilitado.Checked)
                {
                    sestado = "1";
                }

                if (Rdb_inhabilitado.Checked)
                {
                    sestado = "0";
                }
                else
                {
                   sestado = "1";
                }

                logic.funactualizar(Txt_codigo.Text.ToString(), Txt_nombre.Text.ToString(), Txt_descipcion.Text.ToString(), sestado.ToString());
                MessageBox.Show("Perfil Actualizado Correctamente");
                mostrarperfiles();
                Btn_modificar.Enabled = false;
                Btn_actualizar.Enabled = false;
                Btn_cancelar.Enabled = false;
                Btn_guardar.Enabled = false;
                Btn_ingreso.Enabled = true;
                //Txt_codigo.Enabled = false;
                //Txt_nombre.Enabled = false;
                //Txt_descipcion.Enabled = false;
                Gpb_estado.Enabled = false;
                limpiar();

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            //Txt_codigo.Enabled = true;
            Btn_ingreso.Enabled = false;
            Btn_actualizar.Enabled = false;
            Gpb_buscarperfiles.Enabled = false;
            Btn_modificar.Enabled = false;
            Rdb_habilitado.Checked = true;
            Rdb_inhabilitado.Checked = true;
            Gpb_estado.Enabled = true;
            //Txt_nombre.Enabled = true;
            //Txt_descipcion.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_cancelar.Enabled = true;

            //try
            //{
            //    DataTable dtValidarID = logic.funagregar();
            //    foreach (DataRow row in dtValidarID.Rows)
            //    {
            //        if (row[0].ToString() == "")
            //        {
            //            Txt_codigo.Text = "1";
            //        }
            //        else
            //        {
            //            Txt_codigo.Text = row[0].ToString();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex);
            //    return;
            //}
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            //Txt_codigo.Enabled = false;
            Btn_ingreso.Enabled = false;
            Btn_cancelar.Enabled = true;
            Btn_actualizar.Enabled = true;
            Btn_modificar.Enabled = false;
            //Txt_nombre.Enabled = true;
            //Txt_descipcion.Enabled = true;
            Rdb_habilitado.Enabled = true;
            Rdb_inhabilitado.Enabled = true;
            Gpb_estado.Enabled = true;
        }
        /* creado por Emerzon Garcia */
        private void btn_eli_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_codigo.Text))
            {
                // Confirmar antes de eliminar
                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este perfil?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    // Llamar al método de la capa lógica para eliminar el perfil
                    logic.funeliminarperfil(Txt_codigo.Text);
                    MessageBox.Show("Perfil Eliminado Correctamente");
                    mostrarperfiles();
                    // Opcionalmente, puedes desactivar botones o limpiar campos después de la eliminación
                    Btn_modificar.Enabled = false;
                    Btn_actualizar.Enabled = false;
                    Btn_cancelar.Enabled = false;
                    Btn_guardar.Enabled = false;
                    Btn_ingreso.Enabled = true;
                    //Txt_codigo.Enabled = false;
                    Gpb_estado.Enabled = false;  // Desactiva el grupo de radio buttons
                    limpiar();  // Limpiar campos
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un perfil para eliminar.");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            limpiar();
            Btn_modificar.Enabled = false;
            Btn_actualizar.Enabled = false;
            Btn_cancelar.Enabled = false;
            Btn_guardar.Enabled = false;
            //Txt_nombre.Enabled = false;
            //Txt_descipcion.Enabled = false;
            Gpb_buscarperfiles.Enabled = true;
            Btn_ingreso.Enabled = true;
            Gpb_estado.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //------------------------------------------ Inicio: KATERYN DE LEON y Gabriela Suc ------------------------------------------
        private void btn_ayuda_Click(object sender, EventArgs e)
        {

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
            string pathAyuda = FindFileInDirectory(ayudaFolderPath, "ayudaPerfiles.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(pathAyuda))
            {
              
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, pathAyuda, "ayudaPerfiles_2024.html");
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

        //**************************KEVIN LOPEZ***********************************
        private void btn_bsucarperfil_Click(object sender, EventArgs e)
        {
            string sperfil = Cbo_buscar.Text;

            if (string.IsNullOrWhiteSpace(sperfil))
            {
                MessageBox.Show("Por favor, ingrese un ID de perfil.");
                return;
            }

            try
            {
                DataTable dtModulos = logic.funconsultarperfil(sperfil);

                if (dtModulos == null || dtModulos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraro el perfil.");
                    return;
                }

                foreach (DataRow row in dtModulos.Rows)
                {
                    if (row[0] != DBNull.Value) Txt_codigo.Text = row[0].ToString();
                    if (row[1] != DBNull.Value) Txt_nombre.Text = row[1].ToString();
                    if (row[2] != DBNull.Value) Txt_descipcion.Text = row[2].ToString();
                    if (row[3] != DBNull.Value)
                    {
                        string estado = row[3].ToString();
                        if (estado == "1")
                        {
                            Rdb_habilitado.Checked = true;
                            Rdb_inhabilitado.Checked = false;
                        }
                        else if (estado == "0")
                        {
                            Rdb_habilitado.Checked = false;
                            Rdb_inhabilitado.Checked = true;
                        }
                    }
                }

                Btn_modificar.Enabled = true;
                Btn_guardar.Enabled = false;
                //Txt_codigo.Enabled = false;
                //Txt_nombre.Enabled = false;
                //Txt_descipcion.Enabled = false;
                Rdb_habilitado.Enabled = false;
                Rdb_inhabilitado.Enabled = false;
                Btn_eliminar.Enabled = true;
                Btn_ingreso.Enabled = false;
                Btn_cancelar.Enabled = true;
                Gpb_estado.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void Fun_cargar_busqueda()
        {
            try
            {

                DataTable dtPerfiles = logic.funconsultaLogPerfiles();
                Cbo_buscar.Items.Clear();
                foreach (DataRow row in dtPerfiles.Rows)
                {
                    Cbo_buscar.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar busqueda: " + ex.Message);
            }
        }

        //**************************FIN KEVIN LOPEZ***********************************
    }
}
