namespace Capa_Vista_Seguridad
{
    partial class frm_asignacion_modulo_aplicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_asignacion_modulo_aplicaciones));
            this.Cmb_modulo = new System.Windows.Forms.ComboBox();
            this.Cmb_aplicacion = new System.Windows.Forms.ComboBox();
            this.Txt_modulos = new System.Windows.Forms.Label();
            this.Txt_aplicaciones = new System.Windows.Forms.Label();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.Btn_ver = new System.Windows.Forms.Button();
            this.Txt_aplicacion = new System.Windows.Forms.TextBox();
            this.Txt_modulo = new System.Windows.Forms.TextBox();
            this.Dgv_asignaciones_modulo_aplicacion = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Txt_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignaciones_modulo_aplicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb_modulo
            // 
            this.Cmb_modulo.FormattingEnabled = true;
            this.Cmb_modulo.Location = new System.Drawing.Point(159, 92);
            this.Cmb_modulo.Name = "Cmb_modulo";
            this.Cmb_modulo.Size = new System.Drawing.Size(245, 24);
            this.Cmb_modulo.TabIndex = 0;
            this.Cmb_modulo.SelectedIndexChanged += new System.EventHandler(this.cmb_modulo_SelectedIndexChanged_1);
            // 
            // Cmb_aplicacion
            // 
            this.Cmb_aplicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_aplicacion.FormattingEnabled = true;
            this.Cmb_aplicacion.Location = new System.Drawing.Point(681, 92);
            this.Cmb_aplicacion.Name = "Cmb_aplicacion";
            this.Cmb_aplicacion.Size = new System.Drawing.Size(245, 24);
            this.Cmb_aplicacion.TabIndex = 1;
            this.Cmb_aplicacion.SelectedIndexChanged += new System.EventHandler(this.cmb_apli_SelectedIndexChanged);
            // 
            // Txt_modulos
            // 
            this.Txt_modulos.AutoSize = true;
            this.Txt_modulos.Font = new System.Drawing.Font("Haettenschweiler", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_modulos.Location = new System.Drawing.Point(234, 54);
            this.Txt_modulos.Name = "Txt_modulos";
            this.Txt_modulos.Size = new System.Drawing.Size(67, 24);
            this.Txt_modulos.TabIndex = 2;
            this.Txt_modulos.Text = "Modulos";
            // 
            // Txt_aplicaciones
            // 
            this.Txt_aplicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_aplicaciones.AutoSize = true;
            this.Txt_aplicaciones.Font = new System.Drawing.Font("Haettenschweiler", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_aplicaciones.Location = new System.Drawing.Point(766, 54);
            this.Txt_aplicaciones.Name = "Txt_aplicaciones";
            this.Txt_aplicaciones.Size = new System.Drawing.Size(96, 24);
            this.Txt_aplicaciones.TabIndex = 3;
            this.Txt_aplicaciones.Text = "Aplicaciones";
            // 
            // Btn_crear
            // 
            this.Btn_crear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_crear.FlatAppearance.BorderSize = 0;
            this.Btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_crear.Image = global::Capa_Vista_Seguridad.Properties.Resources.agregar11;
            this.Btn_crear.Location = new System.Drawing.Point(487, 99);
            this.Btn_crear.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(69, 57);
            this.Btn_crear.TabIndex = 15;
            this.Btn_crear.UseVisualStyleBackColor = false;
            this.Btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // Btn_ver
            // 
            this.Btn_ver.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_ver.FlatAppearance.BorderSize = 0;
            this.Btn_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ver.Image = global::Capa_Vista_Seguridad.Properties.Resources.buscar11;
            this.Btn_ver.Location = new System.Drawing.Point(551, 99);
            this.Btn_ver.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ver.Name = "Btn_ver";
            this.Btn_ver.Size = new System.Drawing.Size(69, 57);
            this.Btn_ver.TabIndex = 14;
            this.Btn_ver.UseVisualStyleBackColor = false;
            this.Btn_ver.Visible = false;
            this.Btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // Txt_aplicacion
            // 
            this.Txt_aplicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_aplicacion.Location = new System.Drawing.Point(681, 134);
            this.Txt_aplicacion.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_aplicacion.Name = "Txt_aplicacion";
            this.Txt_aplicacion.Size = new System.Drawing.Size(245, 22);
            this.Txt_aplicacion.TabIndex = 13;
            // 
            // Txt_modulo
            // 
            this.Txt_modulo.Location = new System.Drawing.Point(159, 134);
            this.Txt_modulo.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_modulo.Name = "Txt_modulo";
            this.Txt_modulo.Size = new System.Drawing.Size(245, 22);
            this.Txt_modulo.TabIndex = 12;
            // 
            // Dgv_asignaciones_modulo_aplicacion
            // 
            this.Dgv_asignaciones_modulo_aplicacion.AllowUserToAddRows = false;
            this.Dgv_asignaciones_modulo_aplicacion.AllowUserToDeleteRows = false;
            this.Dgv_asignaciones_modulo_aplicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_asignaciones_modulo_aplicacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_asignaciones_modulo_aplicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignaciones_modulo_aplicacion.Location = new System.Drawing.Point(31, 182);
            this.Dgv_asignaciones_modulo_aplicacion.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_asignaciones_modulo_aplicacion.Name = "Dgv_asignaciones_modulo_aplicacion";
            this.Dgv_asignaciones_modulo_aplicacion.ReadOnly = true;
            this.Dgv_asignaciones_modulo_aplicacion.RowHeadersWidth = 72;
            this.Dgv_asignaciones_modulo_aplicacion.RowTemplate.Height = 31;
            this.Dgv_asignaciones_modulo_aplicacion.Size = new System.Drawing.Size(1044, 269);
            this.Dgv_asignaciones_modulo_aplicacion.TabIndex = 11;
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Image = global::Capa_Vista_Seguridad.Properties.Resources.salir11;
            this.btn_salir.Location = new System.Drawing.Point(955, 22);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(69, 57);
            this.btn_salir.TabIndex = 235;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = global::Capa_Vista_Seguridad.Properties.Resources.ayuda11;
            this.Btn_ayuda.Location = new System.Drawing.Point(1020, 22);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(69, 57);
            this.Btn_ayuda.TabIndex = 236;
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_titulo.ForeColor = System.Drawing.Color.Transparent;
            this.Txt_titulo.Location = new System.Drawing.Point(399, 22);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(326, 45);
            this.Txt_titulo.TabIndex = 284;
            this.Txt_titulo.Text = "Modulos a aplicaciones";
            // 
            // frm_asignacion_modulo_aplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1104, 462);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.Btn_crear);
            this.Controls.Add(this.Btn_ver);
            this.Controls.Add(this.Txt_aplicacion);
            this.Controls.Add(this.Txt_modulo);
            this.Controls.Add(this.Dgv_asignaciones_modulo_aplicacion);
            this.Controls.Add(this.Txt_aplicaciones);
            this.Controls.Add(this.Txt_modulos);
            this.Controls.Add(this.Cmb_aplicacion);
            this.Controls.Add(this.Cmb_modulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_asignacion_modulo_aplicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulos a aplicaciones";
            this.Load += new System.EventHandler(this.frm_asignacion_modulo_aplicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignaciones_modulo_aplicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb_modulo;
        private System.Windows.Forms.ComboBox Cmb_aplicacion;
        private System.Windows.Forms.Label Txt_modulos;
        private System.Windows.Forms.Label Txt_aplicaciones;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.Button Btn_ver;
        private System.Windows.Forms.TextBox Txt_aplicacion;
        private System.Windows.Forms.TextBox Txt_modulo;
        private System.Windows.Forms.DataGridView Dgv_asignaciones_modulo_aplicacion;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Label Txt_titulo;
    }
}