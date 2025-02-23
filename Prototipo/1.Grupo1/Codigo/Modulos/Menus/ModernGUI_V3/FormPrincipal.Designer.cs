namespace Interfac_V3
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelIdentificacion = new System.Windows.Forms.Panel();
            this.panelformularios = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelMenuProcesos = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMenuProcesosOpcion1 = new System.Windows.Forms.Button();
            this.btnMenuProcesos = new System.Windows.Forms.Button();
            this.panelMenuCatalogos = new System.Windows.Forms.Panel();
            this.btnMenuCatalogosOpcion2 = new System.Windows.Forms.Button();
            this.btnMenuCatalogosOpcion1 = new System.Windows.Forms.Button();
            this.btnMenuCatalogos = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelformularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelMenuProcesos.SuspendLayout();
            this.panelMenuCatalogos.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelIdentificacion);
            this.panelContenedor.Controls.Add(this.panelformularios);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1363, 661);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelIdentificacion
            // 
            this.panelIdentificacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIdentificacion.Location = new System.Drawing.Point(182, 631);
            this.panelIdentificacion.Name = "panelIdentificacion";
            this.panelIdentificacion.Size = new System.Drawing.Size(1181, 30);
            this.panelIdentificacion.TabIndex = 3;
            // 
            // panelformularios
            // 
            this.panelformularios.BackColor = System.Drawing.SystemColors.Control;
            this.panelformularios.Controls.Add(this.pictureBox1);
            this.panelformularios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelformularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelformularios.Location = new System.Drawing.Point(182, 39);
            this.panelformularios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelformularios.Name = "panelformularios";
            this.panelformularios.Size = new System.Drawing.Size(1181, 622);
            this.panelformularios.TabIndex = 2;
            this.panelformularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelformularios_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 163);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.panelMenuProcesos);
            this.panelMenu.Controls.Add(this.btnMenuProcesos);
            this.panelMenu.Controls.Add(this.panelMenuCatalogos);
            this.panelMenu.Controls.Add(this.btnMenuCatalogos);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 39);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(182, 622);
            this.panelMenu.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 264);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(182, 43);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelMenuProcesos
            // 
            this.panelMenuProcesos.Controls.Add(this.button1);
            this.panelMenuProcesos.Controls.Add(this.btnMenuProcesosOpcion1);
            this.panelMenuProcesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuProcesos.Location = new System.Drawing.Point(0, 172);
            this.panelMenuProcesos.Name = "panelMenuProcesos";
            this.panelMenuProcesos.Size = new System.Drawing.Size(182, 92);
            this.panelMenuProcesos.TabIndex = 6;
            this.panelMenuProcesos.Visible = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(0, 37);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(182, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Opcion4";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMenuProcesosOpcion1
            // 
            this.btnMenuProcesosOpcion1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuProcesosOpcion1.FlatAppearance.BorderSize = 0;
            this.btnMenuProcesosOpcion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuProcesosOpcion1.ForeColor = System.Drawing.Color.Silver;
            this.btnMenuProcesosOpcion1.Location = new System.Drawing.Point(0, 0);
            this.btnMenuProcesosOpcion1.Name = "btnMenuProcesosOpcion1";
            this.btnMenuProcesosOpcion1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMenuProcesosOpcion1.Size = new System.Drawing.Size(182, 37);
            this.btnMenuProcesosOpcion1.TabIndex = 0;
            this.btnMenuProcesosOpcion1.Text = "Opcion3";
            this.btnMenuProcesosOpcion1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuProcesosOpcion1.UseVisualStyleBackColor = true;
            this.btnMenuProcesosOpcion1.Click += new System.EventHandler(this.btnMenuProcesosOpcion1_Click);
            // 
            // btnMenuProcesos
            // 
            this.btnMenuProcesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuProcesos.FlatAppearance.BorderSize = 0;
            this.btnMenuProcesos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMenuProcesos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnMenuProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuProcesos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuProcesos.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuProcesos.Image")));
            this.btnMenuProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuProcesos.Location = new System.Drawing.Point(0, 126);
            this.btnMenuProcesos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuProcesos.Name = "btnMenuProcesos";
            this.btnMenuProcesos.Size = new System.Drawing.Size(182, 46);
            this.btnMenuProcesos.TabIndex = 5;
            this.btnMenuProcesos.Text = "Procesos";
            this.btnMenuProcesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuProcesos.UseVisualStyleBackColor = true;
            this.btnMenuProcesos.Click += new System.EventHandler(this.btnMenuProcesos_Click);
            // 
            // panelMenuCatalogos
            // 
            this.panelMenuCatalogos.Controls.Add(this.btnMenuCatalogosOpcion2);
            this.panelMenuCatalogos.Controls.Add(this.btnMenuCatalogosOpcion1);
            this.panelMenuCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuCatalogos.Location = new System.Drawing.Point(0, 45);
            this.panelMenuCatalogos.Name = "panelMenuCatalogos";
            this.panelMenuCatalogos.Size = new System.Drawing.Size(182, 81);
            this.panelMenuCatalogos.TabIndex = 4;
            this.panelMenuCatalogos.Visible = false;
            // 
            // btnMenuCatalogosOpcion2
            // 
            this.btnMenuCatalogosOpcion2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuCatalogosOpcion2.FlatAppearance.BorderSize = 0;
            this.btnMenuCatalogosOpcion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCatalogosOpcion2.ForeColor = System.Drawing.Color.Silver;
            this.btnMenuCatalogosOpcion2.Location = new System.Drawing.Point(0, 38);
            this.btnMenuCatalogosOpcion2.Name = "btnMenuCatalogosOpcion2";
            this.btnMenuCatalogosOpcion2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMenuCatalogosOpcion2.Size = new System.Drawing.Size(182, 19);
            this.btnMenuCatalogosOpcion2.TabIndex = 1;
            this.btnMenuCatalogosOpcion2.Text = "Opcion2";
            this.btnMenuCatalogosOpcion2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCatalogosOpcion2.UseVisualStyleBackColor = true;
            this.btnMenuCatalogosOpcion2.Click += new System.EventHandler(this.btnMenuCatalogosOpcion2_Click_1);
            // 
            // btnMenuCatalogosOpcion1
            // 
            this.btnMenuCatalogosOpcion1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuCatalogosOpcion1.FlatAppearance.BorderSize = 0;
            this.btnMenuCatalogosOpcion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCatalogosOpcion1.ForeColor = System.Drawing.Color.Silver;
            this.btnMenuCatalogosOpcion1.Location = new System.Drawing.Point(0, 0);
            this.btnMenuCatalogosOpcion1.Name = "btnMenuCatalogosOpcion1";
            this.btnMenuCatalogosOpcion1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMenuCatalogosOpcion1.Size = new System.Drawing.Size(182, 38);
            this.btnMenuCatalogosOpcion1.TabIndex = 0;
            this.btnMenuCatalogosOpcion1.Text = "Opcion1";
            this.btnMenuCatalogosOpcion1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCatalogosOpcion1.UseVisualStyleBackColor = true;
            this.btnMenuCatalogosOpcion1.Click += new System.EventHandler(this.btnMenuCatalogosOpcion1_Click);
            // 
            // btnMenuCatalogos
            // 
            this.btnMenuCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuCatalogos.FlatAppearance.BorderSize = 0;
            this.btnMenuCatalogos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMenuCatalogos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnMenuCatalogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCatalogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCatalogos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuCatalogos.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuCatalogos.Image")));
            this.btnMenuCatalogos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCatalogos.Location = new System.Drawing.Point(0, 0);
            this.btnMenuCatalogos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuCatalogos.Name = "btnMenuCatalogos";
            this.btnMenuCatalogos.Size = new System.Drawing.Size(182, 45);
            this.btnMenuCatalogos.TabIndex = 2;
            this.btnMenuCatalogos.Text = "Catalogos";
            this.btnMenuCatalogos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCatalogos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuCatalogos.UseVisualStyleBackColor = true;
            this.btnMenuCatalogos.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarraTitulo.Controls.Add(this.pictureBox2);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1363, 39);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1311, 11);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(16, 16);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1289, 11);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1312, 11);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(16, 16);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1333, 11);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 661);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(651, 400);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelformularios.ResumeLayout(false);
            this.panelformularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenuProcesos.ResumeLayout(false);
            this.panelMenuCatalogos.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelformularios;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnMenuCatalogos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelIdentificacion;
        private System.Windows.Forms.Panel panelMenuCatalogos;
        private System.Windows.Forms.Button btnMenuCatalogosOpcion1;
        private System.Windows.Forms.Button btnMenuCatalogosOpcion2;
        private System.Windows.Forms.Button btnMenuProcesos;
        private System.Windows.Forms.Panel panelMenuProcesos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMenuProcesosOpcion1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSalir;
    }
}

