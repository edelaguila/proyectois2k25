using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Compras;
using Capa_Modelo_Compras;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Vista_Compras
{
    public partial class Form1 : Form
    {
        private ControladorCompras controlador = new ControladorCompras();
        private Conexion conn = new Conexion();
        public Form1()
        {
            InitializeComponent();
            CargarSolicitudesenDatagriedView();
            this.Load += Form1_Load;
        }

        public class Vendedor
        {
            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("nombre")]
            public string nombre { get; set; }

            [JsonProperty("fk_id_vendedores")]
            public int vendedorId { get; set; }
        }

        public async Task<List<Vendedor>> ObtenerVendedores()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "http://localhost:5000/api/empleados";

                try
                {
                    var response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();
                    var vendedores = JsonConvert.DeserializeObject<List<Vendedor>>(json);
                    return vendedores ?? new List<Vendedor>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la API: " + ex.Message);
                    return new List<Vendedor>();
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var vendedores = await ObtenerVendedores();

            // Agregar opción por defecto
            vendedores.Insert(0, new Vendedor { id = 0, nombre = "-- Seleccione un vendedor --" });

            cboAPI.DataSource = vendedores;
            cboAPI.DisplayMember = "nombre";   // <- Esta propiedad sí existe ahora
            cboAPI.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboAPI.SelectedItem is Vendedor vendedor && vendedor.id != 0)
            {
                MessageBox.Show($"ID: {vendedor.id}, Nombre: {vendedor.nombre}, VendedorID: {vendedor.vendedorId}");
            }
            else
            {
                MessageBox.Show("Seleccione un vendedor válido.");
            }
        }

        private void Pic_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.Pro_InsertarVendedor(
                    Convert.ToInt32(textBox1.Text),           // ID del vendedor
                    textBox2.Text.Trim(),                         // Nombre
                    textBox3.Text.Trim(),                       // Apellido
                    Convert.ToDouble(textBox4.Text),
                    textBox5.Text.Trim(),                      // Dirección
                    textBox6.Text.Trim(),                       // Teléfono
                    Convert.ToInt32(cboAPI.SelectedValue)     // FK Empleado (de un ComboBox)
                );
                CargarSolicitudesenDatagriedView();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar vendedor: " + ex.Message);
            }
        }
        public void CargarSolicitudesenDatagriedView()
        {
            try
            {
                DataTable tablaMovimiento = controlador.Fun_MostrarMovimientosInventario2();
                dataGridView1.DataSource = tablaMovimiento;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar datos en el DataGridView: " + ex.Message);
            }
        }

        private void Pic_Editar_Click(object sender, EventArgs e)
        {

        }
        private void Dgv_compras_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];

                // Campos de vendedores (adaptar según las columnas disponibles en el DataGridView)
                textBox1.Text = fila.Cells["Pk_id_vendedor"].Value.ToString();
                textBox2.Text = fila.Cells["vendedores_nombre"].Value.ToString();
                textBox3.Text = fila.Cells["vendedores_apellido"].Value.ToString();
                textBox4.Text = fila.Cells["vendedores_sueldo"].Value.ToString();
                textBox5.Text = fila.Cells["vendedores_direccion"].Value.ToString();
                textBox6.Text = fila.Cells["vendedores_telefono"].Value.ToString();
            }
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el ID del vendedor de la fila seleccionada (ajusta el nombre de la columna)
                int idVendedor = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Pk_id_vendedor"].Value);

                try
                {
                    controlador.Pro_EliminarVendedor(idVendedor);
                    MessageBox.Show("Vendedor eliminado correctamente.");

                    // Recarga o refresca el DataGridView después de eliminar
                    CargarSolicitudesenDatagriedView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar vendedor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un vendedor para eliminar.");
            }
        }

    }

}

