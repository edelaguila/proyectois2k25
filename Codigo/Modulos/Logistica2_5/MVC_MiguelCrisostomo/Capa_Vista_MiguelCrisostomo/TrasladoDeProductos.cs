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
            CargarDestinos(); // Cargar destinos al iniciar el formulario
            CargarCodigosProductos(); // Cargar códigos de productos  

            Cbo_Destino.SelectedIndexChanged += Cbo_Destino_SelectedIndexChanged; // Enlazar el evento para destinos
            Cbo_CodigoProd.SelectedIndexChanged += new EventHandler(Cbo_CodigoProd_SelectedIndexChanged); // Enlaza el evento cuando cambia la selección del combo de códigos de productos
            Txt_Cantidad.TextChanged += Txt_Cantidad_TextChanged;

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

        }
        //*************************************************************************************************************


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
                // Verificar si hay un elemento seleccionado  
                if (Cbo_CodigoProd.SelectedItem != null)
                {

                    //METODOS_________________*****************************************
                    // Obtener y mostrar nombreProducto
                    int idProducto = controlador.ObteneridProductoPorCodigo((int)Cbo_CodigoProd.SelectedItem);
                    Txt_Id2.Text = idProducto.ToString();

                    //METODOS_________________*****************************************
                    // Obtener y mostrar nombreProducto
                    string nombreProducto = controlador.ObtenerNombreProductoPorCodigo((int)Cbo_CodigoProd.SelectedItem);
                    Txt_NombreProd.Text = nombreProducto;

                    // Obtener y mostrar pesoProducto como texto
                    string pesoProducto = controlador.ObtenerPesoProductoPorCodigo((int)Cbo_CodigoProd.SelectedItem);
                    Txt_PesoProd.Text = pesoProducto;

                    // Obtener y mostrar stock
                    int stockProducto = controlador.ObtenerStockProductoPorCodigo((int)Cbo_CodigoProd.SelectedItem);
                    Txt_Stock.Text = stockProducto.ToString(); // Muestra el stock en el TextBox

                    // Obtener y mostrar precio
                    decimal precioProducto = controlador.ObtenerPrecioProductoPorCodigo((int)Cbo_CodigoProd.SelectedItem);
                    int p = Convert.ToInt32(precioProducto);
                    Txt_PrecioU.Text = p.ToString();

                }
                else
                {
                    // Manejar el caso cuando no hay un elemento seleccionado  
                    Txt_Id2.Text = string.Empty;
                    Txt_NombreProd.Text = string.Empty;
                    Txt_PesoProd.Text = string.Empty;
                    Txt_Stock.Text = string.Empty;
                    // Limpiar otros TextBox si es necesario  
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el nombre del producto: " + ex.Message);
            }
        }

        //CALCULO DE "COSTO TOTAL"*****************************************************



        // Definir un ancho máximo para el Label  
        private const int MaxLabelWidth = 50; // Ajusta este valor según sea necesario  


        // Evento para recalcular el costo total al cambiar la cantidad
        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {

            // Verificar si ambos valores son válidos antes de calcular  
            if (decimal.TryParse(Txt_Cantidad.Text, out decimal cantidad) &&
                decimal.TryParse(Txt_PrecioU.Text, out decimal precioUnitario) &&
                int.TryParse(Txt_Stock.Text, out int stock)) // Asegúrate de que Txt_Stock contenga un número  ) // Asegúrate de que Txt_Stock contenga un número  )
            {
                // Bloquear el TextBox si la cantidad supera el stock disponible  
                if (cantidad > stock)
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

                // Calcular el nuevo stock basado en la cantidad ingresada  
                int nuevoStock = stock - (int)cantidad;


                // Evitar que el stock sea negativo  
                if (nuevoStock < 0)
                {
                    Txt_Stock.Text = "0"; // Muestra 0 si el stock se vuelve negativo  
                }
                else
                {
                    // Txt_Stock.Text = nuevoStock.ToString(); // Actualiza Txt_Stock con el nuevo valor  
                }
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
        /// INSTRUCCION PARA CARGAR INFORMACION EN EL Cbo_Destino ******************************************************
        private void CargarDestinos()
        {
            try
            {
                List<string> destinos = modelo.ObtenerDestinos(); // Llama al método ObtenerDestinos
                Cbo_Destino.Items.Clear();
                foreach (string codigoProducto in destinos)
                {
                    Cbo_Destino.Items.Add(codigoProducto); // Agrega cada destino al ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar destinos: " + ex.Message);
            }
        }

        /// EVENTO PARA MOSTRAR EL ID AL SELECCIONAR UN DESTINO ******************************************************
        private void Cbo_Destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay un elemento seleccionado  
                if (Cbo_Destino.SelectedItem != null)
                {

                    //METODOS_________________*****************************************
                    // Obtener y mostrar el ID de guía
                    string destinoSeleccionado = Cbo_Destino.SelectedItem.ToString();
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

                // Cerrar la conexión
                conn.desconexion(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de traslado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
        private void label12_Click(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {}

        private void Pic_Ingresar_Click(object sender, EventArgs e)
        {
            // Bloquear los campos de texto para que no se puedan editar
            Txt_Vehiculo.ReadOnly = true;
            Txt_PesoTotalV.ReadOnly = true;
            Txt_NombreProd.ReadOnly = true;
            Txt_PesoProd.ReadOnly = true;

            // Alternativamente, puedes deshabilitar los campos para que no se puedan interactuar
            Txt_Vehiculo.Enabled = false;
            Txt_PesoTotalV.Enabled = false;
            Txt_NombreProd.Enabled = false;
            Txt_PesoProd.Enabled = false;

            // Cambiar el fondo a gris para indicar que los campos están bloqueados
            Txt_Vehiculo.BackColor = Color.LightGray;
            Txt_PesoTotalV.BackColor = Color.LightGray;
            Txt_NombreProd.BackColor = Color.LightGray;
            Txt_PesoProd.BackColor = Color.LightGray;


            // Llamar al método para limpiar los campos  
            LimpiarCampos();

            // Desbloquear el campo Txt_Cantidad  
            Txt_Cantidad.Enabled = true;

        }

        private void LimpiarCampos()
        {
            // Limpia el contenido de cada campo  
            Txt_Id1.Clear();
            Cbo_Destino.SelectedIndex = -1; // Deselecciona cualquier opción en el ComboBox  
            Txt_Vehiculo.Clear();
            Txt_PesoTotalV.Clear();
            Txt_Id2.Clear();
            Cbo_CodigoProd.SelectedIndex = -1; // Deselecciona cualquier opción en el ComboBox  
            Txt_NombreProd.Clear();
            Txt_PesoProd.Clear();
            Txt_Stock.Clear();
            Txt_Cantidad.Clear();
            Txt_PrecioU.Clear();

            // Restablecer el DateTimePicker a la fecha actual
            Dtp_Fecha_Traslado.Value = DateTime.Now;


            // Opcional: Enfocar el primer campo donde se ingresará nueva información  
            Txt_Id1.Focus();
        }

        private void Pic_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación para asegurarse de que la cantidad sea válida
                if (!int.TryParse(Txt_Cantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida y mayor a cero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación para el stock
                if (!int.TryParse(Txt_Stock.Text, out int stock))
                {
                    MessageBox.Show("El stock no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cantidad > stock)
                {
                    MessageBox.Show("La cantidad ingresada excede el stock disponible.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación para el precio unitario
                // Aquí asumimos que el precio unitario y el código de producto ya se capturan correctamente  
                if (!int.TryParse(Txt_PrecioU.Text, out int precioUnitario))
                {
                    MessageBox.Show("El precio unitario no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación para el código de producto
                if (!int.TryParse(Cbo_CodigoProd.Text, out int codigoProducto))
                {
                    MessageBox.Show("El código de producto no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el peso total del vehículo (sin la letra "kg")
                if (!int.TryParse(Txt_PesoTotalV.Text, out int pesoTotalVehiculo))
                {
                    MessageBox.Show("El peso total del vehículo no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el peso del producto (eliminando el "kg" si está presente)
                string pesoProdTexto = Txt_PesoProd.Text.Replace("kg", "").Trim(); // Elimina "kg" y cualquier espacio adicional

                if (!int.TryParse(pesoProdTexto, out int pesoProducto))
                {
                    MessageBox.Show("El peso del producto no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: si el peso del producto es mayor que el peso que soporta el vehículo
                if (pesoProducto > pesoTotalVehiculo)
                {
                    MessageBox.Show("El peso del producto excede el peso soportado por el vehículo. No se puede realizar el traslado.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la fecha del DateTimePicker  
                DateTime fechaTraslado = Dtp_Fecha_Traslado.Value;
                string fecha = fechaTraslado.ToString("yyyy-MM-dd");

                // Calcular el costo total
                int costoTotal = cantidad * precioUnitario;

                // Obtener ID del producto y de la guía
                if (!int.TryParse(Txt_Id2.Text, out int idProducto))
                {
                    MessageBox.Show("El ID de producto no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(Txt_Id1.Text, out int idGuia))
                {
                    MessageBox.Show("El ID de guía no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Generar el documento de forma automática y única
                string documento = controlador.ObtenerSiguienteDocumentoConFormato();



                int nuevoStock = stock - cantidad;

                // Muestra el nuevo stock que se guardará 
                controlador.ActualizarStockProducto(codigoProducto, nuevoStock);

                // Aquí realizas el resto de las operaciones...  
                controlador.registrarTrasladoProductos(documento, fecha, costoTotal, costoTotal, precioUnitario, idProducto, idGuia, codigoProducto);

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
    }
}
