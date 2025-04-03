
namespace Capa_Vista_GD
{
    partial class frm_evidencias
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
            this.Lbl_idFalta = new System.Windows.Forms.Label();
            this.Txt_tipoEvidencia = new System.Windows.Forms.TextBox();
            this.Lbl_tipoEvidencia = new System.Windows.Forms.Label();
            this.Txt_cargarArchivo = new System.Windows.Forms.TextBox();
            this.Lbl_cargarArchivo = new System.Windows.Forms.Label();
            this.Cbo_idFalta = new System.Windows.Forms.ComboBox();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Gpb_EvidenciaValida = new System.Windows.Forms.GroupBox();
            this.Gpb_no = new System.Windows.Forms.RadioButton();
            this.Rdb_Si = new System.Windows.Forms.RadioButton();
            this.Gpb_EvidenciaValida.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_idFalta
            // 
            this.Lbl_idFalta.AutoSize = true;
            this.Lbl_idFalta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idFalta.Location = new System.Drawing.Point(150, 159);
            this.Lbl_idFalta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_idFalta.Name = "Lbl_idFalta";
            this.Lbl_idFalta.Size = new System.Drawing.Size(120, 22);
            this.Lbl_idFalta.TabIndex = 0;
            this.Lbl_idFalta.Text = "ID de la falta:";
            this.Lbl_idFalta.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_tipoEvidencia
            // 
            this.Txt_tipoEvidencia.Location = new System.Drawing.Point(317, 199);
            this.Txt_tipoEvidencia.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_tipoEvidencia.Name = "Txt_tipoEvidencia";
            this.Txt_tipoEvidencia.Size = new System.Drawing.Size(310, 30);
            this.Txt_tipoEvidencia.TabIndex = 3;
            // 
            // Lbl_tipoEvidencia
            // 
            this.Lbl_tipoEvidencia.AutoSize = true;
            this.Lbl_tipoEvidencia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoEvidencia.Location = new System.Drawing.Point(150, 207);
            this.Lbl_tipoEvidencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_tipoEvidencia.Name = "Lbl_tipoEvidencia";
            this.Lbl_tipoEvidencia.Size = new System.Drawing.Size(159, 22);
            this.Lbl_tipoEvidencia.TabIndex = 2;
            this.Lbl_tipoEvidencia.Text = "Tipo de evidencia:";
            // 
            // Txt_cargarArchivo
            // 
            this.Txt_cargarArchivo.Location = new System.Drawing.Point(317, 250);
            this.Txt_cargarArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_cargarArchivo.Name = "Txt_cargarArchivo";
            this.Txt_cargarArchivo.Size = new System.Drawing.Size(310, 30);
            this.Txt_cargarArchivo.TabIndex = 5;
            // 
            // Lbl_cargarArchivo
            // 
            this.Lbl_cargarArchivo.AutoSize = true;
            this.Lbl_cargarArchivo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cargarArchivo.Location = new System.Drawing.Point(150, 258);
            this.Lbl_cargarArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_cargarArchivo.Name = "Lbl_cargarArchivo";
            this.Lbl_cargarArchivo.Size = new System.Drawing.Size(135, 22);
            this.Lbl_cargarArchivo.TabIndex = 4;
            this.Lbl_cargarArchivo.Text = "Cargar archivo:";
            // 
            // Cbo_idFalta
            // 
            this.Cbo_idFalta.FormattingEnabled = true;
            this.Cbo_idFalta.Location = new System.Drawing.Point(317, 151);
            this.Cbo_idFalta.Name = "Cbo_idFalta";
            this.Cbo_idFalta.Size = new System.Drawing.Size(109, 30);
            this.Cbo_idFalta.TabIndex = 8;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ayuda.Image = global::Capa_Vista_GD.Properties.Resources.ayuda;
            this.Btn_Ayuda.Location = new System.Drawing.Point(580, 27);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(89, 77);
            this.Btn_Ayuda.TabIndex = 17;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Salir.Image = global::Capa_Vista_GD.Properties.Resources.cerrar_sesion;
            this.Btn_Salir.Location = new System.Drawing.Point(675, 27);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(89, 77);
            this.Btn_Salir.TabIndex = 16;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Buscar.Image = global::Capa_Vista_GD.Properties.Resources.buscar;
            this.Btn_Buscar.Location = new System.Drawing.Point(485, 27);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(89, 77);
            this.Btn_Buscar.TabIndex = 15;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Eliminar.Image = global::Capa_Vista_GD.Properties.Resources.borrar;
            this.Btn_Eliminar.Location = new System.Drawing.Point(390, 27);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(89, 77);
            this.Btn_Eliminar.TabIndex = 14;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Editar.Image = global::Capa_Vista_GD.Properties.Resources.Editar;
            this.Btn_Editar.Location = new System.Drawing.Point(295, 27);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(89, 77);
            this.Btn_Editar.TabIndex = 13;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cancelar.Image = global::Capa_Vista_GD.Properties.Resources.cancelar;
            this.Btn_Cancelar.Location = new System.Drawing.Point(198, 27);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(90, 77);
            this.Btn_Cancelar.TabIndex = 12;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Guardar.Image = global::Capa_Vista_GD.Properties.Resources.guardar;
            this.Btn_Guardar.Location = new System.Drawing.Point(103, 27);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(90, 77);
            this.Btn_Guardar.TabIndex = 11;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Nuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Nuevo.Image = global::Capa_Vista_GD.Properties.Resources.agregar_archivo;
            this.Btn_Nuevo.Location = new System.Drawing.Point(7, 27);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(90, 77);
            this.Btn_Nuevo.TabIndex = 10;
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // Gpb_EvidenciaValida
            // 
            this.Gpb_EvidenciaValida.Controls.Add(this.Gpb_no);
            this.Gpb_EvidenciaValida.Controls.Add(this.Rdb_Si);
            this.Gpb_EvidenciaValida.Location = new System.Drawing.Point(442, 122);
            this.Gpb_EvidenciaValida.Name = "Gpb_EvidenciaValida";
            this.Gpb_EvidenciaValida.Size = new System.Drawing.Size(185, 70);
            this.Gpb_EvidenciaValida.TabIndex = 18;
            this.Gpb_EvidenciaValida.TabStop = false;
            this.Gpb_EvidenciaValida.Text = "¿Evidencia valida?";
            this.Gpb_EvidenciaValida.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Gpb_no
            // 
            this.Gpb_no.AutoSize = true;
            this.Gpb_no.Location = new System.Drawing.Point(94, 29);
            this.Gpb_no.Name = "Gpb_no";
            this.Gpb_no.Size = new System.Drawing.Size(55, 26);
            this.Gpb_no.TabIndex = 1;
            this.Gpb_no.TabStop = true;
            this.Gpb_no.Text = "No";
            this.Gpb_no.UseVisualStyleBackColor = true;
            // 
            // Rdb_Si
            // 
            this.Rdb_Si.AutoSize = true;
            this.Rdb_Si.Location = new System.Drawing.Point(29, 29);
            this.Rdb_Si.Name = "Rdb_Si";
            this.Rdb_Si.Size = new System.Drawing.Size(48, 26);
            this.Rdb_Si.TabIndex = 0;
            this.Rdb_Si.TabStop = true;
            this.Rdb_Si.Text = "Si";
            this.Rdb_Si.UseVisualStyleBackColor = true;
            // 
            // frm_evidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(770, 302);
            this.Controls.Add(this.Gpb_EvidenciaValida);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Cbo_idFalta);
            this.Controls.Add(this.Txt_cargarArchivo);
            this.Controls.Add(this.Lbl_cargarArchivo);
            this.Controls.Add(this.Txt_tipoEvidencia);
            this.Controls.Add(this.Lbl_tipoEvidencia);
            this.Controls.Add(this.Lbl_idFalta);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_evidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "15002 - Ingreso de evidencias";
            this.Gpb_EvidenciaValida.ResumeLayout(false);
            this.Gpb_EvidenciaValida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_idFalta;
        private System.Windows.Forms.TextBox Txt_tipoEvidencia;
        private System.Windows.Forms.Label Lbl_tipoEvidencia;
        private System.Windows.Forms.TextBox Txt_cargarArchivo;
        private System.Windows.Forms.Label Lbl_cargarArchivo;
        private System.Windows.Forms.ComboBox Cbo_idFalta;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.GroupBox Gpb_EvidenciaValida;
        private System.Windows.Forms.RadioButton Gpb_no;
        private System.Windows.Forms.RadioButton Rdb_Si;
    }
}