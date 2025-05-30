using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_MiguelCrisostomo;
using Capa_Modelo_MiguelCrisostomo;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.IO;

namespace Capa_Vista_MiguelCrisostomo
{
    public partial class TrasladoDeProductos : Form
    {
        controlador controlador = new controlador();
        private sentencias modelo = new sentencias(); // Instancia de la clase 'sentencias'
        private conexion conn = new conexion();


        //CONSTRUCTOR__*************************************************************************************************
        public TrasladoDeProductos()
        {
            InitializeComponent();// Inicializa los componentes del formulario
            
            // Agregar los controles al formulario
            this.Controls.Add(this.Cbo_TipoInformee);
            
            // Deshabilitar campos inicialmente
            Cbo_Vehiculo.Enabled = false;
            Cbo_CodigoProd.Enabled = false;
            Dtp_Fecha_Traslado.Enabled = false;
            Txt_Cantidad.Enabled = false;
            
            CargarDestinos(); // Cargar destinos al iniciar el formulario
            CargarCodigosProductos(); // Cargar códigos de productos  
            CargarVehiculos(); // Cargar vehículos al iniciar el formulario
            CargarSucursales(); // Cargar sucursales al iniciar el formulario
            CargarBodegasOrigen(); // Cargar bodegas de origen al iniciar el formulario

            // Configurar el ComboBox de selección de informe
            Cbo_TipoInformee.Items.Add("Informe salida TDP");
            Cbo_TipoInformee.Items.Add("Informe entrada TDP");
            Cbo_TipoInformee.SelectedIndex = 0; // Seleccionar el primer elemento por defecto
            Cbo_TipoInformee.SelectedIndexChanged += Cbo_TipoInformee_SelectedIndexChanged;

            // Configurar el DataGridView de productos
            Dgv_Productos.Columns.Add("codigoProducto", "Código");
            Dgv_Productos.Columns.Add("nombreProducto", "Nombre");
            Dgv_Productos.Columns.Add("stock", "Stock");
            Dgv_Productos.Columns.Add("cantidad", "Cantidad");
            Dgv_Productos.Columns.Add("precioUnitario", "Precio Unitario");
            Dgv_Productos.Columns.Add("pesoProducto", "Peso");
            Dgv_Productos.Columns.Add("stockRestante", "Stock Restante");

            // Configurar el DataGridView
            Dgv_Productos.AllowUserToAddRows = false;
            Dgv_Productos.AllowUserToDeleteRows = true;
            Dgv_Productos.ReadOnly = true;
            Dgv_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Productos.MultiSelect = false;

            // Cambiar el color de fondo a blanco
            Dgv_Productos.BackgroundColor = Color.White;
            Dgv_Productos.DefaultCellStyle.BackColor = Color.White;

            // Configurar el TextBox de destino para autocompletado
            TxtDESTINO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TxtDESTINO.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtDESTINO.AutoCompleteCustomSource = new AutoCompleteStringCollection();

            // Configurar el TextBox de búsqueda para autocompletado
            Txt_Busqueda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Txt_Busqueda.AutoCompleteCustomSource = new AutoCompleteStringCollection();

            TxtDESTINO.TextChanged += TxtDESTINO_TextChanged; // Enlazar el evento para destinos
            Cbo_CodigoProd.SelectedIndexChanged += new EventHandler(Cbo_CodigoProd_SelectedIndexChanged); // Enlaza el evento cuando cambia la selección del combo de códigos de productos
            Txt_Cantidad.TextChanged += Txt_Cantidad_TextChanged;
            Cbo_Vehiculo.SelectedIndexChanged += Cbo_Vehiculo_SelectedIndexChanged;
            Txt_Busqueda.TextChanged += Txt_Busqueda_TextChanged; // Enlazar el evento para la búsqueda

            // Desactivar algunos TextBoxes
            Txt_Id1.Enabled = false;
            Txt_Vehiculo.Enabled = false;
            Txt_Id2.Enabled = false;
            Txt_NombreProd.Enabled = false;
            Txt_PesoProd.Enabled = false;
            Txt_Stock.Enabled = false;
            Txt_PrecioU.Enabled = false;
            Lbl_CostoTProd.Enabled = true;
            Txt_PesoTotalV.Enabled = false;
            Pic_Ingresar.Click += new EventHandler(Pic_Ingresar_Click);
            Txt_Cantidad.Enabled = true;

            // Enlazar eventos para los botones
            Pic_Actualizar.MouseEnter += Pic_Actualizar_MouseEnter;
            Pic_Actualizar.MouseLeave += Pic_Actualizar_MouseLeave;
            Pic_Aceptar.MouseEnter += Pic_Aceptar_MouseEnter;
            Pic_Aceptar.MouseLeave += Pic_Aceptar_MouseLeave;
            Pic_Ingresar.MouseEnter += Pic_Ingresar_MouseEnter;
            Pic_Ingresar.MouseLeave += Pic_Ingresar_MouseLeave;
            Pic_Editar.MouseEnter += Pic_Editar_MouseEnter;
            Pic_Editar.MouseLeave += Pic_Editar_MouseLeave;
            Pic_Guardar.MouseEnter += Pic_Guardar_MouseEnter;
            Pic_Guardar.MouseLeave += Pic_Guardar_MouseLeave; 
            Pic_Salir.MouseEnter += Pic_Salir_MouseEnter;
            Pic_Salir.MouseLeave += Pic_Salir_MouseLeave;
            Pic_Reporte.MouseEnter += Pic_Reporte_MouseEnter;
            Pic_Reporte.MouseLeave += Pic_Reporte_MouseLeave;
            Pic_Ayuda.MouseEnter += Pic_Ayuda_MouseEnter;
            Pic_Ayuda.MouseLeave += Pic_Ayuda_MouseLeave;
            Pic_InformeBs.MouseEnter += Pic_InformeBs_MouseEnter;
            Pic_InformeBs.MouseLeave += Pic_InformeBs_MouseLeave;
            Pic_CanselarTDP.MouseEnter += Pic_CanselarTDP_MouseEnter;
            Pic_CanselarTDP.MouseLeave += Pic_CanselarTDP_MouseLeave;
            Pic_Agregar.MouseEnter += Pic_Agregar_MouseEnter;
            Pic_Agregar.MouseLeave += Pic_Agregar_MouseLeave;
            Pic_NuevoTrasladoP.Click += new EventHandler(Pic_NuevoTrasladoP_Click);
            Pic_NuevoTrasladoP.MouseEnter += Pic_NuevoTrasladoP_MouseEnter;
            Pic_NuevoTrasladoP.MouseLeave += Pic_NuevoTrasladoP_MouseLeave;
            Pic_Agregar.Click += new EventHandler(Pic_Agregar_Click);
            Pic_CanselarTDP.Click += new System.EventHandler(this.Pic_CanselarTDP_Click);
            Pic_InformeBs.Click += new EventHandler(Pic_InformeBs_Click);

            // Agregar evento para manejar la eliminación de filas
            Dgv_Productos.RowsRemoved += Dgv_Productos_RowsRemoved;

            // Agregar el evento CellClick para el DataGridView de traslados
            Dgv_TrasladoDProductos.CellClick += Dgv_TrasladoDProductos_CellClick;

            // Configurar el DataGridView de detalles
            ConfigurarDataGridViewDetalles();

            // Agregar evento para validar la selección de bodegas
            Cbo_BodegaOrigen.SelectedIndexChanged += Cbo_BodegaOrigen_SelectedIndexChanged;
            Cbo_Sucursal.SelectedIndexChanged += Cbo_Sucursal_SelectedIndexChanged;
        }

        // Evento para manejar la eliminación de filas del DataGridView
        private void Dgv_Productos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                // Actualizar el peso total cuando se elimina una fila
                ActualizarPesoTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el peso después de eliminar la fila: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// INSTRUCCION PARA CARGAR LOS CODIGOS EN EL Cbo_CodigoProd ******************************************************
        private void CargarCodigosProductos()
        {
            try
            {
                List<int> codigosProductos = controlador.ObtenerCodigosProductos(); // Llama al método en el controlador
                Cbo_CodigoProd.Items.Clear();

                // Establece el modo de autocompletado
                Cbo_CodigoProd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                Cbo_CodigoProd.AutoCompleteSource = AutoCompleteSource.ListItems;


                foreach (int codigo in codigosProductos)
                {
                    Cbo_CodigoProd.Items.Add(codigo); // Agrega cada código de producto al ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar códigos de productos: " + ex.Message);
            }
        }

        //Llamar a CargarCodigosProductos en el Load del formulario
        private void TrasladoDeProductos_Load(object sender, EventArgs e)
        {
            // Llama al método para cargar los códigos de productos en el ComboBox
            CargarCodigosProductos();
        }


        /// EVENTO PARA MOSTRAR EL nombreProducto ******************************************************
        private void Cbo_CodigoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarSeleccionBodegasCompleta())
                {
                    Cbo_CodigoProd.SelectedIndex = -1;
                    return;
                }

                if (Cbo_CodigoProd.SelectedItem != null)
                {
                    int codigoProducto = (int)Cbo_CodigoProd.SelectedItem;
                    
                    // Actualizar el stock en tiempo real
                    int stockActual = controlador.ObtenerStockProductoPorCodigo(codigoProducto);
                    Txt_Stock.Text = stockActual.ToString();

                    // Bloquear Txt_Cantidad si el stock es cero
                    if (stockActual == 0)
                    {
                        Txt_Cantidad.Enabled = false;
                        Txt_Cantidad.Clear();
                        MessageBox.Show("No hay stock disponible para este producto.", "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Txt_Cantidad.Enabled = true;
                    }

                    // Obtener y mostrar nombreProducto
                    string nombreProducto = controlador.ObtenerNombreProductoPorCodigo(codigoProducto);
                    Txt_NombreProd.Text = nombreProducto;

                    // Obtener y mostrar pesoProducto como texto
                    string pesoProducto = controlador.ObtenerPesoProductoPorCodigo(codigoProducto);
                    Txt_PesoProd.Text = pesoProducto;

                    // Obtener y mostrar precio
                    decimal precioProducto = controlador.ObtenerPrecioProductoPorCodigo(codigoProducto);
                    Txt_PrecioU.Text = precioProducto.ToString();

                    // Obtener y mostrar el ID del producto
                    int idProducto = controlador.ObteneridProductoPorCodigo(codigoProducto);
                    Txt_Id2.Text = idProducto.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener información del producto: " + ex.Message);
            }
        }

        //CALCULO DE "COSTO TOTAL"*****************************************************



        // Definir un ancho máximo para el Label  
        private const int MaxLabelWidth = 50; // Ajusta este valor según sea necesario  


        // Evento para recalcular el costo total al cambiar la cantidad
        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarSeleccionBodegasCompleta())
            {
                Txt_Cantidad.Clear();
                return;
            }
            // Verificar si el stock es cero
            if (int.TryParse(Txt_Stock.Text, out int stock) && stock == 0)
            {
                Txt_Cantidad.Enabled = false;
                Txt_Cantidad.Clear();
                MessageBox.Show("No hay stock disponible para este producto.", "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si ambos valores son válidos antes de calcular  
            if (decimal.TryParse(Txt_Cantidad.Text, out decimal cantidad) &&
                decimal.TryParse(Txt_PrecioU.Text, out decimal precioUnitario) &&
                int.TryParse(Txt_Stock.Text, out int stockDisponible))
            {
                // Bloquear el TextBox si la cantidad supera el stock disponible  
                if (cantidad > stockDisponible)
                {
                    Txt_Cantidad.Enabled = false; // Bloquear el TextBox  
                    MessageBox.Show("La cantidad excede el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir de la función  
                }
                else
                {
                    Txt_Cantidad.Enabled = true; // Asegurarte de que se re-habilita el TextBox si la cantidad es válida  
                }

                // Calcular el costo total  
                decimal costoTotal = cantidad * precioUnitario;

                // Mostrar el costo total en Lbl_CostoTProd, aplicando formato  
                string costoTotalText = costoTotal.ToString("F2"); // Formato de dos decimales  

                // Truncar el texto si excede el ancho máximo  
                if (TextRenderer.MeasureText(costoTotalText, Lbl_CostoTProd.Font).Width > MaxLabelWidth)
                {
                    costoTotalText = costoTotalText.Substring(0, Math.Min(costoTotalText.Length, 7)); // Ajusta el número según sea necesario  
                }

                // Asignar el texto al Label  
                Lbl_CostoTProd.Text = costoTotalText;
            }
            else
            {
                // Si la cantidad o el precio unitario no son válidos, asignar "0.00" al campo de costo total  
                Lbl_CostoTProd.Text = "0.00";

                // Si no hay una cantidad válida, restablecer el Txt_Stock para reflejar el stock original  
                if (int.TryParse(Txt_Stock.Text, out int stockOriginal))
                {
                    Txt_Stock.Text = stockOriginal.ToString();
                }
            }
        }


        //*************************************************************************************************************
        /// INSTRUCCION PARA CARGAR INFORMACION EN EL TxtDESTINO ******************************************************
        private void CargarDestinos()
        {
            try
            {
                // Configurar el TextBox de destino para autocompletado
                TxtDESTINO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TxtDESTINO.AutoCompleteSource = AutoCompleteSource.CustomSource;
                TxtDESTINO.AutoCompleteCustomSource = new AutoCompleteStringCollection();

                List<string> destinos = modelo.ObtenerDestinos(); // Llama al método ObtenerDestinos
                foreach (string destino in destinos)
                {
                    TxtDESTINO.AutoCompleteCustomSource.Add(destino); // Agrega cada destino al AutoCompleteCustomSource
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar destinos: " + ex.Message);
            }
        }

        /// EVENTO PARA MOSTRAR EL ID AL SELECCIONAR UN DESTINO ******************************************************
        private void TxtDESTINO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay un texto ingresado  
                if (!string.IsNullOrEmpty(TxtDESTINO.Text))
                {
                    //METODOS_________________*****************************************
                    // Obtener y mostrar el ID de guía
                    string destinoSeleccionado = TxtDESTINO.Text;
                    int idGuia = controlador.ObtenerIdGuiaPorDestino(destinoSeleccionado); // Llama al método en el controlador
                    Txt_Id1.Text = idGuia.ToString(); // Muestra el ID en el TextBox

                    // Obtener y mostrar la marca del vehículo
                    string marcaVehiculo = modelo.ObtenerMarcaVehiculoPorDestino(destinoSeleccionado);
                    Txt_Vehiculo.Text = marcaVehiculo;

                    // Obtener y mostrar el peso total del vehículo
                    int pesoTotalVehiculo = modelo.ObtenerPesoTotalVehiculoPorDestino(destinoSeleccionado);
                    Txt_PesoTotalV.Text = pesoTotalVehiculo.ToString(); // Muestra el peso total en el TextBox correspondiente
                }
                else
                {
                    // Manejar el caso donde no hay un destino seleccionado  
                    Txt_Id1.Text = string.Empty;
                    Txt_Vehiculo.Text = string.Empty;
                    Txt_PesoTotalV.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del destino: " + ex.Message);
            }
        }

        // iNSTRUCCION PARA CARGAR LA INFORMACION AL DATAGRIDVIEW 
        private void CargarDatosTraslado()
        {
            try
            {
                // Usar conn para obtener la conexión
                OdbcConnection connection = conn.Conexion();
                string query = "SELECT Pk_id_TrasladoProductos, documento, fecha, costoTotal, costoTotalGeneral, precioTotal, codigoProducto, Fk_id_guia FROM Tbl_TrasladoProductos";

                OdbcDataAdapter adapter = new OdbcDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Dgv_TrasladoDProductos.DataSource = dataTable;

                // Cambia el nombre de la columna después de establecer el DataSource  
                Dgv_TrasladoDProductos.Columns["Pk_id_TrasladoProductos"].HeaderText = "Traslado";

                // Cambia el nombre de la columna después de establecer el DataSource  
                Dgv_TrasladoDProductos.Columns["Fk_id_guia"].HeaderText = "Guia";

                // Ocultar la columna 'Guia'
                if (Dgv_TrasladoDProductos.Columns.Contains("Fk_id_guia"))
                {
                    Dgv_TrasladoDProductos.Columns["Fk_id_guia"].Visible = false;
                }

                // Cargar sugerencias de autocompletado
                CargarSugerenciasAutocompletado(dataTable);

                // Cerrar la conexión
                conn.desconexion(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de traslado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarSugerenciasAutocompletado(DataTable dataTable)
        {
            try
            {
                // Limpiar las sugerencias existentes
                Txt_Busqueda.AutoCompleteCustomSource.Clear();

                // Crear un HashSet para evitar duplicados
                HashSet<string> sugerencias = new HashSet<string>();

                // Recorrer todas las filas y columnas del DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn col in dataTable.Columns)
                    {
                        string valor = row[col].ToString();
                        if (!string.IsNullOrWhiteSpace(valor))
                        {
                            sugerencias.Add(valor);
                        }
                    }
                }

                // Agregar las sugerencias al AutoCompleteCustomSource
                foreach (string sugerencia in sugerencias)
                {
                    Txt_Busqueda.AutoCompleteCustomSource.Add(sugerencia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sugerencias de autocompletado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
        private void label12_Click(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {}

        private void Pic_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar campos de productos
                Txt_Id2.Clear();
                Cbo_CodigoProd.SelectedIndex = -1;
                Txt_NombreProd.Clear();
                Txt_PesoProd.Clear();
                Txt_Stock.Clear();
                Txt_Cantidad.Clear();
                Txt_PrecioU.Clear();
                Lbl_CostoTProd.Text = "0.00";
                Txt_PesoTotalV.Clear();

                // Limpiar campos adicionales
                Lbl_PesoV.Text = "0";
                Cbo_Vehiculo.SelectedIndex = -1;
                Cbo_Sucursal.SelectedIndex = -1;
                Cbo_BodegaOrigen.SelectedIndex = -1;

                // Limpiar el DataGridView de productos
                Dgv_Productos.Rows.Clear();

                // Mostrar mensaje de éxito
                MessageBox.Show("Campos limpiados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar los campos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pic_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarSeleccionBodegasCompleta())
                {
                    return;
                }

                // Verificar si hay productos en el DataGridView
                if (Dgv_Productos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay productos agregados para realizar el traslado.", 
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el peso total del vehículo
                if (!int.TryParse(Txt_PesoTotalV.Text, out int pesoTotalVehiculo))
                {
                    MessageBox.Show("El peso total del vehículo no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que el peso total de los productos no exceda el peso del vehículo
                int pesoTotalProductos = 0;
                foreach (DataGridViewRow row in Dgv_Productos.Rows)
                {
                    if (row.Cells["pesoProducto"].Value != null)
                    {
                        pesoTotalProductos += Convert.ToInt32(row.Cells["pesoProducto"].Value);
                    }
                }

                if (pesoTotalProductos > pesoTotalVehiculo)
                {
                    MessageBox.Show("El peso total de los productos excede el peso soportado por el vehículo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la fecha del DateTimePicker
                DateTime fechaTraslado = Dtp_Fecha_Traslado.Value;
                string fecha = fechaTraslado.ToString("yyyy-MM-dd");

                // Validar ID de guía
                if (!int.TryParse(Txt_Id1.Text, out int idGuia))
                {
                    MessageBox.Show("El ID de guía no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Generar un único documento para todo el traslado
                string documento = controlador.ObtenerSiguienteDocumentoConFormato();

                // Calcular el costo total general de todos los productos
                decimal costoTotalGeneral = 0;
                foreach (DataGridViewRow row in Dgv_Productos.Rows)
                {
                    int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["precioUnitario"].Value);
                    costoTotalGeneral += cantidad * precioUnitario;
                }

                // Obtener el primer producto para el registro principal
                DataGridViewRow firstRow = Dgv_Productos.Rows[0];
                int primerCodigoProducto = Convert.ToInt32(firstRow.Cells["codigoProducto"].Value);
                decimal primerPrecioUnitario = Convert.ToDecimal(firstRow.Cells["precioUnitario"].Value);
                int primerIdProducto = controlador.ObteneridProductoPorCodigo(primerCodigoProducto);

                // Registrar el traslado principal una sola vez
                controlador.registrarTrasladoProductos(
                    documento,
                    fecha,
                    (int)costoTotalGeneral,
                    (int)costoTotalGeneral,
                    (int)primerPrecioUnitario,
                    primerIdProducto,
                    idGuia,
                    primerCodigoProducto,
                    Cbo_BodegaOrigen.SelectedItem?.ToString(),
                    Cbo_Sucursal.SelectedItem?.ToString()
                );

                // Obtener el ID del traslado recién creado
                int idTraslado = controlador.ObtenerIdTrasladoPorDocumento(documento);

                // Insertar en tbl_movimiento_de_inventario para el documento de salida
                using (OdbcConnection connection = conn.Conexion())
                {
                    // Obtener el ID de la bodega de origen
                    string queryBodega = "SELECT Pk_ID_BODEGA FROM TBL_BODEGAS WHERE NOMBRE_BODEGA = ?";
                    using (OdbcCommand cmdBodega = new OdbcCommand(queryBodega, connection))
                    {
                        cmdBodega.Parameters.AddWithValue("@bodega", Cbo_BodegaOrigen.SelectedItem.ToString());
                        int idBodegaOrigen = Convert.ToInt32(cmdBodega.ExecuteScalar());

                        foreach (DataGridViewRow row in Dgv_Productos.Rows)
                        {
                            int codigoProducto = Convert.ToInt32(row.Cells["codigoProducto"].Value);
                            int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                            int idProducto = controlador.ObteneridProductoPorCodigo(codigoProducto);

                            // Insertar el movimiento de inventario
                            string queryMovimiento = @"
                                INSERT INTO tbl_movimiento_de_inventario 
                                (Fk_id_producto, stock, Fk_id_traslado, Fk_ID_BODEGA, Cantidad_almacen, Fk_id_compra, tipo_movimiento) 
                                VALUES (?, ?, ?, ?, ?, NULL, 'SALIDA')";

                            using (OdbcCommand cmdMovimiento = new OdbcCommand(queryMovimiento, connection))
                            {
                                cmdMovimiento.Parameters.AddWithValue("@idProducto", idProducto);
                                cmdMovimiento.Parameters.AddWithValue("@stock", cantidad);
                                cmdMovimiento.Parameters.AddWithValue("@idTraslado", idTraslado);
                                cmdMovimiento.Parameters.AddWithValue("@idBodega", idBodegaOrigen);
                                cmdMovimiento.Parameters.AddWithValue("@cantidadAlmacen", cantidad); // Puedes ajustar este valor si tienes el stock actual
                                cmdMovimiento.ExecuteNonQuery();
                            }
                        }
                    }
                }

                // Registrar el documento de entrada con el mismo documento
                controlador.registrarEntradaProductos(
                    documento, // Usar el mismo documento
                    fecha,
                    //(int)costoTotalGeneral,
                    //(int)costoTotalGeneral,
                    //(int)primerPrecioUnitario,
                    (int)costoTotalGeneral,      // costoTotal
                    (int)costoTotalGeneral,      // costoTotalGeneral
                    (int)primerPrecioUnitario,   // precioTotal
                    primerIdProducto,
                    idGuia,
                    Cbo_BodegaOrigen.SelectedItem?.ToString(),
                    Cbo_Sucursal.SelectedIndex > -1 ? Cbo_Sucursal.SelectedItem.ToString() : null
                );

                // Obtener el ID de la entrada recién creada
                int idEntrada = controlador.ObtenerIdEntradaPorDocumento(documento);

                // Registrar los detalles de cada producto y actualizar el stock
                using (OdbcConnection connection = conn.Conexion())
                {
                    foreach (DataGridViewRow row in Dgv_Productos.Rows)
                    {
                        int codigoProducto = Convert.ToInt32(row.Cells["codigoProducto"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                        decimal precioUnitario = Convert.ToDecimal(row.Cells["precioUnitario"].Value);
                        decimal costoTotal = cantidad * precioUnitario;
                        int idProducto = controlador.ObteneridProductoPorCodigo(codigoProducto);

                        // Registrar el detalle del producto en la tabla de traslado
                        string queryDetalle = @"
                            INSERT INTO Tbl_DetalleTrasladoProductos 
                            (Fk_id_TrasladoProductos, codigoProducto, cantidad, precioUnitario, costoTotal) 
                            VALUES (?, ?, ?, ?, ?)";

                        using (OdbcCommand cmd = new OdbcCommand(queryDetalle, connection))
                        {
                            cmd.Parameters.AddWithValue("@idTraslado", idTraslado);
                            cmd.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@precioUnitario", (int)precioUnitario);
                            cmd.Parameters.AddWithValue("@costoTotal", (int)costoTotal);
                            cmd.ExecuteNonQuery();
                        }

                        // Registrar el detalle del producto en la tabla de entrada
                        string queryDetalleEntrada = @"
                            INSERT INTO Tbl_DetalleEntradaProductos 
                            (Fk_id_EntradaProductos, codigoProducto, cantidad, precioUnitario, costoTotal) 
                            VALUES (?, ?, ?, ?, ?)";

                        using (OdbcCommand cmd = new OdbcCommand(queryDetalleEntrada, connection))
                        {
                            cmd.Parameters.AddWithValue("@idEntrada", idEntrada);
                            cmd.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@precioUnitario", (int)precioUnitario);
                            cmd.Parameters.AddWithValue("@costoTotal", (int)costoTotal);
                            cmd.ExecuteNonQuery();
                        }

                        // Actualizar el stock en la bodega de origen
                        string queryActualizarOrigen = @"
                            UPDATE TBL_EXISTENCIAS_BODEGA 
                            SET CANTIDAD_ACTUAL = CANTIDAD_ACTUAL - ? 
                            WHERE Fk_ID_BODEGA = (SELECT Pk_ID_BODEGA FROM TBL_BODEGAS WHERE NOMBRE_BODEGA = ?) 
                            AND Fk_ID_PRODUCTO = ?";

                        using (OdbcCommand cmd = new OdbcCommand(queryActualizarOrigen, connection))
                        {
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@bodega", Cbo_BodegaOrigen.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@idProducto", idProducto);
                            cmd.ExecuteNonQuery();
                        }

                        // Actualizar el stock en la tabla Tbl_Productos
                        string queryActualizarStockProducto = @"
                            UPDATE Tbl_Productos 
                            SET stock = stock - ? 
                            WHERE codigoProducto = ?";

                        using (OdbcCommand cmd = new OdbcCommand(queryActualizarStockProducto, connection))
                        {
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                            cmd.ExecuteNonQuery();
                        }

                        // Actualizar o insertar el stock en la bodega de destino
                        string queryActualizarDestino = @"
                            INSERT INTO TBL_EXISTENCIAS_BODEGA (Fk_ID_BODEGA, Fk_ID_PRODUCTO, CANTIDAD_ACTUAL, CANTIDAD_INICIAL)
                            SELECT 
                                (SELECT Pk_ID_BODEGA FROM TBL_BODEGAS WHERE NOMBRE_BODEGA = ?),
                                ?,
                                ?,
                                ?
                            ON DUPLICATE KEY UPDATE
                                CANTIDAD_ACTUAL = CANTIDAD_ACTUAL + ?";

                        using (OdbcCommand cmd = new OdbcCommand(queryActualizarDestino, connection))
                        {
                            cmd.Parameters.AddWithValue("@bodega", Cbo_Sucursal.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@idProducto", idProducto);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@cantidadInicial", cantidad);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                // Actualizar el DataGridView con los nuevos datos
                CargarDatosTraslado();

                // Limpiar el DataGridView de productos
                Dgv_Productos.Rows.Clear();

                // Mostrar mensaje de éxito
                MessageBox.Show("Traslado realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el traslado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //INSTRUCCIONES PARA EL BOTON ACTUALIZAR
        private void Pic_Actualizar_Click(object sender, EventArgs e)
        {
            // Llama al método que carga y refresca los datos en el DataGridView
            CargarDatosTraslado();
        }

        //BOTON ACTUALIZAR
        private void Pic_Actualizar_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_Actualizar.BackColor = Color.Black; // Cambia el color de fondo al entrar el mouse  
        }

        private void Pic_Actualizar_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar el color de fondo  
            Pic_Actualizar.BackColor = Color.Transparent; // Restaura el color original  
        }

        //BOTON ACEPTAR
        private void Pic_Aceptar_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_Aceptar.BackColor = Color.Black; // Cambia el color de fondo al entrar el mouse  
        }

        private void Pic_Aceptar_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar el color de fondo  
            Pic_Aceptar.BackColor = Color.Transparent; // Restaura el color original  
        }

        //*NUEVO------------------------------------------------------------------------------------------------------------
        
        //BOTON INFORMES BODEGAS
        private void Pic_InformeBs_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_InformeBs.BackColor = Color.Black; // Cambia el color de fondo al entrar el mouse  
        }

        private void Pic_InformeBs_MouseLeave(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_InformeBs.BackColor = Color.Transparent; // Cambia el color de fondo al entrar el mouse  
        }

        //BOTON CANCELAR TRASLADO DE PRODUCTOS
        private void Pic_CanselarTDP_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_CanselarTDP.BackColor = Color.Black; // Cambia el color de fondo al entrar el mouse  
        }

        private void Pic_CanselarTDP_MouseLeave(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_CanselarTDP.BackColor = Color.Transparent; // Cambia el color de fondo al entrar el mouse  
        }

        //BOTON AGREGAR PRODUCTOS
        private void Pic_Agregar_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_Agregar.BackColor = Color.Black; // Cambia el color de fondo al entrar el mouse  
        }

        private void Pic_Agregar_MouseLeave(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_Agregar.BackColor = Color.Transparent; // Cambia el color de fondo al entrar el mouse  
        }

        //------------------------------------------------------------------------------------------------------------


        //BOTON INGRESAR
        private void Pic_Ingresar_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_Ingresar.BackColor = Color.Black; // Cambia el color de fondo al entrar el mouse  
        }

        private void Pic_Ingresar_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar el color de fondo  
            Pic_Ingresar.BackColor = Color.Transparent; // Restaura el color original  
        }

        //BOTON EDITAR
        private void Pic_Editar_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_Editar.BackColor = Color.Black; // Cambia el color de fondo al entrar el mouse  
        }

        private void Pic_Editar_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar el color de fondo  
            Pic_Editar.BackColor = Color.Transparent; // Restaura el color original  
        }

        //BOTON GUARDAR
        private void Pic_Guardar_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_Guardar.BackColor = Color.Black; // Cambia el color de fondo al entrar el mouse  
        }

        private void Pic_Guardar_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar el color de fondo  
            Pic_Guardar.BackColor = Color.Transparent; // Restaura el color original  
        }
                
        //BOTON SALIR
        private void Pic_Salir_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_Salir.BackColor = Color.Black; // Cambia el color de fondo al entrar el mouse  
        }

        private void Pic_Salir_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar el color de fondo  
            Pic_Salir.BackColor = Color.Transparent; // Restaura el color original  
        }

        //BOTON REPORTEs
        private void Pic_Reporte_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_Reporte.BackColor = Color.Black; // Cambia el color de fondo al entrar el mouse  
        }

        private void Pic_Reporte_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar el color de fondo  
            Pic_Reporte.BackColor = Color.Transparent; // Restaura el color original  
        }

        //BOTON AYUDA
        private void Pic_Ayuda_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_Ayuda.BackColor = Color.Black; // Cambia el color de fondo al entrar el mouse  
        }

        private void Pic_Ayuda_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar el color de fondo  
            Pic_Ayuda.BackColor = Color.Transparent; // Restaura el color original  
        }


        private void Pic_Editar_Click(object sender, EventArgs e)
        {
            // Asegúrate de habilitar y permitir la edición
            Txt_Vehiculo.Enabled = true;
            Txt_Vehiculo.ReadOnly = false;

            Txt_PesoTotalV.Enabled = true;
            Txt_PesoTotalV.ReadOnly = false;

            Txt_NombreProd.Enabled = true;
            Txt_NombreProd.ReadOnly = false;

            Txt_PesoProd.Enabled = true;
            Txt_PesoProd.ReadOnly = false;

            // Cambiar el fondo a blanco para indicar que son editables
            Txt_Vehiculo.BackColor = Color.White;
            Txt_PesoTotalV.BackColor = Color.White;
            Txt_NombreProd.BackColor = Color.White;
            Txt_PesoProd.BackColor = Color.White;

        }

        private void Pic_Guardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            string idVehiculo = Txt_Id1.Text;
            string vehiculo = Txt_Vehiculo.Text;
            string pesoTotalV = Txt_PesoTotalV.Text;

            string idProd = Txt_Id2.Text;
            string nombreProd = Txt_NombreProd.Text;
            string pesoProd = Txt_PesoProd.Text;

            try
            {
                // Conexión a la base de datos
                OdbcConnection connection = conn.Conexion();

                // Guardar cambios en Tbl_vehiculos
                string queryVehiculos = "UPDATE Tbl_vehiculos SET marca = ?, pesoTotal = ? WHERE Pk_id_vehiculo = ?";
                using (OdbcCommand cmdVehiculo = new OdbcCommand(queryVehiculos, connection))
                {
                    cmdVehiculo.Parameters.AddWithValue("@marca", vehiculo);
                    cmdVehiculo.Parameters.AddWithValue("@pesoTotal", pesoTotalV);
                    cmdVehiculo.Parameters.AddWithValue("@Pk_id_vehiculo", idVehiculo);

                    cmdVehiculo.ExecuteNonQuery();
                }

                // Guardar cambios en Tbl_Productos
                string queryProductos = "UPDATE Tbl_Productos SET nombreProducto = ?, pesoProducto = ? WHERE Pk_id_Producto = ?";
                using (OdbcCommand cmdProducto = new OdbcCommand(queryProductos, connection))
                {
                    cmdProducto.Parameters.AddWithValue("@nombreProducto", nombreProd);
                    cmdProducto.Parameters.AddWithValue("@pesoProducto", pesoProd);
                    cmdProducto.Parameters.AddWithValue("@Pk_id_Producto", idProd);

                    cmdProducto.ExecuteNonQuery();
                }

                // Cerrar la conexión
                conn.desconexion(connection);

                MessageBox.Show("Cambios guardados exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }


        }

        private void Pic_Salir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();

        }
                
        private void Pic_Reporte_Click(object sender, EventArgs e)
        {
            //Abrir Formulario

           ReporteTDP frm = new ReporteTDP();
           frm.Show();
        }
        
        private void Pic_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta del directorio del ejecutable
                string sexecutablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Retroceder a la carpeta del proyecto
                string sprojectPath = Path.GetFullPath(Path.Combine(sexecutablePath, @"..\..\"));
                //MessageBox.Show("1" + projectPath);

                string sayudaFolderPath = Path.Combine(sprojectPath, "AyudaTraslado");

                // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
                string spathAyuda = FindFileInDirectory(sayudaFolderPath, "AyudaTrasladoDeProductos.chm");

                // Verifica si el archivo existe antes de intentar abrirlo
                if (!string.IsNullOrEmpty(spathAyuda))
                {
                    // Abre el archivo de ayuda .chm en la sección especificada
                    //Help.ShowHelp(null, spathAyuda, "AyudaTrasladoDeProductos.html");
                    Help.ShowHelp(null, spathAyuda, "AyudaTrasladoDeProductos.html");
                }
                else
                {
                    // Si el archivo no existe, muestra un mensaje de error
                    MessageBox.Show("El archivo de ayuda no se encontró.");
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }

        public string FindFileInDirectory(string sdirectory, string sfileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(sdirectory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(sdirectory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in files)
                    {
                        if (Path.GetFileName(file).Equals(sfileName, StringComparison.OrdinalIgnoreCase))
                        {
                            //MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la carpeta: " + sdirectory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar ayuda: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Destino_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_CodigoProd_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Pic_NuevoTrasladoP_Click(object sender, EventArgs e)
        {
            NuevoTraslado nuevoTraslado = new NuevoTraslado();
            nuevoTraslado.Show();
        }

        private void Pic_NuevoTrasladoP_MouseEnter(object sender, EventArgs e)
        {
            Pic_NuevoTrasladoP.Size = new Size(Pic_NuevoTrasladoP.Width + 10, Pic_NuevoTrasladoP.Height + 10);
        }

        private void Pic_NuevoTrasladoP_MouseLeave(object sender, EventArgs e)
        {
            Pic_NuevoTrasladoP.Size = new Size(Pic_NuevoTrasladoP.Width - 10, Pic_NuevoTrasladoP.Height - 10);
        }

        private void Pic_NuevoTrasladoP_Click_1(object sender, EventArgs e)
        {

        }

        private void CargarVehiculos()
        {
            try
            {
                List<string> marcasVehiculos = controlador.ObtenerMarcasVehiculos();
                Cbo_Vehiculo.Items.Clear();
                
                // Configurar el ComboBox para permitir búsqueda y autocompletado
                Cbo_Vehiculo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                Cbo_Vehiculo.AutoCompleteSource = AutoCompleteSource.ListItems;
                Cbo_Vehiculo.DropDownStyle = ComboBoxStyle.DropDown;

                foreach (string marca in marcasVehiculos)
                {
                    Cbo_Vehiculo.Items.Add(marca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vehículos: " + ex.Message);
            }
        }

        private void CargarSucursales()
        {
            try
            {
                List<string> sucursales = controlador.ObtenerSucursales();
                Cbo_Sucursal.Items.Clear();
                foreach (string sucursal in sucursales)
                {
                    Cbo_Sucursal.Items.Add(sucursal);
                }
                
                // Configurar el ComboBox para permitir selección pero no edición
                Cbo_Sucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sucursales: " + ex.Message);
            }
        }

        private void Cbo_Vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Vehiculo.SelectedItem != null)
                {
                    string marcaSeleccionada = Cbo_Vehiculo.SelectedItem.ToString();
                    
                    // Actualizar Txt_Vehiculo con la marca seleccionada
                    Txt_Vehiculo.Text = marcaSeleccionada;
                    
                    // Obtener y mostrar el peso total del vehículo
                    int pesoTotal = controlador.ObtenerPesoTotalPorMarca(marcaSeleccionada);
                    Txt_PesoTotalV.Text = pesoTotal.ToString();

                    // Obtener el ID del vehículo por marca
                    int idVehiculo = controlador.ObtenerIdVehiculoPorMarca(marcaSeleccionada);
                    
                    // Obtener y mostrar el destino correspondiente
                    if (idVehiculo > 0)
                    {
                        string destino = controlador.ObtenerDestinoPorIdVehiculo(idVehiculo);
                        if (!string.IsNullOrEmpty(destino))
                        {
                            TxtDESTINO.Text = destino;
                            TxtDESTINO.Enabled = false;
                            TxtDESTINO.BackColor = Color.LightGray;
                        }
                        else
                        {
                            TxtDESTINO.Text = "";
                            TxtDESTINO.Enabled = true;
                            TxtDESTINO.BackColor = Color.White;
                        }
                    }

                    // Obtener y actualizar los destinos disponibles para esta marca
                    List<string> destinos = controlador.ObtenerDestinosPorMarca(marcaSeleccionada);
                    TxtDESTINO.AutoCompleteCustomSource.Clear();
                    foreach (string dest in destinos)
                    {
                        TxtDESTINO.AutoCompleteCustomSource.Add(dest);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el vehículo: " + ex.Message);
            }
        }

        /*private void Cbo_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Producto.SelectedItem != null)
            {
                string productoSeleccionado = Cbo_Producto.SelectedItem.ToString();
                string[] partes = productoSeleccionado.Split('|');
                if (partes.Length >= 2)
                {
                    string codigoStr = partes[0].Trim();
                    if (int.TryParse(codigoStr, out int codigoProducto))
                    {
                        // Actualizar el stock en tiempo real
                        int stockActual = controlador.ObtenerStockProductoPorCodigo(codigoProducto);
                        Txt_Stock.Text = stockActual.ToString();
                    }
                }
            }
        }*/

        private void Dgv_Productos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (Dgv_Productos.CurrentRow != null)
                {
                    if (MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Dgv_Productos.Rows.RemoveAt(Dgv_Productos.CurrentRow.Index);
                        ActualizarPesoTotal(); // Actualizar el peso total después de eliminar
                    }
                }
            }
        }

        private void Pic_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación para asegurarse de que la cantidad sea válida
                if (!int.TryParse(Txt_Cantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida y mayor a cero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación para el código de producto
                if (!int.TryParse(Cbo_CodigoProd.Text, out int codigoProducto))
                {
                    MessageBox.Show("El código de producto no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el último stock restante del producto en el DataGridView
                int ultimoStockRestante = -1;
                for (int i = Dgv_Productos.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = Dgv_Productos.Rows[i];
                    if (row.Cells["codigoProducto"].Value != null &&
                        Convert.ToInt32(row.Cells["codigoProducto"].Value) == codigoProducto)
                    {
                        ultimoStockRestante = Convert.ToInt32(row.Cells["stockRestante"].Value);
                        break;
                    }
                }

                // Si no se encontró el producto en el DataGridView, usar el stock original
                int stockDisponible = ultimoStockRestante >= 0 ? ultimoStockRestante : Convert.ToInt32(Txt_Stock.Text);

                // Verificar si hay suficiente stock
                if (stockDisponible == 0)
                {
                    MessageBox.Show("No hay stock disponible para este producto.", "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cantidad > stockDisponible)
                {
                    MessageBox.Show($"La cantidad solicitada ({cantidad}) excede el stock disponible ({stockDisponible}).", 
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación para el precio unitario
                if (!decimal.TryParse(Txt_PrecioU.Text, out decimal precioUnitario))
                {
                    MessageBox.Show("El precio unitario no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el peso del producto (eliminando el "kg" si está presente)
                string pesoProdTexto = Txt_PesoProd.Text.Replace("kg", "").Trim();
                if (!int.TryParse(pesoProdTexto, out int pesoProducto))
                {
                    MessageBox.Show("El peso del producto no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el nombre del producto
                string nombreProducto = Txt_NombreProd.Text;

                // Calcular el nuevo stock restante
                int nuevoStockRestante = stockDisponible - cantidad;

                // Agregar el producto al DataGridView
                Dgv_Productos.Rows.Add(
                    codigoProducto,
                    nombreProducto,
                    Convert.ToInt32(Txt_Stock.Text), // Stock original
                    cantidad,
                    precioUnitario,
                    pesoProducto,
                    nuevoStockRestante
                );

                // Actualizar el peso total y el label
                ActualizarPesoTotal();

                // Limpiar los campos después de agregar el producto
                Cbo_CodigoProd.SelectedIndex = -1;
                Txt_NombreProd.Clear();
                Txt_Stock.Clear();
                Txt_Cantidad.Clear();
                Txt_PrecioU.Clear();
                Txt_PesoProd.Clear();

                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarPesoTotal()
        {
            try
            {
                int pesoTotalProductos = 0;
                foreach (DataGridViewRow row in Dgv_Productos.Rows)
                {
                    if (row.Cells["pesoProducto"].Value != null)
                    {
                        pesoTotalProductos += Convert.ToInt32(row.Cells["pesoProducto"].Value);
                    }
                }

                if (int.TryParse(Txt_PesoTotalV.Text, out int pesoMaximoVehiculo))
                {
                    int pesoRestante = pesoMaximoVehiculo - pesoTotalProductos;
                    Lbl_PesoV.Text = pesoRestante.ToString();
                    
                    // Cambiar el color del label según el peso restante
                    if (pesoRestante < 0)
                    {
                        Lbl_PesoV.ForeColor = Color.Red;
                    }
                    else if (pesoRestante < pesoMaximoVehiculo * 0.2) // Menos del 20% de capacidad
                    {
                        Lbl_PesoV.ForeColor = Color.Orange;
                    }
                    else
                    {
                        Lbl_PesoV.ForeColor = Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el peso total: " + ex.Message);
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void ConfigurarDataGridViewDetalles()
        {
            // Limpiar columnas existentes
            Dgv_Productos.Columns.Clear();

            // Configurar el DataGridView de productos
            Dgv_Productos.Columns.Add("codigoProducto", "Código");
            Dgv_Productos.Columns.Add("nombreProducto", "Nombre");
            Dgv_Productos.Columns.Add("stock", "Stock");
            Dgv_Productos.Columns.Add("cantidad", "Cantidad");
            Dgv_Productos.Columns.Add("precioUnitario", "Precio Unitario");
            Dgv_Productos.Columns.Add("pesoProducto", "Peso");
            Dgv_Productos.Columns.Add("stockRestante", "Stock Restante");

            // Configurar el DataGridView
            Dgv_Productos.AllowUserToAddRows = false;
            Dgv_Productos.AllowUserToDeleteRows = true;
            Dgv_Productos.ReadOnly = true;
            Dgv_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Productos.MultiSelect = false;
        }

        //Instrucción para mostrar el título del formulario DetalleTraslado.cs
        private void Dgv_TrasladoDProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Verificar el tipo de informe seleccionado
                    string tipoInforme = Cbo_TipoInformee.SelectedItem?.ToString();
                    if (tipoInforme != "Informe salida TDP")
                    {
                        // Si no es 'Informe salida TDP', no abrimos el formulario de detalles
                        return;
                    }

                    // Obtener el documento del traslado seleccionado
                    string documento = Dgv_TrasladoDProductos.Rows[e.RowIndex].Cells["documento"].Value.ToString();

                    // Obtener los detalles del traslado
                    DataTable detalles = controlador.ObtenerDetallesTraslado(documento);

                    // Crear y mostrar el formulario de detalles
                    DetalleTraslado formDetalle = new DetalleTraslado();
                    formDetalle.Text = $"Detalle del Traslado - Documento: {documento}";
                    
                    // Obtener las bodegas del primer registro (ya que son las mismas para todo el traslado)
                    if (detalles.Rows.Count > 0)
                    {
                        formDetalle.Txt_BodegaOrigen.Text = detalles.Rows[0]["bodega_origen"].ToString();
                        formDetalle.Txt_BodegaDestino.Text = detalles.Rows[0]["bodega_destino"].ToString();
                    }
                    
                    formDetalle.CargarDatos(detalles);
                    formDetalle.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles del traslado: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarBodegasOrigen()
        {
            try
            {
                List<string> bodegas = controlador.ObtenerNombresBodegas();
                Cbo_BodegaOrigen.Items.Clear();
                foreach (string bodega in bodegas)
                {
                    Cbo_BodegaOrigen.Items.Add(bodega);
                }
                
                // Configurar el ComboBox para permitir selección pero no edición
                Cbo_BodegaOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las bodegas de origen: " + ex.Message);
            }
        }

        private void Cbo_BodegaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarSeleccionBodegas();
        }

        private void Cbo_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarSeleccionBodegas();
        }

        private void ValidarSeleccionBodegas()
        {
            bool bodegasSeleccionadas = Cbo_BodegaOrigen.SelectedItem != null && Cbo_Sucursal.SelectedItem != null;
            
            // Habilitar/deshabilitar campos según la selección de bodegas
            Cbo_Vehiculo.Enabled = bodegasSeleccionadas;
            Cbo_CodigoProd.Enabled = bodegasSeleccionadas;
            Dtp_Fecha_Traslado.Enabled = bodegasSeleccionadas;
            Txt_Cantidad.Enabled = bodegasSeleccionadas;

            if (bodegasSeleccionadas)
            {
                string bodegaOrigen = Cbo_BodegaOrigen.SelectedItem.ToString();
                string bodegaDestino = Cbo_Sucursal.SelectedItem.ToString();

                if (bodegaOrigen == bodegaDestino)
                {
                    MessageBox.Show("No puede seleccionar la misma bodega como origen y destino.", 
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cbo_Sucursal.SelectedItem = null;
                    
                    // Deshabilitar campos nuevamente
                    Cbo_Vehiculo.Enabled = false;
                    Cbo_CodigoProd.Enabled = false;
                    Dtp_Fecha_Traslado.Enabled = false;
                    Txt_Cantidad.Enabled = false;
                }
            }
            else
            {
                // Si no hay bodegas seleccionadas, limpiar los campos dependientes
                Cbo_Vehiculo.SelectedIndex = -1;
                Cbo_CodigoProd.SelectedIndex = -1;
                Txt_Cantidad.Clear();
            }
        }

        private void Txt_Destino_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_TrasladoDProductos.DataSource != null)
                {
                    DataTable dt = (DataTable)Dgv_TrasladoDProductos.DataSource;
                    string searchText = Txt_Busqueda.Text.ToLower();

                    if (string.IsNullOrWhiteSpace(searchText))
                    {
                        // Si el texto de búsqueda está vacío, mostrar todos los registros
                        dt.DefaultView.RowFilter = "";
                    }
                    else
                    {
                        // Crear el filtro para buscar en todas las columnas visibles
                        string filter = string.Empty;
                        foreach (DataGridViewColumn column in Dgv_TrasladoDProductos.Columns)
                        {
                            if (column.Visible)
                            {
                                if (!string.IsNullOrEmpty(filter))
                                    filter += " OR ";
                                filter += $"CONVERT([{column.DataPropertyName}], System.String) LIKE '%{searchText}%'";
                            }
                        }
                        dt.DefaultView.RowFilter = filter;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgv_TrasladoDProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool ValidarSeleccionBodegasCompleta()
        {
            if (Cbo_BodegaOrigen.SelectedItem == null || Cbo_Sucursal.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar tanto la bodega de origen como la bodega de destino antes de continuar.", 
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void CargarDatosEntrada()
        {
            try
            {
                OdbcConnection connection = conn.Conexion();
                string query = "SELECT Pk_id_EntradaProductos, documento, fecha, costoTotal, costoTotalGeneral, precioTotal, codigoProducto, Fk_id_guia, bodega_origen, bodega_destino FROM Tbl_EntradaProductos";

                OdbcDataAdapter adapter = new OdbcDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Dgv_TrasladoDProductos.DataSource = dataTable;

                // Cambia el nombre de la columna después de establecer el DataSource  
                Dgv_TrasladoDProductos.Columns["Pk_id_EntradaProductos"].HeaderText = "Entrada";
                Dgv_TrasladoDProductos.Columns["Fk_id_guia"].HeaderText = "Guía";

                // Cargar sugerencias de autocompletado inteligente para el buscador de entrada
                CargarSugerenciasAutocompletadoEntrada(dataTable);

                conn.desconexion(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de entrada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarSugerenciasAutocompletadoEntrada(DataTable dataTable)
        {
            try
            {
                // Limpiar las sugerencias existentes
                Txt_Busqueda.AutoCompleteCustomSource.Clear();

                // Crear un HashSet para evitar duplicados
                HashSet<string> sugerencias = new HashSet<string>();

                // Recorrer todas las filas y solo la columna 'documento'
                foreach (DataRow row in dataTable.Rows)
                {
                    string valor = row["documento"].ToString();
                    if (!string.IsNullOrWhiteSpace(valor))
                    {
                        sugerencias.Add(valor);
                    }
                }

                // Agregar las sugerencias al AutoCompleteCustomSource
                foreach (string sugerencia in sugerencias)
                {
                    Txt_Busqueda.AutoCompleteCustomSource.Add(sugerencia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sugerencias de autocompletado de entrada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Cbo_TipoInformee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_TipoInformee.SelectedItem != null)
                {
                    string tipoInforme = Cbo_TipoInformee.SelectedItem.ToString();
                    
                    if (tipoInforme == "Informe salida TDP")
                    {
                        CargarDatosTraslado(); // Cargar datos de traslado en Dgv_TrasladoDProductos
                    }
                    else if (tipoInforme == "Informe entrada TDP")
                    {
                        CargarDatosEntradaEnTraslado(); // Cargar datos de entrada en Dgv_TrasladoDProductos
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar el tipo de informe: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nuevo método para cargar los datos de entrada en Dgv_TrasladoDProductos
        private void CargarDatosEntradaEnTraslado()
        {
            try
            {
                OdbcConnection connection = conn.Conexion();
                string query = "SELECT Pk_id_EntradaProductos AS 'Entrada', documento, fecha, costoTotal, costoTotalGeneral, precioTotal, codigoProducto, Fk_id_guia, bodega_origen, bodega_destino, estado FROM Tbl_EntradaProductos";

                OdbcDataAdapter adapter = new OdbcDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Dgv_TrasladoDProductos.DataSource = dataTable;

                // Cambiar el nombre de la columna después de establecer el DataSource  
                Dgv_TrasladoDProductos.Columns["Entrada"].HeaderText = "Entrada";
                Dgv_TrasladoDProductos.Columns["Fk_id_guia"].HeaderText = "Guía";
                Dgv_TrasladoDProductos.Columns["estado"].HeaderText = "Estado";

                conn.desconexion(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de entrada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pic_CanselarTDP_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_TrasladoDProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un traslado para cancelar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Obtener el documento seleccionado
                string documento = Dgv_TrasladoDProductos.SelectedRows[0].Cells["documento"].Value.ToString();

                // Confirmar con el usuario
                DialogResult result = MessageBox.Show($"¿Está seguro que desea cancelar el traslado con documento: {documento}?\nEsta acción devolverá los productos al stock original.",
                    "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                    return;

                OdbcConnection connection = conn.Conexion();

                // 1. Obtener el ID de traslado y la bodega destino usando el documento
                string queryId = "SELECT Pk_id_TrasladoProductos, bodega_destino FROM Tbl_TrasladoProductos WHERE documento = ?";
                OdbcCommand cmdId = new OdbcCommand(queryId, connection);
                cmdId.Parameters.AddWithValue("@documento", documento);
                int idTraslado = 0;
                string bodegaDestino = "";
                using (OdbcDataReader reader = cmdId.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idTraslado = reader.GetInt32(0);
                        bodegaDestino = reader.GetString(1);
                    }
                }
                if (idTraslado == 0)
                {
                    MessageBox.Show("No se encontró el traslado para cancelar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.desconexion(connection);
                    return;
                }

                // 2. Obtener los productos y cantidades del detalle
                string queryDetalles = "SELECT codigoProducto, cantidad FROM Tbl_DetalleTrasladoProductos WHERE Fk_id_TrasladoProductos = ?";
                OdbcCommand cmdDetalles = new OdbcCommand(queryDetalles, connection);
                cmdDetalles.Parameters.AddWithValue("@idTraslado", idTraslado);
                var detalles = new List<(int codigoProducto, int cantidad)>();
                using (OdbcDataReader reader = cmdDetalles.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int codigoProducto = reader.GetInt32(0);
                        int cantidad = reader.GetInt32(1);
                        // Depuración: mostrar los valores obtenidos
                        if (cantidad <= 0 || codigoProducto <= 0)
                        {
                            MessageBox.Show($"Valor inesperado: código={codigoProducto}, cantidad={cantidad}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        detalles.Add((codigoProducto, cantidad));
                    }
                }

                // 3. Revertir stock para cada producto
                foreach (var detalle in detalles)
                {
                    // 1. Sumar al stock en tbl_productos usando codigoProducto
                    string querySumarStock = "UPDATE Tbl_Productos SET stock = stock + ? WHERE codigoProducto = ?";
                    OdbcCommand cmdSumar = new OdbcCommand(querySumarStock, connection);
                    cmdSumar.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                    cmdSumar.Parameters.AddWithValue("@codigoProducto", detalle.codigoProducto);
                    int rowsAffected = cmdSumar.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show($"No se actualizó el stock para el producto {detalle.codigoProducto}.", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // 2. Obtener el ID interno del producto
                    int idProducto = 0;
                    string queryIdProducto = "SELECT Pk_id_Producto FROM Tbl_Productos WHERE codigoProducto = ?";
                    using (OdbcCommand cmdIdProducto = new OdbcCommand(queryIdProducto, connection))
                    {
                        cmdIdProducto.Parameters.AddWithValue("@codigoProducto", detalle.codigoProducto);
                        using (OdbcDataReader reader = cmdIdProducto.ExecuteReader())
                        {
                            if (reader.Read())
                                idProducto = reader.GetInt32(0);
                        }
                    }
                    if (idProducto == 0)
                    {
                        MessageBox.Show($"No se encontró el ID interno para el producto {detalle.codigoProducto}.", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    // 3. Restar en tbl_existencias_bodega usando el ID interno
                    string queryRestarBodega = @"UPDATE TBL_EXISTENCIAS_BODEGA 
                        SET CANTIDAD_ACTUAL = CANTIDAD_ACTUAL - ? 
                        WHERE Fk_ID_BODEGA = (SELECT Pk_ID_BODEGA FROM TBL_BODEGAS WHERE NOMBRE_BODEGA = ?) 
                        AND Fk_ID_PRODUCTO = ?";
                    OdbcCommand cmdRestar = new OdbcCommand(queryRestarBodega, connection);
                    cmdRestar.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                    cmdRestar.Parameters.AddWithValue("@bodega", bodegaDestino);
                    cmdRestar.Parameters.AddWithValue("@idProducto", idProducto);
                    int rowsBodega = cmdRestar.ExecuteNonQuery();
                    if (rowsBodega == 0)
                    {
                        MessageBox.Show($"No se actualizó la existencia en bodega para el producto {detalle.codigoProducto}.", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // 4. Marcar el documento como cancelado en Tbl_EntradaProductos (si aplica)
                string queryCancelar = "UPDATE Tbl_EntradaProductos SET estado = 'cancelado' WHERE documento = ?";
                OdbcCommand cmdCancelar = new OdbcCommand(queryCancelar, connection);
                cmdCancelar.Parameters.AddWithValue("@documento", documento);
                cmdCancelar.ExecuteNonQuery();

                conn.desconexion(connection);

                MessageBox.Show("Traslado cancelado y stock revertido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar la vista
                if (Cbo_TipoInformee.SelectedItem != null && Cbo_TipoInformee.SelectedItem.ToString() == "Informe entrada TDP")
                {
                    CargarDatosEntradaEnTraslado();
                }
                else
                {
                    CargarDatosTraslado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cancelar el traslado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pic_InformeBs_Click(object sender, EventArgs e)
        {
            InformacionBodegas infoBodegas = new InformacionBodegas();
            infoBodegas.ShowDialog();
        }

        private void Cbo_BodegaOrigen_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Cbo_TipoInformee_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void Pic_InformeBs_Click_1(object sender, EventArgs e)
        {

        }

        private void Pic_CanselarTDP_Click_1(object sender, EventArgs e)
        {

        }

        private void toolTip8_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
