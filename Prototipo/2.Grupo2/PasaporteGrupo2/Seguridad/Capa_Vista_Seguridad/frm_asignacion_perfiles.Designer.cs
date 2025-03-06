namespace Capa_Vista_Seguridad
{
    partial class frm_asignacion_perfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_asignacion_perfiles));
            this.Gpb_consulta = new System.Windows.Forms.GroupBox();
            this.Dgv_perfiles_asignados = new System.Windows.Forms.DataGridView();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.lbl_perfiles = new System.Windows.Forms.Label();
            this.Cbo_perfiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbo_usuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Dgv_asignacion_perfiles = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.Gpb_vista_previa = new System.Windows.Forms.GroupBox();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_remover = new System.Windows.Forms.Button();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_bsucar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_perfiles_asignados)).BeginInit();
            this.Gpb_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion_perfiles)).BeginInit();
            this.Gpb_vista_previa.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_consulta
            // 
            this.Gpb_consulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_consulta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_consulta.Location = new System.Drawing.Point(44, 370);
            this.Gpb_consulta.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_consulta.Name = "Gpb_consulta";
            this.Gpb_consulta.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_consulta.Size = new System.Drawing.Size(711, 211);
            this.Gpb_consulta.TabIndex = 4;
            this.Gpb_consulta.TabStop = false;
            this.Gpb_consulta.Text = "Consulta de Perfiles de Usuarios";
            // 
            // Dgv_perfiles_asignados
            // 
            this.Dgv_perfiles_asignados.AllowUserToAddRows = false;
            this.Dgv_perfiles_asignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_perfiles_asignados.Location = new System.Drawing.Point(55, 397);
            this.Dgv_perfiles_asignados.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_perfiles_asignados.Name = "Dgv_perfiles_asignados";
            this.Dgv_perfiles_asignados.RowHeadersWidth = 51;
            this.Dgv_perfiles_asignados.Size = new System.Drawing.Size(641, 175);
            this.Dgv_perfiles_asignados.TabIndex = 8;
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datos.Controls.Add(this.lbl_perfiles);
            this.Gpb_datos.Controls.Add(this.Cbo_perfiles);
            this.Gpb_datos.Controls.Add(this.label1);
            this.Gpb_datos.Controls.Add(this.Cbo_usuario);
            this.Gpb_datos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.Location = new System.Drawing.Point(44, 161);
            this.Gpb_datos.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Size = new System.Drawing.Size(256, 188);
            this.Gpb_datos.TabIndex = 5;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // lbl_perfiles
            // 
            this.lbl_perfiles.AutoSize = true;
            this.lbl_perfiles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perfiles.Location = new System.Drawing.Point(80, 92);
            this.lbl_perfiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_perfiles.Name = "lbl_perfiles";
            this.lbl_perfiles.Size = new System.Drawing.Size(53, 19);
            this.lbl_perfiles.TabIndex = 7;
            this.lbl_perfiles.Text = "Perfiles";
            // 
            // Cbo_perfiles
            // 
            this.Cbo_perfiles.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_perfiles.FormattingEnabled = true;
            this.Cbo_perfiles.Location = new System.Drawing.Point(11, 127);
            this.Cbo_perfiles.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_perfiles.Name = "Cbo_perfiles";
            this.Cbo_perfiles.Size = new System.Drawing.Size(199, 23);
            this.Cbo_perfiles.TabIndex = 6;
            this.Cbo_perfiles.SelectedIndexChanged += new System.EventHandler(this.Cbo_perfiles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // Cbo_usuario
            // 
            this.Cbo_usuario.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_usuario.FormattingEnabled = true;
            this.Cbo_usuario.Location = new System.Drawing.Point(11, 54);
            this.Cbo_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_usuario.Name = "Cbo_usuario";
            this.Cbo_usuario.Size = new System.Drawing.Size(199, 23);
            this.Cbo_usuario.TabIndex = 4;
            this.Cbo_usuario.SelectedIndexChanged += new System.EventHandler(this.Cbo_usuario_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 6;
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_titulo.ForeColor = System.Drawing.Color.Transparent;
            this.Txt_titulo.Location = new System.Drawing.Point(132, 18);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(554, 37);
            this.Txt_titulo.TabIndex = 259;
            this.Txt_titulo.Text = "A s i g n a c i o n   d e  p e r f i l e s   a   U s u a r i o s";
            // 
            // Dgv_asignacion_perfiles
            // 
            this.Dgv_asignacion_perfiles.AllowUserToAddRows = false;
            this.Dgv_asignacion_perfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignacion_perfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.NombrePerfil});
            this.Dgv_asignacion_perfiles.Location = new System.Drawing.Point(388, 188);
            this.Dgv_asignacion_perfiles.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_asignacion_perfiles.Name = "Dgv_asignacion_perfiles";
            this.Dgv_asignacion_perfiles.RowHeadersWidth = 51;
            this.Dgv_asignacion_perfiles.Size = new System.Drawing.Size(325, 148);
            this.Dgv_asignacion_perfiles.TabIndex = 266;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 140;
            // 
            // NombrePerfil
            // 
            this.NombrePerfil.HeaderText = "Perfil";
            this.NombrePerfil.MinimumWidth = 6;
            this.NombrePerfil.Name = "NombrePerfil";
            this.NombrePerfil.Width = 140;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 5;
            // 
            // Gpb_vista_previa
            // 
            this.Gpb_vista_previa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_vista_previa.Controls.Add(this.label5);
            this.Gpb_vista_previa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_vista_previa.Location = new System.Drawing.Point(290, 161);
            this.Gpb_vista_previa.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_vista_previa.Name = "Gpb_vista_previa";
            this.Gpb_vista_previa.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_vista_previa.Size = new System.Drawing.Size(493, 188);
            this.Gpb_vista_previa.TabIndex = 8;
            this.Gpb_vista_previa.TabStop = false;
            this.Gpb_vista_previa.Text = "Vista Previa";
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = global::Capa_Vista_Seguridad.Properties.Resources.ayuda11;
            this.Btn_ayuda.Location = new System.Drawing.Point(714, 83);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(69, 57);
            this.Btn_ayuda.TabIndex = 267;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click_1);
            // 
            // Btn_remover
            // 
            this.Btn_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_remover.FlatAppearance.BorderSize = 0;
            this.Btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_remover.Image = global::Capa_Vista_Seguridad.Properties.Resources.borrar11;
            this.Btn_remover.Location = new System.Drawing.Point(183, 83);
            this.Btn_remover.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_remover.Name = "Btn_remover";
            this.Btn_remover.Size = new System.Drawing.Size(69, 57);
            this.Btn_remover.TabIndex = 260;
            this.Btn_remover.UseVisualStyleBackColor = false;
            this.Btn_remover.Click += new System.EventHandler(this.Btn_remover_Click);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Image = global::Capa_Vista_Seguridad.Properties.Resources.agregar11;
            this.Btn_agregar.Location = new System.Drawing.Point(45, 83);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(69, 57);
            this.Btn_agregar.TabIndex = 258;
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Image = global::Capa_Vista_Seguridad.Properties.Resources.guardar12;
            this.Btn_guardar.Location = new System.Drawing.Point(114, 83);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(69, 57);
            this.Btn_guardar.TabIndex = 261;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Image = global::Capa_Vista_Seguridad.Properties.Resources.cancelar1;
            this.Btn_cancelar.Location = new System.Drawing.Point(252, 83);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(69, 57);
            this.Btn_cancelar.TabIndex = 291;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Image = global::Capa_Vista_Seguridad.Properties.Resources.salir11;
            this.Btn_salir.Location = new System.Drawing.Point(645, 83);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(69, 57);
            this.Btn_salir.TabIndex = 262;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_modificar.FlatAppearance.BorderSize = 0;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Image = global::Capa_Vista_Seguridad.Properties.Resources.editar11;
            this.Btn_modificar.Location = new System.Drawing.Point(319, 83);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(69, 57);
            this.Btn_modificar.TabIndex = 305;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Image = global::Capa_Vista_Seguridad.Properties.Resources.guardar21;
            this.Btn_actualizar.Location = new System.Drawing.Point(388, 83);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(69, 57);
            this.Btn_actualizar.TabIndex = 304;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // Btn_bsucar
            // 
            this.Btn_bsucar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_bsucar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_bsucar.FlatAppearance.BorderSize = 0;
            this.Btn_bsucar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_bsucar.Image = global::Capa_Vista_Seguridad.Properties.Resources.buscar11;
            this.Btn_bsucar.Location = new System.Drawing.Point(457, 83);
            this.Btn_bsucar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_bsucar.Name = "Btn_bsucar";
            this.Btn_bsucar.Size = new System.Drawing.Size(65, 57);
            this.Btn_bsucar.TabIndex = 306;
            this.Btn_bsucar.UseVisualStyleBackColor = false;
            // 
            // frm_asignacion_perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(865, 601);
            this.Controls.Add(this.Btn_bsucar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Btn_remover);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Dgv_perfiles_asignados);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Dgv_asignacion_perfiles);
            this.Controls.Add(this.Gpb_vista_previa);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gpb_datos);
            this.Controls.Add(this.Gpb_consulta);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_asignacion_perfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de Perfiles a Usuarios";
            this.Load += new System.EventHandler(this.Frm_asignacion_perfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_perfiles_asignados)).EndInit();
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion_perfiles)).EndInit();
            this.Gpb_vista_previa.ResumeLayout(false);
            this.Gpb_vista_previa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Gpb_consulta;
        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.Label lbl_perfiles;
        private System.Windows.Forms.ComboBox Cbo_perfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_perfiles_asignados;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_remover;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.DataGridView Dgv_asignacion_perfiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Gpb_vista_previa;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_bsucar;
    }
}