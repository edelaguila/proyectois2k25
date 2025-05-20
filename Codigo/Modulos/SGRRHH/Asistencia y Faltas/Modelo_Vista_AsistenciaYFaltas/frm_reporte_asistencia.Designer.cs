
namespace Modelo_Vista_AsistenciaYFaltas
{
    partial class frm_reporte_asistencia
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
            this.ReposrteAsistencia1 = new Modelo_Vista_AsistenciaYFaltas.ReposrteAsistencia();
            this.AsisRep2 = new Modelo_Vista_AsistenciaYFaltas.AsisRep();
            this.AsisRep1 = new Modelo_Vista_AsistenciaYFaltas.AsisRep();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.AsistenciReporte1 = new Modelo_Vista_AsistenciaYFaltas.AsistenciReporte();
            this.AsistenciReporte2 = new Modelo_Vista_AsistenciaYFaltas.AsistenciReporte();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.AsistenciReporte3 = new Modelo_Vista_AsistenciaYFaltas.AsistenciReporte();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.AsistenciReporte2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.AsistenciReporte3;
            this.crystalReportViewer2.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer2.TabIndex = 1;
            // 
            // frm_reporte_asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frm_reporte_asistencia";
            this.Text = "frm_reporte_asistencia";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ReposrteAsistencia ReposrteAsistencia1;
        private AsisRep AsisRep1;
        private AsisRep AsisRep2;
        private AsistenciReporte AsistenciReporte1;
        private AsistenciReporte AsistenciReporte2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private AsistenciReporte AsistenciReporte3;
    }
}