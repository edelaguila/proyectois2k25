
namespace Capa_Vista_Contabilidad
{
    partial class FormCierre
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
            this.cierre1 = new Capa_Vista_CierreContable.Cierre();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cierre1
            // 
            this.cierre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cierre1.idUsuario = null;
            this.cierre1.Location = new System.Drawing.Point(0, 0);
            this.cierre1.Name = "cierre1";
            this.cierre1.Size = new System.Drawing.Size(1074, 667);
            this.cierre1.TabIndex = 0;
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_salir.BackgroundImage = global::Capa_Vista_Contabilidad.Properties.Resources.SALIR_V4;
            this.Btn_salir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_salir.Location = new System.Drawing.Point(970, 51);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(69, 63);
            this.Btn_salir.TabIndex = 1;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // FormCierre
            // 
            this.ClientSize = new System.Drawing.Size(1074, 667);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.cierre1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "FormCierre";
            this.ResumeLayout(false);

        }

        private Capa_Vista_CierreContable.Cierre cierre1;

        #endregion

        private Capa_Vista_CierreContable.Cierre cierre;
        private System.Windows.Forms.Button Btn_salir;
    }
}