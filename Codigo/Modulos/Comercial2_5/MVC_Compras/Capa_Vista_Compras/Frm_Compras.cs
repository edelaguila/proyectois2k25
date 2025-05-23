using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Compras;
using Capa_Modelo_Compras;

namespace Capa_Vista_Compras
{
    public partial class Frm_Compras : Form
    {
        private ControladorCompras controlador = new ControladorCompras();
        private Conexion conn = new Conexion();


        public Frm_Compras()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(218, 247, 245); // Color de fondo personalizado
            CargarSucursales();
            LlenarTiposComprobante();
            LlenarFormasPago();
            CargarProd();
            CargarSuc();
            CargarSolicitudesenDatagriedView();

            CargarBodega();



            }

        private void Pic_Salir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Pic_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pic_Ingresar_Click(object sender, EventArgs e)
        {
            // Cambiar el color o agregar un efecto al pasar el mouse  
            Pic_Ingresar.BackColor = Color.Black; // Cambia el color de fondo al entrar el mouse  
            try
            {
                // Limpiar campos de productos
                comboProveedor.SelectedIndex = -1;
                dateTimeFecha.Value = DateTime.Now; // Mejor que DateTime.MinValue
                txtNumeroFactura.Clear();
                comboTipoCompro.SelectedIndex = -1;
                comboFormaPago.SelectedIndex = -1;
                comboProducto.SelectedIndex = -1;
                txtCantidad.Clear();
                txtPrecio.Text = "0.00";
                txtDesc.Clear();
                txtSubtotal.Clear();
                txtTotal.Clear();
                txtImpuestos.Clear();

                // Activar (habilitar) campos
                comboProveedor.Enabled = true;
                dateTimeFecha.Enabled = true;
                txtNumeroFactura.Enabled = true;
                comboTipoCompro.Enabled = true;
                comboFormaPago.Enabled = true;
                comboProducto.Enabled = true;
                txtCantidad.Enabled = true;
                txtDesc.Enabled = true;
               

          

                // Mostrar mensaje de éxito
                MessageBox.Show("Campos limpiados y activados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar los campos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarSucursales()
        {
            try
            {
                OdbcConnection connection = conn.conexion();
                string query = "SELECT Pk_prov_id, Prov_nombre FROM Tbl_proveedores";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboProveedor.DataSource = dt;
                comboProveedor.DisplayMember = "Pk_prov_id"; // Lo que se ve
                comboProveedor.ValueMember = "Pk_prov_id";       // Lo que se usa internamente

                comboProveedor.DropDownStyle = ComboBoxStyle.DropDownList;

                conn.desconexion(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void CargarBodega()
        {
            try
            {
                OdbcConnection connection = conn.conexion();
                string query = "SELECT Pk_ID_BODEGA, NOMBRE_BODEGA FROM tbl_bodegas";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboAlma.DataSource = dt;
                comboAlma.DisplayMember = "Pk_ID_BODEGA"; // Lo que se ve
                comboAlma.ValueMember = "Pk_ID_BODEGA";       // Lo que se usa internamente

                comboAlma.DropDownStyle = ComboBoxStyle.DropDownList;

                conn.desconexion(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }
        private void CargarProd()
        {
            try
            {
                // Obtener productos con precio
                List<Tuple<string, double>> productos = controlador.ObtenerProductosConPrecio();
                comboProducto.Items.Clear();

                // Guardar los productos con precio para su uso posterior
                foreach (var producto in productos)
                {
                    comboProducto.Items.Add(producto.Item1);  // Solo agregar el nombre del producto al ComboBox
                }

                // Configurar el ComboBox para permitir selección pero no edición
                comboProducto.DropDownStyle = ComboBoxStyle.DropDownList;

                // Evento para manejar la selección del producto y mostrar el precio
                comboProducto.SelectedIndexChanged += (sender, e) =>
                {
                    try
                    {
                        // Obtener el nombre del producto seleccionado
                        string productoSeleccionado = comboProducto.SelectedItem.ToString();

                        // Buscar el producto en la lista de productos con precio
                        var producto = productos.FirstOrDefault(p => p.Item1 == productoSeleccionado);

                        if (producto != null)
                        {
                            // Llenar el campo de precio con el precio del producto
                            txtPrecio.Text = producto.Item2.ToString("F2");  // Mostrar el precio con dos decimales
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener el precio del producto: " + ex.Message);
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }



        private void CargarSuc()
        {
            try
            {
                List<string> sucursales = controlador.ObtenerSucursales2();
                comboAlma.Items.Clear();
                foreach (string sucursal in sucursales)
                {
                    comboAlma.Items.Add(sucursal);
                }

                // Configurar el ComboBox para permitir selección pero no edición
                comboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sucursales: " + ex.Message);
            }
        }





        private void LlenarTiposComprobante()
        {
            comboTipoCompro.Items.Clear();

            // Lista fija
            comboTipoCompro.Items.Add("Factura");
            comboTipoCompro.Items.Add("Recibo");
            comboTipoCompro.Items.Add("Nota de Crédito");

            comboTipoCompro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LlenarFormasPago()
        {
            comboFormaPago.Items.Clear();

            comboFormaPago.Items.Add("Efectivo");
            comboFormaPago.Items.Add("Tarjeta de Crédito");
            comboFormaPago.Items.Add("Tarjeta de Débito");
            comboFormaPago.Items.Add("Transferencia");
            comboFormaPago.Items.Add("Cheque");

            comboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Agregarprod_Click(object sender, EventArgs e)
        {

     
        }

        private void Pic_Editar_Click(object sender, EventArgs e)
        {
            // Valida que haya una fila seleccionada, para evitar errores
            if (Dgv_compras.SelectedRows.Count > 0)
            {
                // Obtén el ID o clave primaria del registro seleccionado, que debería estar en alguna columna
                int idCompra = Convert.ToInt32(Dgv_compras.SelectedRows[0].Cells["Pk_ID_Compra"].Value);

                // Llama al controlador con los valores actuales de los controles (los editados)
                controlador.Pro_EditarCompra(
                    idCompra,
                    Convert.ToInt32(comboProveedor.SelectedValue),
                    dateTimeFecha.Value,
                    Convert.ToInt32(comboAlma.SelectedValue),
                    txtNumeroFactura.Text,
                    comboTipoCompro.SelectedItem.ToString(),
                    comboFormaPago.SelectedItem.ToString(),
                    Convert.ToDouble(txtSubtotal.Text),
                    Convert.ToDouble(txtImpuestos.Text),
                    Convert.ToDouble(txtTotal.Text),
                    comboProducto.SelectedItem.ToString(),
                    Convert.ToDouble(txtCantidad.Text),
                    Convert.ToDouble(txtPrecio.Text),
                    txtDesc.Text
                );

                // Refresca el DataGridView para que muestre los cambios
                CargarSolicitudesenDatagriedView();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }

        private void Pic_Guardar_Click(object sender, EventArgs e)
        {
            controlador.Pro_RegistrarCompra(
                Convert.ToInt32(comboProveedor.SelectedValue), // Asegúrate de usar SelectedValue
                dateTimeFecha.Value, // Pasa la fecha seleccionada
                Convert.ToInt32(comboAlma.SelectedValue), // Asegúrate de usar SelectedValue


                txtNumeroFactura.Text, // ← Pasa el texto tal cual, sin convertir a int
                comboTipoCompro.SelectedItem.ToString(), // Aquí pasas la palabra seleccionada
                comboFormaPago.SelectedItem.ToString(), // Aquí pasas la palabra seleccionada

                 Convert.ToDouble(txtSubtotal.Text), // Para convertir el valor del campo de texto en un double
                Convert.ToDouble(txtImpuestos.Text), // Para convertir el valor del campo de texto en un double
                Convert.ToDouble(txtTotal.Text), // Para convertir el valor del campo de texto en un double

                comboProducto.SelectedItem.ToString(), // Aquí pasas la palabra seleccionada
                Convert.ToDouble(txtCantidad.Text), // Para convertir el valor del campo de texto en un double
                Convert.ToDouble(txtPrecio.Text), // Para convertir el valor del campo de texto en un double    Convert.ToDouble(txtPrecio.Text), // Para convertir el valor del campo de texto en un double
                               txtDesc.Text // ← Pasa el texto tal cual, sin convertir a int





            );
            CargarSolicitudesenDatagriedView();
        }




        public void CargarSolicitudesenDatagriedView()
        {
            try
            {
                DataTable tablaMovimiento = controlador.Fun_MostrarMovimientosInventario();
                Dgv_compras.DataSource = tablaMovimiento;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar datos en el DataGridView: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("Por favor, ingresa la cantidad y el precio.");
                    return;
                }

                // Convertir valores
                double precio = Convert.ToDouble(txtPrecio.Text);
                double cantidad = Convert.ToDouble(txtCantidad.Text);

                // Calcular subtotal
                double subtotal = precio * cantidad;
                txtSubtotal.Text = subtotal.ToString("F2");

                // Calcular impuesto del 12%
                double impuestos = subtotal * 0.12;
                txtImpuestos.Text = impuestos.ToString("F2");

                // Calcular total
                double total = subtotal + impuestos;
                txtTotal.Text = total.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular totales: " + ex.Message);
            }
        }

        private void Pic_Ingresar_MouseEnter(object sender, EventArgs e)
        {
            Pic_Ingresar.Size = new Size(Pic_Ingresar.Width + 5, Pic_Ingresar.Height + 5);
            Pic_Ingresar.Cursor = Cursors.Hand;
            Pic_Ingresar.BackColor = Color.Black;

        }

        private void Pic_Ingresar_MouseLeave(object sender, EventArgs e)
        {
            Pic_Ingresar.Size = new Size(Pic_Ingresar.Width - 5, Pic_Ingresar.Height - 5);
            Pic_Ingresar.BackColor = Color.Transparent; // O el color original que usabas

        }

        private void Pic_Guardar_MouseEnter(object sender, EventArgs e)
        {
            Pic_Guardar.Size = new Size(Pic_Ingresar.Width + 5, Pic_Ingresar.Height + 5);
            Pic_Guardar.Cursor = Cursors.Hand;
            Pic_Guardar.BackColor = Color.Black;
        }

        private void Pic_Guardar_MouseLeave(object sender, EventArgs e)
        {
            Pic_Guardar.Size = new Size(Pic_Ingresar.Width - 5, Pic_Ingresar.Height - 5);
            Pic_Guardar.BackColor = Color.Transparent; // O el color original que usabas
        }

        private void Pic_Editar_MouseEnter(object sender, EventArgs e)
        {
            Pic_Editar.Size = new Size(Pic_Ingresar.Width + 5, Pic_Ingresar.Height + 5);
            Pic_Editar.Cursor = Cursors.Hand;
            Pic_Editar.BackColor = Color.Black;

        }

        private void Pic_Editar_MouseLeave(object sender, EventArgs e)
        {
            Pic_Editar.Size = new Size(Pic_Ingresar.Width - 5, Pic_Ingresar.Height - 5);
            Pic_Editar.BackColor = Color.Transparent; // O el color original que usabas
        }

        private void Pic_Ayuda_MouseEnter(object sender, EventArgs e)
        {
            Pic_Ayuda.Size = new Size(Pic_Ingresar.Width + 5, Pic_Ingresar.Height + 5);
            Pic_Ayuda.Cursor = Cursors.Hand;
            Pic_Ayuda.BackColor = Color.Black;
        }

        private void Pic_Ayuda_MouseLeave(object sender, EventArgs e)
        {
            Pic_Ayuda.Size = new Size(Pic_Ingresar.Width - 5, Pic_Ingresar.Height - 5);
            Pic_Ayuda.BackColor = Color.Transparent; // O el color original que usabas
        }

        private void Pic_Salir_MouseEnter(object sender, EventArgs e)
        {
            Pic_Salir.Size = new Size(Pic_Ingresar.Width + 5, Pic_Ingresar.Height + 5);
            Pic_Salir.Cursor = Cursors.Hand;
            Pic_Salir.BackColor = Color.Black;

        }

        private void Pic_Salir_MouseLeave(object sender, EventArgs e)
        {
            Pic_Salir.Size = new Size(Pic_Ingresar.Width - 5, Pic_Ingresar.Height - 5);
            Pic_Salir.BackColor = Color.Transparent; // O el color original que usabas
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(Pic_Ingresar.Width + 5, Pic_Ingresar.Height + 5);
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.BackColor = Color.Black;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(Pic_Ingresar.Width - 5, Pic_Ingresar.Height - 5);
            pictureBox1.BackColor = Color.Transparent; // O el color original que usabas
        }

        private void Btn_Eliminar_MouseEnter(object sender, EventArgs e)
        {
            Btn_Eliminar.Size = new Size(Pic_Ingresar.Width + 5, Pic_Ingresar.Height + 5);
            Btn_Eliminar.Cursor = Cursors.Hand;
            Btn_Eliminar.BackColor = Color.Black;
        }

        private void Btn_Eliminar_MouseLeave(object sender, EventArgs e)
        {
            Btn_Eliminar.Size = new Size(Pic_Ingresar.Width - 5, Pic_Ingresar.Height - 5);
            Btn_Eliminar.BackColor = Color.Transparent; // O el color original que usabas
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_compras.SelectedRows.Count > 0)
                {
                    int idCompra = Convert.ToInt32(Dgv_compras.SelectedRows[0].Cells["Pk_ID_Compra"].Value);
                    controlador.Pro_EliminarCompra(idCompra);
                    MessageBox.Show("Compra eliminada correctamente.");
                    CargarSolicitudesenDatagriedView();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una compra para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la compra: " + ex.Message);
            }
        }

        private void Dgv_compras_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_compras.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = Dgv_compras.SelectedRows[0];

                // Asumiendo que el orden de columnas es igual a tus controles
                comboProveedor.SelectedValue = Convert.ToInt32(fila.Cells["Fk_prov_id"].Value);
                dateTimeFecha.Value = Convert.ToDateTime(fila.Cells["fecha_compra"].Value);
                comboAlma.SelectedValue = Convert.ToInt32(fila.Cells["Fk_ID_BODEGA"].Value);
                txtNumeroFactura.Text = fila.Cells["numero_factura"].Value.ToString();
                comboTipoCompro.SelectedItem = fila.Cells["tipo_comprobante"].Value.ToString();
                comboFormaPago.SelectedItem = fila.Cells["forma_pago"].Value.ToString();
                txtSubtotal.Text = fila.Cells["subtotal"].Value.ToString();
                txtImpuestos.Text = fila.Cells["impuestos"].Value.ToString();
                txtTotal.Text = fila.Cells["total"].Value.ToString();
                comboProducto.SelectedItem = fila.Cells["producto"].Value.ToString();
                txtCantidad.Text = fila.Cells["cantidad"].Value.ToString();
                txtPrecio.Text = fila.Cells["precio"].Value.ToString();
                txtDesc.Text = fila.Cells["descripcion"].Value.ToString();
            }
        }

        private void Dgv_compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

