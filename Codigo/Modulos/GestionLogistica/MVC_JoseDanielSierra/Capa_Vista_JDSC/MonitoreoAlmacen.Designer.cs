
namespace Capa_Vista_JDSC
{
    partial class MonitoreoAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoreoAlmacen));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.chkDiscrepanciaDetectada = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaAuditoria = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtCantidadFisica = new System.Windows.Forms.TextBox();
            this.txtCantidadRegistrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProductoAuditoria = new System.Windows.Forms.ComboBox();
            this.btnRealizarAuditoria = new System.Windows.Forms.Button();
            this.dgvAuditorias = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBodegaAuditoria = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lbl_Producto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.btnCargarExistencias = new System.Windows.Forms.Button();
            this.dgvExistencias = new System.Windows.Forms.DataGridView();
            this.Lbl_Bodega = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_ayudaAlmacen = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditorias)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGenerarReporte);
            this.groupBox3.Controls.Add(this.chkDiscrepanciaDetectada);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtpFechaAuditoria);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtObservaciones);
            this.groupBox3.Controls.Add(this.txtCantidadFisica);
            this.groupBox3.Controls.Add(this.txtCantidadRegistrada);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbProductoAuditoria);
            this.groupBox3.Controls.Add(this.btnRealizarAuditoria);
            this.groupBox3.Controls.Add(this.dgvAuditorias);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbBodegaAuditoria);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(643, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 484);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auditoria de Existencias";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.FlatAppearance.BorderSize = 0;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarReporte.Image")));
            this.btnGenerarReporte.Location = new System.Drawing.Point(540, 91);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(73, 71);
            this.btnGenerarReporte.TabIndex = 25;
            this.toolTip3.SetToolTip(this.btnGenerarReporte, "Generar Reporte");
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // chkDiscrepanciaDetectada
            // 
            this.chkDiscrepanciaDetectada.AutoSize = true;
            this.chkDiscrepanciaDetectada.Location = new System.Drawing.Point(319, 107);
            this.chkDiscrepanciaDetectada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDiscrepanciaDetectada.Name = "chkDiscrepanciaDetectada";
            this.chkDiscrepanciaDetectada.Size = new System.Drawing.Size(169, 23);
            this.chkDiscrepanciaDetectada.TabIndex = 24;
            this.chkDiscrepanciaDetectada.Text = "Discrepancia detectada";
            this.chkDiscrepanciaDetectada.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cantidad Física";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cantidad Registrada:";
            // 
            // dtpFechaAuditoria
            // 
            this.dtpFechaAuditoria.Location = new System.Drawing.Point(152, 34);
            this.dtpFechaAuditoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaAuditoria.Name = "dtpFechaAuditoria";
            this.dtpFechaAuditoria.Size = new System.Drawing.Size(159, 26);
            this.dtpFechaAuditoria.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha de Auditoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(139, 146);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(337, 26);
            this.txtObservaciones.TabIndex = 18;
            // 
            // txtCantidadFisica
            // 
            this.txtCantidadFisica.Location = new System.Drawing.Point(468, 70);
            this.txtCantidadFisica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidadFisica.Name = "txtCantidadFisica";
            this.txtCantidadFisica.Size = new System.Drawing.Size(61, 26);
            this.txtCantidadFisica.TabIndex = 17;
            // 
            // txtCantidadRegistrada
            // 
            this.txtCantidadRegistrada.Location = new System.Drawing.Point(468, 32);
            this.txtCantidadRegistrada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidadRegistrada.Name = "txtCantidadRegistrada";
            this.txtCantidadRegistrada.Size = new System.Drawing.Size(61, 26);
            this.txtCantidadRegistrada.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Producto";
            // 
            // cmbProductoAuditoria
            // 
            this.cmbProductoAuditoria.FormattingEnabled = true;
            this.cmbProductoAuditoria.Location = new System.Drawing.Point(139, 106);
            this.cmbProductoAuditoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProductoAuditoria.Name = "cmbProductoAuditoria";
            this.cmbProductoAuditoria.Size = new System.Drawing.Size(135, 27);
            this.cmbProductoAuditoria.TabIndex = 10;
            // 
            // btnRealizarAuditoria
            // 
            this.btnRealizarAuditoria.FlatAppearance.BorderSize = 0;
            this.btnRealizarAuditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarAuditoria.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizarAuditoria.Image")));
            this.btnRealizarAuditoria.Location = new System.Drawing.Point(539, 11);
            this.btnRealizarAuditoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRealizarAuditoria.Name = "btnRealizarAuditoria";
            this.btnRealizarAuditoria.Size = new System.Drawing.Size(73, 70);
            this.btnRealizarAuditoria.TabIndex = 15;
            this.toolTip2.SetToolTip(this.btnRealizarAuditoria, "Guardar");
            this.btnRealizarAuditoria.UseVisualStyleBackColor = false;
            this.btnRealizarAuditoria.Click += new System.EventHandler(this.btnRealizarAuditoria_Click);
            // 
            // dgvAuditorias
            // 
            this.dgvAuditorias.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAuditorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditorias.Location = new System.Drawing.Point(33, 191);
            this.dgvAuditorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAuditorias.Name = "dgvAuditorias";
            this.dgvAuditorias.RowHeadersWidth = 62;
            this.dgvAuditorias.RowTemplate.Height = 28;
            this.dgvAuditorias.Size = new System.Drawing.Size(557, 275);
            this.dgvAuditorias.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bodega:";
            // 
            // cmbBodegaAuditoria
            // 
            this.cmbBodegaAuditoria.FormattingEnabled = true;
            this.cmbBodegaAuditoria.Location = new System.Drawing.Point(139, 70);
            this.cmbBodegaAuditoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBodegaAuditoria.Name = "cmbBodegaAuditoria";
            this.cmbBodegaAuditoria.Size = new System.Drawing.Size(135, 27);
            this.cmbBodegaAuditoria.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lbl_Producto);
            this.groupBox2.Controls.Add(this.cmbProducto);
            this.groupBox2.Controls.Add(this.btnCargarExistencias);
            this.groupBox2.Controls.Add(this.dgvExistencias);
            this.groupBox2.Controls.Add(this.Lbl_Bodega);
            this.groupBox2.Controls.Add(this.cmbBodega);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 484);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Existencias en Bodega";
            // 
            // Lbl_Producto
            // 
            this.Lbl_Producto.AutoSize = true;
            this.Lbl_Producto.Location = new System.Drawing.Point(110, 116);
            this.Lbl_Producto.Name = "Lbl_Producto";
            this.Lbl_Producto.Size = new System.Drawing.Size(65, 19);
            this.Lbl_Producto.TabIndex = 9;
            this.Lbl_Producto.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(210, 116);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(127, 27);
            this.cmbProducto.TabIndex = 10;
            // 
            // btnCargarExistencias
            // 
            this.btnCargarExistencias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarExistencias.FlatAppearance.BorderSize = 0;
            this.btnCargarExistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarExistencias.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarExistencias.Image")));
            this.btnCargarExistencias.Location = new System.Drawing.Point(359, 75);
            this.btnCargarExistencias.Margin = new System.Windows.Forms.Padding(0);
            this.btnCargarExistencias.Name = "btnCargarExistencias";
            this.btnCargarExistencias.Size = new System.Drawing.Size(78, 75);
            this.btnCargarExistencias.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnCargarExistencias, "Buscar");
            this.btnCargarExistencias.UseVisualStyleBackColor = false;
            this.btnCargarExistencias.Click += new System.EventHandler(this.btnCargarExistencias_Click);
            // 
            // dgvExistencias
            // 
            this.dgvExistencias.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistencias.Location = new System.Drawing.Point(22, 191);
            this.dgvExistencias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvExistencias.Name = "dgvExistencias";
            this.dgvExistencias.RowHeadersWidth = 62;
            this.dgvExistencias.RowTemplate.Height = 28;
            this.dgvExistencias.Size = new System.Drawing.Size(528, 275);
            this.dgvExistencias.TabIndex = 12;
            // 
            // Lbl_Bodega
            // 
            this.Lbl_Bodega.AutoSize = true;
            this.Lbl_Bodega.Location = new System.Drawing.Point(110, 93);
            this.Lbl_Bodega.Name = "Lbl_Bodega";
            this.Lbl_Bodega.Size = new System.Drawing.Size(59, 19);
            this.Lbl_Bodega.TabIndex = 3;
            this.Lbl_Bodega.Text = "Bodega:";
            // 
            // cmbBodega
            // 
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(210, 91);
            this.cmbBodega.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(127, 27);
            this.cmbBodega.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "MONITOREO DE ALMACÉN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(848, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Unidades Disponibles:";
            // 
            // Btn_ayudaAlmacen
            // 
            this.Btn_ayudaAlmacen.FlatAppearance.BorderSize = 0;
            this.Btn_ayudaAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayudaAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayudaAlmacen.Image")));
            this.Btn_ayudaAlmacen.Location = new System.Drawing.Point(1183, 8);
            this.Btn_ayudaAlmacen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_ayudaAlmacen.Name = "Btn_ayudaAlmacen";
            this.Btn_ayudaAlmacen.Size = new System.Drawing.Size(77, 62);
            this.Btn_ayudaAlmacen.TabIndex = 26;
            this.toolTip4.SetToolTip(this.Btn_ayudaAlmacen, "Ayuda");
            this.Btn_ayudaAlmacen.UseVisualStyleBackColor = false;
            this.Btn_ayudaAlmacen.Click += new System.EventHandler(this.Btn_ayudaAlmacen_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1193, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "AYUDA";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // MonitoreoAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1284, 639);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Btn_ayudaAlmacen);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MonitoreoAlmacen";
            this.Text = "MonitoreoAlmacen";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditorias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.CheckBox chkDiscrepanciaDetectada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaAuditoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtCantidadFisica;
        private System.Windows.Forms.TextBox txtCantidadRegistrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProductoAuditoria;
        private System.Windows.Forms.Button btnRealizarAuditoria;
        private System.Windows.Forms.DataGridView dgvAuditorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBodegaAuditoria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lbl_Producto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Button btnCargarExistencias;
        private System.Windows.Forms.DataGridView dgvExistencias;
        private System.Windows.Forms.Label Lbl_Bodega;
        private System.Windows.Forms.ComboBox cmbBodega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_ayudaAlmacen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}