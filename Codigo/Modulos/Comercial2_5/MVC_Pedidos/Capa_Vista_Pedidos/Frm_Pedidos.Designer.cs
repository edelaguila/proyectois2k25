
namespace Capa_Vista_Tramite
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_idEncezado = new System.Windows.Forms.TextBox();
            this.Btn_cancelarE = new System.Windows.Forms.Button();
            this.Btn_insertarE = new System.Windows.Forms.Button();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Cbo_cliente = new System.Windows.Forms.ComboBox();
            this.Cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.Txt_FechaVencimiento = new System.Windows.Forms.Label();
            this.Txt_Clienten = new System.Windows.Forms.Label();
            this.Txt_Vendedorn = new System.Windows.Forms.Label();
            this.Txt_idE = new System.Windows.Forms.Label();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_insertarD = new System.Windows.Forms.Button();
            this.Btn_cancelarD = new System.Windows.Forms.Button();
            this.Cbo_encabezado = new System.Windows.Forms.ComboBox();
            this.Txt_idEfk = new System.Windows.Forms.Label();
            this.Txt_idDetalle = new System.Windows.Forms.TextBox();
            this.Txt_idD = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.Txt_idCotizacionfk = new System.Windows.Forms.Label();
            this.Txt_precioTn = new System.Windows.Forms.Label();
            this.Txt_precioTotal = new System.Windows.Forms.TextBox();
            this.Txt_subtotal = new System.Windows.Forms.TextBox();
            this.Txt_IVAn = new System.Windows.Forms.Label();
            this.Txt_IVA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_subtotaln = new System.Windows.Forms.Label();
            this.Dgv_pedido = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_idEncezado);
            this.groupBox1.Controls.Add(this.Btn_cancelarE);
            this.groupBox1.Controls.Add(this.Btn_insertarE);
            this.groupBox1.Controls.Add(this.Dtp_fecha);
            this.groupBox1.Controls.Add(this.Cbo_cliente);
            this.groupBox1.Controls.Add(this.Cbo_vendedor);
            this.groupBox1.Controls.Add(this.Txt_FechaVencimiento);
            this.groupBox1.Controls.Add(this.Txt_Clienten);
            this.groupBox1.Controls.Add(this.Txt_Vendedorn);
            this.groupBox1.Controls.Add(this.Txt_idE);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(983, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // Txt_idEncezado
            // 
            this.Txt_idEncezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idEncezado.Location = new System.Drawing.Point(137, 38);
            this.Txt_idEncezado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_idEncezado.Name = "Txt_idEncezado";
            this.Txt_idEncezado.Size = new System.Drawing.Size(160, 26);
            this.Txt_idEncezado.TabIndex = 9;
            // 
            // Btn_cancelarE
            // 
            this.Btn_cancelarE.Location = new System.Drawing.Point(817, 89);
            this.Btn_cancelarE.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cancelarE.Name = "Btn_cancelarE";
            this.Btn_cancelarE.Size = new System.Drawing.Size(100, 28);
            this.Btn_cancelarE.TabIndex = 8;
            this.Btn_cancelarE.Text = "Cancelar";
            this.Btn_cancelarE.UseVisualStyleBackColor = true;
            // 
            // Btn_insertarE
            // 
            this.Btn_insertarE.Location = new System.Drawing.Point(817, 38);
            this.Btn_insertarE.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_insertarE.Name = "Btn_insertarE";
            this.Btn_insertarE.Size = new System.Drawing.Size(100, 28);
            this.Btn_insertarE.TabIndex = 7;
            this.Btn_insertarE.Text = "Insertar";
            this.Btn_insertarE.UseVisualStyleBackColor = true;
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha.Location = new System.Drawing.Point(447, 74);
            this.Dtp_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(265, 26);
            this.Dtp_fecha.TabIndex = 6;
            // 
            // Cbo_cliente
            // 
            this.Cbo_cliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cliente.FormattingEnabled = true;
            this.Cbo_cliente.Location = new System.Drawing.Point(137, 112);
            this.Cbo_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_cliente.Name = "Cbo_cliente";
            this.Cbo_cliente.Size = new System.Drawing.Size(160, 27);
            this.Cbo_cliente.TabIndex = 5;
            // 
            // Cbo_vendedor
            // 
            this.Cbo_vendedor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_vendedor.FormattingEnabled = true;
            this.Cbo_vendedor.Location = new System.Drawing.Point(137, 73);
            this.Cbo_vendedor.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_vendedor.Name = "Cbo_vendedor";
            this.Cbo_vendedor.Size = new System.Drawing.Size(160, 27);
            this.Cbo_vendedor.TabIndex = 4;
            // 
            // Txt_FechaVencimiento
            // 
            this.Txt_FechaVencimiento.AutoSize = true;
            this.Txt_FechaVencimiento.Location = new System.Drawing.Point(493, 38);
            this.Txt_FechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_FechaVencimiento.Name = "Txt_FechaVencimiento";
            this.Txt_FechaVencimiento.Size = new System.Drawing.Size(159, 22);
            this.Txt_FechaVencimiento.TabIndex = 3;
            this.Txt_FechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // Txt_Clienten
            // 
            this.Txt_Clienten.AutoSize = true;
            this.Txt_Clienten.Location = new System.Drawing.Point(39, 116);
            this.Txt_Clienten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Clienten.Name = "Txt_Clienten";
            this.Txt_Clienten.Size = new System.Drawing.Size(67, 22);
            this.Txt_Clienten.TabIndex = 2;
            this.Txt_Clienten.Text = "Cliente";
            // 
            // Txt_Vendedorn
            // 
            this.Txt_Vendedorn.AutoSize = true;
            this.Txt_Vendedorn.Location = new System.Drawing.Point(39, 73);
            this.Txt_Vendedorn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Vendedorn.Name = "Txt_Vendedorn";
            this.Txt_Vendedorn.Size = new System.Drawing.Size(85, 22);
            this.Txt_Vendedorn.TabIndex = 1;
            this.Txt_Vendedorn.Text = "Vendedor";
            // 
            // Txt_idE
            // 
            this.Txt_idE.AutoSize = true;
            this.Txt_idE.Location = new System.Drawing.Point(39, 38);
            this.Txt_idE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_idE.Name = "Txt_idE";
            this.Txt_idE.Size = new System.Drawing.Size(30, 22);
            this.Txt_idE.TabIndex = 0;
            this.Txt_idE.Text = "ID";
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_titulo.Location = new System.Drawing.Point(480, 45);
            this.Txt_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(90, 25);
            this.Txt_titulo.TabIndex = 7;
            this.Txt_titulo.Text = "Pedidos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_insertarD);
            this.groupBox2.Controls.Add(this.Btn_cancelarD);
            this.groupBox2.Controls.Add(this.Cbo_encabezado);
            this.groupBox2.Controls.Add(this.Txt_idEfk);
            this.groupBox2.Controls.Add(this.Txt_idDetalle);
            this.groupBox2.Controls.Add(this.Txt_idD);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.Txt_idCotizacionfk);
            this.groupBox2.Controls.Add(this.Txt_precioTn);
            this.groupBox2.Controls.Add(this.Txt_precioTotal);
            this.groupBox2.Controls.Add(this.Txt_subtotal);
            this.groupBox2.Controls.Add(this.Txt_IVAn);
            this.groupBox2.Controls.Add(this.Txt_IVA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Txt_subtotaln);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(983, 207);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // Btn_insertarD
            // 
            this.Btn_insertarD.Location = new System.Drawing.Point(817, 57);
            this.Btn_insertarD.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_insertarD.Name = "Btn_insertarD";
            this.Btn_insertarD.Size = new System.Drawing.Size(100, 28);
            this.Btn_insertarD.TabIndex = 26;
            this.Btn_insertarD.Text = "Insertar";
            this.Btn_insertarD.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelarD
            // 
            this.Btn_cancelarD.Location = new System.Drawing.Point(817, 129);
            this.Btn_cancelarD.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cancelarD.Name = "Btn_cancelarD";
            this.Btn_cancelarD.Size = new System.Drawing.Size(100, 28);
            this.Btn_cancelarD.TabIndex = 27;
            this.Btn_cancelarD.Text = "Cancelar";
            this.Btn_cancelarD.UseVisualStyleBackColor = true;
            // 
            // Cbo_encabezado
            // 
            this.Cbo_encabezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_encabezado.FormattingEnabled = true;
            this.Cbo_encabezado.Location = new System.Drawing.Point(187, 96);
            this.Cbo_encabezado.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_encabezado.Name = "Cbo_encabezado";
            this.Cbo_encabezado.Size = new System.Drawing.Size(160, 27);
            this.Cbo_encabezado.TabIndex = 25;
            // 
            // Txt_idEfk
            // 
            this.Txt_idEfk.AutoSize = true;
            this.Txt_idEfk.Location = new System.Drawing.Point(57, 105);
            this.Txt_idEfk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_idEfk.Name = "Txt_idEfk";
            this.Txt_idEfk.Size = new System.Drawing.Size(130, 22);
            this.Txt_idEfk.TabIndex = 24;
            this.Txt_idEfk.Text = "ID Encabezado";
            // 
            // Txt_idDetalle
            // 
            this.Txt_idDetalle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idDetalle.Location = new System.Drawing.Point(187, 53);
            this.Txt_idDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_idDetalle.Name = "Txt_idDetalle";
            this.Txt_idDetalle.Size = new System.Drawing.Size(160, 26);
            this.Txt_idDetalle.TabIndex = 23;
            // 
            // Txt_idD
            // 
            this.Txt_idD.AutoSize = true;
            this.Txt_idD.Location = new System.Drawing.Point(57, 52);
            this.Txt_idD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_idD.Name = "Txt_idD";
            this.Txt_idD.Size = new System.Drawing.Size(30, 22);
            this.Txt_idD.TabIndex = 22;
            this.Txt_idD.Text = "ID";
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(184, 137);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(160, 27);
            this.comboBox5.TabIndex = 20;
            // 
            // Txt_idCotizacionfk
            // 
            this.Txt_idCotizacionfk.AutoSize = true;
            this.Txt_idCotizacionfk.Location = new System.Drawing.Point(57, 140);
            this.Txt_idCotizacionfk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_idCotizacionfk.Name = "Txt_idCotizacionfk";
            this.Txt_idCotizacionfk.Size = new System.Drawing.Size(120, 22);
            this.Txt_idCotizacionfk.TabIndex = 19;
            this.Txt_idCotizacionfk.Text = "ID Cotización";
            // 
            // Txt_precioTn
            // 
            this.Txt_precioTn.AutoSize = true;
            this.Txt_precioTn.Location = new System.Drawing.Point(452, 132);
            this.Txt_precioTn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_precioTn.Name = "Txt_precioTn";
            this.Txt_precioTn.Size = new System.Drawing.Size(108, 22);
            this.Txt_precioTn.TabIndex = 21;
            this.Txt_precioTn.Text = "Precio Total";
            // 
            // Txt_precioTotal
            // 
            this.Txt_precioTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precioTotal.Location = new System.Drawing.Point(577, 132);
            this.Txt_precioTotal.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_precioTotal.Name = "Txt_precioTotal";
            this.Txt_precioTotal.Size = new System.Drawing.Size(160, 26);
            this.Txt_precioTotal.TabIndex = 20;
            // 
            // Txt_subtotal
            // 
            this.Txt_subtotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_subtotal.Location = new System.Drawing.Point(577, 48);
            this.Txt_subtotal.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_subtotal.Name = "Txt_subtotal";
            this.Txt_subtotal.Size = new System.Drawing.Size(160, 26);
            this.Txt_subtotal.TabIndex = 19;
            // 
            // Txt_IVAn
            // 
            this.Txt_IVAn.AutoSize = true;
            this.Txt_IVAn.Location = new System.Drawing.Point(451, 96);
            this.Txt_IVAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_IVAn.Name = "Txt_IVAn";
            this.Txt_IVAn.Size = new System.Drawing.Size(40, 22);
            this.Txt_IVAn.TabIndex = 16;
            this.Txt_IVAn.Text = "IVA";
            // 
            // Txt_IVA
            // 
            this.Txt_IVA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IVA.Location = new System.Drawing.Point(577, 87);
            this.Txt_IVA.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_IVA.Name = "Txt_IVA";
            this.Txt_IVA.Size = new System.Drawing.Size(163, 26);
            this.Txt_IVA.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 22);
            this.label6.TabIndex = 10;
            // 
            // Txt_subtotaln
            // 
            this.Txt_subtotaln.AutoSize = true;
            this.Txt_subtotaln.Location = new System.Drawing.Point(451, 57);
            this.Txt_subtotaln.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_subtotaln.Name = "Txt_subtotaln";
            this.Txt_subtotaln.Size = new System.Drawing.Size(75, 22);
            this.Txt_subtotaln.TabIndex = 9;
            this.Txt_subtotaln.Text = "Subtotal";
            // 
            // Dgv_pedido
            // 
            this.Dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_pedido.Location = new System.Drawing.Point(40, 440);
            this.Dgv_pedido.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_pedido.Name = "Dgv_pedido";
            this.Dgv_pedido.RowHeadersWidth = 51;
            this.Dgv_pedido.Size = new System.Drawing.Size(983, 160);
            this.Dgv_pedido.TabIndex = 10;
            // 
            // Frm_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1103, 634);
            this.Controls.Add(this.Dgv_pedido);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt_titulo);
            this.Name = "Frm_Pedidos";
            this.Text = "Frm_Pedidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_idEncezado;
        private System.Windows.Forms.Button Btn_cancelarE;
        private System.Windows.Forms.Button Btn_insertarE;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.ComboBox Cbo_cliente;
        private System.Windows.Forms.ComboBox Cbo_vendedor;
        private System.Windows.Forms.Label Txt_FechaVencimiento;
        private System.Windows.Forms.Label Txt_Clienten;
        private System.Windows.Forms.Label Txt_Vendedorn;
        private System.Windows.Forms.Label Txt_idE;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_insertarD;
        private System.Windows.Forms.Button Btn_cancelarD;
        private System.Windows.Forms.ComboBox Cbo_encabezado;
        private System.Windows.Forms.Label Txt_idEfk;
        private System.Windows.Forms.TextBox Txt_idDetalle;
        private System.Windows.Forms.Label Txt_idD;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label Txt_idCotizacionfk;
        private System.Windows.Forms.Label Txt_precioTn;
        private System.Windows.Forms.TextBox Txt_precioTotal;
        private System.Windows.Forms.TextBox Txt_subtotal;
        private System.Windows.Forms.Label Txt_IVAn;
        private System.Windows.Forms.TextBox Txt_IVA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Txt_subtotaln;
        private System.Windows.Forms.DataGridView Dgv_pedido;
    }
}