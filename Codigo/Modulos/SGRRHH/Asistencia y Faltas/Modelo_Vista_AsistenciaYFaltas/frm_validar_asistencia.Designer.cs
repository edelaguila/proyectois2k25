
namespace Modelo_Vista_AsistenciaYFaltas
{
    partial class frm_validar_asistencia
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
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.dgvValidacion = new System.Windows.Forms.DataGridView();
            this.btnNoDescontarSeptimo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMes
            // 
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(210, 90);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(121, 24);
            this.cboMes.TabIndex = 0;
            // 
            // cboAnio
            // 
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(431, 90);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(121, 24);
            this.cboAnio.TabIndex = 1;
            // 
            // dgvValidacion
            // 
            this.dgvValidacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvValidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValidacion.Location = new System.Drawing.Point(-3, 261);
            this.dgvValidacion.Name = "dgvValidacion";
            this.dgvValidacion.RowHeadersWidth = 51;
            this.dgvValidacion.RowTemplate.Height = 24;
            this.dgvValidacion.Size = new System.Drawing.Size(834, 196);
            this.dgvValidacion.TabIndex = 3;
            // 
            // btnNoDescontarSeptimo
            // 
            this.btnNoDescontarSeptimo.Location = new System.Drawing.Point(274, 143);
            this.btnNoDescontarSeptimo.Name = "btnNoDescontarSeptimo";
            this.btnNoDescontarSeptimo.Size = new System.Drawing.Size(101, 89);
            this.btnNoDescontarSeptimo.TabIndex = 4;
            this.btnNoDescontarSeptimo.Text = "No Descontar el Septimo";
            this.btnNoDescontarSeptimo.UseVisualStyleBackColor = true;
            this.btnNoDescontarSeptimo.Click += new System.EventHandler(this.btnNoDescontarSeptimo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Año";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Image = global::Modelo_Vista_AsistenciaYFaltas.Properties.Resources.icon__3_1;
            this.Btn_Buscar.Location = new System.Drawing.Point(565, 143);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(92, 89);
            this.Btn_Buscar.TabIndex = 8;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Image = global::Modelo_Vista_AsistenciaYFaltas.Properties.Resources.icon__8_;
            this.btnInsertar.Location = new System.Drawing.Point(432, 143);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 89);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Image = global::Modelo_Vista_AsistenciaYFaltas.Properties.Resources.icon__1_;
            this.btnCargar.Location = new System.Drawing.Point(133, 143);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(95, 89);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click_1);
            // 
            // frm_validar_asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnNoDescontarSeptimo);
            this.Controls.Add(this.dgvValidacion);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.cboMes);
            this.Name = "frm_validar_asistencia";
            this.Text = "16002-ImportarAsistencia";
            this.Load += new System.EventHandler(this.frm_validar_asistencia_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvValidacion;
        private System.Windows.Forms.Button btnNoDescontarSeptimo;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}