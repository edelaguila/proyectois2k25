
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
            this.Cbo_idtraslado = new System.Windows.Forms.ComboBox();
            this.Id_traslado = new System.Windows.Forms.Label();
            this.Txt_stockprod = new System.Windows.Forms.Label();
            this.Cbo_idprod = new System.Windows.Forms.ComboBox();
            this.Txt_idprod = new System.Windows.Forms.Label();
            this.txt_numMovimiento = new System.Windows.Forms.TextBox();
            this.Txt_No_movimiento = new System.Windows.Forms.Label();
            this.Txt_almacen = new System.Windows.Forms.Label();
            this.Cbo_almacen = new System.Windows.Forms.ComboBox();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_editar = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_pdf = new System.Windows.Forms.Button();
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Txt_tipomovimiento = new System.Windows.Forms.Label();
            this.Cbo_tipomovimiento = new System.Windows.Forms.ComboBox();
            this.Txt_cantstock = new System.Windows.Forms.NumericUpDown();
            this.Txt_almastock = new System.Windows.Forms.NumericUpDown();
            this.Txt_cantalmac = new System.Windows.Forms.Label();
            this.Cbo_idcompra = new System.Windows.Forms.ComboBox();
            this.Txt_idcompra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_cantstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_almastock)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Inventario
            // 
            this.Dgv_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Inventario.Location = new System.Drawing.Point(16, 303);
            this.Dgv_Inventario.Name = "Dgv_Inventario";
            this.Dgv_Inventario.Size = new System.Drawing.Size(618, 241);
            this.Dgv_Inventario.TabIndex = 42;
            this.Dgv_Inventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbMovimientoInventario_CellClick);
            // 
            // Cbo_idtraslado
            // 
            this.Cbo_idtraslado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_idtraslado.FormattingEnabled = true;
            this.Cbo_idtraslado.Location = new System.Drawing.Point(524, 190);
            this.Cbo_idtraslado.Name = "Cbo_idtraslado";
            this.Cbo_idtraslado.Size = new System.Drawing.Size(191, 21);
            this.Cbo_idtraslado.TabIndex = 41;
            // 
            // Id_traslado
            // 
            this.Id_traslado.AutoSize = true;
            this.Id_traslado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_traslado.Location = new System.Drawing.Point(379, 190);
            this.Id_traslado.Name = "Id_traslado";
            this.Id_traslado.Size = new System.Drawing.Size(96, 19);
            this.Id_traslado.TabIndex = 40;
            this.Id_traslado.Text = "Id del traslado";
            // 
            // Txt_stockprod
            // 
            this.Txt_stockprod.AutoSize = true;
            this.Txt_stockprod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_stockprod.Location = new System.Drawing.Point(12, 190);
            this.Txt_stockprod.Name = "Txt_stockprod";
            this.Txt_stockprod.Size = new System.Drawing.Size(126, 19);
            this.Txt_stockprod.TabIndex = 38;
            this.Txt_stockprod.Text = "Stock del producto";
            // 
            // Cbo_idprod
            // 
            this.Cbo_idprod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_idprod.FormattingEnabled = true;
            this.Cbo_idprod.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Cbo_idprod.Location = new System.Drawing.Point(524, 159);
            this.Cbo_idprod.Name = "Cbo_idprod";
            this.Cbo_idprod.Size = new System.Drawing.Size(191, 21);
            this.Cbo_idprod.TabIndex = 33;
            // 
            // Txt_idprod
            // 
            this.Txt_idprod.AutoSize = true;
            this.Txt_idprod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idprod.Location = new System.Drawing.Point(379, 158);
            this.Txt_idprod.Name = "Txt_idprod";
            this.Txt_idprod.Size = new System.Drawing.Size(103, 19);
            this.Txt_idprod.TabIndex = 32;
            this.Txt_idprod.Text = "Id del producto";
            // 
            // txt_numMovimiento
            // 
            this.txt_numMovimiento.Location = new System.Drawing.Point(149, 159);
            this.txt_numMovimiento.Name = "txt_numMovimiento";
            this.txt_numMovimiento.ReadOnly = true;
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
            // Txt_almacen
            // 
            this.Txt_almacen.AutoSize = true;
            this.Txt_almacen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_almacen.Location = new System.Drawing.Point(12, 223);
            this.Txt_almacen.Name = "Txt_almacen";
            this.Txt_almacen.Size = new System.Drawing.Size(100, 19);
            this.Txt_almacen.TabIndex = 45;
            this.Txt_almacen.Text = "Id del Almacén";
            // 
            // Cbo_almacen
            // 
            this.Cbo_almacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_almacen.FormattingEnabled = true;
            this.Cbo_almacen.Location = new System.Drawing.Point(149, 224);
            this.Cbo_almacen.Name = "Cbo_almacen";
            this.Cbo_almacen.Size = new System.Drawing.Size(121, 21);
            this.Cbo_almacen.TabIndex = 46;
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_titulo.Location = new System.Drawing.Point(217, 107);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(289, 37);
            this.Txt_titulo.TabIndex = 48;
            this.Txt_titulo.Text = "Movimiento de Inventario";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Image = global::MVC_JavierChamo.Properties.Resources.agregar_archivo;
            this.Btn_guardar.Location = new System.Drawing.Point(16, 13);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(107, 91);
            this.Btn_guardar.TabIndex = 26;
            this.toolTip1.SetToolTip(this.Btn_guardar, "Guardar Registro");
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Image = global::MVC_JavierChamo.Properties.Resources.Guardar;
            this.Btn_editar.Location = new System.Drawing.Point(143, 10);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(91, 94);
            this.Btn_editar.TabIndex = 27;
            this.toolTip2.SetToolTip(this.Btn_editar, "Editar Registro");
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Image = global::MVC_JavierChamo.Properties.Resources.cancelar;
            this.Btn_eliminar.Location = new System.Drawing.Point(256, 8);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(101, 96);
            this.Btn_eliminar.TabIndex = 29;
            this.toolTip3.SetToolTip(this.Btn_eliminar, "Eliminar Registro");
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Image = global::MVC_JavierChamo.Properties.Resources.ACTUALIZAR_V4;
            this.Btn_actualizar.Location = new System.Drawing.Point(640, 303);
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
            this.Btn_pdf.Location = new System.Drawing.Point(383, 8);
            this.Btn_pdf.Name = "Btn_pdf";
            this.Btn_pdf.Size = new System.Drawing.Size(105, 96);
            this.Btn_pdf.TabIndex = 43;
            this.toolTip5.SetToolTip(this.Btn_pdf, "Generar PDF");
            this.Btn_pdf.UseVisualStyleBackColor = true;
            this.Btn_pdf.Click += new System.EventHandler(this.btn_GenerarPDF_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = global::MVC_JavierChamo.Properties.Resources.preguntas;
            this.Btn_ayuda.Location = new System.Drawing.Point(630, 11);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(105, 94);
            this.Btn_ayuda.TabIndex = 49;
            this.toolTip6.SetToolTip(this.Btn_ayuda, "Ayuda");
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.Image = global::MVC_JavierChamo.Properties.Resources.reporte2;
            this.Btn_reporte.Location = new System.Drawing.Point(510, 8);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(95, 96);
            this.Btn_reporte.TabIndex = 47;
            this.toolTip6.SetToolTip(this.Btn_reporte, "Generar Reporte");
            this.Btn_reporte.UseVisualStyleBackColor = true;
            this.Btn_reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // Txt_tipomovimiento
            // 
            this.Txt_tipomovimiento.AutoSize = true;
            this.Txt_tipomovimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_tipomovimiento.Location = new System.Drawing.Point(379, 257);
            this.Txt_tipomovimiento.Name = "Txt_tipomovimiento";
            this.Txt_tipomovimiento.Size = new System.Drawing.Size(128, 19);
            this.Txt_tipomovimiento.TabIndex = 50;
            this.Txt_tipomovimiento.Text = "Tipo de movimiento";
            // 
            // Cbo_tipomovimiento
            // 
            this.Cbo_tipomovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_tipomovimiento.FormattingEnabled = true;
            this.Cbo_tipomovimiento.Items.AddRange(new object[] {
            "Positivo",
            "Negativo"});
            this.Cbo_tipomovimiento.Location = new System.Drawing.Point(524, 258);
            this.Cbo_tipomovimiento.Name = "Cbo_tipomovimiento";
            this.Cbo_tipomovimiento.Size = new System.Drawing.Size(191, 21);
            this.Cbo_tipomovimiento.TabIndex = 51;
            // 
            // Txt_cantstock
            // 
            this.Txt_cantstock.Location = new System.Drawing.Point(149, 192);
            this.Txt_cantstock.Name = "Txt_cantstock";
            this.Txt_cantstock.Size = new System.Drawing.Size(184, 20);
            this.Txt_cantstock.TabIndex = 53;
            // 
            // Txt_almastock
            // 
            this.Txt_almastock.Location = new System.Drawing.Point(524, 224);
            this.Txt_almastock.Name = "Txt_almastock";
            this.Txt_almastock.Size = new System.Drawing.Size(191, 20);
            this.Txt_almastock.TabIndex = 55;
            // 
            // Txt_cantalmac
            // 
            this.Txt_cantalmac.AutoSize = true;
            this.Txt_cantalmac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cantalmac.Location = new System.Drawing.Point(379, 223);
            this.Txt_cantalmac.Name = "Txt_cantalmac";
            this.Txt_cantalmac.Size = new System.Drawing.Size(139, 19);
            this.Txt_cantalmac.TabIndex = 54;
            this.Txt_cantalmac.Text = "Cantidad del almacén";
            // 
            // Cbo_idcompra
            // 
            this.Cbo_idcompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_idcompra.FormattingEnabled = true;
            this.Cbo_idcompra.Location = new System.Drawing.Point(149, 258);
            this.Cbo_idcompra.Name = "Cbo_idcompra";
            this.Cbo_idcompra.Size = new System.Drawing.Size(121, 21);
            this.Cbo_idcompra.TabIndex = 57;
            // 
            // Txt_idcompra
            // 
            this.Txt_idcompra.AutoSize = true;
            this.Txt_idcompra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idcompra.Location = new System.Drawing.Point(12, 257);
            this.Txt_idcompra.Name = "Txt_idcompra";
            this.Txt_idcompra.Size = new System.Drawing.Size(95, 19);
            this.Txt_idcompra.TabIndex = 56;
            this.Txt_idcompra.Text = "Id de Compra";
            // 
            // Movimiento_de_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(747, 570);
            this.Controls.Add(this.Cbo_idcompra);
            this.Controls.Add(this.Txt_idcompra);
            this.Controls.Add(this.Txt_almastock);
            this.Controls.Add(this.Txt_cantalmac);
            this.Controls.Add(this.Txt_cantstock);
            this.Controls.Add(this.Cbo_tipomovimiento);
            this.Controls.Add(this.Txt_tipomovimiento);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Cbo_almacen);
            this.Controls.Add(this.Txt_almacen);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_pdf);
            this.Controls.Add(this.Dgv_Inventario);
            this.Controls.Add(this.Cbo_idtraslado);
            this.Controls.Add(this.Id_traslado);
            this.Controls.Add(this.Txt_stockprod);
            this.Controls.Add(this.Cbo_idprod);
            this.Controls.Add(this.Txt_idprod);
            this.Controls.Add(this.txt_numMovimiento);
            this.Controls.Add(this.Txt_No_movimiento);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_guardar);
            this.Name = "Movimiento_de_Inventario";
            this.Text = "Movimiento_de_Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_cantstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_almastock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_pdf;
        private System.Windows.Forms.DataGridView Dgv_Inventario;
        private System.Windows.Forms.Label Id_traslado;
        private System.Windows.Forms.Label Txt_stockprod;
        private System.Windows.Forms.Label Txt_idprod;
        private System.Windows.Forms.TextBox txt_numMovimiento;
        private System.Windows.Forms.Label Txt_No_movimiento;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Label Txt_almacen;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Label Txt_titulo;
        public System.Windows.Forms.ComboBox Cbo_idtraslado;
        public System.Windows.Forms.ComboBox Cbo_idprod;
        public System.Windows.Forms.ComboBox Cbo_almacen;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.Label Txt_tipomovimiento;
        public System.Windows.Forms.ComboBox Cbo_tipomovimiento;
        private System.Windows.Forms.NumericUpDown Txt_cantstock;
        private System.Windows.Forms.NumericUpDown Txt_almastock;
        private System.Windows.Forms.Label Txt_cantalmac;
        public System.Windows.Forms.ComboBox Cbo_idcompra;
        private System.Windows.Forms.Label Txt_idcompra;
    }
}