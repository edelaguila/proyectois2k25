namespace Capa_Vista_Seguridad
{
    partial class frm_perfiles_mantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_perfiles_mantenimiento));
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Gpb_buscarperfiles = new System.Windows.Forms.GroupBox();
            this.Cbo_buscar = new System.Windows.Forms.ComboBox();
            this.Btn_buscarperfil = new System.Windows.Forms.Button();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Txt_descipcion = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Txt_descripciondat = new System.Windows.Forms.Label();
            this.Txt_nombredat = new System.Windows.Forms.Label();
            this.Txt_codigoperfil = new System.Windows.Forms.Label();
            this.Gpb_estado = new System.Windows.Forms.GroupBox();
            this.Rdb_inhabilitado = new System.Windows.Forms.RadioButton();
            this.Rdb_habilitado = new System.Windows.Forms.RadioButton();
            this.Btn_ingreso = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Dgv_perfiles = new System.Windows.Forms.DataGridView();
            this.Gpb_buscarperfiles.SuspendLayout();
            this.Gpb_datos.SuspendLayout();
            this.Gpb_estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_perfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_titulo.ForeColor = System.Drawing.Color.Transparent;
            this.Txt_titulo.Location = new System.Drawing.Point(258, 14);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(399, 44);
            this.Txt_titulo.TabIndex = 274;
            this.Txt_titulo.Text = "MANTENIMIENTO DE PERFILES ";
            // 
            // Gpb_buscarperfiles
            // 
            this.Gpb_buscarperfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_buscarperfiles.Controls.Add(this.Cbo_buscar);
            this.Gpb_buscarperfiles.Controls.Add(this.Btn_buscarperfil);
            this.Gpb_buscarperfiles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_buscarperfiles.Location = new System.Drawing.Point(95, 258);
            this.Gpb_buscarperfiles.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_buscarperfiles.Name = "Gpb_buscarperfiles";
            this.Gpb_buscarperfiles.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_buscarperfiles.Size = new System.Drawing.Size(310, 126);
            this.Gpb_buscarperfiles.TabIndex = 273;
            this.Gpb_buscarperfiles.TabStop = false;
            this.Gpb_buscarperfiles.Text = "Buscar perfiles";
            // 
            // Cbo_buscar
            // 
            this.Cbo_buscar.FormattingEnabled = true;
            this.Cbo_buscar.Location = new System.Drawing.Point(29, 46);
            this.Cbo_buscar.Name = "Cbo_buscar";
            this.Cbo_buscar.Size = new System.Drawing.Size(121, 31);
            this.Cbo_buscar.TabIndex = 267;
            // 
            // Btn_buscarperfil
            // 
            this.Btn_buscarperfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_buscarperfil.FlatAppearance.BorderSize = 0;
            this.Btn_buscarperfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscarperfil.Image = global::Capa_Vista_Seguridad.Properties.Resources.buscar11;
            this.Btn_buscarperfil.Location = new System.Drawing.Point(194, 33);
            this.Btn_buscarperfil.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_buscarperfil.Name = "Btn_buscarperfil";
            this.Btn_buscarperfil.Size = new System.Drawing.Size(69, 57);
            this.Btn_buscarperfil.TabIndex = 266;
            this.Btn_buscarperfil.UseVisualStyleBackColor = true;
            this.Btn_buscarperfil.Click += new System.EventHandler(this.btn_bsucarperfil_Click);
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datos.Controls.Add(this.Txt_descipcion);
            this.Gpb_datos.Controls.Add(this.Txt_nombre);
            this.Gpb_datos.Controls.Add(this.Txt_codigo);
            this.Gpb_datos.Controls.Add(this.Txt_descripciondat);
            this.Gpb_datos.Controls.Add(this.Txt_nombredat);
            this.Gpb_datos.Controls.Add(this.Txt_codigoperfil);
            this.Gpb_datos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.Location = new System.Drawing.Point(95, 146);
            this.Gpb_datos.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Size = new System.Drawing.Size(661, 100);
            this.Gpb_datos.TabIndex = 272;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // Txt_descipcion
            // 
            this.Txt_descipcion.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descipcion.Location = new System.Drawing.Point(386, 52);
            this.Txt_descipcion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_descipcion.Multiline = true;
            this.Txt_descipcion.Name = "Txt_descipcion";
            this.Txt_descipcion.Size = new System.Drawing.Size(258, 26);
            this.Txt_descipcion.TabIndex = 6;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(216, 51);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(151, 27);
            this.Txt_nombre.TabIndex = 5;
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigo.Location = new System.Drawing.Point(55, 52);
            this.Txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(137, 27);
            this.Txt_codigo.TabIndex = 4;
            // 
            // Txt_descripciondat
            // 
            this.Txt_descripciondat.AutoSize = true;
            this.Txt_descripciondat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripciondat.Location = new System.Drawing.Point(453, 22);
            this.Txt_descripciondat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_descripciondat.Name = "Txt_descripciondat";
            this.Txt_descripciondat.Size = new System.Drawing.Size(107, 22);
            this.Txt_descripciondat.TabIndex = 2;
            this.Txt_descripciondat.Text = "Descripción";
            // 
            // Txt_nombredat
            // 
            this.Txt_nombredat.AutoSize = true;
            this.Txt_nombredat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombredat.Location = new System.Drawing.Point(254, 22);
            this.Txt_nombredat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_nombredat.Name = "Txt_nombredat";
            this.Txt_nombredat.Size = new System.Drawing.Size(74, 22);
            this.Txt_nombredat.TabIndex = 1;
            this.Txt_nombredat.Text = "Nombre";
            // 
            // Txt_codigoperfil
            // 
            this.Txt_codigoperfil.AutoSize = true;
            this.Txt_codigoperfil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigoperfil.Location = new System.Drawing.Point(51, 22);
            this.Txt_codigoperfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_codigoperfil.Name = "Txt_codigoperfil";
            this.Txt_codigoperfil.Size = new System.Drawing.Size(141, 22);
            this.Txt_codigoperfil.TabIndex = 0;
            this.Txt_codigoperfil.Text = "Codigo de perfil";
            // 
            // Gpb_estado
            // 
            this.Gpb_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_estado.Controls.Add(this.Rdb_inhabilitado);
            this.Gpb_estado.Controls.Add(this.Rdb_habilitado);
            this.Gpb_estado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_estado.Location = new System.Drawing.Point(426, 258);
            this.Gpb_estado.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_estado.Name = "Gpb_estado";
            this.Gpb_estado.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_estado.Size = new System.Drawing.Size(330, 126);
            this.Gpb_estado.TabIndex = 271;
            this.Gpb_estado.TabStop = false;
            this.Gpb_estado.Text = "Estado";
            // 
            // Rdb_inhabilitado
            // 
            this.Rdb_inhabilitado.AutoSize = true;
            this.Rdb_inhabilitado.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_inhabilitado.Location = new System.Drawing.Point(190, 46);
            this.Rdb_inhabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_inhabilitado.Name = "Rdb_inhabilitado";
            this.Rdb_inhabilitado.Size = new System.Drawing.Size(110, 23);
            this.Rdb_inhabilitado.TabIndex = 1;
            this.Rdb_inhabilitado.TabStop = true;
            this.Rdb_inhabilitado.Text = "Inhabilitado";
            this.Rdb_inhabilitado.UseVisualStyleBackColor = true;
            // 
            // Rdb_habilitado
            // 
            this.Rdb_habilitado.AutoSize = true;
            this.Rdb_habilitado.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_habilitado.Location = new System.Drawing.Point(47, 46);
            this.Rdb_habilitado.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_habilitado.Name = "Rdb_habilitado";
            this.Rdb_habilitado.Size = new System.Drawing.Size(101, 23);
            this.Rdb_habilitado.TabIndex = 0;
            this.Rdb_habilitado.TabStop = true;
            this.Rdb_habilitado.Text = "Habilitado";
            this.Rdb_habilitado.UseVisualStyleBackColor = true;
            // 
            // Btn_ingreso
            // 
            this.Btn_ingreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_ingreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ingreso.FlatAppearance.BorderSize = 0;
            this.Btn_ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingreso.Image = global::Capa_Vista_Seguridad.Properties.Resources.agregar11;
            this.Btn_ingreso.Location = new System.Drawing.Point(95, 71);
            this.Btn_ingreso.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ingreso.Name = "Btn_ingreso";
            this.Btn_ingreso.Size = new System.Drawing.Size(69, 57);
            this.Btn_ingreso.TabIndex = 275;
            this.Btn_ingreso.UseVisualStyleBackColor = false;
            this.Btn_ingreso.Click += new System.EventHandler(this.btn_nuevo_Click_1);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Image = global::Capa_Vista_Seguridad.Properties.Resources.salir11;
            this.Btn_salir.Location = new System.Drawing.Point(616, 71);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(69, 57);
            this.Btn_salir.TabIndex = 277;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Image = global::Capa_Vista_Seguridad.Properties.Resources.borrar11;
            this.Btn_eliminar.Location = new System.Drawing.Point(371, 71);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(69, 57);
            this.Btn_eliminar.TabIndex = 282;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.btn_eli_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Image = global::Capa_Vista_Seguridad.Properties.Resources.cancelar1;
            this.Btn_cancelar.Location = new System.Drawing.Point(440, 71);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(69, 57);
            this.Btn_cancelar.TabIndex = 278;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Image = global::Capa_Vista_Seguridad.Properties.Resources.guardar21;
            this.Btn_actualizar.Location = new System.Drawing.Point(233, 71);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(69, 57);
            this.Btn_actualizar.TabIndex = 280;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = global::Capa_Vista_Seguridad.Properties.Resources.ayuda11;
            this.Btn_ayuda.Location = new System.Drawing.Point(685, 71);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(69, 57);
            this.Btn_ayuda.TabIndex = 279;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_modificar.FlatAppearance.BorderSize = 0;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Image = global::Capa_Vista_Seguridad.Properties.Resources.editar11;
            this.Btn_modificar.Location = new System.Drawing.Point(302, 71);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(69, 57);
            this.Btn_modificar.TabIndex = 281;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Image = global::Capa_Vista_Seguridad.Properties.Resources.guardar12;
            this.Btn_guardar.Location = new System.Drawing.Point(164, 71);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(69, 57);
            this.Btn_guardar.TabIndex = 276;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // Dgv_perfiles
            // 
            this.Dgv_perfiles.AllowUserToAddRows = false;
            this.Dgv_perfiles.AllowUserToDeleteRows = false;
            this.Dgv_perfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_perfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_perfiles.Location = new System.Drawing.Point(95, 391);
            this.Dgv_perfiles.Name = "Dgv_perfiles";
            this.Dgv_perfiles.ReadOnly = true;
            this.Dgv_perfiles.RowHeadersWidth = 72;
            this.Dgv_perfiles.RowTemplate.Height = 31;
            this.Dgv_perfiles.Size = new System.Drawing.Size(661, 182);
            this.Dgv_perfiles.TabIndex = 283;
            // 
            // frm_perfiles_mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(867, 580);
            this.Controls.Add(this.Dgv_perfiles);
            this.Controls.Add(this.Btn_ingreso);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.Gpb_buscarperfiles);
            this.Controls.Add(this.Gpb_datos);
            this.Controls.Add(this.Gpb_estado);
            this.Controls.Add(this.Btn_ayuda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_perfiles_mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Perfiles";
            this.Load += new System.EventHandler(this.Frm_perfiles_mantenimiento_Load);
            this.Gpb_buscarperfiles.ResumeLayout(false);
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.Gpb_estado.ResumeLayout(false);
            this.Gpb_estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_perfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_ingreso;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.GroupBox Gpb_buscarperfiles;
        private System.Windows.Forms.Button Btn_buscarperfil;
        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.TextBox Txt_descipcion;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label Txt_descripciondat;
        private System.Windows.Forms.Label Txt_nombredat;
        private System.Windows.Forms.Label Txt_codigoperfil;
        private System.Windows.Forms.GroupBox Gpb_estado;
        private System.Windows.Forms.RadioButton Rdb_inhabilitado;
        private System.Windows.Forms.RadioButton Rdb_habilitado;
        private System.Windows.Forms.DataGridView Dgv_perfiles;
        private System.Windows.Forms.ComboBox Cbo_buscar;
    }
}