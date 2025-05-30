
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Menu
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
            this.Btn_Mantenimiento = new System.Windows.Forms.Button();
            this.Btn_Caja = new System.Windows.Forms.Button();
            this.Btn_Mov_Clientes = new System.Windows.Forms.Button();
            this.Btn_Mov_Prov = new System.Windows.Forms.Button();
            this.Btn_ReportC = new System.Windows.Forms.Button();
            this.Btn_ReportesP = new System.Windows.Forms.Button();
            this.Btn_ReporteM = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Enlaces = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Mantenimiento
            // 
            this.Btn_Mantenimiento.Location = new System.Drawing.Point(791, 3);
            this.Btn_Mantenimiento.Name = "Btn_Mantenimiento";
            this.Btn_Mantenimiento.Size = new System.Drawing.Size(142, 60);
            this.Btn_Mantenimiento.TabIndex = 0;
            this.Btn_Mantenimiento.Text = "MANTENIMIENTO";
            this.Btn_Mantenimiento.UseVisualStyleBackColor = true;
            this.Btn_Mantenimiento.Click += new System.EventHandler(this.Btn_Mantenimiento_Click);
            // 
            // Btn_Caja
            // 
            this.Btn_Caja.Location = new System.Drawing.Point(259, 3);
            this.Btn_Caja.Name = "Btn_Caja";
            this.Btn_Caja.Size = new System.Drawing.Size(122, 60);
            this.Btn_Caja.TabIndex = 1;
            this.Btn_Caja.Text = "CAJA";
            this.Btn_Caja.UseVisualStyleBackColor = true;
            this.Btn_Caja.Click += new System.EventHandler(this.Btn_Caja_Click);
            // 
            // Btn_Mov_Clientes
            // 
            this.Btn_Mov_Clientes.Location = new System.Drawing.Point(3, 3);
            this.Btn_Mov_Clientes.Name = "Btn_Mov_Clientes";
            this.Btn_Mov_Clientes.Size = new System.Drawing.Size(122, 60);
            this.Btn_Mov_Clientes.TabIndex = 2;
            this.Btn_Mov_Clientes.Text = "MOVIMIENTO\r\nCLIENTES\r\n";
            this.Btn_Mov_Clientes.UseVisualStyleBackColor = true;
            this.Btn_Mov_Clientes.Click += new System.EventHandler(this.Btn_Mov_Clientes_Click);
            // 
            // Btn_Mov_Prov
            // 
            this.Btn_Mov_Prov.Location = new System.Drawing.Point(131, 3);
            this.Btn_Mov_Prov.Name = "Btn_Mov_Prov";
            this.Btn_Mov_Prov.Size = new System.Drawing.Size(122, 60);
            this.Btn_Mov_Prov.TabIndex = 3;
            this.Btn_Mov_Prov.Text = "MOVIMIENTO\r\nPROVEEDOR";
            this.Btn_Mov_Prov.UseVisualStyleBackColor = true;
            this.Btn_Mov_Prov.Click += new System.EventHandler(this.Btn_Mov_Prov_Click);
            // 
            // Btn_ReportC
            // 
            this.Btn_ReportC.Location = new System.Drawing.Point(387, 3);
            this.Btn_ReportC.Name = "Btn_ReportC";
            this.Btn_ReportC.Size = new System.Drawing.Size(122, 60);
            this.Btn_ReportC.TabIndex = 4;
            this.Btn_ReportC.Text = "REPORTES\r\nCLIENTES";
            this.Btn_ReportC.UseVisualStyleBackColor = true;
            this.Btn_ReportC.Click += new System.EventHandler(this.Btn_ReportC_Click);
            // 
            // Btn_ReportesP
            // 
            this.Btn_ReportesP.Location = new System.Drawing.Point(515, 3);
            this.Btn_ReportesP.Name = "Btn_ReportesP";
            this.Btn_ReportesP.Size = new System.Drawing.Size(122, 60);
            this.Btn_ReportesP.TabIndex = 5;
            this.Btn_ReportesP.Text = "REPORTES\r\nPROVEEDOR\r\n";
            this.Btn_ReportesP.UseVisualStyleBackColor = true;
            this.Btn_ReportesP.Click += new System.EventHandler(this.Btn_ReportesP_Click);
            // 
            // Btn_ReporteM
            // 
            this.Btn_ReporteM.Location = new System.Drawing.Point(643, 3);
            this.Btn_ReporteM.Name = "Btn_ReporteM";
            this.Btn_ReporteM.Size = new System.Drawing.Size(142, 60);
            this.Btn_ReporteM.TabIndex = 6;
            this.Btn_ReporteM.Text = "REPORTES\r\nMANTENIMIENTO\r\n";
            this.Btn_ReporteM.UseVisualStyleBackColor = true;
            this.Btn_ReporteM.Click += new System.EventHandler(this.Btn_ReporteM_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel1.Controls.Add(this.Btn_Mov_Clientes);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Mov_Prov);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Caja);
            this.flowLayoutPanel1.Controls.Add(this.Btn_ReportC);
            this.flowLayoutPanel1.Controls.Add(this.Btn_ReportesP);
            this.flowLayoutPanel1.Controls.Add(this.Btn_ReporteM);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Mantenimiento);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Enlaces);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1392, 758);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // Btn_Enlaces
            // 
            this.Btn_Enlaces.Location = new System.Drawing.Point(939, 3);
            this.Btn_Enlaces.Name = "Btn_Enlaces";
            this.Btn_Enlaces.Size = new System.Drawing.Size(142, 60);
            this.Btn_Enlaces.TabIndex = 8;
            this.Btn_Enlaces.Text = "ENLACES";
            this.Btn_Enlaces.UseVisualStyleBackColor = true;
            this.Btn_Enlaces.Click += new System.EventHandler(this.Btn_Enlaces_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.WhatsApp_Image_2024_10_13_at_5_24_35_PM;
            this.pictureBox1.Location = new System.Drawing.Point(1087, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1392, 758);
            this.Controls.Add(this.flowLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Mantenimiento;
        private System.Windows.Forms.Button Btn_Caja;
        private System.Windows.Forms.Button Btn_Mov_Clientes;
        private System.Windows.Forms.Button Btn_Mov_Prov;
        private System.Windows.Forms.Button Btn_ReportC;
        private System.Windows.Forms.Button Btn_ReportesP;
        private System.Windows.Forms.Button Btn_ReporteM;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Enlaces;
    }
}