
namespace Capa_Vista_GD
{
    partial class frm_sanciones
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
            this.Chk_sancion = new System.Windows.Forms.CheckBox();
            this.Cbo_idFalta = new System.Windows.Forms.ComboBox();
            this.Txt_tipoSancion = new System.Windows.Forms.TextBox();
            this.Lbl_tipoSancion = new System.Windows.Forms.Label();
            this.Lbl_idFalta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chk_sancion
            // 
            this.Chk_sancion.AutoSize = true;
            this.Chk_sancion.Location = new System.Drawing.Point(512, 124);
            this.Chk_sancion.Margin = new System.Windows.Forms.Padding(4);
            this.Chk_sancion.Name = "Chk_sancion";
            this.Chk_sancion.Size = new System.Drawing.Size(197, 26);
            this.Chk_sancion.TabIndex = 14;
            this.Chk_sancion.Text = "No se aplica sanción";
            this.Chk_sancion.UseVisualStyleBackColor = true;
            this.Chk_sancion.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Cbo_idFalta
            // 
            this.Cbo_idFalta.FormattingEnabled = true;
            this.Cbo_idFalta.Location = new System.Drawing.Point(284, 120);
            this.Cbo_idFalta.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_idFalta.Name = "Cbo_idFalta";
            this.Cbo_idFalta.Size = new System.Drawing.Size(148, 30);
            this.Cbo_idFalta.TabIndex = 13;
            this.Cbo_idFalta.SelectedIndexChanged += new System.EventHandler(this.Cbo_idFalta_SelectedIndexChanged);
            // 
            // Txt_tipoSancion
            // 
            this.Txt_tipoSancion.Location = new System.Drawing.Point(284, 170);
            this.Txt_tipoSancion.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_tipoSancion.Name = "Txt_tipoSancion";
            this.Txt_tipoSancion.Size = new System.Drawing.Size(425, 30);
            this.Txt_tipoSancion.TabIndex = 12;
            this.Txt_tipoSancion.TextChanged += new System.EventHandler(this.Txt_tipoEvidencia_TextChanged);
            // 
            // Lbl_tipoSancion
            // 
            this.Lbl_tipoSancion.AutoSize = true;
            this.Lbl_tipoSancion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoSancion.Location = new System.Drawing.Point(77, 181);
            this.Lbl_tipoSancion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_tipoSancion.Name = "Lbl_tipoSancion";
            this.Lbl_tipoSancion.Size = new System.Drawing.Size(142, 22);
            this.Lbl_tipoSancion.TabIndex = 11;
            this.Lbl_tipoSancion.Text = "Tipo de sanción:";
            this.Lbl_tipoSancion.Click += new System.EventHandler(this.Lbl_tipoEvidencia_Click);
            // 
            // Lbl_idFalta
            // 
            this.Lbl_idFalta.AutoSize = true;
            this.Lbl_idFalta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idFalta.Location = new System.Drawing.Point(77, 128);
            this.Lbl_idFalta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_idFalta.Name = "Lbl_idFalta";
            this.Lbl_idFalta.Size = new System.Drawing.Size(120, 22);
            this.Lbl_idFalta.TabIndex = 10;
            this.Lbl_idFalta.Text = "ID de la falta:";
            this.Lbl_idFalta.Click += new System.EventHandler(this.Lbl_idFalta_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 225);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 30);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descripción de sanción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tipo de sanción:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 282);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(338, 30);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ayuda.Image = global::Capa_Vista_GD.Properties.Resources.ayuda;
            this.Btn_Ayuda.Location = new System.Drawing.Point(590, 12);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(89, 77);
            this.Btn_Ayuda.TabIndex = 26;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Salir.Image = global::Capa_Vista_GD.Properties.Resources.cerrar_sesion;
            this.Btn_Salir.Location = new System.Drawing.Point(685, 12);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(89, 77);
            this.Btn_Salir.TabIndex = 25;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Buscar.Image = global::Capa_Vista_GD.Properties.Resources.buscar;
            this.Btn_Buscar.Location = new System.Drawing.Point(495, 12);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(89, 77);
            this.Btn_Buscar.TabIndex = 24;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Eliminar.Image = global::Capa_Vista_GD.Properties.Resources.borrar;
            this.Btn_Eliminar.Location = new System.Drawing.Point(400, 12);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(89, 77);
            this.Btn_Eliminar.TabIndex = 23;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Editar.Image = global::Capa_Vista_GD.Properties.Resources.Editar;
            this.Btn_Editar.Location = new System.Drawing.Point(305, 12);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(89, 77);
            this.Btn_Editar.TabIndex = 22;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cancelar.Image = global::Capa_Vista_GD.Properties.Resources.cancelar;
            this.Btn_Cancelar.Location = new System.Drawing.Point(208, 12);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(90, 77);
            this.Btn_Cancelar.TabIndex = 21;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Guardar.Image = global::Capa_Vista_GD.Properties.Resources.guardar;
            this.Btn_Guardar.Location = new System.Drawing.Point(113, 12);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(90, 77);
            this.Btn_Guardar.TabIndex = 20;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Nuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Nuevo.Image = global::Capa_Vista_GD.Properties.Resources.agregar_archivo;
            this.Btn_Nuevo.Location = new System.Drawing.Point(17, 12);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(90, 77);
            this.Btn_Nuevo.TabIndex = 19;
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // frm_sanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(793, 339);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chk_sancion);
            this.Controls.Add(this.Cbo_idFalta);
            this.Controls.Add(this.Txt_tipoSancion);
            this.Controls.Add(this.Lbl_tipoSancion);
            this.Controls.Add(this.Lbl_idFalta);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_sanciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "15003 - Registro de Sancion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Chk_sancion;
        private System.Windows.Forms.ComboBox Cbo_idFalta;
        private System.Windows.Forms.TextBox Txt_tipoSancion;
        private System.Windows.Forms.Label Lbl_tipoSancion;
        private System.Windows.Forms.Label Lbl_idFalta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Nuevo;
    }
}