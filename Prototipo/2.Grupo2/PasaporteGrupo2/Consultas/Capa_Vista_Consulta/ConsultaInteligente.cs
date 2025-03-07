using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Consulta;
using System.Data.Odbc;

namespace Capa_Vista_Consulta
{
    public partial class ConsultaInteligente : Form
    {
        consultaControlador csControlador = new consultaControlador();
        private string[] datos;
        private string[] datosComplejo;
        private string[] tipos;
        private string consultaSeleccionada;
        public string BD;

        public ConsultaInteligente(string Tabla)
        {
            InitializeComponent();
            BD = Tabla;
            tipos = new string[] { "consultaInteligente_nombre_consulta", "consultaInteligente_tipo_consulta", "consultaInteligente_consulta_SQLE", "consultaInteligente_consulta_estatus" };
            csControlador.CargarTablas(cboTabla, BD);
            csControlador.CargarTablas(cboEditarTabla, BD);
            cboTabla.SelectedIndexChanged += new EventHandler(cboTabla_SelectedIndexChanged);
            cboEditarTabla.SelectedIndexChanged += new EventHandler(cboTablaEditar_SelectedIndexChanged);
            chbCondiciones.CheckedChanged += chbCondiciones_CheckedChanged;
            gbCondiciones.Enabled = false;
            Gpb_Ordenar.Enabled = false;
            Gpb_ListadoConsultas.Enabled = true;
            Gpb_EditarLogica.Enabled = false;
            Gpb_EditarComparacion.Enabled = false;
            Gpb_EditarOrden.Enabled = false;
            csControlador.obtenerNombresConsultas(cboQuery1);
            cboQuery1.SelectedIndexChanged += new EventHandler(cboConsultas_SelectedIndexChanged);
            csControlador.obtenerNombresConsultas(cboQuery3);
            cboQuery3.SelectedIndexChanged += new EventHandler(cboConsultas_SelectedIndexChanged);
            csControlador.obtenerNombresConsultas(cboEditarNombreConsulta);
            cboEditarNombreConsulta.SelectedIndexChanged += new EventHandler(cboConsultas_SelectedIndexChanged);
            llenarComboLogico(cboLogico);
            llenarComboComparador(cboComparador);
            llenarComboOrden(cboOrdenar);
            llenarComboLogico(cboEditarLogico);
            llenarComboComparador(cboEditarComparador);
            llenarComboOrden(cboEditarOrdenar);
            ActualizarComboBox();
            //Creado por Sebastian Luna
            var tt = new ToolTip();
            tt.SetToolTip(btnEliminar, "Borrar");
            tt.SetToolTip(btnActualizar, "Actualizar");
            tt.SetToolTip(btnBuscarQuery, "Buscar");
            tt.SetToolTip(btnBuscarQuery1, "Buscar");
            tt.SetToolTip(btnEditarSimple, "Agregar");
            tt.SetToolTip(btnEditarLogico, "Agregar");
            tt.SetToolTip(btnEditarOrdenar, "Agregar");
            tt.SetToolTip(btnEditarComparacion, "Agregar");
            tt.SetToolTip(btnEditarCampoSimple, "Agregar Campos");
            tt.SetToolTip(btnCancelarEditarSimple, "Cancelar");
            tt.SetToolTip(btnCancelarEditarLogico, "Cancelar");
            tt.SetToolTip(btnCancelarEditarComparacion, "Cancelar");
            tt.SetToolTip(btnCancelarEditarOrdenar, "Cancelar");
            tt.SetToolTip(btnCancelarEditar, "Borrar");
            tt.SetToolTip(btnEditar, "Editar");
            tt.SetToolTip(btnConsultarEditar, "Consular");
            tt.SetToolTip(btnNuevo, "Agregar");
            tt.SetToolTip(brnAgregarLogica, "Agregar");
            tt.SetToolTip(btnAgregarComparacion, "Agregar");
            tt.SetToolTip(btnAgregarOrden, "Agregar");
            tt.SetToolTip(btnAgregarConsultaSimple, "Agregar Campos");
            tt.SetToolTip(btnCancelarSimple, "Cancelar");
            tt.SetToolTip(btnCancelarLogica, "Cancelar");
            tt.SetToolTip(btnCancelarComparacion, "Cancelar");
            tt.SetToolTip(btnCancelarOrden, "Cancelar");
            tt.SetToolTip(btnCancelar, "Borrar");
            tt.SetToolTip(btnCrear, "Crear");
            tt.SetToolTip(btnConsultar, "Consular");
        }
        private void ActualizarComboBox()
        {
            csControlador.obtenerNombresConsultas(cboQuery1);
            csControlador.obtenerNombresConsultas(cboQuery3);
            csControlador.obtenerNombresConsultas(cboEditarNombreConsulta);
        }
        string tabla = "tbl_consultaInteligente";
        private void cboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una tabla
            if (!string.IsNullOrEmpty(cboTabla.Text))
            {
                // Llama al método para llenar el segundo ComboBox con las columnas de la tabla seleccionada
                csControlador.obtenerColumbasPorTabla(cboCampos, cboTabla.Text);
                csControlador.obtenerColumbasPorTabla(cboComparadorCampo, cboTabla.Text);
                csControlador.obtenerColumbasPorTabla(cboLogicoCampo, cboTabla.Text);
                csControlador.obtenerColumbasPorTabla(cboOrdenarCampo, cboTabla.Text);
            }
        }
        private void llenarComboLogico(ComboBox comboBox1)
        {
            comboBox1.Items.Add("Seleccionar"); comboBox1.Items.Add("OR");
            comboBox1.Items.Add("AND"); comboBox1.Items.Add("NOT"); comboBox1.SelectedIndex = 0;
        }
        private void llenarComboComparador(ComboBox comboBox1)
        {
            comboBox1.Items.Add("Seleccionar"); comboBox1.Items.Add("WHERE");comboBox1.SelectedIndex = 0;
        }
        private void llenarComboOrden(ComboBox comboBox1)
        {
            comboBox1.Items.Add("Seleccionar"); comboBox1.Items.Add("Ordenar"); comboBox1.Items.Add("Agrupar"); comboBox1.SelectedIndex = 0;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //boton agregar, consulta simple
            try
            {
                datos = new string[] { txtNombreConsulta.Text, "0", cboTabla.Text, chbTodosCampos.Text, txtQueryFinal.Text, "1" };
                string camposSeleccionados;// Inicializamos la variable para los campos que se mostrarán en el query
                if (chbTodosCampos.Checked)// Verificamos si el CheckBox de 'Todos los campos' está marcado
                {
                    camposSeleccionados = "*";// Si está marcado, mostramos "Todos los campos"
                }
                else
                {
                    // Si no está marcado, verificamos si hay un campo seleccionado en el ComboBox
                    if (!string.IsNullOrEmpty(cboCampos.Text))
                    {
                        // Si hay un campo seleccionado, lo mostramos
                        camposSeleccionados = cboCampos.Text;
                    }
                    else
                    {
                        // Si no hay campo seleccionado, dejamos un valor vacío o un mensaje de advertencia
                        MessageBox.Show("Debe seleccionar o un campo o todos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (string.IsNullOrEmpty(txtQuery.Text))
                {
                    // Si txtQuery está vacío, asignamos el valor inicial
                    txtQuery.Text = camposSeleccionados + " + " + txtAlias.Text + " + ";
                    datos[4] = txtQuery.Text;
                }
                else
                {
                    // Si txtQuery ya tiene texto, agregamos el nuevo valor sin repetir el nombre de la consulta y el tipo
                    txtQuery.Text += Environment.NewLine + camposSeleccionados + " + " + txtAlias.Text + " + ";
                    datos[4] += txtQuery.Text;
                }
                // Procesar los datos en la tabla correspondiente
                csControlador.ingresar(tipos, datos, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chbCondiciones_CheckedChanged(object sender, EventArgs e)
        {
            bool habilitarControles = chbCondiciones.Checked;
            gbCondiciones.Enabled = habilitarControles;
            Gpb_Ordenar.Enabled = habilitarControles;
            Gpb_ListadoConsultas.Enabled = habilitarControles;
            Gpb_EditarLogica.Enabled = habilitarControles;
            Gpb_EditarOrden.Enabled = habilitarControles;
            if (datos != null && datos.Length > 0)
            {
                datos[1] = "1";
                Console.WriteLine("Se habilitó la consulta Compleja.");
            }
        }

        private void btnAgregarComparacion_Click(object sender, EventArgs e)
        {
            try
            {
                datosComplejo = new string[] { cboComparador.Text, cboComparadorCampo.Text, txtValorComparador.Text, txtQueryFinal.Text };
                csControlador.ingresar(tipos, datosComplejo, tabla);
                string queryGenerado = csControlador.GenerarQueryComplejo(datosComplejo, datos);
                txtQueryFinal.Clear(); txtQueryFinal.Text = queryGenerado; datosComplejo = new string[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void brnAgregarLogica_Click(object sender, EventArgs e)
        {
            try
            {
                datosComplejo = new string[] { cboLogico.Text, cboLogicoCampo.Text, txtValorLogico.Text, txtQueryFinal.Text };
                csControlador.ingresar(tipos, datosComplejo, tabla);
                string queryGenerado = csControlador.GenerarQueryComplejo(datosComplejo, datos);
                txtQueryFinal.Clear(); txtQueryFinal.Text = queryGenerado; datosComplejo = new string[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregarConsultaSimple_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtQuery.Text))
                {
                    MessageBox.Show("Por favor, ingrese una consulta válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string queryGenerado = csControlador.GenerarQuerySimple(datos);
                txtQueryFinal.Text = queryGenerado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                csControlador.InsertarDatos(tipos, datos, tabla);
                ActualizarComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            // Inicializar el array de datos
            try
            {
                datosComplejo = new string[] { cboOrdenar.Text, cboOrdenarCampo.Text, "0", txtQueryFinal.Text };
                // Verificar el tipo de operación
                if (cboOrdenar.Text == "Ordenar")
                {
                    datosComplejo[0] = "ORDER BY";
                    if (chbOrdenAscendente.Checked)
                    {
                        datosComplejo[2] = "ASC"; // Agregar ASC si está seleccionado
                    }
                    else if (chbOrdenDescendente.Checked)
                    {
                        datosComplejo[2] = "DESC"; // Agregar DESC si está seleccionado
                    }
                    else
                    {
                        MessageBox.Show("Si se desea agregar un ordenamiento, debe seleccionar el tipo.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (cboOrdenar.Text == "Agrupar")
                {
                    datosComplejo[0] = "GROUP BY"; // Indicar que es una operación de agrupamiento
                }
                else
                {
                    MessageBox.Show("Antes de agregar debe asignar valores.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                csControlador.ingresar(tipos, datosComplejo, tabla);
                string queryGenerado = csControlador.GenerarQueryComplejo(datosComplejo, datos);
                txtQueryFinal.Clear(); txtQueryFinal.Text = queryGenerado; datosComplejo = new string[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreConsulta.Text))
                {
                    MessageBox.Show("Por favor, ingrese una consulta válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                consultaControlador controlador = new consultaControlador();
                string querySeleccionado = txtNombreConsulta.Text;
                controlador.BuscarQuerySeleccionado(querySeleccionado, dgvConsultar, txtQueryFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaInteligente_Load(object sender, EventArgs e)
        {

        }

        private void creciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void chbEditarDescendente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarSimple_Click(object sender, EventArgs e)
        {
            datos = new string[0];
            txtNombreConsulta.Clear();
            cboTabla.ResetText();
            cboCampos.ResetText();
            txtAlias.Clear();
            chbTodosCampos.Checked = false;
            txtQuery.Clear();
        }

        private void btnCancelarLogica_Click(object sender, EventArgs e)
        {
            datos = new string[0];
            datosComplejo = new string[0];
            txtQueryFinal.Clear();
            cboLogico.ResetText();
            cboLogicoCampo.ResetText();
            txtValorLogico.Clear();
        }

        private void btnCancelarComparacion_Click(object sender, EventArgs e)
        {
            datos = new string[0];
            datosComplejo = new string[0];
            txtQueryFinal.Clear();
            cboComparador.ResetText();
            cboComparadorCampo.ResetText();
            txtValorComparador.Clear();
        }

        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {
            datos = new string[0];
            datosComplejo = new string[0];
            txtQueryFinal.Clear();
            cboOrdenar.ResetText();
            cboOrdenarCampo.ResetText();
            chbOrdenAscendente.Checked = false;
            chbOrdenDescendente.Checked = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            datos = new string[0];
            datosComplejo = new string[0];
            txtNombreConsulta.Clear();
            cboTabla.ResetText();
            cboCampos.ResetText();
            txtAlias.Clear();
            chbTodosCampos.Checked = false;
            cboLogico.ResetText();
            cboLogicoCampo.ResetText();
            txtValorLogico.Clear();
            cboComparador.ResetText();
            cboComparadorCampo.ResetText();
            txtValorComparador.Clear();
            cboOrdenar.ResetText();
            cboOrdenarCampo.ResetText();
            chbOrdenAscendente.Checked = false;
            chbOrdenDescendente.Checked = false;
            txtQuery.Clear();
            txtQueryFinal.Clear();
        }



        //SALVADOR MARTÍNEZ // PESTAÑA DE EDITAR

        private void cboTablaEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una tabla
            if (!string.IsNullOrEmpty(cboEditarTabla.Text))
            {
                // Llama al método para llenar el segundo ComboBox con las columnas de la tabla seleccionada
                csControlador.obtenerColumbasPorTabla(cboEditarCampo, cboEditarTabla.Text);
                csControlador.obtenerColumbasPorTabla(cboEditarCampoComparador, cboEditarTabla.Text);
                csControlador.obtenerColumbasPorTabla(cboEditarCampoLogico, cboEditarTabla.Text);
                csControlador.obtenerColumbasPorTabla(cboEditarCampoOrdenar, cboEditarTabla.Text);
            }
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            // Asegúrate de que consultaSeleccionada tiene un valor válido
            try
            {
                if (string.IsNullOrEmpty(consultaSeleccionada))
                {
                    MessageBox.Show("Debe seleccionar una consulta para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Actualiza datos con la consulta seleccionada
                datos[0] = consultaSeleccionada; // Suponiendo que datos[0] es el nombre de la consulta
                                                 // Procesar los datos en la tabla correspondiente
                csControlador.ActualizarDatos(tipos, datos, tabla);
                ActualizarComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Captura el nombre de la consulta seleccionada
            string nombreConsulta = cboQuery1.Text;
            string nombreConsulta1 = cboQuery3.Text;
            string nombreConsulta2 = cboEditarNombreConsulta.Text;
            // Guardar el nombre de la consulta en una variable de instancia
            consultaSeleccionada = nombreConsulta;
            consultaSeleccionada = nombreConsulta1;
            consultaSeleccionada = nombreConsulta2;
        }
        private void btnEditarSimple_Click(object sender, EventArgs e)
        {
            //boton agregar, consulta simple
            // Datos que se van a procesar
            try
            {
                datos = new string[] { cboEditarNombreConsulta.Text, "0", cboEditarTabla.Text, chbTodosCampos.Text, txtQueryEditadoFinal.Text, "1" };
                // Inicializamos la variable para los campos que se mostrarán en el query
                string camposSeleccionados;
                // Verificamos si el CheckBox de 'Todos los campos' está marcado
                if (chbEditarTodosCampos.Checked)
                {
                    // Si está marcado, mostramos "Todos los campos"
                    camposSeleccionados = "*";
                }
                else
                {
                    // Si no está marcado, verificamos si hay un campo seleccionado en el ComboBox
                    if (!string.IsNullOrEmpty(cboEditarCampo.Text))
                    {
                        // Si hay un campo seleccionado, lo mostramos
                        camposSeleccionados = cboEditarCampo.Text;
                    }
                    else
                    {
                        // Si no hay campo seleccionado, dejamos un valor vacío o un mensaje de advertencia
                        MessageBox.Show("Debe seleccionar o un campo o todos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (string.IsNullOrEmpty(txtQueryEditado.Text))
                {
                    // Si txtQuery está vacío, asignamos el valor inicial
                    txtQueryEditado.Text = camposSeleccionados + " + " + txtEditarAlias.Text + " + ";
                    datos[4] = txtQueryEditado.Text;
                }
                else
                {
                    // Si txtQuery ya tiene texto, agregamos el nuevo valor sin repetir el nombre de la consulta y el tipo
                    txtQueryEditado.Text += Environment.NewLine + camposSeleccionados + " + " + txtEditarAlias.Text + " + ";
                    datos[4] += txtQueryEditado.Text;
                }
                // Procesar los datos en la tabla correspondiente
                csControlador.ingresar(tipos, datos, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditarCampoSimple_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtQueryEditado.Text))
                {
                    MessageBox.Show("Por favor, ingrese una consulta válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string queryGenerado = csControlador.GenerarQuerySimple(datos);
                txtQueryEditadoFinal.Text = queryGenerado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            datos = new string[0];
            cboEditarTabla.ResetText();
            cboEditarCampo.ResetText();
            txtEditarAlias.Clear();
            chbTodosCampos.Checked = false;
            txtQueryEditado.Clear();
        }

        private void btnCancelarEditar_Click(object sender, EventArgs e)
        {
            datos = new string[0];
            datosComplejo = new string[0];
            cboEditarTabla.ResetText();
            cboEditarCampo.ResetText();
            txtEditarAlias.Clear();
            chbEditarTodosCampos.Checked = false;
            cboEditarLogico.ResetText();
            cboEditarCampoLogico.ResetText();
            txtEditarValorLogico.Clear();
            cboEditarComparador.ResetText();
            cboEditarCampoComparador.ResetText();
            txtEditarValorComparacion.Clear();
            cboEditarOrdenar.ResetText();
            cboEditarCampoOrdenar.ResetText();
            chbEditarAscendente.Checked = false;
            chbEditarDescendente.Checked = false;
            txtQueryEditado.Clear();
            txtQueryEditadoFinal.Clear();
        }


        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            bool habilitarControles = chbCondicionesEditar.Checked;
            gbEditarCondicion.Enabled = habilitarControles;
            Gpb_EditarComparacion.Enabled = habilitarControles;
            Gpb_EditarOrden.Enabled = habilitarControles;
            Gpb_ListadoConsultas.Enabled = habilitarControles;
            Gpb_EditarLogica.Enabled = habilitarControles;
            Gpb_EditarOrden.Enabled = habilitarControles;
            if (datos != null && datos.Length > 0)
            {
                datos[1] = "1";
                Console.WriteLine("Se habilitó la consulta Compleja.");
            }

        }


        private void btnEditarOrdenar_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado una operación válida
            try
            {
                if (string.IsNullOrWhiteSpace(cboEditarOrdenar.Text) || string.IsNullOrWhiteSpace(cboEditarCampoOrdenar.Text))
                {
                    MessageBox.Show("Debe seleccionar una operación y un campo.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Inicializar el array de datos
                datosComplejo = new string[] { cboEditarOrdenar.Text, cboEditarCampoOrdenar.Text, "0", txtQueryEditadoFinal.Text };
                // Verificar el tipo de operación
                if (cboEditarOrdenar.Text == "Ordenar")
                {
                    datosComplejo[0] = "ORDER BY";
                    if (chbEditarAscendente.Checked)
                    {
                        datosComplejo[2] = "ASC"; // Agregar ASC si está seleccionado
                    }
                    else if (chbEditarDescendente.Checked)
                    {
                        datosComplejo[2] = "DESC"; // Agregar DESC si está seleccionado
                    }
                    else
                    {
                        MessageBox.Show("Si se desea agregar un ordenamiento, debe seleccionar el tipo.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (cboEditarOrdenar.Text == "Agrupar")
                {
                    datosComplejo[0] = "GROUP BY"; // Indicar que es una operación de agrupamiento
                }
                else
                {
                    MessageBox.Show("Antes de agregar debe asignar valores.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                csControlador.ingresar(tipos, datosComplejo, tabla);
                string queryGenerado = csControlador.GenerarQueryComplejo(datosComplejo, datos);
                txtQueryEditadoFinal.Clear(); txtQueryEditadoFinal.Text = queryGenerado; datosComplejo = new string[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarLogico_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cboEditarCampoOrdenar.Text))
                {
                    MessageBox.Show("Por favor, ingrese una consulta válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                datosComplejo = new string[] { cboEditarLogico.Text, cboEditarCampoLogico.Text, txtEditarValorLogico.Text, txtQueryEditadoFinal.Text };
                csControlador.ingresar(tipos, datosComplejo, tabla);
                string queryGenerado = csControlador.GenerarQueryComplejo(datosComplejo, datos);
                txtQueryEditadoFinal.Clear(); txtQueryEditadoFinal.Text = queryGenerado; datosComplejo = new string[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarComparacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cboEditarCampoComparador.Text))
                {
                    MessageBox.Show("Por favor, ingrese una consulta válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                datosComplejo = new string[] { cboEditarComparador.Text, cboEditarCampoComparador.Text, txtEditarValorComparacion.Text, txtQueryEditadoFinal.Text };
                csControlador.ingresar(tipos, datosComplejo, tabla);
                string queryGenerado = csControlador.GenerarQueryComplejo(datosComplejo, datos);
                txtQueryEditadoFinal.Clear(); txtQueryEditadoFinal.Text = queryGenerado; datosComplejo = new string[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Cambios por Sebastian Luna 

        private void cboQuery3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTabla_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cboQuery2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Captura el nombre de la consulta seleccionada
            string nombreConsulta = cboQuery1.Text;
            string nombreConsulta1 = cboQuery3.Text;
            // Guardar el nombre de la consulta en una variable de instancia
            consultaSeleccionada = nombreConsulta;
            consultaSeleccionada = nombreConsulta1;
        }

        private void btnBuscarQuery1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cboQuery1.Text))
                {
                    MessageBox.Show("Por favor, ingrese una consulta válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                consultaControlador controlador = new consultaControlador();
                string querySeleccionado = cboQuery1.SelectedItem.ToString();
                controlador.BuscarQuerySeleccionado(querySeleccionado, dgvConsultas, txtQuery11);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboQuery1_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultaControlador controlador = new consultaControlador();
            controlador.CargarQueryEnTextBox(cboQuery1, txtQuery11);
        }

        private void btnBuscarQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cboQuery3.Text))
                {
                    MessageBox.Show("Por favor, ingrese una consulta válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                consultaControlador controlador = new consultaControlador();
                string querySeleccionado = cboQuery3.SelectedItem.ToString();
                controlador.BuscarQuerySeleccionado(querySeleccionado, dgvEliminarBuscarConsulta, txtQuery11);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de la consulta seleccionada en el ComboBox
            try
            {
                string nombreConsultaSeleccionada = cboQuery3.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(nombreConsultaSeleccionada))
                {
                    MessageBox.Show("Seleccione una consulta del ComboBox.");
                    return;
                }
                // Llamar al método del controlador para buscar y mostrar el query
                consultaControlador controlador = new consultaControlador();
                controlador.BuscarQuerySeleccionado(nombreConsultaSeleccionada, dgvEliminarBuscarConsulta, txtQuery11);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de la consulta seleccionada en cboQuery3
            try
            {
                if (string.IsNullOrWhiteSpace(cboQuery3.Text))
                {
                    MessageBox.Show("Por favor, ingrese una consulta válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string consultaSeleccionada = cboQuery3.SelectedItem.ToString();
                // Llamar al método de controlador para eliminar la consulta
                if (!string.IsNullOrEmpty(consultaSeleccionada))
                {
                    consultaControlador eliminarControlador = new consultaControlador();
                    eliminarControlador.EliminarConsulta(consultaSeleccionada);
                    // Refrescar el DataGridView después de eliminar la consulta
                    // Esto puede incluir la llamada al método para recargar los datos, si es necesario
                    dgvEliminarBuscarConsulta.DataSource = null; // Limpiar el DataGridView

                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una consulta para eliminar.");
                }
                ActualizarComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabConsultas_Click(object sender, EventArgs e)
        {

        }

        private void chbTodosCampos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cboEditarNombreConsulta.Text))
                {
                    MessageBox.Show("Por favor, ingrese una consulta válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                consultaControlador controlador = new consultaControlador();
                string querySeleccionado = cboEditarNombreConsulta.SelectedItem.ToString();
                controlador.BuscarQuerySeleccionado(querySeleccionado, dgvMostrar1, txtQueryEditadoFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvMostrar1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
        //Fin participacion sebastian Luna
    }
}