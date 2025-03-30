
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtRutaArchivo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importacion de Asitencia";
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Location = new System.Drawing.Point(3, 301);
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.RowHeadersWidth = 51;
            this.dgvAsistencias.RowTemplate.Height = 24;
            this.dgvAsistencias.Size = new System.Drawing.Size(799, 190);
            this.dgvAsistencias.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 22);
            this.textBox1.TabIndex = 3;
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.AutoSize = true;
            this.txtRutaArchivo.Location = new System.Drawing.Point(84, 142);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(60, 17);
            this.txtRutaArchivo.TabIndex = 4;
            this.txtRutaArchivo.Text = "Importar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Importar Asistencia";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frm_importar_asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 492);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAsistencias);
            this.Controls.Add(this.label1);
            this.Name = "frm_importar_asistencia";
            this.Text = "frm_importar_asistencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtRutaArchivo;
        private System.Windows.Forms.Button button2;
    }
}