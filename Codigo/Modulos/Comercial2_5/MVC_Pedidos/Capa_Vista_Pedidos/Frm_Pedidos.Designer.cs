
namespace Capa_Vista_Pedidos
{
    partial class Frm_Pedidos
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
            this.Gpb_Encabezado = new System.Windows.Forms.GroupBox();
            this.Txt_IdEncabezado = new System.Windows.Forms.TextBox();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_insertar = new System.Windows.Forms.Button();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Cbo_cliente = new System.Windows.Forms.ComboBox();
            this.Cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.Lbl_FechaVencimiento = new System.Windows.Forms.Label();
            this.Lbl_Clientes = new System.Windows.Forms.Label();
            this.Lbl_Vendedor = new System.Windows.Forms.Label();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Gpb_Detalle = new System.Windows.Forms.GroupBox();
            this.Btn_insertarD = new System.Windows.Forms.Button();
            this.Btn_cancelarD = new System.Windows.Forms.Button();
            this.Cbo_encabezado = new System.Windows.Forms.ComboBox();
            this.Lbl_IdEncab = new System.Windows.Forms.Label();
            this.Txt_IDdetalle = new System.Windows.Forms.TextBox();
            this.Lbl_IdDet = new System.Windows.Forms.Label();
            this.Cbo_Cotizacion = new System.Windows.Forms.ComboBox();
            this.Lbl_IdCoti = new System.Windows.Forms.Label();
            this.Lbl_precioTot = new System.Windows.Forms.Label();
            this.Txt_precioTotal = new System.Windows.Forms.TextBox();
            this.Txt_subtotal = new System.Windows.Forms.TextBox();
            this.Lbl_IVA = new System.Windows.Forms.Label();
            this.Txt_IVA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_subtot = new System.Windows.Forms.Label();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Dgv_pedido = new System.Windows.Forms.DataGridView();
            this.Gpb_Encabezado.SuspendLayout();
            this.Gpb_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_Encabezado
            // 
            this.Gpb_Encabezado.Controls.Add(this.Txt_IdEncabezado);
            this.Gpb_Encabezado.Controls.Add(this.Btn_cancelar);
            this.Gpb_Encabezado.Controls.Add(this.Btn_insertar);
            this.Gpb_Encabezado.Controls.Add(this.Dtp_fecha);
            this.Gpb_Encabezado.Controls.Add(this.Cbo_cliente);
            this.Gpb_Encabezado.Controls.Add(this.Cbo_vendedor);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_FechaVencimiento);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_Clientes);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_Vendedor);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_ID);
            this.Gpb_Encabezado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Encabezado.Location = new System.Drawing.Point(22, 38);
            this.Gpb_Encabezado.Name = "Gpb_Encabezado";
            this.Gpb_Encabezado.Size = new System.Drawing.Size(735, 119);
            this.Gpb_Encabezado.TabIndex = 10;
            this.Gpb_Encabezado.TabStop = false;
            this.Gpb_Encabezado.Text = "Encabezado";
            // 
            // Txt_IdEncabezado
            // 
            this.Txt_IdEncabezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdEncabezado.Location = new System.Drawing.Point(103, 28);
            this.Txt_IdEncabezado.Name = "Txt_IdEncabezado";
            this.Txt_IdEncabezado.Size = new System.Drawing.Size(121, 22);
            this.Txt_IdEncabezado.TabIndex = 9;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(613, 72);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 8;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_insertar
            // 
            this.Btn_insertar.Location = new System.Drawing.Point(613, 31);
            this.Btn_insertar.Name = "Btn_insertar";
            this.Btn_insertar.Size = new System.Drawing.Size(75, 23);
            this.Btn_insertar.TabIndex = 7;
            this.Btn_insertar.Text = "Insertar";
            this.Btn_insertar.UseVisualStyleBackColor = true;
            this.Btn_insertar.Click += new System.EventHandler(this.Btn_insertar_Click);
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
            this.Lbl_Vendedor.Location = new System.Drawing.Point(29, 63);
            this.Lbl_Vendedor.Name = "Lbl_Vendedor";
            this.Lbl_Vendedor.Size = new System.Drawing.Size(68, 19);
            this.Lbl_Vendedor.TabIndex = 1;
            this.Lbl_Vendedor.Text = "Vendedor";
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(35, 28);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(25, 19);
            this.Lbl_ID.TabIndex = 0;
            this.Lbl_ID.Text = "ID";
            // 
            // Gpb_Detalle
            // 
            this.Gpb_Detalle.Controls.Add(this.Btn_insertarD);
            this.Gpb_Detalle.Controls.Add(this.Btn_cancelarD);
            this.Gpb_Detalle.Controls.Add(this.Cbo_encabezado);
            this.Gpb_Detalle.Controls.Add(this.Lbl_IdEncab);
            this.Gpb_Detalle.Controls.Add(this.Txt_IDdetalle);
            this.Gpb_Detalle.Controls.Add(this.Lbl_IdDet);
            this.Gpb_Detalle.Controls.Add(this.Cbo_Cotizacion);
            this.Gpb_Detalle.Controls.Add(this.Lbl_IdCoti);
            this.Gpb_Detalle.Controls.Add(this.Lbl_precioTot);
            this.Gpb_Detalle.Controls.Add(this.Txt_precioTotal);
            this.Gpb_Detalle.Controls.Add(this.Txt_subtotal);
            this.Gpb_Detalle.Controls.Add(this.Lbl_IVA);
            this.Gpb_Detalle.Controls.Add(this.Txt_IVA);
            this.Gpb_Detalle.Controls.Add(this.label6);
            this.Gpb_Detalle.Controls.Add(this.Lbl_subtot);
            this.Gpb_Detalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Detalle.Location = new System.Drawing.Point(22, 163);
            this.Gpb_Detalle.Name = "Gpb_Detalle";
            this.Gpb_Detalle.Size = new System.Drawing.Size(735, 170);
            this.Gpb_Detalle.TabIndex = 9;
            this.Gpb_Detalle.TabStop = false;
            this.Gpb_Detalle.Text = "Detalle";
            // 
            // Btn_insertarD
            // 
            this.Btn_insertarD.Location = new System.Drawing.Point(613, 46);
            this.Btn_insertarD.Name = "Btn_insertarD";
            this.Btn_insertarD.Size = new System.Drawing.Size(75, 23);
            this.Btn_insertarD.TabIndex = 26;
            this.Btn_insertarD.Text = "Insertar";
            this.Btn_insertarD.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelarD
            // 
            this.Btn_cancelarD.Location = new System.Drawing.Point(613, 105);
            this.Btn_cancelarD.Name = "Btn_cancelarD";
            this.Btn_cancelarD.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelarD.TabIndex = 27;
            this.Btn_cancelarD.Text = "Cancelar";
            this.Btn_cancelarD.UseVisualStyleBackColor = true;
            // 
            // Cbo_encabezado
            // 
            this.Cbo_encabezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_encabezado.FormattingEnabled = true;
            this.Cbo_encabezado.Location = new System.Drawing.Point(140, 78);
            this.Cbo_encabezado.Name = "Cbo_encabezado";
            this.Cbo_encabezado.Size = new System.Drawing.Size(121, 23);
            this.Cbo_encabezado.TabIndex = 25;
            // 
            // Lbl_IdEncab
            // 
            this.Lbl_IdEncab.AutoSize = true;
            this.Lbl_IdEncab.Location = new System.Drawing.Point(35, 82);
            this.Lbl_IdEncab.Name = "Lbl_IdEncab";
            this.Lbl_IdEncab.Size = new System.Drawing.Size(103, 19);
            this.Lbl_IdEncab.TabIndex = 24;
            this.Lbl_IdEncab.Text = "ID Encabezado";
            // 
            // Txt_IDdetalle
            // 
            this.Txt_IDdetalle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IDdetalle.Location = new System.Drawing.Point(140, 43);
            this.Txt_IDdetalle.Name = "Txt_IDdetalle";
            this.Txt_IDdetalle.Size = new System.Drawing.Size(121, 22);
            this.Txt_IDdetalle.TabIndex = 23;
            // 
            // Lbl_IdDet
            // 
            this.Lbl_IdDet.AutoSize = true;
            this.Lbl_IdDet.Location = new System.Drawing.Point(35, 46);
            this.Lbl_IdDet.Name = "Lbl_IdDet";
            this.Lbl_IdDet.Size = new System.Drawing.Size(25, 19);
            this.Lbl_IdDet.TabIndex = 22;
            this.Lbl_IdDet.Text = "ID";
            // 
            // Cbo_Cotizacion
            // 
            this.Cbo_Cotizacion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Cotizacion.FormattingEnabled = true;
            this.Cbo_Cotizacion.Location = new System.Drawing.Point(138, 111);
            this.Cbo_Cotizacion.Name = "Cbo_Cotizacion";
            this.Cbo_Cotizacion.Size = new System.Drawing.Size(121, 23);
            this.Cbo_Cotizacion.TabIndex = 20;
            // 
            // Lbl_IdCoti
            // 
            this.Lbl_IdCoti.AutoSize = true;
            this.Lbl_IdCoti.Location = new System.Drawing.Point(35, 112);
            this.Lbl_IdCoti.Name = "Lbl_IdCoti";
            this.Lbl_IdCoti.Size = new System.Drawing.Size(93, 19);
            this.Lbl_IdCoti.TabIndex = 19;
            this.Lbl_IdCoti.Text = "ID Cotización";
            // 
            // Lbl_precioTot
            // 
            this.Lbl_precioTot.AutoSize = true;
            this.Lbl_precioTot.Location = new System.Drawing.Point(339, 107);
            this.Lbl_precioTot.Name = "Lbl_precioTot";
            this.Lbl_precioTot.Size = new System.Drawing.Size(82, 19);
            this.Lbl_precioTot.TabIndex = 21;
            this.Lbl_precioTot.Text = "Precio Total";
            // 
            // Txt_precioTotal
            // 
            this.Txt_precioTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precioTotal.Location = new System.Drawing.Point(433, 107);
            this.Txt_precioTotal.Name = "Txt_precioTotal";
            this.Txt_precioTotal.Size = new System.Drawing.Size(121, 22);
            this.Txt_precioTotal.TabIndex = 20;
            // 
            // Txt_subtotal
            // 
            this.Txt_subtotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_subtotal.Location = new System.Drawing.Point(433, 39);
            this.Txt_subtotal.Name = "Txt_subtotal";
            this.Txt_subtotal.Size = new System.Drawing.Size(121, 22);
            this.Txt_subtotal.TabIndex = 19;
            // 
            // Lbl_IVA
            // 
            this.Lbl_IVA.AutoSize = true;
            this.Lbl_IVA.Location = new System.Drawing.Point(338, 78);
            this.Lbl_IVA.Name = "Lbl_IVA";
            this.Lbl_IVA.Size = new System.Drawing.Size(34, 19);
            this.Lbl_IVA.TabIndex = 16;
            this.Lbl_IVA.Text = "IVA";
            // 
            // Txt_IVA
            // 
            this.Txt_IVA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IVA.Location = new System.Drawing.Point(433, 71);
            this.Txt_IVA.Name = "Txt_IVA";
            this.Txt_IVA.Size = new System.Drawing.Size(121, 22);
            this.Txt_IVA.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 10;
            // 
            // Lbl_subtot
            // 
            this.Lbl_subtot.AutoSize = true;
            this.Lbl_subtot.Location = new System.Drawing.Point(338, 46);
            this.Lbl_subtot.Name = "Lbl_subtot";
            this.Lbl_subtot.Size = new System.Drawing.Size(59, 19);
            this.Lbl_subtot.TabIndex = 9;
            this.Lbl_subtot.Text = "Subtotal";
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(309, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(110, 29);
            this.Lbl_titulo.TabIndex = 8;
            this.Lbl_titulo.Text = "Pedidos";
            // 
            // Dgv_pedido
            // 
            this.Dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_pedido.Location = new System.Drawing.Point(22, 349);
            this.Dgv_pedido.Name = "Dgv_pedido";
            this.Dgv_pedido.RowHeadersWidth = 51;
            this.Dgv_pedido.Size = new System.Drawing.Size(735, 132);
            this.Dgv_pedido.TabIndex = 7;
            // 
            // Frm_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(819, 498);
            this.Controls.Add(this.Gpb_Encabezado);
            this.Controls.Add(this.Gpb_Detalle);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.Dgv_pedido);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Pedidos";
            this.Text = "Frm_Pedidos";
            this.Load += new System.EventHandler(this.Frm_Pedidos_Load);
            this.Gpb_Encabezado.ResumeLayout(false);
            this.Gpb_Encabezado.PerformLayout();
            this.Gpb_Detalle.ResumeLayout(false);
            this.Gpb_Detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Encabezado;
        private System.Windows.Forms.TextBox Txt_IdEncabezado;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_insertar;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.ComboBox Cbo_cliente;
        private System.Windows.Forms.ComboBox Cbo_vendedor;
        private System.Windows.Forms.Label Lbl_FechaVencimiento;
        private System.Windows.Forms.Label Lbl_Clientes;
        private System.Windows.Forms.Label Lbl_Vendedor;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.GroupBox Gpb_Detalle;
        private System.Windows.Forms.Button Btn_insertarD;
        private System.Windows.Forms.Button Btn_cancelarD;
        private System.Windows.Forms.ComboBox Cbo_encabezado;
        private System.Windows.Forms.Label Lbl_IdEncab;
        private System.Windows.Forms.TextBox Txt_IDdetalle;
        private System.Windows.Forms.Label Lbl_IdDet;
        private System.Windows.Forms.ComboBox Cbo_Cotizacion;
        private System.Windows.Forms.Label Lbl_IdCoti;
        private System.Windows.Forms.Label Lbl_precioTot;
        private System.Windows.Forms.TextBox Txt_precioTotal;
        private System.Windows.Forms.TextBox Txt_subtotal;
        private System.Windows.Forms.Label Lbl_IVA;
        private System.Windows.Forms.TextBox Txt_IVA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_subtot;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.DataGridView Dgv_pedido;
    }
}