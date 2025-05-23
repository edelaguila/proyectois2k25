
namespace Capa_Vista_Cotizacion
{
    partial class Frm_Cotizacion
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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Dgv_cotizacion = new System.Windows.Forms.DataGridView();
            this.Gpb_Detalle = new System.Windows.Forms.GroupBox();
            this.Txt_precion = new System.Windows.Forms.Label();
            this.Txt_precio = new System.Windows.Forms.TextBox();
            this.Lbl_cantidad = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.Cbo_encabezado = new System.Windows.Forms.ComboBox();
            this.Txt_idEfk = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Lbl_IdDetalle = new System.Windows.Forms.TextBox();
            this.Lbl_IdDet = new System.Windows.Forms.Label();
            this.Btn_canceldet = new System.Windows.Forms.Button();
            this.Btn_inserdet = new System.Windows.Forms.Button();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Cbo_producto = new System.Windows.Forms.ComboBox();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_productos = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Gpb_Encabezado = new System.Windows.Forms.GroupBox();
            this.Txt_IdEncabezado = new System.Windows.Forms.TextBox();
            this.Btn_cancelarE = new System.Windows.Forms.Button();
            this.Btn_insertarE = new System.Windows.Forms.Button();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Cbo_cliente = new System.Windows.Forms.ComboBox();
            this.Cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.Lbl_FechaVencimiento = new System.Windows.Forms.Label();
            this.Lbl_Clientes = new System.Windows.Forms.Label();
            this.Lbl_Vendedor = new System.Windows.Forms.Label();
            this.Lbl_IDe = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cotizacion)).BeginInit();
            this.Gpb_Detalle.SuspendLayout();
            this.Gpb_Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(301, 8);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(135, 29);
            this.Lbl_titulo.TabIndex = 27;
            this.Lbl_titulo.Text = "Cotizacion";
            // 
            // Dgv_cotizacion
            // 
            this.Dgv_cotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cotizacion.Location = new System.Drawing.Point(23, 334);
            this.Dgv_cotizacion.Name = "Dgv_cotizacion";
            this.Dgv_cotizacion.RowHeadersWidth = 51;
            this.Dgv_cotizacion.Size = new System.Drawing.Size(735, 132);
            this.Dgv_cotizacion.TabIndex = 26;
            // 
            // Gpb_Detalle
            // 
            this.Gpb_Detalle.Controls.Add(this.Txt_precion);
            this.Gpb_Detalle.Controls.Add(this.Txt_precio);
            this.Gpb_Detalle.Controls.Add(this.Lbl_cantidad);
            this.Gpb_Detalle.Controls.Add(this.Txt_Cantidad);
            this.Gpb_Detalle.Controls.Add(this.Lbl_total);
            this.Gpb_Detalle.Controls.Add(this.Cbo_encabezado);
            this.Gpb_Detalle.Controls.Add(this.Txt_idEfk);
            this.Gpb_Detalle.Controls.Add(this.Txt_Total);
            this.Gpb_Detalle.Controls.Add(this.Lbl_IdDetalle);
            this.Gpb_Detalle.Controls.Add(this.Lbl_IdDet);
            this.Gpb_Detalle.Controls.Add(this.Btn_canceldet);
            this.Gpb_Detalle.Controls.Add(this.Btn_inserdet);
            this.Gpb_Detalle.Controls.Add(this.Txt_descripcion);
            this.Gpb_Detalle.Controls.Add(this.Cbo_producto);
            this.Gpb_Detalle.Controls.Add(this.Lbl_descripcion);
            this.Gpb_Detalle.Controls.Add(this.label6);
            this.Gpb_Detalle.Controls.Add(this.Lbl_productos);
            this.Gpb_Detalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Detalle.Location = new System.Drawing.Point(23, 176);
            this.Gpb_Detalle.Name = "Gpb_Detalle";
            this.Gpb_Detalle.Size = new System.Drawing.Size(735, 152);
            this.Gpb_Detalle.TabIndex = 25;
            this.Gpb_Detalle.TabStop = false;
            this.Gpb_Detalle.Text = "Detalle";
            // 
            // Txt_precion
            // 
            this.Txt_precion.AutoSize = true;
            this.Txt_precion.Location = new System.Drawing.Point(639, 24);
            this.Txt_precion.Name = "Txt_precion";
            this.Txt_precion.Size = new System.Drawing.Size(48, 19);
            this.Txt_precion.TabIndex = 31;
            this.Txt_precion.Text = "Precio";
            // 
            // Txt_precio
            // 
            this.Txt_precio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precio.Location = new System.Drawing.Point(597, 42);
            this.Txt_precio.Name = "Txt_precio";
            this.Txt_precio.Size = new System.Drawing.Size(121, 22);
            this.Txt_precio.TabIndex = 30;
            // 
            // Lbl_cantidad
            // 
            this.Lbl_cantidad.AutoSize = true;
            this.Lbl_cantidad.Location = new System.Drawing.Point(334, 73);
            this.Lbl_cantidad.Name = "Lbl_cantidad";
            this.Lbl_cantidad.Size = new System.Drawing.Size(64, 19);
            this.Lbl_cantidad.TabIndex = 29;
            this.Lbl_cantidad.Text = "Cantidad";
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.Location = new System.Drawing.Point(428, 73);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(121, 22);
            this.Txt_Cantidad.TabIndex = 28;
            // 
            // Lbl_total
            // 
            this.Lbl_total.AutoSize = true;
            this.Lbl_total.Location = new System.Drawing.Point(334, 115);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(39, 19);
            this.Lbl_total.TabIndex = 27;
            this.Lbl_total.Text = "Total";
            // 
            // Cbo_encabezado
            // 
            this.Cbo_encabezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_encabezado.FormattingEnabled = true;
            this.Cbo_encabezado.Location = new System.Drawing.Point(148, 60);
            this.Cbo_encabezado.Name = "Cbo_encabezado";
            this.Cbo_encabezado.Size = new System.Drawing.Size(121, 23);
            this.Cbo_encabezado.TabIndex = 18;
            // 
            // Txt_idEfk
            // 
            this.Txt_idEfk.AutoSize = true;
            this.Txt_idEfk.Location = new System.Drawing.Point(35, 64);
            this.Txt_idEfk.Name = "Txt_idEfk";
            this.Txt_idEfk.Size = new System.Drawing.Size(103, 19);
            this.Txt_idEfk.TabIndex = 17;
            this.Txt_idEfk.Text = "ID Encabezado";
            // 
            // Txt_Total
            // 
            this.Txt_Total.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total.Location = new System.Drawing.Point(428, 115);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(121, 22);
            this.Txt_Total.TabIndex = 26;
            // 
            // Lbl_IdDetalle
            // 
            this.Lbl_IdDetalle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdDetalle.Location = new System.Drawing.Point(148, 25);
            this.Lbl_IdDetalle.Name = "Lbl_IdDetalle";
            this.Lbl_IdDetalle.Size = new System.Drawing.Size(121, 22);
            this.Lbl_IdDetalle.TabIndex = 11;
            // 
            // Lbl_IdDet
            // 
            this.Lbl_IdDet.AutoSize = true;
            this.Lbl_IdDet.Location = new System.Drawing.Point(35, 24);
            this.Lbl_IdDet.Name = "Lbl_IdDet";
            this.Lbl_IdDet.Size = new System.Drawing.Size(25, 19);
            this.Lbl_IdDet.TabIndex = 10;
            this.Lbl_IdDet.Text = "ID";
            this.Lbl_IdDet.Click += new System.EventHandler(this.Lbl_IdDet_Click);
            // 
            // Btn_canceldet
            // 
            this.Btn_canceldet.Location = new System.Drawing.Point(654, 115);
            this.Btn_canceldet.Name = "Btn_canceldet";
            this.Btn_canceldet.Size = new System.Drawing.Size(75, 23);
            this.Btn_canceldet.TabIndex = 11;
            this.Btn_canceldet.Text = "Cancelar";
            this.Btn_canceldet.UseVisualStyleBackColor = true;
            // 
            // Btn_inserdet
            // 
            this.Btn_inserdet.Location = new System.Drawing.Point(573, 115);
            this.Btn_inserdet.Name = "Btn_inserdet";
            this.Btn_inserdet.Size = new System.Drawing.Size(75, 23);
            this.Btn_inserdet.TabIndex = 10;
            this.Btn_inserdet.Text = "Insertar";
            this.Btn_inserdet.UseVisualStyleBackColor = true;
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcion.Location = new System.Drawing.Point(148, 99);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(121, 22);
            this.Txt_descripcion.TabIndex = 10;
            // 
            // Cbo_producto
            // 
            this.Cbo_producto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_producto.FormattingEnabled = true;
            this.Cbo_producto.Location = new System.Drawing.Point(428, 32);
            this.Cbo_producto.Name = "Cbo_producto";
            this.Cbo_producto.Size = new System.Drawing.Size(121, 23);
            this.Cbo_producto.TabIndex = 10;
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Location = new System.Drawing.Point(35, 99);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(81, 19);
            this.Lbl_descripcion.TabIndex = 11;
            this.Lbl_descripcion.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 10;
            // 
            // Lbl_productos
            // 
            this.Lbl_productos.AutoSize = true;
            this.Lbl_productos.Location = new System.Drawing.Point(334, 32);
            this.Lbl_productos.Name = "Lbl_productos";
            this.Lbl_productos.Size = new System.Drawing.Size(65, 19);
            this.Lbl_productos.TabIndex = 9;
            this.Lbl_productos.Text = "Producto";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(451, 259);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 29;
            // 
            // Gpb_Encabezado
            // 
            this.Gpb_Encabezado.Controls.Add(this.Txt_IdEncabezado);
            this.Gpb_Encabezado.Controls.Add(this.Btn_cancelarE);
            this.Gpb_Encabezado.Controls.Add(this.Btn_insertarE);
            this.Gpb_Encabezado.Controls.Add(this.Dtp_fecha);
            this.Gpb_Encabezado.Controls.Add(this.Cbo_cliente);
            this.Gpb_Encabezado.Controls.Add(this.Cbo_vendedor);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_FechaVencimiento);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_Clientes);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_Vendedor);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_IDe);
            this.Gpb_Encabezado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Encabezado.Location = new System.Drawing.Point(23, 40);
            this.Gpb_Encabezado.Name = "Gpb_Encabezado";
            this.Gpb_Encabezado.Size = new System.Drawing.Size(735, 130);
            this.Gpb_Encabezado.TabIndex = 24;
            this.Gpb_Encabezado.TabStop = false;
            this.Gpb_Encabezado.Text = "Encabezado";
            // 
            // Txt_IdEncabezado
            // 
            this.Txt_IdEncabezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdEncabezado.Location = new System.Drawing.Point(103, 31);
            this.Txt_IdEncabezado.Name = "Txt_IdEncabezado";
            this.Txt_IdEncabezado.Size = new System.Drawing.Size(121, 22);
            this.Txt_IdEncabezado.TabIndex = 9;
            // 
            // Btn_cancelarE
            // 
            this.Btn_cancelarE.Location = new System.Drawing.Point(613, 72);
            this.Btn_cancelarE.Name = "Btn_cancelarE";
            this.Btn_cancelarE.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelarE.TabIndex = 8;
            this.Btn_cancelarE.Text = "Cancelar";
            this.Btn_cancelarE.UseVisualStyleBackColor = true;
            // 
            // Btn_insertarE
            // 
            this.Btn_insertarE.Location = new System.Drawing.Point(613, 31);
            this.Btn_insertarE.Name = "Btn_insertarE";
            this.Btn_insertarE.Size = new System.Drawing.Size(75, 23);
            this.Btn_insertarE.TabIndex = 7;
            this.Btn_insertarE.Text = "Insertar";
            this.Btn_insertarE.UseVisualStyleBackColor = true;
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha.Location = new System.Drawing.Point(335, 60);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fecha.TabIndex = 6;
            // 
            // Cbo_cliente
            // 
            this.Cbo_cliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cliente.FormattingEnabled = true;
            this.Cbo_cliente.Location = new System.Drawing.Point(103, 91);
            this.Cbo_cliente.Name = "Cbo_cliente";
            this.Cbo_cliente.Size = new System.Drawing.Size(121, 23);
            this.Cbo_cliente.TabIndex = 5;
            // 
            // Cbo_vendedor
            // 
            this.Cbo_vendedor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_vendedor.FormattingEnabled = true;
            this.Cbo_vendedor.Location = new System.Drawing.Point(103, 59);
            this.Cbo_vendedor.Name = "Cbo_vendedor";
            this.Cbo_vendedor.Size = new System.Drawing.Size(121, 23);
            this.Cbo_vendedor.TabIndex = 4;
            // 
            // Lbl_FechaVencimiento
            // 
            this.Lbl_FechaVencimiento.AutoSize = true;
            this.Lbl_FechaVencimiento.Location = new System.Drawing.Point(370, 31);
            this.Lbl_FechaVencimiento.Name = "Lbl_FechaVencimiento";
            this.Lbl_FechaVencimiento.Size = new System.Drawing.Size(123, 19);
            this.Lbl_FechaVencimiento.TabIndex = 3;
            this.Lbl_FechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // Lbl_Clientes
            // 
            this.Lbl_Clientes.AutoSize = true;
            this.Lbl_Clientes.Location = new System.Drawing.Point(29, 94);
            this.Lbl_Clientes.Name = "Lbl_Clientes";
            this.Lbl_Clientes.Size = new System.Drawing.Size(51, 19);
            this.Lbl_Clientes.TabIndex = 2;
            this.Lbl_Clientes.Text = "Cliente";
            // 
            // Lbl_Vendedor
            // 
            this.Lbl_Vendedor.AutoSize = true;
            this.Lbl_Vendedor.Location = new System.Drawing.Point(29, 59);
            this.Lbl_Vendedor.Name = "Lbl_Vendedor";
            this.Lbl_Vendedor.Size = new System.Drawing.Size(68, 19);
            this.Lbl_Vendedor.TabIndex = 1;
            this.Lbl_Vendedor.Text = "Vendedor";
            // 
            // Lbl_IDe
            // 
            this.Lbl_IDe.AutoSize = true;
            this.Lbl_IDe.Location = new System.Drawing.Point(29, 31);
            this.Lbl_IDe.Name = "Lbl_IDe";
            this.Lbl_IDe.Size = new System.Drawing.Size(25, 19);
            this.Lbl_IDe.TabIndex = 0;
            this.Lbl_IDe.Text = "ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(356, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Subtotal";
            // 
            // Frm_Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(780, 478);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.Dgv_cotizacion);
            this.Controls.Add(this.Gpb_Detalle);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Gpb_Encabezado);
            this.Controls.Add(this.label14);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Cotizacion";
            this.Text = "Frm_Cotizacion";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cotizacion)).EndInit();
            this.Gpb_Detalle.ResumeLayout(false);
            this.Gpb_Detalle.PerformLayout();
            this.Gpb_Encabezado.ResumeLayout(false);
            this.Gpb_Encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.DataGridView Dgv_cotizacion;
        private System.Windows.Forms.GroupBox Gpb_Detalle;
        private System.Windows.Forms.Label Txt_precion;
        private System.Windows.Forms.TextBox Txt_precio;
        private System.Windows.Forms.Label Lbl_cantidad;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.ComboBox Cbo_encabezado;
        private System.Windows.Forms.Label Txt_idEfk;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.TextBox Lbl_IdDetalle;
        private System.Windows.Forms.Label Lbl_IdDet;
        private System.Windows.Forms.Button Btn_canceldet;
        private System.Windows.Forms.Button Btn_inserdet;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.ComboBox Cbo_producto;
        private System.Windows.Forms.Label Lbl_descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_productos;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox Gpb_Encabezado;
        private System.Windows.Forms.TextBox Txt_IdEncabezado;
        private System.Windows.Forms.Button Btn_cancelarE;
        private System.Windows.Forms.Button Btn_insertarE;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.ComboBox Cbo_cliente;
        private System.Windows.Forms.ComboBox Cbo_vendedor;
        private System.Windows.Forms.Label Lbl_FechaVencimiento;
        private System.Windows.Forms.Label Lbl_Clientes;
        private System.Windows.Forms.Label Lbl_Vendedor;
        private System.Windows.Forms.Label Lbl_IDe;
        private System.Windows.Forms.Label label14;
    }
}