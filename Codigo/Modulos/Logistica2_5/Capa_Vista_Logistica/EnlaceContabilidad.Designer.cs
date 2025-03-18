
namespace Capa_Vista_Logistica
{
    partial class Frm_Polizas
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gp_encabezado = new System.Windows.Forms.GroupBox();
            this.Txt_concepto = new System.Windows.Forms.TextBox();
            this.Txt_concept = new System.Windows.Forms.Label();
            this.Txt_tipo_poliza = new System.Windows.Forms.Label();
            this.Dpt_fecha = new System.Windows.Forms.DateTimePicker();
            this.Txt_fecha = new System.Windows.Forms.Label();
            this.Cbo_tipopoliza = new System.Windows.Forms.ComboBox();
            this.gb_detalle = new System.Windows.Forms.GroupBox();
            this.Txt_val = new System.Windows.Forms.Label();
            this.Txt_cargoabono = new System.Windows.Forms.Label();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.Txt_valor = new System.Windows.Forms.TextBox();
            this.Cbo_operacion = new System.Windows.Forms.ComboBox();
            this.Cbo_Cuenta = new System.Windows.Forms.ComboBox();
            this.Txt_Cuenta = new System.Windows.Forms.Label();
            this.gb_detallemov = new System.Windows.Forms.GroupBox();
            this.Btn_quitar = new System.Windows.Forms.Button();
            this.Dgv_Polizas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_cargoB = new System.Windows.Forms.Label();
            this.Txt_abonoB = new System.Windows.Forms.Label();
            this.Txt_CargoTot = new System.Windows.Forms.Label();
            this.Txt_AbonoTot = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_registrar_poliza = new System.Windows.Forms.Button();
            this.Btn_nueva_poliza = new System.Windows.Forms.Button();
            this.gp_encabezado.SuspendLayout();
            this.gb_detalle.SuspendLayout();
            this.gb_detallemov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Polizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Maroon;
            // 
            // gp_encabezado
            // 
            this.gp_encabezado.Controls.Add(this.Txt_concepto);
            this.gp_encabezado.Controls.Add(this.Txt_concept);
            this.gp_encabezado.Controls.Add(this.Txt_tipo_poliza);
            this.gp_encabezado.Controls.Add(this.Dpt_fecha);
            this.gp_encabezado.Controls.Add(this.Txt_fecha);
            this.gp_encabezado.Controls.Add(this.Cbo_tipopoliza);
            this.gp_encabezado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_encabezado.Location = new System.Drawing.Point(9, 79);
            this.gp_encabezado.Margin = new System.Windows.Forms.Padding(2);
            this.gp_encabezado.Name = "gp_encabezado";
            this.gp_encabezado.Padding = new System.Windows.Forms.Padding(2);
            this.gp_encabezado.Size = new System.Drawing.Size(788, 118);
            this.gp_encabezado.TabIndex = 0;
            this.gp_encabezado.TabStop = false;
            this.gp_encabezado.Text = "Encabezado poliza";
            // 
            // Txt_concepto
            // 
            this.Txt_concepto.Location = new System.Drawing.Point(92, 79);
            this.Txt_concepto.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_concepto.Name = "Txt_concepto";
            this.Txt_concepto.Size = new System.Drawing.Size(672, 26);
            this.Txt_concepto.TabIndex = 5;
            // 
            // Txt_concept
            // 
            this.Txt_concept.AutoSize = true;
            this.Txt_concept.Location = new System.Drawing.Point(14, 82);
            this.Txt_concept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_concept.Name = "Txt_concept";
            this.Txt_concept.Size = new System.Drawing.Size(69, 19);
            this.Txt_concept.TabIndex = 4;
            this.Txt_concept.Text = "Concepto";
            // 
            // Txt_tipo_poliza
            // 
            this.Txt_tipo_poliza.AutoSize = true;
            this.Txt_tipo_poliza.Location = new System.Drawing.Point(340, 40);
            this.Txt_tipo_poliza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_tipo_poliza.Name = "Txt_tipo_poliza";
            this.Txt_tipo_poliza.Size = new System.Drawing.Size(94, 19);
            this.Txt_tipo_poliza.TabIndex = 3;
            this.Txt_tipo_poliza.Text = "Tipo de poliza";
            // 
            // Dpt_fecha
            // 
            this.Dpt_fecha.Location = new System.Drawing.Point(92, 36);
            this.Dpt_fecha.Margin = new System.Windows.Forms.Padding(2);
            this.Dpt_fecha.Name = "Dpt_fecha";
            this.Dpt_fecha.Size = new System.Drawing.Size(205, 26);
            this.Dpt_fecha.TabIndex = 2;
            this.Dpt_fecha.ValueChanged += new System.EventHandler(this.dtpfecha_ValueChanged);
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.AutoSize = true;
            this.Txt_fecha.Location = new System.Drawing.Point(37, 40);
            this.Txt_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(46, 19);
            this.Txt_fecha.TabIndex = 1;
            this.Txt_fecha.Text = "Fecha";
            // 
            // Cbo_tipopoliza
            // 
            this.Cbo_tipopoliza.FormattingEnabled = true;
            this.Cbo_tipopoliza.Location = new System.Drawing.Point(438, 37);
            this.Cbo_tipopoliza.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_tipopoliza.Name = "Cbo_tipopoliza";
            this.Cbo_tipopoliza.Size = new System.Drawing.Size(189, 27);
            this.Cbo_tipopoliza.TabIndex = 0;
            this.Cbo_tipopoliza.SelectedIndexChanged += new System.EventHandler(this.cbtipopoliza_SelectedIndexChanged);
            // 
            // gb_detalle
            // 
            this.gb_detalle.Controls.Add(this.Txt_val);
            this.gb_detalle.Controls.Add(this.Txt_cargoabono);
            this.gb_detalle.Controls.Add(this.Btn_aceptar);
            this.gb_detalle.Controls.Add(this.Txt_valor);
            this.gb_detalle.Controls.Add(this.Cbo_operacion);
            this.gb_detalle.Controls.Add(this.Cbo_Cuenta);
            this.gb_detalle.Controls.Add(this.Txt_Cuenta);
            this.gb_detalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_detalle.Location = new System.Drawing.Point(10, 202);
            this.gb_detalle.Margin = new System.Windows.Forms.Padding(2);
            this.gb_detalle.Name = "gb_detalle";
            this.gb_detalle.Padding = new System.Windows.Forms.Padding(2);
            this.gb_detalle.Size = new System.Drawing.Size(788, 93);
            this.gb_detalle.TabIndex = 1;
            this.gb_detalle.TabStop = false;
            this.gb_detalle.Text = "Detalle";
            // 
            // Txt_val
            // 
            this.Txt_val.AutoSize = true;
            this.Txt_val.BackColor = System.Drawing.Color.Beige;
            this.Txt_val.Location = new System.Drawing.Point(492, 23);
            this.Txt_val.Margin = new System.Windows.Forms.Padding(8);
            this.Txt_val.Name = "Txt_val";
            this.Txt_val.Padding = new System.Windows.Forms.Padding(0, 0, 41, 0);
            this.Txt_val.Size = new System.Drawing.Size(134, 19);
            this.Txt_val.TabIndex = 8;
            this.Txt_val.Text = "             Valor";
            this.Txt_val.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Txt_cargoabono
            // 
            this.Txt_cargoabono.AutoSize = true;
            this.Txt_cargoabono.BackColor = System.Drawing.Color.Beige;
            this.Txt_cargoabono.Location = new System.Drawing.Point(322, 23);
            this.Txt_cargoabono.Margin = new System.Windows.Forms.Padding(8);
            this.Txt_cargoabono.Name = "Txt_cargoabono";
            this.Txt_cargoabono.Padding = new System.Windows.Forms.Padding(0, 0, 34, 0);
            this.Txt_cargoabono.Size = new System.Drawing.Size(167, 19);
            this.Txt_cargoabono.TabIndex = 7;
            this.Txt_cargoabono.Text = "          Cargo/Abono";
            this.Txt_cargoabono.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.Btn_aceptar.Image = global::Capa_Vista_Logistica.Properties.Resources.lista_de_verificacion;
            this.Btn_aceptar.Location = new System.Drawing.Point(649, 12);
            this.Btn_aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(82, 76);
            this.Btn_aceptar.TabIndex = 6;
            this.Btn_aceptar.UseVisualStyleBackColor = false;
            this.Btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // Txt_valor
            // 
            this.Txt_valor.Location = new System.Drawing.Point(516, 47);
            this.Txt_valor.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_valor.Name = "Txt_valor";
            this.Txt_valor.Size = new System.Drawing.Size(109, 26);
            this.Txt_valor.TabIndex = 5;
            this.Txt_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // Cbo_operacion
            // 
            this.Cbo_operacion.FormattingEnabled = true;
            this.Cbo_operacion.Location = new System.Drawing.Point(341, 46);
            this.Cbo_operacion.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_operacion.Name = "Cbo_operacion";
            this.Cbo_operacion.Size = new System.Drawing.Size(133, 27);
            this.Cbo_operacion.TabIndex = 4;
            this.Cbo_operacion.SelectedIndexChanged += new System.EventHandler(this.cboperacion_SelectedIndexChanged);
            // 
            // Cbo_Cuenta
            // 
            this.Cbo_Cuenta.FormattingEnabled = true;
            this.Cbo_Cuenta.Location = new System.Drawing.Point(91, 47);
            this.Cbo_Cuenta.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_Cuenta.Name = "Cbo_Cuenta";
            this.Cbo_Cuenta.Size = new System.Drawing.Size(217, 27);
            this.Cbo_Cuenta.TabIndex = 3;
            this.Cbo_Cuenta.SelectedIndexChanged += new System.EventHandler(this.cbCuenta_SelectedIndexChanged);
            // 
            // Txt_Cuenta
            // 
            this.Txt_Cuenta.AutoSize = true;
            this.Txt_Cuenta.BackColor = System.Drawing.Color.Beige;
            this.Txt_Cuenta.Location = new System.Drawing.Point(36, 23);
            this.Txt_Cuenta.Margin = new System.Windows.Forms.Padding(8);
            this.Txt_Cuenta.Name = "Txt_Cuenta";
            this.Txt_Cuenta.Padding = new System.Windows.Forms.Padding(0, 0, 90, 0);
            this.Txt_Cuenta.Size = new System.Drawing.Size(258, 19);
            this.Txt_Cuenta.TabIndex = 0;
            this.Txt_Cuenta.Text = "                             Cuenta\r\n";
            this.Txt_Cuenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gb_detallemov
            // 
            this.gb_detallemov.Controls.Add(this.Btn_quitar);
            this.gb_detallemov.Controls.Add(this.Dgv_Polizas);
            this.gb_detallemov.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_detallemov.Location = new System.Drawing.Point(10, 306);
            this.gb_detallemov.Margin = new System.Windows.Forms.Padding(2);
            this.gb_detallemov.Name = "gb_detallemov";
            this.gb_detallemov.Padding = new System.Windows.Forms.Padding(2);
            this.gb_detallemov.Size = new System.Drawing.Size(788, 304);
            this.gb_detallemov.TabIndex = 2;
            this.gb_detallemov.TabStop = false;
            this.gb_detallemov.Text = "Detalle de movimiento";
            // 
            // Btn_quitar
            // 
            this.Btn_quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.Btn_quitar.Image = global::Capa_Vista_Logistica.Properties.Resources.boton_menos3;
            this.Btn_quitar.Location = new System.Drawing.Point(694, 25);
            this.Btn_quitar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_quitar.Name = "Btn_quitar";
            this.Btn_quitar.Size = new System.Drawing.Size(80, 79);
            this.Btn_quitar.TabIndex = 1;
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
            this.Dgv_Polizas.Location = new System.Drawing.Point(5, 25);
            this.Dgv_Polizas.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_Polizas.Name = "Dgv_Polizas";
            this.Dgv_Polizas.RowHeadersWidth = 51;
            this.Dgv_Polizas.RowTemplate.Height = 24;
            this.Dgv_Polizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Polizas.Size = new System.Drawing.Size(671, 266);
            this.Dgv_Polizas.TabIndex = 0;
            this.Dgv_Polizas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolizas_CellContentClick);
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
            // Txt_cargoB
            // 
            this.Txt_cargoB.AutoSize = true;
            this.Txt_cargoB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cargoB.Location = new System.Drawing.Point(332, 636);
            this.Txt_cargoB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_cargoB.Name = "Txt_cargoB";
            this.Txt_cargoB.Size = new System.Drawing.Size(116, 19);
            this.Txt_cargoB.TabIndex = 7;
            this.Txt_cargoB.Text = "TOTAL CARGO";
            // 
            // Txt_abonoB
            // 
            this.Txt_abonoB.AutoSize = true;
            this.Txt_abonoB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_abonoB.Location = new System.Drawing.Point(543, 636);
            this.Txt_abonoB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_abonoB.Name = "Txt_abonoB";
            this.Txt_abonoB.Size = new System.Drawing.Size(117, 19);
            this.Txt_abonoB.TabIndex = 8;
            this.Txt_abonoB.Text = "TOTAL ABONO";
            // 
            // Txt_CargoTot
            // 
            this.Txt_CargoTot.AutoSize = true;
            this.Txt_CargoTot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CargoTot.Location = new System.Drawing.Point(458, 636);
            this.Txt_CargoTot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_CargoTot.Name = "Txt_CargoTot";
            this.Txt_CargoTot.Size = new System.Drawing.Size(45, 19);
            this.Txt_CargoTot.TabIndex = 10;
            this.Txt_CargoTot.Text = "00.00";
            // 
            // Txt_AbonoTot
            // 
            this.Txt_AbonoTot.AutoSize = true;
            this.Txt_AbonoTot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_AbonoTot.Location = new System.Drawing.Point(667, 636);
            this.Txt_AbonoTot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_AbonoTot.Name = "Txt_AbonoTot";
            this.Txt_AbonoTot.Size = new System.Drawing.Size(45, 19);
            this.Txt_AbonoTot.TabIndex = 11;
            this.Txt_AbonoTot.Text = "00.00";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = global::Capa_Vista_Logistica.Properties.Resources.preguntas;
            this.Btn_ayuda.Location = new System.Drawing.Point(689, 10);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(52, 50);
            this.Btn_ayuda.TabIndex = 13;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Image = global::Capa_Vista_Logistica.Properties.Resources.cerrar_sesion;
            this.Btn_salir.Location = new System.Drawing.Point(745, 10);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(52, 50);
            this.Btn_salir.TabIndex = 12;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Image = global::Capa_Vista_Logistica.Properties.Resources.cancelar;
            this.Btn_Cancelar.Location = new System.Drawing.Point(161, 11);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(52, 50);
            this.Btn_Cancelar.TabIndex = 9;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Btn_registrar_poliza
            // 
            this.Btn_registrar_poliza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.Btn_registrar_poliza.Image = global::Capa_Vista_Logistica.Properties.Resources.ahorrar__1_;
            this.Btn_registrar_poliza.Location = new System.Drawing.Point(94, 10);
            this.Btn_registrar_poliza.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_registrar_poliza.Name = "Btn_registrar_poliza";
            this.Btn_registrar_poliza.Size = new System.Drawing.Size(52, 52);
            this.Btn_registrar_poliza.TabIndex = 4;
            this.Btn_registrar_poliza.UseVisualStyleBackColor = false;
            this.Btn_registrar_poliza.Click += new System.EventHandler(this.btn_registar_poliza_Click);
            // 
            // Btn_nueva_poliza
            // 
            this.Btn_nueva_poliza.Image = global::Capa_Vista_Logistica.Properties.Resources.agregar_archivo;
            this.Btn_nueva_poliza.Location = new System.Drawing.Point(28, 10);
            this.Btn_nueva_poliza.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_nueva_poliza.Name = "Btn_nueva_poliza";
            this.Btn_nueva_poliza.Size = new System.Drawing.Size(52, 52);
            this.Btn_nueva_poliza.TabIndex = 3;
            this.Btn_nueva_poliza.UseVisualStyleBackColor = true;
            this.Btn_nueva_poliza.Click += new System.EventHandler(this.btn_nueva_poliza_Click);
            // 
            // Frm_Polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 678);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Txt_AbonoTot);
            this.Controls.Add(this.Txt_CargoTot);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Txt_abonoB);
            this.Controls.Add(this.Txt_cargoB);
            this.Controls.Add(this.Btn_registrar_poliza);
            this.Controls.Add(this.Btn_nueva_poliza);
            this.Controls.Add(this.gb_detallemov);
            this.Controls.Add(this.gb_detalle);
            this.Controls.Add(this.gp_encabezado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Polizas";
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

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox gp_encabezado;
        internal System.Windows.Forms.TextBox Txt_concepto;
        private System.Windows.Forms.Label Txt_concept;
        private System.Windows.Forms.Label Txt_tipo_poliza;
        private System.Windows.Forms.DateTimePicker Dpt_fecha;
        private System.Windows.Forms.Label Txt_fecha;
        internal System.Windows.Forms.ComboBox Cbo_tipopoliza;
        private System.Windows.Forms.GroupBox gb_detalle;
        private System.Windows.Forms.Button Btn_aceptar;
        internal System.Windows.Forms.TextBox Txt_valor;
        internal System.Windows.Forms.ComboBox Cbo_operacion;
        internal System.Windows.Forms.ComboBox Cbo_Cuenta;
        private System.Windows.Forms.Label Txt_Cuenta;
        private System.Windows.Forms.GroupBox gb_detallemov;
        private System.Windows.Forms.Button Btn_quitar;
        internal System.Windows.Forms.DataGridView Dgv_Polizas;
        private System.Windows.Forms.Button Btn_nueva_poliza;
        private System.Windows.Forms.Button Btn_registrar_poliza;
        private System.Windows.Forms.Label Txt_cargoB;
        private System.Windows.Forms.Label Txt_abonoB;
        private System.Windows.Forms.Button Btn_Cancelar;
        internal System.Windows.Forms.Label Txt_CargoTot;
        internal System.Windows.Forms.Label Txt_AbonoTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
        private System.Windows.Forms.Label Txt_val;
        private System.Windows.Forms.Label Txt_cargoabono;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}