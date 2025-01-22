
namespace Capa_Vista_CierreContable
{
    partial class ConsultasCierre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasCierre));
            this.Lbl_totabonos = new System.Windows.Forms.Label();
            this.Lbl_totalhaber = new System.Windows.Forms.Label();
            this.Lbl_totcargos = new System.Windows.Forms.Label();
            this.Lbl_Totaldebe = new System.Windows.Forms.Label();
            this.Lbl_mes = new System.Windows.Forms.Label();
            this.Cbo_mes = new System.Windows.Forms.ComboBox();
            this.Lbl_Tituloconsulta = new System.Windows.Forms.Label();
            this.Lbl_saldoact = new System.Windows.Forms.Label();
            this.Txt_saldoH = new System.Windows.Forms.TextBox();
            this.Txt_saldoD = new System.Windows.Forms.TextBox();
            this.Dgv_cargos = new System.Windows.Forms.DataGridView();
            this.Dgv_abonos = new System.Windows.Forms.DataGridView();
            this.Lbl_haber = new System.Windows.Forms.Label();
            this.Lbl_Debe = new System.Windows.Forms.Label();
            this.Txt_saldofinal = new System.Windows.Forms.TextBox();
            this.Cbo_cuenta = new System.Windows.Forms.ComboBox();
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.Txt_saldoant = new System.Windows.Forms.TextBox();
            this.Lbl_saldoant = new System.Windows.Forms.Label();
            this.Cbo_consultaAño = new System.Windows.Forms.ComboBox();
            this.Lbl_año = new System.Windows.Forms.Label();
            this.Btn_ayuda1 = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_abonos)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_totabonos
            // 
            this.Lbl_totabonos.AutoSize = true;
            this.Lbl_totabonos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_totabonos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_totabonos.Location = new System.Drawing.Point(833, 398);
            this.Lbl_totabonos.Name = "Lbl_totabonos";
            this.Lbl_totabonos.Size = new System.Drawing.Size(30, 23);
            this.Lbl_totabonos.TabIndex = 62;
            this.Lbl_totabonos.Text = "Q.";
            // 
            // Lbl_totalhaber
            // 
            this.Lbl_totalhaber.AutoSize = true;
            this.Lbl_totalhaber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_totalhaber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_totalhaber.Location = new System.Drawing.Point(766, 399);
            this.Lbl_totalhaber.Name = "Lbl_totalhaber";
            this.Lbl_totalhaber.Size = new System.Drawing.Size(62, 24);
            this.Lbl_totalhaber.TabIndex = 61;
            this.Lbl_totalhaber.Text = "Total:";
            // 
            // Lbl_totcargos
            // 
            this.Lbl_totcargos.AutoSize = true;
            this.Lbl_totcargos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_totcargos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_totcargos.Location = new System.Drawing.Point(322, 400);
            this.Lbl_totcargos.Name = "Lbl_totcargos";
            this.Lbl_totcargos.Size = new System.Drawing.Size(30, 23);
            this.Lbl_totcargos.TabIndex = 60;
            this.Lbl_totcargos.Text = "Q.";
            // 
            // Lbl_Totaldebe
            // 
            this.Lbl_Totaldebe.AutoSize = true;
            this.Lbl_Totaldebe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Totaldebe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Totaldebe.Location = new System.Drawing.Point(265, 400);
            this.Lbl_Totaldebe.Name = "Lbl_Totaldebe";
            this.Lbl_Totaldebe.Size = new System.Drawing.Size(62, 24);
            this.Lbl_Totaldebe.TabIndex = 59;
            this.Lbl_Totaldebe.Text = "Total:";
            // 
            // Lbl_mes
            // 
            this.Lbl_mes.AutoSize = true;
            this.Lbl_mes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_mes.Location = new System.Drawing.Point(395, 78);
            this.Lbl_mes.Name = "Lbl_mes";
            this.Lbl_mes.Size = new System.Drawing.Size(47, 24);
            this.Lbl_mes.TabIndex = 52;
            this.Lbl_mes.Text = "Mes";
            // 
            // Cbo_mes
            // 
            this.Cbo_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_mes.FormattingEnabled = true;
            this.Cbo_mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.Cbo_mes.Location = new System.Drawing.Point(453, 78);
            this.Cbo_mes.Name = "Cbo_mes";
            this.Cbo_mes.Size = new System.Drawing.Size(163, 21);
            this.Cbo_mes.TabIndex = 51;
            // 
            // Lbl_Tituloconsulta
            // 
            this.Lbl_Tituloconsulta.AutoSize = true;
            this.Lbl_Tituloconsulta.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tituloconsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Tituloconsulta.Location = new System.Drawing.Point(427, 8);
            this.Lbl_Tituloconsulta.Name = "Lbl_Tituloconsulta";
            this.Lbl_Tituloconsulta.Size = new System.Drawing.Size(195, 37);
            this.Lbl_Tituloconsulta.TabIndex = 50;
            this.Lbl_Tituloconsulta.Text = "Consultar Cierre";
            // 
            // Lbl_saldoact
            // 
            this.Lbl_saldoact.AutoSize = true;
            this.Lbl_saldoact.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_saldoact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_saldoact.Location = new System.Drawing.Point(536, 458);
            this.Lbl_saldoact.Name = "Lbl_saldoact";
            this.Lbl_saldoact.Size = new System.Drawing.Size(123, 24);
            this.Lbl_saldoact.TabIndex = 73;
            this.Lbl_saldoact.Text = "Saldo Actual";
            // 
            // Txt_saldoH
            // 
            this.Txt_saldoH.Location = new System.Drawing.Point(877, 401);
            this.Txt_saldoH.Name = "Txt_saldoH";
            this.Txt_saldoH.Size = new System.Drawing.Size(163, 20);
            this.Txt_saldoH.TabIndex = 72;
            // 
            // Txt_saldoD
            // 
            this.Txt_saldoD.Location = new System.Drawing.Point(358, 402);
            this.Txt_saldoD.Name = "Txt_saldoD";
            this.Txt_saldoD.Size = new System.Drawing.Size(163, 20);
            this.Txt_saldoD.TabIndex = 71;
            // 
            // Dgv_cargos
            // 
            this.Dgv_cargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cargos.Location = new System.Drawing.Point(22, 163);
            this.Dgv_cargos.Name = "Dgv_cargos";
            this.Dgv_cargos.Size = new System.Drawing.Size(499, 225);
            this.Dgv_cargos.TabIndex = 78;
            // 
            // Dgv_abonos
            // 
            this.Dgv_abonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_abonos.Location = new System.Drawing.Point(541, 163);
            this.Dgv_abonos.Name = "Dgv_abonos";
            this.Dgv_abonos.Size = new System.Drawing.Size(499, 225);
            this.Dgv_abonos.TabIndex = 77;
            // 
            // Lbl_haber
            // 
            this.Lbl_haber.AutoSize = true;
            this.Lbl_haber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_haber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_haber.Location = new System.Drawing.Point(751, 136);
            this.Lbl_haber.Name = "Lbl_haber";
            this.Lbl_haber.Size = new System.Drawing.Size(85, 24);
            this.Lbl_haber.TabIndex = 76;
            this.Lbl_haber.Text = "HABER";
            // 
            // Lbl_Debe
            // 
            this.Lbl_Debe.AutoSize = true;
            this.Lbl_Debe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Debe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Debe.Location = new System.Drawing.Point(231, 136);
            this.Lbl_Debe.Name = "Lbl_Debe";
            this.Lbl_Debe.Size = new System.Drawing.Size(68, 24);
            this.Lbl_Debe.TabIndex = 75;
            this.Lbl_Debe.Text = "DEBE";
            // 
            // Txt_saldofinal
            // 
            this.Txt_saldofinal.Location = new System.Drawing.Point(665, 462);
            this.Txt_saldofinal.Name = "Txt_saldofinal";
            this.Txt_saldofinal.Size = new System.Drawing.Size(163, 20);
            this.Txt_saldofinal.TabIndex = 79;
            // 
            // Cbo_cuenta
            // 
            this.Cbo_cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_cuenta.FormattingEnabled = true;
            this.Cbo_cuenta.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.Cbo_cuenta.Location = new System.Drawing.Point(453, 105);
            this.Cbo_cuenta.Name = "Cbo_cuenta";
            this.Cbo_cuenta.Size = new System.Drawing.Size(163, 21);
            this.Cbo_cuenta.TabIndex = 80;
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_cuenta.Location = new System.Drawing.Point(367, 102);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.Size = new System.Drawing.Size(75, 24);
            this.Lbl_cuenta.TabIndex = 81;
            this.Lbl_cuenta.Text = "Cuenta";
            // 
            // Txt_saldoant
            // 
            this.Txt_saldoant.Location = new System.Drawing.Point(308, 462);
            this.Txt_saldoant.Name = "Txt_saldoant";
            this.Txt_saldoant.Size = new System.Drawing.Size(181, 20);
            this.Txt_saldoant.TabIndex = 82;
            // 
            // Lbl_saldoant
            // 
            this.Lbl_saldoant.AutoSize = true;
            this.Lbl_saldoant.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_saldoant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_saldoant.Location = new System.Drawing.Point(172, 458);
            this.Lbl_saldoant.Name = "Lbl_saldoant";
            this.Lbl_saldoant.Size = new System.Drawing.Size(139, 24);
            this.Lbl_saldoant.TabIndex = 83;
            this.Lbl_saldoant.Text = "Saldo Anterior";
            // 
            // Cbo_consultaAño
            // 
            this.Cbo_consultaAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_consultaAño.FormattingEnabled = true;
            this.Cbo_consultaAño.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.Cbo_consultaAño.Location = new System.Drawing.Point(453, 51);
            this.Cbo_consultaAño.Name = "Cbo_consultaAño";
            this.Cbo_consultaAño.Size = new System.Drawing.Size(163, 21);
            this.Cbo_consultaAño.TabIndex = 84;
            // 
            // Lbl_año
            // 
            this.Lbl_año.AutoSize = true;
            this.Lbl_año.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_año.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_año.Location = new System.Drawing.Point(395, 51);
            this.Lbl_año.Name = "Lbl_año";
            this.Lbl_año.Size = new System.Drawing.Size(47, 24);
            this.Lbl_año.TabIndex = 85;
            this.Lbl_año.Text = "Año";
            // 
            // Btn_ayuda1
            // 
            this.Btn_ayuda1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_ayuda1.BackgroundImage = global::Capa_Vista_CierreContable.Properties.Resources.AYUDA_V4;
            this.Btn_ayuda1.Location = new System.Drawing.Point(191, 27);
            this.Btn_ayuda1.Name = "Btn_ayuda1";
            this.Btn_ayuda1.Size = new System.Drawing.Size(72, 66);
            this.Btn_ayuda1.TabIndex = 87;
            this.Btn_ayuda1.UseVisualStyleBackColor = false;
            this.Btn_ayuda1.Click += new System.EventHandler(this.btn_Ayuda1_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_actualizar.BackgroundImage = global::Capa_Vista_CierreContable.Properties.Resources.ACTUALIZAR_V4;
            this.Btn_actualizar.Location = new System.Drawing.Point(269, 27);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(72, 66);
            this.Btn_actualizar.TabIndex = 86;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_consultar.Image = global::Capa_Vista_CierreContable.Properties.Resources.BUCAR_V4;
            this.Btn_consultar.Location = new System.Drawing.Point(665, 27);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(72, 66);
            this.Btn_consultar.TabIndex = 53;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.btn_mensual_Click_1);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_reporte.BackgroundImage = global::Capa_Vista_CierreContable.Properties.Resources.impresora;
            this.Btn_reporte.Location = new System.Drawing.Point(113, 29);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(72, 63);
            this.Btn_reporte.TabIndex = 103;
            this.Btn_reporte.UseVisualStyleBackColor = false;
            this.Btn_reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // ConsultasCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(152)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(913, 512);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_ayuda1);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Lbl_año);
            this.Controls.Add(this.Cbo_consultaAño);
            this.Controls.Add(this.Lbl_saldoant);
            this.Controls.Add(this.Txt_saldoant);
            this.Controls.Add(this.Lbl_cuenta);
            this.Controls.Add(this.Cbo_cuenta);
            this.Controls.Add(this.Txt_saldofinal);
            this.Controls.Add(this.Dgv_cargos);
            this.Controls.Add(this.Dgv_abonos);
            this.Controls.Add(this.Lbl_haber);
            this.Controls.Add(this.Lbl_Debe);
            this.Controls.Add(this.Lbl_saldoact);
            this.Controls.Add(this.Txt_saldoH);
            this.Controls.Add(this.Txt_saldoD);
            this.Controls.Add(this.Lbl_totabonos);
            this.Controls.Add(this.Lbl_totalhaber);
            this.Controls.Add(this.Lbl_totcargos);
            this.Controls.Add(this.Lbl_Totaldebe);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Lbl_mes);
            this.Controls.Add(this.Cbo_mes);
            this.Controls.Add(this.Lbl_Tituloconsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultasCierre";
            this.Load += new System.EventHandler(this.PartidaCierre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_abonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_totabonos;
        private System.Windows.Forms.Label Lbl_totalhaber;
        private System.Windows.Forms.Label Lbl_totcargos;
        private System.Windows.Forms.Label Lbl_Totaldebe;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Label Lbl_mes;
        private System.Windows.Forms.ComboBox Cbo_mes;
        private System.Windows.Forms.Label Lbl_Tituloconsulta;
        private System.Windows.Forms.Label Lbl_saldoact;
        private System.Windows.Forms.TextBox Txt_saldoH;
        private System.Windows.Forms.TextBox Txt_saldoD;
        public System.Windows.Forms.DataGridView Dgv_cargos;
        public System.Windows.Forms.DataGridView Dgv_abonos;
        private System.Windows.Forms.Label Lbl_haber;
        private System.Windows.Forms.Label Lbl_Debe;
        private System.Windows.Forms.TextBox Txt_saldofinal;
        public System.Windows.Forms.ComboBox Cbo_cuenta;
        private System.Windows.Forms.Label Lbl_cuenta;
        private System.Windows.Forms.TextBox Txt_saldoant;
        private System.Windows.Forms.Label Lbl_saldoant;
        public System.Windows.Forms.ComboBox Cbo_consultaAño;
        private System.Windows.Forms.Label Lbl_año;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_ayuda1;
        private System.Windows.Forms.Button Btn_reporte;
    }
}