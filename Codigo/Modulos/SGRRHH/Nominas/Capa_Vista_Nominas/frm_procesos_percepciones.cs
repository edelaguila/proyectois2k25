using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Nominas;

namespace Capa_Vista_Nominas
{
    //Fernando Jose García de León  - 0901-21-581 INICIO
    public partial class frm_procesos_percepciones : Form
    {
        private Controlador cn = new Controlador();
        private int idSeleccionado = 0;
        private int excepcionActiva = 1;
        private int estadoActivo = 1;

        //Metodos para que se abra solamente una ventana y no multiples
        private static frm_procesos_percepciones instancia = null;
        public static frm_procesos_percepciones ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frm_procesos_percepciones();
            }
            return instancia;
        }
        public frm_procesos_percepciones()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            // Configurar el orden de tabulación
            Txt_concepto.TabIndex = 0;
            Cbo_tipo.TabIndex = 1;
            Cbo_aplicacion.TabIndex = 2;
            Btn_excepcion.TabIndex = 3;
            Txt_monto.TabIndex = 4;
            Btn_estado.TabIndex = 5;
            // Inicializar ComboBox al cargar el formulario
            ConfigurarComboBoxes();
            CargarDatos();
            // Inicializar los botones de excepción y estado como activos
            excepcionActiva = 1;
            estadoActivo = 1;
            Cbo_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_aplicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_clase.DropDownStyle = ComboBoxStyle.DropDownList;
            // Actualizar los botones para reflejar su estado activo
            ActualizarBotonExcepcion();
            ActualizarBotonEstado();
            // Inicializar los botones y campos como deshabilitados al cargar el formulario
            ConfigurarControles(false);
            // Crear un ToolTip
            ToolTip toolTip = new ToolTip();

            // Configuración de ToolTips para los botones
            toolTip.SetToolTip(Btn_insertar, "Insertar un nuevo registro");
            toolTip.SetToolTip(Btn_guardar, "Guardar el registro actual");
            toolTip.SetToolTip(Btn_editar, "Editar el registro seleccionado");
            toolTip.SetToolTip(Btn_eliminar, "Eliminar el registro seleccionado");
            toolTip.SetToolTip(Btn_excepcion, "Activar o desactivar la excepción");
            toolTip.SetToolTip(Btn_estado, "Activar o desactivar el estado");
        }

        // Método para habilitar o deshabilitar los controles
        private void ConfigurarControles(bool habilitar)
        {
            // Habilitar o deshabilitar los controles de texto
            Txt_concepto.Enabled = habilitar;
            Cbo_tipo.Enabled = habilitar;
            Cbo_aplicacion.Enabled = habilitar;
            Txt_monto.Enabled = habilitar;
            Cbo_clase.Enabled = habilitar;

            // Habilitar o deshabilitar los botones
            Btn_excepcion.Enabled = true; // Btn_excepcion permanece habilitado siempre
            Btn_excepcion.Enabled = habilitar;
            Btn_estado.Enabled = habilitar;
            Btn_guardar.Enabled = habilitar;
            Btn_editar.Enabled = habilitar;
            Btn_eliminar.Enabled = habilitar;
        }

        private void ConfigurarComboBoxes()
        {
            Cbo_tipo.Items.Clear();
            Cbo_tipo.Items.Add("Porcentaje");
            Cbo_tipo.Items.Add("Monto");

            Cbo_aplicacion.Items.Clear();
            Cbo_aplicacion.Items.Add("Todos");
            Cbo_aplicacion.Items.Add("Ninguno");

            Cbo_clase.Items.Clear();
            Cbo_clase.Items.Add("Percepción");
            Cbo_clase.Items.Add("Deducción");
        }

        private void CargarDatos()
        {
            try
            {
                DataTable dt = cn.funcConsultaLogicaDeduPerp();
                if (dt != null)
                {
                    Dgv_perp_dec.DataSource = dt;

                    // Buscar el último ID y sumarle 1 para el nuevo registro
                    if (dt.Rows.Count > 0)
                    {
                        int maxId = dt.AsEnumerable()
                            .Max(row => Convert.ToInt32(row["ID"]));
                        Txt_pk_dedu.Text = (maxId + 1).ToString();
                    }
                    else
                    {
                        Txt_pk_dedu.Text = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Error al cargar los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            idSeleccionado = 0;
            // Buscar el último ID en el DataGridView y sumarle 1
            if (Dgv_perp_dec.Rows.Count > 0)
            {
                int maxId = 0;
                foreach (DataGridViewRow row in Dgv_perp_dec.Rows)
                {
                    if (row.Cells["ID"].Value != null)
                    {
                        int currentId = Convert.ToInt32(row.Cells["ID"].Value);
                        if (currentId > maxId)
                            maxId = currentId;
                    }
                }
                Txt_pk_dedu.Text = (maxId + 1).ToString();
            }
            else
            {
                Txt_pk_dedu.Text = "1";
            }

            Txt_concepto.Text = "";
            Cbo_tipo.SelectedIndex = -1;
            Cbo_aplicacion.SelectedIndex = -1;
            Cbo_clase.SelectedIndex = -1;
            Txt_monto.Text = "";
            excepcionActiva = 1;
            estadoActivo = 1;
            ActualizarBotonExcepcion();
            ActualizarBotonEstado();
        }

        private void Btn_insertar_Click(object sender, EventArgs e)
        {
            // Habilitar controles cuando se presiona "Insertar"
            ConfigurarControles(true);
            LimpiarFormulario();
            Txt_concepto.Focus();
            Btn_editar.Enabled = false;
            Btn_eliminar.Enabled = false;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para editar");
                return;
            }
            Txt_concepto.Focus();
            Cbo_clase.Enabled = true;
            Txt_concepto.Enabled = true;
            Cbo_tipo.Enabled = true;
            Cbo_aplicacion.Enabled = true;
            Btn_excepcion.Enabled = true;
            Txt_monto.Enabled = true;
            Btn_estado.Enabled = true;
            Btn_guardar.Enabled = true;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos vacíos
                if (string.IsNullOrEmpty(Txt_concepto.Text) ||
                    Cbo_tipo.SelectedIndex == -1 ||
                    Cbo_aplicacion.SelectedIndex == -1 ||
                    Cbo_clase.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(Txt_monto.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                    return;
                }

                // Obtener valores de los campos
                string concepto = Txt_concepto.Text;
                string tipo = Cbo_tipo.SelectedItem.ToString();
                string aplicacion = Cbo_aplicacion.SelectedItem.ToString();
                string clase = Cbo_clase.SelectedItem.ToString();

                // Validar que el monto sea un número válido
                if (!float.TryParse(Txt_monto.Text, out float monto))
                {
                    MessageBox.Show("El monto debe ser un número válido");
                    return;
                }

                // Si idSeleccionado es 0, es un nuevo registro
                if (idSeleccionado == 0)
                {
                    // Insertar nuevo registro
                    cn.funcInsertarLogicaDeduPerp(clase, concepto, tipo, aplicacion, excepcionActiva, monto);
                    MessageBox.Show("Registro insertado exitosamente");
                    // Inicializar los botones de excepción y estado como activos
                    excepcionActiva = 1;
                    estadoActivo = 1;
                }
                else
                {
                    // Actualizar registro existente
                    cn.funcActualizarLogicaDeduPerp(idSeleccionado, clase, concepto, tipo, aplicacion, excepcionActiva, monto);
                    MessageBox.Show("Registro actualizado exitosamente");
                    // Inicializar los botones de excepción y estado como activos
                    excepcionActiva = 1;
                    estadoActivo = 1;
                }

                LimpiarFormulario();
                ConfigurarControles(false); // Deshabilitar controles después de guardar
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }


        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        cn.funcEliminarLogicaDeduPerp(idSeleccionado);
                        LimpiarFormulario();
                        CargarDatos();
                        MessageBox.Show("Registro eliminado exitosamente");
                        Btn_editar.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro para eliminar");
            }
        }

        private void Dgv_perp_dec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    idSeleccionado = Convert.ToInt32(Dgv_perp_dec.Rows[e.RowIndex].Cells["ID"].Value);
                    Txt_pk_dedu.Text = idSeleccionado.ToString(); // Añadir esta línea
                    Txt_concepto.Text = Dgv_perp_dec.Rows[e.RowIndex].Cells["Concepto"].Value.ToString();
                    Cbo_tipo.SelectedItem = Dgv_perp_dec.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
                    Cbo_aplicacion.SelectedItem = Dgv_perp_dec.Rows[e.RowIndex].Cells["Aplicacion"].Value.ToString();
                    Cbo_clase.SelectedItem = Dgv_perp_dec.Rows[e.RowIndex].Cells["Clase"].Value.ToString();

                    excepcionActiva = Convert.ToInt32(Dgv_perp_dec.Rows[e.RowIndex].Cells["Excepcion"].Value);
                    estadoActivo = Convert.ToInt32(Dgv_perp_dec.Rows[e.RowIndex].Cells["Estado"].Value);

                    ActualizarBotonExcepcion();
                    ActualizarBotonEstado();

                    Txt_monto.Text = Dgv_perp_dec.Rows[e.RowIndex].Cells["Monto"].Value.ToString();
                    Btn_editar.Enabled = true;
                    Btn_eliminar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar registro: " + ex.Message);
                }
            }
        }

        // Actualiza el texto y color del botón de Excepcion según su estado
        private void ActualizarBotonExcepcion()
        {
            Btn_excepcion.Text = excepcionActiva == 1 ? "Activado" : "Desactivado";
            Btn_excepcion.BackColor = excepcionActiva == 1 ? Color.LightGreen : Color.LightCoral;
        }

        // Actualiza el texto y color del botón de Estado según su estado
        private void ActualizarBotonEstado()
        {
            Btn_estado.Text = estadoActivo == 1 ? "Activado" : "Desactivado";
            Btn_estado.BackColor = estadoActivo == 1 ? Color.LightGreen : Color.LightCoral;
        }

        private void Cbo_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_aplicacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_procesos_percepciones_Load(object sender, EventArgs e)
        {

        }

        private void Btn_excepcionactivado_Click(object sender, EventArgs e)
        {
            excepcionActiva = excepcionActiva == 1 ? 0 : 1;
            ActualizarBotonExcepcion();
        }



        private void Btn_estadoactivado_Click(object sender, EventArgs e)
        {
            estadoActivo = estadoActivo == 1 ? 0 : 1;
            ActualizarBotonEstado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarFormulario(); // Limpia el formulario
            ConfigurarControles(false); // Deshabilita controles de edición

            // Reiniciar estados para excepcion y estado
            excepcionActiva = 1;
            estadoActivo = 1;
            ActualizarBotonExcepcion();
            ActualizarBotonEstado();

            // Opcionalmente, puedes volver a cargar los datos si es necesario
            CargarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //FIN - Fernando García 0901-21-581

    }
}
