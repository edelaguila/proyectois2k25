
namespace Capa_Vista_Capacitacion
{
    partial class notificacionSemaforo
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(12, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(84, 31);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "label1";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblNivel.Location = new System.Drawing.Point(41, 141);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(41, 19);
            this.lblNivel.TabIndex = 1;
            this.lblNivel.Text = "Nivel";
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCompetencia.Location = new System.Drawing.Point(466, 141);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(89, 19);
            this.lblCompetencia.TabIndex = 2;
            this.lblCompetencia.Text = "Competencia";
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPuntuacion.Location = new System.Drawing.Point(41, 188);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(75, 19);
            this.lblPuntuacion.TabIndex = 3;
            this.lblPuntuacion.Text = "Puntuacion";
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblAsistencia.Location = new System.Drawing.Point(485, 188);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(70, 19);
            this.lblAsistencia.TabIndex = 4;
            this.lblAsistencia.Text = "Asistencia";
            // 
            // notificacionSemaforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 240);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.lblCompetencia);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblMensaje);
            this.Name = "notificacionSemaforo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notificacionSemaforo";
            this.Load += new System.EventHandler(this.notificacionSemaforo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.Label lblAsistencia;
    }
}