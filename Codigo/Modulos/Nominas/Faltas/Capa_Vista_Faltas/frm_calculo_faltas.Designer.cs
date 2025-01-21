
namespace Capa_Vista_Faltas
{
    partial class frm_calculo_faltas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_calculo_faltas));
            this.Btn_Calculo_Falta = new System.Windows.Forms.Button();
            this.Cbo_Empleados = new System.Windows.Forms.ComboBox();
            this.Dgv_Faltas = new System.Windows.Forms.DataGridView();
            this.Cbo_Mes = new System.Windows.Forms.ComboBox();
            this.Lbl_Empleados = new System.Windows.Forms.Label();
            this.Lbl_Mes = new System.Windows.Forms.Label();
            this.Lbl_ControlFaltas = new System.Windows.Forms.Label();
            this.Btn_Reportes = new System.Windows.Forms.Button();
            this.Btn_Ayudas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Faltas)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Calculo_Falta
            // 
            this.Btn_Calculo_Falta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Calculo_Falta.Location = new System.Drawing.Point(546, 150);
            this.Btn_Calculo_Falta.Name = "Btn_Calculo_Falta";
            this.Btn_Calculo_Falta.Size = new System.Drawing.Size(190, 34);
            this.Btn_Calculo_Falta.TabIndex = 0;
            this.Btn_Calculo_Falta.Text = "Calcular faltas";
            this.Btn_Calculo_Falta.UseVisualStyleBackColor = true;
            this.Btn_Calculo_Falta.Click += new System.EventHandler(this.Btn_Calculo_Falta_Click_1);
            // 
            // Cbo_Empleados
            // 
            this.Cbo_Empleados.FormattingEnabled = true;
            this.Cbo_Empleados.Location = new System.Drawing.Point(81, 157);
            this.Cbo_Empleados.Name = "Cbo_Empleados";
            this.Cbo_Empleados.Size = new System.Drawing.Size(121, 24);
            this.Cbo_Empleados.TabIndex = 1;
            this.Cbo_Empleados.SelectedIndexChanged += new System.EventHandler(this.Cbo_Empleados_SelectedIndexChanged);
            // 
            // Dgv_Faltas
            // 
            this.Dgv_Faltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Faltas.Location = new System.Drawing.Point(12, 241);
            this.Dgv_Faltas.Name = "Dgv_Faltas";
            this.Dgv_Faltas.RowHeadersWidth = 51;
            this.Dgv_Faltas.RowTemplate.Height = 24;
            this.Dgv_Faltas.Size = new System.Drawing.Size(982, 197);
            this.Dgv_Faltas.TabIndex = 2;
            this.Dgv_Faltas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Faltas_CellContentClick);
            // 
            // Cbo_Mes
            // 
            this.Cbo_Mes.FormattingEnabled = true;
            this.Cbo_Mes.Location = new System.Drawing.Point(313, 157);
            this.Cbo_Mes.Name = "Cbo_Mes";
            this.Cbo_Mes.Size = new System.Drawing.Size(121, 24);
            this.Cbo_Mes.TabIndex = 3;
            // 
            // Lbl_Empleados
            // 
            this.Lbl_Empleados.AutoSize = true;
            this.Lbl_Empleados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Empleados.Location = new System.Drawing.Point(77, 121);
            this.Lbl_Empleados.Name = "Lbl_Empleados";
            this.Lbl_Empleados.Size = new System.Drawing.Size(101, 23);
            this.Lbl_Empleados.TabIndex = 4;
            this.Lbl_Empleados.Text = "Empleados";
            // 
            // Lbl_Mes
            // 
            this.Lbl_Mes.AutoSize = true;
            this.Lbl_Mes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mes.Location = new System.Drawing.Point(348, 121);
            this.Lbl_Mes.Name = "Lbl_Mes";
            this.Lbl_Mes.Size = new System.Drawing.Size(46, 23);
            this.Lbl_Mes.TabIndex = 5;
            this.Lbl_Mes.Text = "Mes";
            // 
            // Lbl_ControlFaltas
            // 
            this.Lbl_ControlFaltas.AutoSize = true;
            this.Lbl_ControlFaltas.Font = new System.Drawing.Font("Haettenschweiler", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ControlFaltas.Location = new System.Drawing.Point(344, 37);
            this.Lbl_ControlFaltas.Name = "Lbl_ControlFaltas";
            this.Lbl_ControlFaltas.Size = new System.Drawing.Size(361, 44);
            this.Lbl_ControlFaltas.TabIndex = 6;
            this.Lbl_ControlFaltas.Text = "Calculo del Valor de Faltas";
            this.Lbl_ControlFaltas.Click += new System.EventHandler(this.Lbl_ControlFaltas_Click);
            // 
            // Btn_Reportes
            // 
            this.Btn_Reportes.BackgroundImage = global::Capa_Vista_Faltas.Properties.Resources.reporte_falta;
            this.Btn_Reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Reportes.Location = new System.Drawing.Point(898, 12);
            this.Btn_Reportes.Name = "Btn_Reportes";
            this.Btn_Reportes.Size = new System.Drawing.Size(59, 57);
            this.Btn_Reportes.TabIndex = 8;
            this.Btn_Reportes.UseVisualStyleBackColor = true;
            this.Btn_Reportes.Click += new System.EventHandler(this.Btn_Reportes_Click);
            // 
            // Btn_Ayudas
            // 
            this.Btn_Ayudas.BackgroundImage = global::Capa_Vista_Faltas.Properties.Resources.icon_ayuda1;
            this.Btn_Ayudas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Ayudas.Location = new System.Drawing.Point(963, 12);
            this.Btn_Ayudas.Name = "Btn_Ayudas";
            this.Btn_Ayudas.Size = new System.Drawing.Size(60, 57);
            this.Btn_Ayudas.TabIndex = 7;
            this.Btn_Ayudas.UseVisualStyleBackColor = true;
            this.Btn_Ayudas.Click += new System.EventHandler(this.Btn_Ayudas_Click);
            // 
            // frm_calculo_faltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(161)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.Btn_Reportes);
            this.Controls.Add(this.Btn_Ayudas);
            this.Controls.Add(this.Lbl_ControlFaltas);
            this.Controls.Add(this.Lbl_Mes);
            this.Controls.Add(this.Lbl_Empleados);
            this.Controls.Add(this.Cbo_Mes);
            this.Controls.Add(this.Dgv_Faltas);
            this.Controls.Add(this.Cbo_Empleados);
            this.Controls.Add(this.Btn_Calculo_Falta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_calculo_faltas";
            this.Text = "Calculo de Faltas";
            this.Load += new System.EventHandler(this.frm_calculo_faltas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Faltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Calculo_Falta;
        private System.Windows.Forms.ComboBox Cbo_Empleados;
        private System.Windows.Forms.DataGridView Dgv_Faltas;
        private System.Windows.Forms.ComboBox Cbo_Mes;
        private System.Windows.Forms.Label Lbl_Empleados;
        private System.Windows.Forms.Label Lbl_Mes;
        private System.Windows.Forms.Label Lbl_ControlFaltas;
        private System.Windows.Forms.Button Btn_Ayudas;
        private System.Windows.Forms.Button Btn_Reportes;
    }
}