
namespace Capa_Vista_Polizas
{
    partial class frmPolizas
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
            System.Windows.Forms.Label Lbl_Cuenta;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPolizas));
            this.cd_form = new System.Windows.Forms.ColorDialog();
            this.gp_encabezado = new System.Windows.Forms.GroupBox();
            this.Txt_concepto = new System.Windows.Forms.TextBox();
            this.lbl_concepto = new System.Windows.Forms.Label();
            this.Lbl_tipo_poliza = new System.Windows.Forms.Label();
            this.Dpt_fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Cbo_tipopoliza = new System.Windows.Forms.ComboBox();
            this.gb_detalle = new System.Windows.Forms.GroupBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.Lbl_operacion = new System.Windows.Forms.Label();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.Txt_valor = new System.Windows.Forms.TextBox();
            this.Cbo_operacion = new System.Windows.Forms.ComboBox();
            this.Cbo_Cuenta = new System.Windows.Forms.ComboBox();
            this.gb_detallemov = new System.Windows.Forms.GroupBox();
            this.Btn_quitar = new System.Windows.Forms.Button();
            this.Dgv_Polizas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_cargo = new System.Windows.Forms.Label();
            this.Lbl_abono = new System.Windows.Forms.Label();
            this.Lbl_CargoTot = new System.Windows.Forms.Label();
            this.Lbl_AbonoTot = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Tt_Crear = new System.Windows.Forms.ToolTip(this.components);
            this.Tt_Guardar = new System.Windows.Forms.ToolTip(this.components);
            this.Tt_Cancelar = new System.Windows.Forms.ToolTip(this.components);
            this.Tt_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.Tt_Salir = new System.Windows.Forms.ToolTip(this.components);
            this.Tt_Check = new System.Windows.Forms.ToolTip(this.components);
            this.Tt_Quitar = new System.Windows.Forms.ToolTip(this.components);
            this.Tt_Aviso = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_registar_poliza = new System.Windows.Forms.Button();
            this.Btn_nueva_poliza = new System.Windows.Forms.Button();
            Lbl_Cuenta = new System.Windows.Forms.Label();
            this.gp_encabezado.SuspendLayout();
            this.gb_detalle.SuspendLayout();
            this.gb_detallemov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Polizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Cuenta
            // 
            Lbl_Cuenta.BackColor = System.Drawing.Color.Beige;
            Lbl_Cuenta.Location = new System.Drawing.Point(124, 28);
            Lbl_Cuenta.Margin = new System.Windows.Forms.Padding(10);
            Lbl_Cuenta.Name = "Lbl_Cuenta";
            Lbl_Cuenta.Padding = new System.Windows.Forms.Padding(0, 0, 120, 0);
            Lbl_Cuenta.Size = new System.Drawing.Size(286, 22);
            Lbl_Cuenta.TabIndex = 0;
            Lbl_Cuenta.Text = "                Cuenta\r\n";
            Lbl_Cuenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cd_form
            // 
            this.cd_form.Color = System.Drawing.Color.Maroon;
            // 
            // gp_encabezado
            // 
            this.gp_encabezado.Controls.Add(this.Txt_concepto);
            this.gp_encabezado.Controls.Add(this.lbl_concepto);
            this.gp_encabezado.Controls.Add(this.Lbl_tipo_poliza);
            this.gp_encabezado.Controls.Add(this.Dpt_fecha);
            this.gp_encabezado.Controls.Add(this.Lbl_fecha);
            this.gp_encabezado.Controls.Add(this.Cbo_tipopoliza);
            this.gp_encabezado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_encabezado.Location = new System.Drawing.Point(12, 97);
            this.gp_encabezado.Name = "gp_encabezado";
            this.gp_encabezado.Size = new System.Drawing.Size(1051, 145);
            this.gp_encabezado.TabIndex = 0;
            this.gp_encabezado.TabStop = false;
            this.gp_encabezado.Text = "Encabezado poliza";
            // 
            // Txt_concepto
            // 
            this.Txt_concepto.Location = new System.Drawing.Point(140, 97);
            this.Txt_concepto.Name = "Txt_concepto";
            this.Txt_concepto.Size = new System.Drawing.Size(877, 30);
            this.Txt_concepto.TabIndex = 8;
            // 
            // lbl_concepto
            // 
            this.lbl_concepto.AutoSize = true;
            this.lbl_concepto.Location = new System.Drawing.Point(49, 97);
            this.lbl_concepto.Name = "lbl_concepto";
            this.lbl_concepto.Size = new System.Drawing.Size(85, 22);
            this.lbl_concepto.TabIndex = 4;
            this.lbl_concepto.Text = "Concepto";
            // 
            // Lbl_tipo_poliza
            // 
            this.Lbl_tipo_poliza.AutoSize = true;
            this.Lbl_tipo_poliza.Location = new System.Drawing.Point(558, 49);
            this.Lbl_tipo_poliza.Name = "Lbl_tipo_poliza";
            this.Lbl_tipo_poliza.Size = new System.Drawing.Size(125, 22);
            this.Lbl_tipo_poliza.TabIndex = 3;
            this.Lbl_tipo_poliza.Text = "Tipo de poliza";
            // 
            // Dpt_fecha
            // 
            this.Dpt_fecha.Location = new System.Drawing.Point(113, 43);
            this.Dpt_fecha.Name = "Dpt_fecha";
            this.Dpt_fecha.Size = new System.Drawing.Size(325, 30);
            this.Dpt_fecha.TabIndex = 6;
            this.Dpt_fecha.ValueChanged += new System.EventHandler(this.dtpfecha_ValueChanged);
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Location = new System.Drawing.Point(49, 44);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(57, 22);
            this.Lbl_fecha.TabIndex = 1;
            this.Lbl_fecha.Text = "Fecha";
            // 
            // Cbo_tipopoliza
            // 
            this.Cbo_tipopoliza.FormattingEnabled = true;
            this.Cbo_tipopoliza.Location = new System.Drawing.Point(689, 46);
            this.Cbo_tipopoliza.Name = "Cbo_tipopoliza";
            this.Cbo_tipopoliza.Size = new System.Drawing.Size(251, 30);
            this.Cbo_tipopoliza.TabIndex = 7;
            this.Cbo_tipopoliza.SelectedIndexChanged += new System.EventHandler(this.cbtipopoliza_SelectedIndexChanged);
            // 
            // gb_detalle
            // 
            this.gb_detalle.Controls.Add(this.lbl_valor);
            this.gb_detalle.Controls.Add(this.Lbl_operacion);
            this.gb_detalle.Controls.Add(this.Btn_aceptar);
            this.gb_detalle.Controls.Add(this.Txt_valor);
            this.gb_detalle.Controls.Add(this.Cbo_operacion);
            this.gb_detalle.Controls.Add(this.Cbo_Cuenta);
            this.gb_detalle.Controls.Add(Lbl_Cuenta);
            this.gb_detalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_detalle.Location = new System.Drawing.Point(13, 248);
            this.gb_detalle.Name = "gb_detalle";
            this.gb_detalle.Size = new System.Drawing.Size(1050, 114);
            this.gb_detalle.TabIndex = 1;
            this.gb_detalle.TabStop = false;
            this.gb_detalle.Text = "Detalle";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.BackColor = System.Drawing.Color.Beige;
            this.lbl_valor.Location = new System.Drawing.Point(689, 28);
            this.lbl_valor.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
            this.lbl_valor.Size = new System.Drawing.Size(143, 22);
            this.lbl_valor.TabIndex = 8;
            this.lbl_valor.Text = "       Valor";
            this.lbl_valor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_operacion
            // 
            this.Lbl_operacion.AutoSize = true;
            this.Lbl_operacion.BackColor = System.Drawing.Color.Beige;
            this.Lbl_operacion.Location = new System.Drawing.Point(454, 28);
            this.Lbl_operacion.Margin = new System.Windows.Forms.Padding(10);
            this.Lbl_operacion.Name = "Lbl_operacion";
            this.Lbl_operacion.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.Lbl_operacion.Size = new System.Drawing.Size(177, 22);
            this.Lbl_operacion.TabIndex = 7;
            this.Lbl_operacion.Text = "   Cargo/Abono";
            this.Lbl_operacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.Btn_aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_aceptar.Image")));
            this.Btn_aceptar.Location = new System.Drawing.Point(880, 17);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(94, 91);
            this.Btn_aceptar.TabIndex = 12;
            this.Btn_aceptar.UseVisualStyleBackColor = false;
            this.Btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // Txt_valor
            // 
            this.Txt_valor.Location = new System.Drawing.Point(688, 58);
            this.Txt_valor.Name = "Txt_valor";
            this.Txt_valor.Size = new System.Drawing.Size(144, 30);
            this.Txt_valor.TabIndex = 11;
            this.Txt_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.Txt_valor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // Cbo_operacion
            // 
            this.Cbo_operacion.FormattingEnabled = true;
            this.Cbo_operacion.Location = new System.Drawing.Point(455, 56);
            this.Cbo_operacion.Name = "Cbo_operacion";
            this.Cbo_operacion.Size = new System.Drawing.Size(176, 30);
            this.Cbo_operacion.TabIndex = 10;
            this.Cbo_operacion.SelectedIndexChanged += new System.EventHandler(this.cboperacion_SelectedIndexChanged);
            // 
            // Cbo_Cuenta
            // 
            this.Cbo_Cuenta.FormattingEnabled = true;
            this.Cbo_Cuenta.Location = new System.Drawing.Point(122, 58);
            this.Cbo_Cuenta.Name = "Cbo_Cuenta";
            this.Cbo_Cuenta.Size = new System.Drawing.Size(288, 30);
            this.Cbo_Cuenta.TabIndex = 9;
            this.Cbo_Cuenta.SelectedIndexChanged += new System.EventHandler(this.cbCuenta_SelectedIndexChanged);
            // 
            // gb_detallemov
            // 
            this.gb_detallemov.Controls.Add(this.Btn_quitar);
            this.gb_detallemov.Controls.Add(this.Dgv_Polizas);
            this.gb_detallemov.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_detallemov.Location = new System.Drawing.Point(13, 377);
            this.gb_detallemov.Name = "gb_detallemov";
            this.gb_detallemov.Size = new System.Drawing.Size(1050, 374);
            this.gb_detallemov.TabIndex = 2;
            this.gb_detallemov.TabStop = false;
            this.gb_detallemov.Text = "Detalle de movimiento";
            // 
            // Btn_quitar
            // 
            this.Btn_quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.Btn_quitar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_quitar.Image")));
            this.Btn_quitar.Location = new System.Drawing.Point(923, 29);
            this.Btn_quitar.Name = "Btn_quitar";
            this.Btn_quitar.Size = new System.Drawing.Size(107, 97);
            this.Btn_quitar.TabIndex = 14;
            this.Btn_quitar.UseVisualStyleBackColor = false;
            this.Btn_quitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // Dgv_Polizas
            // 
            this.Dgv_Polizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Polizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cuenta,
            this.Cargo,
            this.Abono});
            this.Dgv_Polizas.Location = new System.Drawing.Point(7, 31);
            this.Dgv_Polizas.Name = "Dgv_Polizas";
            this.Dgv_Polizas.RowHeadersWidth = 51;
            this.Dgv_Polizas.RowTemplate.Height = 24;
            this.Dgv_Polizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Polizas.Size = new System.Drawing.Size(895, 327);
            this.Dgv_Polizas.TabIndex = 13;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 150;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 6;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Width = 150;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 150;
            // 
            // Abono
            // 
            this.Abono.HeaderText = "Abono";
            this.Abono.MinimumWidth = 6;
            this.Abono.Name = "Abono";
            this.Abono.Width = 150;
            // 
            // Lbl_cargo
            // 
            this.Lbl_cargo.AutoSize = true;
            this.Lbl_cargo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cargo.Location = new System.Drawing.Point(467, 783);
            this.Lbl_cargo.Name = "Lbl_cargo";
            this.Lbl_cargo.Size = new System.Drawing.Size(143, 22);
            this.Lbl_cargo.TabIndex = 7;
            this.Lbl_cargo.Text = "TOTAL CARGO";
            // 
            // Lbl_abono
            // 
            this.Lbl_abono.AutoSize = true;
            this.Lbl_abono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_abono.Location = new System.Drawing.Point(716, 783);
            this.Lbl_abono.Name = "Lbl_abono";
            this.Lbl_abono.Size = new System.Drawing.Size(143, 22);
            this.Lbl_abono.TabIndex = 8;
            this.Lbl_abono.Text = "TOTAL ABONO";
            // 
            // Lbl_CargoTot
            // 
            this.Lbl_CargoTot.AutoSize = true;
            this.Lbl_CargoTot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CargoTot.Location = new System.Drawing.Point(625, 783);
            this.Lbl_CargoTot.Name = "Lbl_CargoTot";
            this.Lbl_CargoTot.Size = new System.Drawing.Size(55, 22);
            this.Lbl_CargoTot.TabIndex = 10;
            this.Lbl_CargoTot.Text = "00.00";
            // 
            // Lbl_AbonoTot
            // 
            this.Lbl_AbonoTot.AutoSize = true;
            this.Lbl_AbonoTot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AbonoTot.Location = new System.Drawing.Point(865, 783);
            this.Lbl_AbonoTot.Name = "Lbl_AbonoTot";
            this.Lbl_AbonoTot.Size = new System.Drawing.Size(55, 22);
            this.Lbl_AbonoTot.TabIndex = 11;
            this.Lbl_AbonoTot.Text = "00.00";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(917, 12);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(70, 62);
            this.Btn_ayuda.TabIndex = 8;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salir.Image")));
            this.Btn_salir.Location = new System.Drawing.Point(993, 12);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(70, 62);
            this.Btn_salir.TabIndex = 9;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(215, 14);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(70, 62);
            this.Btn_Cancelar.TabIndex = 7;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Btn_registar_poliza
            // 
            this.Btn_registar_poliza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.Btn_registar_poliza.Image = ((System.Drawing.Image)(resources.GetObject("Btn_registar_poliza.Image")));
            this.Btn_registar_poliza.Location = new System.Drawing.Point(125, 12);
            this.Btn_registar_poliza.Name = "Btn_registar_poliza";
            this.Btn_registar_poliza.Size = new System.Drawing.Size(70, 64);
            this.Btn_registar_poliza.TabIndex = 6;
            this.Btn_registar_poliza.UseVisualStyleBackColor = false;
            this.Btn_registar_poliza.Click += new System.EventHandler(this.btn_registar_poliza_Click);
            // 
            // Btn_nueva_poliza
            // 
            this.Btn_nueva_poliza.Image = ((System.Drawing.Image)(resources.GetObject("Btn_nueva_poliza.Image")));
            this.Btn_nueva_poliza.Location = new System.Drawing.Point(38, 12);
            this.Btn_nueva_poliza.Name = "Btn_nueva_poliza";
            this.Btn_nueva_poliza.Size = new System.Drawing.Size(70, 64);
            this.Btn_nueva_poliza.TabIndex = 5;
            this.Btn_nueva_poliza.UseVisualStyleBackColor = true;
            this.Btn_nueva_poliza.Click += new System.EventHandler(this.btn_nueva_poliza_Click);
            // 
            // frmPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 834);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Lbl_AbonoTot);
            this.Controls.Add(this.Lbl_CargoTot);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Lbl_abono);
            this.Controls.Add(this.Lbl_cargo);
            this.Controls.Add(this.Btn_registar_poliza);
            this.Controls.Add(this.Btn_nueva_poliza);
            this.Controls.Add(this.gb_detallemov);
            this.Controls.Add(this.gb_detalle);
            this.Controls.Add(this.gp_encabezado);
            this.Name = "frmPolizas";
            this.Text = "Polizas";
            this.Load += new System.EventHandler(this.Polizas_Load);
            this.gp_encabezado.ResumeLayout(false);
            this.gp_encabezado.PerformLayout();
            this.gb_detalle.ResumeLayout(false);
            this.gb_detalle.PerformLayout();
            this.gb_detallemov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Polizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog cd_form;
        private System.Windows.Forms.GroupBox gp_encabezado;
        private System.Windows.Forms.TextBox Txt_concepto;
        private System.Windows.Forms.Label lbl_concepto;
        private System.Windows.Forms.Label Lbl_tipo_poliza;
        private System.Windows.Forms.DateTimePicker Dpt_fecha;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.ComboBox Cbo_tipopoliza;
        private System.Windows.Forms.GroupBox gb_detalle;
        private System.Windows.Forms.Button Btn_aceptar;
        private System.Windows.Forms.TextBox Txt_valor;
        private System.Windows.Forms.ComboBox Cbo_operacion;
        private System.Windows.Forms.ComboBox Cbo_Cuenta;
        private System.Windows.Forms.GroupBox gb_detallemov;
        private System.Windows.Forms.Button Btn_quitar;
        private System.Windows.Forms.DataGridView Dgv_Polizas;
        private System.Windows.Forms.Button Btn_nueva_poliza;
        private System.Windows.Forms.Button Btn_registar_poliza;
        private System.Windows.Forms.Label Lbl_cargo;
        private System.Windows.Forms.Label Lbl_abono;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label Lbl_CargoTot;
        private System.Windows.Forms.Label Lbl_AbonoTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label Lbl_operacion;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.ToolTip Tt_Crear;
        private System.Windows.Forms.ToolTip Tt_Guardar;
        private System.Windows.Forms.ToolTip Tt_Cancelar;
        private System.Windows.Forms.ToolTip Tt_Ayuda;
        private System.Windows.Forms.ToolTip Tt_Salir;
        private System.Windows.Forms.ToolTip Tt_Check;
        private System.Windows.Forms.ToolTip Tt_Quitar;
        private System.Windows.Forms.ToolTip Tt_Aviso;
    }
}