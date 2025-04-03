namespace Capa_Vista_Carrera
{
    partial class frm_Promociones
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
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Lbl_Emp = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_PuestoActual = new System.Windows.Forms.Label();
            this.Lbl_SalarioActual = new System.Windows.Forms.Label();
            this.Lbl_PuestoNuevo = new System.Windows.Forms.Label();
            this.Lbl_SalarioNuevo = new System.Windows.Forms.Label();
            this.Lbl_Motivo = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_empleado = new System.Windows.Forms.TextBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_PuestoActual = new System.Windows.Forms.TextBox();
            this.txt_SalarioActual = new System.Windows.Forms.TextBox();
            this.txt_PuestoNuevo = new System.Windows.Forms.TextBox();
            this.txt_SalarioNuevo = new System.Windows.Forms.TextBox();
            this.txt_Motivo = new System.Windows.Forms.TextBox();
            this.dgv_promociones = new System.Windows.Forms.DataGridView();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_promociones)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Lbl_ID.Location = new System.Drawing.Point(39, 136);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(126, 22);
            this.Lbl_ID.TabIndex = 10;
            this.Lbl_ID.Text = "ID_Promocion";
            // 
            // Lbl_Emp
            // 
            this.Lbl_Emp.AutoSize = true;
            this.Lbl_Emp.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Lbl_Emp.Location = new System.Drawing.Point(39, 180);
            this.Lbl_Emp.Name = "Lbl_Emp";
            this.Lbl_Emp.Size = new System.Drawing.Size(90, 22);
            this.Lbl_Emp.TabIndex = 11;
            this.Lbl_Emp.Text = "Empleado";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Lbl_Fecha.Location = new System.Drawing.Point(39, 227);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(57, 22);
            this.Lbl_Fecha.TabIndex = 12;
            this.Lbl_Fecha.Text = "Fecha";
            // 
            // Lbl_PuestoActual
            // 
            this.Lbl_PuestoActual.AutoSize = true;
            this.Lbl_PuestoActual.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Lbl_PuestoActual.Location = new System.Drawing.Point(39, 278);
            this.Lbl_PuestoActual.Name = "Lbl_PuestoActual";
            this.Lbl_PuestoActual.Size = new System.Drawing.Size(118, 22);
            this.Lbl_PuestoActual.TabIndex = 13;
            this.Lbl_PuestoActual.Text = "Puesto Actual";
            // 
            // Lbl_SalarioActual
            // 
            this.Lbl_SalarioActual.AutoSize = true;
            this.Lbl_SalarioActual.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Lbl_SalarioActual.Location = new System.Drawing.Point(508, 135);
            this.Lbl_SalarioActual.Name = "Lbl_SalarioActual";
            this.Lbl_SalarioActual.Size = new System.Drawing.Size(124, 22);
            this.Lbl_SalarioActual.TabIndex = 14;
            this.Lbl_SalarioActual.Text = "Salario Actual";
            // 
            // Lbl_PuestoNuevo
            // 
            this.Lbl_PuestoNuevo.AutoSize = true;
            this.Lbl_PuestoNuevo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Lbl_PuestoNuevo.Location = new System.Drawing.Point(508, 181);
            this.Lbl_PuestoNuevo.Name = "Lbl_PuestoNuevo";
            this.Lbl_PuestoNuevo.Size = new System.Drawing.Size(119, 22);
            this.Lbl_PuestoNuevo.TabIndex = 15;
            this.Lbl_PuestoNuevo.Text = "Puesto Nuevo";
            // 
            // Lbl_SalarioNuevo
            // 
            this.Lbl_SalarioNuevo.AutoSize = true;
            this.Lbl_SalarioNuevo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Lbl_SalarioNuevo.Location = new System.Drawing.Point(508, 227);
            this.Lbl_SalarioNuevo.Name = "Lbl_SalarioNuevo";
            this.Lbl_SalarioNuevo.Size = new System.Drawing.Size(125, 22);
            this.Lbl_SalarioNuevo.TabIndex = 16;
            this.Lbl_SalarioNuevo.Text = "Salario Nuevo";
            // 
            // Lbl_Motivo
            // 
            this.Lbl_Motivo.AutoSize = true;
            this.Lbl_Motivo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Lbl_Motivo.Location = new System.Drawing.Point(512, 279);
            this.Lbl_Motivo.Name = "Lbl_Motivo";
            this.Lbl_Motivo.Size = new System.Drawing.Size(68, 22);
            this.Lbl_Motivo.TabIndex = 17;
            this.Lbl_Motivo.Text = "Motivo";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(184, 136);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(174, 22);
            this.txt_ID.TabIndex = 18;
            // 
            // txt_empleado
            // 
            this.txt_empleado.Location = new System.Drawing.Point(184, 181);
            this.txt_empleado.Name = "txt_empleado";
            this.txt_empleado.Size = new System.Drawing.Size(174, 22);
            this.txt_empleado.TabIndex = 19;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(184, 226);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(271, 22);
            this.dtp_fecha.TabIndex = 20;
            // 
            // txt_PuestoActual
            // 
            this.txt_PuestoActual.Location = new System.Drawing.Point(184, 279);
            this.txt_PuestoActual.Name = "txt_PuestoActual";
            this.txt_PuestoActual.Size = new System.Drawing.Size(174, 22);
            this.txt_PuestoActual.TabIndex = 21;
            // 
            // txt_SalarioActual
            // 
            this.txt_SalarioActual.Location = new System.Drawing.Point(670, 135);
            this.txt_SalarioActual.Name = "txt_SalarioActual";
            this.txt_SalarioActual.Size = new System.Drawing.Size(174, 22);
            this.txt_SalarioActual.TabIndex = 22;
            // 
            // txt_PuestoNuevo
            // 
            this.txt_PuestoNuevo.Location = new System.Drawing.Point(670, 182);
            this.txt_PuestoNuevo.Name = "txt_PuestoNuevo";
            this.txt_PuestoNuevo.Size = new System.Drawing.Size(174, 22);
            this.txt_PuestoNuevo.TabIndex = 23;
            // 
            // txt_SalarioNuevo
            // 
            this.txt_SalarioNuevo.Location = new System.Drawing.Point(670, 228);
            this.txt_SalarioNuevo.Name = "txt_SalarioNuevo";
            this.txt_SalarioNuevo.Size = new System.Drawing.Size(174, 22);
            this.txt_SalarioNuevo.TabIndex = 24;
            // 
            // txt_Motivo
            // 
            this.txt_Motivo.Location = new System.Drawing.Point(670, 280);
            this.txt_Motivo.Multiline = true;
            this.txt_Motivo.Name = "txt_Motivo";
            this.txt_Motivo.Size = new System.Drawing.Size(306, 83);
            this.txt_Motivo.TabIndex = 25;
            // 
            // dgv_promociones
            // 
            this.dgv_promociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_promociones.Location = new System.Drawing.Point(34, 392);
            this.dgv_promociones.Name = "dgv_promociones";
            this.dgv_promociones.RowHeadersWidth = 51;
            this.dgv_promociones.RowTemplate.Height = 24;
            this.dgv_promociones.Size = new System.Drawing.Size(1014, 300);
            this.dgv_promociones.TabIndex = 26;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackgroundImage = global::Capa_Vista_Carrera.Properties.Resources.reporte__2_;
            this.Btn_Reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Reporte.Location = new System.Drawing.Point(699, 12);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(89, 77);
            this.Btn_Reporte.TabIndex = 8;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackgroundImage = global::Capa_Vista_Carrera.Properties.Resources.preguntas__1___1_;
            this.Btn_Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ayuda.Location = new System.Drawing.Point(604, 12);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(89, 77);
            this.Btn_Ayuda.TabIndex = 7;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackgroundImage = global::Capa_Vista_Carrera.Properties.Resources.cerrar_sesion__1___1_;
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Salir.Location = new System.Drawing.Point(794, 12);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(89, 77);
            this.Btn_Salir.TabIndex = 6;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackgroundImage = global::Capa_Vista_Carrera.Properties.Resources.buscar__1___1___1_;
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Buscar.Location = new System.Drawing.Point(509, 12);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(89, 77);
            this.Btn_Buscar.TabIndex = 5;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackgroundImage = global::Capa_Vista_Carrera.Properties.Resources.borrar__1___1_;
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Eliminar.Location = new System.Drawing.Point(414, 12);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(89, 77);
            this.Btn_Eliminar.TabIndex = 4;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackgroundImage = global::Capa_Vista_Carrera.Properties.Resources.convenio__1___1_;
            this.Btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Editar.Location = new System.Drawing.Point(319, 12);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(89, 77);
            this.Btn_Editar.TabIndex = 3;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackgroundImage = global::Capa_Vista_Carrera.Properties.Resources.cancelar__1___1_;
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cancelar.Location = new System.Drawing.Point(222, 12);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(90, 77);
            this.Btn_Cancelar.TabIndex = 2;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackgroundImage = global::Capa_Vista_Carrera.Properties.Resources.ahorrar__1___1_;
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Guardar.Location = new System.Drawing.Point(127, 12);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(90, 77);
            this.Btn_Guardar.TabIndex = 1;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackgroundImage = global::Capa_Vista_Carrera.Properties.Resources.agregar_archivo__1___1___1_;
            this.Btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Nuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Nuevo.Location = new System.Drawing.Point(31, 12);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(90, 77);
            this.Btn_Nuevo.TabIndex = 0;
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // frm_Promociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1072, 778);
            this.Controls.Add(this.dgv_promociones);
            this.Controls.Add(this.txt_Motivo);
            this.Controls.Add(this.txt_SalarioNuevo);
            this.Controls.Add(this.txt_PuestoNuevo);
            this.Controls.Add(this.txt_SalarioActual);
            this.Controls.Add(this.txt_PuestoActual);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.txt_empleado);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.Lbl_Motivo);
            this.Controls.Add(this.Lbl_SalarioNuevo);
            this.Controls.Add(this.Lbl_PuestoNuevo);
            this.Controls.Add(this.Lbl_SalarioActual);
            this.Controls.Add(this.Lbl_PuestoActual);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Lbl_Emp);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Name = "frm_Promociones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "12001-Promociones";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_promociones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.Label Lbl_Emp;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_PuestoActual;
        private System.Windows.Forms.Label Lbl_SalarioActual;
        private System.Windows.Forms.Label Lbl_PuestoNuevo;
        private System.Windows.Forms.Label Lbl_SalarioNuevo;
        private System.Windows.Forms.Label Lbl_Motivo;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_empleado;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.TextBox txt_PuestoActual;
        private System.Windows.Forms.TextBox txt_SalarioActual;
        private System.Windows.Forms.TextBox txt_PuestoNuevo;
        private System.Windows.Forms.TextBox txt_SalarioNuevo;
        private System.Windows.Forms.TextBox txt_Motivo;
        private System.Windows.Forms.DataGridView dgv_promociones;
    }
}