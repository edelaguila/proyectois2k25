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
            CargarSolicitudesenDatagriedView();
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
                Dgv_compras.Rows.Clear();

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
            controlador.Pro_RegistrarCompra(
                Convert.ToInt32(comboProveedor.SelectedValue), // Asegúrate de usar SelectedValue
                dateTimeFecha.Value, // Pasa la fecha seleccionada
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


        private void ActualizarDataGridView()
        {
            try
            {
                // Conexión a la base de datos
                OdbcConnection connection = conn.conexion();

                // Consulta para obtener todas las compras registradas desde la tabla correcta
                string query = "SELECT Pk_id_compra, Fk_prov_id, fecha_compra, numero_factura, tipo_comprobante, forma_pago, subtotal, impuestos, total, producto FROM Tbl_compra";

                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    OdbcDataReader reader = cmd.ExecuteReader();

                    // Limpiar el DataGridView antes de llenarlo con los nuevos datos
                    Dgv_compras.Rows.Clear();

                    // Llenar el DataGridView con los datos obtenidos
                    while (reader.Read())
                    {
                        Dgv_compras.Rows.Add(
                            reader["Pk_id_compra"],
                            reader["Fk_prov_id"],
                            reader["fecha_compra"],
                            reader["numero_factura"],
                            reader["tipo_comprobante"],
                            reader["forma_pago"],
                            reader["subtotal"],
                            reader["impuestos"],
                            reader["total"],
                            reader["producto"]
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



    }

}

