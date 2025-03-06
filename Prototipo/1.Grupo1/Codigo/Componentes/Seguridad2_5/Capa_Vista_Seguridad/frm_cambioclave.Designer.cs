namespace Capa_Vista_Seguridad
{
    partial class frm_cambioclave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cambioclave));
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.Lbl_idusuario = new System.Windows.Forms.Label();
            this.Lbl_contrasenia = new System.Windows.Forms.Label();
            this.Gpb_datosusuario = new System.Windows.Forms.GroupBox();
            this.Lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.Gpb_datospersonales = new System.Windows.Forms.GroupBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idbuscar = new System.Windows.Forms.TextBox();
            this.Gpb_modificar = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Gpb_contraseniausuario = new System.Windows.Forms.GroupBox();
            this.txt_nueva_clave_repetida = new System.Windows.Forms.TextBox();
            this.Lbl_nuevacontrasenia = new System.Windows.Forms.Label();
            this.Lbl_repetircontrasenia = new System.Windows.Forms.Label();
            this.txt_nueva_clave = new System.Windows.Forms.TextBox();
            this.btn_salir1 = new System.Windows.Forms.Button();
            this.btn_guardar1 = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.Gpb_datosusuario.SuspendLayout();
            this.Gpb_datospersonales.SuspendLayout();
            this.Gpb_modificar.SuspendLayout();
            this.Gpb_contraseniausuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(104, 33);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(283, 26);
            this.txt_id.TabIndex = 226;
            // 
            // txt_clave
            // 
            this.txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave.Location = new System.Drawing.Point(104, 88);
            this.txt_clave.Margin = new System.Windows.Forms.Padding(4);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(283, 26);
            this.txt_clave.TabIndex = 227;
            // 
            // Lbl_idusuario
            // 
            this.Lbl_idusuario.AutoSize = true;
            this.Lbl_idusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idusuario.Location = new System.Drawing.Point(8, 36);
            this.Lbl_idusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_idusuario.Name = "Lbl_idusuario";
            this.Lbl_idusuario.Size = new System.Drawing.Size(89, 20);
            this.Lbl_idusuario.TabIndex = 205;
            this.Lbl_idusuario.Text = "ID Usuario";
            // 
            // Lbl_contrasenia
            // 
            this.Lbl_contrasenia.AutoSize = true;
            this.Lbl_contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contrasenia.Location = new System.Drawing.Point(8, 91);
            this.Lbl_contrasenia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_contrasenia.Name = "Lbl_contrasenia";
            this.Lbl_contrasenia.Size = new System.Drawing.Size(100, 20);
            this.Lbl_contrasenia.TabIndex = 193;
            this.Lbl_contrasenia.Text = " Contraseña";
            // 
            // Gpb_datosusuario
            // 
            this.Gpb_datosusuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Gpb_datosusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datosusuario.Controls.Add(this.Lbl_contrasenia);
            this.Gpb_datosusuario.Controls.Add(this.Lbl_idusuario);
            this.Gpb_datosusuario.Controls.Add(this.txt_clave);
            this.Gpb_datosusuario.Controls.Add(this.txt_id);
            this.Gpb_datosusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosusuario.Location = new System.Drawing.Point(13, 204);
            this.Gpb_datosusuario.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datosusuario.Name = "Gpb_datosusuario";
            this.Gpb_datosusuario.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datosusuario.Size = new System.Drawing.Size(399, 135);
            this.Gpb_datosusuario.TabIndex = 251;
            this.Gpb_datosusuario.TabStop = false;
            this.Gpb_datosusuario.Text = "Datos Usuario";
            // 
            // Lbl_apellido
            // 
            this.Lbl_apellido.AutoSize = true;
            this.Lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_apellido.Location = new System.Drawing.Point(16, 91);
            this.Lbl_apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_apellido.Name = "Lbl_apellido";
            this.Lbl_apellido.Size = new System.Drawing.Size(68, 20);
            this.Lbl_apellido.TabIndex = 193;
            this.Lbl_apellido.Text = "Apellido";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(85, 33);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(300, 26);
            this.txt_apellido.TabIndex = 227;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(85, 88);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(300, 26);
            this.txt_nombre.TabIndex = 226;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(8, 39);
            this.Lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(78, 20);
            this.Lbl_nombre.TabIndex = 205;
            this.Lbl_nombre.Text = " Nombre ";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombres.Location = new System.Drawing.Point(85, 33);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(300, 26);
            this.txt_nombres.TabIndex = 249;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidos.Location = new System.Drawing.Point(85, 88);
            this.txt_apellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(300, 26);
            this.txt_apellidos.TabIndex = 252;
            // 
            // Gpb_datospersonales
            // 
            this.Gpb_datospersonales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Gpb_datospersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datospersonales.Controls.Add(this.txt_apellidos);
            this.Gpb_datospersonales.Controls.Add(this.txt_nombres);
            this.Gpb_datospersonales.Controls.Add(this.Lbl_nombre);
            this.Gpb_datospersonales.Controls.Add(this.txt_nombre);
            this.Gpb_datospersonales.Controls.Add(this.txt_apellido);
            this.Gpb_datospersonales.Controls.Add(this.Lbl_apellido);
            this.Gpb_datospersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datospersonales.Location = new System.Drawing.Point(420, 204);
            this.Gpb_datospersonales.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonales.Name = "Gpb_datospersonales";
            this.Gpb_datospersonales.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonales.Size = new System.Drawing.Size(405, 135);
            this.Gpb_datospersonales.TabIndex = 252;
            this.Gpb_datospersonales.TabStop = false;
            this.Gpb_datospersonales.Text = "Datos Personales";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_buscar.FlatAppearance.BorderSize = 0;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Image = global::Capa_Vista_Seguridad.Properties.Resources.buscar11;
            this.Btn_buscar.Location = new System.Drawing.Point(467, 27);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(69, 57);
            this.Btn_buscar.TabIndex = 237;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 238;
            this.label2.Text = "Buscar Id";
            // 
            // txt_idbuscar
            // 
            this.txt_idbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_idbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idbuscar.Location = new System.Drawing.Point(176, 41);
            this.txt_idbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idbuscar.Name = "txt_idbuscar";
            this.txt_idbuscar.Size = new System.Drawing.Size(283, 26);
            this.txt_idbuscar.TabIndex = 253;
            // 
            // Gpb_modificar
            // 
            this.Gpb_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_modificar.Controls.Add(this.txt_idbuscar);
            this.Gpb_modificar.Controls.Add(this.label2);
            this.Gpb_modificar.Controls.Add(this.Btn_buscar);
            this.Gpb_modificar.Location = new System.Drawing.Point(87, 84);
            this.Gpb_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_modificar.Name = "Gpb_modificar";
            this.Gpb_modificar.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_modificar.Size = new System.Drawing.Size(601, 101);
            this.Gpb_modificar.TabIndex = 253;
            this.Gpb_modificar.TabStop = false;
            this.Gpb_modificar.Text = "Modificar";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Haettenschweiler", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(249, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(342, 45);
            this.label6.TabIndex = 255;
            this.label6.Text = "CAMBIO DE CONTRASEÑA";
            // 
            // Gpb_contraseniausuario
            // 
            this.Gpb_contraseniausuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_contraseniausuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_contraseniausuario.Controls.Add(this.txt_nueva_clave_repetida);
            this.Gpb_contraseniausuario.Controls.Add(this.Lbl_nuevacontrasenia);
            this.Gpb_contraseniausuario.Controls.Add(this.Lbl_repetircontrasenia);
            this.Gpb_contraseniausuario.Controls.Add(this.txt_nueva_clave);
            this.Gpb_contraseniausuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_contraseniausuario.Location = new System.Drawing.Point(13, 347);
            this.Gpb_contraseniausuario.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_contraseniausuario.Name = "Gpb_contraseniausuario";
            this.Gpb_contraseniausuario.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_contraseniausuario.Size = new System.Drawing.Size(399, 135);
            this.Gpb_contraseniausuario.TabIndex = 260;
            this.Gpb_contraseniausuario.TabStop = false;
            this.Gpb_contraseniausuario.Text = "Datos Usuario";
            // 
            // txt_nueva_clave_repetida
            // 
            this.txt_nueva_clave_repetida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nueva_clave_repetida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nueva_clave_repetida.Location = new System.Drawing.Point(146, 82);
            this.txt_nueva_clave_repetida.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nueva_clave_repetida.Name = "txt_nueva_clave_repetida";
            this.txt_nueva_clave_repetida.PasswordChar = '*';
            this.txt_nueva_clave_repetida.Size = new System.Drawing.Size(247, 26);
            this.txt_nueva_clave_repetida.TabIndex = 228;
            // 
            // Lbl_nuevacontrasenia
            // 
            this.Lbl_nuevacontrasenia.AutoSize = true;
            this.Lbl_nuevacontrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nuevacontrasenia.Location = new System.Drawing.Point(6, 42);
            this.Lbl_nuevacontrasenia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nuevacontrasenia.Name = "Lbl_nuevacontrasenia";
            this.Lbl_nuevacontrasenia.Size = new System.Drawing.Size(152, 20);
            this.Lbl_nuevacontrasenia.TabIndex = 193;
            this.Lbl_nuevacontrasenia.Text = " Nueva Contraseña";
            // 
            // Lbl_repetircontrasenia
            // 
            this.Lbl_repetircontrasenia.AutoSize = true;
            this.Lbl_repetircontrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_repetircontrasenia.Location = new System.Drawing.Point(8, 88);
            this.Lbl_repetircontrasenia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_repetircontrasenia.Name = "Lbl_repetircontrasenia";
            this.Lbl_repetircontrasenia.Size = new System.Drawing.Size(154, 20);
            this.Lbl_repetircontrasenia.TabIndex = 205;
            this.Lbl_repetircontrasenia.Text = "Repetir Contraseña";
            // 
            // txt_nueva_clave
            // 
            this.txt_nueva_clave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nueva_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nueva_clave.Location = new System.Drawing.Point(147, 36);
            this.txt_nueva_clave.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nueva_clave.Name = "txt_nueva_clave";
            this.txt_nueva_clave.PasswordChar = '*';
            this.txt_nueva_clave.Size = new System.Drawing.Size(246, 26);
            this.txt_nueva_clave.TabIndex = 227;
            // 
            // btn_salir1
            // 
            this.btn_salir1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_salir1.FlatAppearance.BorderSize = 0;
            this.btn_salir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir1.Image = global::Capa_Vista_Seguridad.Properties.Resources.salir11;
            this.btn_salir1.Location = new System.Drawing.Point(514, 418);
            this.btn_salir1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir1.Name = "btn_salir1";
            this.btn_salir1.Size = new System.Drawing.Size(69, 57);
            this.btn_salir1.TabIndex = 260;
            this.btn_salir1.UseVisualStyleBackColor = false;
            this.btn_salir1.Click += new System.EventHandler(this.Btn_salir1_Click);
            // 
            // btn_guardar1
            // 
            this.btn_guardar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_guardar1.FlatAppearance.BorderSize = 0;
            this.btn_guardar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar1.Image = global::Capa_Vista_Seguridad.Properties.Resources.guardar12;
            this.btn_guardar1.Location = new System.Drawing.Point(514, 363);
            this.btn_guardar1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar1.Name = "btn_guardar1";
            this.btn_guardar1.Size = new System.Drawing.Size(69, 57);
            this.btn_guardar1.TabIndex = 259;
            this.btn_guardar1.UseVisualStyleBackColor = false;
            this.btn_guardar1.Click += new System.EventHandler(this.Btn_guardar1_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_ayuda.FlatAppearance.BorderSize = 0;
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayuda.Image = global::Capa_Vista_Seguridad.Properties.Resources.ayuda11;
            this.btn_ayuda.Location = new System.Drawing.Point(740, 10);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(69, 57);
            this.btn_ayuda.TabIndex = 256;
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // frm_cambioclave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(838, 514);
            this.Controls.Add(this.Gpb_contraseniausuario);
            this.Controls.Add(this.btn_salir1);
            this.Controls.Add(this.btn_guardar1);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gpb_modificar);
            this.Controls.Add(this.Gpb_datospersonales);
            this.Controls.Add(this.Gpb_datosusuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_cambioclave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Contraseña";
            this.Load += new System.EventHandler(this.Frm_cambioclave_Load);
            this.Gpb_datosusuario.ResumeLayout(false);
            this.Gpb_datosusuario.PerformLayout();
            this.Gpb_datospersonales.ResumeLayout(false);
            this.Gpb_datospersonales.PerformLayout();
            this.Gpb_modificar.ResumeLayout(false);
            this.Gpb_modificar.PerformLayout();
            this.Gpb_contraseniausuario.ResumeLayout(false);
            this.Gpb_contraseniausuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label Lbl_idusuario;
        private System.Windows.Forms.Label Lbl_contrasenia;
        private System.Windows.Forms.GroupBox Gpb_datosusuario;
        private System.Windows.Forms.Label Lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.GroupBox Gpb_datospersonales;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idbuscar;
        private System.Windows.Forms.GroupBox Gpb_modificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.GroupBox Gpb_contraseniausuario;
        private System.Windows.Forms.Label Lbl_nuevacontrasenia;
        private System.Windows.Forms.Label Lbl_repetircontrasenia;
        private System.Windows.Forms.TextBox txt_nueva_clave;
        private System.Windows.Forms.Button btn_salir1;
        private System.Windows.Forms.Button btn_guardar1;
        private System.Windows.Forms.TextBox txt_nueva_clave_repetida;
    }
}