using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Carrera;

namespace Capa_Vista_Carrera
{
    public partial class frm_Promociones : Form
    {
        Controlador logica2;
        private int idSeleccionado = 0;
        private int excepcionActiva = 1;
        private int estadoActivo = 1;
        string valorSeleccionado;
        public frm_Promociones(String idUsuario)
        {
            InitializeComponent();
            logica2 = new Controlador(idUsuario);
            //idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            ///*********Prueba con la tabla inicial*********/
            //string[] alias = { "Id_Promocion", "fk_clave_empleado", "fecha", "Puesto Actual", "Salario Actual","Puesto Nuevo", "Salario Nuevo","Motivo","estado" };
            //navegador1.AsignarAlias(alias);
            //navegador1.AsignarSalida(this);
            //navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#ffd96b"));
            //navegador1.AsignarColorFuente(Color.Black);
            //navegador1.ObtenerIdAplicacion("1000");
            //navegador1.AsignarAyuda("1");
            //navegador1.ObtenerIdUsuario(idUsuario);
            //navegador1.AsignarTabla("tbl_promociones");
            //navegador1.AsignarNombreForm("Promociones");

            /////********Valores foraneos en Combobox************************/

            //navegador1.AsignarComboConTabla("tbl_empleados", "pk_clave", "empleados_nombre", 1);

            /////**************************************************/

            ///////************Se muestre en el dgv los nombres y no los numeros*******/

            ////navegador1.AsignarForaneas("Tbl_usuario", "DPI_usuario", "Fk_id_usuario", "Pk_id_usuario");
            ////navegador1.AsignarForaneas("Tbl_oficina", "nombre_oficina", "Fk_id_oficina", "Pk_id_oficina");
            ////navegador1.AsignarForaneas("Tbl_empleado", "nombre_empleado", "Fk_id_empleado", "Pk_id_empleado");


            //string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            // Configurar el orden de tabulación
            txt_ID.TabIndex = 0;
            cmb_empleado.TabIndex = 1;
            dtp_fecha.TabIndex = 2;
            txt_PuestoActual.TabIndex = 3;
            txt_SalarioActual.TabIndex = 4;
            txt_PuestoNuevo.TabIndex = 5;
            txt_SalarioNuevo.TabIndex = 6;
            txt_Motivo.TabIndex = 7;
            // Inicializar ComboBox al cargar el formulario
            //ConfigurarComboBoxes();
            CargarDatos();
            //// Inicializar los botones de excepción y estado como activos
            //excepcionActiva = 1;
            //estadoActivo = 1;
            //Cbo_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            //Cbo_aplicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            //Cbo_clase.DropDownStyle = ComboBoxStyle.DropDownList;
            //// Actualizar los botones para reflejar su estado activo
            //ActualizarBotonExcepcion();
            //ActualizarBotonEstado();
            //// Inicializar los botones y campos como deshabilitados al cargar el formulario
            ConfigurarControles(false);
            //// Crear un ToolTip
            ToolTip toolTip = new ToolTip();

            // Configuración de ToolTips para los botones
            toolTip.SetToolTip(Btn_Nuevo, "Insertar un nuevo registro");
            toolTip.SetToolTip(Btn_Guardar, "Guardar el registro actual");
            toolTip.SetToolTip(Btn_Cancelar, "Cancelar la operacion");
            toolTip.SetToolTip(Btn_Editar, "Editar el registro seleccionado");
            toolTip.SetToolTip(Btn_Eliminar, "Eliminar el registro seleccionado");
            toolTip.SetToolTip(Btn_Buscar, "Abrir consulta inteligente");
            toolTip.SetToolTip(Btn_Ayuda, "Ver la ayuda del formulario");
            toolTip.SetToolTip(Btn_Reporte, "Ver el reporte asociado");
            toolTip.SetToolTip(Btn_Salir, "Salir del formulario");

            string tabla = "tbl_empleados";
            string campo1 = "pk_clave";
            string campo2 = "empleados_nombre";


            // Llama al método para llenar el ComboBox
            llenarseModulos(tabla, campo1, campo2);
            //llenarseApli(tablaApli, campo1Apli, campo2Apli);

            // Asocia el evento SelectedIndexChanged después de poblar el ComboBox
            cmb_empleado.SelectedIndexChanged += new EventHandler(cmb_modulo_SelectedIndexChanged);
            //Cmb_aplicacion.SelectedIndexChanged += new EventHandler(cmb_apli_SelectedIndexChanged2);


        }

        private void CargarDatos()
        {
            try
            {
                DataTable dt = logica2.funcConsultarPromociones();
                if (dt != null)
                {
                    dgv_promociones.DataSource = dt;

                    // Buscar el último ID y sumarle 1 para el nuevo registro
                    if (dt.Rows.Count > 0)
                    {
                        int maxId = dt.AsEnumerable()
                            .Max(row => Convert.ToInt32(row["ID"]));
                        txt_ID.Text = (maxId + 1).ToString();
                    }
                    else
                    {
                        txt_ID.Text = "1";
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

        private void ConfigurarControles(bool habilitar)
        {
            // Habilitar o deshabilitar los controles de texto
            cmb_empleado.Enabled = habilitar;
            dtp_fecha.Enabled = habilitar;
            txt_PuestoActual.Enabled = habilitar;
            txt_SalarioActual.Enabled = habilitar;
            txt_PuestoNuevo.Enabled = habilitar;
            txt_SalarioNuevo.Enabled = habilitar;
            txt_Motivo.Enabled = habilitar;

            // Habilitar o deshabilitar los botones


            Btn_Guardar.Enabled = habilitar;
            Btn_Editar.Enabled = habilitar;
            Btn_Eliminar.Enabled = habilitar;
        }

        private void LimpiarFormulario()
        {
            idSeleccionado = 0;
            // Buscar el último ID en el DataGridView y sumarle 1
            if (dgv_promociones.Rows.Count > 0)
            {
                int maxId = 0;
                foreach (DataGridViewRow row in dgv_promociones.Rows)
                {
                    if (row.Cells["ID"].Value != null)
                    {
                        int currentId = Convert.ToInt32(row.Cells["ID"].Value);
                        if (currentId > maxId)
                            maxId = currentId;
                    }
                }
                txt_ID.Text = (maxId + 1).ToString();
            }
            else
            {
                txt_ID.Text = "1";
            }

            txt_PuestoActual.Text = "";
            cmb_empleado.SelectedIndex = -1;
            txt_SalarioActual.Text = "";
            txt_PuestoNuevo.Text = "";
            txt_SalarioNuevo.Text = "";
            txt_Motivo.Text = "";

            //ActualizarBotonExcepcion();
            //ActualizarBotonEstado();
        }




        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 1*****************************************************/

        public void llenarseModulos(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logica2.enviar(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            cmb_empleado.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                cmb_empleado.Items.Add(new ComboBoxItem
                {
                    Value = row[campo1].ToString(),
                    Display = row[campo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            cmb_empleado.AutoCompleteCustomSource = coleccion;
            cmb_empleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_empleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

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

        private void cmb_modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_empleado.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItem)cmb_empleado.SelectedItem;
                string valorSeleccionado = selectedItem.Value;
                // Mostrar el valor en un MessageBox
               MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            }
        }
        /***************************************************************************************************/


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frm_Promociones_Load(object sender, EventArgs e)
        {
           cmb_empleado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmb_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmb_empleado.SelectedItem != null)
            //{
            //    // Obtener el valor del ValueMember seleccionado
            //    var selectedItem = (ComboBoxItem)cmb_empleado.SelectedItem;
            //    string valorSeleccionado = selectedItem.Value;
            //    // Mostrar el valor en un MessageBox
            //    MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            //}

            if (cmb_empleado.SelectedItem != null)
            {
                var selectedItem = (ComboBoxItem)cmb_empleado.SelectedItem;
                valorSeleccionado = selectedItem.Value;

                // Obtener datos del empleado
                DataRow datos = logica2.ObtenerPuestoYSalario(valorSeleccionado);
                if (datos != null)
                {
                    txt_PuestoActual.Text = datos["puesto"].ToString();
                    txt_SalarioActual.Text = datos["salario"].ToString();
                }
                else
                {
                    txt_PuestoActual.Text = "No encontrado";
                    txt_SalarioActual.Text = "No encontrado";
                }
            }




        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            // Habilitar controles cuando se presiona "Insertar"
            ConfigurarControles(true);
            LimpiarFormulario();
            //Txt_concepto.Focus();
            Btn_Editar.Enabled = false;
            Btn_Eliminar.Enabled = false;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos vacíos
                if (string.IsNullOrEmpty(txt_PuestoActual.Text) ||
                    cmb_empleado.SelectedIndex == -1 ||  
                    string.IsNullOrEmpty(txt_SalarioActual.Text) || string.IsNullOrEmpty(txt_PuestoNuevo.Text)
                    || string.IsNullOrEmpty(txt_Motivo.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                    return;
                }

                // Obtener valores de los campos
                //string empleado = cmb_empleado.SelectedItem.ToString();
                string empleadoInicial = valorSeleccionado;
                int empleado = Convert.ToInt32(valorSeleccionado);
                //string fecha = dtp_fecha.Value.ToString("yyyy-MM-dd");
                DateTime fecha = dtp_fecha.Value;

                string puestoactual = txt_PuestoActual.Text;
                string salarioactual = txt_SalarioActual.Text;

                string puestonuevo = txt_PuestoNuevo.Text;
                string salarionuevo = txt_SalarioNuevo.Text;

                string motivo = txt_Motivo.Text;

                //MessageBox.Show(fecha);
                ////// Validar que el monto sea un número válido
                //if (!decimal.TryParse(txt_SalarioActual.Text, out decimal salarioactual))
                //{
                //    MessageBox.Show("El monto debe ser un número válido");
                //    return;
                //}


                //// Validar que el monto sea un número válido
                //if (!decimal.TryParse(txt_SalarioNuevo.Text, out decimal salarionuevo))
                //{
                //    MessageBox.Show("El monto debe ser un número válido");
                //    return;
                //}

                // Si idSeleccionado es 0, es un nuevo registro
                if (idSeleccionado == 0)
                {
                    // Insertar nuevo registro
                    logica2.funcInsertarPromocion(empleado, fecha, puestoactual, salarioactual, puestonuevo, salarionuevo, motivo);
                    MessageBox.Show("Registro insertado exitosamente");
                    CargarDatos();

                    // Inicializar los botones de excepción y estado como activos
                    excepcionActiva = 1;
                    estadoActivo = 1;
                }
                else
                {
                    //// Actualizar registro existente
                    //cn.funcActualizarLogicaDeduPerp(idSeleccionado, clase, concepto, tipo, aplicacion, excepcionActiva, monto);
                    //MessageBox.Show("Registro actualizado exitosamente");
                    //// Inicializar los botones de excepción y estado como activos
                    //excepcionActiva = 1;
                    //estadoActivo = 1;
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
    }
}
