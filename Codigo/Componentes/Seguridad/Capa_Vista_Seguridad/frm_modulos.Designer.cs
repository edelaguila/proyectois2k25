namespace Capa_Vista_Seguridad
{
    partial class frmMantemientoMódulos
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
            this.Gpb_buscar = new System.Windows.Forms.GroupBox();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Gpb_estado = new System.Windows.Forms.GroupBox();
            this.Rdb_inhabilitado = new System.Windows.Forms.RadioButton();
            this.Rdb_habilitado = new System.Windows.Forms.RadioButton();
            this.Txt_descripcionmodulo = new System.Windows.Forms.Label();
            this.Txt_nombremodulo = new System.Windows.Forms.Label();
            this.Txt_id = new System.Windows.Forms.Label();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Dgv_modulos = new System.Windows.Forms.DataGridView();
            this.Gpb_buscar.SuspendLayout();
            this.Gpb_datos.SuspendLayout();
            this.Gpb_estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_modulos)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_buscar
            // 
            this.Gpb_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_buscar.Controls.Add(this.Txt_buscar);
            this.Gpb_buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_buscar.Location = new System.Drawing.Point(154, 132);
            this.Gpb_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_buscar.Name = "Gpb_buscar";
            this.Gpb_buscar.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_buscar.Size = new System.Drawing.Size(651, 98);
            this.Gpb_buscar.TabIndex = 255;
            this.Gpb_buscar.TabStop = false;
            this.Gpb_buscar.Text = "Buscar Módulo";
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(37, 36);
            this.Txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(573, 30);
            this.Txt_buscar.TabIndex = 6;
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datos.Controls.Add(this.Dgv_modulos);
            this.Gpb_datos.Controls.Add(this.Txt_nombre);
            this.Gpb_datos.Controls.Add(this.Txt_codigo);
            this.Gpb_datos.Controls.Add(this.Gpb_estado);
            this.Gpb_datos.Controls.Add(this.Txt_descripcionmodulo);
            this.Gpb_datos.Controls.Add(this.Txt_nombremodulo);
            this.Gpb_datos.Controls.Add(this.Txt_id);
            this.Gpb_datos.Controls.Add(this.Txt_descripcion);
            this.Gpb_datos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.Location = new System.Drawing.Point(156, 238);
            this.Gpb_datos.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Size = new System.Drawing.Size(648, 421);
            this.Gpb_datos.TabIndex = 254;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(245, 69);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nombre.Multiline = true;
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(296, 26);
            this.Txt_nombre.TabIndex = 2;
            this.Txt_nombre.Tag = "2";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigo.Location = new System.Drawing.Point(246, 27);
            this.Txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(297, 28);
            this.Txt_codigo.TabIndex = 4;
            // 
            // Gpb_estado
            // 
            this.Gpb_estado.Controls.Add(this.Rdb_inhabilitado);
            this.Gpb_estado.Controls.Add(this.Rdb_habilitado);
            this.Gpb_estado.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_estado.Location = new System.Drawing.Point(102, 144);
            this.Gpb_estado.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_estado.Name = "Gpb_estado";
            this.Gpb_estado.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_estado.Size = new System.Drawing.Size(441, 76);
            this.Gpb_estado.TabIndex = 3;
            this.Gpb_estado.TabStop = false;
            this.Gpb_estado.Text = "Estado";
            // 
            // Rdb_inhabilitado
            // 
            this.Rdb_inhabilitado.AutoSize = true;
            this.Rdb_inhabilitado.Location = new System.Drawing.Point(248, 29);
            this.Rdb_inhabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_inhabilitado.Name = "Rdb_inhabilitado";
            this.Rdb_inhabilitado.Size = new System.Drawing.Size(131, 25);
            this.Rdb_inhabilitado.TabIndex = 1;
            this.Rdb_inhabilitado.TabStop = true;
            this.Rdb_inhabilitado.Text = "Inhabilitado";
            this.Rdb_inhabilitado.UseVisualStyleBackColor = true;
            // 
            // Rdb_habilitado
            // 
            this.Rdb_habilitado.AutoSize = true;
            this.Rdb_habilitado.Location = new System.Drawing.Point(74, 29);
            this.Rdb_habilitado.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_habilitado.Name = "Rdb_habilitado";
            this.Rdb_habilitado.Size = new System.Drawing.Size(118, 25);
            this.Rdb_habilitado.TabIndex = 0;
            this.Rdb_habilitado.TabStop = true;
            this.Rdb_habilitado.Text = "Habilitado";
            this.Rdb_habilitado.UseVisualStyleBackColor = true;
            this.Rdb_habilitado.CheckedChanged += new System.EventHandler(this.Rdb_habilitado_CheckedChanged);
            // 
            // Txt_descripcionmodulo
            // 
            this.Txt_descripcionmodulo.AutoSize = true;
            this.Txt_descripcionmodulo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcionmodulo.Location = new System.Drawing.Point(69, 111);
            this.Txt_descripcionmodulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_descripcionmodulo.Name = "Txt_descripcionmodulo";
            this.Txt_descripcionmodulo.Size = new System.Drawing.Size(107, 21);
            this.Txt_descripcionmodulo.TabIndex = 2;
            this.Txt_descripcionmodulo.Text = "Descripción";
            // 
            // Txt_nombremodulo
            // 
            this.Txt_nombremodulo.AutoSize = true;
            this.Txt_nombremodulo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombremodulo.Location = new System.Drawing.Point(69, 69);
            this.Txt_nombremodulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_nombremodulo.Name = "Txt_nombremodulo";
            this.Txt_nombremodulo.Size = new System.Drawing.Size(77, 21);
            this.Txt_nombremodulo.TabIndex = 1;
            this.Txt_nombremodulo.Text = "Nombre";
            // 
            // Txt_id
            // 
            this.Txt_id.AutoSize = true;
            this.Txt_id.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id.Location = new System.Drawing.Point(69, 27);
            this.Txt_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(169, 21);
            this.Txt_id.TabIndex = 0;
            this.Txt_id.Text = "Código de Módulo";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcion.Location = new System.Drawing.Point(244, 108);
            this.Txt_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(297, 28);
            this.Txt_descripcion.TabIndex = 1;
            this.Txt_descripcion.Tag = "1";
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_titulo.ForeColor = System.Drawing.Color.Transparent;
            this.Txt_titulo.Location = new System.Drawing.Point(198, 9);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(561, 45);
            this.Txt_titulo.TabIndex = 291;
            this.Txt_titulo.Text = "M a n t e n i m i e n t o   d e   M ó d u l o s";
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Image = global::Capa_Vista_Seguridad.Properties.Resources.cancelar1;
            this.Btn_cancelar.Location = new System.Drawing.Point(568, 63);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(69, 57);
            this.Btn_cancelar.TabIndex = 290;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Image = global::Capa_Vista_Seguridad.Properties.Resources.borrar11;
            this.Btn_eliminar.Location = new System.Drawing.Point(499, 63);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(69, 57);
            this.Btn_eliminar.TabIndex = 289;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click_1);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_modificar.FlatAppearance.BorderSize = 0;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Image = global::Capa_Vista_Seguridad.Properties.Resources.editar11;
            this.Btn_modificar.Location = new System.Drawing.Point(430, 63);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(69, 57);
            this.Btn_modificar.TabIndex = 288;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_buscar.FlatAppearance.BorderSize = 0;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Image = global::Capa_Vista_Seguridad.Properties.Resources.buscar11;
            this.Btn_buscar.Location = new System.Drawing.Point(361, 63);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(69, 57);
            this.Btn_buscar.TabIndex = 287;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Image = global::Capa_Vista_Seguridad.Properties.Resources.guardar21;
            this.Btn_actualizar.Location = new System.Drawing.Point(292, 63);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(69, 57);
            this.Btn_actualizar.TabIndex = 286;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click_1);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Image = global::Capa_Vista_Seguridad.Properties.Resources.guardar12;
            this.Btn_guardar.Location = new System.Drawing.Point(223, 63);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(69, 57);
            this.Btn_guardar.TabIndex = 285;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click_1);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = global::Capa_Vista_Seguridad.Properties.Resources.ayuda11;
            this.Btn_ayuda.Location = new System.Drawing.Point(736, 63);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(69, 57);
            this.Btn_ayuda.TabIndex = 284;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Image = global::Capa_Vista_Seguridad.Properties.Resources.salir11;
            this.Btn_salir.Location = new System.Drawing.Point(667, 63);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(69, 57);
            this.Btn_salir.TabIndex = 283;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Image = global::Capa_Vista_Seguridad.Properties.Resources.agregar11;
            this.Btn_agregar.Location = new System.Drawing.Point(154, 63);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(69, 57);
            this.Btn_agregar.TabIndex = 277;
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Dgv_modulos
            // 
            this.Dgv_modulos.AllowUserToAddRows = false;
            this.Dgv_modulos.AllowUserToDeleteRows = false;
            this.Dgv_modulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_modulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_modulos.Location = new System.Drawing.Point(7, 227);
            this.Dgv_modulos.Name = "Dgv_modulos";
            this.Dgv_modulos.ReadOnly = true;
            this.Dgv_modulos.RowHeadersWidth = 72;
            this.Dgv_modulos.RowTemplate.Height = 31;
            this.Dgv_modulos.Size = new System.Drawing.Size(634, 194);
            this.Dgv_modulos.TabIndex = 259;
            // 
            // frmMantemientoMódulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(973, 685);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Gpb_buscar);
            this.Controls.Add(this.Gpb_datos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMantemientoMódulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Modulos";
            this.Load += new System.EventHandler(this.Frm_modulos_Load);
            this.Gpb_buscar.ResumeLayout(false);
            this.Gpb_buscar.PerformLayout();
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.Gpb_estado.ResumeLayout(false);
            this.Gpb_estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_modulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Gpb_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.GroupBox Gpb_estado;
        private System.Windows.Forms.RadioButton Rdb_inhabilitado;
        private System.Windows.Forms.RadioButton Rdb_habilitado;
        private System.Windows.Forms.Label Txt_descripcionmodulo;
        private System.Windows.Forms.Label Txt_nombremodulo;
        private System.Windows.Forms.Label Txt_id;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.DataGridView Dgv_modulos;
    }
}