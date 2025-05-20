
namespace Capa_Vista_Reporte
{
    partial class Reporte
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportesProv1 = new Capa_Vista_Reporte.ReportesProv();
            //this.ReporteProveedor3 = new Capa_Vista_Reporte.ReporteProveedor();
            //this.ReporteProveedor1 = new Capa_Vista_Reporte.ReporteProveedor();
            //this.ReporteProveedor2 = new Capa_Vista_Reporte.ReporteProveedor();
            this.ReportesProv2 = new Capa_Vista_Reporte.ReportesProv();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
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
            this.crystalReportViewer2.ReportSource = this.ReportesProv2;
            this.crystalReportViewer2.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer2.TabIndex = 1;
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = 0;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer3.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.ReportSource = this.ReportesProv1;
            this.crystalReportViewer3.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer3.TabIndex = 2;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer3);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.ResumeLayout(false);

        }

        #endregion
        //private ReporteProveedor ReporteProveedor1;
        //private CrystalReport2 CrystalReport22;
        //private CrystalReport4 CrystalReport41;
        //private CrystalReport4 CrystalReport42;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        //private ReporteProveedor ReporteProveedor2;
        //private CrystalReport4 CrystalReport43;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        //private ReporteProveedor ReporteProveedor3;
        private ReportesProv ReportesProv1;
        private ReportesProv ReportesProv2;
        //private CrystalReport4 CrystalReport44;
        // private Prueba Prueba1;
    }
}