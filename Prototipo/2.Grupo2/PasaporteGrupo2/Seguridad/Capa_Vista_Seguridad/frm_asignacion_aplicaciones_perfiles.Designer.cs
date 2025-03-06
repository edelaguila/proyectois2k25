namespace Capa_Vista_Seguridad
{
    partial class frm_asignacion_aplicaciones_perfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_asignacion_aplicaciones_perfiles));
            this.label3 = new System.Windows.Forms.Label();
            this.Dgv_asignacionesperfiles = new System.Windows.Forms.DataGridView();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingresar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Consultar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Imprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Cbo_modulos = new System.Windows.Forms.ComboBox();
            this.Txt_modulos = new System.Windows.Forms.Label();
            this.Cbo_perfiles = new System.Windows.Forms.ComboBox();
            this.Cbo_aplicaciones = new System.Windows.Forms.ComboBox();
            this.Txt_perfiles = new System.Windows.Forms.Label();
            this.Txt_aplicaciones = new System.Windows.Forms.Label();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_remover = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Dgv_asignaciones = new System.Windows.Forms.DataGridView();
            this.Btn_modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacionesperfiles)).BeginInit();
            this.Gpb_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 44);
            this.label3.TabIndex = 274;
            // 
            // Dgv_asignacionesperfiles
            // 
            this.Dgv_asignacionesperfiles.AllowUserToAddRows = false;
            this.Dgv_asignacionesperfiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Dgv_asignacionesperfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignacionesperfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Perfil,
            this.Aplicacion,
            this.Ingresar,
            this.Consultar,
            this.Modificar,
            this.Eliminar,
            this.Imprimir});
            this.Dgv_asignacionesperfiles.Location = new System.Drawing.Point(29, 328);
            this.Dgv_asignacionesperfiles.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_asignacionesperfiles.Name = "Dgv_asignacionesperfiles";
            this.Dgv_asignacionesperfiles.RowHeadersWidth = 51;
            this.Dgv_asignacionesperfiles.Size = new System.Drawing.Size(729, 212);
            this.Dgv_asignacionesperfiles.TabIndex = 272;
            this.Dgv_asignacionesperfiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_asignacionesperfiles_CellContentClick_1);
            // 
            // Perfil
            // 
            this.Perfil.FillWeight = 117.8203F;
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.MinimumWidth = 6;
            this.Perfil.Name = "Perfil";
            this.Perfil.Width = 148;
            // 
            // Aplicacion
            // 
            this.Aplicacion.FillWeight = 115.2093F;
            this.Aplicacion.HeaderText = "Aplicacion";
            this.Aplicacion.MinimumWidth = 6;
            this.Aplicacion.Name = "Aplicacion";
            this.Aplicacion.Width = 149;
            // 
            // Ingresar
            // 
            this.Ingresar.FalseValue = "0";
            this.Ingresar.FillWeight = 85.63838F;
            this.Ingresar.HeaderText = "Ingresar";
            this.Ingresar.MinimumWidth = 6;
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.TrueValue = "1";
            this.Ingresar.Width = 72;
            // 
            // Consultar
            // 
            this.Consultar.FalseValue = "0";
            this.Consultar.FillWeight = 88.13612F;
            this.Consultar.HeaderText = "Consultar";
            this.Consultar.MinimumWidth = 6;
            this.Consultar.Name = "Consultar";
            this.Consultar.TrueValue = "1";
            this.Consultar.Width = 75;
            // 
            // Modificar
            // 
            this.Modificar.FalseValue = "0";
            this.Modificar.FillWeight = 90.35796F;
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.MinimumWidth = 6;
            this.Modificar.Name = "Modificar";
            this.Modificar.TrueValue = "1";
            this.Modificar.Width = 77;
            // 
            // Eliminar
            // 
            this.Eliminar.FalseValue = "0";
            this.Eliminar.FillWeight = 92.33439F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.TrueValue = "1";
            this.Eliminar.Width = 78;
            // 
            // Imprimir
            // 
            this.Imprimir.FalseValue = "0";
            this.Imprimir.FillWeight = 94.09251F;
            this.Imprimir.HeaderText = "Imprimir";
            this.Imprimir.MinimumWidth = 6;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.TrueValue = "1";
            this.Imprimir.Width = 80;
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datos.Controls.Add(this.Cbo_modulos);
            this.Gpb_datos.Controls.Add(this.Txt_modulos);
            this.Gpb_datos.Controls.Add(this.Cbo_perfiles);
            this.Gpb_datos.Controls.Add(this.Cbo_aplicaciones);
            this.Gpb_datos.Controls.Add(this.Txt_perfiles);
            this.Gpb_datos.Controls.Add(this.Txt_aplicaciones);
            this.Gpb_datos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.Location = new System.Drawing.Point(286, 209);
            this.Gpb_datos.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Size = new System.Drawing.Size(739, 101);
            this.Gpb_datos.TabIndex = 273;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // Cbo_modulos
            // 
            this.Cbo_modulos.BackColor = System.Drawing.Color.White;
            this.Cbo_modulos.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbo_modulos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_modulos.FormattingEnabled = true;
            this.Cbo_modulos.Location = new System.Drawing.Point(300, 51);
            this.Cbo_modulos.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_modulos.Name = "Cbo_modulos";
            this.Cbo_modulos.Size = new System.Drawing.Size(160, 27);
            this.Cbo_modulos.TabIndex = 14;
            // 
            // Txt_modulos
            // 
            this.Txt_modulos.AutoSize = true;
            this.Txt_modulos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_modulos.Location = new System.Drawing.Point(348, 26);
            this.Txt_modulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_modulos.Name = "Txt_modulos";
            this.Txt_modulos.Size = new System.Drawing.Size(80, 22);
            this.Txt_modulos.TabIndex = 13;
            this.Txt_modulos.Text = "Modulos";
            // 
            // Cbo_perfiles
            // 
            this.Cbo_perfiles.BackColor = System.Drawing.Color.White;
            this.Cbo_perfiles.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_perfiles.FormattingEnabled = true;
            this.Cbo_perfiles.Location = new System.Drawing.Point(96, 51);
            this.Cbo_perfiles.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_perfiles.Name = "Cbo_perfiles";
            this.Cbo_perfiles.Size = new System.Drawing.Size(160, 27);
            this.Cbo_perfiles.TabIndex = 0;
            // 
            // Cbo_aplicaciones
            // 
            this.Cbo_aplicaciones.BackColor = System.Drawing.Color.White;
            this.Cbo_aplicaciones.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_aplicaciones.FormattingEnabled = true;
            this.Cbo_aplicaciones.Location = new System.Drawing.Point(502, 51);
            this.Cbo_aplicaciones.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_aplicaciones.Name = "Cbo_aplicaciones";
            this.Cbo_aplicaciones.Size = new System.Drawing.Size(160, 27);
            this.Cbo_aplicaciones.TabIndex = 1;
            this.Cbo_aplicaciones.SelectedIndexChanged += new System.EventHandler(this.Cbo_aplicaciones_SelectedIndexChanged_1);
            // 
            // Txt_perfiles
            // 
            this.Txt_perfiles.AutoSize = true;
            this.Txt_perfiles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_perfiles.Location = new System.Drawing.Point(142, 26);
            this.Txt_perfiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_perfiles.Name = "Txt_perfiles";
            this.Txt_perfiles.Size = new System.Drawing.Size(72, 22);
            this.Txt_perfiles.TabIndex = 2;
            this.Txt_perfiles.Text = "Perfiles";
            // 
            // Txt_aplicaciones
            // 
            this.Txt_aplicaciones.AutoSize = true;
            this.Txt_aplicaciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_aplicaciones.Location = new System.Drawing.Point(526, 25);
            this.Txt_aplicaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_aplicaciones.Name = "Txt_aplicaciones";
            this.Txt_aplicaciones.Size = new System.Drawing.Size(115, 22);
            this.Txt_aplicaciones.TabIndex = 3;
            this.Txt_aplicaciones.Text = "Aplicaciones";
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_titulo.ForeColor = System.Drawing.Color.Transparent;
            this.Txt_titulo.Location = new System.Drawing.Point(278, 59);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(774, 45);
            this.Txt_titulo.TabIndex = 283;
            this.Txt_titulo.Text = "A s i g n a c i o n  d e  A p l i c a c i o n e s  a  P e r f i l e s";
            this.Txt_titulo.Click += new System.EventHandler(this.label4_Click);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Image = global::Capa_Vista_Seguridad.Properties.Resources.agregar11;
            this.Btn_agregar.Location = new System.Drawing.Point(286, 134);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(69, 57);
            this.Btn_agregar.TabIndex = 279;
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click_1);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = global::Capa_Vista_Seguridad.Properties.Resources.ayuda11;
            this.Btn_ayuda.Location = new System.Drawing.Point(956, 134);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(69, 57);
            this.Btn_ayuda.TabIndex = 280;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click_1);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Image = global::Capa_Vista_Seguridad.Properties.Resources.salir11;
            this.Btn_salir.Location = new System.Drawing.Point(887, 134);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(69, 57);
            this.Btn_salir.TabIndex = 277;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_buscar.FlatAppearance.BorderSize = 0;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Image = global::Capa_Vista_Seguridad.Properties.Resources.buscar11;
            this.Btn_buscar.Location = new System.Drawing.Point(562, 134);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(69, 57);
            this.Btn_buscar.TabIndex = 278;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
            // 
            // Btn_remover
            // 
            this.Btn_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_remover.FlatAppearance.BorderSize = 0;
            this.Btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_remover.Image = global::Capa_Vista_Seguridad.Properties.Resources.borrar11;
            this.Btn_remover.Location = new System.Drawing.Point(631, 134);
            this.Btn_remover.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_remover.Name = "Btn_remover";
            this.Btn_remover.Size = new System.Drawing.Size(69, 57);
            this.Btn_remover.TabIndex = 281;
            this.Btn_remover.UseVisualStyleBackColor = false;
            this.Btn_remover.Click += new System.EventHandler(this.btn_remover_Click_1);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Image = global::Capa_Vista_Seguridad.Properties.Resources.guardar12;
            this.Btn_guardar.Location = new System.Drawing.Point(355, 134);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(69, 57);
            this.Btn_guardar.TabIndex = 276;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.btn_finalizar_Click_1);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Image = global::Capa_Vista_Seguridad.Properties.Resources.cancelar1;
            this.Btn_cancelar.Location = new System.Drawing.Point(493, 134);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(69, 57);
            this.Btn_cancelar.TabIndex = 292;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Dgv_asignaciones
            // 
            this.Dgv_asignaciones.AllowUserToAddRows = false;
            this.Dgv_asignaciones.AllowUserToDeleteRows = false;
            this.Dgv_asignaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_asignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignaciones.Location = new System.Drawing.Point(775, 328);
            this.Dgv_asignaciones.Name = "Dgv_asignaciones";
            this.Dgv_asignaciones.ReadOnly = true;
            this.Dgv_asignaciones.RowHeadersWidth = 72;
            this.Dgv_asignaciones.RowTemplate.Height = 31;
            this.Dgv_asignaciones.Size = new System.Drawing.Size(501, 212);
            this.Dgv_asignaciones.TabIndex = 293;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_modificar.FlatAppearance.BorderSize = 0;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Image = global::Capa_Vista_Seguridad.Properties.Resources.editar11;
            this.Btn_modificar.Location = new System.Drawing.Point(424, 134);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(69, 57);
            this.Btn_modificar.TabIndex = 295;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // frm_asignacion_aplicaciones_perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1288, 574);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Dgv_asignaciones);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_remover);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dgv_asignacionesperfiles);
            this.Controls.Add(this.Gpb_datos);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_asignacion_aplicaciones_perfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de aplicaciones a perfiles";
            this.Load += new System.EventHandler(this.Frm_asignacion_aplicaciones_perfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacionesperfiles)).EndInit();
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_remover;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dgv_asignacionesperfiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aplicacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ingresar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Consultar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Modificar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Imprimir;
        private System.Windows.Forms.GroupBox Gpb_datos;
        public System.Windows.Forms.ComboBox Cbo_modulos;
        private System.Windows.Forms.Label Txt_modulos;
        public System.Windows.Forms.ComboBox Cbo_perfiles;
        private System.Windows.Forms.ComboBox Cbo_aplicaciones;
        private System.Windows.Forms.Label Txt_perfiles;
        private System.Windows.Forms.Label Txt_aplicaciones;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.DataGridView Dgv_asignaciones;
        private System.Windows.Forms.Button Btn_modificar;
    }
}