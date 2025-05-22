namespace Capa_Vista_Planilla
{
    partial class Frm_GenPlanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GenPlanilla));
            this.Lbl_Correlativo = new System.Windows.Forms.Label();
            this.Dgv_encabezado = new System.Windows.Forms.DataGridView();
            this.Txt_Correlativo = new System.Windows.Forms.TextBox();
            this.Lbl_FechaFin = new System.Windows.Forms.Label();
            this.Lbl_FechaInicio = new System.Windows.Forms.Label();
            this.Lbl_pk_Encabezado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.Dtp_final = new System.Windows.Forms.DateTimePicker();
            this.Txt_ClaveEncabezado = new System.Windows.Forms.TextBox();
            this.Btn_Dedu_Per = new System.Windows.Forms.Button();
            this.cbo_mes = new System.Windows.Forms.ComboBox();
            this.dgv_encabezadoInicial = new System.Windows.Forms.DataGridView();
            this.Lbl_SeleccionMes = new System.Windows.Forms.Label();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_Reportes = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_impresora = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_insertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_encabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_encabezadoInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Correlativo
            // 
            this.Lbl_Correlativo.AutoSize = true;
            this.Lbl_Correlativo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Correlativo.Location = new System.Drawing.Point(21, 182);
            this.Lbl_Correlativo.Name = "Lbl_Correlativo";
            this.Lbl_Correlativo.Size = new System.Drawing.Size(102, 22);
            this.Lbl_Correlativo.TabIndex = 65;
            this.Lbl_Correlativo.Text = "Correlativo";
            // 
            // Dgv_encabezado
            // 
            this.Dgv_encabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_encabezado.Location = new System.Drawing.Point(23, 299);
            this.Dgv_encabezado.Name = "Dgv_encabezado";
            this.Dgv_encabezado.RowHeadersWidth = 51;
            this.Dgv_encabezado.RowTemplate.Height = 24;
            this.Dgv_encabezado.Size = new System.Drawing.Size(1380, 266);
            this.Dgv_encabezado.TabIndex = 52;
            this.Dgv_encabezado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_encabezado_CellContentClick);
            // 
            // Txt_Correlativo
            // 
            this.Txt_Correlativo.Location = new System.Drawing.Point(220, 182);
            this.Txt_Correlativo.Name = "Txt_Correlativo";
            this.Txt_Correlativo.Size = new System.Drawing.Size(193, 22);
            this.Txt_Correlativo.TabIndex = 47;
            // 
            // Lbl_FechaFin
            // 
            this.Lbl_FechaFin.AutoSize = true;
            this.Lbl_FechaFin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaFin.Location = new System.Drawing.Point(24, 254);
            this.Lbl_FechaFin.Name = "Lbl_FechaFin";
            this.Lbl_FechaFin.Size = new System.Drawing.Size(88, 22);
            this.Lbl_FechaFin.TabIndex = 42;
            this.Lbl_FechaFin.Text = "Fecha Fin";
            // 
            // Lbl_FechaInicio
            // 
            this.Lbl_FechaInicio.AutoSize = true;
            this.Lbl_FechaInicio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaInicio.Location = new System.Drawing.Point(21, 217);
            this.Lbl_FechaInicio.Name = "Lbl_FechaInicio";
            this.Lbl_FechaInicio.Size = new System.Drawing.Size(108, 22);
            this.Lbl_FechaInicio.TabIndex = 41;
            this.Lbl_FechaInicio.Text = "Fecha Inicio";
            // 
            // Lbl_pk_Encabezado
            // 
            this.Lbl_pk_Encabezado.AutoSize = true;
            this.Lbl_pk_Encabezado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_pk_Encabezado.Location = new System.Drawing.Point(21, 143);
            this.Lbl_pk_Encabezado.Name = "Lbl_pk_Encabezado";
            this.Lbl_pk_Encabezado.Size = new System.Drawing.Size(157, 22);
            this.Lbl_pk_Encabezado.TabIndex = 40;
            this.Lbl_pk_Encabezado.Text = "Clave Encabezado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 45);
            this.label1.TabIndex = 35;
            this.label1.Text = "Encabezado Planilla";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dtp_inicio
            // 
            this.Dtp_inicio.Location = new System.Drawing.Point(220, 217);
            this.Dtp_inicio.Name = "Dtp_inicio";
            this.Dtp_inicio.Size = new System.Drawing.Size(193, 22);
            this.Dtp_inicio.TabIndex = 74;
            // 
            // Dtp_final
            // 
            this.Dtp_final.Location = new System.Drawing.Point(220, 254);
            this.Dtp_final.Name = "Dtp_final";
            this.Dtp_final.Size = new System.Drawing.Size(193, 22);
            this.Dtp_final.TabIndex = 75;
            // 
            // Txt_ClaveEncabezado
            // 
            this.Txt_ClaveEncabezado.Enabled = false;
            this.Txt_ClaveEncabezado.Location = new System.Drawing.Point(220, 145);
            this.Txt_ClaveEncabezado.Name = "Txt_ClaveEncabezado";
            this.Txt_ClaveEncabezado.ReadOnly = true;
            this.Txt_ClaveEncabezado.Size = new System.Drawing.Size(193, 22);
            this.Txt_ClaveEncabezado.TabIndex = 76;
            // 
            // Btn_Dedu_Per
            // 
            this.Btn_Dedu_Per.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(161)))), ((int)(((byte)(214)))));
            this.Btn_Dedu_Per.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dedu_Per.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.Btn_Dedu_Per.Location = new System.Drawing.Point(464, 35);
            this.Btn_Dedu_Per.Name = "Btn_Dedu_Per";
            this.Btn_Dedu_Per.Size = new System.Drawing.Size(247, 39);
            this.Btn_Dedu_Per.TabIndex = 78;
            this.Btn_Dedu_Per.Text = "Deducciones/Percepciones";
            this.Btn_Dedu_Per.UseVisualStyleBackColor = false;
            this.Btn_Dedu_Per.Click += new System.EventHandler(this.Btn_Dedu_Per_Click);
            // 
            // cbo_mes
            // 
            this.cbo_mes.FormattingEnabled = true;
            this.cbo_mes.Location = new System.Drawing.Point(496, 180);
            this.cbo_mes.Name = "cbo_mes";
            this.cbo_mes.Size = new System.Drawing.Size(121, 24);
            this.cbo_mes.TabIndex = 79;
            this.cbo_mes.SelectedIndexChanged += new System.EventHandler(this.cbo_mes_SelectedIndexChanged);
            // 
            // dgv_encabezadoInicial
            // 
            this.dgv_encabezadoInicial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_encabezadoInicial.Location = new System.Drawing.Point(699, 143);
            this.dgv_encabezadoInicial.Name = "dgv_encabezadoInicial";
            this.dgv_encabezadoInicial.RowHeadersWidth = 51;
            this.dgv_encabezadoInicial.RowTemplate.Height = 24;
            this.dgv_encabezadoInicial.Size = new System.Drawing.Size(704, 150);
            this.dgv_encabezadoInicial.TabIndex = 80;
            this.dgv_encabezadoInicial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Lbl_SeleccionMes
            // 
            this.Lbl_SeleccionMes.AutoSize = true;
            this.Lbl_SeleccionMes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SeleccionMes.Location = new System.Drawing.Point(475, 145);
            this.Lbl_SeleccionMes.Name = "Lbl_SeleccionMes";
            this.Lbl_SeleccionMes.Size = new System.Drawing.Size(142, 22);
            this.Lbl_SeleccionMes.TabIndex = 82;
            this.Lbl_SeleccionMes.Text = "Seleccione Mes:";
            // 
            // Btn_salir
            // 
            this.Btn_salir.Image = global::Capa_Vista_Planilla.Properties.Resources.icono_salir_64px;
            this.Btn_salir.Location = new System.Drawing.Point(1287, 3);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 71);
            this.Btn_salir.TabIndex = 101;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_Reportes
            // 
            this.Btn_Reportes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reportes.Image")));
            this.Btn_Reportes.Location = new System.Drawing.Point(1206, 3);
            this.Btn_Reportes.Name = "Btn_Reportes";
            this.Btn_Reportes.Size = new System.Drawing.Size(75, 71);
            this.Btn_Reportes.TabIndex = 100;
            this.Btn_Reportes.UseVisualStyleBackColor = true;
            this.Btn_Reportes.Click += new System.EventHandler(this.Btn_Reportes_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Image = global::Capa_Vista_Planilla.Properties.Resources.icono_ayuda_64px1;
            this.Btn_Ayuda.Location = new System.Drawing.Point(1128, 3);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(75, 71);
            this.Btn_Ayuda.TabIndex = 99;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_impresora
            // 
            this.Btn_impresora.Image = global::Capa_Vista_Planilla.Properties.Resources.printer;
            this.Btn_impresora.Location = new System.Drawing.Point(383, 12);
            this.Btn_impresora.Name = "Btn_impresora";
            this.Btn_impresora.Size = new System.Drawing.Size(75, 71);
            this.Btn_impresora.TabIndex = 81;
            this.Btn_impresora.UseVisualStyleBackColor = true;
            this.Btn_impresora.Click += new System.EventHandler(this.Btn_impresora_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Image = global::Capa_Vista_Planilla.Properties.Resources.borrar1;
            this.Btn_eliminar.Location = new System.Drawing.Point(311, 12);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(75, 71);
            this.Btn_eliminar.TabIndex = 77;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Image = global::Capa_Vista_Planilla.Properties.Resources.icono_cancelar_64px1;
            this.Btn_cancelar.Location = new System.Drawing.Point(238, 12);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 71);
            this.Btn_cancelar.TabIndex = 55;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Image = global::Capa_Vista_Planilla.Properties.Resources.icono_guardar_64px1;
            this.Btn_guardar.Location = new System.Drawing.Point(164, 12);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(75, 71);
            this.Btn_guardar.TabIndex = 38;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Image = global::Capa_Vista_Planilla.Properties.Resources.convenio1;
            this.Btn_editar.Location = new System.Drawing.Point(90, 12);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(75, 71);
            this.Btn_editar.TabIndex = 37;
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_insertar
            // 
            this.Btn_insertar.Image = global::Capa_Vista_Planilla.Properties.Resources.agregar_archivo1;
            this.Btn_insertar.Location = new System.Drawing.Point(20, 12);
            this.Btn_insertar.Name = "Btn_insertar";
            this.Btn_insertar.Size = new System.Drawing.Size(75, 71);
            this.Btn_insertar.TabIndex = 36;
            this.Btn_insertar.UseVisualStyleBackColor = true;
            this.Btn_insertar.Click += new System.EventHandler(this.Btn_insertar_Click);
            // 
            // Frm_GenPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1415, 592);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_Reportes);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Lbl_SeleccionMes);
            this.Controls.Add(this.Btn_impresora);
            this.Controls.Add(this.dgv_encabezadoInicial);
            this.Controls.Add(this.cbo_mes);
            this.Controls.Add(this.Btn_Dedu_Per);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Txt_ClaveEncabezado);
            this.Controls.Add(this.Dtp_final);
            this.Controls.Add(this.Dtp_inicio);
            this.Controls.Add(this.Lbl_Correlativo);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Dgv_encabezado);
            this.Controls.Add(this.Txt_Correlativo);
            this.Controls.Add(this.Lbl_FechaFin);
            this.Controls.Add(this.Lbl_FechaInicio);
            this.Controls.Add(this.Lbl_pk_Encabezado);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_insertar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_GenPlanilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Encabezado Planilla";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_encabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_encabezadoInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Correlativo;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.DataGridView Dgv_encabezado;
        private System.Windows.Forms.TextBox Txt_Correlativo;
        private System.Windows.Forms.Label Lbl_FechaFin;
        private System.Windows.Forms.Label Lbl_FechaInicio;
        private System.Windows.Forms.Label Lbl_pk_Encabezado;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_insertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_inicio;
        private System.Windows.Forms.DateTimePicker Dtp_final;
        private System.Windows.Forms.TextBox Txt_ClaveEncabezado;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_Dedu_Per;
        private System.Windows.Forms.ComboBox cbo_mes;
        private System.Windows.Forms.DataGridView dgv_encabezadoInicial;
        private System.Windows.Forms.Button Btn_impresora;
        private System.Windows.Forms.Label Lbl_SeleccionMes;
        private System.Windows.Forms.Button Btn_Reportes;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_salir;
    }
}