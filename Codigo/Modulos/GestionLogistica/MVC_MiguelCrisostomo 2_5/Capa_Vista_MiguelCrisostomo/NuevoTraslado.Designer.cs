
namespace Capa_Vista_MiguelCrisostomo
{
    partial class NuevoTraslado
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
            this.Cbo_Sucursal = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cbo_Sucursal
            // 
            this.Cbo_Sucursal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Sucursal.FormattingEnabled = true;
            this.Cbo_Sucursal.Location = new System.Drawing.Point(19, 32);
            this.Cbo_Sucursal.Name = "Cbo_Sucursal";
            this.Cbo_Sucursal.Size = new System.Drawing.Size(203, 31);
            this.Cbo_Sucursal.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cbo_Sucursal);
            this.groupBox1.Location = new System.Drawing.Point(347, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUCURSAL";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NuevoTraslado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1041, 524);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevoTraslado";
            this.Text = "NuevoTraslado";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_Sucursal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}