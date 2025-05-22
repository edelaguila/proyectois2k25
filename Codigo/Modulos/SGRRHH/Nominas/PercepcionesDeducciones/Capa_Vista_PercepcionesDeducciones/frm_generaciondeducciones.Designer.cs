
namespace Capa_Vista_PercepcionesDeducciones
{
    partial class frm_generaciondeducciones
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
            this.Dgv_gendeducciones = new System.Windows.Forms.DataGridView();
            this.Lbl_deducciones = new System.Windows.Forms.Label();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_reportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_gendeducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_gendeducciones
            // 
            this.Dgv_gendeducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_gendeducciones.Location = new System.Drawing.Point(28, 105);
            this.Dgv_gendeducciones.Name = "Dgv_gendeducciones";
            this.Dgv_gendeducciones.RowHeadersWidth = 51;
            this.Dgv_gendeducciones.RowTemplate.Height = 24;
            this.Dgv_gendeducciones.Size = new System.Drawing.Size(1128, 411);
            this.Dgv_gendeducciones.TabIndex = 3;
            // 
            // Lbl_deducciones
            // 
            this.Lbl_deducciones.AutoSize = true;
            this.Lbl_deducciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_deducciones.Location = new System.Drawing.Point(409, 28);
            this.Lbl_deducciones.Name = "Lbl_deducciones";
            this.Lbl_deducciones.Size = new System.Drawing.Size(357, 32);
            this.Lbl_deducciones.TabIndex = 4;
            this.Lbl_deducciones.Text = "Generación Deducciones";
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
            this.Btn_ayuda.TabIndex = 286;
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
            this.Btn_reportes.TabIndex = 288;
            this.Btn_reportes.UseVisualStyleBackColor = false;
            this.Btn_reportes.Click += new System.EventHandler(this.Btn_reportes_Click);
            // 
            // frm_generaciondeducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(161)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1182, 541);
            this.Controls.Add(this.Btn_reportes);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Lbl_deducciones);
            this.Controls.Add(this.Dgv_gendeducciones);
            this.Name = "frm_generaciondeducciones";
            this.Text = "Generación Deducciones";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_gendeducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_gendeducciones;
        private System.Windows.Forms.Label Lbl_deducciones;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_reportes;
    }
}