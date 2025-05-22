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
using Capa_Controlador_Carrera;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_Carrera
{
    public partial class frm_Promociones : Form
    {
        Controlador logica2;
        private int idSeleccionado = 0;
        private int excepcionActiva = 1;
        private int estadoActivo = 1;
        string valorSeleccionado;
        string valorSeleccionado2;

        logica logicaSeg = new logica();
        public string idUsuario { get; set; }
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
           cmb_PuestoNuevo.TabIndex = 5;
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
            //toolTip.SetToolTip(Btn_Editar, "Editar el registro seleccionado");
            toolTip.SetToolTip(Btn_Eliminar, "Eliminar el registro seleccionado");
            //toolTip.SetToolTip(Btn_Buscar, "Abrir consulta inteligente");
            toolTip.SetToolTip(Btn_Ayuda, "Ver la ayuda del formulario");
            toolTip.SetToolTip(Btn_Reporte, "Ver el reporte asociado");
            toolTip.SetToolTip(Btn_Salir, "Salir del formulario");

            string tabla = "tbl_empleados";
            string campo1 = "pk_clave";
            string campo2 = "empleados_nombre";

            // Llama al método para llenar el ComboBox
            llenarseModulos(tabla, campo1, campo2);
            //llenarseApli(tablaApli, campo1Apli, campo2Apli);


            string tablaPuesto = "tbl_puestos_trabajo";
            string campo1Puesto = "pk_id_puestos";
            string campo2Puesto = "puestos_nombre_puesto";

            // Llama al método para llenar el ComboBox
            llenarseModulosPuestos(tablaPuesto, campo1Puesto, campo2Puesto);
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
            //txt_PuestoNuevo.Enabled = habilitar;
            cmb_PuestoNuevo.Enabled = habilitar;
            txt_SalarioNuevo.Enabled = habilitar;
            txt_Motivo.Enabled = habilitar;

            // Habilitar o deshabilitar los botones


            Btn_Guardar.Enabled = habilitar;
            //Btn_Editar.Enabled = habilitar;
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
            cmb_PuestoNuevo.SelectedIndex = -1;
            //txt_PuestoNuevo.Text = "";
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
               // MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
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

        /***************************************************************************************************/

        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 2*****************************************************/

        public void llenarseModulosPuestos(string tablaPuesto, string campo1Puesto, string campo2Puesto)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logica2.enviar2(tablaPuesto, campo1Puesto, campo2Puesto);

            // Limpia el ComboBox antes de llenarlo
            cmb_PuestoNuevo.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                cmb_PuestoNuevo.Items.Add(new ComboBoxItemPuesto
                {
                    ValuePuesto = row[campo1Puesto].ToString(),
                    DisplayPuesto = row[campo2Puesto].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1Puesto]) + "-" + Convert.ToString(row[campo2Puesto]));
                coleccion.Add(Convert.ToString(row[campo2Puesto]) + "-" + Convert.ToString(row[campo1Puesto]));
            }

            cmb_empleado.AutoCompleteCustomSource = coleccion;
            cmb_empleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_empleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItemPuesto
        {
            public string ValuePuesto { get; set; }
            public string DisplayPuesto { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{ValuePuesto}-{DisplayPuesto}"; // Formato "ID-Nombre"
            }
        }

        private void cmb_PuestoNuevo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmb_PuestoNuevo.SelectedItem != null)
            //{
            //    // Obtener el valor del ValueMember seleccionado
            //    var selectedItem = (ComboBoxItemPuesto)cmb_PuestoNuevo.SelectedItem;
            //    string valorSeleccionado = selectedItem.ValuePuesto;
            //    // Mostrar el valor en un MessageBox
            //    MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            //}
            if (cmb_PuestoNuevo.SelectedItem != null)
            {
                var selectedItem = (ComboBoxItemPuesto)cmb_PuestoNuevo.SelectedItem;
                valorSeleccionado2 = selectedItem.DisplayPuesto;
                //MessageBox.Show($"Valor seleccionado: {valorSeleccionado2}", "Valor Seleccionado");

                // Obtener datos del empleado
                DataRow datos = logica2.ObtenerPuestoYSalario2(valorSeleccionado2);
                if (datos != null)
                {
                    //txt_PuestoActual.Text = datos["puesto"].ToString();
                    txt_SalarioNuevo.Text = datos["salario"].ToString();
                }
                else
                {
                    //txt_PuestoActual.Text = "No encontrado";
                    txt_SalarioNuevo.Text = "No encontrado";
                }
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






        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            // Habilitar controles cuando se presiona "Insertar"
            ConfigurarControles(true);
            LimpiarFormulario();
            //Txt_concepto.Focus();
            //Btn_Editar.Enabled = false;
            Btn_Eliminar.Enabled = false;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos vacíos
                if (string.IsNullOrEmpty(txt_PuestoActual.Text) ||
                    cmb_empleado.SelectedIndex == -1 ||  
                    string.IsNullOrEmpty(txt_SalarioActual.Text) || cmb_PuestoNuevo.SelectedIndex == -1
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

                string puestonuevo = valorSeleccionado2;
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
                    logicaSeg.funinsertarabitacora(idUsuario, "Ingreso una promocion", "Tbl_promociones", "12001");
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

        private void dgv_promociones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                try
                {
                    idSeleccionado = Convert.ToInt32(dgv_promociones.Rows[e.RowIndex].Cells["ID"].Value);
                    txt_ID.Text = idSeleccionado.ToString(); // Añadir esta línea
                    
                    
                    cmb_empleado.SelectedItem = dgv_promociones.Rows[e.RowIndex].Cells["Empleado"].Value.ToString();
                   
                    txt_PuestoActual.Text = dgv_promociones.Rows[e.RowIndex].Cells["PuestoActual"].Value.ToString();
                    txt_SalarioActual.Text = dgv_promociones.Rows[e.RowIndex].Cells["SalarioActual"].Value.ToString();


                    cmb_PuestoNuevo.SelectedItem = dgv_promociones.Rows[e.RowIndex].Cells["NuevoPuesto"].Value.ToString();
                    txt_SalarioNuevo.Text = dgv_promociones.Rows[e.RowIndex].Cells["NuevoSalario"].Value.ToString();


                    txt_Motivo.Text = dgv_promociones.Rows[e.RowIndex].Cells["Motivo"].Value.ToString();


                    //Cbo_clase.SelectedItem = Dgv_perp_dec.Rows[e.RowIndex].Cells["Clase"].Value.ToString();

                    //excepcionActiva = Convert.ToInt32(Dgv_perp_dec.Rows[e.RowIndex].Cells["Excepcion"].Value);
                    //estadoActivo = Convert.ToInt32(Dgv_perp_dec.Rows[e.RowIndex].Cells["Estado"].Value);

                    //ActualizarBotonExcepcion();
                    //ActualizarBotonEstado();

                    //Txt_monto.Text = Dgv_perp_dec.Rows[e.RowIndex].Cells["Monto"].Value.ToString();
                    //Btn_Editar.Enabled = true;
                    Btn_Eliminar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar registro: " + ex.Message);
                }
            }

        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para editar");
                return;
            }
            //.Focus();
            cmb_empleado.Enabled = true;
            dtp_fecha.Enabled = true;
            txt_PuestoActual.Enabled = true;
            txt_SalarioActual.Enabled = true;
            cmb_PuestoNuevo.Enabled = true;
            txt_SalarioNuevo.Enabled = true;
            txt_Motivo.Enabled = true;
            Btn_Guardar.Enabled = true;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario(); // Limpia el formulario
            ConfigurarControles(false); // Deshabilita controles de edición

            // Reiniciar estados para excepcion y estado
           // excepcionActiva = 1;
            // estadoActivo = 1;
          //  ActualizarBotonExcepcion();
          //  ActualizarBotonEstado();

            // Opcionalmente, puedes volver a cargar los datos si es necesario
            CargarDatos();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        logica2.funcEliminarPromocion(idSeleccionado);
                        LimpiarFormulario();
                        CargarDatos();
                        MessageBox.Show("Registro eliminado exitosamente");
                        logicaSeg.funinsertarabitacora(idUsuario, "Se elimino una promocion", "Tbl_promociones", "12001");
                        //Btn_editar.Enabled = false;
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

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            frm_Reporte reporte = new frm_Reporte();
            reporte.Show();
            logicaSeg.funinsertarabitacora(idUsuario, "Se vio el reporte", "Tbl_promociones", "12001");
        }
        // Declarar el ToolTip en el boton Ayuda
        private ToolTip toolTipAyuda = new ToolTip();
        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            // Busca la carpeta raíz del proyecto llamada proyectois2k25 a partir de la ruta del ejecutable.
            // Si encuentra la carpeta, busca el archivo .chm dentro de ella y sus subcarpetas.
            //Si el archivo es encontrado, intenta abrirlo usando Help.ShowHelp().Si falla, lo abre directamente con el proceso del sistema.

            logicaSeg.funinsertarabitacora(idUsuario, "Se consulto Ayuda", "Tbl_promociones", "12001");
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
            string sPathAyuda = sfunFindFileInDirectory(sProjectPath, "AyudaPromociones.chm");

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

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            logicaSeg.funinsertarabitacora(idUsuario, "Se salio de promociones", "Tbl_promociones", "12001");
        }
    }
}
