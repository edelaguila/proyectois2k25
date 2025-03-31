
namespace Capa_Vista_Liquidaciones
{
    partial class Frm_calcular_liquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_calcular_liquidacion));
            this.Lbl_titulo_liquidaciones = new System.Windows.Forms.Label();
            this.Lbl_empleado_liquidacion = new System.Windows.Forms.Label();
            this.Lbl_fecha_alta_empleado = new System.Windows.Forms.Label();
            this.Lbl_fecha_baja_empleado = new System.Windows.Forms.Label();
            this.Lbl_salario = new System.Windows.Forms.Label();
            this.Gpb_pago_liquidacion = new System.Windows.Forms.GroupBox();
            this.Txt_bono14_liquidacion = new System.Windows.Forms.TextBox();
            this.Txt_aguinaldo_liquidacion = new System.Windows.Forms.TextBox();
            this.Txt_vacaciones_liquidacion = new System.Windows.Forms.TextBox();
            this.Lbl_Bono14 = new System.Windows.Forms.Label();
            this.Lbl_aguinaldo = new System.Windows.Forms.Label();
            this.Lbl_Vacaciones = new System.Windows.Forms.Label();
            this.Cbo_empleado_liquidacion = new System.Windows.Forms.ComboBox();
            this.Txt_fecha_alta = new System.Windows.Forms.TextBox();
            this.Txt_fecha_baja = new System.Windows.Forms.TextBox();
            this.Txt_salario = new System.Windows.Forms.TextBox();
            this.Lbl_dias_laborados = new System.Windows.Forms.Label();
            this.Txt_dias_laborados = new System.Windows.Forms.TextBox();
            this.Btn_enlace_contabilidad = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_ayuda_liquidaciones = new System.Windows.Forms.Button();
            this.Btn_reporte_liquidaciones = new System.Windows.Forms.Button();
            this.Btn_calculo_liquidaciones = new System.Windows.Forms.Button();
            this.Dgv_liquidaciones = new System.Windows.Forms.DataGridView();
            this.Gpb_pago_liquidacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_liquidaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_titulo_liquidaciones
            // 
            this.Lbl_titulo_liquidaciones.AutoSize = true;
            this.Lbl_titulo_liquidaciones.Font = new System.Drawing.Font("Haettenschweiler", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo_liquidaciones.Location = new System.Drawing.Point(350, 128);
            this.Lbl_titulo_liquidaciones.Name = "Lbl_titulo_liquidaciones";
            this.Lbl_titulo_liquidaciones.Size = new System.Drawing.Size(320, 44);
            this.Lbl_titulo_liquidaciones.TabIndex = 0;
            this.Lbl_titulo_liquidaciones.Text = "Cálculo de liquidaciones";
            // 
            // Lbl_empleado_liquidacion
            // 
            this.Lbl_empleado_liquidacion.AutoSize = true;
            this.Lbl_empleado_liquidacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_empleado_liquidacion.Location = new System.Drawing.Point(36, 236);
            this.Lbl_empleado_liquidacion.Name = "Lbl_empleado_liquidacion";
            this.Lbl_empleado_liquidacion.Size = new System.Drawing.Size(90, 22);
            this.Lbl_empleado_liquidacion.TabIndex = 6;
            this.Lbl_empleado_liquidacion.Text = "Empleado";
            // 
            // Lbl_fecha_alta_empleado
            // 
            this.Lbl_fecha_alta_empleado.AutoSize = true;
            this.Lbl_fecha_alta_empleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha_alta_empleado.Location = new System.Drawing.Point(36, 295);
            this.Lbl_fecha_alta_empleado.Name = "Lbl_fecha_alta_empleado";
            this.Lbl_fecha_alta_empleado.Size = new System.Drawing.Size(91, 22);
            this.Lbl_fecha_alta_empleado.TabIndex = 7;
            this.Lbl_fecha_alta_empleado.Text = "Fecha alta";
            // 
            // Lbl_fecha_baja_empleado
            // 
            this.Lbl_fecha_baja_empleado.AutoSize = true;
            this.Lbl_fecha_baja_empleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha_baja_empleado.Location = new System.Drawing.Point(36, 350);
            this.Lbl_fecha_baja_empleado.Name = "Lbl_fecha_baja_empleado";
            this.Lbl_fecha_baja_empleado.Size = new System.Drawing.Size(96, 22);
            this.Lbl_fecha_baja_empleado.TabIndex = 8;
            this.Lbl_fecha_baja_empleado.Text = "Fecha baja";
            // 
            // Lbl_salario
            // 
            this.Lbl_salario.AutoSize = true;
            this.Lbl_salario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_salario.Location = new System.Drawing.Point(36, 462);
            this.Lbl_salario.Name = "Lbl_salario";
            this.Lbl_salario.Size = new System.Drawing.Size(68, 22);
            this.Lbl_salario.TabIndex = 9;
            this.Lbl_salario.Text = "Salario";
            // 
            // Gpb_pago_liquidacion
            // 
            this.Gpb_pago_liquidacion.Controls.Add(this.Txt_bono14_liquidacion);
            this.Gpb_pago_liquidacion.Controls.Add(this.Txt_aguinaldo_liquidacion);
            this.Gpb_pago_liquidacion.Controls.Add(this.Txt_vacaciones_liquidacion);
            this.Gpb_pago_liquidacion.Controls.Add(this.Lbl_Bono14);
            this.Gpb_pago_liquidacion.Controls.Add(this.Lbl_aguinaldo);
            this.Gpb_pago_liquidacion.Controls.Add(this.Lbl_Vacaciones);
            this.Gpb_pago_liquidacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_pago_liquidacion.Location = new System.Drawing.Point(621, 228);
            this.Gpb_pago_liquidacion.Name = "Gpb_pago_liquidacion";
            this.Gpb_pago_liquidacion.Size = new System.Drawing.Size(377, 224);
            this.Gpb_pago_liquidacion.TabIndex = 10;
            this.Gpb_pago_liquidacion.TabStop = false;
            this.Gpb_pago_liquidacion.Text = "Pago Liquidación";
            // 
            // Txt_bono14_liquidacion
            // 
            this.Txt_bono14_liquidacion.Enabled = false;
            this.Txt_bono14_liquidacion.Location = new System.Drawing.Point(135, 177);
            this.Txt_bono14_liquidacion.Name = "Txt_bono14_liquidacion";
            this.Txt_bono14_liquidacion.Size = new System.Drawing.Size(204, 30);
            this.Txt_bono14_liquidacion.TabIndex = 5;
            // 
            // Txt_aguinaldo_liquidacion
            // 
            this.Txt_aguinaldo_liquidacion.Enabled = false;
            this.Txt_aguinaldo_liquidacion.Location = new System.Drawing.Point(135, 113);
            this.Txt_aguinaldo_liquidacion.Name = "Txt_aguinaldo_liquidacion";
            this.Txt_aguinaldo_liquidacion.Size = new System.Drawing.Size(204, 30);
            this.Txt_aguinaldo_liquidacion.TabIndex = 4;
            // 
            // Txt_vacaciones_liquidacion
            // 
            this.Txt_vacaciones_liquidacion.Enabled = false;
            this.Txt_vacaciones_liquidacion.Location = new System.Drawing.Point(135, 51);
            this.Txt_vacaciones_liquidacion.Name = "Txt_vacaciones_liquidacion";
            this.Txt_vacaciones_liquidacion.Size = new System.Drawing.Size(204, 30);
            this.Txt_vacaciones_liquidacion.TabIndex = 3;
            // 
            // Lbl_Bono14
            // 
            this.Lbl_Bono14.AutoSize = true;
            this.Lbl_Bono14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bono14.Location = new System.Drawing.Point(15, 185);
            this.Lbl_Bono14.Name = "Lbl_Bono14";
            this.Lbl_Bono14.Size = new System.Drawing.Size(77, 22);
            this.Lbl_Bono14.TabIndex = 2;
            this.Lbl_Bono14.Text = "Bono 14";
            // 
            // Lbl_aguinaldo
            // 
            this.Lbl_aguinaldo.AutoSize = true;
            this.Lbl_aguinaldo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_aguinaldo.Location = new System.Drawing.Point(15, 121);
            this.Lbl_aguinaldo.Name = "Lbl_aguinaldo";
            this.Lbl_aguinaldo.Size = new System.Drawing.Size(92, 22);
            this.Lbl_aguinaldo.TabIndex = 1;
            this.Lbl_aguinaldo.Text = "Aguinaldo";
            // 
            // Lbl_Vacaciones
            // 
            this.Lbl_Vacaciones.AutoSize = true;
            this.Lbl_Vacaciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Vacaciones.Location = new System.Drawing.Point(15, 59);
            this.Lbl_Vacaciones.Name = "Lbl_Vacaciones";
            this.Lbl_Vacaciones.Size = new System.Drawing.Size(99, 22);
            this.Lbl_Vacaciones.TabIndex = 0;
            this.Lbl_Vacaciones.Text = "Vacaciones";
            // 
            // Cbo_empleado_liquidacion
            // 
            this.Cbo_empleado_liquidacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_empleado_liquidacion.FormattingEnabled = true;
            this.Cbo_empleado_liquidacion.Location = new System.Drawing.Point(321, 228);
            this.Cbo_empleado_liquidacion.Name = "Cbo_empleado_liquidacion";
            this.Cbo_empleado_liquidacion.Size = new System.Drawing.Size(204, 30);
            this.Cbo_empleado_liquidacion.TabIndex = 1;
            this.Cbo_empleado_liquidacion.SelectedIndexChanged += new System.EventHandler(this.Cbo_empleado_liquidacion_SelectedIndexChanged);
            // 
            // Txt_fecha_alta
            // 
            this.Txt_fecha_alta.Enabled = false;
            this.Txt_fecha_alta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fecha_alta.Location = new System.Drawing.Point(321, 287);
            this.Txt_fecha_alta.Name = "Txt_fecha_alta";
            this.Txt_fecha_alta.Size = new System.Drawing.Size(204, 30);
            this.Txt_fecha_alta.TabIndex = 12;
            // 
            // Txt_fecha_baja
            // 
            this.Txt_fecha_baja.Enabled = false;
            this.Txt_fecha_baja.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fecha_baja.Location = new System.Drawing.Point(321, 342);
            this.Txt_fecha_baja.Name = "Txt_fecha_baja";
            this.Txt_fecha_baja.Size = new System.Drawing.Size(204, 30);
            this.Txt_fecha_baja.TabIndex = 13;
            // 
            // Txt_salario
            // 
            this.Txt_salario.Enabled = false;
            this.Txt_salario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_salario.Location = new System.Drawing.Point(321, 454);
            this.Txt_salario.Name = "Txt_salario";
            this.Txt_salario.Size = new System.Drawing.Size(204, 30);
            this.Txt_salario.TabIndex = 14;
            // 
            // Lbl_dias_laborados
            // 
            this.Lbl_dias_laborados.AutoSize = true;
            this.Lbl_dias_laborados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dias_laborados.Location = new System.Drawing.Point(36, 407);
            this.Lbl_dias_laborados.Name = "Lbl_dias_laborados";
            this.Lbl_dias_laborados.Size = new System.Drawing.Size(260, 22);
            this.Lbl_dias_laborados.TabIndex = 15;
            this.Lbl_dias_laborados.Text = "Días laborados en el año actual";
            // 
            // Txt_dias_laborados
            // 
            this.Txt_dias_laborados.Enabled = false;
            this.Txt_dias_laborados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_dias_laborados.Location = new System.Drawing.Point(321, 399);
            this.Txt_dias_laborados.Name = "Txt_dias_laborados";
            this.Txt_dias_laborados.Size = new System.Drawing.Size(204, 30);
            this.Txt_dias_laborados.TabIndex = 16;
            // 
            // Btn_enlace_contabilidad
            // 
            this.Btn_enlace_contabilidad.Image = global::Capa_Vista_Liquidaciones.Properties.Resources.icono_contabilidad_64px;
            this.Btn_enlace_contabilidad.Location = new System.Drawing.Point(925, 776);
            this.Btn_enlace_contabilidad.Name = "Btn_enlace_contabilidad";
            this.Btn_enlace_contabilidad.Size = new System.Drawing.Size(73, 73);
            this.Btn_enlace_contabilidad.TabIndex = 7;
            this.Btn_enlace_contabilidad.UseVisualStyleBackColor = true;
            this.Btn_enlace_contabilidad.Click += new System.EventHandler(this.Btn_enlace_contabilidad_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Image = global::Capa_Vista_Liquidaciones.Properties.Resources.icono_salir_64px;
            this.Btn_salir.Location = new System.Drawing.Point(925, 23);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(73, 73);
            this.Btn_salir.TabIndex = 6;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Image = global::Capa_Vista_Liquidaciones.Properties.Resources.icono_cancelar_64px;
            this.Btn_cancelar.Location = new System.Drawing.Point(836, 22);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(73, 74);
            this.Btn_cancelar.TabIndex = 5;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_ayuda_liquidaciones
            // 
            this.Btn_ayuda_liquidaciones.Image = global::Capa_Vista_Liquidaciones.Properties.Resources.icono_ayuda_64px;
            this.Btn_ayuda_liquidaciones.Location = new System.Drawing.Point(748, 22);
            this.Btn_ayuda_liquidaciones.Name = "Btn_ayuda_liquidaciones";
            this.Btn_ayuda_liquidaciones.Size = new System.Drawing.Size(73, 73);
            this.Btn_ayuda_liquidaciones.TabIndex = 4;
            this.Btn_ayuda_liquidaciones.UseVisualStyleBackColor = true;
            this.Btn_ayuda_liquidaciones.Click += new System.EventHandler(this.Btn_ayuda_liquidaciones_Click);
            // 
            // Btn_reporte_liquidaciones
            // 
            this.Btn_reporte_liquidaciones.Image = global::Capa_Vista_Liquidaciones.Properties.Resources.icono_reporte_64px;
            this.Btn_reporte_liquidaciones.Location = new System.Drawing.Point(659, 22);
            this.Btn_reporte_liquidaciones.Name = "Btn_reporte_liquidaciones";
            this.Btn_reporte_liquidaciones.Size = new System.Drawing.Size(73, 73);
            this.Btn_reporte_liquidaciones.TabIndex = 3;
            this.Btn_reporte_liquidaciones.UseVisualStyleBackColor = true;
            this.Btn_reporte_liquidaciones.Click += new System.EventHandler(this.Btn_reporte_liquidaciones_Click);
            // 
            // Btn_calculo_liquidaciones
            // 
            this.Btn_calculo_liquidaciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_calculo_liquidaciones.Image = global::Capa_Vista_Liquidaciones.Properties.Resources.icono_guardar_64px;
            this.Btn_calculo_liquidaciones.Location = new System.Drawing.Point(574, 21);
            this.Btn_calculo_liquidaciones.Name = "Btn_calculo_liquidaciones";
            this.Btn_calculo_liquidaciones.Size = new System.Drawing.Size(70, 73);
            this.Btn_calculo_liquidaciones.TabIndex = 2;
            this.Btn_calculo_liquidaciones.UseVisualStyleBackColor = true;
            this.Btn_calculo_liquidaciones.Click += new System.EventHandler(this.Btn_calculo_liquidaciones_Click);
            // 
            // Dgv_liquidaciones
            // 
            this.Dgv_liquidaciones.AllowUserToAddRows = false;
            this.Dgv_liquidaciones.AllowUserToDeleteRows = false;
            this.Dgv_liquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_liquidaciones.Location = new System.Drawing.Point(40, 536);
            this.Dgv_liquidaciones.Name = "Dgv_liquidaciones";
            this.Dgv_liquidaciones.ReadOnly = true;
            this.Dgv_liquidaciones.RowHeadersWidth = 51;
            this.Dgv_liquidaciones.RowTemplate.Height = 24;
            this.Dgv_liquidaciones.Size = new System.Drawing.Size(958, 216);
            this.Dgv_liquidaciones.TabIndex = 20;
            // 
            // Frm_calcular_liquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1034, 865);
            this.Controls.Add(this.Dgv_liquidaciones);
            this.Controls.Add(this.Btn_enlace_contabilidad);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Txt_dias_laborados);
            this.Controls.Add(this.Lbl_dias_laborados);
            this.Controls.Add(this.Txt_salario);
            this.Controls.Add(this.Txt_fecha_baja);
            this.Controls.Add(this.Txt_fecha_alta);
            this.Controls.Add(this.Cbo_empleado_liquidacion);
            this.Controls.Add(this.Gpb_pago_liquidacion);
            this.Controls.Add(this.Lbl_salario);
            this.Controls.Add(this.Lbl_fecha_baja_empleado);
            this.Controls.Add(this.Lbl_fecha_alta_empleado);
            this.Controls.Add(this.Lbl_empleado_liquidacion);
            this.Controls.Add(this.Btn_ayuda_liquidaciones);
            this.Controls.Add(this.Btn_reporte_liquidaciones);
            this.Controls.Add(this.Btn_calculo_liquidaciones);
            this.Controls.Add(this.Lbl_titulo_liquidaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_calcular_liquidacion";
            this.Text = "Cálculo liquidación";
            this.Load += new System.EventHandler(this.Frm_calcular_liquidacion_Load);
            this.Gpb_pago_liquidacion.ResumeLayout(false);
            this.Gpb_pago_liquidacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_liquidaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo_liquidaciones;
        private System.Windows.Forms.Button Btn_calculo_liquidaciones;
        private System.Windows.Forms.Button Btn_reporte_liquidaciones;
        private System.Windows.Forms.Button Btn_ayuda_liquidaciones;
        private System.Windows.Forms.Label Lbl_empleado_liquidacion;
        private System.Windows.Forms.Label Lbl_fecha_alta_empleado;
        private System.Windows.Forms.Label Lbl_fecha_baja_empleado;
        private System.Windows.Forms.Label Lbl_salario;
        private System.Windows.Forms.GroupBox Gpb_pago_liquidacion;
        private System.Windows.Forms.Label Lbl_Bono14;
        private System.Windows.Forms.Label Lbl_aguinaldo;
        private System.Windows.Forms.Label Lbl_Vacaciones;
        private System.Windows.Forms.ComboBox Cbo_empleado_liquidacion;
        private System.Windows.Forms.TextBox Txt_fecha_alta;
        private System.Windows.Forms.TextBox Txt_fecha_baja;
        private System.Windows.Forms.TextBox Txt_salario;
        private System.Windows.Forms.TextBox Txt_bono14_liquidacion;
        private System.Windows.Forms.TextBox Txt_aguinaldo_liquidacion;
        private System.Windows.Forms.TextBox Txt_vacaciones_liquidacion;
        private System.Windows.Forms.Label Lbl_dias_laborados;
        private System.Windows.Forms.TextBox Txt_dias_laborados;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_enlace_contabilidad;
        private System.Windows.Forms.DataGridView Dgv_liquidaciones;
    }
}