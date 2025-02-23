namespace Capa_Vista_Seguridad
{
    partial class frm_mostrar_bitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mostrar_bitacora));
            this.Dgv_bitacora = new System.Windows.Forms.DataGridView();
            this.Txt_dato = new System.Windows.Forms.TextBox();
            this.Cmb_columna = new System.Windows.Forms.ComboBox();
            this.Lbl_columna = new System.Windows.Forms.Label();
            this.Lbl_ingresaundato = new System.Windows.Forms.Label();
            this.Dtp_dato = new System.Windows.Forms.DateTimePicker();
            this.Dtp_hora = new System.Windows.Forms.DateTimePicker();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_borrarfiltros = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_bitacora
            // 
            this.Dgv_bitacora.AllowUserToAddRows = false;
            this.Dgv_bitacora.AllowUserToDeleteRows = false;
            this.Dgv_bitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_bitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_bitacora.Location = new System.Drawing.Point(19, 97);
            this.Dgv_bitacora.Name = "Dgv_bitacora";
            this.Dgv_bitacora.ReadOnly = true;
            this.Dgv_bitacora.RowHeadersWidth = 62;
            this.Dgv_bitacora.RowTemplate.Height = 28;
            this.Dgv_bitacora.Size = new System.Drawing.Size(1068, 487);
            this.Dgv_bitacora.TabIndex = 0;
            // 
            // Txt_dato
            // 
            this.Txt_dato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_dato.Location = new System.Drawing.Point(472, 46);
            this.Txt_dato.Name = "Txt_dato";
            this.Txt_dato.Size = new System.Drawing.Size(229, 27);
            this.Txt_dato.TabIndex = 2;
            // 
            // Cmb_columna
            // 
            this.Cmb_columna.FormattingEnabled = true;
            this.Cmb_columna.Location = new System.Drawing.Point(155, 46);
            this.Cmb_columna.Name = "Cmb_columna";
            this.Cmb_columna.Size = new System.Drawing.Size(226, 29);
            this.Cmb_columna.TabIndex = 3;
            this.Cmb_columna.SelectedIndexChanged += new System.EventHandler(this.Cbo_columna_SelectedIndexChanged);
            // 
            // Lbl_columna
            // 
            this.Lbl_columna.AutoSize = true;
            this.Lbl_columna.Location = new System.Drawing.Point(160, 20);
            this.Lbl_columna.Name = "Lbl_columna";
            this.Lbl_columna.Size = new System.Drawing.Size(215, 21);
            this.Lbl_columna.TabIndex = 5;
            this.Lbl_columna.Text = "Selecciona una columna";
            // 
            // Lbl_ingresaundato
            // 
            this.Lbl_ingresaundato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ingresaundato.AutoSize = true;
            this.Lbl_ingresaundato.Location = new System.Drawing.Point(510, 20);
            this.Lbl_ingresaundato.Name = "Lbl_ingresaundato";
            this.Lbl_ingresaundato.Size = new System.Drawing.Size(143, 21);
            this.Lbl_ingresaundato.TabIndex = 6;
            this.Lbl_ingresaundato.Text = "Ingresa un dato";
            // 
            // Dtp_dato
            // 
            this.Dtp_dato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtp_dato.Location = new System.Drawing.Point(455, 46);
            this.Dtp_dato.Name = "Dtp_dato";
            this.Dtp_dato.Size = new System.Drawing.Size(258, 27);
            this.Dtp_dato.TabIndex = 7;
            this.Dtp_dato.Visible = false;
            // 
            // Dtp_hora
            // 
            this.Dtp_hora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtp_hora.Location = new System.Drawing.Point(455, 46);
            this.Dtp_hora.Name = "Dtp_hora";
            this.Dtp_hora.Size = new System.Drawing.Size(258, 27);
            this.Dtp_hora.TabIndex = 9;
            this.Dtp_hora.Visible = false;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = global::Capa_Vista_Seguridad.Properties.Resources.ayuda11;
            this.Btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ayuda.Location = new System.Drawing.Point(1033, 25);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(54, 53);
            this.Btn_ayuda.TabIndex = 257;
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // Btn_borrarfiltros
            // 
            this.Btn_borrarfiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_borrarfiltros.BackgroundImage = global::Capa_Vista_Seguridad.Properties.Resources.borrar1;
            this.Btn_borrarfiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_borrarfiltros.FlatAppearance.BorderSize = 0;
            this.Btn_borrarfiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrarfiltros.Location = new System.Drawing.Point(797, 25);
            this.Btn_borrarfiltros.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_borrarfiltros.Name = "Btn_borrarfiltros";
            this.Btn_borrarfiltros.Size = new System.Drawing.Size(54, 53);
            this.Btn_borrarfiltros.TabIndex = 8;
            this.Btn_borrarfiltros.UseVisualStyleBackColor = true;
            this.Btn_borrarfiltros.Click += new System.EventHandler(this.Btn_borrarfiltros_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_buscar.BackgroundImage = global::Capa_Vista_Seguridad.Properties.Resources.buscar1;
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_buscar.FlatAppearance.BorderSize = 0;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Location = new System.Drawing.Point(741, 25);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(54, 53);
            this.Btn_buscar.TabIndex = 4;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_actualizar.BackgroundImage = global::Capa_Vista_Seguridad.Properties.Resources.actualizar__3_;
            this.Btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Location = new System.Drawing.Point(874, 25);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(54, 53);
            this.Btn_actualizar.TabIndex = 1;
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_mostrar_bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1104, 596);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Dtp_hora);
            this.Controls.Add(this.Btn_borrarfiltros);
            this.Controls.Add(this.Dtp_dato);
            this.Controls.Add(this.Lbl_ingresaundato);
            this.Controls.Add(this.Lbl_columna);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Cmb_columna);
            this.Controls.Add(this.Txt_dato);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Dgv_bitacora);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_mostrar_bitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Frm_mostrar_bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_bitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_bitacora;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.TextBox Txt_dato;
        private System.Windows.Forms.ComboBox Cmb_columna;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label Lbl_columna;
        private System.Windows.Forms.Label Lbl_ingresaundato;
        private System.Windows.Forms.DateTimePicker Dtp_dato;
        private System.Windows.Forms.Button Btn_borrarfiltros;
        private System.Windows.Forms.DateTimePicker Dtp_hora;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}