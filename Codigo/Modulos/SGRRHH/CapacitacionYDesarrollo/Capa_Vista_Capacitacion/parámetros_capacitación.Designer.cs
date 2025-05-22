
namespace Capa_Vista_Capacitacion
{
    partial class parámetros_capacitación
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
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudAumento = new System.Windows.Forms.NumericUpDown();
            this.nudNeutro = new System.Windows.Forms.NumericUpDown();
            this.Btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeutro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(57, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(115, 24);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "Parámetros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aumento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Neutro";
            // 
            // nudAumento
            // 
            this.nudAumento.Location = new System.Drawing.Point(129, 52);
            this.nudAumento.Name = "nudAumento";
            this.nudAumento.Size = new System.Drawing.Size(67, 20);
            this.nudAumento.TabIndex = 14;
            // 
            // nudNeutro
            // 
            this.nudNeutro.Location = new System.Drawing.Point(129, 123);
            this.nudNeutro.Name = "nudNeutro";
            this.nudNeutro.Size = new System.Drawing.Size(67, 20);
            this.nudNeutro.TabIndex = 15;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Image = global::Capa_Vista_Capacitacion.Properties.Resources.ahorrar__1___1_;
            this.Btn_guardar.Location = new System.Drawing.Point(84, 169);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(66, 69);
            this.Btn_guardar.TabIndex = 17;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // parámetros_capacitación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(251, 250);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.nudNeutro);
            this.Controls.Add(this.nudAumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Name = "parámetros_capacitación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "parámetros_capacitación";
            this.Load += new System.EventHandler(this.parámetros_capacitación_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeutro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAumento;
        private System.Windows.Forms.NumericUpDown nudNeutro;
        private System.Windows.Forms.Button Btn_guardar;
    }
}