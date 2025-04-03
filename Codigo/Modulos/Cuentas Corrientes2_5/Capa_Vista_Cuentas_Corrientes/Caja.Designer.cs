namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lbl_monto_pago = new System.Windows.Forms.Label();
            this.Lbl_NombreCliente = new System.Windows.Forms.Label();
            this.Lbl_id_cobra_deuda = new System.Windows.Forms.Label();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.Lbl_saldo_restante = new System.Windows.Forms.Label();
            this.Cbo_Id_factura = new System.Windows.Forms.ComboBox();
            this.Lbl_idCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_id_CP = new System.Windows.Forms.TextBox();
            this.Dtp_fecha_reg = new System.Windows.Forms.DateTimePicker();
            this.Lbl_mora = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_mora = new System.Windows.Forms.TextBox();
            this.Txt_monto_deuda = new System.Windows.Forms.TextBox();
            this.Lbl_estado_cuenta = new System.Windows.Forms.Label();
            this.Txt_Saldo_restante = new System.Windows.Forms.TextBox();
            this.Lbl_fecha_registro = new System.Windows.Forms.Label();
            this.Txt_monto_trans = new System.Windows.Forms.TextBox();
            this.Cbo_id_deuda = new System.Windows.Forms.ComboBox();
            this.Text_IdFactura = new System.Windows.Forms.Label();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lbl_monto_pago);
            this.groupBox2.Controls.Add(this.Lbl_NombreCliente);
            this.groupBox2.Controls.Add(this.Lbl_id_cobra_deuda);
            this.groupBox2.Controls.Add(this.Txt_estado);
            this.groupBox2.Controls.Add(this.Lbl_saldo_restante);
            this.groupBox2.Controls.Add(this.Cbo_Id_factura);
            this.groupBox2.Controls.Add(this.Lbl_idCliente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Txt_id_CP);
            this.groupBox2.Controls.Add(this.Dtp_fecha_reg);
            this.groupBox2.Controls.Add(this.Lbl_mora);
            this.groupBox2.Controls.Add(this.Txt_Nombre);
            this.groupBox2.Controls.Add(this.Txt_mora);
            this.groupBox2.Controls.Add(this.Txt_monto_deuda);
            this.groupBox2.Controls.Add(this.Lbl_estado_cuenta);
            this.groupBox2.Controls.Add(this.Txt_Saldo_restante);
            this.groupBox2.Controls.Add(this.Lbl_fecha_registro);
            this.groupBox2.Controls.Add(this.Txt_monto_trans);
            this.groupBox2.Controls.Add(this.Cbo_id_deuda);
            this.groupBox2.Controls.Add(this.Text_IdFactura);
            this.groupBox2.Location = new System.Drawing.Point(8, 141);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(997, 250);
            this.groupBox2.TabIndex = 155;
            this.groupBox2.TabStop = false;
            // 
            // Lbl_monto_pago
            // 
            this.Lbl_monto_pago.AutoSize = true;
            this.Lbl_monto_pago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_monto_pago.Location = new System.Drawing.Point(540, 70);
            this.Lbl_monto_pago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_monto_pago.Name = "Lbl_monto_pago";
            this.Lbl_monto_pago.Size = new System.Drawing.Size(192, 22);
            this.Lbl_monto_pago.TabIndex = 120;
            this.Lbl_monto_pago.Text = "Monto de Transacción:";
            // 
            // Lbl_NombreCliente
            // 
            this.Lbl_NombreCliente.AutoSize = true;
            this.Lbl_NombreCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreCliente.Location = new System.Drawing.Point(17, 76);
            this.Lbl_NombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_NombreCliente.Name = "Lbl_NombreCliente";
            this.Lbl_NombreCliente.Size = new System.Drawing.Size(85, 22);
            this.Lbl_NombreCliente.TabIndex = 117;
            this.Lbl_NombreCliente.Text = "Nombre: ";
            // 
            // Lbl_id_cobra_deuda
            // 
            this.Lbl_id_cobra_deuda.AutoSize = true;
            this.Lbl_id_cobra_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_cobra_deuda.Location = new System.Drawing.Point(17, 156);
            this.Lbl_id_cobra_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_cobra_deuda.Name = "Lbl_id_cobra_deuda";
            this.Lbl_id_cobra_deuda.Size = new System.Drawing.Size(130, 22);
            this.Lbl_id_cobra_deuda.TabIndex = 118;
            this.Lbl_id_cobra_deuda.Text = "Código Deuda:";
            // 
            // Txt_estado
            // 
            this.Txt_estado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.Location = new System.Drawing.Point(791, 190);
            this.Txt_estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(146, 30);
            this.Txt_estado.TabIndex = 149;
            // 
            // Lbl_saldo_restante
            // 
            this.Lbl_saldo_restante.AutoSize = true;
            this.Lbl_saldo_restante.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_saldo_restante.Location = new System.Drawing.Point(593, 112);
            this.Lbl_saldo_restante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_saldo_restante.Name = "Lbl_saldo_restante";
            this.Lbl_saldo_restante.Size = new System.Drawing.Size(134, 22);
            this.Lbl_saldo_restante.TabIndex = 119;
            this.Lbl_saldo_restante.Text = "Saldo Restante:";
            // 
            // Cbo_Id_factura
            // 
            this.Cbo_Id_factura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Id_factura.FormattingEnabled = true;
            this.Cbo_Id_factura.Location = new System.Drawing.Point(230, 114);
            this.Cbo_Id_factura.Name = "Cbo_Id_factura";
            this.Cbo_Id_factura.Size = new System.Drawing.Size(121, 30);
            this.Cbo_Id_factura.TabIndex = 148;
            // 
            // Lbl_idCliente
            // 
            this.Lbl_idCliente.AutoSize = true;
            this.Lbl_idCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idCliente.Location = new System.Drawing.Point(17, 36);
            this.Lbl_idCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_idCliente.Name = "Lbl_idCliente";
            this.Lbl_idCliente.Size = new System.Drawing.Size(74, 22);
            this.Lbl_idCliente.TabIndex = 121;
            this.Lbl_idCliente.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 147;
            this.label1.Text = "No. Factura: ";
            // 
            // Txt_id_CP
            // 
            this.Txt_id_CP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_CP.Location = new System.Drawing.Point(230, 34);
            this.Txt_id_CP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_id_CP.Name = "Txt_id_CP";
            this.Txt_id_CP.Size = new System.Drawing.Size(171, 30);
            this.Txt_id_CP.TabIndex = 122;
            // 
            // Dtp_fecha_reg
            // 
            this.Dtp_fecha_reg.Location = new System.Drawing.Point(791, 157);
            this.Dtp_fecha_reg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtp_fecha_reg.Name = "Dtp_fecha_reg";
            this.Dtp_fecha_reg.Size = new System.Drawing.Size(178, 22);
            this.Dtp_fecha_reg.TabIndex = 146;
            // 
            // Lbl_mora
            // 
            this.Lbl_mora.AutoSize = true;
            this.Lbl_mora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mora.Location = new System.Drawing.Point(649, 39);
            this.Lbl_mora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_mora.Name = "Lbl_mora";
            this.Lbl_mora.Size = new System.Drawing.Size(59, 22);
            this.Lbl_mora.TabIndex = 124;
            this.Lbl_mora.Text = "Mora:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(229, 72);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(259, 30);
            this.Txt_Nombre.TabIndex = 145;
            // 
            // Txt_mora
            // 
            this.Txt_mora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_mora.Location = new System.Drawing.Point(791, 34);
            this.Txt_mora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_mora.Name = "Txt_mora";
            this.Txt_mora.Size = new System.Drawing.Size(146, 30);
            this.Txt_mora.TabIndex = 125;
            // 
            // Txt_monto_deuda
            // 
            this.Txt_monto_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_monto_deuda.Location = new System.Drawing.Point(229, 198);
            this.Txt_monto_deuda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_monto_deuda.Name = "Txt_monto_deuda";
            this.Txt_monto_deuda.Size = new System.Drawing.Size(121, 30);
            this.Txt_monto_deuda.TabIndex = 144;
            // 
            // Lbl_estado_cuenta
            // 
            this.Lbl_estado_cuenta.AutoSize = true;
            this.Lbl_estado_cuenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado_cuenta.Location = new System.Drawing.Point(554, 196);
            this.Lbl_estado_cuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_estado_cuenta.Name = "Lbl_estado_cuenta";
            this.Lbl_estado_cuenta.Size = new System.Drawing.Size(153, 22);
            this.Lbl_estado_cuenta.TabIndex = 127;
            this.Lbl_estado_cuenta.Text = "Estado de Cuenta:";
            // 
            // Txt_Saldo_restante
            // 
            this.Txt_Saldo_restante.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Saldo_restante.Location = new System.Drawing.Point(791, 110);
            this.Txt_Saldo_restante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Saldo_restante.Name = "Txt_Saldo_restante";
            this.Txt_Saldo_restante.Size = new System.Drawing.Size(146, 30);
            this.Txt_Saldo_restante.TabIndex = 141;
            // 
            // Lbl_fecha_registro
            // 
            this.Lbl_fecha_registro.AutoSize = true;
            this.Lbl_fecha_registro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha_registro.Location = new System.Drawing.Point(573, 157);
            this.Lbl_fecha_registro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_fecha_registro.Name = "Lbl_fecha_registro";
            this.Lbl_fecha_registro.Size = new System.Drawing.Size(153, 22);
            this.Lbl_fecha_registro.TabIndex = 128;
            this.Lbl_fecha_registro.Text = "Fecha de registro:";
            // 
            // Txt_monto_trans
            // 
            this.Txt_monto_trans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_monto_trans.Location = new System.Drawing.Point(791, 70);
            this.Txt_monto_trans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_monto_trans.Name = "Txt_monto_trans";
            this.Txt_monto_trans.Size = new System.Drawing.Size(146, 30);
            this.Txt_monto_trans.TabIndex = 140;
            // 
            // Cbo_id_deuda
            // 
            this.Cbo_id_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_id_deuda.FormattingEnabled = true;
            this.Cbo_id_deuda.Location = new System.Drawing.Point(229, 157);
            this.Cbo_id_deuda.Name = "Cbo_id_deuda";
            this.Cbo_id_deuda.Size = new System.Drawing.Size(121, 30);
            this.Cbo_id_deuda.TabIndex = 135;
            // 
            // Text_IdFactura
            // 
            this.Text_IdFactura.AutoSize = true;
            this.Text_IdFactura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_IdFactura.Location = new System.Drawing.Point(22, 199);
            this.Text_IdFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Text_IdFactura.Name = "Text_IdFactura";
            this.Text_IdFactura.Size = new System.Drawing.Size(123, 22);
            this.Text_IdFactura.TabIndex = 137;
            this.Text_IdFactura.Text = "Monto Deuda:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Ayudas);
            this.groupBox1.Controls.Add(this.Btn_editar);
            this.groupBox1.Controls.Add(this.Btn_eliminar);
            this.groupBox1.Controls.Add(this.Btn_guardar);
            this.groupBox1.Controls.Add(this.Btn_Actualizar);
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Controls.Add(this.Btn_salir);
            this.groupBox1.Controls.Add(this.Btn_reportes);
            this.groupBox1.Location = new System.Drawing.Point(248, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(613, 82);
            this.groupBox1.TabIndex = 154;
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
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(63, 61);
            this.Btn_guardar.TabIndex = 132;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Actualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Actualizar.Image")));
            this.Btn_Actualizar.Location = new System.Drawing.Point(41, 10);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(60, 62);
            this.Btn_Actualizar.TabIndex = 133;
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(313, 10);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 33);
            this.label3.TabIndex = 153;
            this.label3.Text = "- CAJA -";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 438);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(948, 182);
            this.dataGridView1.TabIndex = 156;
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1014, 667);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Caja";
            this.Text = "Caja";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lbl_monto_pago;
        private System.Windows.Forms.Label Lbl_NombreCliente;
        private System.Windows.Forms.Label Lbl_id_cobra_deuda;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.Label Lbl_saldo_restante;
        private System.Windows.Forms.ComboBox Cbo_Id_factura;
        private System.Windows.Forms.Label Lbl_idCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_id_CP;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_reg;
        private System.Windows.Forms.Label Lbl_mora;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_mora;
        private System.Windows.Forms.TextBox Txt_monto_deuda;
        private System.Windows.Forms.Label Lbl_estado_cuenta;
        private System.Windows.Forms.TextBox Txt_Saldo_restante;
        private System.Windows.Forms.Label Lbl_fecha_registro;
        private System.Windows.Forms.TextBox Txt_monto_trans;
        private System.Windows.Forms.ComboBox Cbo_id_deuda;
        private System.Windows.Forms.Label Text_IdFactura;
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}