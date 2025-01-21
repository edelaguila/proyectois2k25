
namespace Capa_Vista_PercepcionesDeducciones
{
    partial class frm_generacionpercepciones
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
            this.Lbl_percepciones = new System.Windows.Forms.Label();
            this.Dgv_genpercepciones = new System.Windows.Forms.DataGridView();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_reportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_genpercepciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_percepciones
            // 
            this.Lbl_percepciones.AutoSize = true;
            this.Lbl_percepciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_percepciones.Location = new System.Drawing.Point(409, 28);
            this.Lbl_percepciones.Name = "Lbl_percepciones";
            this.Lbl_percepciones.Size = new System.Drawing.Size(366, 32);
            this.Lbl_percepciones.TabIndex = 0;
            this.Lbl_percepciones.Text = "Generación Percepciones";
            // 
            // Dgv_genpercepciones
            // 
            this.Dgv_genpercepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_genpercepciones.Location = new System.Drawing.Point(28, 105);
            this.Dgv_genpercepciones.Name = "Dgv_genpercepciones";
            this.Dgv_genpercepciones.RowHeadersWidth = 51;
            this.Dgv_genpercepciones.RowTemplate.Height = 24;
            this.Dgv_genpercepciones.Size = new System.Drawing.Size(1128, 411);
            this.Dgv_genpercepciones.TabIndex = 1;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(161)))), ((int)(((byte)(214)))));
            this.Btn_ayuda.BackgroundImage = global::Capa_Vista_PercepcionesDeducciones.Properties.Resources.preguntas__1_;
            this.Btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Location = new System.Drawing.Point(1081, 17);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(71, 65);
            this.Btn_ayuda.TabIndex = 285;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_reportes
            // 
            this.Btn_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(161)))), ((int)(((byte)(214)))));
            this.Btn_reportes.BackgroundImage = global::Capa_Vista_PercepcionesDeducciones.Properties.Resources.reporte;
            this.Btn_reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_reportes.FlatAppearance.BorderSize = 0;
            this.Btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reportes.Location = new System.Drawing.Point(1010, 17);
            this.Btn_reportes.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_reportes.Name = "Btn_reportes";
            this.Btn_reportes.Size = new System.Drawing.Size(71, 65);
            this.Btn_reportes.TabIndex = 287;
            this.Btn_reportes.UseVisualStyleBackColor = false;
            this.Btn_reportes.Click += new System.EventHandler(this.Btn_reportes_Click);
            // 
            // frm_generacionpercepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(161)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1182, 541);
            this.Controls.Add(this.Btn_reportes);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Dgv_genpercepciones);
            this.Controls.Add(this.Lbl_percepciones);
            this.Name = "frm_generacionpercepciones";
            this.Text = "Generación Percepciones";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_genpercepciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_percepciones;
        private System.Windows.Forms.DataGridView Dgv_genpercepciones;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_reportes;
    }
}