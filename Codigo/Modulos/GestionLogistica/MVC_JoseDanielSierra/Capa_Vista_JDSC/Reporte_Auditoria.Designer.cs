
namespace Capa_Vista_JDSC
{
    partial class Reporte_Auditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Auditoria));
            this.Txt_IDAuditoria = new System.Windows.Forms.TextBox();
            this.Btn_GenerarReporte = new System.Windows.Forms.Button();
            this.LBL_IDAuditoria = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_ReporteGeneral = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_IDAuditoria
            // 
            this.Txt_IDAuditoria.Location = new System.Drawing.Point(125, 53);
            this.Txt_IDAuditoria.Name = "Txt_IDAuditoria";
            this.Txt_IDAuditoria.Size = new System.Drawing.Size(47, 26);
            this.Txt_IDAuditoria.TabIndex = 0;
            // 
            // Btn_GenerarReporte
            // 
            this.Btn_GenerarReporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_GenerarReporte.FlatAppearance.BorderSize = 0;
            this.Btn_GenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GenerarReporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_GenerarReporte.Image")));
            this.Btn_GenerarReporte.Location = new System.Drawing.Point(178, 19);
            this.Btn_GenerarReporte.Name = "Btn_GenerarReporte";
            this.Btn_GenerarReporte.Size = new System.Drawing.Size(93, 81);
            this.Btn_GenerarReporte.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Btn_GenerarReporte, "Reporte Auditoria PDF");
            this.Btn_GenerarReporte.UseVisualStyleBackColor = false;
            this.Btn_GenerarReporte.Click += new System.EventHandler(this.Btn_GenerarReporte_Click);
            // 
            // LBL_IDAuditoria
            // 
            this.LBL_IDAuditoria.AutoSize = true;
            this.LBL_IDAuditoria.Location = new System.Drawing.Point(32, 56);
            this.LBL_IDAuditoria.Name = "LBL_IDAuditoria";
            this.LBL_IDAuditoria.Size = new System.Drawing.Size(87, 19);
            this.LBL_IDAuditoria.TabIndex = 2;
            this.LBL_IDAuditoria.Text = "ID Auditoria:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_GenerarReporte);
            this.groupBox1.Controls.Add(this.LBL_IDAuditoria);
            this.groupBox1.Controls.Add(this.Txt_IDAuditoria);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar Reporte de una Auditoria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_ReporteGeneral);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(334, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 127);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar Reporte General de Auditoria";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Btn_ReporteGeneral
            // 
            this.Btn_ReporteGeneral.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ReporteGeneral.FlatAppearance.BorderSize = 0;
            this.Btn_ReporteGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ReporteGeneral.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ReporteGeneral.Image")));
            this.Btn_ReporteGeneral.Location = new System.Drawing.Point(90, 25);
            this.Btn_ReporteGeneral.Name = "Btn_ReporteGeneral";
            this.Btn_ReporteGeneral.Size = new System.Drawing.Size(93, 81);
            this.Btn_ReporteGeneral.TabIndex = 1;
            this.toolTip2.SetToolTip(this.Btn_ReporteGeneral, "Reporte Auditorias");
            this.Btn_ReporteGeneral.UseVisualStyleBackColor = false;
            this.Btn_ReporteGeneral.Click += new System.EventHandler(this.Btn_ReporteGeneral_Click);
            // 
            // Reporte_Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(635, 180);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reporte_Auditoria";
            this.Text = "Reporte_Auditoria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_IDAuditoria;
        private System.Windows.Forms.Button Btn_GenerarReporte;
        private System.Windows.Forms.Label LBL_IDAuditoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_ReporteGeneral;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}