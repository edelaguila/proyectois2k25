
namespace Capa_Vista_EstadosFinancieros
{
    partial class Visualizar
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
            this.FlujoDeEfectivoHistorico1 = new Capa_Vista_EstadosFinancieros.FlujoDeEfectivoHistorico();
            this.EstadoDeResultadosHistorico1 = new Capa_Vista_EstadosFinancieros.EstadoDeResultadosHistorico();
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
            this.crystalReportViewer1.ReportSource = "C:\\PRUEBAA\\asis22k24proy2\\Codigo\\Modulos\\Contabilidad\\EstadosFinancieros\\Reportes" +
    "Estados\\Balance.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1129, 450);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // Visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Visualizar";
            this.Text = "Visualizar";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private EstadoDeResultadosHistorico EstadoDeResultadosHistorico1;
        private FlujoDeEfectivoHistorico FlujoDeEfectivoHistorico1;
    }
}