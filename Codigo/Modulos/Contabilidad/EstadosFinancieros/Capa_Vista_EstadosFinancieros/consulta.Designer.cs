
namespace Capa_Vista_EstadosFinancieros
{
    partial class consulta
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
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.DGV_prueba = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_prueba)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Location = new System.Drawing.Point(566, 74);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Consultar.TabIndex = 0;
            this.Btn_Consultar.Text = "button1";
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // DGV_prueba
            // 
            this.DGV_prueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_prueba.Location = new System.Drawing.Point(87, 176);
            this.DGV_prueba.Name = "DGV_prueba";
            this.DGV_prueba.Size = new System.Drawing.Size(615, 262);
            this.DGV_prueba.TabIndex = 1;
            // 
            // consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_prueba);
            this.Controls.Add(this.Btn_Consultar);
            this.Name = "consulta";
            this.Text = "consulta";
            this.Load += new System.EventHandler(this.consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_prueba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.DataGridView DGV_prueba;
    }
}