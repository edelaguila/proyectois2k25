namespace Capa_Vista_Seguridad
{
    partial class frm_aplicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_aplicaciones));
            this.Gpb_buscar = new System.Windows.Forms.GroupBox();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Txt_buscar_id = new System.Windows.Forms.Label();
            this.Btn_bsucar = new System.Windows.Forms.Button();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Dgv_aplicaciones = new System.Windows.Forms.DataGridView();
            this.Gpb_estado = new System.Windows.Forms.GroupBox();
            this.Rdb_inhabilitado = new System.Windows.Forms.RadioButton();
            this.Rdb_habilitado = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_descripcionA = new System.Windows.Forms.Label();
            this.Txt_nombreA = new System.Windows.Forms.Label();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Txt_id = new System.Windows.Forms.Label();
            this.Txt_idaplicacion = new System.Windows.Forms.TextBox();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Cbo_buscar = new System.Windows.Forms.ComboBox();
            this.Gpb_buscar.SuspendLayout();
            this.Gpb_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aplicaciones)).BeginInit();
            this.Gpb_estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_buscar
            // 
            this.Gpb_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_buscar.Controls.Add(this.Cbo_buscar);
            this.Gpb_buscar.Controls.Add(this.Txt_buscar);
            this.Gpb_buscar.Controls.Add(this.Txt_buscar_id);
            this.Gpb_buscar.Controls.Add(this.Btn_bsucar);
            this.Gpb_buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_buscar.Location = new System.Drawing.Point(49, 138);
            this.Gpb_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_buscar.Name = "Gpb_buscar";
            this.Gpb_buscar.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_buscar.Size = new System.Drawing.Size(785, 87);
            this.Gpb_buscar.TabIndex = 255;
            this.Gpb_buscar.TabStop = false;
            this.Gpb_buscar.Text = "Buscar";
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar.Location = new System.Drawing.Point(286, 28);
            this.Txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(283, 26);
            this.Txt_buscar.TabIndex = 240;
            this.Txt_buscar.Tag = "9";
            // 
            // Txt_buscar_id
            // 
            this.Txt_buscar_id.AutoSize = true;
            this.Txt_buscar_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar_id.Location = new System.Drawing.Point(129, 35);
            this.Txt_buscar_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_buscar_id.Name = "Txt_buscar_id";
            this.Txt_buscar_id.Size = new System.Drawing.Size(68, 19);
            this.Txt_buscar_id.TabIndex = 238;
            this.Txt_buscar_id.Text = "Buscar Id";
            // 
            // Btn_bsucar
            // 
            this.Btn_bsucar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_bsucar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_bsucar.FlatAppearance.BorderSize = 0;
            this.Btn_bsucar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_bsucar.Image = global::Capa_Vista_Seguridad.Properties.Resources.buscar11;
            this.Btn_bsucar.Location = new System.Drawing.Point(586, 17);
            this.Btn_bsucar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_bsucar.Name = "Btn_bsucar";
            this.Btn_bsucar.Size = new System.Drawing.Size(61, 49);
            this.Btn_bsucar.TabIndex = 296;
            this.Btn_bsucar.UseVisualStyleBackColor = false;
            this.Btn_bsucar.Click += new System.EventHandler(this.Btn_bsucar_Click);
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datos.Controls.Add(this.Dgv_aplicaciones);
            this.Gpb_datos.Controls.Add(this.Gpb_estado);
            this.Gpb_datos.Controls.Add(this.label3);
            this.Gpb_datos.Controls.Add(this.Txt_nombre);
            this.Gpb_datos.Controls.Add(this.Txt_descripcionA);
            this.Gpb_datos.Controls.Add(this.Txt_nombreA);
            this.Gpb_datos.Controls.Add(this.Txt_descripcion);
            this.Gpb_datos.Controls.Add(this.Txt_id);
            this.Gpb_datos.Controls.Add(this.Txt_idaplicacion);
            this.Gpb_datos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.Location = new System.Drawing.Point(49, 233);
            this.Gpb_datos.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Size = new System.Drawing.Size(785, 477);
            this.Gpb_datos.TabIndex = 254;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos Aplicacion";
            // 
            // Dgv_aplicaciones
            // 
            this.Dgv_aplicaciones.AllowUserToAddRows = false;
            this.Dgv_aplicaciones.AllowUserToDeleteRows = false;
            this.Dgv_aplicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_aplicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_aplicaciones.Location = new System.Drawing.Point(9, 196);
            this.Dgv_aplicaciones.Name = "Dgv_aplicaciones";
            this.Dgv_aplicaciones.ReadOnly = true;
            this.Dgv_aplicaciones.RowHeadersWidth = 72;
            this.Dgv_aplicaciones.RowTemplate.Height = 31;
            this.Dgv_aplicaciones.Size = new System.Drawing.Size(769, 255);
            this.Dgv_aplicaciones.TabIndex = 259;
            // 
            // Gpb_estado
            // 
            this.Gpb_estado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_estado.Controls.Add(this.Rdb_inhabilitado);
            this.Gpb_estado.Controls.Add(this.Rdb_habilitado);
            this.Gpb_estado.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_estado.Location = new System.Drawing.Point(8, 158);
            this.Gpb_estado.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_estado.Name = "Gpb_estado";
            this.Gpb_estado.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_estado.Size = new System.Drawing.Size(769, 27);
            this.Gpb_estado.TabIndex = 230;
            this.Gpb_estado.TabStop = false;
            this.Gpb_estado.Text = "Estado";
            // 
            // Rdb_inhabilitado
            // 
            this.Rdb_inhabilitado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_inhabilitado.AutoSize = true;
            this.Rdb_inhabilitado.Location = new System.Drawing.Point(381, 0);
            this.Rdb_inhabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_inhabilitado.Name = "Rdb_inhabilitado";
            this.Rdb_inhabilitado.Size = new System.Drawing.Size(111, 23);
            this.Rdb_inhabilitado.TabIndex = 1;
            this.Rdb_inhabilitado.TabStop = true;
            this.Rdb_inhabilitado.Text = "Inhabilitado";
            this.Rdb_inhabilitado.UseVisualStyleBackColor = true;
            // 
            // Rdb_habilitado
            // 
            this.Rdb_habilitado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_habilitado.AutoSize = true;
            this.Rdb_habilitado.Location = new System.Drawing.Point(241, 0);
            this.Rdb_habilitado.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_habilitado.Name = "Rdb_habilitado";
            this.Rdb_habilitado.Size = new System.Drawing.Size(100, 23);
            this.Rdb_habilitado.TabIndex = 0;
            this.Rdb_habilitado.TabStop = true;
            this.Rdb_habilitado.Text = "Habilitado";
            this.Rdb_habilitado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 229;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(249, 69);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(285, 26);
            this.Txt_nombre.TabIndex = 228;
            // 
            // Txt_descripcionA
            // 
            this.Txt_descripcionA.AutoSize = true;
            this.Txt_descripcionA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcionA.Location = new System.Drawing.Point(25, 114);
            this.Txt_descripcionA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_descripcionA.Name = "Txt_descripcionA";
            this.Txt_descripcionA.Size = new System.Drawing.Size(81, 19);
            this.Txt_descripcionA.TabIndex = 193;
            this.Txt_descripcionA.Text = "Descripcion";
            // 
            // Txt_nombreA
            // 
            this.Txt_nombreA.AutoSize = true;
            this.Txt_nombreA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreA.Location = new System.Drawing.Point(21, 76);
            this.Txt_nombreA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_nombreA.Name = "Txt_nombreA";
            this.Txt_nombreA.Size = new System.Drawing.Size(131, 19);
            this.Txt_nombreA.TabIndex = 205;
            this.Txt_nombreA.Text = " Nombre Aplicacion";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcion.Location = new System.Drawing.Point(249, 111);
            this.Txt_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(285, 26);
            this.Txt_descripcion.TabIndex = 226;
            this.Txt_descripcion.Tag = "2";
            // 
            // Txt_id
            // 
            this.Txt_id.AutoSize = true;
            this.Txt_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id.Location = new System.Drawing.Point(25, 40);
            this.Txt_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(92, 19);
            this.Txt_id.TabIndex = 205;
            this.Txt_id.Text = "ID Aplicacion";
            // 
            // Txt_idaplicacion
            // 
            this.Txt_idaplicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_idaplicacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idaplicacion.Location = new System.Drawing.Point(249, 33);
            this.Txt_idaplicacion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_idaplicacion.Name = "Txt_idaplicacion";
            this.Txt_idaplicacion.Size = new System.Drawing.Size(285, 26);
            this.Txt_idaplicacion.TabIndex = 226;
            this.Txt_idaplicacion.TextChanged += new System.EventHandler(this.Txt_idaplicacion_TextChanged);
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_titulo.ForeColor = System.Drawing.Color.Transparent;
            this.Txt_titulo.Location = new System.Drawing.Point(157, 9);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(496, 37);
            this.Txt_titulo.TabIndex = 260;
            this.Txt_titulo.Text = "M a n t e n i m i e n to  d e  A p l i c a c i o n e s";
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Image = global::Capa_Vista_Seguridad.Properties.Resources.cancelar1;
            this.Btn_cancelar.Location = new System.Drawing.Point(394, 66);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(69, 57);
            this.Btn_cancelar.TabIndex = 299;
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
            this.Btn_eliminar.Location = new System.Drawing.Point(325, 66);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(69, 57);
            this.Btn_eliminar.TabIndex = 298;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.Image = global::Capa_Vista_Seguridad.Properties.Resources.agregar11;
            this.Btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_nuevo.Location = new System.Drawing.Point(49, 66);
            this.Btn_nuevo.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(69, 57);
            this.Btn_nuevo.TabIndex = 291;
            this.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_modificar.FlatAppearance.BorderSize = 0;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Image = global::Capa_Vista_Seguridad.Properties.Resources.editar11;
            this.Btn_modificar.Location = new System.Drawing.Point(187, 66);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(69, 57);
            this.Btn_modificar.TabIndex = 297;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Image = global::Capa_Vista_Seguridad.Properties.Resources.guardar21;
            this.Btn_actualizar.Location = new System.Drawing.Point(256, 66);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(69, 57);
            this.Btn_actualizar.TabIndex = 295;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ingresar.FlatAppearance.BorderSize = 0;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Image = global::Capa_Vista_Seguridad.Properties.Resources.guardar12;
            this.Btn_ingresar.Location = new System.Drawing.Point(118, 66);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(69, 57);
            this.Btn_ingresar.TabIndex = 294;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = global::Capa_Vista_Seguridad.Properties.Resources.ayuda11;
            this.Btn_ayuda.Location = new System.Drawing.Point(764, 66);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(69, 57);
            this.Btn_ayuda.TabIndex = 293;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click_1);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Image = global::Capa_Vista_Seguridad.Properties.Resources.salir11;
            this.Btn_salir.Location = new System.Drawing.Point(695, 66);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(69, 57);
            this.Btn_salir.TabIndex = 292;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Cbo_buscar
            // 
            this.Cbo_buscar.FormattingEnabled = true;
            this.Cbo_buscar.Location = new System.Drawing.Point(286, 28);
            this.Cbo_buscar.Name = "Cbo_buscar";
            this.Cbo_buscar.Size = new System.Drawing.Size(283, 27);
            this.Cbo_buscar.TabIndex = 299;
            this.Cbo_buscar.SelectedIndexChanged += new System.EventHandler(this.Cbo_buscar_SelectedIndexChanged);
            // 
            // frm_aplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(870, 723);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.Gpb_buscar);
            this.Controls.Add(this.Gpb_datos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_aplicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Aplicaciones";
            this.Load += new System.EventHandler(this.Frm_aplicaciones_Load);
            this.Gpb_buscar.ResumeLayout(false);
            this.Gpb_buscar.PerformLayout();
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aplicaciones)).EndInit();
            this.Gpb_estado.ResumeLayout(false);
            this.Gpb_estado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Gpb_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label Txt_buscar_id;
        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Txt_descripcionA;
        private System.Windows.Forms.Label Txt_nombreA;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.Label Txt_id;
        private System.Windows.Forms.TextBox Txt_idaplicacion;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_bsucar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.GroupBox Gpb_estado;
        private System.Windows.Forms.RadioButton Rdb_inhabilitado;
        private System.Windows.Forms.RadioButton Rdb_habilitado;
        private System.Windows.Forms.DataGridView Dgv_aplicaciones;
        private System.Windows.Forms.ComboBox Cbo_buscar;
    }
}