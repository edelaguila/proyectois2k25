
namespace AppCContable
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cierre1 = new Capa_Vista_CierreContable.Cierre();
            this.SuspendLayout();
            // 
            // cierre1
            // 
            this.cierre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cierre1.Location = new System.Drawing.Point(0, 0);
            this.cierre1.Name = "cierre1";
            this.cierre1.Size = new System.Drawing.Size(1084, 675);
            this.cierre1.TabIndex = 0;
            //this.cierre1.Load += new System.EventHandler(this.cierre1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1084, 675);
            this.Controls.Add(this.cierre1);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Capa_Vista_CierreContable.Cierre cierre1;
    }
}

