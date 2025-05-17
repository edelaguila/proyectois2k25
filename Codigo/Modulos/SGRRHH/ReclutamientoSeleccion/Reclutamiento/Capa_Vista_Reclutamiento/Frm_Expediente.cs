using Capa_Controlador_Reclutamiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_Reclutamiento
{
    public partial class Frm_Expediente : Form
    {
       
        Controlador controlador = new Controlador();
        logica logicaSeg = new logica();

        public string idUsuario { get; set; }
        public Frm_Expediente()
        {
            InitializeComponent();
            LlenarComboPostulantes();
            Dgv_VisualizarDatos.DataSource = controlador.Pro_obtenerExpedientes();

            //inicia con los botones blockeados excepto el de agregar

            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_cancelar.Enabled = false;
            Btn_seleccionarCV.Enabled = false;
            Btn_SeleccionarEntrevista.Enabled = false;
            Btn_SeleccionarPruebas.Enabled = false;

            Txt_idexpediente.Enabled = false;
           // Cmb_Idpostulante.Enabled = false;
            Txt_Curriculum.Enabled = false;
            Txt_DocEntrevista.Enabled = false;
            Txt_pruebaLogica.Enabled = false;
            Txt_pruebaNumerica.Enabled = false;
            Txt_pruebaVerbal.Enabled = false;
            Txt_pruebaRazonamiento.Enabled = false;
            Txt_pruebaTecnologica.Enabled = false;
            Cmb_PruebaPersonalidad.Enabled = false;

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            Btn_guardar.Enabled = true;          
            Btn_cancelar.Enabled = true;
            Btn_seleccionarCV.Enabled = true;
            Btn_SeleccionarEntrevista.Enabled = true;
            Btn_SeleccionarPruebas.Enabled = true;


            Txt_idexpediente.Enabled = true;
            Cmb_Idpostulante.Enabled = true;
            Txt_Curriculum.Enabled = true;
            Txt_DocEntrevista.Enabled = true;
            Txt_pruebaLogica.Enabled = true;
            Txt_pruebaNumerica.Enabled = true;
            Txt_pruebaVerbal.Enabled = true;
            Txt_pruebaRazonamiento.Enabled = true;
            Txt_pruebaTecnologica.Enabled = true;
            Cmb_PruebaPersonalidad.Enabled = true;
            LimpiarCampos();

            logicaSeg.funinsertarabitacora(idUsuario, "Se inicio un nuevo registro en expedientes", "tbl_expedientes", "13005");
        }
            // Función para limpiar los campos
            private void LimpiarCampos()
            {
                Txt_idexpediente.Clear();
                Txt_Curriculum.Clear();
                Txt_DocEntrevista.Clear();
                Txt_DocPruebas.Clear();

                Txt_pruebaLogica.Clear();
                Txt_pruebaNumerica.Clear();
                Txt_pruebaVerbal.Clear();
                Txt_pruebaRazonamiento.Clear();
                Txt_pruebaTecnologica.Clear();

                Cmb_Idpostulante.SelectedIndex = -1;
                Cmb_PruebaPersonalidad.SelectedIndex = -1;
            }

        private void Btn_seleccionarCV_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del cuadro de diálogo para abrir archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configura el filtro para los tipos de archivo, por ejemplo, PDF
            openFileDialog.Filter = "Archivos PDF|*.pdf|Todos los archivos|*.*";

            // Muestra el cuadro de diálogo para seleccionar un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Asigna la ruta completa del archivo seleccionado al TextBox
                Txt_Curriculum.Text = openFileDialog.FileName;
            }
        }
        private void LlenarComboPostulantes()
        {
            var lista = controlador.ObtenerListaPostulantes();

            Cmb_Idpostulante.DataSource = lista;
            Cmb_Idpostulante.DisplayMember = "Value"; // lo que se muestra (nombre)
            Cmb_Idpostulante.ValueMember = "Key";     // el ID real
        }

        private void Btn_SeleccionarEntrevista_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos PDF|*.pdf|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Txt_DocEntrevista.Text = openFileDialog.FileName;
            }
        }

        private void Btn_SeleccionarPruebas_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos PDF|*.pdf|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Txt_DocPruebas.Text = openFileDialog.FileName;
            }
        }

        private void Btn_VerCv_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Idpostulante.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un postulante antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idPostulante = (int)Cmb_Idpostulante.SelectedValue;
                controlador.VerArchivoPDF("curriculum", idPostulante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar visualizar el currículum.\nDetalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_DocEntrevista_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Idpostulante.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un postulante antes de ver el documento de entrevista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idPostulante = (int)Cmb_Idpostulante.SelectedValue;
                controlador.VerArchivoPDF("documento_entrevista", idPostulante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar visualizar el documento de entrevista.\nDetalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_DocPruebas_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Idpostulante.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un postulante antes de ver el documento de pruebas psicométricas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idPostulante = (int)Cmb_Idpostulante.SelectedValue;
                controlador.VerArchivoPDF("pruebas_psicometricas", idPostulante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar visualizar las pruebas psicométricas.\nDetalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Expediente_Load(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Idpostulante.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un postulante antes de guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int pkPostulante = (int)Cmb_Idpostulante.SelectedValue;

                //Validar si ya existe expediente para este postulante
                if (controlador.Pro_expedienteExiste(pkPostulante))
                {
                    MessageBox.Show("Este postulante ya tiene un expediente registrado.", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string pathCurriculum = Txt_Curriculum.Text;
                string pathEntrevista = Txt_DocEntrevista.Text;
                string pathPruebas = Txt_DocPruebas.Text;

                // Validar campos numéricos: si están vacíos o inválidos, poner 0
                int logica = int.TryParse(Txt_pruebaLogica.Text, out int l) ? l : 0;
                int numerica = int.TryParse(Txt_pruebaNumerica.Text, out int n) ? n : 0;
                int verbal = int.TryParse(Txt_pruebaVerbal.Text, out int v) ? v : 0;
                int razonamiento = int.TryParse(Txt_pruebaRazonamiento.Text, out int r) ? r : 0;
                int tecnologica = int.TryParse(Txt_pruebaTecnologica.Text, out int t) ? t : 0;

                string personalidad = Cmb_PruebaPersonalidad.Text;

                controlador.Pro_guardar(pkPostulante, pathCurriculum, pathEntrevista,
                    logica, numerica, verbal, razonamiento, tecnologica, personalidad, pathPruebas);

                Dgv_VisualizarDatos.DataSource = controlador.Pro_obtenerExpedientes();
                LimpiarCampos();
                logicaSeg.funinsertarabitacora(idUsuario, "Se guardo un nuevo registro", "tbl_expedientes", "13005");

                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_eliminar.Enabled = false;
                Btn_cancelar.Enabled = false;
                Btn_seleccionarCV.Enabled = false;
                Btn_SeleccionarEntrevista.Enabled = false;
                Btn_SeleccionarPruebas.Enabled = false;

                Txt_idexpediente.Enabled = false;
                Txt_Curriculum.Enabled = false;
                Txt_DocEntrevista.Enabled = false;
                Txt_pruebaLogica.Enabled = false;
                Txt_pruebaNumerica.Enabled = false;
                Txt_pruebaVerbal.Enabled = false;
                Txt_pruebaRazonamiento.Enabled = false;
                Txt_pruebaTecnologica.Enabled = false;
                Cmb_PruebaPersonalidad.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Dgv_VisualizarDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idPostulante = Convert.ToInt32(Dgv_VisualizarDatos.Rows[e.RowIndex].Cells["Fk_id_postulante"].Value);
                CargarDatosDelPostulante(idPostulante);
                Btn_agregar.Enabled = false;
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = true;
                Btn_cancelar.Enabled = true;
                Btn_eliminar.Enabled = true;
                Btn_seleccionarCV.Enabled = true;
                Btn_SeleccionarEntrevista.Enabled = true;
                Btn_SeleccionarPruebas.Enabled = true;

                Txt_idexpediente.Enabled = true;
                Cmb_Idpostulante.Enabled = true;
                Txt_Curriculum.Enabled = true;
                Txt_DocEntrevista.Enabled = true;
                Txt_pruebaLogica.Enabled = true;
                Txt_pruebaNumerica.Enabled = true;
                Txt_pruebaVerbal.Enabled = true;
                Txt_pruebaRazonamiento.Enabled = true;
                Txt_pruebaTecnologica.Enabled = true;
                Cmb_PruebaPersonalidad.Enabled = true;
            }
        }

        private void CargarDatosDelPostulante(int id)
        {
            var datos = controlador.Pro_ObtenerExpedientePorId(id);

            if (datos != null)
            {
                Txt_idexpediente.Text = datos["Pk_id_expediente"].ToString();
                Cmb_Idpostulante.SelectedValue = datos["Fk_id_postulante"]; 

                Txt_Curriculum.Text = datos["curriculum"].ToString(); 
                Txt_DocEntrevista.Text = datos["documento_entrevista"].ToString(); 

                Txt_pruebaLogica.Text = datos["prueba_logica"].ToString();
                Txt_pruebaNumerica.Text = datos["prueba_numerica"].ToString();
                Txt_pruebaVerbal.Text = datos["prueba_verbal"].ToString();
                Txt_pruebaRazonamiento.Text = datos["razonamiento"].ToString();
                Txt_pruebaTecnologica.Text = datos["prueba_tecnologica"].ToString();

                Cmb_PruebaPersonalidad.SelectedItem = datos["prueba_personalidad"].ToString();
                Txt_DocPruebas.Text = datos["pruebas_psicometricas"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró información del postulante.");
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                int idExpediente = int.Parse(Txt_idexpediente.Text.Trim());

                if (Cmb_Idpostulante.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un postulante antes de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int pkPostulante = (int)Cmb_Idpostulante.SelectedValue;

                string pathCurriculum = Txt_Curriculum.Text;
                string pathEntrevista = Txt_DocEntrevista.Text;
                string pathPruebas = Txt_DocPruebas.Text;

                int logica = double.TryParse(Txt_pruebaLogica.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double l) ? (int)l : 0;
                int numerica = double.TryParse(Txt_pruebaNumerica.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double n) ? (int)n : 0;
                int verbal = double.TryParse(Txt_pruebaVerbal.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double v) ? (int)v : 0;
                int razonamiento = double.TryParse(Txt_pruebaRazonamiento.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double r) ? (int)r : 0;
                int tecnologica = double.TryParse(Txt_pruebaTecnologica.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double t) ? (int)t : 0;

                string personalidad = Cmb_PruebaPersonalidad.Text;

                // Confirmación antes de actualizar
                DialogResult confirm = MessageBox.Show(
                    "¿Está seguro de que desea actualizar este expediente?",
                    "Confirmar actualización",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.No)
                {
                    MessageBox.Show("Actualización cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logicaSeg.funinsertarabitacora(idUsuario, "Se modificó un registro", "tbl_expedientes", "13005");
                    return;
                }

                controlador.Pro_actualizar(
                    idExpediente,
                    pkPostulante,
                    pathCurriculum,
                    pathEntrevista,
                    logica,
                    numerica,
                    verbal,
                    razonamiento,
                    tecnologica,
                    personalidad,
                    pathPruebas
                );

                Dgv_VisualizarDatos.DataSource = controlador.Pro_obtenerExpedientes();
                LimpiarCampos();

                Btn_agregar.Enabled = true;
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_eliminar.Enabled = false;
                Btn_cancelar.Enabled = false;

                Txt_idexpediente.Enabled = false;
                Txt_Curriculum.Enabled = false;
                Txt_DocEntrevista.Enabled = false;
                Txt_pruebaLogica.Enabled = false;
                Txt_pruebaNumerica.Enabled = false;
                Txt_pruebaVerbal.Enabled = false;
                Txt_pruebaRazonamiento.Enabled = false;
                Txt_pruebaTecnologica.Enabled = false;
                Cmb_PruebaPersonalidad.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_idexpediente.Text))
                {
                    MessageBox.Show("Debe seleccionar un expediente para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idExpediente = int.Parse(Txt_idexpediente.Text.Trim());

                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este expediente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No)
                    return;

                // Llamada al método de eliminación en el controlador
                controlador.Pro_eliminarExpediente(idExpediente);

                MessageBox.Show("Expediente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dgv_VisualizarDatos.DataSource = controlador.Pro_obtenerExpedientes(); // refrescar vista
                LimpiarCampos();

                Btn_agregar.Enabled = true;
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_eliminar.Enabled = false;
                Btn_cancelar.Enabled = false;

                Txt_idexpediente.Enabled = false;
                Txt_Curriculum.Enabled = false;
                Txt_DocEntrevista.Enabled = false;
                Txt_pruebaLogica.Enabled = false;
                Txt_pruebaNumerica.Enabled = false;
                Txt_pruebaVerbal.Enabled = false;
                Txt_pruebaRazonamiento.Enabled = false;
                Txt_pruebaTecnologica.Enabled = false;
                Cmb_PruebaPersonalidad.Enabled = false;
                logicaSeg.funinsertarabitacora(idUsuario, "Se eliminó un registro", "tbl_expedientes", "13005");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el expediente. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
    "¿Está seguro de que desea cancelar? Se perderán los datos no guardados.",
    "Confirmar cancelación",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question
);

            if (resultado == DialogResult.Yes)
            {
                LimpiarCampos();
                Btn_agregar.Enabled = true;
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_eliminar.Enabled = false;
                Btn_cancelar.Enabled = false;

                
                Txt_idexpediente.Enabled = false;
                Txt_Curriculum.Enabled = false;
                Txt_DocEntrevista.Enabled = false;
                Txt_pruebaLogica.Enabled = false;
                Txt_pruebaNumerica.Enabled = false;
                Txt_pruebaVerbal.Enabled = false;
                Txt_pruebaRazonamiento.Enabled = false;
                Txt_pruebaTecnologica.Enabled = false;
                Cmb_PruebaPersonalidad.Enabled = false;

                logicaSeg.funinsertarabitacora(idUsuario, "Se cancelo una operación", "tbl_expedientes", "13005");
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (Cmb_Idpostulante.SelectedItem is KeyValuePair<int, string> seleccionado)
            {
                int idPostulante = seleccionado.Key;
                CargarDatosDelPostulante(idPostulante);

                // Desmarcar todas las filas primero
                foreach (DataGridViewRow fila in Dgv_VisualizarDatos.Rows)
                {
                    fila.Selected = false;
                }

                // Buscar y seleccionar la fila correspondiente
                foreach (DataGridViewRow fila in Dgv_VisualizarDatos.Rows)
                {
                    if (fila.Cells["Fk_id_postulante"].Value != null &&
                        int.TryParse(fila.Cells["Fk_id_postulante"].Value.ToString(), out int id) &&
                        id == idPostulante)
                    {
                        fila.Selected = true;
                        Dgv_VisualizarDatos.FirstDisplayedScrollingRowIndex = fila.Index;
                        break;
                    }
                }
                logicaSeg.funinsertarabitacora(idUsuario, "Se hizó una busqueda de registro", "tbl_expedientes", "13005");
            }
            else
            {
                MessageBox.Show("Seleccione un nombre válido.");
            }

        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            logicaSeg.funinsertarabitacora(idUsuario, "Se cerró el formulario", "tbl_expedientes", "13005");
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte reporte = new Frm_Reporte();
            reporte.Show();
            logicaSeg.funinsertarabitacora(idUsuario, "Se consultó el reporte", "tbl_expedientes", "13005");
        }

        // Declarar el ToolTip en el boton Ayuda
        private ToolTip toolTipAyuda = new ToolTip();
        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            // Mostrar el ToolTip en el boton ayuda
            toolTipAyuda.SetToolTip(Btn_ayuda, " Documento de ayuda ");

            // Obtener la ruta del directorio del ejecutable
            string sExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Retroceder a la carpeta del proyecto
            string sProjectPath = Path.GetFullPath(Path.Combine(sExecutablePath, @"..\..\..\..\..\..\Ayuda\"));
            //  MessageBox.Show("1" + sProjectPath);


            string sAyudaFolderPath = Path.Combine(sProjectPath, "Ayuda Reclutamiento");

            string sPathAyuda = funFindFileInDirectory(sAyudaFolderPath, "AyudaExpedientes.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(sPathAyuda))
            {
                // MessageBox.Show("El archivo sí está.");
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, sPathAyuda, "AyudaExpedietes.html");
                logicaSeg.funinsertarabitacora(idUsuario, "Se consultó la ayuda", "tbl_expedientes", "13005");
            }
            else
            {
                // Si el archivo no existe, muestra un mensaje de error
                MessageBox.Show("El archivo de ayuda no se encontró.");
            }


        }

        private string funFindFileInDirectory(string sDirectory, string sFileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(sDirectory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] sFiles = Directory.GetFiles(sDirectory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in sFiles)
                    {
                        if (Path.GetFileName(file).Equals(sFileName, StringComparison.OrdinalIgnoreCase))
                        {
                            // MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {   //Mensaje de No se encontro la carpeta
                    // MessageBox.Show("No se encontró la carpeta: " + sDirectory);
                }
            }
            catch (Exception ex)
            {       //Mensaje de error al buscar el archivo
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }

    }
}

