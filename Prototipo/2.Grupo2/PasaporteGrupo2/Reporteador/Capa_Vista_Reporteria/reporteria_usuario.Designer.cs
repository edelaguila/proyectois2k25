
namespace Capa_Vista_Reporteria
{
    partial class reporteria_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reporteria_usuario));
            this.Nombre = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_VerReporte = new System.Windows.Forms.Button();
            this.Dgv_Regreporteria = new System.Windows.Forms.DataGridView();
            this.Txt_ruta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Regreporteria)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(61, 14);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(81, 25);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(150, 18);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(239, 22);
            this.Txt_nombre.TabIndex = 1;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(397, 10);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(37, 40);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_VerReporte
            // 
            this.Btn_VerReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_VerReporte.Enabled = false;
            this.Btn_VerReporte.FlatAppearance.BorderSize = 0;
            this.Btn_VerReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_VerReporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_VerReporte.Image")));
            this.Btn_VerReporte.Location = new System.Drawing.Point(653, 9);
            this.Btn_VerReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_VerReporte.Name = "Btn_VerReporte";
            this.Btn_VerReporte.Size = new System.Drawing.Size(38, 40);
            this.Btn_VerReporte.TabIndex = 3;
            this.Btn_VerReporte.UseVisualStyleBackColor = true;
            this.Btn_VerReporte.Click += new System.EventHandler(this.Btn_VerReporte_Click);
            // 
            // Dgv_Regreporteria
            // 
            this.Dgv_Regreporteria.AllowUserToAddRows = false;
            this.Dgv_Regreporteria.AllowUserToDeleteRows = false;
            this.Dgv_Regreporteria.AllowUserToOrderColumns = true;
            this.Dgv_Regreporteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Regreporteria.Location = new System.Drawing.Point(54, 61);
            this.Dgv_Regreporteria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgv_Regreporteria.Name = "Dgv_Regreporteria";
            this.Dgv_Regreporteria.ReadOnly = true;
            this.Dgv_Regreporteria.RowHeadersWidth = 62;
            this.Dgv_Regreporteria.Size = new System.Drawing.Size(789, 418);
            this.Dgv_Regreporteria.TabIndex = 8;
            this.Dgv_Regreporteria.DoubleClick += new System.EventHandler(this.tabla_registro_DoubleClick);
            // 
            // Txt_ruta
            // 
            this.Txt_ruta.Location = new System.Drawing.Point(467, 18);
            this.Txt_ruta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_ruta.Name = "Txt_ruta";
            this.Txt_ruta.Size = new System.Drawing.Size(179, 22);
            this.Txt_ruta.TabIndex = 9;
            // 
            // reporteria_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(177)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(909, 492);
            this.Controls.Add(this.Txt_ruta);
            this.Controls.Add(this.Dgv_Regreporteria);
            this.Controls.Add(this.Btn_VerReporte);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Nombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "reporteria_usuario";
            this.Text = "reporteria_usuario";
            this.Load += new System.EventHandler(this.reporteria_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Regreporteria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_VerReporte;
        private System.Windows.Forms.DataGridView Dgv_Regreporteria;
        private System.Windows.Forms.TextBox Txt_ruta;
    }
}