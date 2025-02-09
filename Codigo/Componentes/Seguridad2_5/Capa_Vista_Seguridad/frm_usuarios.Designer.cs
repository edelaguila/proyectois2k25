namespace Capa_Vista_Seguridad
{
    partial class frm_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuarios));
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Gpb_modificar = new System.Windows.Forms.GroupBox();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Txt_buscar_id = new System.Windows.Forms.Label();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Gpb_datospersonalesclave = new System.Windows.Forms.GroupBox();
            this.Cmb_Pregunta = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_preguntausuario = new System.Windows.Forms.Label();
            this.Rdb_inhabilitado = new System.Windows.Forms.RadioButton();
            this.Rdb_habilitado = new System.Windows.Forms.RadioButton();
            this.Txt_respuesta = new System.Windows.Forms.TextBox();
            this.Lbl_respuestausuario = new System.Windows.Forms.Label();
            this.Txt_estado = new System.Windows.Forms.Label();
            this.txt_estadousuario = new System.Windows.Forms.TextBox();
            this.Gpb_datospersonales = new System.Windows.Forms.GroupBox();
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.Txt_correousuario = new System.Windows.Forms.Label();
            this.Txt_apellido = new System.Windows.Forms.TextBox();
            this.Txt_nomb = new System.Windows.Forms.TextBox();
            this.Txt_nombreusuario = new System.Windows.Forms.Label();
            this.Txt_apellidousuario = new System.Windows.Forms.Label();
            this.Gpb_datosusuario = new System.Windows.Forms.GroupBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.Txt_idusuario = new System.Windows.Forms.Label();
            this.Txt_usernameusuario = new System.Windows.Forms.Label();
            this.Txt_nombreusername = new System.Windows.Forms.TextBox();
            this.Txt_contraseniausuario = new System.Windows.Forms.Label();
            this.Txt_clave = new System.Windows.Forms.TextBox();
            this.Dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rdb_activos = new System.Windows.Forms.RadioButton();
            this.Rdb_inactivos = new System.Windows.Forms.RadioButton();
            this.Gpb_modificar.SuspendLayout();
            this.Gpb_datospersonalesclave.SuspendLayout();
            this.Gpb_datospersonales.SuspendLayout();
            this.Gpb_datosusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Image = global::Capa_Vista_Seguridad.Properties.Resources.guardar12;
            this.Btn_guardar.Location = new System.Drawing.Point(1053, 99);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(69, 57);
            this.Btn_guardar.TabIndex = 233;
            this.Btn_guardar.Tag = "5";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Image = global::Capa_Vista_Seguridad.Properties.Resources.salir11;
            this.Btn_salir.Location = new System.Drawing.Point(1323, 14);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(69, 57);
            this.Btn_salir.TabIndex = 234;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_buscar.FlatAppearance.BorderSize = 0;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Image = global::Capa_Vista_Seguridad.Properties.Resources.buscar11;
            this.Btn_buscar.Location = new System.Drawing.Point(860, 14);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(69, 57);
            this.Btn_buscar.TabIndex = 237;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Image = global::Capa_Vista_Seguridad.Properties.Resources.borrar11;
            this.Btn_eliminar.Location = new System.Drawing.Point(1191, 99);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(69, 57);
            this.Btn_eliminar.TabIndex = 238;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Gpb_modificar
            // 
            this.Gpb_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_modificar.Controls.Add(this.Txt_buscar);
            this.Gpb_modificar.Controls.Add(this.Txt_buscar_id);
            this.Gpb_modificar.Controls.Add(this.Btn_buscar);
            this.Gpb_modificar.Location = new System.Drawing.Point(25, 84);
            this.Gpb_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_modificar.Name = "Gpb_modificar";
            this.Gpb_modificar.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_modificar.Size = new System.Drawing.Size(937, 79);
            this.Gpb_modificar.TabIndex = 239;
            this.Gpb_modificar.TabStop = false;
            this.Gpb_modificar.Text = "Modificar";
            this.Gpb_modificar.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar.Location = new System.Drawing.Point(166, 29);
            this.Txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(686, 26);
            this.Txt_buscar.TabIndex = 240;
            // 
            // Txt_buscar_id
            // 
            this.Txt_buscar_id.AutoSize = true;
            this.Txt_buscar_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar_id.Location = new System.Drawing.Point(42, 33);
            this.Txt_buscar_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_buscar_id.Name = "Txt_buscar_id";
            this.Txt_buscar_id.Size = new System.Drawing.Size(81, 20);
            this.Txt_buscar_id.TabIndex = 238;
            this.Txt_buscar_id.Text = "Buscar Id";
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_modificar.FlatAppearance.BorderSize = 0;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Image = global::Capa_Vista_Seguridad.Properties.Resources.editar11;
            this.Btn_modificar.Location = new System.Drawing.Point(1122, 99);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(69, 57);
            this.Btn_modificar.TabIndex = 240;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.Image = global::Capa_Vista_Seguridad.Properties.Resources.agregar11;
            this.Btn_nuevo.Location = new System.Drawing.Point(984, 99);
            this.Btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(69, 57);
            this.Btn_nuevo.TabIndex = 241;
            this.Btn_nuevo.Tag = "0";
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Gpb_datospersonalesclave
            // 
            this.Gpb_datospersonalesclave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datospersonalesclave.Controls.Add(this.Cmb_Pregunta);
            this.Gpb_datospersonalesclave.Controls.Add(this.textBox1);
            this.Gpb_datospersonalesclave.Controls.Add(this.Lbl_preguntausuario);
            this.Gpb_datospersonalesclave.Controls.Add(this.Rdb_inhabilitado);
            this.Gpb_datospersonalesclave.Controls.Add(this.Rdb_habilitado);
            this.Gpb_datospersonalesclave.Controls.Add(this.Txt_respuesta);
            this.Gpb_datospersonalesclave.Controls.Add(this.Lbl_respuestausuario);
            this.Gpb_datospersonalesclave.Controls.Add(this.Txt_estado);
            this.Gpb_datospersonalesclave.Controls.Add(this.txt_estadousuario);
            this.Gpb_datospersonalesclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datospersonalesclave.Location = new System.Drawing.Point(984, 194);
            this.Gpb_datospersonalesclave.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonalesclave.Name = "Gpb_datospersonalesclave";
            this.Gpb_datospersonalesclave.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonalesclave.Size = new System.Drawing.Size(476, 231);
            this.Gpb_datospersonalesclave.TabIndex = 256;
            this.Gpb_datospersonalesclave.TabStop = false;
            this.Gpb_datospersonalesclave.Text = "Datos Personales";
            // 
            // Cmb_Pregunta
            // 
            this.Cmb_Pregunta.FormattingEnabled = true;
            this.Cmb_Pregunta.Location = new System.Drawing.Point(171, 135);
            this.Cmb_Pregunta.Name = "Cmb_Pregunta";
            this.Cmb_Pregunta.Size = new System.Drawing.Size(297, 28);
            this.Cmb_Pregunta.TabIndex = 262;
            this.Cmb_Pregunta.SelectedIndexChanged += new System.EventHandler(this.cmb_Pregunta_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(414, 137);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(16, 26);
            this.textBox1.TabIndex = 261;
            this.textBox1.Tag = "3";
            // 
            // Lbl_preguntausuario
            // 
            this.Lbl_preguntausuario.AutoSize = true;
            this.Lbl_preguntausuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_preguntausuario.Location = new System.Drawing.Point(32, 137);
            this.Lbl_preguntausuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_preguntausuario.Name = "Lbl_preguntausuario";
            this.Lbl_preguntausuario.Size = new System.Drawing.Size(76, 20);
            this.Lbl_preguntausuario.TabIndex = 260;
            this.Lbl_preguntausuario.Text = "Pregunta";
            // 
            // Rdb_inhabilitado
            // 
            this.Rdb_inhabilitado.AutoSize = true;
            this.Rdb_inhabilitado.Location = new System.Drawing.Point(231, 63);
            this.Rdb_inhabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_inhabilitado.Name = "Rdb_inhabilitado";
            this.Rdb_inhabilitado.Size = new System.Drawing.Size(87, 24);
            this.Rdb_inhabilitado.TabIndex = 231;
            this.Rdb_inhabilitado.TabStop = true;
            this.Rdb_inhabilitado.Text = "Inactivo";
            this.Rdb_inhabilitado.UseVisualStyleBackColor = true;
            // 
            // Rdb_habilitado
            // 
            this.Rdb_habilitado.AutoSize = true;
            this.Rdb_habilitado.Location = new System.Drawing.Point(94, 63);
            this.Rdb_habilitado.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_habilitado.Name = "Rdb_habilitado";
            this.Rdb_habilitado.Size = new System.Drawing.Size(76, 24);
            this.Rdb_habilitado.TabIndex = 230;
            this.Rdb_habilitado.TabStop = true;
            this.Rdb_habilitado.Text = "Activo";
            this.Rdb_habilitado.UseVisualStyleBackColor = true;
            // 
            // Txt_respuesta
            // 
            this.Txt_respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_respuesta.Location = new System.Drawing.Point(171, 190);
            this.Txt_respuesta.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_respuesta.Name = "Txt_respuesta";
            this.Txt_respuesta.Size = new System.Drawing.Size(297, 26);
            this.Txt_respuesta.TabIndex = 229;
            this.Txt_respuesta.Tag = "4";
            // 
            // Lbl_respuestausuario
            // 
            this.Lbl_respuestausuario.AutoSize = true;
            this.Lbl_respuestausuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_respuestausuario.Location = new System.Drawing.Point(32, 189);
            this.Lbl_respuestausuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_respuestausuario.Name = "Lbl_respuestausuario";
            this.Lbl_respuestausuario.Size = new System.Drawing.Size(89, 20);
            this.Lbl_respuestausuario.TabIndex = 228;
            this.Lbl_respuestausuario.Text = "Respuesta";
            // 
            // Txt_estado
            // 
            this.Txt_estado.AutoSize = true;
            this.Txt_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.Location = new System.Drawing.Point(131, 30);
            this.Txt_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(124, 20);
            this.Txt_estado.TabIndex = 205;
            this.Txt_estado.Text = "Estado Usuario";
            // 
            // txt_estadousuario
            // 
            this.txt_estadousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estadousuario.Location = new System.Drawing.Point(436, 135);
            this.txt_estadousuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estadousuario.Name = "txt_estadousuario";
            this.txt_estadousuario.Size = new System.Drawing.Size(16, 26);
            this.txt_estadousuario.TabIndex = 227;
            this.txt_estadousuario.Tag = "3";
            this.txt_estadousuario.TextChanged += new System.EventHandler(this.txt_estadousuario_TextChanged);
            // 
            // Gpb_datospersonales
            // 
            this.Gpb_datospersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datospersonales.Controls.Add(this.Txt_correo);
            this.Gpb_datospersonales.Controls.Add(this.Txt_correousuario);
            this.Gpb_datospersonales.Controls.Add(this.Txt_apellido);
            this.Gpb_datospersonales.Controls.Add(this.Txt_nomb);
            this.Gpb_datospersonales.Controls.Add(this.Txt_nombreusuario);
            this.Gpb_datospersonales.Controls.Add(this.Txt_apellidousuario);
            this.Gpb_datospersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datospersonales.Location = new System.Drawing.Point(505, 194);
            this.Gpb_datospersonales.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonales.Name = "Gpb_datospersonales";
            this.Gpb_datospersonales.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonales.Size = new System.Drawing.Size(457, 231);
            this.Gpb_datospersonales.TabIndex = 255;
            this.Gpb_datospersonales.TabStop = false;
            this.Gpb_datospersonales.Text = "Datos Personales";
            // 
            // Txt_correo
            // 
            this.Txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_correo.Location = new System.Drawing.Point(125, 149);
            this.Txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(308, 26);
            this.Txt_correo.TabIndex = 229;
            this.Txt_correo.Tag = "4";
            // 
            // Txt_correousuario
            // 
            this.Txt_correousuario.AutoSize = true;
            this.Txt_correousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_correousuario.Location = new System.Drawing.Point(8, 149);
            this.Txt_correousuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_correousuario.Name = "Txt_correousuario";
            this.Txt_correousuario.Size = new System.Drawing.Size(60, 20);
            this.Txt_correousuario.TabIndex = 228;
            this.Txt_correousuario.Text = "Correo";
            // 
            // Txt_apellido
            // 
            this.Txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellido.Location = new System.Drawing.Point(125, 94);
            this.Txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_apellido.Name = "Txt_apellido";
            this.Txt_apellido.Size = new System.Drawing.Size(308, 26);
            this.Txt_apellido.TabIndex = 226;
            this.Txt_apellido.Tag = "4";
            // 
            // Txt_nomb
            // 
            this.Txt_nomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nomb.Location = new System.Drawing.Point(206, 39);
            this.Txt_nomb.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nomb.Name = "Txt_nomb";
            this.Txt_nomb.Size = new System.Drawing.Size(227, 26);
            this.Txt_nomb.TabIndex = 226;
            this.Txt_nomb.Tag = "1";
            // 
            // Txt_nombreusuario
            // 
            this.Txt_nombreusuario.AutoSize = true;
            this.Txt_nombreusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreusuario.Location = new System.Drawing.Point(8, 43);
            this.Txt_nombreusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_nombreusuario.Name = "Txt_nombreusuario";
            this.Txt_nombreusuario.Size = new System.Drawing.Size(68, 20);
            this.Txt_nombreusuario.TabIndex = 205;
            this.Txt_nombreusuario.Text = "Nombre";
            // 
            // Txt_apellidousuario
            // 
            this.Txt_apellidousuario.AutoSize = true;
            this.Txt_apellidousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellidousuario.Location = new System.Drawing.Point(8, 97);
            this.Txt_apellidousuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_apellidousuario.Name = "Txt_apellidousuario";
            this.Txt_apellidousuario.Size = new System.Drawing.Size(68, 20);
            this.Txt_apellidousuario.TabIndex = 193;
            this.Txt_apellidousuario.Text = "Apellido";
            // 
            // Gpb_datosusuario
            // 
            this.Gpb_datosusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datosusuario.Controls.Add(this.Txt_id);
            this.Gpb_datosusuario.Controls.Add(this.Txt_idusuario);
            this.Gpb_datosusuario.Controls.Add(this.Txt_usernameusuario);
            this.Gpb_datosusuario.Controls.Add(this.Txt_nombreusername);
            this.Gpb_datosusuario.Controls.Add(this.Txt_contraseniausuario);
            this.Gpb_datosusuario.Controls.Add(this.Txt_clave);
            this.Gpb_datosusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosusuario.Location = new System.Drawing.Point(25, 194);
            this.Gpb_datosusuario.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datosusuario.Name = "Gpb_datosusuario";
            this.Gpb_datosusuario.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datosusuario.Size = new System.Drawing.Size(455, 231);
            this.Gpb_datosusuario.TabIndex = 254;
            this.Gpb_datosusuario.TabStop = false;
            this.Gpb_datosusuario.Text = "Datos Usuario";
            // 
            // Txt_id
            // 
            this.Txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id.Location = new System.Drawing.Point(146, 44);
            this.Txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(227, 26);
            this.Txt_id.TabIndex = 254;
            this.Txt_id.Tag = "1";
            // 
            // Txt_idusuario
            // 
            this.Txt_idusuario.AutoSize = true;
            this.Txt_idusuario.Location = new System.Drawing.Point(14, 42);
            this.Txt_idusuario.Name = "Txt_idusuario";
            this.Txt_idusuario.Size = new System.Drawing.Size(26, 20);
            this.Txt_idusuario.TabIndex = 228;
            this.Txt_idusuario.Text = "ID";
            // 
            // Txt_usernameusuario
            // 
            this.Txt_usernameusuario.AutoSize = true;
            this.Txt_usernameusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usernameusuario.Location = new System.Drawing.Point(14, 93);
            this.Txt_usernameusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_usernameusuario.Name = "Txt_usernameusuario";
            this.Txt_usernameusuario.Size = new System.Drawing.Size(86, 20);
            this.Txt_usernameusuario.TabIndex = 205;
            this.Txt_usernameusuario.Text = "Username";
            // 
            // Txt_nombreusername
            // 
            this.Txt_nombreusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreusername.Location = new System.Drawing.Point(146, 93);
            this.Txt_nombreusername.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nombreusername.Name = "Txt_nombreusername";
            this.Txt_nombreusername.Size = new System.Drawing.Size(283, 26);
            this.Txt_nombreusername.TabIndex = 227;
            this.Txt_nombreusername.Tag = "3";
            // 
            // Txt_contraseniausuario
            // 
            this.Txt_contraseniausuario.AutoSize = true;
            this.Txt_contraseniausuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_contraseniausuario.Location = new System.Drawing.Point(8, 141);
            this.Txt_contraseniausuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_contraseniausuario.Name = "Txt_contraseniausuario";
            this.Txt_contraseniausuario.Size = new System.Drawing.Size(100, 20);
            this.Txt_contraseniausuario.TabIndex = 193;
            this.Txt_contraseniausuario.Text = " Contraseña";
            // 
            // Txt_clave
            // 
            this.Txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_clave.Location = new System.Drawing.Point(146, 141);
            this.Txt_clave.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_clave.Name = "Txt_clave";
            this.Txt_clave.PasswordChar = '*';
            this.Txt_clave.Size = new System.Drawing.Size(283, 26);
            this.Txt_clave.TabIndex = 227;
            this.Txt_clave.Tag = "2";
            // 
            // Dgv_usuarios
            // 
            this.Dgv_usuarios.AllowUserToAddRows = false;
            this.Dgv_usuarios.AllowUserToDeleteRows = false;
            this.Dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_usuarios.Location = new System.Drawing.Point(25, 445);
            this.Dgv_usuarios.Name = "Dgv_usuarios";
            this.Dgv_usuarios.ReadOnly = true;
            this.Dgv_usuarios.RowHeadersWidth = 72;
            this.Dgv_usuarios.RowTemplate.Height = 31;
            this.Dgv_usuarios.Size = new System.Drawing.Size(1314, 239);
            this.Dgv_usuarios.TabIndex = 258;
            this.Dgv_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_usuarios_CellContentClick);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = global::Capa_Vista_Seguridad.Properties.Resources.ayuda11;
            this.Btn_ayuda.Location = new System.Drawing.Point(1392, 14);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(69, 57);
            this.Btn_ayuda.TabIndex = 252;
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_titulo.ForeColor = System.Drawing.Color.Transparent;
            this.Txt_titulo.Location = new System.Drawing.Point(483, 9);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(521, 62);
            this.Txt_titulo.TabIndex = 260;
            this.Txt_titulo.Text = "Mantenimiento de Usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.Rdb_inactivos);
            this.panel1.Controls.Add(this.Rdb_activos);
            this.panel1.Location = new System.Drawing.Point(1358, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 239);
            this.panel1.TabIndex = 261;
            // 
            // Rdb_activos
            // 
            this.Rdb_activos.AutoSize = true;
            this.Rdb_activos.Location = new System.Drawing.Point(11, 52);
            this.Rdb_activos.Name = "Rdb_activos";
            this.Rdb_activos.Size = new System.Drawing.Size(85, 24);
            this.Rdb_activos.TabIndex = 0;
            this.Rdb_activos.TabStop = true;
            this.Rdb_activos.Text = "Activos";
            this.Rdb_activos.UseVisualStyleBackColor = true;
            // 
            // Rdb_inactivos
            // 
            this.Rdb_inactivos.AutoSize = true;
            this.Rdb_inactivos.Location = new System.Drawing.Point(5, 137);
            this.Rdb_inactivos.Name = "Rdb_inactivos";
            this.Rdb_inactivos.Size = new System.Drawing.Size(96, 24);
            this.Rdb_inactivos.TabIndex = 1;
            this.Rdb_inactivos.TabStop = true;
            this.Rdb_inactivos.Text = "Inactivos";
            this.Rdb_inactivos.UseVisualStyleBackColor = true;
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1486, 747);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.Dgv_usuarios);
            this.Controls.Add(this.Gpb_datospersonalesclave);
            this.Controls.Add(this.Gpb_datospersonales);
            this.Controls.Add(this.Gpb_datosusuario);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Gpb_modificar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_guardar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Usuarios";
            this.Load += new System.EventHandler(this.Frm_usuarios_Load);
            this.Gpb_modificar.ResumeLayout(false);
            this.Gpb_modificar.PerformLayout();
            this.Gpb_datospersonalesclave.ResumeLayout(false);
            this.Gpb_datospersonalesclave.PerformLayout();
            this.Gpb_datospersonales.ResumeLayout(false);
            this.Gpb_datospersonales.PerformLayout();
            this.Gpb_datosusuario.ResumeLayout(false);
            this.Gpb_datosusuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.GroupBox Gpb_modificar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label Txt_buscar_id;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.GroupBox Gpb_datospersonalesclave;
        private System.Windows.Forms.TextBox Txt_respuesta;
        private System.Windows.Forms.Label Lbl_respuestausuario;
        private System.Windows.Forms.Label Txt_estado;
        private System.Windows.Forms.TextBox txt_estadousuario;
        private System.Windows.Forms.GroupBox Gpb_datospersonales;
        private System.Windows.Forms.TextBox Txt_correo;
        private System.Windows.Forms.Label Txt_correousuario;
        private System.Windows.Forms.TextBox Txt_apellido;
        private System.Windows.Forms.TextBox Txt_nomb;
        private System.Windows.Forms.Label Txt_nombreusuario;
        private System.Windows.Forms.Label Txt_apellidousuario;
        private System.Windows.Forms.GroupBox Gpb_datosusuario;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label Txt_idusuario;
        private System.Windows.Forms.Label Txt_usernameusuario;
        private System.Windows.Forms.TextBox Txt_nombreusername;
        private System.Windows.Forms.Label Txt_contraseniausuario;
        private System.Windows.Forms.TextBox Txt_clave;
        private System.Windows.Forms.RadioButton Rdb_inhabilitado;
        private System.Windows.Forms.RadioButton Rdb_habilitado;
        private System.Windows.Forms.DataGridView Dgv_usuarios;
        private System.Windows.Forms.ComboBox Cmb_Pregunta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_preguntausuario;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Rdb_inactivos;
        private System.Windows.Forms.RadioButton Rdb_activos;
    }
}