using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Vista_Compras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                string url = "http://192.168.43.90:5000/api/empleados";

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
    }
}
