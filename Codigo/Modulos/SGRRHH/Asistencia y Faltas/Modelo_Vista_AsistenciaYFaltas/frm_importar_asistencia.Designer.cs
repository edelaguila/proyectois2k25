
namespace Modelo_Vista_AsistenciaYFaltas
{
    partial class frm_importar_asistencia
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
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.Txt_importar = new System.Windows.Forms.TextBox();
            this.txt_RutaArchivo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_importar = new System.Windows.Forms.Button();
            this.btn_examinar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAsistencias.Location = new System.Drawing.Point(0, 285);
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.RowHeadersWidth = 51;
            this.dgvAsistencias.RowTemplate.Height = 24;
            this.dgvAsistencias.Size = new System.Drawing.Size(819, 209);
            this.dgvAsistencias.TabIndex = 1;
            // 
            // Txt_importar
            // 
            this.Txt_importar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_importar.Location = new System.Drawing.Point(142, 168);
            this.Txt_importar.Name = "Txt_importar";
            this.Txt_importar.Size = new System.Drawing.Size(489, 22);
            this.Txt_importar.TabIndex = 3;
            // 
            // txt_RutaArchivo
            // 
            this.txt_RutaArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RutaArchivo.AutoSize = true;
            this.txt_RutaArchivo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RutaArchivo.Location = new System.Drawing.Point(44, 167);
            this.txt_RutaArchivo.Name = "txt_RutaArchivo";
            this.txt_RutaArchivo.Size = new System.Drawing.Size(78, 22);
            this.txt_RutaArchivo.TabIndex = 4;
            this.txt_RutaArchivo.Text = "Importar";
            // 
            // button1
            // 
            this.button1.Image = global::Modelo_Vista_AsistenciaYFaltas.Properties.Resources.icon__3_;
            this.button1.Location = new System.Drawing.Point(662, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 77);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Image = global::Modelo_Vista_AsistenciaYFaltas.Properties.Resources.icon__2_;
            this.btn_ayuda.Location = new System.Drawing.Point(744, 12);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(75, 77);
            this.btn_ayuda.TabIndex = 6;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // btn_importar
            // 
            this.btn_importar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_importar.Image = global::Modelo_Vista_AsistenciaYFaltas.Properties.Resources.icon__8_;
            this.btn_importar.Location = new System.Drawing.Point(12, 26);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(88, 79);
            this.btn_importar.TabIndex = 5;
            this.btn_importar.UseVisualStyleBackColor = true;
            // 
            // btn_examinar
            // 
            this.btn_examinar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_examinar.Image = global::Modelo_Vista_AsistenciaYFaltas.Properties.Resources.icon__1_;
            this.btn_examinar.Location = new System.Drawing.Point(662, 140);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(90, 79);
            this.btn_examinar.TabIndex = 2;
            this.btn_examinar.UseVisualStyleBackColor = true;
            // 
            // frm_importar_asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(819, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_importar);
            this.Controls.Add(this.txt_RutaArchivo);
            this.Controls.Add(this.Txt_importar);
            this.Controls.Add(this.btn_examinar);
            this.Controls.Add(this.dgvAsistencias);
            this.Name = "frm_importar_asistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "16002-Importar Asistencia";
            this.Load += new System.EventHandler(this.frm_importar_asistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.TextBox Txt_importar;
        private System.Windows.Forms.Label txt_RutaArchivo;
        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button button1;
    }
}