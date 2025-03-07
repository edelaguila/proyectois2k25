namespace Capa_Vista_Seguridad
{
    partial class frm_login
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Cb_ver_password = new System.Windows.Forms.CheckBox();
            this.Txt_clave = new System.Windows.Forms.TextBox();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Btn_entrar = new System.Windows.Forms.Button();
            this.Btn_olvidocontrasenia = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcb_logo = new System.Windows.Forms.PictureBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(60)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(299, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 1);
            this.panel3.TabIndex = 289;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(60)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(299, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 1);
            this.panel2.TabIndex = 287;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.pcb_logo);
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 174);
            this.panel1.TabIndex = 286;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(479, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(169, 84);
            this.lblTitulo.TabIndex = 210;
            this.lblTitulo.Text = "LOGIN";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_cancelar.Location = new System.Drawing.Point(540, 408);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(420, 47);
            this.Btn_cancelar.TabIndex = 282;
            this.Btn_cancelar.Tag = "4";
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click_1);
            // 
            // Cb_ver_password
            // 
            this.Cb_ver_password.AutoSize = true;
            this.Cb_ver_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_ver_password.Location = new System.Drawing.Point(790, 327);
            this.Cb_ver_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_ver_password.Name = "Cb_ver_password";
            this.Cb_ver_password.Size = new System.Drawing.Size(18, 17);
            this.Cb_ver_password.TabIndex = 283;
            this.Cb_ver_password.Tag = "5";
            this.Cb_ver_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cb_ver_password.UseVisualStyleBackColor = true;
            this.Cb_ver_password.CheckedChanged += new System.EventHandler(this.Cb_ver_password_CheckedChanged_1);
            // 
            // Txt_clave
            // 
            this.Txt_clave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_clave.Location = new System.Drawing.Point(372, 293);
            this.Txt_clave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_clave.Name = "Txt_clave";
            this.Txt_clave.Size = new System.Drawing.Size(304, 38);
            this.Txt_clave.TabIndex = 280;
            this.Txt_clave.Tag = "2";
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usuario.Location = new System.Drawing.Point(369, 207);
            this.Txt_usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_usuario.Multiline = true;
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(383, 50);
            this.Txt_usuario.TabIndex = 279;
            this.Txt_usuario.Tag = "1";
            // 
            // Btn_entrar
            // 
            this.Btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.Btn_entrar.FlatAppearance.BorderSize = 0;
            this.Btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_entrar.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_entrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_entrar.Location = new System.Drawing.Point(114, 408);
            this.Btn_entrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_entrar.Name = "Btn_entrar";
            this.Btn_entrar.Size = new System.Drawing.Size(420, 47);
            this.Btn_entrar.TabIndex = 281;
            this.Btn_entrar.Tag = "1";
            this.Btn_entrar.Text = "Entrar";
            this.Btn_entrar.UseVisualStyleBackColor = false;
            this.Btn_entrar.Click += new System.EventHandler(this.Btn_entrar_Click_1);
            // 
            // Btn_olvidocontrasenia
            // 
            this.Btn_olvidocontrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_olvidocontrasenia.FlatAppearance.BorderSize = 0;
            this.Btn_olvidocontrasenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_olvidocontrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_olvidocontrasenia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_olvidocontrasenia.Location = new System.Drawing.Point(405, 471);
            this.Btn_olvidocontrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_olvidocontrasenia.Name = "Btn_olvidocontrasenia";
            this.Btn_olvidocontrasenia.Size = new System.Drawing.Size(271, 28);
            this.Btn_olvidocontrasenia.TabIndex = 278;
            this.Btn_olvidocontrasenia.Tag = "1";
            this.Btn_olvidocontrasenia.Text = "Olvide mi contraseña";
            this.Btn_olvidocontrasenia.UseVisualStyleBackColor = false;
            this.Btn_olvidocontrasenia.Click += new System.EventHandler(this.Btn_olvidocontrasenia_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::Capa_Vista_Seguridad.Properties.Resources.image_removebg_preview__5_;
            this.pictureBox3.Location = new System.Drawing.Point(815, 321);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 285;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Capa_Vista_Seguridad.Properties.Resources.bloquear;
            this.pictureBox2.Location = new System.Drawing.Point(298, 284);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 290;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Vista_Seguridad.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(298, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 288;
            this.pictureBox1.TabStop = false;
            // 
            // pcb_logo
            // 
            this.pcb_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pcb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcb_logo.Image = global::Capa_Vista_Seguridad.Properties.Resources.image_removebg_preview__4_;
            this.pcb_logo.Location = new System.Drawing.Point(789, 11);
            this.pcb_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pcb_logo.Name = "pcb_logo";
            this.pcb_logo.Size = new System.Drawing.Size(256, 159);
            this.pcb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_logo.TabIndex = 253;
            this.pcb_logo.TabStop = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Image = global::Capa_Vista_Seguridad.Properties.Resources.icons8_ayuda_30;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAyuda.Location = new System.Drawing.Point(0, 4);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(115, 44);
            this.btnAyuda.TabIndex = 284;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1062, 528);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Cb_ver_password);
            this.Controls.Add(this.Txt_clave);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.Btn_entrar);
            this.Controls.Add(this.Btn_olvidocontrasenia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_login_FormClosing);
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.CheckBox Cb_ver_password;
        private System.Windows.Forms.TextBox Txt_clave;
        public System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.Button Btn_entrar;
        private System.Windows.Forms.Button Btn_olvidocontrasenia;
        private System.Windows.Forms.PictureBox pcb_logo;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}