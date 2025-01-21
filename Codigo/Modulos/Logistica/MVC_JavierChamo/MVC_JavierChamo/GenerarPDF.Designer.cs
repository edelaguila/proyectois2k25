
namespace MVC_JavierChamo
{
    partial class GenerarPDF
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
            this.components = new System.ComponentModel.Container();
            this.Btn_pdf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID_mantenimiento = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Btn_pdf
            // 
            this.Btn_pdf.Location = new System.Drawing.Point(444, 65);
            this.Btn_pdf.Name = "Btn_pdf";
            this.Btn_pdf.Size = new System.Drawing.Size(152, 23);
            this.Btn_pdf.TabIndex = 8;
            this.Btn_pdf.Text = "Generar PDF";
            this.toolTip1.SetToolTip(this.Btn_pdf, "Generar");
            this.Btn_pdf.UseVisualStyleBackColor = true;
            this.Btn_pdf.Click += new System.EventHandler(this.btn_generarPDF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID de la Solicitud de Mantenimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generar PDF de Solicitud";
            // 
            // txtID_mantenimiento
            // 
            this.txtID_mantenimiento.Location = new System.Drawing.Point(261, 68);
            this.txtID_mantenimiento.Name = "txtID_mantenimiento";
            this.txtID_mantenimiento.Size = new System.Drawing.Size(161, 20);
            this.txtID_mantenimiento.TabIndex = 5;
            // 
            // GenerarPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(726, 135);
            this.Controls.Add(this.Btn_pdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID_mantenimiento);
            this.Name = "GenerarPDF";
            this.Text = "GenerarPDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_pdf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID_mantenimiento;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}