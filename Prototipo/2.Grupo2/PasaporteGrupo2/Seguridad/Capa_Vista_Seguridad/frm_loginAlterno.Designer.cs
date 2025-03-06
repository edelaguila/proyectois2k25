namespace Capa_Vista_Seguridad
{
    partial class frm_loginAlterno
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
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Cb_ver_password = new System.Windows.Forms.CheckBox();
            this.Txt_clave = new System.Windows.Forms.TextBox();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Btn_entrar = new System.Windows.Forms.Button();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.Lbl_clave = new System.Windows.Forms.Label();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 37);
            this.label2.TabIndex = 218;
            this.label2.Text = "Modulo seguridad";
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.Teal;
            this.Btn_cancelar.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_cancelar.Location = new System.Drawing.Point(389, 208);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(160, 46);
            this.Btn_cancelar.TabIndex = 214;
            this.Btn_cancelar.Tag = "4";
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Cb_ver_password
            // 
            this.Cb_ver_password.AutoSize = true;
            this.Cb_ver_password.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_ver_password.Location = new System.Drawing.Point(574, 162);
            this.Cb_ver_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_ver_password.Name = "Cb_ver_password";
            this.Cb_ver_password.Size = new System.Drawing.Size(126, 33);
            this.Cb_ver_password.TabIndex = 215;
            this.Cb_ver_password.Tag = "5";
            this.Cb_ver_password.Text = "Ver clave";
            this.Cb_ver_password.UseVisualStyleBackColor = true;
            this.Cb_ver_password.CheckedChanged += new System.EventHandler(this.Cb_ver_password_CheckedChanged);
            // 
            // Txt_clave
            // 
            this.Txt_clave.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_clave.Location = new System.Drawing.Point(221, 158);
            this.Txt_clave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_clave.Name = "Txt_clave";
            this.Txt_clave.Size = new System.Drawing.Size(327, 36);
            this.Txt_clave.TabIndex = 212;
            this.Txt_clave.Tag = "2";
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usuario.Location = new System.Drawing.Point(221, 119);
            this.Txt_usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(327, 36);
            this.Txt_usuario.TabIndex = 211;
            this.Txt_usuario.Tag = "1";
            // 
            // Btn_entrar
            // 
            this.Btn_entrar.BackColor = System.Drawing.Color.Teal;
            this.Btn_entrar.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_entrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_entrar.Location = new System.Drawing.Point(221, 208);
            this.Btn_entrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_entrar.Name = "Btn_entrar";
            this.Btn_entrar.Size = new System.Drawing.Size(160, 46);
            this.Btn_entrar.TabIndex = 213;
            this.Btn_entrar.Tag = "1";
            this.Btn_entrar.Text = "Entrar";
            this.Btn_entrar.UseVisualStyleBackColor = false;
            this.Btn_entrar.Click += new System.EventHandler(this.Btn_entrar_Click);
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.Location = new System.Drawing.Point(114, 119);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(97, 29);
            this.Lbl_usuario.TabIndex = 217;
            this.Lbl_usuario.Text = "Usuario:";
            // 
            // Lbl_clave
            // 
            this.Lbl_clave.AutoSize = true;
            this.Lbl_clave.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_clave.Location = new System.Drawing.Point(140, 158);
            this.Lbl_clave.Name = "Lbl_clave";
            this.Lbl_clave.Size = new System.Drawing.Size(74, 29);
            this.Lbl_clave.TabIndex = 216;
            this.Lbl_clave.Text = "Clave:";
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayuda.Image = global::Capa_Vista_Seguridad.Properties.Resources.icons8_ayuda_30;
            this.btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ayuda.Location = new System.Drawing.Point(637, 14);
            this.btn_ayuda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(115, 44);
            this.btn_ayuda.TabIndex = 252;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // frm_loginAlterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 352);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Cb_ver_password);
            this.Controls.Add(this.Txt_clave);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.Btn_entrar);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.Lbl_clave);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_loginAlterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_loginAlterno_FormClosing);
            this.Load += new System.EventHandler(this.frm_loginAlterno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.CheckBox Cb_ver_password;
        private System.Windows.Forms.TextBox Txt_clave;
        public System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.Button Btn_entrar;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.Label Lbl_clave;
        private System.Windows.Forms.Button btn_ayuda;
    }
}