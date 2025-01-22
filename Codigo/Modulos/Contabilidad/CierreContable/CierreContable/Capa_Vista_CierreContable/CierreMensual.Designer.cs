
namespace Capa_Vista_CierreContable
{
    partial class CierreMensual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CierreMensual));
            this.Lbl_cierremens = new System.Windows.Forms.Label();
            this.Lbl_titulocierre = new System.Windows.Forms.Label();
            this.Lbl_mes = new System.Windows.Forms.Label();
            this.Cbo_mes = new System.Windows.Forms.ComboBox();
            this.Lbl_año = new System.Windows.Forms.Label();
            this.Cbo_año = new System.Windows.Forms.ComboBox();
            this.Dgv_cierre = new System.Windows.Forms.DataGridView();
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.Cbo_cuenta = new System.Windows.Forms.ComboBox();
            this.Gpb_datosmeses = new System.Windows.Forms.GroupBox();
            this.Lbl_saldoact = new System.Windows.Forms.Label();
            this.Lbl_saldoant = new System.Windows.Forms.Label();
            this.Lbl_abonomes = new System.Windows.Forms.Label();
            this.Lbl_cargomes = new System.Windows.Forms.Label();
            this.Txt_saldoactmes = new System.Windows.Forms.TextBox();
            this.Txt_saldoantmes = new System.Windows.Forms.TextBox();
            this.Txt_abonomes = new System.Windows.Forms.TextBox();
            this.Txt_cargomes = new System.Windows.Forms.TextBox();
            this.Btn_ayuda2 = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_nuevocierre = new System.Windows.Forms.Button();
            this.Btn_guardarcierre = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cierre)).BeginInit();
            this.Gpb_datosmeses.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_cierremens
            // 
            this.Lbl_cierremens.AutoSize = true;
            this.Lbl_cierremens.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cierremens.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_cierremens.Location = new System.Drawing.Point(357, 144);
            this.Lbl_cierremens.Name = "Lbl_cierremens";
            this.Lbl_cierremens.Size = new System.Drawing.Size(199, 24);
            this.Lbl_cierremens.TabIndex = 41;
            this.Lbl_cierremens.Text = "CIERRE MENSUAL";
            // 
            // Lbl_titulocierre
            // 
            this.Lbl_titulocierre.AutoSize = true;
            this.Lbl_titulocierre.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulocierre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_titulocierre.Location = new System.Drawing.Point(365, 9);
            this.Lbl_titulocierre.Name = "Lbl_titulocierre";
            this.Lbl_titulocierre.Size = new System.Drawing.Size(180, 37);
            this.Lbl_titulocierre.TabIndex = 36;
            this.Lbl_titulocierre.Text = "Generar Cierre";
            // 
            // Lbl_mes
            // 
            this.Lbl_mes.AutoSize = true;
            this.Lbl_mes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_mes.Location = new System.Drawing.Point(301, 73);
            this.Lbl_mes.Name = "Lbl_mes";
            this.Lbl_mes.Size = new System.Drawing.Size(47, 24);
            this.Lbl_mes.TabIndex = 54;
            this.Lbl_mes.Text = "Mes";
            // 
            // Cbo_mes
            // 
            this.Cbo_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_mes.FormattingEnabled = true;
            this.Cbo_mes.Location = new System.Drawing.Point(372, 76);
            this.Cbo_mes.Name = "Cbo_mes";
            this.Cbo_mes.Size = new System.Drawing.Size(163, 21);
            this.Cbo_mes.TabIndex = 53;
            // 
            // Lbl_año
            // 
            this.Lbl_año.AutoSize = true;
            this.Lbl_año.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_año.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_año.Location = new System.Drawing.Point(300, 49);
            this.Lbl_año.Name = "Lbl_año";
            this.Lbl_año.Size = new System.Drawing.Size(47, 24);
            this.Lbl_año.TabIndex = 56;
            this.Lbl_año.Text = "Año";
            // 
            // Cbo_año
            // 
            this.Cbo_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_año.Enabled = false;
            this.Cbo_año.FormattingEnabled = true;
            this.Cbo_año.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034"});
            this.Cbo_año.Location = new System.Drawing.Point(372, 49);
            this.Cbo_año.Name = "Cbo_año";
            this.Cbo_año.Size = new System.Drawing.Size(163, 21);
            this.Cbo_año.TabIndex = 55;
            // 
            // Dgv_cierre
            // 
            this.Dgv_cierre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cierre.Location = new System.Drawing.Point(23, 171);
            this.Dgv_cierre.Name = "Dgv_cierre";
            this.Dgv_cierre.Size = new System.Drawing.Size(814, 225);
            this.Dgv_cierre.TabIndex = 58;
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_cuenta.Location = new System.Drawing.Point(272, 103);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.Size = new System.Drawing.Size(75, 24);
            this.Lbl_cuenta.TabIndex = 71;
            this.Lbl_cuenta.Text = "Cuenta";
            // 
            // Cbo_cuenta
            // 
            this.Cbo_cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_cuenta.FormattingEnabled = true;
            this.Cbo_cuenta.Location = new System.Drawing.Point(372, 106);
            this.Cbo_cuenta.Name = "Cbo_cuenta";
            this.Cbo_cuenta.Size = new System.Drawing.Size(163, 21);
            this.Cbo_cuenta.TabIndex = 72;
            // 
            // Gpb_datosmeses
            // 
            this.Gpb_datosmeses.Controls.Add(this.Lbl_saldoact);
            this.Gpb_datosmeses.Controls.Add(this.Lbl_saldoant);
            this.Gpb_datosmeses.Controls.Add(this.Lbl_abonomes);
            this.Gpb_datosmeses.Controls.Add(this.Lbl_cargomes);
            this.Gpb_datosmeses.Controls.Add(this.Txt_saldoactmes);
            this.Gpb_datosmeses.Controls.Add(this.Txt_saldoantmes);
            this.Gpb_datosmeses.Controls.Add(this.Txt_abonomes);
            this.Gpb_datosmeses.Controls.Add(this.Txt_cargomes);
            this.Gpb_datosmeses.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosmeses.Location = new System.Drawing.Point(23, 402);
            this.Gpb_datosmeses.Name = "Gpb_datosmeses";
            this.Gpb_datosmeses.Size = new System.Drawing.Size(814, 118);
            this.Gpb_datosmeses.TabIndex = 99;
            this.Gpb_datosmeses.TabStop = false;
            this.Gpb_datosmeses.Text = "Datos del mes";
            // 
            // Lbl_saldoact
            // 
            this.Lbl_saldoact.AutoSize = true;
            this.Lbl_saldoact.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_saldoact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_saldoact.Location = new System.Drawing.Point(471, 74);
            this.Lbl_saldoact.Name = "Lbl_saldoact";
            this.Lbl_saldoact.Size = new System.Drawing.Size(123, 24);
            this.Lbl_saldoact.TabIndex = 106;
            this.Lbl_saldoact.Text = "Saldo Actual";
            // 
            // Lbl_saldoant
            // 
            this.Lbl_saldoant.AutoSize = true;
            this.Lbl_saldoant.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_saldoant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_saldoant.Location = new System.Drawing.Point(471, 47);
            this.Lbl_saldoant.Name = "Lbl_saldoant";
            this.Lbl_saldoant.Size = new System.Drawing.Size(139, 24);
            this.Lbl_saldoant.TabIndex = 105;
            this.Lbl_saldoant.Text = "Saldo Anterior";
            // 
            // Lbl_abonomes
            // 
            this.Lbl_abonomes.AutoSize = true;
            this.Lbl_abonomes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_abonomes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_abonomes.Location = new System.Drawing.Point(27, 74);
            this.Lbl_abonomes.Name = "Lbl_abonomes";
            this.Lbl_abonomes.Size = new System.Drawing.Size(150, 24);
            this.Lbl_abonomes.TabIndex = 104;
            this.Lbl_abonomes.Text = "Abonos del Mes";
            // 
            // Lbl_cargomes
            // 
            this.Lbl_cargomes.AutoSize = true;
            this.Lbl_cargomes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cargomes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_cargomes.Location = new System.Drawing.Point(32, 48);
            this.Lbl_cargomes.Name = "Lbl_cargomes";
            this.Lbl_cargomes.Size = new System.Drawing.Size(145, 24);
            this.Lbl_cargomes.TabIndex = 103;
            this.Lbl_cargomes.Text = "Cargos del mes";
            // 
            // Txt_saldoactmes
            // 
            this.Txt_saldoactmes.Enabled = false;
            this.Txt_saldoactmes.Location = new System.Drawing.Point(616, 78);
            this.Txt_saldoactmes.Name = "Txt_saldoactmes";
            this.Txt_saldoactmes.Size = new System.Drawing.Size(174, 20);
            this.Txt_saldoactmes.TabIndex = 102;
            // 
            // Txt_saldoantmes
            // 
            this.Txt_saldoantmes.Enabled = false;
            this.Txt_saldoantmes.Location = new System.Drawing.Point(616, 48);
            this.Txt_saldoantmes.Name = "Txt_saldoantmes";
            this.Txt_saldoantmes.Size = new System.Drawing.Size(174, 20);
            this.Txt_saldoantmes.TabIndex = 101;
            // 
            // Txt_abonomes
            // 
            this.Txt_abonomes.Enabled = false;
            this.Txt_abonomes.Location = new System.Drawing.Point(193, 79);
            this.Txt_abonomes.Name = "Txt_abonomes";
            this.Txt_abonomes.Size = new System.Drawing.Size(174, 20);
            this.Txt_abonomes.TabIndex = 100;
            // 
            // Txt_cargomes
            // 
            this.Txt_cargomes.Enabled = false;
            this.Txt_cargomes.Location = new System.Drawing.Point(193, 48);
            this.Txt_cargomes.Name = "Txt_cargomes";
            this.Txt_cargomes.Size = new System.Drawing.Size(174, 20);
            this.Txt_cargomes.TabIndex = 99;
            // 
            // Btn_ayuda2
            // 
            this.Btn_ayuda2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_ayuda2.BackgroundImage = global::Capa_Vista_CierreContable.Properties.Resources.AYUDA_V4;
            this.Btn_ayuda2.Location = new System.Drawing.Point(122, 34);
            this.Btn_ayuda2.Name = "Btn_ayuda2";
            this.Btn_ayuda2.Size = new System.Drawing.Size(72, 66);
            this.Btn_ayuda2.TabIndex = 101;
            this.Btn_ayuda2.UseVisualStyleBackColor = false;
            this.Btn_ayuda2.Click += new System.EventHandler(this.btn_Ayuda2_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_actualizar.BackgroundImage = global::Capa_Vista_CierreContable.Properties.Resources.ACTUALIZAR_V4;
            this.Btn_actualizar.Location = new System.Drawing.Point(200, 34);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(72, 66);
            this.Btn_actualizar.TabIndex = 100;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_cancelar.Enabled = false;
            this.Btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_cancelar.Image = global::Capa_Vista_CierreContable.Properties.Resources.CANCELAR_V4;
            this.Btn_cancelar.Location = new System.Drawing.Point(654, 41);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(76, 66);
            this.Btn_cancelar.TabIndex = 90;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Btn_nuevocierre
            // 
            this.Btn_nuevocierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_nuevocierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nuevocierre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_nuevocierre.Image = global::Capa_Vista_CierreContable.Properties.Resources.INGRESAR_V4;
            this.Btn_nuevocierre.Location = new System.Drawing.Point(576, 41);
            this.Btn_nuevocierre.Name = "Btn_nuevocierre";
            this.Btn_nuevocierre.Size = new System.Drawing.Size(72, 66);
            this.Btn_nuevocierre.TabIndex = 89;
            this.Btn_nuevocierre.UseVisualStyleBackColor = false;
            this.Btn_nuevocierre.Click += new System.EventHandler(this.btn_nuevocierre_Click);
            // 
            // Btn_guardarcierre
            // 
            this.Btn_guardarcierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_guardarcierre.Enabled = false;
            this.Btn_guardarcierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardarcierre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_guardarcierre.Image = global::Capa_Vista_CierreContable.Properties.Resources.guardar;
            this.Btn_guardarcierre.Location = new System.Drawing.Point(736, 41);
            this.Btn_guardarcierre.Name = "Btn_guardarcierre";
            this.Btn_guardarcierre.Size = new System.Drawing.Size(76, 66);
            this.Btn_guardarcierre.TabIndex = 88;
            this.Btn_guardarcierre.UseVisualStyleBackColor = false;
            this.Btn_guardarcierre.Click += new System.EventHandler(this.btn_GuardarCierre_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_reporte.BackgroundImage = global::Capa_Vista_CierreContable.Properties.Resources.impresora;
            this.Btn_reporte.Location = new System.Drawing.Point(44, 37);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(72, 63);
            this.Btn_reporte.TabIndex = 104;
            this.Btn_reporte.UseVisualStyleBackColor = false;
            this.Btn_reporte.Click += new System.EventHandler(this.btn_Reporte_Click_1);
            // 
            // CierreMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(901, 532);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_ayuda2);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Gpb_datosmeses);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_nuevocierre);
            this.Controls.Add(this.Btn_guardarcierre);
            this.Controls.Add(this.Cbo_cuenta);
            this.Controls.Add(this.Lbl_cuenta);
            this.Controls.Add(this.Dgv_cierre);
            this.Controls.Add(this.Lbl_año);
            this.Controls.Add(this.Cbo_año);
            this.Controls.Add(this.Lbl_mes);
            this.Controls.Add(this.Cbo_mes);
            this.Controls.Add(this.Lbl_cierremens);
            this.Controls.Add(this.Lbl_titulocierre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CierreMensual";
            this.Load += new System.EventHandler(this.ConsultasCierre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cierre)).EndInit();
            this.Gpb_datosmeses.ResumeLayout(false);
            this.Gpb_datosmeses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_cierremens;
        private System.Windows.Forms.Label Lbl_titulocierre;
        private System.Windows.Forms.Label Lbl_mes;
        public System.Windows.Forms.ComboBox Cbo_mes;
        private System.Windows.Forms.Label Lbl_año;
        public System.Windows.Forms.ComboBox Cbo_año;
        private System.Windows.Forms.DataGridView Dgv_cierre;
        private System.Windows.Forms.Label Lbl_cuenta;
        public System.Windows.Forms.ComboBox Cbo_cuenta;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_nuevocierre;
        private System.Windows.Forms.Button Btn_guardarcierre;
        private System.Windows.Forms.GroupBox Gpb_datosmeses;
        private System.Windows.Forms.Label Lbl_saldoact;
        private System.Windows.Forms.Label Lbl_saldoant;
        private System.Windows.Forms.Label Lbl_abonomes;
        private System.Windows.Forms.Label Lbl_cargomes;
        private System.Windows.Forms.TextBox Txt_saldoactmes;
        private System.Windows.Forms.TextBox Txt_saldoantmes;
        private System.Windows.Forms.TextBox Txt_abonomes;
        private System.Windows.Forms.TextBox Txt_cargomes;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_ayuda2;
        private System.Windows.Forms.Button Btn_reporte;
    }
}