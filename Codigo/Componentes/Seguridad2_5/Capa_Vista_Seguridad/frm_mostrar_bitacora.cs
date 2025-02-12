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
    //Fernando García - 0901-21-581 - INICIO
    public partial class frm_mostrar_bitacora : Form
    {
        private string idUsuario; // Variable de clase para almacenar el idUsuario
        private logica logic; // variable para el filtro de busqueda
        public frm_mostrar_bitacora(string idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            logic = new logica(idUsuario);

            Cmb_columna.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_columna.SelectedIndex = -1;
            Txt_dato.Enabled = false;
            Lbl_ingresaundato.Visible = false;
            Dtp_hora.ShowUpDown = true;
            Dtp_hora.Format = DateTimePickerFormat.Custom;
            Dtp_hora.CustomFormat = "HH:mm";  // Formato de 24 horas
            Limpiar();
            // Inicializar el ComboBox con las opciones de filtrado
            Cmb_columna.Items.AddRange(new string[] { "Id", "Usuario", "Fecha", "Hora", "Host", "IP", "Acción", "Tabla", "Aplicacion" });
            Cmb_columna.SelectedIndex = 0;

            logica l = new logica(idUsuario);
            l.funinsertarabitacora(idUsuario, "Consulto bitacora", "tbl_bitacora", "1301");
            ActualizarBitacora();

            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_buscar, "Buscar en bitacora");
            ToolTip tborrar = new ToolTip();
            tborrar.SetToolTip(Btn_borrarfiltros, "Borrar filtros en bitacora");
            ToolTip tactualizar = new ToolTip();
            tactualizar.SetToolTip(Btn_actualizar, "Actualizar bitacora");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "Ayuda en la bitacora");
        }

        private void ActualizarBitacora()
        {
            Dgv_bitacora.DataSource = logic.consultaLogicaBitacora().Tables[0];
        }

        private void Frm_mostrar_bitacora_Load(object sender, EventArgs e)
        {
            Cmb_columna.SelectedIndex = -1;
            Dgv_bitacora.ScrollBars = ScrollBars.Both;
            Dgv_bitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se vuelve a llamar para actualizar bitacora
            ActualizarBitacora();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (Cmb_columna.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un campo para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string campo = ObtenerCampoFiltro();  // Obtener el campo seleccionado
                string valor = string.Empty;  // Inicializar el valor de búsqueda

                // Determinar el valor de búsqueda según el campo seleccionado
                if (campo == "fecha_bitacora")
                {
                    valor = Dtp_dato.Value.ToString("yyyy-MM-dd");
                }
                else if (campo == "hora_bitacora")
                {
                    // Obtener el valor ingresado en el DateTimePicker de hora
                    valor = Dtp_hora.Value.ToString("HH:mm");

                    // Si solo se ingresa la hora sin minutos, usar LIKE en la consulta SQL
                    if (Dtp_hora.Value.Minute == 0)
                    {
                        valor = Dtp_hora.Value.ToString("HH") + "%";  // Solo busca por la hora, sin los minutos
                    }
                }
                else
                {
                    valor = Txt_dato.Text;
                }

                // Realizar la búsqueda en la bitácora con el campo y el valor obtenidos
                Dgv_bitacora.DataSource = logic.consultaLogicaBitacoraFiltrada(campo, valor).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerCampoFiltro()
        {

            if (Cmb_columna.SelectedItem == null)
            {
                return "FK_id_usuario"; // Valor por defecto
            }

            switch (Cmb_columna.SelectedItem.ToString())
            {
                case "Id": return "Pk_id_bitacora";
                case "Usuario": return "FK_id_usuario";
                case "Fecha": return "fecha_bitacora";
                case "Hora": return "hora_bitacora";
                case "Host": return "host_bitacora";
                case "IP": return "ip_bitacora";
                case "Acción": return "accion_bitacora";
                case "Tabla": return "tabla";
                case "Aplicacion": return "fk_id_aplicacion";
                default: return "FK_id_usuario";
            }
        }

        private void Cbo_columna_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si no hay un elemento seleccionado, desactiva todo
            if (Cmb_columna.SelectedIndex == -1)
            {
                Txt_dato.Enabled = false;
                Txt_dato.Visible = false;
                Dtp_dato.Visible = false;
                Dtp_hora.Visible = false;
                Lbl_ingresaundato.Visible = false;
                return;
            }

            // Si el índice es 2, oculta y desactiva todos los controles
            if (Cmb_columna.SelectedIndex == 2)
            {
                Txt_dato.Visible = false;
                Txt_dato.Enabled = false;
                Dtp_dato.Visible = true;
                Dtp_hora.Visible = false;
                Lbl_ingresaundato.Visible = true;
            }
            // Si el índice es 3, muestra el selector de horas
            else if (Cmb_columna.SelectedIndex == 3)
            {
                Txt_dato.Visible = false;
                Txt_dato.Enabled = false;
                Dtp_dato.Visible = false;
                Dtp_hora.Visible = true;
                Lbl_ingresaundato.Visible = true;
            }
            // Para cualquier otro índice, muestra el campo de texto
            else
            {
                Txt_dato.Visible = true;
                Txt_dato.Enabled = true;
                Dtp_dato.Visible = false;
                Dtp_hora.Visible = false;
                Lbl_ingresaundato.Visible = true;
            }
        }

        private void Btn_borrarfiltros_Click(object sender, EventArgs e)
        {
            ActualizarBitacora();
            Limpiar();
        }

        private void Limpiar()
        {
            try
            {
                Cmb_columna.SelectedIndex = -1; // Deseleccionar
                Txt_dato.Text = string.Empty;
                Txt_dato.Enabled = false;
                Dtp_dato.Value = DateTime.Now;
                Dtp_dato.Visible = false;
                Dtp_hora.Value = DateTime.Now;
                Dtp_hora.Visible = false;
                ActualizarBitacora(); // Volver a cargar todos los datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar los campos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //------------------------------------------ Inicio: KATERYN DE LEON y Gabriela Suc ------------------------------------------
        private void btn_ayuda_Click(object sender, EventArgs e)
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
            string pathAyuda = FindFileInDirectory(ayudaFolderPath, "ayudaBitacora.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(pathAyuda))
            {
                MessageBox.Show("El archivo sí está.");
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, pathAyuda, "ayudaMostrarBitacora_2024.html");
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
    //FIN #########################
}
