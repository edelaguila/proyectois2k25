
namespace Capa_Vista_CPP
{
    partial class Transacc_proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transacc_proveedores));
            this.Cbo_cuenta = new System.Windows.Forms.ComboBox();
            this.Cbo_moneda = new System.Windows.Forms.ComboBox();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_monto = new System.Windows.Forms.TextBox();
            this.Txt_transaccion = new System.Windows.Forms.TextBox();
            this.Dgv_transacciones_provee = new System.Windows.Forms.DataGridView();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Lbl_tipo_moneda = new System.Windows.Forms.Label();
            this.Lbl_monto = new System.Windows.Forms.Label();
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_proveedor = new System.Windows.Forms.Label();
            this.Lbl_id = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Ayudas = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_reportes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_transacciones_provee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cbo_cuenta
            // 
            this.Cbo_cuenta.FormattingEnabled = true;
            this.Cbo_cuenta.Items.AddRange(new object[] {
            "Activo",
            "Pasivo"});
            this.Cbo_cuenta.Location = new System.Drawing.Point(263, 257);
            this.Cbo_cuenta.Name = "Cbo_cuenta";
            this.Cbo_cuenta.Size = new System.Drawing.Size(200, 24);
            this.Cbo_cuenta.TabIndex = 60;
            // 
            // Cbo_moneda
            // 
            this.Cbo_moneda.FormattingEnabled = true;
            this.Cbo_moneda.Items.AddRange(new object[] {
            "USD",
            "MXN",
            "GTQ",
            "EUR"});
            this.Cbo_moneda.Location = new System.Drawing.Point(858, 200);
            this.Cbo_moneda.Name = "Cbo_moneda";
            this.Cbo_moneda.Size = new System.Drawing.Size(198, 24);
            this.Cbo_moneda.TabIndex = 59;
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cbo_estado.Location = new System.Drawing.Point(825, 244);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(202, 24);
            this.Cbo_estado.TabIndex = 51;
            // 
            // Txt_monto
            // 
            this.Txt_monto.Location = new System.Drawing.Point(876, 157);
            this.Txt_monto.Name = "Txt_monto";
            this.Txt_monto.Size = new System.Drawing.Size(198, 22);
            this.Txt_monto.TabIndex = 48;
            // 
            // Txt_transaccion
            // 
            this.Txt_transaccion.Location = new System.Drawing.Point(307, 146);
            this.Txt_transaccion.Name = "Txt_transaccion";
            this.Txt_transaccion.Size = new System.Drawing.Size(156, 22);
            this.Txt_transaccion.TabIndex = 45;
            // 
            // Dgv_transacciones_provee
            // 
            this.Dgv_transacciones_provee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_transacciones_provee.Location = new System.Drawing.Point(162, 302);
            this.Dgv_transacciones_provee.MultiSelect = false;
            this.Dgv_transacciones_provee.Name = "Dgv_transacciones_provee";
            this.Dgv_transacciones_provee.RowHeadersWidth = 51;
            this.Dgv_transacciones_provee.RowTemplate.Height = 24;
            this.Dgv_transacciones_provee.Size = new System.Drawing.Size(1041, 295);
            this.Dgv_transacciones_provee.TabIndex = 44;
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Location = new System.Drawing.Point(741, 244);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(52, 17);
            this.Lbl_estado.TabIndex = 43;
            this.Lbl_estado.Text = "Estado";
            // 
            // Lbl_tipo_moneda
            // 
            this.Lbl_tipo_moneda.AutoSize = true;
            this.Lbl_tipo_moneda.Location = new System.Drawing.Point(741, 203);
            this.Lbl_tipo_moneda.Name = "Lbl_tipo_moneda";
            this.Lbl_tipo_moneda.Size = new System.Drawing.Size(111, 17);
            this.Lbl_tipo_moneda.TabIndex = 41;
            this.Lbl_tipo_moneda.Text = "Tipo de moneda";
            // 
            // Lbl_monto
            // 
            this.Lbl_monto.AutoSize = true;
            this.Lbl_monto.Location = new System.Drawing.Point(741, 160);
            this.Lbl_monto.Name = "Lbl_monto";
            this.Lbl_monto.Size = new System.Drawing.Size(129, 17);
            this.Lbl_monto.TabIndex = 39;
            this.Lbl_monto.Text = "Transacción monto";
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.Location = new System.Drawing.Point(198, 260);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.Size = new System.Drawing.Size(53, 17);
            this.Lbl_cuenta.TabIndex = 37;
            this.Lbl_cuenta.Text = "Cuenta";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Location = new System.Drawing.Point(198, 220);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(144, 17);
            this.Lbl_fecha.TabIndex = 36;
            this.Lbl_fecha.Text = "Fecha de transacción";
            // 
            // Lbl_proveedor
            // 
            this.Lbl_proveedor.AutoSize = true;
            this.Lbl_proveedor.Location = new System.Drawing.Point(198, 187);
            this.Lbl_proveedor.Name = "Lbl_proveedor";
            this.Lbl_proveedor.Size = new System.Drawing.Size(91, 17);
            this.Lbl_proveedor.TabIndex = 34;
            this.Lbl_proveedor.Text = "ID Proveedor";
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Location = new System.Drawing.Point(198, 149);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(103, 17);
            this.Lbl_id.TabIndex = 33;
            this.Lbl_id.Text = "ID Transacción";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.groupBox1.Controls.Add(this.Btn_Ayudas);
            this.groupBox1.Controls.Add(this.Btn_editar);
            this.groupBox1.Controls.Add(this.Btn_eliminar);
            this.groupBox1.Controls.Add(this.Btn_guardar);
            this.groupBox1.Controls.Add(this.Btn_Actualizar);
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Controls.Add(this.Btn_salir);
            this.groupBox1.Controls.Add(this.Btn_reportes);
            this.groupBox1.Location = new System.Drawing.Point(382, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(613, 82);
            this.groupBox1.TabIndex = 156;
            this.groupBox1.TabStop = false;
            // 
            // Btn_Ayudas
            // 
            this.Btn_Ayudas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Ayudas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayudas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayudas.Image")));
            this.Btn_Ayudas.Location = new System.Drawing.Point(452, 10);
            this.Btn_Ayudas.Name = "Btn_Ayudas";
            this.Btn_Ayudas.Size = new System.Drawing.Size(65, 62);
            this.Btn_Ayudas.TabIndex = 142;
            this.Btn_Ayudas.UseVisualStyleBackColor = false;
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_editar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.Location = new System.Drawing.Point(245, 10);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(60, 62);
            this.Btn_editar.TabIndex = 130;
            this.Btn_editar.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_eliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(179, 10);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(58, 62);
            this.Btn_eliminar.TabIndex = 131;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_guardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(108, 11);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(63, 61);
            this.Btn_guardar.TabIndex = 132;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Actualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Actualizar.Image")));
            this.Btn_Actualizar.Location = new System.Drawing.Point(41, 10);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(60, 62);
            this.Btn_Actualizar.TabIndex = 133;
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(313, 10);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(62, 62);
            this.Btn_Buscar.TabIndex = 136;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_salir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salir.Image")));
            this.Btn_salir.Location = new System.Drawing.Point(522, 10);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(63, 62);
            this.Btn_salir.TabIndex = 139;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_reportes
            // 
            this.Btn_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_reportes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reportes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_reportes.Image")));
            this.Btn_reportes.Location = new System.Drawing.Point(381, 10);
            this.Btn_reportes.Name = "Btn_reportes";
            this.Btn_reportes.Size = new System.Drawing.Size(65, 62);
            this.Btn_reportes.TabIndex = 143;
            this.Btn_reportes.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 33);
            this.label3.TabIndex = 155;
            this.label3.Text = "- TRANSACCIÓN PROVEEDORES -";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(349, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 157;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(307, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 158;
            // 
            // Transacc_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1371, 608);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbo_cuenta);
            this.Controls.Add(this.Cbo_moneda);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Txt_monto);
            this.Controls.Add(this.Txt_transaccion);
            this.Controls.Add(this.Dgv_transacciones_provee);
            this.Controls.Add(this.Lbl_estado);
            this.Controls.Add(this.Lbl_tipo_moneda);
            this.Controls.Add(this.Lbl_monto);
            this.Controls.Add(this.Lbl_cuenta);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_proveedor);
            this.Controls.Add(this.Lbl_id);
            this.Name = "Transacc_proveedores";
            this.Text = "Transacc_proveedores";
            this.Load += new System.EventHandler(this.Transacc_proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_transacciones_provee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Cbo_cuenta;
        private System.Windows.Forms.ComboBox Cbo_moneda;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_monto;
        private System.Windows.Forms.TextBox Txt_transaccion;
        private System.Windows.Forms.DataGridView Dgv_transacciones_provee;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.Label Lbl_tipo_moneda;
        private System.Windows.Forms.Label Lbl_monto;
        private System.Windows.Forms.Label Lbl_cuenta;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_proveedor;
        private System.Windows.Forms.Label Lbl_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Ayudas;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_reportes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}