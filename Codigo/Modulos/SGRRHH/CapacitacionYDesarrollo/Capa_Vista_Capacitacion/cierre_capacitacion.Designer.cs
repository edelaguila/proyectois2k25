
namespace Capa_Vista_Capacitacion
{
    partial class cierre_capacitacion
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblCapacitación = new System.Windows.Forms.Label();
            this.lblCierre = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbCapacitación = new System.Windows.Forms.ComboBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgv_Cierres = new System.Windows.Forms.DataGridView();
            this.tbPorcentaje = new System.Windows.Forms.TrackBar();
            this.lblMostrarporcentaje = new System.Windows.Forms.Label();
            this.tbAsistencia = new System.Windows.Forms.TrackBar();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_editarparámetros = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cierres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(29, 122);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 19);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID Cierre";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(29, 160);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(95, 19);
            this.lblEmpleado.TabIndex = 10;
            this.lblEmpleado.Text = "Departamento";
            // 
            // lblCapacitación
            // 
            this.lblCapacitación.AutoSize = true;
            this.lblCapacitación.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacitación.Location = new System.Drawing.Point(29, 196);
            this.lblCapacitación.Name = "lblCapacitación";
            this.lblCapacitación.Size = new System.Drawing.Size(88, 19);
            this.lblCapacitación.TabIndex = 11;
            this.lblCapacitación.Text = "Capacitación";
            // 
            // lblCierre
            // 
            this.lblCierre.AutoSize = true;
            this.lblCierre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCierre.Location = new System.Drawing.Point(416, 159);
            this.lblCierre.Name = "lblCierre";
            this.lblCierre.Size = new System.Drawing.Size(70, 19);
            this.lblCierre.TabIndex = 12;
            this.lblCierre.Text = "Asistencia";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(417, 112);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(75, 19);
            this.lblPorcentaje.TabIndex = 13;
            this.lblPorcentaje.Text = "Puntuación";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(417, 204);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 19);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(130, 121);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(155, 20);
            this.txtID.TabIndex = 15;
            // 
            // cbCapacitación
            // 
            this.cbCapacitación.Enabled = false;
            this.cbCapacitación.FormattingEnabled = true;
            this.cbCapacitación.Location = new System.Drawing.Point(130, 194);
            this.cbCapacitación.Name = "cbCapacitación";
            this.cbCapacitación.Size = new System.Drawing.Size(155, 21);
            this.cbCapacitación.TabIndex = 17;
            this.cbCapacitación.Text = "Seleccione un Departamento";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(130, 157);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(155, 21);
            this.cbDepartamento.TabIndex = 18;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(503, 204);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(94, 20);
            this.dtpFecha.TabIndex = 19;
            this.dtpFecha.Value = new System.DateTime(2025, 4, 29, 0, 0, 0, 0);
            // 
            // dgv_Cierres
            // 
            this.dgv_Cierres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cierres.Location = new System.Drawing.Point(12, 247);
            this.dgv_Cierres.Name = "dgv_Cierres";
            this.dgv_Cierres.Size = new System.Drawing.Size(792, 286);
            this.dgv_Cierres.TabIndex = 21;
            // 
            // tbPorcentaje
            // 
            this.tbPorcentaje.Location = new System.Drawing.Point(497, 110);
            this.tbPorcentaje.Maximum = 100;
            this.tbPorcentaje.Name = "tbPorcentaje";
            this.tbPorcentaje.Size = new System.Drawing.Size(162, 45);
            this.tbPorcentaje.TabIndex = 22;
            this.tbPorcentaje.Scroll += new System.EventHandler(this.tbPorcentaje_Scroll);
            // 
            // lblMostrarporcentaje
            // 
            this.lblMostrarporcentaje.AutoSize = true;
            this.lblMostrarporcentaje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarporcentaje.Location = new System.Drawing.Point(665, 109);
            this.lblMostrarporcentaje.Name = "lblMostrarporcentaje";
            this.lblMostrarporcentaje.Size = new System.Drawing.Size(22, 19);
            this.lblMostrarporcentaje.TabIndex = 23;
            this.lblMostrarporcentaje.Text = "%";
            // 
            // tbAsistencia
            // 
            this.tbAsistencia.Location = new System.Drawing.Point(497, 153);
            this.tbAsistencia.Maximum = 100;
            this.tbAsistencia.Name = "tbAsistencia";
            this.tbAsistencia.Size = new System.Drawing.Size(162, 45);
            this.tbAsistencia.TabIndex = 24;
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(665, 153);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(22, 19);
            this.lblAsistencia.TabIndex = 25;
            this.lblAsistencia.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(701, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Editar Parámetros";
            // 
            // Btn_editarparámetros
            // 
            this.Btn_editarparámetros.Image = global::Capa_Vista_Capacitacion.Properties.Resources.convenio__1___1_;
            this.Btn_editarparámetros.Location = new System.Drawing.Point(726, 107);
            this.Btn_editarparámetros.Name = "Btn_editarparámetros";
            this.Btn_editarparámetros.Size = new System.Drawing.Size(66, 69);
            this.Btn_editarparámetros.TabIndex = 26;
            this.Btn_editarparámetros.UseVisualStyleBackColor = true;
            this.Btn_editarparámetros.Click += new System.EventHandler(this.Btn_editarparámetros_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = global::Capa_Vista_Capacitacion.Properties.Resources.preguntas__1___1_;
            this.Btn_ayuda.Location = new System.Drawing.Point(349, 12);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(69, 69);
            this.Btn_ayuda.TabIndex = 7;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.Image = global::Capa_Vista_Capacitacion.Properties.Resources.reporte__2_;
            this.Btn_reporte.Location = new System.Drawing.Point(420, 12);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(69, 69);
            this.Btn_reporte.TabIndex = 6;
            this.Btn_reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_buscar.Image = global::Capa_Vista_Capacitacion.Properties.Resources.buscar__1___1_1;
            this.Btn_buscar.Location = new System.Drawing.Point(274, 12);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(69, 69);
            this.Btn_buscar.TabIndex = 5;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Enabled = false;
            this.Btn_cancelar.Image = global::Capa_Vista_Capacitacion.Properties.Resources.cancelar__1___1_;
            this.Btn_cancelar.Location = new System.Drawing.Point(202, 12);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(66, 69);
            this.Btn_cancelar.TabIndex = 3;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Image = global::Capa_Vista_Capacitacion.Properties.Resources.cerrar_sesion__1___1_;
            this.Btn_salir.Location = new System.Drawing.Point(726, 12);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(66, 69);
            this.Btn_salir.TabIndex = 2;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Enabled = false;
            this.Btn_guardar.Image = global::Capa_Vista_Capacitacion.Properties.Resources.ahorrar__1___1_;
            this.Btn_guardar.Location = new System.Drawing.Point(130, 12);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(66, 69);
            this.Btn_guardar.TabIndex = 1;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_nuevo.Image = global::Capa_Vista_Capacitacion.Properties.Resources.agregar_archivo__1___1___1_;
            this.Btn_nuevo.Location = new System.Drawing.Point(58, 12);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(66, 69);
            this.Btn_nuevo.TabIndex = 0;
            this.Btn_nuevo.UseVisualStyleBackColor = true;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // cierre_capacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(816, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_editarparámetros);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.tbAsistencia);
            this.Controls.Add(this.lblMostrarporcentaje);
            this.Controls.Add(this.tbPorcentaje);
            this.Controls.Add(this.dgv_Cierres);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.cbCapacitación);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblCierre);
            this.Controls.Add(this.lblCapacitación);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_nuevo);
            this.Name = "cierre_capacitacion";
            this.Text = "14003 - cierre_capacitación";
            this.Load += new System.EventHandler(this.cierre_capacitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cierres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblCapacitación;
        private System.Windows.Forms.Label lblCierre;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbCapacitación;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgv_Cierres;
        private System.Windows.Forms.TrackBar tbPorcentaje;
        private System.Windows.Forms.Label lblMostrarporcentaje;
        private System.Windows.Forms.TrackBar tbAsistencia;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.Button Btn_editarparámetros;
        private System.Windows.Forms.Label label1;
    }
}