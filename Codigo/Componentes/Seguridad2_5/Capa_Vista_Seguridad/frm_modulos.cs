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
    public partial class frmMantemientoMódulos : Form
    {
        logica logic;

        public frmMantemientoMódulos(string idUsuario)
        {
            InitializeComponent();
            Btn_modificar.Enabled = false;
            Btn_actualizar.Enabled = false;
            Btn_cancelar.Enabled = false;
            Btn_eliminar.Enabled = false; //se agrega
            logic = new logica(idUsuario);
            Txt_codigo.Enabled = false;
            Txt_descripcion.Enabled = false;
            Txt_nombre.Enabled = false;
            Btn_guardar.Enabled = false;
            Gpb_estado.Enabled = false;
            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(Btn_agregar, "Crear Módulo");
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(Btn_guardar, "Guardar Módulo");
            ToolTip tactualizar = new ToolTip();
            tactualizar.SetToolTip(Btn_modificar, "Actualizar Cambios");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_buscar, "Buscar Módulo");
            ToolTip teditar = new ToolTip();
            teditar.SetToolTip(Btn_modificar, "Modificar Módulo");
            ToolTip teliminar = new ToolTip();
            teliminar.SetToolTip(Btn_eliminar, "Eliminar Módulo");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(Btn_cancelar, "Limpiar/Cancelar");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(Btn_salir, "Salir Mantenimiento Módulos");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "Ayuda");
            mostrarmodulos();
        }

        public frmMantemientoMódulos()
        {
        }

        void limpiar()
        {
            Txt_buscar.Text = "";
            Txt_codigo.Text = "";
            Txt_nombre.Text = "";
            Txt_descripcion.Text = "";
            Rdb_habilitado.Checked = false;
            Rdb_inhabilitado.Checked = false;
            Txt_codigo.Focus();
        }

        /*********Ismar Cortez********************/
        /*********Mostrar modulos*******************/

        void mostrarmodulos()
        {
            try
            {
                DataTable dtmodulos;

                dtmodulos = logic.Funmostrarmodulos();


                if (dtmodulos == null || dtmodulos.Rows.Count == 0)
                {
                    MessageBox.Show("No existen registros.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Dgv_modulos.DataSource = dtmodulos;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }

        }

        /****************************************/


        private void Frm_modulos_Load(object sender, EventArgs e)
        {

        }

        //Trabajado por María José Véliz Ochoa, 9959-21-5909

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            Btn_agregar.Enabled = false;
            Btn_actualizar.Enabled = false;
            Gpb_buscar.Enabled = false;
            Btn_modificar.Enabled = false;
            Rdb_habilitado.Checked = true;
            Rdb_inhabilitado.Checked = true;
            Gpb_estado.Enabled = true;
            Txt_descripcion.Enabled = true;
            Txt_nombre.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_cancelar.Enabled = true;
            //habilitando para ingresar id
            Txt_codigo.Enabled = true;
            Btn_eliminar.Enabled = false; //se agrega


            //para errores tipo null
            try
            {
                DataTable dtvalidarid = logic.funvalidaridmodulos();
                if (dtvalidarid == null || dtvalidarid.Rows.Count == 0)
                {
                    //txtcodigo.Text = ""; // Asigna un valor por defecto si no se encuentra ningún ID
                    return;
                }
                foreach (DataRow row in dtvalidarid.Rows)
                {
                    if (row[0] != DBNull.Value)
                    {
                        Txt_codigo.Text = row[0].ToString();
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return;
            }
        }
        // FIN ####################################

        private void Rdb_habilitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_Click_1(object sender, EventArgs e)
        {
            Txt_nombre.Enabled = false;
            Txt_descripcion.Enabled = false;


            if (Txt_nombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Modulo");
                Btn_agregar.Enabled = true;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;

            }
            else if (Txt_descripcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion del modulo");
                Btn_agregar.Enabled = true;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;

            }

            else
            {
                string estado = "";
                if (Rdb_habilitado.Checked)
                {
                    estado = "1";
                }

                if (Rdb_inhabilitado.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                logic.funingresarmodulo(Txt_codigo.Text.ToString(), Txt_nombre.Text.ToString(), Txt_descripcion.Text.ToString(), estado.ToString());
                MessageBox.Show("Modulo Ingresado Correctamente");
                limpiar();
                Gpb_buscar.Enabled = true;
                Btn_agregar.Enabled = true;
                Btn_guardar.Enabled = false;
                Txt_codigo.Enabled = false;
                Btn_eliminar.Enabled = false; //se agrega
                mostrarmodulos();
            }
        }


        //Trabajado por Alyson Rodríguez, 9959-21-829
        private void Btn_actualizar_Click_1(object sender, EventArgs e)
        {
            if (Txt_descripcion.Text == "")
            {
                MessageBox.Show("Falta Nombre de Modulo");

                Btn_agregar.Enabled = true;
                Txt_descripcion.Enabled = false;
                Txt_nombre.Enabled = false;


            }
            else if (Txt_nombre.Text == "")
            {
                MessageBox.Show("Falta Descripcion del modulo");

                Btn_agregar.Enabled = true;
                Txt_descripcion.Enabled = false;
                Txt_nombre.Enabled = false;

            }

            else
            {
                string estado = "";
                if (Rdb_habilitado.Checked)
                {
                    estado = "1";
                }

                if (Rdb_inhabilitado.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                logic.funactualizarmodulo(Txt_codigo.Text.ToString(), Txt_descripcion.Text.ToString(), Txt_nombre.Text.ToString(), estado.ToString());
                MessageBox.Show("Modulo Actualizado Correctamente");
                Btn_modificar.Enabled = false;
                Btn_actualizar.Enabled = false;
                Btn_cancelar.Enabled = false;
                Btn_guardar.Enabled = false;
                Gpb_estado.Enabled = false;
                Btn_agregar.Enabled = true;
                Txt_codigo.Enabled = false;
                Txt_descripcion.Enabled = false;
                Txt_nombre.Enabled = false;
                Btn_eliminar.Enabled = false; //se agrega  ALyson #####################
                limpiar();
                mostrarmodulos();
            }
        }

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string sModulo = Txt_buscar.Text;

            if (string.IsNullOrWhiteSpace(sModulo))
            {
                MessageBox.Show("Por favor, ingrese un ID de módulo.");
                return;
            }
            //Para errores null del DataTable
            try
            {
                DataTable dtmodulos = logic.funconsultalogicamodulo(sModulo);

                if (dtmodulos == null || dtmodulos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron módulos.");
                    return;
                }

                foreach (DataRow row in dtmodulos.Rows)
                {// Asigna el valor de cada columna a su respectivo control en la interfaz si no es nulo
                    if (row[0] != DBNull.Value) Txt_codigo.Text = row[0].ToString();
                    if (row[1] != DBNull.Value) Txt_descripcion.Text = row[1].ToString();
                    if (row[2] != DBNull.Value) Txt_nombre.Text = row[2].ToString();
                    if (row[3] != DBNull.Value)
                    {
                        string sEstado = row[3].ToString();
                        if (sEstado == "1")
                        {
                            Rdb_habilitado.Checked = true;
                            Rdb_inhabilitado.Checked = false;
                        }
                        else if (sEstado == "0")
                        {
                            Rdb_habilitado.Checked = false;
                            Rdb_inhabilitado.Checked = true;
                        }
                    }
                }

                Btn_modificar.Enabled = true;
                Btn_guardar.Enabled = false;
                Txt_codigo.Enabled = false;
                Txt_descripcion.Enabled = false;
                Txt_nombre.Enabled = false;
                Rdb_habilitado.Enabled = false;
                Rdb_inhabilitado.Enabled = false;
                Btn_cancelar.Enabled = true;
                Btn_eliminar.Enabled = true; //se agrega

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex);
            }
        }

        //Trabajado por Alyson Rodríguez, 9959-21-829
        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            Txt_codigo.Enabled = false;
            Btn_cancelar.Enabled = true;
            Btn_actualizar.Enabled = true;
            Btn_modificar.Enabled = false;
            Txt_descripcion.Enabled = true;
            Txt_nombre.Enabled = true;
            Rdb_habilitado.Enabled = true;
            Rdb_inhabilitado.Enabled = true;
            Btn_agregar.Enabled = false;
            Gpb_estado.Enabled = true;
            Btn_eliminar.Enabled = false; //se agrega
        }

        //Trabajado por Alyson Rodríguez, 9959-21-829
        private void Btn_eliminar_Click_1(object sender, EventArgs e)
        {
            // Deshabilitar botones y campos según sea necesario
            Btn_agregar.Enabled = true;
            Btn_actualizar.Enabled = false;
            Gpb_buscar.Enabled = true;
            Btn_modificar.Enabled = false;
            Rdb_habilitado.Checked = false;
            Gpb_estado.Enabled = false;
            Txt_descripcion.Enabled = false;
            Txt_nombre.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_cancelar.Enabled = false;
            Txt_codigo.Enabled = false;
            Btn_eliminar.Enabled = false;

            // Validar el estado seleccionado
            string sEstado;
            if (Rdb_habilitado.Checked)
            {
                sEstado = "1"; // Habilitado
            }
            else if (Rdb_inhabilitado.Checked)
            {
                sEstado = "0"; // Inhabilitado
            }
            else
            {
                // Asignar un valor predeterminado si ninguno está seleccionado
                sEstado = "0"; // O "1", dependiendo de tu lógica
            }

            // Validar que se haya ingresado el ID del módulo
            if (string.IsNullOrEmpty(Txt_codigo.Text))
            {
                MessageBox.Show("Falta ID del Módulo");
                return; // Salir del método si falta el ID
            }

            try
            {
                // Llamar al método de la lógica de negocio para realizar el borrado lógico
                logic.funeliminarmodulo(Txt_codigo.Text.ToString(), Txt_descripcion.Text.ToString(), Txt_nombre.Text.ToString(), sEstado);

                MessageBox.Show("Módulo eliminado correctamente.");
                mostrarmodulos();
                limpiar(); // Limpia los campos del formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el módulo: " + ex.Message);
            }
        }
        // FIN BOTON ELIMINAR ####################################

        //María José para deshabilitar txt código
        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            Btn_modificar.Enabled = false;
            Btn_actualizar.Enabled = false;
            Btn_cancelar.Enabled = false;
            Btn_guardar.Enabled = false;
            Txt_descripcion.Enabled = false;
            Txt_nombre.Enabled = false;
            Gpb_buscar.Enabled = true;
            Btn_agregar.Enabled = true;
            Gpb_estado.Enabled = false;
            Txt_codigo.Enabled = false;
            Btn_eliminar.Enabled = false; //se agrega
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }

        //------------------------------------------ Inicio: KATERYN DE LEON y Gabriela Suc ------------------------------------------

        private void Btn_ayuda_Click(object sender, EventArgs e)
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
            string pathAyuda = FindFileInDirectory(ayudaFolderPath, "AyudaModulos.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(pathAyuda))
            {
               
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, pathAyuda, "ayudaModulos_2024.html");
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

    }

}
    



