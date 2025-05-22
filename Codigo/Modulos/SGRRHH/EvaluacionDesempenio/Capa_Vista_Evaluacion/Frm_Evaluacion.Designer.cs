
namespace Capa_Vista_Evaluacion
{
    partial class Frm_Evaluacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cmb_Evaluador = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Tipo_Ev = new System.Windows.Forms.ComboBox();
            this.Cmb_Empleado = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_ObservacionesGen = new System.Windows.Forms.TextBox();
            this.Txt_calificacion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dgv_competencias = new System.Windows.Forms.DataGridView();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_competencias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cmb_Evaluador);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cmb_Tipo_Ev);
            this.groupBox1.Controls.Add(this.Cmb_Empleado);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(524, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Empleado y Evaluador";
            // 
            // Cmb_Evaluador
            // 
            this.Cmb_Evaluador.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Evaluador.FormattingEnabled = true;
            this.Cmb_Evaluador.Location = new System.Drawing.Point(208, 94);
            this.Cmb_Evaluador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cmb_Evaluador.Name = "Cmb_Evaluador";
            this.Cmb_Evaluador.Size = new System.Drawing.Size(262, 27);
            this.Cmb_Evaluador.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Evaluador:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 139);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 26);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2025, 4, 29, 9, 12, 51, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Evaluación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empleado:";
            // 
            // Cmb_Tipo_Ev
            // 
            this.Cmb_Tipo_Ev.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Tipo_Ev.FormattingEnabled = true;
            this.Cmb_Tipo_Ev.Location = new System.Drawing.Point(208, 175);
            this.Cmb_Tipo_Ev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cmb_Tipo_Ev.Name = "Cmb_Tipo_Ev";
            this.Cmb_Tipo_Ev.Size = new System.Drawing.Size(262, 27);
            this.Cmb_Tipo_Ev.TabIndex = 1;
            // 
            // Cmb_Empleado
            // 
            this.Cmb_Empleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Empleado.FormattingEnabled = true;
            this.Cmb_Empleado.Location = new System.Drawing.Point(208, 55);
            this.Cmb_Empleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cmb_Empleado.Name = "Cmb_Empleado";
            this.Cmb_Empleado.Size = new System.Drawing.Size(262, 27);
            this.Cmb_Empleado.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Txt_ObservacionesGen);
            this.groupBox3.Controls.Add(this.Txt_calificacion);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 416);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(524, 141);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Evaluación General";
            // 
            // Txt_ObservacionesGen
            // 
            this.Txt_ObservacionesGen.Location = new System.Drawing.Point(198, 58);
            this.Txt_ObservacionesGen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_ObservacionesGen.Name = "Txt_ObservacionesGen";
            this.Txt_ObservacionesGen.Size = new System.Drawing.Size(272, 26);
            this.Txt_ObservacionesGen.TabIndex = 41;
            // 
            // Txt_calificacion
            // 
            this.Txt_calificacion.Location = new System.Drawing.Point(198, 96);
            this.Txt_calificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_calificacion.Name = "Txt_calificacion";
            this.Txt_calificacion.Size = new System.Drawing.Size(272, 26);
            this.Txt_calificacion.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 96);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 19);
            this.label17.TabIndex = 8;
            this.label17.Text = "Calificación:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 94);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 19);
            this.label19.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 57);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 19);
            this.label21.TabIndex = 2;
            this.label21.Text = "Observaciones:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dgv_competencias);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(571, 138);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(627, 419);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Evaluación de empleado";
            // 
            // Dgv_competencias
            // 
            this.Dgv_competencias.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_competencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_competencias.Location = new System.Drawing.Point(14, 37);
            this.Dgv_competencias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_competencias.Name = "Dgv_competencias";
            this.Dgv_competencias.RowHeadersWidth = 51;
            this.Dgv_competencias.RowTemplate.Height = 24;
            this.Dgv_competencias.Size = new System.Drawing.Size(598, 370);
            this.Dgv_competencias.TabIndex = 6;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.BackgroundImage = global::Capa_Vista_Evaluacion.Properties.Resources.cancelar__1_;
            this.Btn_limpiar.Location = new System.Drawing.Point(121, 49);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(65, 65);
            this.Btn_limpiar.TabIndex = 29;
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackgroundImage = global::Capa_Vista_Evaluacion.Properties.Resources.reporte__1_;
            this.Btn_Reporte.Location = new System.Drawing.Point(190, 49);
            this.Btn_Reporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(65, 65);
            this.Btn_Reporte.TabIndex = 28;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackgroundImage = global::Capa_Vista_Evaluacion.Properties.Resources.cerrar_sesion;
            this.Btn_Salir.Location = new System.Drawing.Point(327, 49);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(68, 65);
            this.Btn_Salir.TabIndex = 19;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackgroundImage = global::Capa_Vista_Evaluacion.Properties.Resources.ahorrar;
            this.Btn_guardar.Location = new System.Drawing.Point(57, 49);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(60, 65);
            this.Btn_guardar.TabIndex = 18;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackgroundImage = global::Capa_Vista_Evaluacion.Properties.Resources.preguntas;
            this.Btn_ayuda.Location = new System.Drawing.Point(259, 49);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(64, 65);
            this.Btn_ayuda.TabIndex = 17;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Frm_Evaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1223, 631);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Evaluacion";
            this.Text = "17003-Evaluación";
            this.Load += new System.EventHandler(this.Frm_Evaluacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_competencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cmb_Evaluador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Tipo_Ev;
        private System.Windows.Forms.ComboBox Cmb_Empleado;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.TextBox Txt_ObservacionesGen;
        private System.Windows.Forms.TextBox Txt_calificacion;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.DataGridView Dgv_competencias;
    }
}