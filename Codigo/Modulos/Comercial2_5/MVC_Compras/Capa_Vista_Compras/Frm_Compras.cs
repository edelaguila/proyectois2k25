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
           
        }

        private void Pic_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar campos de productos
                comboProveedor.SelectedIndex = -1;
                dateTimeFecha.Value = DateTime.MinValue;
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

              

                // Limpiar el DataGridView de productos
                Dgv_TrasladoDProductos.Rows.Clear();

                // Mostrar mensaje de éxito
                MessageBox.Show("Campos limpiados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CargarProd()
        {
            try
            {
                List<string> sucursales = controlador.ObtenerProductos();
                comboProducto.Items.Clear();
                foreach (string sucursal in sucursales)
                {
                    comboProducto.Items.Add(sucursal);
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



        }

        private void Pic_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboProveedor.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un proveedor válido.");
                    return;
                }

                int idProveedor = Convert.ToInt32(comboProveedor.SelectedValue);
                DateTime fechaCompra = dateTimeFecha.Value;
                string numeroFactura = txtNumeroFactura.Text;
                string tipoComprobante = comboTipoCompro.SelectedItem?.ToString();
                string formaPago = comboFormaPago.SelectedItem?.ToString();

                decimal subtotal = decimal.Parse(txtSubtotal.Text);
                decimal impuestos = decimal.Parse(txtImpuestos.Text);
                decimal total = decimal.Parse(txtTotal.Text);

                string producto = comboProducto.SelectedItem?.ToString();
                int cantidad = int.Parse(txtCantidad.Text);
                decimal precio = decimal.Parse(txtPrecio.Text);
                string descripcion = txtDesc.Text;

                string query = @"INSERT INTO compras 
                         (Pk_prov_id, fecha_compra, numero_factura, tipo_comprobante, forma_pago, 
                          subtotal, impuestos, total, producto, cantidad, precio, descripcion, estado, fecha_registro) 
                         VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?";

                using (OdbcConnection connection = conn.conexion())
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Pk_prov_id", idProveedor);
                    cmd.Parameters.AddWithValue("@fecha_compra", fechaCompra.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@numero_factura", numeroFactura);
                    cmd.Parameters.AddWithValue("@tipo_comprobante", tipoComprobante);
                    cmd.Parameters.AddWithValue("@forma_pago", formaPago);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);
                    cmd.Parameters.AddWithValue("@impuestos", impuestos);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@producto", producto);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);

                    cmd.ExecuteNonQuery();
                    conn.desconexion(connection);
                }

                MessageBox.Show("Compra registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique los valores numéricos (subtotal, impuestos, total, cantidad, precio).", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarDataGridView()
        {
            try
            {
                // Conexión a la base de datos
                OdbcConnection connection = conn.conexion();

                // Consulta para obtener todas las compras registradas
                string query = "SELECT id_compra, id_proveedor, fecha_compra, numero_factura, tipo_comprobante, forma_pago, subtotal, impuestos, total, estado FROM compras";

                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    OdbcDataReader reader = cmd.ExecuteReader();

                    // Limpiar el DataGridView antes de llenarlo con los nuevos datos
                    Dgv_TrasladoDProductos.Rows.Clear();

                    // Llenar el DataGridView con los datos obtenidos
                    while (reader.Read())
                    {
                        Dgv_TrasladoDProductos.Rows.Add(
                            reader["id_compra"],
                            reader["id_proveedor"],
                            reader["fecha_compra"],
                            reader["numero_factura"],
                            reader["tipo_comprobante"],
                            reader["forma_pago"],
                            reader["subtotal"],
                            reader["impuestos"],
                            reader["total"],
                            reader["estado"]
                        );
                    }
                }

                // Cerrar la conexión
                conn.desconexion(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el DataGridView: " + ex.Message);
            }
        }


    }




}

