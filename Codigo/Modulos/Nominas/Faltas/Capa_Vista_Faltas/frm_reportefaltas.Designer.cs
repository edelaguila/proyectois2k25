
namespace Capa_Vista_Faltas
{
    partial class frm_reportefaltas
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
            this.Gbo_filtros = new System.Windows.Forms.GroupBox();
            this.Btn_generar = new System.Windows.Forms.Button();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.Cbo_reportemes = new System.Windows.Forms.ComboBox();
            this.Gbo_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbo_filtros
            // 
            this.Gbo_filtros.Controls.Add(this.Btn_generar);
            this.Gbo_filtros.Controls.Add(this.lbl_mes);
            this.Gbo_filtros.Controls.Add(this.Cbo_reportemes);
            this.Gbo_filtros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbo_filtros.Location = new System.Drawing.Point(90, 94);
            this.Gbo_filtros.Name = "Gbo_filtros";
            this.Gbo_filtros.Size = new System.Drawing.Size(666, 211);
            this.Gbo_filtros.TabIndex = 12;
            this.Gbo_filtros.TabStop = false;
            this.Gbo_filtros.Text = "Filtros";
            // 
            // Btn_generar
            // 
            this.Btn_generar.BackgroundImage = global::Capa_Vista_Faltas.Properties.Resources.reporte_falta;
            this.Btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_generar.FlatAppearance.BorderSize = 0;
            this.Btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_generar.Location = new System.Drawing.Point(517, 77);
            this.Btn_generar.Name = "Btn_generar";
            this.Btn_generar.Size = new System.Drawing.Size(75, 69);
            this.Btn_generar.TabIndex = 5;
            this.Btn_generar.UseVisualStyleBackColor = true;
            this.Btn_generar.Click += new System.EventHandler(this.Btn_generar_Click);
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.Location = new System.Drawing.Point(121, 77);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(159, 22);
            this.lbl_mes.TabIndex = 4;
            this.lbl_mes.Text = "Seleccione un Mes";
            // 
            // Cbo_reportemes
            // 
            this.Cbo_reportemes.FormattingEnabled = true;
            this.Cbo_reportemes.Location = new System.Drawing.Point(69, 112);
            this.Cbo_reportemes.Name = "Cbo_reportemes";
            this.Cbo_reportemes.Size = new System.Drawing.Size(323, 30);
            this.Cbo_reportemes.TabIndex = 3;
            this.Cbo_reportemes.SelectedIndexChanged += new System.EventHandler(this.Cbo_reportemes_SelectedIndexChanged);
            // 
            // frm_reportefaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(161)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(850, 411);
            this.Controls.Add(this.Gbo_filtros);
            this.Name = "frm_reportefaltas";
            this.Text = "frm_reportefaltas";
            this.Load += new System.EventHandler(this.frm_reportefaltas_Load);
            this.Gbo_filtros.ResumeLayout(false);
            this.Gbo_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Gbo_filtros;
        private System.Windows.Forms.Button Btn_generar;
        private System.Windows.Forms.Label lbl_mes;
        private System.Windows.Forms.ComboBox Cbo_reportemes;
    }
}