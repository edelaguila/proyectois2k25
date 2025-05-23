
namespace Capa_Vista_Cotizacion
{
    partial class frm_cotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cotizaciones));
            this.Gpb_Enacabezado = new System.Windows.Forms.GroupBox();
            this.Btn_nuevoCE = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Dtp_fechaV = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_tipCliente = new System.Windows.Forms.Label();
            this.Txt_ClienteB = new System.Windows.Forms.TextBox();
            this.Txt_idEncezado = new System.Windows.Forms.TextBox();
            this.Cbo_cliente = new System.Windows.Forms.ComboBox();
            this.Cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.Txt_Clienten = new System.Windows.Forms.Label();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.Txt_totaln = new System.Windows.Forms.Label();
            this.Txt_Vendedorn = new System.Windows.Forms.Label();
            this.Txt_idE = new System.Windows.Forms.Label();
            this.Gpb_detalle = new System.Windows.Forms.GroupBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Dgv_cotizacion = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_cantidad = new System.Windows.Forms.NumericUpDown();
            this.Txt_precion = new System.Windows.Forms.Label();
            this.Txt_precio = new System.Windows.Forms.TextBox();
            this.Txt_cantidadn = new System.Windows.Forms.Label();
            this.Cbo_producto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_producton = new System.Windows.Forms.Label();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Gpb_Enacabezado.SuspendLayout();
            this.Gpb_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_Enacabezado
            // 
            this.Gpb_Enacabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.Gpb_Enacabezado.Controls.Add(this.Btn_nuevoCE);
            this.Gpb_Enacabezado.Controls.Add(this.Btn_cancelar);
            this.Gpb_Enacabezado.Controls.Add(this.Dtp_fechaV);
            this.Gpb_Enacabezado.Controls.Add(this.label2);
            this.Gpb_Enacabezado.Controls.Add(this.Txt_tipCliente);
            this.Gpb_Enacabezado.Controls.Add(this.Txt_ClienteB);
            this.Gpb_Enacabezado.Controls.Add(this.Txt_idEncezado);
            this.Gpb_Enacabezado.Controls.Add(this.Cbo_cliente);
            this.Gpb_Enacabezado.Controls.Add(this.Cbo_vendedor);
            this.Gpb_Enacabezado.Controls.Add(this.Txt_Clienten);
            this.Gpb_Enacabezado.Controls.Add(this.Txt_total);
            this.Gpb_Enacabezado.Controls.Add(this.Txt_totaln);
            this.Gpb_Enacabezado.Controls.Add(this.Txt_Vendedorn);
            this.Gpb_Enacabezado.Controls.Add(this.Txt_idE);
            this.Gpb_Enacabezado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Gpb_Enacabezado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Enacabezado.Location = new System.Drawing.Point(19, 77);
            this.Gpb_Enacabezado.Name = "Gpb_Enacabezado";
            this.Gpb_Enacabezado.Size = new System.Drawing.Size(755, 137);
            this.Gpb_Enacabezado.TabIndex = 302;
            this.Gpb_Enacabezado.TabStop = false;
            this.Gpb_Enacabezado.Text = "Encabezado";
            this.Gpb_Enacabezado.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Btn_nuevoCE
            // 
            this.Btn_nuevoCE.BackColor = System.Drawing.Color.Transparent;
            this.Btn_nuevoCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_nuevoCE.FlatAppearance.BorderSize = 0;
            this.Btn_nuevoCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevoCE.Image = ((System.Drawing.Image)(resources.GetObject("Btn_nuevoCE.Image")));
            this.Btn_nuevoCE.Location = new System.Drawing.Point(585, 70);
            this.Btn_nuevoCE.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_nuevoCE.Name = "Btn_nuevoCE";
            this.Btn_nuevoCE.Size = new System.Drawing.Size(61, 53);
            this.Btn_nuevoCE.TabIndex = 311;
            this.Btn_nuevoCE.UseVisualStyleBackColor = false;
            this.Btn_nuevoCE.Click += new System.EventHandler(this.Btn_nuevoCE_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.Location = new System.Drawing.Point(666, 70);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(61, 53);
            this.Btn_cancelar.TabIndex = 312;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click_1);
            // 
            // Dtp_fechaV
            // 
            this.Dtp_fechaV.Cursor = System.Windows.Forms.Cursors.Default;
            this.Dtp_fechaV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechaV.Location = new System.Drawing.Point(147, 87);
            this.Dtp_fechaV.Name = "Dtp_fechaV";
            this.Dtp_fechaV.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fechaV.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fecha Vencimiento";
            // 
            // Txt_tipCliente
            // 
            this.Txt_tipCliente.AutoSize = true;
            this.Txt_tipCliente.Location = new System.Drawing.Point(600, 34);
            this.Txt_tipCliente.Name = "Txt_tipCliente";
            this.Txt_tipCliente.Size = new System.Drawing.Size(36, 19);
            this.Txt_tipCliente.TabIndex = 29;
            this.Txt_tipCliente.Text = "Tipo";
            // 
            // Txt_ClienteB
            // 
            this.Txt_ClienteB.Cursor = System.Windows.Forms.Cursors.Default;
            this.Txt_ClienteB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ClienteB.Location = new System.Drawing.Point(642, 34);
            this.Txt_ClienteB.Name = "Txt_ClienteB";
            this.Txt_ClienteB.Size = new System.Drawing.Size(85, 22);
            this.Txt_ClienteB.TabIndex = 29;
            // 
            // Txt_idEncezado
            // 
            this.Txt_idEncezado.Cursor = System.Windows.Forms.Cursors.Default;
            this.Txt_idEncezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idEncezado.Location = new System.Drawing.Point(48, 30);
            this.Txt_idEncezado.Name = "Txt_idEncezado";
            this.Txt_idEncezado.Size = new System.Drawing.Size(121, 22);
            this.Txt_idEncezado.TabIndex = 9;
            this.Txt_idEncezado.TextChanged += new System.EventHandler(this.Txt_idEncezado_TextChanged);
            // 
            // Cbo_cliente
            // 
            this.Cbo_cliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbo_cliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cliente.FormattingEnabled = true;
            this.Cbo_cliente.Location = new System.Drawing.Point(464, 30);
            this.Cbo_cliente.Name = "Cbo_cliente";
            this.Cbo_cliente.Size = new System.Drawing.Size(121, 23);
            this.Cbo_cliente.TabIndex = 5;
            this.Cbo_cliente.SelectedIndexChanged += new System.EventHandler(this.Cbo_cliente_SelectedIndexChanged_1);
            // 
            // Cbo_vendedor
            // 
            this.Cbo_vendedor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cbo_vendedor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_vendedor.FormattingEnabled = true;
            this.Cbo_vendedor.Location = new System.Drawing.Point(257, 30);
            this.Cbo_vendedor.Name = "Cbo_vendedor";
            this.Cbo_vendedor.Size = new System.Drawing.Size(121, 23);
            this.Cbo_vendedor.TabIndex = 4;
            this.Cbo_vendedor.SelectedIndexChanged += new System.EventHandler(this.Cbo_vendedor_SelectedIndexChanged);
            // 
            // Txt_Clienten
            // 
            this.Txt_Clienten.AutoSize = true;
            this.Txt_Clienten.Location = new System.Drawing.Point(407, 34);
            this.Txt_Clienten.Name = "Txt_Clienten";
            this.Txt_Clienten.Size = new System.Drawing.Size(51, 19);
            this.Txt_Clienten.TabIndex = 2;
            this.Txt_Clienten.Text = "Cliente";
            // 
            // Txt_total
            // 
            this.Txt_total.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_total.Location = new System.Drawing.Point(452, 87);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(121, 22);
            this.Txt_total.TabIndex = 26;
            this.Txt_total.UseWaitCursor = true;
            // 
            // Txt_totaln
            // 
            this.Txt_totaln.AutoSize = true;
            this.Txt_totaln.Location = new System.Drawing.Point(387, 87);
            this.Txt_totaln.Name = "Txt_totaln";
            this.Txt_totaln.Size = new System.Drawing.Size(39, 19);
            this.Txt_totaln.TabIndex = 27;
            this.Txt_totaln.Text = "Total";
            this.Txt_totaln.Click += new System.EventHandler(this.Txt_totaln_Click_1);
            // 
            // Txt_Vendedorn
            // 
            this.Txt_Vendedorn.AutoSize = true;
            this.Txt_Vendedorn.Location = new System.Drawing.Point(190, 34);
            this.Txt_Vendedorn.Name = "Txt_Vendedorn";
            this.Txt_Vendedorn.Size = new System.Drawing.Size(68, 19);
            this.Txt_Vendedorn.TabIndex = 1;
            this.Txt_Vendedorn.Text = "Vendedor";
            // 
            // Txt_idE
            // 
            this.Txt_idE.AutoSize = true;
            this.Txt_idE.Location = new System.Drawing.Point(8, 31);
            this.Txt_idE.Name = "Txt_idE";
            this.Txt_idE.Size = new System.Drawing.Size(25, 19);
            this.Txt_idE.TabIndex = 0;
            this.Txt_idE.Text = "ID";
            // 
            // Gpb_detalle
            // 
            this.Gpb_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.Gpb_detalle.Controls.Add(this.Btn_agregar);
            this.Gpb_detalle.Controls.Add(this.Btn_borrar);
            this.Gpb_detalle.Controls.Add(this.Dgv_cotizacion);
            this.Gpb_detalle.Controls.Add(this.Txt_cantidad);
            this.Gpb_detalle.Controls.Add(this.Txt_precion);
            this.Gpb_detalle.Controls.Add(this.Txt_precio);
            this.Gpb_detalle.Controls.Add(this.Txt_cantidadn);
            this.Gpb_detalle.Controls.Add(this.Cbo_producto);
            this.Gpb_detalle.Controls.Add(this.label6);
            this.Gpb_detalle.Controls.Add(this.Txt_producton);
            this.Gpb_detalle.Cursor = System.Windows.Forms.Cursors.Default;
            this.Gpb_detalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_detalle.Location = new System.Drawing.Point(19, 220);
            this.Gpb_detalle.Name = "Gpb_detalle";
            this.Gpb_detalle.Size = new System.Drawing.Size(755, 317);
            this.Gpb_detalle.TabIndex = 304;
            this.Gpb_detalle.TabStop = false;
            this.Gpb_detalle.Text = "Detalle";
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_agregar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_agregar.Image")));
            this.Btn_agregar.Location = new System.Drawing.Point(597, 119);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(61, 53);
            this.Btn_agregar.TabIndex = 324;
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_borrar.FlatAppearance.BorderSize = 0;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.Location = new System.Drawing.Point(597, 192);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(61, 53);
            this.Btn_borrar.TabIndex = 315;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Dgv_cotizacion
            // 
            this.Dgv_cotizacion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dgv_cotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.SubTotal});
            this.Dgv_cotizacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.Dgv_cotizacion.Location = new System.Drawing.Point(138, 74);
            this.Dgv_cotizacion.Name = "Dgv_cotizacion";
            this.Dgv_cotizacion.Size = new System.Drawing.Size(447, 216);
            this.Dgv_cotizacion.TabIndex = 10;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // Txt_cantidad
            // 
            this.Txt_cantidad.Location = new System.Drawing.Point(648, 21);
            this.Txt_cantidad.Name = "Txt_cantidad";
            this.Txt_cantidad.Size = new System.Drawing.Size(76, 26);
            this.Txt_cantidad.TabIndex = 11;
            // 
            // Txt_precion
            // 
            this.Txt_precion.AutoSize = true;
            this.Txt_precion.Location = new System.Drawing.Point(330, 28);
            this.Txt_precion.Name = "Txt_precion";
            this.Txt_precion.Size = new System.Drawing.Size(48, 19);
            this.Txt_precion.TabIndex = 31;
            this.Txt_precion.Text = "Precio";
            this.Txt_precion.Click += new System.EventHandler(this.Txt_precion_Click);
            // 
            // Txt_precio
            // 
            this.Txt_precio.Cursor = System.Windows.Forms.Cursors.Default;
            this.Txt_precio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precio.Location = new System.Drawing.Point(402, 25);
            this.Txt_precio.Name = "Txt_precio";
            this.Txt_precio.Size = new System.Drawing.Size(121, 22);
            this.Txt_precio.TabIndex = 30;
            // 
            // Txt_cantidadn
            // 
            this.Txt_cantidadn.AutoSize = true;
            this.Txt_cantidadn.Location = new System.Drawing.Point(572, 26);
            this.Txt_cantidadn.Name = "Txt_cantidadn";
            this.Txt_cantidadn.Size = new System.Drawing.Size(64, 19);
            this.Txt_cantidadn.TabIndex = 29;
            this.Txt_cantidadn.Text = "Cantidad";
            // 
            // Cbo_producto
            // 
            this.Cbo_producto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_producto.FormattingEnabled = true;
            this.Cbo_producto.Location = new System.Drawing.Point(79, 28);
            this.Cbo_producto.Name = "Cbo_producto";
            this.Cbo_producto.Size = new System.Drawing.Size(230, 23);
            this.Cbo_producto.TabIndex = 10;
            this.Cbo_producto.SelectedIndexChanged += new System.EventHandler(this.Cbo_producto_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 10;
            this.label6.UseWaitCursor = true;
            // 
            // Txt_producton
            // 
            this.Txt_producton.AutoSize = true;
            this.Txt_producton.Location = new System.Drawing.Point(8, 31);
            this.Txt_producton.Name = "Txt_producton";
            this.Txt_producton.Size = new System.Drawing.Size(65, 19);
            this.Txt_producton.TabIndex = 9;
            this.Txt_producton.Text = "Producto";
            this.Txt_producton.Click += new System.EventHandler(this.Txt_producton_Click_1);
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 26F);
            this.Txt_titulo.Location = new System.Drawing.Point(305, 14);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(190, 37);
            this.Txt_titulo.TabIndex = 305;
            this.Txt_titulo.Text = "C O T I Z A C I Ó N";
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(666, 10);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(42, 39);
            this.Btn_ayuda.TabIndex = 308;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.Transparent;
            this.Btn_reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_reporte.FlatAppearance.BorderSize = 0;
            this.Btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_reporte.Image")));
            this.Btn_reporte.Location = new System.Drawing.Point(747, 7);
            this.Btn_reporte.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(43, 44);
            this.Btn_reporte.TabIndex = 309;
            this.Btn_reporte.UseVisualStyleBackColor = false;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // frm_cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(812, 558);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.Gpb_detalle);
            this.Controls.Add(this.Gpb_Enacabezado);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cotizaciones";
            this.Text = "Cotizaciones";
            this.Load += new System.EventHandler(this.frm_cotizaciones_Load);
            this.Gpb_Enacabezado.ResumeLayout(false);
            this.Gpb_Enacabezado.PerformLayout();
            this.Gpb_detalle.ResumeLayout(false);
            this.Gpb_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Gpb_Enacabezado;
        private System.Windows.Forms.TextBox Txt_idEncezado;
        private System.Windows.Forms.ComboBox Cbo_cliente;
        private System.Windows.Forms.ComboBox Cbo_vendedor;
        private System.Windows.Forms.Label Txt_Clienten;
        private System.Windows.Forms.Label Txt_Vendedorn;
        private System.Windows.Forms.Label Txt_idE;
        private System.Windows.Forms.GroupBox Gpb_detalle;
        private System.Windows.Forms.DataGridView Dgv_cotizacion;
        private System.Windows.Forms.NumericUpDown Txt_cantidad;
        private System.Windows.Forms.Label Txt_precion;
        private System.Windows.Forms.TextBox Txt_precio;
        private System.Windows.Forms.Label Txt_cantidadn;
        private System.Windows.Forms.Label Txt_totaln;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.ComboBox Cbo_producto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Txt_producton;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.Label Txt_tipCliente;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_nuevoCE;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.TextBox Txt_ClienteB;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.DateTimePicker Dtp_fechaV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}