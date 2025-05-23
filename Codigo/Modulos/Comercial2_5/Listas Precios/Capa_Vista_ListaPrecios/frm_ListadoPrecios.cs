using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Capa_Controlador_ListaPrecios;

namespace Capa_Vista_ListaPrecios
{
    public partial class frm_ListadoPrecios : Form
    {
        private logica logic;

        public frm_ListadoPrecios(string idUsuario)
        {
            InitializeComponent();
            //deshabilitar el txt de fecha
            Txt_fecha.Enabled = false;
            // Establecer la fecha en el TextBox al mostrar el formulario
            this.Shown += new EventHandler(Txt_fecha_TextChanged);

            logic = new logica(idUsuario);
            Txt_clasificacionInventario.Enabled = false;
            Txt_clasificacionEspecificaSeleccionada.Enabled = false;
            //Txt_porcentaje.Enabled = false;
            Dgv_detalleProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            Rdb_costocompra.CheckedChanged += Rdb_costocompra_CheckedChanged;
            Rdb_precioventa.CheckedChanged += Rdb_precioventa_CheckedChanged;
            Rdb_forzar.CheckedChanged += Rdb_forzar_CheckedChanged;

            //relleno del textbox por inventario busaqueda por nombre o codigo
            ConfigurarAutoCompletarProductos(Txt_productobuscado);

            // Agregar opciones al ComboBox de estado
            Cbo_estado.Items.Add("Activo");
            Cbo_estado.Items.Add("Inactivo");
            Cbo_estado.SelectedIndexChanged += Cbo_estado_SelectedIndexChanged;

            //Tooltips
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_buscar, "Buscar");
            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(Btn_aceptar, "Aceptar Selección");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(Btn_cancelar, "Cancelar Selección");
            ToolTip taplicarPrecios = new ToolTip();
            taplicarPrecios.SetToolTip(Btn_aplicar, "Aplicar Precios");
            ToolTip tcrearLista = new ToolTip();
            tcrearLista.SetToolTip(Btn_crear, "Crear Lista");
            ToolTip tcancelarLista = new ToolTip();
            tcancelarLista.SetToolTip(Btn_cancelarLista, "Cancelar Lista");
            ToolTip tactualizar = new ToolTip();
            tactualizar.SetToolTip(Btn_actualizar, "Actualizar cambios de Lista");
            ToolTip teditar = new ToolTip();
            teditar.SetToolTip(Btn_editar, "Editar encabezado Lista");
        }

        private void frm_ListadoPrecios_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarClasificaciones();
            CargarClasificacionesListas();
            CargarDatosEnDataGrid();
            CargarClasificacionesEditar();


            Cbo_clasificacionGeneral.DropDownStyle = ComboBoxStyle.DropDownList;

            // evento SelectedIndexChanged para el ComboBox de clasificaciones
            Cbo_clasificacionGeneral.SelectedIndexChanged += new EventHandler(Cbo_clasificacionGeneral_SelectedIndexChanged);
            //Cbo_clasificacionEspecifica.SelectedIndexChanged += Cbo_clasificacionEspecifica_SelectedIndexChanged;

            // evento TextChanged
            Txt_productobuscado.TextChanged += new EventHandler(Txt_productobuscado_TextChanged);
            Txt_clasificacionInventario.Text = "";

            //this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
        }

        // clasificaciones del tipo de lista (mayorista, minorista)
        private void CargarClasificacionesListas()
        {
            try
            {
                DataTable tableListas= logic.funconsultaLogicaClasificaciones();

                if (tableListas != null && tableListas.Rows.Count > 0)
                {
                    Cbo_tipoLista.DataSource = tableListas;
                    Cbo_tipoLista.DisplayMember = "Clasificaciones"; // El nombre de la columna mostrada
                    Cbo_tipoLista.ValueMember = "Pk_id_clasificacion"; // O el ID correspondiente
                }
                else
                {
                    MessageBox.Show("No hay datos disponibles para mostrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de listas: {ex.Message}");
            }
        }

        // carga/muestra productos segun la seleccion realizada en los combobox
        private void CargarProductos()
        {
            if (Cbo_clasificacionGeneral.SelectedItem != null)
                try
                {
                    // Obtener la clasificación seleccionada del ComboBox 
                    string clasificacion = Cbo_clasificacionGeneral.SelectedItem?.ToString();

                    if (string.IsNullOrEmpty(clasificacion))
                    {
                        Console.WriteLine("Error: Debes seleccionar una clasificación.");
                        return;
                    }

                    // Llamar los productos que concuerden con la clasificación seleccionada
                    DataTable dtProducto = logic.funconsultalogicaproductos(clasificacion);

                    
                    Cbo_clasificacionEspecifica.Items.Clear();

                    // Agregar productos al ComboBox
                    foreach (DataRow row in dtProducto.Rows)
                    {
                        // Concatenar el código y el nombre del producto
                        string displayText = $"{row["codigoProducto"]} - {row["nombreProducto"]}";
                        Cbo_clasificacionEspecifica.Items.Add(displayText);
                    }

                    Cbo_clasificacionEspecifica.SelectedIndexChanged += new EventHandler(Cbo_clasificacionEspecifica_SelectedIndexChanged);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al cargar productos: " + ex.Message);
                }
        }

        //carga clasificaciones generales (marca o linea)
        private void CargarClasificaciones()
        {
            DataTable dtClasificaciones = logic.funconsultarlogicaClasificaciones();

            if (dtClasificaciones != null && dtClasificaciones.Rows.Count > 0)
            {
                Cbo_clasificacionGeneral.DataSource = dtClasificaciones;
                Cbo_clasificacionGeneral.DisplayMember = "tipo"; // clasificaciones generales
                Cbo_clasificacionGeneral.ValueMember = "tipo";
            }
            else
            {
                MessageBox.Show("No se encontraron clasificaciones.");
            }
        }

        //muestra clasificaciones generales (marca o linea)
        private void Cbo_clasificacionGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_clasificacionGeneral.SelectedValue != null)
            {
                string seleccion = Cbo_clasificacionGeneral.SelectedValue.ToString();
                Txt_clasificacionInventario.Text = seleccion;
                CargarClasificacionesEspecificas(seleccion);
            }
            else
            {
                Txt_clasificacionInventario.Clear();
                Cbo_clasificacionEspecifica.DataSource = null;
                Cbo_clasificacionEspecifica.Enabled = false;
            }
        }

        //carga clasificaciones especificas marcas =  LG, ASUS, etc   y por lineas= Productos electronicos, zapatos, dormitorio, etc
        private void CargarClasificacionesEspecificas(string tipoClasificacion)
        {
            DataTable dtClasificacionesEspecificas = logic.CargarClasificacionesEspecificas(tipoClasificacion);

            // ComboBox de clasificaciones específicas
            if (dtClasificacionesEspecificas.Rows.Count > 0)
            {
                Cbo_clasificacionEspecifica.DataSource = dtClasificacionesEspecificas;
                Cbo_clasificacionEspecifica.DisplayMember = "clasificacion"; //subclasificaciones de las clasificaciones generales
                Cbo_clasificacionEspecifica.ValueMember = "clasificacion";
                Cbo_clasificacionEspecifica.Enabled = true;
            }
            else
            {
                Cbo_clasificacionEspecifica.DataSource = null;
                Cbo_clasificacionEspecifica.Enabled = false;
                //MessageBox.Show("No se encontraron clasificaciones específicas.");
            }
        }

        // Cargar productos según la clasificación específica
        private void Cbo_clasificacionEspecifica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cbo_clasificacionEspecifica.SelectedItem != null)
    {
                string clasificacionSeleccionada = Cbo_clasificacionEspecifica.SelectedValue.ToString();

                // Llama al método para cargar productos
                DataTable dtProductos = logic.CargarProductos(clasificacionSeleccionada);

                if (dtProductos != null && dtProductos.Rows.Count > 0)
                {
                    Dgv_detalleProductos.DataSource = dtProductos; // Muestra los productos en el DataGridView

                    // Oculta la columna del ID del producto
                    string nombreColumnaId = "Id"; // Cambia esto al nombre real de la columna ID en tu DataTable
                    if (Dgv_detalleProductos.Columns.Contains(nombreColumnaId))
                    {
                        Dgv_detalleProductos.Columns[nombreColumnaId].Visible = false; // Oculta la columna del ID ya que no es necesario que sea visualizado por el Usuario
                    }
                }
                else
                {
                    Dgv_detalleProductos.DataSource = null; // Limpia el DataGridView si no hay productos
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una clasificación específica.");
            }
        }

        // si se acepta la búsqueda de los productos que se encuentra en la primera datagris, se pasan para modificar su precio (crear precio de lista)
        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            if (Dgv_detalleProductos.DataSource != null)
            {
                // Crea un nuevo DataTable para el segundo DataGridView
                DataTable dtModificacion = new DataTable();

                // Clona la estructura de columnas del primer DataGridView, excepto las columnas especificadas
                foreach (DataGridViewColumn column in Dgv_detalleProductos.Columns)
                {
                    if (column.Name != "Precio_Unitario" &&
                        column.Name != "Costo_Compra") // Omitir las columnas especificadas
                    {
                        dtModificacion.Columns.Add(column.Name, column.ValueType);
                    }
                }

                // Copia todas las filas del primer DataGridView al segundo
                foreach (DataGridViewRow row in Dgv_detalleProductos.Rows)
                {
                    if (!row.IsNewRow) // Ignora la fila nueva si existe
                    {
                        DataRow newRow = dtModificacion.NewRow();

                        // Copia los datos de la fila, omitiendo las columnas especificadas
                        foreach (DataColumn column in dtModificacion.Columns)
                        {
                            newRow[column.ColumnName] = row.Cells[column.ColumnName].Value;
                        }

                        dtModificacion.Rows.Add(newRow);
                    }
                }

                // Asigna el DataTable al segundo DataGridView
                Dgv_seleccionados.DataSource = dtModificacion;

                // Verifica si la columna "Pk_id_Producto" existe en el segundo DataGridView y la oculta
                if (Dgv_seleccionados.Columns.Contains("Id"))
                {
                    Dgv_seleccionados.Columns["Id"].Visible = false;
                }

                // Verifica si hay filas copiadas y maneja el caso si no se copiaron filas
                if (dtModificacion.Rows.Count == 0)
                {
                    MessageBox.Show("No se copiaron filas.");
                }
            }
            else
            {
                MessageBox.Show("No hay productos para mover.");
            }
        }

        //seleccion para hacer descuento (resta)
        private void Rdb_precioventa_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_precioventa.Checked)
            {
                Txt_porcentaje.Visible = true; 
                Txt_porcentaje.Focus(); 
                Txt_forzado.Visible = false;
            }
            else
            {
                Txt_porcentaje.Visible = false;
                Txt_porcentaje.Clear();
                Txt_forzado.Visible = true;
            }
        }

        //seleccion para hacer aumento (suma)
        private void Rdb_costocompra_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_costocompra.Checked)
            {
                Txt_porcentaje.Visible = true; 
                Txt_porcentaje.Focus(); 
                Txt_forzado.Visible = false;
            }
            else
            {
                Txt_porcentaje.Visible = false; 
                Txt_porcentaje.Clear();
                Txt_forzado.Visible = true;
            }
        }

        private decimal[] preciosOriginales;

        // aumento o descuento, se coloca el porcentaje
        private void Txt_porcentaje_TextChanged(object sender, EventArgs e)
        {
            // Validar el valor ingresado en el TextBox como decimal positivo
            decimal porcentaje;
            bool esPorcentajeValido = decimal.TryParse(Txt_porcentaje.Text, out porcentaje) && porcentaje >= 0;

            // Cambiar el color de fondo del TextBox para indicar error
            Txt_porcentaje.BackColor = esPorcentajeValido ? System.Drawing.Color.White : System.Drawing.Color.LightCoral;

            // Habilitar o deshabilitar el botón de aplicar
            Btn_aplicar.Enabled = esPorcentajeValido;

            // Solo ejecutar el código si el porcentaje es válido
            if (!esPorcentajeValido)
            {
                return;
            }

            // Verificar si la columna "Precio_Lista" existe en Dgv_seleccionados
            if (!Dgv_seleccionados.Columns.Contains("Precio_Lista"))
            {
                Dgv_seleccionados.Columns.Add("Precio_Lista", "Precio de Lista");
            }

            // Verificar si se ha seleccionado un radio button
            if (Rdb_precioventa.Checked || Rdb_costocompra.Checked)
            {
                // Inicializar el array de precios originales si es necesario
                if (preciosOriginales == null || preciosOriginales.Length != Dgv_seleccionados.Rows.Count)
                {
                    preciosOriginales = new decimal[Dgv_seleccionados.Rows.Count];
                }

                foreach (DataGridViewRow row in Dgv_seleccionados.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Guardar el precio original si es la primera vez
                    if (preciosOriginales[row.Index] == 0)
                    {
                        preciosOriginales[row.Index] = Convert.ToDecimal(row.Cells["Precio_Venta"].Value);
                    }

                    decimal precioVenta = Convert.ToDecimal(row.Cells["Precio_Venta"].Value);
                    row.Cells["Precio_Lista"].Value = 0; // Reiniciar a cero

                    // Realizar cálculos dependiendo del radio button seleccionado
                    decimal nuevoPrecio;
                    if (Rdb_precioventa.Checked)
                    {
                        nuevoPrecio = Math.Round(precioVenta - (precioVenta * (porcentaje / 100)), 2);
                    }
                    else // Rdb_costocompra.Checked
                    {
                        nuevoPrecio = Math.Round(precioVenta + (precioVenta * (porcentaje / 100)), 2);
                    }

                    // Asignar el nuevo precio en la columna "Precio_Lista"
                    row.Cells["Precio_Lista"].Value = nuevoPrecio;
                    row.Cells["Precio_Lista"].Style.BackColor = System.Drawing.Color.LightGreen;
                }
            }
        }

        // ingreso del valor directo a enviarse a producto especifico
        private void Txt_forzado_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el RadioButton Rdb_forzar está seleccionado
            if (!Rdb_forzar.Checked)
            {
                return;
            }

            // Validar el valor ingresado en el TextBox como decimal positivo
            decimal precioForzado;
            bool esPrecioValido = decimal.TryParse(Txt_forzado.Text, out precioForzado) && precioForzado > 0;

            // Cambiar el color de fondo del TextBox para indicar error
            Txt_forzado.BackColor = esPrecioValido ? System.Drawing.Color.White : System.Drawing.Color.LightCoral;

            // Habilitar o deshabilitar el botón de aplicar
            Btn_aplicar.Enabled = esPrecioValido;

            // Solo ejecutar el código si el precio es válido
            if (!esPrecioValido)
            {
                return;
            }

            // Redondear el precio forzado a dos decimales y formatearlo
            decimal precioRedondeado = Math.Round(precioForzado, 2);
            string precioFormateado = precioRedondeado.ToString("0.00");

            // Verificar si la columna "Precio_Lista" existe en Dgv_seleccionados
            if (!Dgv_seleccionados.Columns.Contains("Precio_Lista"))
            {
                Dgv_seleccionados.Columns.Add("Precio_Lista", "Precio de Lista");
            }

            // Asignar el precio forzado a cada fila en la columna "Precio_Lista"
            foreach (DataGridViewRow row in Dgv_seleccionados.Rows)
            {
                if (row.IsNewRow) continue;

                row.Cells["Precio_Lista"].Value = precioFormateado;

                // Cambiar el color de fondo de la celda en "Precio_Lista"
                row.Cells["Precio_Lista"].Style.BackColor = System.Drawing.Color.LightGreen;
            }
        }

        // si se cancela se deseleccionan los cambios/ creación de precios de lista
        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            // Limpiar el primer DataGridView
            Dgv_detalleProductos.DataSource = null; 
            Dgv_detalleProductos.Rows.Clear(); 

            // Limpiar el segundo DataGridView
            Dgv_seleccionados.DataSource = null; 
            Dgv_seleccionados.Rows.Clear(); 

            // Eliminar la columna "Precio_Lista" si existe
            if (Dgv_seleccionados.Columns.Contains("Precio_Lista"))
            {
                Dgv_seleccionados.Columns.Remove("Precio_Lista");
            }

            // Limpiar combos
            Cbo_clasificacionGeneral.SelectedIndex = -1;
            Cbo_clasificacionEspecifica.SelectedIndex = -1;

            // Limpiar txt de búsqueda individual
            Txt_productobuscado.Text = null;
            MessageBox.Show("La selección ha sido limpiada.");
        }

        // si los precios de lista estan correctos segun lo necesitemos enviar todos los datos para el posterior guardado
        private void Btn_aplicar_Click(object sender, EventArgs e)
        {
            bool datosCompletos = true;

            // Verificar si al menos un RadioButton está seleccionado
            if (!Rdb_precioventa.Checked && !Rdb_costocompra.Checked && !Rdb_forzar.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de operación (Precio, Costo o Forzar).");
                datosCompletos = false;
            }

            // Lógica de validación según el RadioButton seleccionado
            if (Rdb_precioventa.Checked || Rdb_costocompra.Checked)
            {
                // Si se selecciona "Precio" o "Costo", el campo de porcentaje (descuento) debe tener un valor válido
                if (string.IsNullOrWhiteSpace(Txt_porcentaje.Text))
                {
                    MessageBox.Show("Debe ingresar un valor en el campo de porcentaje (descuento).");
                    Txt_porcentaje.Focus();
                    datosCompletos = false;
                }
                else if (!decimal.TryParse(Txt_porcentaje.Text, out decimal porcentaje) || porcentaje < 0)
                {
                    MessageBox.Show("Por favor, ingrese un porcentaje válido (no negativo).");
                    Txt_porcentaje.Focus();
                    datosCompletos = false;
                }

                // Si se selecciona "Precio" o "Costo", no debe haber valor en Txt_forzado
                if (!string.IsNullOrWhiteSpace(Txt_forzado.Text))
                {
                    MessageBox.Show("Si selecciona precio o costo, no debe llenar el campo de forzar.");
                    Txt_forzado.Focus();
                    datosCompletos = false;
                }
            }
            else if (Rdb_forzar.Checked)
            {
                // Si se selecciona "Forzar", no debe haber valor en Txt_porcentaje
                if (!string.IsNullOrWhiteSpace(Txt_porcentaje.Text))
                {
                    MessageBox.Show("Si selecciona 'Forzar', no debe llenar el campo de porcentaje.");
                    Txt_porcentaje.Focus();
                    datosCompletos = false;
                }

                // El campo Txt_forzado debe tener valor si está seleccionado "Forzar"
                if (string.IsNullOrWhiteSpace(Txt_forzado.Text))
                {
                    MessageBox.Show("Debe ingresar un valor en el campo de forzar.");
                    Txt_forzado.Focus();
                    datosCompletos = false;
                }
            }

            // Si algún dato está incompleto, salir de la función para permitir el llenado
            if (!datosCompletos)
            {
                return;
            }

            // Crear un nuevo DataTable para almacenar los datos combinados encabezado + detalle
            DataTable dtCombinado = new DataTable();

            // Definir las columnas
            dtCombinado.Columns.Add("Codigo Lista", typeof(int));
            dtCombinado.Columns.Add("Tipo de Lista", typeof(string));
            dtCombinado.Columns.Add("Estado", typeof(string));
            dtCombinado.Columns.Add("Fecha Creacion", typeof(string));
            dtCombinado.Columns.Add("Clasificacion Producto", typeof(string));
            dtCombinado.Columns.Add("Subclasificación", typeof(string));
            dtCombinado.Columns.Add("Id", typeof(int));
            dtCombinado.Columns.Add("Codigo Producto", typeof(int));
            dtCombinado.Columns.Add("Producto", typeof(string));
            dtCombinado.Columns.Add("Precio de Lista", typeof(decimal));

            // Obtener valores del encabezado del formulario
            int iCodigo = 0;
            string sClasificacion = string.Empty;
            string sEstado = string.Empty;
            string sFecha = string.Empty;

            // Verificar si los campos del encabezado están llenos
            if (string.IsNullOrWhiteSpace(Txt_codigo.Text) ||
                string.IsNullOrWhiteSpace(Cbo_tipoLista.Text) ||
                string.IsNullOrWhiteSpace(Cbo_estado.SelectedItem?.ToString()) ||
                string.IsNullOrWhiteSpace(Txt_fecha.Text))
            {
                MessageBox.Show("Debe llenar todos los campos del encabezado: Código, Tipo de Lista, Estado, Fecha.");
                return;
            }

            iCodigo = int.Parse(Txt_codigo.Text);
            sClasificacion = Cbo_tipoLista.Text;
            sEstado = Cbo_estado.SelectedItem.ToString();
            sFecha = Txt_fecha.Text;

            // Verificar que haya datos en Dgv_seleccionados
            if (Dgv_seleccionados.DataSource != null)
            {
                foreach (DataGridViewRow row in Dgv_seleccionados.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow productoRow = dtCombinado.NewRow();

                        // Agregar la información del encabezado
                        productoRow["Codigo Lista"] = iCodigo;
                        productoRow["Tipo de Lista"] = sClasificacion;
                        productoRow["Estado"] = sEstado;
                        productoRow["Fecha Creacion"] = sFecha;

                        // Agregar la información del producto
                        productoRow["Clasificacion Producto"] = row.Cells["Clasificacion"].Value;
                        productoRow["Subclasificación"] = row.Cells["Tipo"].Value;

                        // Validación del ID
                        var idValue = row.Cells["Id"].Value;
                        if (idValue != null && idValue != DBNull.Value)
                        {
                            productoRow["Id"] = Convert.ToInt32(idValue);
                        }
                        else
                        {
                            MessageBox.Show($"Fila {row.Index + 1}: El ID es nulo o inválido.");
                            continue;
                        }

                        productoRow["Codigo Producto"] = row.Cells["Codigo"].Value;
                        productoRow["Producto"] = row.Cells["Producto"].Value;
                        productoRow["Precio de Lista"] = row.Cells["Precio_Lista"].Value;

                        // Agregar la fila del producto al DataTable combinado
                        dtCombinado.Rows.Add(productoRow);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos en la lista de seleccionados.");
                return;
            }

            // Asignar el DataTable combinado al nuevo DataGridView
            Dgv_combinado.DataSource = dtCombinado;
            Dgv_combinado.Columns["Id"].Visible = false;

            if (dtCombinado.Rows.Count == 0)
            {
                MessageBox.Show("No se copiaron filas.");
            }
        }

        // buscar un producto por codigo o nombre especifico (hay que esperar unos 10 seg para que agarre la consulta)
        public void ConfigurarAutoCompletarProductos(TextBox txtBuscarProducto)
        {
            AutoCompleteStringCollection listaProductos = logic.funconsultalogicaProductosPorInventario();

            // Configuración del autocompletado en el TextBox
            txtBuscarProducto.AutoCompleteCustomSource = listaProductos;
            txtBuscarProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBuscarProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // busca segun el codigo o nombre especifico seleccionado
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = Txt_productobuscado.Text;

            // Verificar si el texto tiene al menos 1 carácter para realizar la búsqueda
            if (textoBusqueda.Length > 0)
            {
                // Obtiene la información del producto
                DataTable dtProductoSeleccionado = logic.funCargarProductos(textoBusqueda);

                // Si se encuentra un producto, mostrar la información 
                if (dtProductoSeleccionado.Rows.Count > 0)
                {
                    // Llenar el DataGridView con la información del producto
                    Dgv_detalleProductos.DataSource = dtProductoSeleccionado;

                    if (Dgv_detalleProductos.Columns.Contains("Id"))
                    {
                        Dgv_detalleProductos.Columns["Id"].Visible = false;
                    }
                }
                else
                {
                    Dgv_detalleProductos.DataSource = null;
                }
            }
            else
            {
                Dgv_detalleProductos.DataSource = null;
            }
        }

        private void Rdb_forzar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_tipoLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_productobuscado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        //fecha que se actualiza segun el dia
        private void Txt_fecha_TextChanged(object sender, EventArgs e)
        {
            Txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //si al verificar el encabezado + detalle la lista cumple con lo que se requiere, hay que crearla y almacenar en bd
        private void Btn_crear_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores del formulario
                if (!int.TryParse(Txt_codigo.Text, out int iCodigoEncabezado))
                {
                    MessageBox.Show("El código de encabezado no es un número válido.");
                    return;
                }

                if (!int.TryParse(Cbo_tipoLista.SelectedValue?.ToString(), out int iClasificacion))
                {
                    MessageBox.Show("La clasificación no es un número válido.");
                    return;
                }

                if (!DateTime.TryParseExact(Txt_fecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime sFecha))
                {
                    MessageBox.Show("La fecha no tiene un formato válido. Use el formato dd/MM/yyyy.");
                    return;
                }

                string sEstado = Cbo_estado.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(sEstado))
                {
                    MessageBox.Show("El estado debe seleccionarse.");
                    return;
                }

                // Insertar el encabezado
                bool resultadoEncabezado = logic.funinsertarListaEncabezado(iCodigoEncabezado, iClasificacion, sFecha, sEstado);

                if (resultadoEncabezado)
                {
                    bool detalleExitoso = true;

                    // Insertar detalles de productos asociados
                    foreach (DataGridViewRow row in Dgv_combinado.Rows)
                    {
                        if (row.IsNewRow) continue;

                        var idValue = row.Cells["Id"]?.Value;
                        var precioValue = row.Cells["Precio de Lista"]?.Value;

                        if (idValue == null || precioValue == null)
                        {
                            MessageBox.Show($"Error: El valor de ID o Precio Lista es nulo en la fila {row.Index + 1}.");
                            detalleExitoso = false;
                            continue;
                        }

                        if (int.TryParse(idValue.ToString(), out int iCodigoProducto) &&
                            decimal.TryParse(precioValue.ToString(), out decimal dPrecioLista))
                        {
                            bool resultadoDetalle = logic.funinsertarListaDetalle(iCodigoEncabezado, iCodigoProducto, dPrecioLista);

                            if (!resultadoDetalle)
                            {
                                detalleExitoso = false;
                                MessageBox.Show($"Error al guardar el detalle para el producto con ID {iCodigoProducto}.");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Error: No se pudo convertir el ID o el Precio en la fila {row.Index + 1}.");
                            detalleExitoso = false;
                        }
                    }

                    if (detalleExitoso)
                    {
                        MessageBox.Show("Datos guardados exitosamente en ambas tablas.");

                        //ActualizarDataGrid();
                        LimpiarFormulario();
                    }
                }
                else
                {
                    MessageBox.Show("Error al guardar el encabezado.");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al guardar datos: " + ex.Message);
            }
        }


        private void LimpiarFormulario()
        {
            Txt_codigo.Clear();
            Txt_fecha.Clear();
            Txt_productobuscado.Clear();
            Cbo_tipoLista.SelectedIndex = -1; 
            Cbo_estado.SelectedIndex = -1;
            Cbo_clasificacionEspecifica.SelectedIndex = -1; 
            Cbo_clasificacionGeneral.SelectedIndex = -1;

            //Dgv_seleccionados.Rows.Clear(); 
            //Dgv_detalleProductos.Rows.Clear(); 
        }

        private void Dgv_detalleProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // si no cumple solo se cancela, se borra del ultimo datagrid que es de donde se toma la informacion para guardar en bd
        private void Btn_cancelarLista_Click(object sender, EventArgs e)
        {
            Dgv_combinado.DataSource = null;
            Dgv_combinado.Rows.Clear(); 
        }


        //para editar encabezado
        public void CargarDatos(int codigoEncabezado, DateTime fecha, string estado, string nombreClasificacion)
        {
            Txt_codigo.Text = codigoEncabezado.ToString();
            Cbo_tipoLista.Text = nombreClasificacion; // Usar el nombre en lugar del ID
            Txt_fecha.Text = fecha.ToString("dd/MM/yyyy");
            Cbo_estado.Text = estado;

            CargarDetalles(codigoEncabezado);
        }

        private DataTable originalDataTable;
        private void CargarDetalles(int codigoEncabezado)
        {
            try
            {
                // Llama al método que obtiene los detalles 
                DataTable detalleTable = logic.funobtenerDetalle(codigoEncabezado);

                if (detalleTable == null || detalleTable.Rows.Count == 0)
                {
                    MessageBox.Show("No existen detalles para el encabezado seleccionado.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
                    Dgv_seleccionados.DataSource = null; // Limpia el DataGridView
                }
                else
                {
                   
                    Dgv_seleccionados.DataSource = detalleTable;

                    StringBuilder mensaje = new StringBuilder("Formato de las columnas:\n\n");
                    foreach (DataColumn columna in detalleTable.Columns)
                    {
                        mensaje.AppendLine($"Columna: {columna.ColumnName} - Tipo: {columna.DataType}");
                    }

                    //MessageBox.Show(mensaje.ToString(), "Información de las Columnas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles: " + ex.Message);
            }
        }

        private void Txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dgv_combinado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //mostrar encabezado y detalle persistente para edición
        public DataTable funCargarEncabezadoYDetalle()
        {
            DataTable resultTable = new DataTable();

            try
            {
                // Obtener encabezados
                DataTable encabezados = logic.funcargarEncabezados();
                if (encabezados == null || encabezados.Rows.Count == 0)
                {
                    Console.WriteLine("No se encontraron encabezados.");
                    return resultTable; // Devolver tabla vacía si no hay encabezados
                }

                // Crear columnas en el DataTable de resultado
                resultTable.Columns.Add("Codigo Lista");
                resultTable.Columns.Add("Tipo de Lista");
                resultTable.Columns.Add("Fecha Creacion");
                resultTable.Columns.Add("Estado");
                resultTable.Columns.Add("Clasificacion Producto");
                resultTable.Columns.Add("Subclasificacion");
                resultTable.Columns.Add("Producto");
                resultTable.Columns.Add("Codigo Producto");
                resultTable.Columns.Add("Precio de Lista");

                // Para cada encabezado, obtener detalles y llenar 
                foreach (DataRow encabezado in encabezados.Rows)
                {
                    if (!encabezado.Table.Columns.Contains("Codigo Lista"))
                    {
                        Console.WriteLine("Columna 'Codigo Lista' no encontrada en el encabezado.");
                        continue;
                    }

                    int idEncabezado = Convert.ToInt32(encabezado["Codigo Lista"]);
                    Console.WriteLine($"Procesando encabezado ID: {idEncabezado}");

                    if (idEncabezado <= 0)
                    {
                        Console.WriteLine("ID de encabezado no válido.");
                        continue; 
                    }

                    // Formatear fecha
                    string fechaCreacion = Convert.ToDateTime(encabezado["Fecha Creacion"]).ToString("dd/MM/yyyy");

                    // Convertir el estado de 1/0 a Activo/Inactivo
                    string estado = encabezado["Estado"].ToString() == "1" ? "Activo" : "Inactivo";

                    // obtener detalles- aun no los toma, solo se actuliza el encabezado
                    DataTable detalles = logic.funobtenerDetalle(idEncabezado);
                    if (detalles == null)
                    {
                        Console.WriteLine($"No se encontraron detalles para el encabezado ID: {idEncabezado}");
                    }
                    else
                    {
                        Console.WriteLine($"Encabezado ID: {idEncabezado}, Detalles encontrados: {detalles.Rows.Count}");
                    }

                    // Si no hay detalles, agregar solo el encabezado
                    if (detalles == null || detalles.Rows.Count == 0)
                    {
                        resultTable.Rows.Add(encabezado["Codigo Lista"], encabezado["Tipo de Lista"],
                                              fechaCreacion, estado, "", "", "", "", "");
                    }
                    else
                    {
                        // Agregar cada detalle asociado al encabezado
                        foreach (DataRow detalle in detalles.Rows)
                        {
                            resultTable.Rows.Add(encabezado["Codigo Lista"], encabezado["Tipo de Lista"],
                                                  fechaCreacion, estado,
                                                  detalle["Clasificacion Producto"], detalle["Subclasificacion"],
                                                  detalle["Producto"], detalle["Codigo Producto"],
                                                  detalle["Precio Lista"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener encabezados y detalles: " + ex.Message);
            }

            return resultTable;
        }

        //muestra encabezado + detalle de las listas ya creadas
        private void CargarDatosEnDataGrid()
        {
            DataTable datos = funCargarEncabezadoYDetalle();
            Dgv_combinado.DataSource = datos; 
        }

        // edita los encabezados
        private void Btn_editar_Click(object sender, EventArgs e)
        {
            // Deshabilitar el campo de texto para que no sea interactuable
            Txt_codigo.Enabled = false;
            Txt_porcentaje.Enabled = false;
            Txt_forzado.Enabled = false;
            Rdb_costocompra.Enabled = false;
            Rdb_precioventa.Enabled = false;
            Rdb_forzar.Enabled = false;
            Btn_aplicar.Enabled = false;
            Btn_crear.Enabled = false;
            Btn_cancelarLista.Enabled = false;

            try
            {
                if (Dgv_combinado.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = Dgv_combinado.SelectedRows[0];

                    // Validación de campos vacíos
                    if (filaSeleccionada.Cells["Codigo Lista"].Value == null ||
                        filaSeleccionada.Cells["Tipo de Lista"].Value == null ||
                        filaSeleccionada.Cells["Fecha Creacion"].Value == null ||
                        filaSeleccionada.Cells["Estado"].Value == null)
                    {
                        MessageBox.Show("Uno o más campos están vacíos.", "Error");
                        return;
                    }

                    // Validación de código
                    int iCodigoEncabezado;
                    if (!int.TryParse(filaSeleccionada.Cells["Codigo Lista"].Value.ToString(), out iCodigoEncabezado))
                    {
                        MessageBox.Show("El código de la lista tiene un formato incorrecto.", "Error");
                        return;
                    }

                    string nombreClasificacion = filaSeleccionada.Cells["Tipo de Lista"].Value.ToString();

                    // Validación de la fecha de creación
                    DateTime sFecha;
                    if (!DateTime.TryParse(filaSeleccionada.Cells["Fecha Creacion"].Value.ToString(), out sFecha))
                    {
                        MessageBox.Show("La fecha de creación tiene un formato incorrecto.", "Error");
                        return;
                    }

                    // Verificación del valor de estado
                    string estadoString = filaSeleccionada.Cells["Estado"].Value?.ToString();
                    if (string.IsNullOrEmpty(estadoString) ||
                        (!estadoString.Equals("Activo") && !estadoString.Equals("Inactivo")))
                    {
                        MessageBox.Show("El estado tiene un formato incorrecto. Debe ser 'Activo' o 'Inactivo'.", "Error");
                        return;
                    }

                    // Llamada a métodos para cargar los datos
                    CargarDatos(iCodigoEncabezado, sFecha, estadoString, nombreClasificacion);
                    CargarDetalles(iCodigoEncabezado);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila para mostrar los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar mostrar los datos: " + ex.Message, "Error");
            }
        }

        private Dictionary<string, int> clasificacionesDict;

        //llama la informacion de la lista que se quiere editar
        private void CargarClasificacionesEditar()
        {
            try
            {
                DataTable tableListas = logic.funcargarEncabezadosPorTipo();

                clasificacionesDict = new Dictionary<string, int>(); 

                if (tableListas != null && tableListas.Rows.Count > 0)
                {
                    Cbo_tipoLista.DataSource = tableListas;
                    Cbo_tipoLista.DisplayMember = "Clasificaciones"; 
                    Cbo_tipoLista.ValueMember = "Pk_id_clasificacion"; 

                    foreach (DataRow row in tableListas.Rows)
                    {
                        int id = Convert.ToInt32(row["Pk_id_clasificacion"]);
                        string nombre = row["Clasificaciones"].ToString();
                        clasificacionesDict[nombre] = id; 
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos disponibles para mostrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de listas: {ex.Message}");
            }
        }

        // luego de editar hay que actualizar los cambios
        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            // Deshabilitar los campos de texto para evitar edición durante la actualización
            Txt_codigo.Enabled = false;
            Txt_porcentaje.Enabled = false;
            Txt_forzado.Enabled = false;
            Rdb_costocompra.Enabled = false;
            Rdb_precioventa.Enabled = false;
            Rdb_forzar.Enabled = false;
            Btn_aplicar.Enabled = false;
            Btn_crear.Enabled = false;
            Btn_cancelarLista.Enabled = false;

            try
            {
                // Verificar si hay una fila seleccionada en el DataGridView
                if (Dgv_combinado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione al menos una fila para actualizar.");
                    return;
                }

                // Obtener valores para el encabezado
                DataGridViewRow filaSeleccionada = Dgv_combinado.SelectedRows[0];
                int iCodigoEncabezado = Convert.ToInt32(filaSeleccionada.Cells["Codigo Lista"].Value);
                int nuevoCodigo = (string.IsNullOrEmpty(Txt_codigo.Text)) ? iCodigoEncabezado : Convert.ToInt32(Txt_codigo.Text);
                int iClasificacion = Convert.ToInt32(Cbo_tipoLista.SelectedValue);
                DateTime sFecha = DateTime.Parse(Txt_fecha.Text);
                string sEstado = Cbo_estado.SelectedItem.ToString();

                // Mostrar valores para depuración
                MessageBox.Show($"Intentando actualizar encabezado con:\nCódigo: {nuevoCodigo}\nClasificación: {iClasificacion}\nFecha: {sFecha}\nEstado: {sEstado}");

                // Actualizar el encabezado
                bool exitoEncabezado = logic.funlogicaactualizarEncabezado(nuevoCodigo, iClasificacion, sFecha, sEstado) != null;

                // Verificar si la actualización del encabezado fue exitosa
                if (exitoEncabezado)
                {
                    MessageBox.Show("Encabezado actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Encabezado actualizado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la actualización: {ex.Message}\nDetalles: {ex.StackTrace}");
            }
            finally
            {
                // Habilitar los campos de texto después de finalizar la actualización
                Txt_codigo.Enabled = true;
                Txt_porcentaje.Enabled = true;
                Txt_forzado.Enabled = true;
                Rdb_costocompra.Enabled = true;
                Rdb_precioventa.Enabled = true;
                Rdb_forzar.Enabled = true;
                Btn_aplicar.Enabled = true;
                Btn_crear.Enabled = true;
                Btn_cancelarLista.Enabled = true;

            }

        }

    }
}