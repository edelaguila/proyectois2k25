
namespace Interfac_V3
{
    partial class FormModulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModulos));
            this.panelBarraSuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.Btn_Empresa = new System.Windows.Forms.Button();
            this.Btn_CuentasCorrientes = new System.Windows.Forms.Button();
            this.Btn_Produccion = new System.Windows.Forms.Button();
            this.Btn_Nominas = new System.Windows.Forms.Button();
            this.Btn_Bancos = new System.Windows.Forms.Button();
            this.Btn_Compras = new System.Windows.Forms.Button();
            this.Btn_Contabilidad = new System.Windows.Forms.Button();
            this.Btn_Logistica = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.panelBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraSuperior
            // 
            this.panelBarraSuperior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBarraSuperior.Controls.Add(this.btnCerrar);
            this.panelBarraSuperior.Controls.Add(this.btnMinimizar);
            this.panelBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelBarraSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBarraSuperior.Name = "panelBarraSuperior";
            this.panelBarraSuperior.Size = new System.Drawing.Size(280, 21);
            this.panelBarraSuperior.TabIndex = 0;
            this.panelBarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraSuperior_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(266, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(12, 13);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(250, 6);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(12, 13);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 21);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(280, 52);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.Btn_Empresa);
            this.panelContenedor.Controls.Add(this.Btn_CuentasCorrientes);
            this.panelContenedor.Controls.Add(this.Btn_Produccion);
            this.panelContenedor.Controls.Add(this.Btn_Nominas);
            this.panelContenedor.Controls.Add(this.Btn_Bancos);
            this.panelContenedor.Controls.Add(this.Btn_Compras);
            this.panelContenedor.Controls.Add(this.Btn_Contabilidad);
            this.panelContenedor.Controls.Add(this.Btn_Logistica);
            this.panelContenedor.Controls.Add(this.btnSalir);
            this.panelContenedor.Controls.Add(this.btnSeguridad);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 73);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(280, 567);
            this.panelContenedor.TabIndex = 2;
            // 
            // Btn_Empresa
            // 
            this.Btn_Empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Empresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Empresa.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Empresa.Image")));
            this.Btn_Empresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Empresa.Location = new System.Drawing.Point(2, 471);
            this.Btn_Empresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Empresa.Name = "Btn_Empresa";
            this.Btn_Empresa.Size = new System.Drawing.Size(275, 44);
            this.Btn_Empresa.TabIndex = 9;
            this.Btn_Empresa.Text = "Registro Empresa";
            this.Btn_Empresa.UseVisualStyleBackColor = true;
            // 
            // Btn_CuentasCorrientes
            // 
            this.Btn_CuentasCorrientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CuentasCorrientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CuentasCorrientes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CuentasCorrientes.Image")));
            this.Btn_CuentasCorrientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CuentasCorrientes.Location = new System.Drawing.Point(2, 412);
            this.Btn_CuentasCorrientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_CuentasCorrientes.Name = "Btn_CuentasCorrientes";
            this.Btn_CuentasCorrientes.Size = new System.Drawing.Size(275, 55);
            this.Btn_CuentasCorrientes.TabIndex = 8;
            this.Btn_CuentasCorrientes.Text = "Modulo Cuentas corrientes";
            this.Btn_CuentasCorrientes.UseVisualStyleBackColor = true;
            this.Btn_CuentasCorrientes.Click += new System.EventHandler(this.Btn_CuentasCorrientes_Click);
            // 
            // Btn_Produccion
            // 
            this.Btn_Produccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Produccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Produccion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Produccion.Image")));
            this.Btn_Produccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Produccion.Location = new System.Drawing.Point(2, 353);
            this.Btn_Produccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Produccion.Name = "Btn_Produccion";
            this.Btn_Produccion.Size = new System.Drawing.Size(275, 55);
            this.Btn_Produccion.TabIndex = 7;
            this.Btn_Produccion.Text = "Modulo Produccion";
            this.Btn_Produccion.UseVisualStyleBackColor = true;
            this.Btn_Produccion.Click += new System.EventHandler(this.Btn_Produccion_Click);
            // 
            // Btn_Nominas
            // 
            this.Btn_Nominas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nominas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nominas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Nominas.Image")));
            this.Btn_Nominas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Nominas.Location = new System.Drawing.Point(2, 294);
            this.Btn_Nominas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Nominas.Name = "Btn_Nominas";
            this.Btn_Nominas.Size = new System.Drawing.Size(275, 55);
            this.Btn_Nominas.TabIndex = 6;
            this.Btn_Nominas.Text = "Modulo Recursos Humanos";
            this.Btn_Nominas.UseVisualStyleBackColor = true;
            this.Btn_Nominas.Click += new System.EventHandler(this.Btn_Nominas_Click);
            // 
            // Btn_Bancos
            // 
            this.Btn_Bancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Bancos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Bancos.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Bancos.Image")));
            this.Btn_Bancos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Bancos.Location = new System.Drawing.Point(2, 235);
            this.Btn_Bancos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Bancos.Name = "Btn_Bancos";
            this.Btn_Bancos.Size = new System.Drawing.Size(275, 55);
            this.Btn_Bancos.TabIndex = 5;
            this.Btn_Bancos.Text = "Modulo Bancos";
            this.Btn_Bancos.UseVisualStyleBackColor = true;
            this.Btn_Bancos.Click += new System.EventHandler(this.Btn_Bancos_Click);
            // 
            // Btn_Compras
            // 
            this.Btn_Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Compras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Compras.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Compras.Image")));
            this.Btn_Compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Compras.Location = new System.Drawing.Point(2, 176);
            this.Btn_Compras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Compras.Name = "Btn_Compras";
            this.Btn_Compras.Size = new System.Drawing.Size(275, 55);
            this.Btn_Compras.TabIndex = 4;
            this.Btn_Compras.Text = "Modulo Compra y ventas";
            this.Btn_Compras.UseVisualStyleBackColor = true;
            this.Btn_Compras.Click += new System.EventHandler(this.Btn_Compras_Click);
            // 
            // Btn_Contabilidad
            // 
            this.Btn_Contabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Contabilidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Contabilidad.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Contabilidad.Image")));
            this.Btn_Contabilidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Contabilidad.Location = new System.Drawing.Point(2, 118);
            this.Btn_Contabilidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Contabilidad.Name = "Btn_Contabilidad";
            this.Btn_Contabilidad.Size = new System.Drawing.Size(275, 55);
            this.Btn_Contabilidad.TabIndex = 3;
            this.Btn_Contabilidad.Text = "Modulo Contabilidad";
            this.Btn_Contabilidad.UseVisualStyleBackColor = true;
            this.Btn_Contabilidad.Click += new System.EventHandler(this.Btn_Contabilidad_Click);
            // 
            // Btn_Logistica
            // 
            this.Btn_Logistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logistica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Logistica.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logistica.Image")));
            this.Btn_Logistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Logistica.Location = new System.Drawing.Point(2, 59);
            this.Btn_Logistica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Logistica.Name = "Btn_Logistica";
            this.Btn_Logistica.Size = new System.Drawing.Size(275, 55);
            this.Btn_Logistica.TabIndex = 2;
            this.Btn_Logistica.Text = "Modulo Logistica";
            this.Btn_Logistica.UseVisualStyleBackColor = true;
            this.Btn_Logistica.Click += new System.EventHandler(this.Btn_Logistica_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(2, 518);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(275, 41);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir del Sistema";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.Image = ((System.Drawing.Image)(resources.GetObject("btnSeguridad.Image")));
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(3, 0);
            this.btnSeguridad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(275, 55);
            this.btnSeguridad.TabIndex = 0;
            this.btnSeguridad.Text = "Modulo de Seguridad";
            this.btnSeguridad.UseVisualStyleBackColor = true;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // FormModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 640);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormModulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModulos";
            this.Load += new System.EventHandler(this.FormModulos_Load);
            this.panelBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraSuperior;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button Btn_Logistica;
        private System.Windows.Forms.Button Btn_Bancos;
        private System.Windows.Forms.Button Btn_Compras;
        private System.Windows.Forms.Button Btn_Contabilidad;
        private System.Windows.Forms.Button Btn_CuentasCorrientes;
        private System.Windows.Forms.Button Btn_Produccion;
        private System.Windows.Forms.Button Btn_Nominas;
        private System.Windows.Forms.Button Btn_Empresa;
    }
}