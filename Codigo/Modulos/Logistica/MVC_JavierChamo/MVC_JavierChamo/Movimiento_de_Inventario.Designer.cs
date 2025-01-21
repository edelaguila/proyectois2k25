
namespace MVC_JavierChamo
{
    partial class Movimiento_de_Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Dgv_Inventario = new System.Windows.Forms.DataGridView();
            this.Cbo_idStock = new System.Windows.Forms.ComboBox();
            this.Txt_stock = new System.Windows.Forms.Label();
            this.Cbo_idProducto = new System.Windows.Forms.ComboBox();
            this.Txt_idProducto = new System.Windows.Forms.Label();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_estado = new System.Windows.Forms.Label();
            this.txt_numMovimiento = new System.Windows.Forms.TextBox();
            this.Txt_No_movimiento = new System.Windows.Forms.Label();
            this.Txt_local = new System.Windows.Forms.Label();
            this.Cbo_Local = new System.Windows.Forms.ComboBox();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_pdf = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Inventario
            // 
            this.Dgv_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Inventario.Location = new System.Drawing.Point(86, 296);
            this.Dgv_Inventario.Name = "Dgv_Inventario";
            this.Dgv_Inventario.Size = new System.Drawing.Size(540, 262);
            this.Dgv_Inventario.TabIndex = 42;
            this.Dgv_Inventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbMovimientoInventario_CellClick);
            // 
            // Cbo_idStock
            // 
            this.Cbo_idStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_idStock.FormattingEnabled = true;
            this.Cbo_idStock.Location = new System.Drawing.Point(470, 203);
            this.Cbo_idStock.Name = "Cbo_idStock";
            this.Cbo_idStock.Size = new System.Drawing.Size(191, 21);
            this.Cbo_idStock.TabIndex = 41;
            // 
            // Txt_stock
            // 
            this.Txt_stock.AutoSize = true;
            this.Txt_stock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_stock.Location = new System.Drawing.Point(379, 205);
            this.Txt_stock.Name = "Txt_stock";
            this.Txt_stock.Size = new System.Drawing.Size(81, 19);
            this.Txt_stock.TabIndex = 40;
            this.Txt_stock.Text = "Id del stock";
            // 
            // Cbo_idProducto
            // 
            this.Cbo_idProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_idProducto.FormattingEnabled = true;
            this.Cbo_idProducto.Location = new System.Drawing.Point(163, 203);
            this.Cbo_idProducto.Name = "Cbo_idProducto";
            this.Cbo_idProducto.Size = new System.Drawing.Size(184, 21);
            this.Cbo_idProducto.TabIndex = 39;
            // 
            // Txt_idProducto
            // 
            this.Txt_idProducto.AutoSize = true;
            this.Txt_idProducto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idProducto.Location = new System.Drawing.Point(12, 205);
            this.Txt_idProducto.Name = "Txt_idProducto";
            this.Txt_idProducto.Size = new System.Drawing.Size(104, 19);
            this.Txt_idProducto.TabIndex = 38;
            this.Txt_idProducto.Text = "Id del Producto";
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Cbo_estado.Location = new System.Drawing.Point(470, 152);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(213, 21);
            this.Cbo_estado.TabIndex = 33;
            // 
            // Txt_estado
            // 
            this.Txt_estado.AutoSize = true;
            this.Txt_estado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.Location = new System.Drawing.Point(408, 156);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(51, 19);
            this.Txt_estado.TabIndex = 32;
            this.Txt_estado.Text = "Estado";
            // 
            // txt_numMovimiento
            // 
            this.txt_numMovimiento.Location = new System.Drawing.Point(163, 157);
            this.txt_numMovimiento.Name = "txt_numMovimiento";
            this.txt_numMovimiento.Size = new System.Drawing.Size(184, 20);
            this.txt_numMovimiento.TabIndex = 31;
            // 
            // Txt_No_movimiento
            // 
            this.Txt_No_movimiento.AutoSize = true;
            this.Txt_No_movimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_No_movimiento.Location = new System.Drawing.Point(8, 158);
            this.Txt_No_movimiento.Name = "Txt_No_movimiento";
            this.Txt_No_movimiento.Size = new System.Drawing.Size(135, 19);
            this.Txt_No_movimiento.TabIndex = 30;
            this.Txt_No_movimiento.Text = "Núm. de movimiento";
            // 
            // Txt_local
            // 
            this.Txt_local.AutoSize = true;
            this.Txt_local.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_local.Location = new System.Drawing.Point(12, 252);
            this.Txt_local.Name = "Txt_local";
            this.Txt_local.Size = new System.Drawing.Size(82, 19);
            this.Txt_local.TabIndex = 45;
            this.Txt_local.Text = "Id del Local";
            // 
            // Cbo_Local
            // 
            this.Cbo_Local.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Local.FormattingEnabled = true;
            this.Cbo_Local.Location = new System.Drawing.Point(163, 251);
            this.Cbo_Local.Name = "Cbo_Local";
            this.Cbo_Local.Size = new System.Drawing.Size(121, 21);
            this.Cbo_Local.TabIndex = 46;
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_titulo.Location = new System.Drawing.Point(249, 107);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(289, 37);
            this.Txt_titulo.TabIndex = 48;
            this.Txt_titulo.Text = "Movimiento de Inventario";
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = global::MVC_JavierChamo.Properties.Resources.ayuda;
            this.Btn_ayuda.Location = new System.Drawing.Point(640, 296);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(81, 49);
            this.Btn_ayuda.TabIndex = 49;
            this.toolTip6.SetToolTip(this.Btn_ayuda, "Ayuda");
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.Image = global::MVC_JavierChamo.Properties.Resources.reporte;
            this.Btn_reporte.Location = new System.Drawing.Point(640, 8);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(95, 96);
            this.Btn_reporte.TabIndex = 47;
            this.toolTip6.SetToolTip(this.Btn_reporte, "Generar Reporte");
            this.Btn_reporte.UseVisualStyleBackColor = true;
            this.Btn_reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Image = global::MVC_JavierChamo.Properties.Resources.actualizarR;
            this.Btn_actualizar.Location = new System.Drawing.Point(383, 8);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(102, 96);
            this.Btn_actualizar.TabIndex = 44;
            this.toolTip4.SetToolTip(this.Btn_actualizar, "Actualizar ");
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // Btn_pdf
            // 
            this.Btn_pdf.Image = global::MVC_JavierChamo.Properties.Resources.PDF;
            this.Btn_pdf.Location = new System.Drawing.Point(512, 8);
            this.Btn_pdf.Name = "Btn_pdf";
            this.Btn_pdf.Size = new System.Drawing.Size(105, 96);
            this.Btn_pdf.TabIndex = 43;
            this.toolTip5.SetToolTip(this.Btn_pdf, "Generar PDF");
            this.Btn_pdf.UseVisualStyleBackColor = true;
            this.Btn_pdf.Click += new System.EventHandler(this.btn_GenerarPDF_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Image = global::MVC_JavierChamo.Properties.Resources.trash;
            this.Btn_eliminar.Location = new System.Drawing.Point(256, 8);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(101, 96);
            this.Btn_eliminar.TabIndex = 29;
            this.toolTip3.SetToolTip(this.Btn_eliminar, "Eliminar Registro");
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Image = global::MVC_JavierChamo.Properties.Resources.lapiz;
            this.Btn_editar.Location = new System.Drawing.Point(143, 10);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(91, 94);
            this.Btn_editar.TabIndex = 27;
            this.toolTip2.SetToolTip(this.Btn_editar, "Editar Registro");
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Image = global::MVC_JavierChamo.Properties.Resources.Guardar;
            this.Btn_guardar.Location = new System.Drawing.Point(16, 13);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(107, 91);
            this.Btn_guardar.TabIndex = 26;
            this.toolTip1.SetToolTip(this.Btn_guardar, "Guardar Registro");
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // Movimiento_de_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(747, 570);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Cbo_Local);
            this.Controls.Add(this.Txt_local);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_pdf);
            this.Controls.Add(this.Dgv_Inventario);
            this.Controls.Add(this.Cbo_idStock);
            this.Controls.Add(this.Txt_stock);
            this.Controls.Add(this.Cbo_idProducto);
            this.Controls.Add(this.Txt_idProducto);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Txt_estado);
            this.Controls.Add(this.txt_numMovimiento);
            this.Controls.Add(this.Txt_No_movimiento);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_guardar);
            this.Name = "Movimiento_de_Inventario";
            this.Text = "Movimiento_de_Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Inventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_pdf;
        private System.Windows.Forms.DataGridView Dgv_Inventario;
        private System.Windows.Forms.Label Txt_stock;
        private System.Windows.Forms.Label Txt_idProducto;
        private System.Windows.Forms.Label Txt_estado;
        private System.Windows.Forms.TextBox txt_numMovimiento;
        private System.Windows.Forms.Label Txt_No_movimiento;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Label Txt_local;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Label Txt_titulo;
        public System.Windows.Forms.ComboBox Cbo_idStock;
        public System.Windows.Forms.ComboBox Cbo_idProducto;
        public System.Windows.Forms.ComboBox Cbo_estado;
        public System.Windows.Forms.ComboBox Cbo_Local;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}