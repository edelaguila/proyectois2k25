using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Capa_Controlador_Planilla;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_Planilla
{
    public partial class Frm_GenPlanilla : Form
    {
        Controlador cn = new Controlador();
        String svalorSeleccionado;
        String svalorSeleccionado2;
        private int iidSeleccionado = 0;
        private int iidSeleccionado2 = 0;

        logica logicaSeg = new logica();
        public string idUsuario { get; set; }
        public Frm_GenPlanilla()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#AEA1D6");
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(Btn_insertar, "Insertar un nuevo registro");
            toolTip.SetToolTip(Btn_guardar, "Guardar el registro actual");
            toolTip.SetToolTip(Btn_editar, "Editar el registro seleccionado");
            toolTip.SetToolTip(Btn_cancelar, "Cancelar el ingreso");
            toolTip.SetToolTip(Btn_eliminar, "Eliminar un registro");
            toolTip.SetToolTip(Btn_impresora, "Imprimir Planilla");
            toolTip.SetToolTip(Btn_Dedu_Per, "Vincula nueva Perpcecion/Deduccion");
            toolTip.SetToolTip(Btn_Ayuda, "Mostrar la ayuda");
            toolTip.SetToolTip(Btn_Reportes, "Documento de Reportes");
            toolTip.SetToolTip(Btn_salir, "Salir del formulario");

            //toolTip.SetToolTip(Btn_insertarPlanilla, "Insertar un nuevo registro");
            //toolTip.SetToolTip(Btn_guardar, "Guardar el registro actual");
            //toolTip.SetToolTip(Btn_guardarPlanilla, "Editar el registro seleccionado");
            //toolTip.SetToolTip(Btn_cancelarPlanilla, "Cancelar el ingreso");
            //toolTip.SetToolTip(Btn_EliminarDetalle, "Eliminar un registro");

            // Configurar el orden de tabulación
            Txt_ClaveEncabezado.TabIndex = 0;
            Txt_Correlativo.TabIndex = 1;
            Dtp_inicio.TabIndex = 2;
            Dtp_final.TabIndex = 3;

            //Txt_ClaveDetalle.TabIndex = 4;
            //Cbo_ClaveEmpleado.TabIndex = 5;
            //Cbo_CEncabezado.TabIndex = 6;

            // Inicializar los botones y campos como deshabilitados al cargar el formulario
            proConfigurarControles1(false);
            proConfigurarControles2(false);
            //Dgv_encabezado.Columns[0].HeaderText = "ClaveEncabezado";
            //Dgv_encabezado.Columns[1].HeaderText = "Correlativo";
            //Dgv_encabezado.Columns[2].HeaderText = "FechaInicio";
            //Dgv_encabezado.Columns[3].HeaderText = "FechaFinal";
            //Dgv_encabezado.Columns[4].HeaderText = "TotalMes";

            //Dgv_detalle.Columns[0].HeaderText = "Clave Detalle";
            //Dgv_detalle.Columns[1].HeaderText = "Total Percepciones";
            //Dgv_detalle.Columns[2].HeaderText = "Total Deducciones";
            //Dgv_detalle.Columns[3].HeaderText = "Total Liquido";
            //Dgv_detalle.Columns[4].HeaderText = "Empleado";
            //Dgv_detalle.Columns[4].HeaderText = "Contrato";
            //Dgv_detalle.Columns[4].HeaderText = "Detalle Encabezado";

            
            //proCargarDetalle();


            string stabla = "tbl_empleados";
            string scampo1 = "pk_clave";
            string scampo2 = "empleados_nombre";

            string stablaEnca = " tbl_planilla_Encabezado";
            string scampo1Enca = "pk_registro_planilla_Encabezado";
            string scampo2Enca = "encabezado_correlativo_planilla";
            proCargarEncabezadoInicial();

            // Llama al método para llenar el ComboBox
            //prollenarseEmpleados(stabla, scampo1, scampo2);
            //prollenarseEncabezado(stablaEnca, scampo1Enca, scampo2Enca);


            // Datos fijos para el ComboBox
             List<string> items = new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            // Asignar los datos al ComboBox
             cbo_mes.DataSource = items;


        }

        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 1*****************************************************/

        //public void prollenarseEmpleados(string stabla, string scampo1, string scampo2)
        //{
        //    // Obtén los datos para el ComboBox
        //    var dt2 = cn.funenviar(stabla, scampo1, scampo2);

        //    // Limpia el ComboBox antes de llenarlo
        //    Cbo_ClaveEmpleado.Items.Clear();

        //    foreach (DataRow row in dt2.Rows)
        //    {
        //        // Agrega el elemento mostrando el formato "ID-Nombre"
        //        Cbo_ClaveEmpleado.Items.Add(new ComboBoxItem
        //        {
        //            Value = row[scampo1].ToString(),
        //            Display = row[scampo2].ToString()
        //        });
        //    }

        //    // Configura AutoComplete para el ComboBox con el formato deseado
        //    AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
        //    foreach (DataRow row in dt2.Rows)
        //    {
        //        coleccion.Add(Convert.ToString(row[scampo1]) + "-" + Convert.ToString(row[scampo2]));
        //        coleccion.Add(Convert.ToString(row[scampo2]) + "-" + Convert.ToString(row[scampo1]));
        //    }

        //    Cbo_ClaveEmpleado.AutoCompleteCustomSource = coleccion;
        //    Cbo_ClaveEmpleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    Cbo_ClaveEmpleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //}

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        //private void Cbo_ClaveEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (Cbo_ClaveEmpleado.SelectedItem != null)
        //    {
        //        // Obtener el valor del ValueMember seleccionado
        //        var selectedItem = (ComboBoxItem)Cbo_ClaveEmpleado.SelectedItem;
        //        svalorSeleccionado = selectedItem.Value;
        //        // Mostrar el valor en un MessageBox
        //        Console.Write($"Valor seleccionado: {svalorSeleccionado}", "Valor Seleccionado");
        //    }
        //}

        /******************************************************************************************/

        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 2*****************************************************/

        //public void prollenarseEncabezado(string stabla, string scampo1, string scampo2)
        //{
        //    // Obtén los datos para el ComboBox
        //    var dt2 = cn.funenviar2(stabla, scampo1, scampo2);

        //    // Limpia el ComboBox antes de llenarlo
        //    Cbo_CEncabezado.Items.Clear();

        //    foreach (DataRow row in dt2.Rows)
        //    {
        //        // Agrega el elemento mostrando el formato "ID-Nombre"
        //        Cbo_CEncabezado.Items.Add(new ComboBoxItem
        //        {
        //            Value = row[scampo1].ToString(),
        //            Display = row[scampo2].ToString()
        //        });
        //    }

        //    // Configura AutoComplete para el ComboBox con el formato deseado
        //    AutoCompleteStringCollection coleccion2 = new AutoCompleteStringCollection();
        //    foreach (DataRow row in dt2.Rows)
        //    {
        //        coleccion2.Add(Convert.ToString(row[scampo1]) + "-" + Convert.ToString(row[scampo2]));
        //        coleccion2.Add(Convert.ToString(row[scampo2]) + "-" + Convert.ToString(row[scampo1]));
        //    }

        //    Cbo_CEncabezado.AutoCompleteCustomSource = coleccion2;
        //    Cbo_CEncabezado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    Cbo_CEncabezado.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //}

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem2
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        //private void Cbo_CEncabezado_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (Cbo_CEncabezado.SelectedItem != null)
        //    {
        //        // Obtener el valor del ValueMember seleccionado
        //        var selectedItem = (ComboBoxItem)Cbo_CEncabezado.SelectedItem;
        //        svalorSeleccionado2 = selectedItem.Value;
        //        // Mostrar el valor en un MessageBox
        //        Console.Write($"Valor seleccionado: {svalorSeleccionado2}", "Valor Seleccionado");
        //    }
        //}

        /**********************************************************************************************/


        private void proCargarEncabezadoInicial()
        {


            //// Cargar deducciones en la DataGridView
            DataTable encabezado = cn.funObtenerEncabezadoInicial();
            dgv_encabezadoInicial.DataSource = encabezado;
        }
        //private void proCargarDetalle()
        //{


        //    //// Cargar deducciones en la DataGridView
        //    DataTable detalle = cn.funObtenerDetalle();
        //    Dgv_detalle.DataSource = detalle;
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Método para habilitar o deshabilitar los controles
        private void proConfigurarControles1(bool bhabilitar)
        {
            // Habilitar o deshabilitar los controles de texto
            Txt_ClaveEncabezado.Enabled = bhabilitar;
            Txt_Correlativo.Enabled = bhabilitar;
            Dtp_inicio.Enabled = bhabilitar;
            Dtp_final.Enabled = bhabilitar;

            Btn_guardar.Enabled = bhabilitar;
            Btn_editar.Enabled = bhabilitar;
            Btn_eliminar.Enabled = bhabilitar;

        }

        private void proConfigurarControles2(bool bhabilitar)
        {
            // Habilitar o deshabilitar los controles de texto
            //Txt_ClaveDetalle.Enabled = bhabilitar;
            //Cbo_ClaveEmpleado.Enabled = bhabilitar;
            //Cbo_CEncabezado.Enabled = bhabilitar;



            //Btn_guardarPlanilla.Enabled = bhabilitar;
            //Btn_editarPlanilla.Enabled = bhabilitar;
            //Btn_EliminarDetalle.Enabled = bhabilitar;



        }


        private void proLimpiarFormulario()
        {
            iidSeleccionado = 0;
            // Buscar el último ID en el DataGridView y sumarle 1
            if (dgv_encabezadoInicial.Rows.Count > 0)
            {
                int imaxId = 0;
                foreach (DataGridViewRow row in dgv_encabezadoInicial.Rows)
                {
                    if (row.Cells["ID_Encabezado"].Value != null)
                    {
                        int icurrentId = Convert.ToInt32(row.Cells["ID_Encabezado"].Value);
                        if (icurrentId > imaxId)
                            imaxId = icurrentId;
                    }
                }
                Txt_ClaveEncabezado.Text = (imaxId + 1).ToString();
            }
            else
            {
                Txt_ClaveEncabezado.Text = "1";
            }

            Txt_Correlativo.Text = "";
            Dtp_inicio.Value = DateTime.Now;
            Dtp_final.Value = DateTime.Now;

        }







        private void Btn_insertar_Click(object sender, EventArgs e)
        {
            proConfigurarControles1(true);
            proLimpiarFormulario();
            Txt_Correlativo.Focus();

            Btn_editar.Enabled = false;
            Btn_eliminar.Enabled = false;


        }

        //private void Btn_editarPlanilla_Click(object sender, EventArgs e)
        //{
        //    if (iidSeleccionado2 == 0)
        //    {
        //        MessageBox.Show("Debe seleccionar un registro para editar");
        //        return;
        //    }

        //    Cbo_ClaveEmpleado.Enabled = true;
        //    Cbo_CEncabezado.Enabled = true;

        //    if (iidSeleccionado2 == 0)
        //    {
        //        MessageBox.Show("Debe seleccionar un registro para editar");
        //        return;
        //    }
        //    Btn_guardarPlanilla.Enabled = true;
        //}

        //private void Btn_guardarPlanilla_Click(object sender, EventArgs e)
        //{
        //    int ipkRegistroPlanillaDetalle = Convert.ToInt32(Txt_ClaveDetalle.Text);
        //    //var selectedEmpleado = (ComboBoxItem)Cbo_ClaveEmpleado.SelectedItem;
        //    //var selectedEncabezado = (ComboBoxItem)Cbo_CEncabezado.SelectedItem;

        //    //// Obtener nombres
        //    //string nombreEmpleado = selectedEmpleado.Value;
        //    //string nombreAplicacion = selectedEncabezado.Value;

        //    //MessageBox.Show(nombreEmpleado);
        //    //MessageBox.Show(nombreAplicacion);


        //    //int fkIdRegistroPlanillaEncabezado = Convert.ToInt32(valorSeleccionado2); // ID del encabezado de la planilla
        //    //int fkClaveEmpleado = Convert.ToInt32(valorSeleccionado); // ID del empleado


        //    //bool exito = cn.EjecutarCalculoPlanilla(pkRegistroPlanillaDetalle, fkIdRegistroPlanillaEncabezado, fkClaveEmpleado);

        //    //if (exito)
        //    //{
        //    //    MessageBox.Show("Cálculo de planilla completado con éxito.");
        //    //    CargarDetalle();
        //    //    ConfigurarControles1(false);
        //    //    LimpiarFormulario();

        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("Error al calcular la planilla.");
        //    //}

        //    /*****************/
        //    try
        //    {
        //        // Validación de campos vacíos
        //        if (
        //            Cbo_ClaveEmpleado.SelectedIndex == -1 ||
        //            Cbo_CEncabezado.SelectedIndex == -1)
        //        {
        //            MessageBox.Show("Todos los campos son obligatorios");
        //            return;
        //        }

        //        // Obtener valores de los campos
        //        int ifkIdRegistroPlanillaEncabezado = Convert.ToInt32(svalorSeleccionado2); // ID del encabezado de la planilla
        //        int ifkClaveEmpleado = Convert.ToInt32(svalorSeleccionado); // ID del empleado


        //        // Si idSeleccionado es 0, es un nuevo registro
        //        if (iidSeleccionado2 == 0)
        //        {
        //            bool bexito = cn.funEjecutarCalculoPlanilla( ifkIdRegistroPlanillaEncabezado, ifkClaveEmpleado);

        //            if (bexito)
        //            {
        //                MessageBox.Show("Cálculo de planilla completado con éxito.");
        //                //proCargarDetalle();
        //                proConfigurarControles2(false);
        //                //proLimpiarFormulario2();

        //            }
        //            else
        //            {
        //                MessageBox.Show("Error al calcular la planilla.");
        //            }
        //        }
        //        else
        //        {
        //            // Actualizar registro existente
        //            cn.funcActualizarDetalle(iidSeleccionado2, ifkIdRegistroPlanillaEncabezado, ifkClaveEmpleado);
        //            MessageBox.Show("Registro actualizado exitosamente");
        //            // Inicializar los botones de excepción y estado como activos
        //            //proCargarDetalle();

        //        }

        //        //proLimpiarFormulario2();
        //       //proCargarDetalle();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al guardar: " + ex.Message);
        //    }





        //}

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //// Validación de campos vacíos
            //if (string.IsNullOrEmpty(Txt_Correlativo.Text))
            //{
            //    MessageBox.Show("Debe Ingresar un correlativo");
            //    return;
            //}

            //if (!int.TryParse(Txt_Correlativo.Text, out int corre))
            //{
            //    MessageBox.Show("El correlativo debe ser un número entero válido.");
            //    return;
            //}

            //int correlativo = Convert.ToInt32(Txt_Correlativo.Text);
            //DateTime fechaInicio = Dtp_inicio.Value;
            //DateTime fechaFinal = Dtp_final.Value;
            //decimal totalMes = 0; // Puedes calcular o asignar este valor como sea necesario.

            //Controlador controlador = new Controlador();
            //bool resultado = controlador.AgregarPlanillaEncabezado(correlativo, fechaInicio, fechaFinal, totalMes);

            //if (resultado)
            //{
            //    CargarEncabezado();
            //    MessageBox.Show("Encabezado de planilla agregado correctamente.");

            //    string tablaEnca = " tbl_planilla_Encabezado";
            //    string campo1Enca = "pk_registro_planilla_Encabezado";
            //    string campo2Enca = "encabezado_correlativo_planilla";

            //    llenarseEncabezado(tablaEnca, campo1Enca, campo2Enca);
            //    ConfigurarControles1(false);
            //    LimpiarFormulario();
            //}
            //else
            //{
            //    MessageBox.Show("Error al agregar el encabezado de planilla.");
            //}

            /***********/

            try
            {
                // Validación de campos vacíos
                if (string.IsNullOrEmpty(Txt_Correlativo.Text))
                {
                    MessageBox.Show("Debe Ingresar un correlativo");
                    return;
                }

                if (!int.TryParse(Txt_Correlativo.Text, out int corre))
                {
                    MessageBox.Show("El correlativo debe ser un número entero válido.");
                    return;
                }

                int icorrelativo = Convert.ToInt32(Txt_Correlativo.Text);
                DateTime dfechaInicio = Dtp_inicio.Value;
                DateTime dfechaFinal = Dtp_final.Value;
                string smesTexto;

                if (dfechaInicio.Year == dfechaFinal.Year && dfechaInicio.Month == dfechaFinal.Month)
                {
                    // Las fechas están en el mismo mes y año
                    MessageBox.Show("Las fechas están en el mismo mes y año.");
                    smesTexto = dfechaInicio.ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));

                }
                else
                {
                    // Las fechas no están en el mismo mes y año
                    MessageBox.Show("Las fechas no están en el mismo mes y año.");
                    return;
                }



                decimal detotalMes = 0; // Puedes calcular o asignar este valor como sea necesario.

                bool resultado;
                // Si idSeleccionado es 0, es un nuevo registro
                if (iidSeleccionado == 0)
                {
                    smesTexto = dfechaInicio.ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));
                    Console.Write(smesTexto);
                    resultado = cn.funEjecutarCalculoPlanilla(icorrelativo, dfechaInicio, dfechaFinal, smesTexto);

                    if (resultado)
                    {
                        //proCargarEncabezado();
                        MessageBox.Show("Encabezado de planilla agregado correctamente.");
                        logicaSeg.funinsertarabitacora(idUsuario, "Ingreso un Encabezado de Planilla", "Tbl_planilla_encabezado", "6201");
                        string stablaEnca = " tbl_planilla_Encabezado";
                        string scampo1Enca = "pk_registro_planilla_Encabezado";
                        string scampo2Enca = "encabezado_correlativo_planilla";
                        proCargarEncabezadoInicial();
                        //prollenarseEncabezado(stablaEnca, scampo1Enca, scampo2Enca);
                        proConfigurarControles1(false);
                        //proLimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el encabezado de planilla.");
                    }
                }
                else
                {
                    smesTexto = dfechaInicio.ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));
                    // Actualizar registro existente
                    cn.funcActualizarEncabezado(iidSeleccionado, icorrelativo, dfechaInicio, dfechaFinal, smesTexto);
                    proCargarEncabezadoInicial();
                    MessageBox.Show("Registro actualizado exitosamente");
                    logicaSeg.funinsertarabitacora(idUsuario, "Se actualizo Encabezado de Planilla", "Tbl_planilla_encabezado", "6201");

                    //proCargarEncabezado();

                }

                //proLimpiarFormulario();
                //proCargarEncabezado();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

        }

        private void Btn_insertarPlanilla_Click(object sender, EventArgs e)
        {
            proConfigurarControles2(true);
            //proLimpiarFormulario2();
            //Txt_Correlativo.Focus();

            Btn_editar.Enabled = false;
            Btn_eliminar.Enabled = false;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            //proLimpiarFormulario(); // Limpia el formulario
            proConfigurarControles1(false); // Deshabilita controles de edición
            //proCargarEncabezado();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (iidSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para editar");
                return;
            }
            Txt_Correlativo.Focus();
            Dtp_inicio.Enabled = true;
            Dtp_final.Enabled = true;

            if (iidSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para editar");
                return;
            }
            Btn_guardar.Enabled = true;

        }

        private void Dgv_encabezado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    try
            //    {
            //        iidSeleccionado = Convert.ToInt32(Dgv_encabezado.Rows[e.RowIndex].Cells["ClaveEncabezado"].Value);
            //        Txt_ClaveEncabezado.Text = iidSeleccionado.ToString(); // Añadir esta línea
            //        Txt_Correlativo.Text = Dgv_encabezado.Rows[e.RowIndex].Cells["Correlativo"].Value.ToString();


            //        Dtp_inicio.Value = (DateTime)Dgv_encabezado.Rows[e.RowIndex].Cells["FechaInicio"].Value;
            //        Dtp_final.Value = (DateTime)Dgv_encabezado.Rows[e.RowIndex].Cells["FechaFinal"].Value;


            //        Btn_editar.Enabled = true;
            //        Btn_eliminar.Enabled = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error al seleccionar registro: " + ex.Message);
            //    }
            //}
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (iidSeleccionado != 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        cn.funcEliminarEncabezado(iidSeleccionado);
                        proCargarEncabezadoInicial();
                        //proLimpiarFormulario();
                        MessageBox.Show("Registro eliminado exitosamente");
                        logicaSeg.funinsertarabitacora(idUsuario, "Se elimino un Encabezado de Planilla", "Tbl_planilla_encabezado", "6201");
                        //proCargarEncabezado();
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

        private void Btn_cancelarPlanilla_Click(object sender, EventArgs e)
        {
            //proLimpiarFormulario2(); // Limpia el formulario
            proConfigurarControles2(false); // Deshabilita controles de edición
            //proCargarDetalle();
        }



        private void Btn_EliminarDetalle_Click(object sender, EventArgs e)
        {
            if (iidSeleccionado2 != 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        cn.funcEliminarDetalle(iidSeleccionado2);
                        //proLimpiarFormulario2();
                        MessageBox.Show("Registro eliminado exitosamente");
                        //Btn_editarPlanilla.Enabled = false;
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

        private void cbo_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mesSeleccionado = cbo_mes.SelectedItem.ToString();
            proLlenarDataGridView(mesSeleccionado);


        }
        public void proLlenarDataGridView(string mesTexto)
        {
            try
            {
                // Instancia del controlador
                var controlador = new Controlador(); // Asegúrate de reemplazar con el nombre real de tu clase controlador

                // Obtener los datos de la planilla para el mes especificado
                DataTable datosPlanilla = controlador.funObtenerEncabezado(mesTexto);

                if (datosPlanilla != null && datosPlanilla.Rows.Count > 0)
                {
                    // Asignar el DataTable como fuente de datos del DataGridView
                    Dgv_encabezado.DataSource = datosPlanilla;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el mes especificado.");
                    //Dgv_encabezado.Rows.Clear();
                    DataTable dt = (DataTable)Dgv_encabezado.DataSource;
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el DataGridView: " + ex.Message);
            }
        }

        private void Btn_Dedu_Per_Click(object sender, EventArgs e)
        {
            Frm_CalculoPerpDedu frm = new Frm_CalculoPerpDedu();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    iidSeleccionado = Convert.ToInt32(dgv_encabezadoInicial.Rows[e.RowIndex].Cells["ID_Encabezado"].Value);
                    Txt_ClaveEncabezado.Text = iidSeleccionado.ToString(); // Añadir esta línea
                    Txt_Correlativo.Text = dgv_encabezadoInicial.Rows[e.RowIndex].Cells["Correlativo"].Value.ToString();


                    Dtp_inicio.Value = (DateTime)dgv_encabezadoInicial.Rows[e.RowIndex].Cells["Fecha_Inicio"].Value;
                    Dtp_final.Value = (DateTime)dgv_encabezadoInicial.Rows[e.RowIndex].Cells["Fecha_Final"].Value;


                    Btn_editar.Enabled = true;
                    Btn_eliminar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar registro: " + ex.Message);
                }
            }
        }


        private void Btn_impresora_Click(object sender, EventArgs e)
        {
            // Configura el diálogo de guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Guardar el archivo PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Ruta donde se guardará el archivo PDF
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Configura el documento PDF en formato horizontal (Landscape)
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 20f, 20f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                    pdfDoc.Open();

                    // Configura la fuente para el contenido y el encabezado
                    iTextSharp.text.Font font = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                    iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);

                    // Agrega un encabezado con el mes seleccionado en el ComboBox
                    string mesSeleccionado = cbo_mes.SelectedItem?.ToString() ?? "Mes no seleccionado";
                    Paragraph header = new Paragraph("Planilla " + mesSeleccionado, headerFont)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 10f
                    };
                    pdfDoc.Add(header);

                    // Crea una tabla en PDF con el mismo número de columnas que el DataGridView
                    PdfPTable pdfTable = new PdfPTable(Dgv_encabezado.ColumnCount)
                    {
                        WidthPercentage = 100
                    };

                    // Configura el ancho de las columnas de acuerdo a la proporción en el DataGridView
                    float[] columnWidths = new float[Dgv_encabezado.ColumnCount];
                    for (int i = 0; i < Dgv_encabezado.ColumnCount; i++)
                    {
                        columnWidths[i] = Dgv_encabezado.Columns[i].Width;
                    }
                    pdfTable.SetWidths(columnWidths);

                    // Agrega encabezados de columna
                    foreach (DataGridViewColumn column in Dgv_encabezado.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font))
                        {
                            BackgroundColor = BaseColor.LIGHT_GRAY,
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        pdfTable.AddCell(cell);
                    }

                    // Agrega las filas del DataGridView al PDF
                    foreach (DataGridViewRow row in Dgv_encabezado.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(new Phrase(cell.Value?.ToString() ?? string.Empty, font));
                        }
                    }

                    // Agrega la tabla al documento PDF y cierra el documento
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();

                    MessageBox.Show("PDF generado exitosamente en: " + filePath, "PDF Exportado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logicaSeg.funinsertarabitacora(idUsuario, "Se imprimio una Planilla", "Tbl_planilla_encabezado", "6201");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void funAbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = new T();
            formulario.Show();
        }
        private void Btn_Reportes_Click(object sender, EventArgs e)
        {
            //   ReporteH frm = new ReporteH();
            //   frm.Show();

            // Llamar a AbrirFormulario para abrir el formulario de ReporteH
            funAbrirFormulario<ReportePlanilla2>();
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
                            //MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {   //Mensaje de No se encontro la carpeta
                    MessageBox.Show("No se encontró la carpeta: " + sDirectory);
                }
            }
            catch (Exception ex)
            {       //Mensaje de error al buscar el archivo
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }


        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            // Mostrar el ToolTip en el boton ayuda
            toolTip.SetToolTip(Btn_Ayuda, " Documento de ayuda ");

            // Obtener la ruta del directorio del ejecutable
            string sExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Retroceder a la carpeta del proyecto
            string sProjectPath = Path.GetFullPath(Path.Combine(sExecutablePath, @"..\..\..\..\..\..\Ayuda\Modulos\Nominas\"));
          //  MessageBox.Show("1" + sProjectPath);


            string sAyudaFolderPath = Path.Combine(sProjectPath, "AyudaPlanillas");

            string sPathAyuda = funFindFileInDirectory(sAyudaFolderPath, "planilla.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(sPathAyuda))
            {
               // MessageBox.Show("El archivo sí está.");
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, sPathAyuda, "Planilla.html");
            }
            else
            {
                // Si el archivo no existe, muestra un mensaje de error
                MessageBox.Show("El archivo de ayuda no se encontró.");
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
