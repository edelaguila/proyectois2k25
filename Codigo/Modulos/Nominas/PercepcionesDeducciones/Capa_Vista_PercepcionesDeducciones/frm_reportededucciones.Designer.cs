
namespace Capa_Vista_PercepcionesDeducciones
{
    partial class frm_reportededucciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reportededucciones));
            this.Gbo_filtros = new System.Windows.Forms.GroupBox();
            this.Btn_generar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbo_reportesdeducciones = new System.Windows.Forms.ComboBox();
            this.Gbo_sinfiltros = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_general = new System.Windows.Forms.Button();
            this.Chk_filtros = new System.Windows.Forms.CheckBox();
            this.Gbo_filtros.SuspendLayout();
            this.Gbo_sinfiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbo_filtros
            // 
            this.Gbo_filtros.Controls.Add(this.Btn_generar);
            this.Gbo_filtros.Controls.Add(this.label1);
            this.Gbo_filtros.Controls.Add(this.Cbo_reportesdeducciones);
            this.Gbo_filtros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbo_filtros.Location = new System.Drawing.Point(74, 261);
            this.Gbo_filtros.Name = "Gbo_filtros";
            this.Gbo_filtros.Size = new System.Drawing.Size(666, 211);
            this.Gbo_filtros.TabIndex = 4;
            this.Gbo_filtros.TabStop = false;
            this.Gbo_filtros.Text = "Filtros";
            // 
            // Btn_generar
            // 
            this.Btn_generar.BackgroundImage = global::Capa_Vista_PercepcionesDeducciones.Properties.Resources.reporte;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione un departamento";
            // 
            // Cbo_reportesdeducciones
            // 
            this.Cbo_reportesdeducciones.FormattingEnabled = true;
            this.Cbo_reportesdeducciones.Location = new System.Drawing.Point(69, 112);
            this.Cbo_reportesdeducciones.Name = "Cbo_reportesdeducciones";
            this.Cbo_reportesdeducciones.Size = new System.Drawing.Size(323, 30);
            this.Cbo_reportesdeducciones.TabIndex = 3;
            // 
            // Gbo_sinfiltros
            // 
            this.Gbo_sinfiltros.Controls.Add(this.label2);
            this.Gbo_sinfiltros.Controls.Add(this.Btn_general);
            this.Gbo_sinfiltros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbo_sinfiltros.Location = new System.Drawing.Point(74, 33);
            this.Gbo_sinfiltros.Name = "Gbo_sinfiltros";
            this.Gbo_sinfiltros.Size = new System.Drawing.Size(666, 136);
            this.Gbo_sinfiltros.TabIndex = 6;
            this.Gbo_sinfiltros.TabStop = false;
            this.Gbo_sinfiltros.Text = "Sin filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Generar sin filtros";
            // 
            // Btn_general
            // 
            this.Btn_general.BackgroundImage = global::Capa_Vista_PercepcionesDeducciones.Properties.Resources.reporte;
            this.Btn_general.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_general.FlatAppearance.BorderSize = 0;
            this.Btn_general.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_general.Location = new System.Drawing.Point(517, 37);
            this.Btn_general.Name = "Btn_general";
            this.Btn_general.Size = new System.Drawing.Size(75, 69);
            this.Btn_general.TabIndex = 8;
            this.Btn_general.UseVisualStyleBackColor = true;
            this.Btn_general.Click += new System.EventHandler(this.Btn_general_Click);
            // 
            // Chk_filtros
            // 
            this.Chk_filtros.AutoSize = true;
            this.Chk_filtros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_filtros.Location = new System.Drawing.Point(121, 206);
            this.Chk_filtros.Name = "Chk_filtros";
            this.Chk_filtros.Size = new System.Drawing.Size(117, 26);
            this.Chk_filtros.TabIndex = 11;
            this.Chk_filtros.Text = "Con filtros";
            this.Chk_filtros.UseVisualStyleBackColor = true;
            this.Chk_filtros.CheckedChanged += new System.EventHandler(this.Chk_filtros_CheckedChanged);
            // 
            // frm_reportededucciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(161)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.Chk_filtros);
            this.Controls.Add(this.Gbo_sinfiltros);
            this.Controls.Add(this.Gbo_filtros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_reportededucciones";
            this.Text = "Reporte Deducciones";
            this.Load += new System.EventHandler(this.frm_reportededucciones_Load);
            this.Gbo_filtros.ResumeLayout(false);
            this.Gbo_filtros.PerformLayout();
            this.Gbo_sinfiltros.ResumeLayout(false);
            this.Gbo_sinfiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Gbo_filtros;
        private System.Windows.Forms.Button Btn_generar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_reportesdeducciones;
        private System.Windows.Forms.GroupBox Gbo_sinfiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_general;
        private System.Windows.Forms.CheckBox Chk_filtros;
    }
}