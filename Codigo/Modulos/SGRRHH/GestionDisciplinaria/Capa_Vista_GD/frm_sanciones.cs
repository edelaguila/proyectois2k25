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
using Capa_Controlador_GD;

namespace Capa_Vista_GD
{
    public partial class frm_sanciones : Form
    {
        Controlador Ctrl;
        public frm_sanciones(string idUsuario)
        {
            InitializeComponent();
            Ctrl = new Controlador(idUsuario);

            Btn_Guardar.Enabled = false;
            Btn_Editar.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Cbo_idFalta.Enabled = false;
            Cbo_tipoSancion.Enabled = false;
            Cbo_operador.Enabled = false;
            Txt_descripcionSancion.Enabled = false;
            Dtp_fechaSancion.Enabled = false;
            Chk_sancion.Enabled = false;

        }

        private void CargarFaltas()
        {
            try
            {
                DataTable dtFaltas = Ctrl.funconsultalogicafaltas();
                Cbo_idFalta.Items.Clear();
                foreach (DataRow row in dtFaltas.Rows)
                {
                    Cbo_idFalta.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar faltas: " + ex.Message);
            }
        }

        private void Lbl_idFalta_Click(object sender, EventArgs e)
        {

        }

        //Chk_sancion
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_sancion.Checked)
            {
                // Si se marca, autocompleta ciertos campos
                Cbo_tipoSancion.SelectedItem = "Ninguna";
                Txt_descripcionSancion.Text = "No se aplica sanción";
            }
            else
            {
                // Si se desmarca, limpia los campos automáticos
                Txt_descripcionSancion.Clear();
                Cbo_tipoSancion.SelectedIndex = -1;
            }
        }

        private void Txt_tipoEvidencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_tipoEvidencia_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_idFalta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //**Para visualizar el reporte**
        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Form Reporte = new Frm_reporteSancion();
            Reporte.Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Declarar el ToolTip en el boton Ayuda
        private ToolTip toolTipAyuda = new ToolTip();

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
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
            string sPathAyuda = sfunFindFileInDirectory(sProjectPath, "AyudaSanciones.chm");

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

        // Declarar el ToolTip en el boton cancelar
        private ToolTip toolTip = new ToolTip();

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            // Mostrar el ToolTip en el boton limpiar
            toolTip.SetToolTip(Btn_Cancelar, "Boton cancelar ");
            limpiar();
            Dgv_sanciones.DataSource = null;
        }

        private void frm_sanciones_Load(object sender, EventArgs e)
        {
            CargarFaltas();
            CargarOperadores();

            //Listado de sanciones que se cargan en el combobox al iniciar el formulario
            List<string> tiposSanciones = new List<string>
            {
                "Ninguna",
                "Amonestación verbal",
                "Amonestación escrita",
                "Suspension de empleo y sueldo",
                "Traslado de Area/Departamento",
                "Inhabilitacion para ascenso",
                "Despido disciplinario",
                "Multa"
            };
            Cbo_tipoSancion.DataSource = tiposSanciones;
            Cbo_tipoSancion.SelectedIndex = 0;
        }

        private void CargarOperadores()
        {
            DataTable operadores = Ctrl.ControladorObtenerOperadores();

            // Agregamos una fila vacía al inicio para obligar a desplegar el combobox
            DataRow filaVacia = operadores.NewRow();
            filaVacia["pk_clave"] = 0;
            filaVacia["nombre_completo"] = ""; // Línea vacía visible en el combo
            operadores.Rows.InsertAt(filaVacia, 0);

            Cbo_operador.DataSource = operadores;
            Cbo_operador.DisplayMember = "nombre_completo";
            Cbo_operador.ValueMember = "pk_clave";
            Cbo_operador.SelectedIndex = 0; // Asegura que se seleccione la fila vacía por defecto
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            // Validación de campos requeridos
            if (Cbo_idFalta.SelectedIndex == -1 ||
                Cbo_tipoSancion.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(Txt_descripcionSancion.Text) ||
                Cbo_operador.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validacion para elegir un operador valido del combobox y evitar una excepcion un valor = 0
            if (Convert.ToInt32(Cbo_operador.SelectedValue) == 0)
            {
                MessageBox.Show("Debe seleccionar un operador válido.");
                return;
            }

            try
            {
                // Obtener datos
                int idFalta = Convert.ToInt32(Cbo_idFalta.SelectedItem);
                string tipoSancion = Cbo_tipoSancion.Text;
                string descripcion = Txt_descripcionSancion.Text.Trim();
                DateTime fecha = Dtp_fechaSancion.Value;
                int operador = Convert.ToInt32(Cbo_operador.SelectedValue);
                bool noSeAplicaSancion = Chk_sancion.Checked;

                Console.WriteLine($"Falta: {Cbo_idFalta.SelectedValue}, Operador: {Cbo_operador.SelectedValue}");

                // Enviar a controlador
                bool insertado = Controlador.funInsertarSancion(idFalta, tipoSancion, descripcion, fecha, noSeAplicaSancion, operador);

                if (insertado)
                {
                    MessageBox.Show("Sanción registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();

                    // Mostrar en DataGridView solo la sanción recién insertada
                    DataTable sancionReciente = Controlador.funObtenerUltimaSancion();
                    Dgv_sanciones.DataSource = sancionReciente;
                    FormatearDataGridView();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar la sanción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                // Captura cualquier excepción y la muestra
                MessageBox.Show("Ocurrió un error:\n" + ex.ToString());
                Console.WriteLine("ERROR: " + ex.ToString());
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            limpiar();
            liberarcontrol();
            Btn_Nuevo.Enabled = false;
            Btn_Guardar.Enabled = false;
            Dgv_sanciones.DataSource = null;

            // Cargar sanciones activas
            Dgv_sanciones.DataSource = Controlador.funObtenerSancionesActivas();
            FormatearDataGridView();
        }

        private void limpiar()
        {
            //Habilitar/Deshabilitar botones y controles
            Btn_Guardar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Editar.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Btn_Nuevo.Enabled = true;

            Cbo_idFalta.Enabled = false;
            Cbo_tipoSancion.Enabled = false;
            Cbo_operador.Enabled = false;
            Txt_descripcionSancion.Enabled = false;
            Dtp_fechaSancion.Enabled = false;
            Chk_sancion.Enabled = false;

            // Limpiar campos
            Cbo_idFalta.SelectedIndex = -1;
            Cbo_tipoSancion.SelectedIndex = -1;
            Txt_descripcionSancion.Clear();
            Dtp_fechaSancion.Value = DateTime.Now;
            Cbo_operador.SelectedIndex = -1;
            Chk_sancion.Checked = false;
        }

        private void Dgv_sanciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Dgv_sanciones.Rows[e.RowIndex];

                Cbo_idFalta.Text = row.Cells["ID Falta"].Value.ToString();
                Cbo_tipoSancion.Text = row.Cells["Tipo de Sancion"].Value.ToString();
                Txt_descripcionSancion.Text = row.Cells["Descripcion"].Value.ToString();
                Dtp_fechaSancion.Value = Convert.ToDateTime(row.Cells["Fecha"].Value);
                Chk_sancion.Checked = Convert.ToInt32(row.Cells["Estado"].Value) == 0;
                Cbo_operador.SelectedValue = row.Cells["ID Operador"].Value;
            }
        }

        private void FormatearDataGridView()
        {
            // Ajustar automáticamente todas las columnas al contenido
            Dgv_sanciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Columna 'Motivo' con un ancho fijo
            if (Dgv_sanciones.Columns.Contains("Descripcion"))
            {
                Dgv_sanciones.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                Dgv_sanciones.Columns["Descripcion"].Width = 240; // tamaño de la celda
            }

            // Columna 'Fecha' con un ancho fijo
            if (Dgv_sanciones.Columns.Contains("Fecha"))
            {
                Dgv_sanciones.Columns["Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                Dgv_sanciones.Columns["Fecha"].Width = 90;
            }

            // Columna 'ID Sancion' con un ancho fijo
            if (Dgv_sanciones.Columns.Contains("ID Sancion"))
            {
                Dgv_sanciones.Columns["ID Sancion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                Dgv_sanciones.Columns["ID Sancion"].Width = 65;
            }

            // Columna 'ID Falta' con un ancho fijo
            if (Dgv_sanciones.Columns.Contains("ID Falta"))
            {
                Dgv_sanciones.Columns["ID Falta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                Dgv_sanciones.Columns["ID Falta"].Width = 50;
            }

            // Columna 'Estado' con un ancho fijo
            if (Dgv_sanciones.Columns.Contains("Estado"))
            {
                Dgv_sanciones.Columns["Estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                Dgv_sanciones.Columns["Estado"].Width = 60;
            }

            // Columna 'ID Operador' con un ancho fijo
            if (Dgv_sanciones.Columns.Contains("ID Operador"))
            {
                Dgv_sanciones.Columns["ID Operador"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                Dgv_sanciones.Columns["ID Operador"].Width = 80;
            }

            // Centrar texto de columnas específicas
            if (Dgv_sanciones.Columns.Contains("ID Falta"))
                Dgv_sanciones.Columns["ID Falta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (Dgv_sanciones.Columns.Contains("ID Operador"))
                Dgv_sanciones.Columns["ID Operador"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (Dgv_sanciones.Columns.Contains("Tipo de Sancion"))
                Dgv_sanciones.Columns["Tipo de Sancion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (Dgv_sanciones.Columns.Contains("Estado"))
                Dgv_sanciones.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (Dgv_sanciones.Columns.Contains("ID Sancion"))
                Dgv_sanciones.Columns["ID Sancion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Colorear las filas inactivas (estado = 0)
            foreach (DataGridViewRow fila in Dgv_sanciones.Rows)
            {
                if (fila.Cells["Estado"].Value != null && fila.Cells["Estado"].Value.ToString() == "0")
                {
                    fila.DefaultCellStyle.BackColor = Color.MistyRose;
                    fila.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Btn_Nuevo.Enabled = false;
            Btn_Guardar.Enabled = true;
            Btn_Cancelar.Enabled = true;
            Cbo_idFalta.Enabled = true;
            Cbo_tipoSancion.Enabled = true;
            Cbo_operador.Enabled = true;
            Txt_descripcionSancion.Enabled = true;
            Dtp_fechaSancion.Enabled = true;
            Chk_sancion.Enabled = true;
            Dgv_sanciones.DataSource = null;
        }

        private void liberarcontrol()
        {
            Btn_Editar.Enabled = true;
            Btn_Eliminar.Enabled = true;
            Btn_Cancelar.Enabled = true;

            Cbo_idFalta.Enabled = true;
            Cbo_tipoSancion.Enabled = true;
            Cbo_operador.Enabled = true;
            Txt_descripcionSancion.Enabled = true;
            Dtp_fechaSancion.Enabled = true;
            Chk_sancion.Enabled = true;
        }

        private void Btn_MostrarEliminados_Click(object sender, EventArgs e)
        {
            limpiar();
            liberarcontrol();
            Btn_Nuevo.Enabled = false;
            Btn_Guardar.Enabled = false;
            Dgv_sanciones.DataSource = null;

            // Cargar sanciones inactivas (eliminadas)
            Dgv_sanciones.DataSource = Ctrl.funObtenerSancionesInactivas();
            FormatearDataGridView();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (Dgv_sanciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para editar.");
                return;
            }

            //validaciones de seguridad
            if (Cbo_idFalta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una falta.");
                return;
            }

            if (Cbo_tipoSancion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de sancion.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_descripcionSancion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción para la sanción.");
                return;
            }

            //Validacion para elegir un operador valido del combobox y evitar una excepcion un valor = 0
            if (Convert.ToInt32(Cbo_operador.SelectedValue) == 0)
            {
                MessageBox.Show("Debe seleccionar un operador válido.");
                return;
            }

            if (Cbo_operador.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un operador.");
                return;
            }

            // Recolectar los datos seleccionados
            int idSancion = Convert.ToInt32(Dgv_sanciones.SelectedRows[0].Cells["ID Sancion"].Value);
            int estadoActual = Convert.ToInt32(Dgv_sanciones.SelectedRows[0].Cells["Estado"].Value);

            int idFalta = Convert.ToInt32(Cbo_idFalta.SelectedItem);
            string tipoSancion = Cbo_tipoSancion.SelectedItem.ToString();
            string descripcion = Txt_descripcionSancion.Text;
            string fecha = Dtp_fechaSancion.Value.ToString("yyyy-MM-dd");
            int estado = Chk_sancion.Checked ? 0 : 1; // Si está marcado "No se aplica", entonces inactivo
            int idOperador = Convert.ToInt32(Cbo_operador.SelectedValue);

            // Preguntar si está restaurando
            if (estadoActual == 0 && estado == 1)
            {
                DialogResult result = MessageBox.Show(
                    "Este es un registro eliminado. ¿Está seguro que desea restaurarlo?",
                    "Confirmar restauración",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                Ctrl.funEditarSancion(idSancion, idFalta, tipoSancion, descripcion, fecha, estado, idOperador);
                MessageBox.Show("Sanción actualizada correctamente.");

                // Refrescar el DataGridView
                Dgv_sanciones.DataSource = Ctrl.funObtenerSancionPorId(idSancion);
                FormatearDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la sanción: " + ex.Message);
            }

            limpiar();
            Btn_Editar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Nuevo.Enabled = false;
            Btn_Cancelar.Enabled = true;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_sanciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
                return;
            }

            int idSancion = Convert.ToInt32(Dgv_sanciones.SelectedRows[0].Cells["ID Sancion"].Value);

            var confirmar = MessageBox.Show("¿Está seguro de eliminar esta sancion?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                if (Ctrl.funEliminarSanciones(idSancion))
                {
                    MessageBox.Show("Sancion eliminada (lógicamente).");
                    FormatearDataGridView();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la sancion.");
                }
            }

            limpiar();
            Dgv_sanciones.DataSource = null;
        }
    }
}
