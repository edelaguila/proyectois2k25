using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_MiguelCrisostomo
{
    public partial class DetalleTraslado : Form
    {
        private DataGridView dgvDetalles;

        public DetalleTraslado()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            AjustarControles();
        }

        private void ConfigurarDataGridView()
        {
            dgvDetalles = new DataGridView();
            dgvDetalles.Location = new Point(20, 100); // Margen izquierdo de 20
            dgvDetalles.Size = new Size(740, 320); // Reducir el ancho y alto para dejar márgenes
            dgvDetalles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Configurar columnas
            dgvDetalles.Columns.Add("codigoProducto", "Código");
            dgvDetalles.Columns.Add("nombreProducto", "Nombre");
            dgvDetalles.Columns.Add("stock", "Stock");
            dgvDetalles.Columns.Add("cantidad", "Cantidad");
            dgvDetalles.Columns.Add("precioUnitario", "Precio Unitario");
            dgvDetalles.Columns.Add("pesoProducto", "Peso");

            // Configuración adicional del DataGridView
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.ReadOnly = true;
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.MultiSelect = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.Controls.Add(dgvDetalles);
        }

        private void AjustarControles()
        {
            // Agregar etiquetas para los TextBox
            Label lblOrigen = new Label();
            //lblOrigen.Text = "Bodega Origen:";
            lblOrigen.Location = new Point(10, 15);
            lblOrigen.AutoSize = true;
            this.Controls.Add(lblOrigen);

            Label lblDestino = new Label();
            //lblDestino.Text = "Bodega Destino:";
            lblDestino.Location = new Point(220, 15);
            lblDestino.AutoSize = true;
            this.Controls.Add(lblDestino);

            // Ajustar posición y apariencia de los TextBox
            //Txt_BodegaOrigen.Location = new Point(100, 12);
            Txt_BodegaOrigen.Enabled = false;
            Txt_BodegaOrigen.BackColor = System.Drawing.Color.White;
            Txt_BodegaOrigen.ForeColor = System.Drawing.Color.Black;
            Txt_BodegaOrigen.BorderStyle = BorderStyle.FixedSingle;
            Txt_BodegaOrigen.TabStop = false;
            Txt_BodegaOrigen.Cursor = Cursors.Default;
            Txt_BodegaOrigen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);

            //Txt_BodegaDestino.Location = new Point(310, 12);
            Txt_BodegaDestino.Enabled = false;
            Txt_BodegaDestino.BackColor = System.Drawing.Color.White;
            Txt_BodegaDestino.ForeColor = System.Drawing.Color.Black;
            Txt_BodegaDestino.BorderStyle = BorderStyle.FixedSingle;
            Txt_BodegaDestino.TabStop = false;
            Txt_BodegaDestino.Cursor = Cursors.Default;
            Txt_BodegaDestino.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        }

        public void CargarDatos(DataTable dt)
        {
            dgvDetalles.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvDetalles.Rows.Add(
                    row["codigoProducto"],
                    row["nombreProducto"],
                    row["stock"],
                    row["cantidad"],
                    row["precioUnitario"],
                    row["pesoProducto"]
                );
            }
        }

        private void Txt_BodegaDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_BodegaOrigen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
