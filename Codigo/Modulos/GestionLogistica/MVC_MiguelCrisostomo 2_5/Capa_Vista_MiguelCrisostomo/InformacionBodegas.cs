using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Modelo_MiguelCrisostomo;

namespace Capa_Vista_MiguelCrisostomo
{
    public partial class InformacionBodegas : Form
    {
        private conexion conn = new conexion();

        public InformacionBodegas()
        {
            InitializeComponent();
            Txt_FiltrarBodegas.TextChanged += Txt_FiltrarBodegas_TextChanged;
            Pic_Actualizar.Click += Pic_Actualizar_Click;
            // Cargar datos al iniciar el formulario
            CargarStockBodegas();
        }

        private void InicializarControles()
        {
            // No inicializar los controles aquí, ya que los maneja el Designer
            // Solo enlazar el evento de filtrado
            Txt_FiltrarBodegas.TextChanged += Txt_FiltrarBodegas_TextChanged;
        }

        // Método para cargar datos de stock de bodegas
        private void CargarStockBodegas()
        {
            try
            {
                OdbcConnection connection = conn.Conexion();
                string query = @"
                    SELECT 
                        b.NOMBRE_BODEGA,
                        p.nombreProducto,
                        SUM(eb.CANTIDAD_ACTUAL) AS CANTIDAD_ACTUAL,
                        SUM(eb.CANTIDAD_INICIAL) AS CANTIDAD_INICIAL
                    FROM TBL_EXISTENCIAS_BODEGA eb
                    INNER JOIN TBL_BODEGAS b ON eb.Fk_ID_BODEGA = b.Pk_ID_BODEGA
                    INNER JOIN Tbl_Productos p ON eb.Fk_ID_PRODUCTO = p.Pk_id_Producto
                    WHERE b.estado = 1
                    GROUP BY b.NOMBRE_BODEGA, p.nombreProducto";
                
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Dgv_StockBodegass.DataSource = dataTable;
                // Ocultar la columna CANTIDAD_INICIAL si existe
                if (Dgv_StockBodegass.Columns.Contains("CANTIDAD_INICIAL"))
                {
                    Dgv_StockBodegass.Columns["CANTIDAD_INICIAL"].Visible = false;
                }
                conn.desconexion(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el stock de bodegas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para filtrar bodegas
        private void Txt_FiltrarBodegas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_StockBodegass.DataSource != null)
                {
                    DataTable dt = (DataTable)Dgv_StockBodegass.DataSource;
                    string searchText = Txt_FiltrarBodegas.Text.Trim();

                    if (string.IsNullOrWhiteSpace(searchText))
                    {
                        dt.DefaultView.RowFilter = "";
                    }
                    else
                    {
                        // Filtrar solo por la columna NOMBRE_BODEGA (sensible a mayúsculas/minúsculas)
                        dt.DefaultView.RowFilter = $"[NOMBRE_BODEGA] LIKE '%{searchText}%'";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar las bodegas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_Datos_Click(object sender, EventArgs e)
        {
            // Método vacío para evitar error de referencia
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Método vacío para evitar error de referencia
        }

        private void Pic_Actualizar_Click(object sender, EventArgs e)
        {
            CargarStockBodegas();
        }
    }
}
