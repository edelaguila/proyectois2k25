
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Enlaces
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
            this.Dgv_FechaInicio = new System.Windows.Forms.Label();
            this.Dgv_FechaFin = new System.Windows.Forms.Label();
            this.lbl_NoPoliza = new System.Windows.Forms.Label();
            this.lbl_concepto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_FechaInicio
            // 
            this.Dgv_FechaInicio.AutoSize = true;
            this.Dgv_FechaInicio.Location = new System.Drawing.Point(87, 113);
            this.Dgv_FechaInicio.Name = "Dgv_FechaInicio";
            this.Dgv_FechaInicio.Size = new System.Drawing.Size(87, 17);
            this.Dgv_FechaInicio.TabIndex = 0;
            this.Dgv_FechaInicio.Text = "Fecha Inicio:";
            // 
            // Dgv_FechaFin
            // 
            this.Dgv_FechaFin.AutoSize = true;
            this.Dgv_FechaFin.Location = new System.Drawing.Point(429, 113);
            this.Dgv_FechaFin.Name = "Dgv_FechaFin";
            this.Dgv_FechaFin.Size = new System.Drawing.Size(74, 17);
            this.Dgv_FechaFin.TabIndex = 1;
            this.Dgv_FechaFin.Text = "Fecha Fin:";
            // 
            // lbl_NoPoliza
            // 
            this.lbl_NoPoliza.AutoSize = true;
            this.lbl_NoPoliza.Location = new System.Drawing.Point(98, 171);
            this.lbl_NoPoliza.Name = "lbl_NoPoliza";
            this.lbl_NoPoliza.Size = new System.Drawing.Size(76, 17);
            this.lbl_NoPoliza.TabIndex = 2;
            this.lbl_NoPoliza.Text = "No. Poliza:";
            // 
            // lbl_concepto
            // 
            this.lbl_concepto.AutoSize = true;
            this.lbl_concepto.Location = new System.Drawing.Point(102, 207);
            this.lbl_concepto.Name = "lbl_concepto";
            this.lbl_concepto.Size = new System.Drawing.Size(72, 17);
            this.lbl_concepto.TabIndex = 3;
            this.lbl_concepto.Text = "Concepto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 22);
            this.textBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(509, 108);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 158);
            this.dataGridView1.TabIndex = 8;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(278, 32);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(307, 34);
            this.lbl_titulo.TabIndex = 9;
            this.lbl_titulo.Text = "ENLACE CONTABLE";
            // 
            // Enlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(910, 440);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_concepto);
            this.Controls.Add(this.lbl_NoPoliza);
            this.Controls.Add(this.Dgv_FechaFin);
            this.Controls.Add(this.Dgv_FechaInicio);
            this.Name = "Enlaces";
            this.Text = "Enlaces";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dgv_FechaInicio;
        private System.Windows.Forms.Label Dgv_FechaFin;
        private System.Windows.Forms.Label lbl_NoPoliza;
        private System.Windows.Forms.Label lbl_concepto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_titulo;
    }
}