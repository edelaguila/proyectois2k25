
namespace Capa_Vista_HorasExtras
{
    partial class frm_horasextra
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
            this.Lbl_mes = new System.Windows.Forms.Label();
            this.Cbo_mes = new System.Windows.Forms.ComboBox();
            this.Txt_calculohoras = new System.Windows.Forms.TextBox();
            this.Lbl_calculohoras = new System.Windows.Forms.Label();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_empleado = new System.Windows.Forms.Label();
            this.Cbo_empleado = new System.Windows.Forms.ComboBox();
            this.Btn_reportes = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_mes
            // 
            this.Lbl_mes.AutoSize = true;
            this.Lbl_mes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mes.Location = new System.Drawing.Point(132, 161);
            this.Lbl_mes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_mes.Name = "Lbl_mes";
            this.Lbl_mes.Size = new System.Drawing.Size(44, 22);
            this.Lbl_mes.TabIndex = 0;
            this.Lbl_mes.Text = "Mes";
            // 
            // Cbo_mes
            // 
            this.Cbo_mes.FormattingEnabled = true;
            this.Cbo_mes.Location = new System.Drawing.Point(342, 159);
            this.Cbo_mes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_mes.Name = "Cbo_mes";
            this.Cbo_mes.Size = new System.Drawing.Size(158, 24);
            this.Cbo_mes.TabIndex = 1;
            this.Cbo_mes.SelectedIndexChanged += new System.EventHandler(this.proCbo_mes_SelectedIndexChanged);
            // 
            // Txt_calculohoras
            // 
            this.Txt_calculohoras.Location = new System.Drawing.Point(342, 217);
            this.Txt_calculohoras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_calculohoras.Name = "Txt_calculohoras";
            this.Txt_calculohoras.Size = new System.Drawing.Size(158, 22);
            this.Txt_calculohoras.TabIndex = 2;
            this.Txt_calculohoras.TextChanged += new System.EventHandler(this.Txt_calculohoras_TextChanged);
            // 
            // Lbl_calculohoras
            // 
            this.Lbl_calculohoras.AutoSize = true;
            this.Lbl_calculohoras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_calculohoras.Location = new System.Drawing.Point(132, 215);
            this.Lbl_calculohoras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_calculohoras.Name = "Lbl_calculohoras";
            this.Lbl_calculohoras.Size = new System.Drawing.Size(180, 22);
            this.Lbl_calculohoras.TabIndex = 3;
            this.Lbl_calculohoras.Text = "Calculo Horas Extras";
            this.Lbl_calculohoras.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Haettenschweiler", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(65, 18);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(534, 45);
            this.Lbl_titulo.TabIndex = 4;
            this.Lbl_titulo.Text = "Formulario de Calculo de Horas Extras";
            this.Lbl_titulo.Click += new System.EventHandler(this.label3_Click);
            // 
            // Lbl_empleado
            // 
            this.Lbl_empleado.AutoSize = true;
            this.Lbl_empleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_empleado.Location = new System.Drawing.Point(132, 103);
            this.Lbl_empleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_empleado.Name = "Lbl_empleado";
            this.Lbl_empleado.Size = new System.Drawing.Size(90, 22);
            this.Lbl_empleado.TabIndex = 5;
            this.Lbl_empleado.Text = "Empleado";
            // 
            // Cbo_empleado
            // 
            this.Cbo_empleado.FormattingEnabled = true;
            this.Cbo_empleado.Location = new System.Drawing.Point(342, 103);
            this.Cbo_empleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_empleado.Name = "Cbo_empleado";
            this.Cbo_empleado.Size = new System.Drawing.Size(157, 24);
            this.Cbo_empleado.TabIndex = 6;
            this.Cbo_empleado.SelectedIndexChanged += new System.EventHandler(this.proCbo_empleado_SelectedIndexChanged);
            // 
            // Btn_reportes
            // 
            this.Btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_reportes.Image = global::Capa_Vista_HorasExtras.Properties.Resources.reporte;
            this.Btn_reportes.Location = new System.Drawing.Point(136, 285);
            this.Btn_reportes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_reportes.Name = "Btn_reportes";
            this.Btn_reportes.Size = new System.Drawing.Size(62, 57);
            this.Btn_reportes.TabIndex = 8;
            this.Btn_reportes.UseVisualStyleBackColor = true;
            this.Btn_reportes.Click += new System.EventHandler(this.Btn_reportes_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ayuda.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_ayuda.Image = global::Capa_Vista_HorasExtras.Properties.Resources.preguntas1;
            this.Btn_ayuda.Location = new System.Drawing.Point(52, 285);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(62, 57);
            this.Btn_ayuda.TabIndex = 7;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_limpiar.Image = global::Capa_Vista_HorasExtras.Properties.Resources.cancelar;
            this.Btn_limpiar.Location = new System.Drawing.Point(556, 87);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(71, 52);
            this.Btn_limpiar.TabIndex = 11;
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click_1);
            // 
            // frm_horasextra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(668, 387);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_reportes);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Cbo_empleado);
            this.Controls.Add(this.Lbl_empleado);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.Lbl_calculohoras);
            this.Controls.Add(this.Txt_calculohoras);
            this.Controls.Add(this.Cbo_mes);
            this.Controls.Add(this.Lbl_mes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_horasextra";
            this.Text = "Horas Extras";
            this.Load += new System.EventHandler(this.frm_horasextra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_mes;
        private System.Windows.Forms.ComboBox Cbo_mes;
        private System.Windows.Forms.TextBox Txt_calculohoras;
        private System.Windows.Forms.Label Lbl_calculohoras;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_empleado;
        private System.Windows.Forms.ComboBox Cbo_empleado;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_reportes;
        private System.Windows.Forms.Button Btn_limpiar;
    }
}