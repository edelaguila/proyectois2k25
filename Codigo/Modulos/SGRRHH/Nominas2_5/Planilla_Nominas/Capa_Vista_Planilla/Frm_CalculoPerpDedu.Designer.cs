namespace Capa_Vista_Planilla
{
    partial class Frm_CalculoPerpDedu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CalculoPerpDedu));
            this.Txt_ClaveVin = new System.Windows.Forms.TextBox();
            this.Lbl_DeduPerp = new System.Windows.Forms.Label();
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Lbl_pk_ = new System.Windows.Forms.Label();
            this.Lbl_Vinculacion = new System.Windows.Forms.Label();
            this.Cbo_Empleado = new System.Windows.Forms.ComboBox();
            this.Cbo_DeduccionPerpcepcion = new System.Windows.Forms.ComboBox();
            this.dgv_deduPerp = new System.Windows.Forms.DataGridView();
            this.cbo_mes = new System.Windows.Forms.ComboBox();
            this.Lbl_mes = new System.Windows.Forms.Label();
            this.dgv_totalmes = new System.Windows.Forms.DataGridView();
            this.Lbl_Totales = new System.Windows.Forms.Label();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_Reportes = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_insertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deduPerp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_totalmes)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_ClaveVin
            // 
            this.Txt_ClaveVin.Enabled = false;
            this.Txt_ClaveVin.Location = new System.Drawing.Point(268, 161);
            this.Txt_ClaveVin.Name = "Txt_ClaveVin";
            this.Txt_ClaveVin.ReadOnly = true;
            this.Txt_ClaveVin.Size = new System.Drawing.Size(193, 22);
            this.Txt_ClaveVin.TabIndex = 90;
            // 
            // Lbl_DeduPerp
            // 
            this.Lbl_DeduPerp.AutoSize = true;
            this.Lbl_DeduPerp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DeduPerp.Location = new System.Drawing.Point(30, 255);
            this.Lbl_DeduPerp.Name = "Lbl_DeduPerp";
            this.Lbl_DeduPerp.Size = new System.Drawing.Size(200, 22);
            this.Lbl_DeduPerp.TabIndex = 84;
            this.Lbl_DeduPerp.Text = "Deduccion/Perpcepcion";
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Empleado.Location = new System.Drawing.Point(30, 208);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(90, 22);
            this.Lbl_Empleado.TabIndex = 83;
            this.Lbl_Empleado.Text = "Empleado";
            this.Lbl_Empleado.Click += new System.EventHandler(this.Lbl_Empleado_Click);
            // 
            // Lbl_pk_
            // 
            this.Lbl_pk_.AutoSize = true;
            this.Lbl_pk_.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_pk_.Location = new System.Drawing.Point(30, 159);
            this.Lbl_pk_.Name = "Lbl_pk_";
            this.Lbl_pk_.Size = new System.Drawing.Size(147, 22);
            this.Lbl_pk_.TabIndex = 82;
            this.Lbl_pk_.Text = "Clave Dedu/Perp";
            // 
            // Lbl_Vinculacion
            // 
            this.Lbl_Vinculacion.AutoSize = true;
            this.Lbl_Vinculacion.Font = new System.Drawing.Font("Haettenschweiler", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Vinculacion.Location = new System.Drawing.Point(10, 91);
            this.Lbl_Vinculacion.Name = "Lbl_Vinculacion";
            this.Lbl_Vinculacion.Size = new System.Drawing.Size(714, 45);
            this.Lbl_Vinculacion.TabIndex = 78;
            this.Lbl_Vinculacion.Text = "Vinculacion Empleados a Deducciones/Percepciones";
            // 
            // Cbo_Empleado
            // 
            this.Cbo_Empleado.FormattingEnabled = true;
            this.Cbo_Empleado.Location = new System.Drawing.Point(268, 209);
            this.Cbo_Empleado.Name = "Cbo_Empleado";
            this.Cbo_Empleado.Size = new System.Drawing.Size(193, 24);
            this.Cbo_Empleado.TabIndex = 92;
            this.Cbo_Empleado.SelectedIndexChanged += new System.EventHandler(this.Cbo_Empleado_SelectedIndexChanged);
            // 
            // Cbo_DeduccionPerpcepcion
            // 
            this.Cbo_DeduccionPerpcepcion.FormattingEnabled = true;
            this.Cbo_DeduccionPerpcepcion.Location = new System.Drawing.Point(268, 255);
            this.Cbo_DeduccionPerpcepcion.Name = "Cbo_DeduccionPerpcepcion";
            this.Cbo_DeduccionPerpcepcion.Size = new System.Drawing.Size(193, 24);
            this.Cbo_DeduccionPerpcepcion.TabIndex = 93;
            this.Cbo_DeduccionPerpcepcion.SelectedIndexChanged += new System.EventHandler(this.Cbo_DeduccionPerpcepcion_SelectedIndexChanged);
            // 
            // dgv_deduPerp
            // 
            this.dgv_deduPerp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_deduPerp.Location = new System.Drawing.Point(12, 370);
            this.dgv_deduPerp.Name = "dgv_deduPerp";
            this.dgv_deduPerp.RowHeadersWidth = 51;
            this.dgv_deduPerp.RowTemplate.Height = 24;
            this.dgv_deduPerp.Size = new System.Drawing.Size(1188, 196);
            this.dgv_deduPerp.TabIndex = 94;
            this.dgv_deduPerp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_deduPerp_CellContentClick);
            // 
            // cbo_mes
            // 
            this.cbo_mes.FormattingEnabled = true;
            this.cbo_mes.Location = new System.Drawing.Point(268, 311);
            this.cbo_mes.Name = "cbo_mes";
            this.cbo_mes.Size = new System.Drawing.Size(193, 24);
            this.cbo_mes.TabIndex = 95;
            // 
            // Lbl_mes
            // 
            this.Lbl_mes.AutoSize = true;
            this.Lbl_mes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mes.Location = new System.Drawing.Point(30, 311);
            this.Lbl_mes.Name = "Lbl_mes";
            this.Lbl_mes.Size = new System.Drawing.Size(44, 22);
            this.Lbl_mes.TabIndex = 96;
            this.Lbl_mes.Text = "Mes";
            this.Lbl_mes.Click += new System.EventHandler(this.Lbl_mes_Click);
            // 
            // dgv_totalmes
            // 
            this.dgv_totalmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_totalmes.Location = new System.Drawing.Point(563, 175);
            this.dgv_totalmes.Name = "dgv_totalmes";
            this.dgv_totalmes.RowHeadersWidth = 51;
            this.dgv_totalmes.RowTemplate.Height = 24;
            this.dgv_totalmes.Size = new System.Drawing.Size(637, 174);
            this.dgv_totalmes.TabIndex = 99;
            // 
            // Lbl_Totales
            // 
            this.Lbl_Totales.AutoSize = true;
            this.Lbl_Totales.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Totales.Location = new System.Drawing.Point(732, 138);
            this.Lbl_Totales.Name = "Lbl_Totales";
            this.Lbl_Totales.Size = new System.Drawing.Size(298, 23);
            this.Lbl_Totales.TabIndex = 101;
            this.Lbl_Totales.Text = "Totales Deducciones/Percepciones";
            // 
            // Btn_salir
            // 
            this.Btn_salir.Image = global::Capa_Vista_Planilla.Properties.Resources.icono_salir_64px1;
            this.Btn_salir.Location = new System.Drawing.Point(1151, 26);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 71);
            this.Btn_salir.TabIndex = 100;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_Reportes
            // 
            this.Btn_Reportes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reportes.Image")));
            this.Btn_Reportes.Location = new System.Drawing.Point(1070, 26);
            this.Btn_Reportes.Name = "Btn_Reportes";
            this.Btn_Reportes.Size = new System.Drawing.Size(75, 71);
            this.Btn_Reportes.TabIndex = 98;
            this.Btn_Reportes.UseVisualStyleBackColor = true;
            this.Btn_Reportes.Click += new System.EventHandler(this.Btn_Reportes_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Image = global::Capa_Vista_Planilla.Properties.Resources.icono_ayuda_64px;
            this.Btn_Ayuda.Location = new System.Drawing.Point(992, 26);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(75, 71);
            this.Btn_Ayuda.TabIndex = 97;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Image = global::Capa_Vista_Planilla.Properties.Resources.borrar;
            this.Btn_eliminar.Location = new System.Drawing.Point(309, 12);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(75, 71);
            this.Btn_eliminar.TabIndex = 91;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Image = global::Capa_Vista_Planilla.Properties.Resources.icono_cancelar_64px;
            this.Btn_cancelar.Location = new System.Drawing.Point(236, 12);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 71);
            this.Btn_cancelar.TabIndex = 86;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Image = global::Capa_Vista_Planilla.Properties.Resources.icono_guardar_64px;
            this.Btn_guardar.Location = new System.Drawing.Point(162, 12);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(75, 71);
            this.Btn_guardar.TabIndex = 81;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Image = global::Capa_Vista_Planilla.Properties.Resources.convenio;
            this.Btn_editar.Location = new System.Drawing.Point(88, 12);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(75, 71);
            this.Btn_editar.TabIndex = 80;
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_insertar
            // 
            this.Btn_insertar.Image = global::Capa_Vista_Planilla.Properties.Resources.agregar_archivo;
            this.Btn_insertar.Location = new System.Drawing.Point(18, 12);
            this.Btn_insertar.Name = "Btn_insertar";
            this.Btn_insertar.Size = new System.Drawing.Size(75, 71);
            this.Btn_insertar.TabIndex = 79;
            this.Btn_insertar.UseVisualStyleBackColor = true;
            this.Btn_insertar.Click += new System.EventHandler(this.Btn_insertar_Click);
            // 
            // Frm_CalculoPerpDedu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1235, 592);
            this.Controls.Add(this.Lbl_Totales);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.dgv_totalmes);
            this.Controls.Add(this.Btn_Reportes);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Lbl_mes);
            this.Controls.Add(this.cbo_mes);
            this.Controls.Add(this.dgv_deduPerp);
            this.Controls.Add(this.Cbo_DeduccionPerpcepcion);
            this.Controls.Add(this.Cbo_Empleado);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Txt_ClaveVin);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Lbl_DeduPerp);
            this.Controls.Add(this.Lbl_Empleado);
            this.Controls.Add(this.Lbl_pk_);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_insertar);
            this.Controls.Add(this.Lbl_Vinculacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CalculoPerpDedu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Calculo Deducciones/Percepciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deduPerp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_totalmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_ClaveVin;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Label Lbl_DeduPerp;
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.Label Lbl_pk_;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_insertar;
        private System.Windows.Forms.Label Lbl_Vinculacion;
        private System.Windows.Forms.ComboBox Cbo_Empleado;
        private System.Windows.Forms.ComboBox Cbo_DeduccionPerpcepcion;
        private System.Windows.Forms.DataGridView dgv_deduPerp;
        private System.Windows.Forms.ComboBox cbo_mes;
        private System.Windows.Forms.Label Lbl_mes;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Reportes;
        private System.Windows.Forms.DataGridView dgv_totalmes;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Label Lbl_Totales;
    }
}