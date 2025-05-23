
namespace MVC_JavierChamo
{
    partial class Mantenimiento_de_Vehiculos
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
            this.components = new System.ComponentModel.Container();
            this.Txt_componentenAfectado = new System.Windows.Forms.Label();
            this.txt_NombreSolicitante = new System.Windows.Forms.TextBox();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Txt_fecha = new System.Windows.Forms.Label();
            this.cmb_ComponenteAfectado = new System.Windows.Forms.ComboBox();
            this.cmb_TipoMantenimiento = new System.Windows.Forms.ComboBox();
            this.Txt_tipoMantenimiento = new System.Windows.Forms.Label();
            this.txtID_mantenimiento = new System.Windows.Forms.TextBox();
            this.Txt_idMantenimiento = new System.Windows.Forms.Label();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.Label();
            this.Txt_idVehiculo = new System.Windows.Forms.Label();
            this.txt_fk_id_vehiculo = new System.Windows.Forms.TextBox();
            this.Txt_tiempo = new System.Windows.Forms.Label();
            this.txt_TiempoEstimado = new System.Windows.Forms.TextBox();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.Txt_estado = new System.Windows.Forms.Label();
            this.txt_CodigoError = new System.Windows.Forms.TextBox();
            this.Txt_problema = new System.Windows.Forms.Label();
            this.txt_responsableAsignado = new System.Windows.Forms.TextBox();
            this.Txt_responsable = new System.Windows.Forms.Label();
            this.Dgv_mantenimiento = new System.Windows.Forms.DataGridView();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_pdf = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_componentenAfectado
            // 
            this.Txt_componentenAfectado.AutoSize = true;
            this.Txt_componentenAfectado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_componentenAfectado.Location = new System.Drawing.Point(408, 105);
            this.Txt_componentenAfectado.Name = "Txt_componentenAfectado";
            this.Txt_componentenAfectado.Size = new System.Drawing.Size(146, 19);
            this.Txt_componentenAfectado.TabIndex = 39;
            this.Txt_componentenAfectado.Text = "Componente Afectado";
            // 
            // txt_NombreSolicitante
            // 
            this.txt_NombreSolicitante.Location = new System.Drawing.Point(573, 67);
            this.txt_NombreSolicitante.Name = "txt_NombreSolicitante";
            this.txt_NombreSolicitante.Size = new System.Drawing.Size(219, 20);
            this.txt_NombreSolicitante.TabIndex = 38;
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.CustomFormat = "2024-10-21";
            this.Dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fecha.Location = new System.Drawing.Point(175, 146);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(226, 20);
            this.Dtp_fecha.TabIndex = 37;
            this.Dtp_fecha.Value = new System.DateTime(2024, 10, 21, 0, 0, 0, 0);
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.AutoSize = true;
            this.Txt_fecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fecha.Location = new System.Drawing.Point(113, 146);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(46, 19);
            this.Txt_fecha.TabIndex = 36;
            this.Txt_fecha.Text = "Fecha";
            // 
            // cmb_ComponenteAfectado
            // 
            this.cmb_ComponenteAfectado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ComponenteAfectado.FormattingEnabled = true;
            this.cmb_ComponenteAfectado.Items.AddRange(new object[] {
            "Motor",
            "Llantas",
            "Frenos",
            "Aceite/Agua"});
            this.cmb_ComponenteAfectado.Location = new System.Drawing.Point(573, 103);
            this.cmb_ComponenteAfectado.Name = "cmb_ComponenteAfectado";
            this.cmb_ComponenteAfectado.Size = new System.Drawing.Size(208, 21);
            this.cmb_ComponenteAfectado.TabIndex = 35;
            // 
            // cmb_TipoMantenimiento
            // 
            this.cmb_TipoMantenimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoMantenimiento.FormattingEnabled = true;
            this.cmb_TipoMantenimiento.Items.AddRange(new object[] {
            "Preventivo",
            "Correctivo"});
            this.cmb_TipoMantenimiento.Location = new System.Drawing.Point(175, 106);
            this.cmb_TipoMantenimiento.Name = "cmb_TipoMantenimiento";
            this.cmb_TipoMantenimiento.Size = new System.Drawing.Size(226, 21);
            this.cmb_TipoMantenimiento.TabIndex = 34;
            // 
            // Txt_tipoMantenimiento
            // 
            this.Txt_tipoMantenimiento.AutoSize = true;
            this.Txt_tipoMantenimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_tipoMantenimiento.Location = new System.Drawing.Point(8, 106);
            this.Txt_tipoMantenimiento.Name = "Txt_tipoMantenimiento";
            this.Txt_tipoMantenimiento.Size = new System.Drawing.Size(145, 19);
            this.Txt_tipoMantenimiento.TabIndex = 33;
            this.Txt_tipoMantenimiento.Text = "Tipo de mantenimiento";
            // 
            // txtID_mantenimiento
            // 
            this.txtID_mantenimiento.BackColor = System.Drawing.SystemColors.Window;
            this.txtID_mantenimiento.Location = new System.Drawing.Point(175, 69);
            this.txtID_mantenimiento.Name = "txtID_mantenimiento";
            this.txtID_mantenimiento.Size = new System.Drawing.Size(226, 20);
            this.txtID_mantenimiento.TabIndex = 32;
            // 
            // Txt_idMantenimiento
            // 
            this.Txt_idMantenimiento.AutoSize = true;
            this.Txt_idMantenimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idMantenimiento.Location = new System.Drawing.Point(34, 70);
            this.Txt_idMantenimiento.Name = "Txt_idMantenimiento";
            this.Txt_idMantenimiento.Size = new System.Drawing.Size(119, 19);
            this.Txt_idMantenimiento.TabIndex = 31;
            this.Txt_idMantenimiento.Text = "ID_mantenimiento";
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_titulo.Location = new System.Drawing.Point(144, 24);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(497, 37);
            this.Txt_titulo.TabIndex = 30;
            this.Txt_titulo.Text = "Formulario de solicitud de mantenimiento";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.AutoSize = true;
            this.Txt_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(407, 68);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(145, 19);
            this.Txt_nombre.TabIndex = 29;
            this.Txt_nombre.Text = "Nombre de Solicitante";
            // 
            // Txt_idVehiculo
            // 
            this.Txt_idVehiculo.AutoSize = true;
            this.Txt_idVehiculo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idVehiculo.Location = new System.Drawing.Point(461, 262);
            this.Txt_idVehiculo.Name = "Txt_idVehiculo";
            this.Txt_idVehiculo.Size = new System.Drawing.Size(97, 19);
            this.Txt_idVehiculo.TabIndex = 54;
            this.Txt_idVehiculo.Text = "Id del vehiculo";
            // 
            // txt_fk_id_vehiculo
            // 
            this.txt_fk_id_vehiculo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_fk_id_vehiculo.Location = new System.Drawing.Point(573, 263);
            this.txt_fk_id_vehiculo.Name = "txt_fk_id_vehiculo";
            this.txt_fk_id_vehiculo.Size = new System.Drawing.Size(168, 20);
            this.txt_fk_id_vehiculo.TabIndex = 53;
            // 
            // Txt_tiempo
            // 
            this.Txt_tiempo.AutoSize = true;
            this.Txt_tiempo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_tiempo.Location = new System.Drawing.Point(18, 268);
            this.Txt_tiempo.Name = "Txt_tiempo";
            this.Txt_tiempo.Size = new System.Drawing.Size(112, 19);
            this.Txt_tiempo.TabIndex = 47;
            this.Txt_tiempo.Text = "Tiempo estimado";
            // 
            // txt_TiempoEstimado
            // 
            this.txt_TiempoEstimado.Location = new System.Drawing.Point(151, 267);
            this.txt_TiempoEstimado.Name = "txt_TiempoEstimado";
            this.txt_TiempoEstimado.Size = new System.Drawing.Size(250, 20);
            this.txt_TiempoEstimado.TabIndex = 46;
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Items.AddRange(new object[] {
            "Activo",
            "No Activo"});
            this.cmb_Estado.Location = new System.Drawing.Point(573, 202);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(219, 21);
            this.cmb_Estado.TabIndex = 45;
            // 
            // Txt_estado
            // 
            this.Txt_estado.AutoSize = true;
            this.Txt_estado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.Location = new System.Drawing.Point(382, 202);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(163, 19);
            this.Txt_estado.TabIndex = 44;
            this.Txt_estado.Text = "Estado del mantenimiento";
            // 
            // txt_CodigoError
            // 
            this.txt_CodigoError.Location = new System.Drawing.Point(117, 200);
            this.txt_CodigoError.Name = "txt_CodigoError";
            this.txt_CodigoError.Size = new System.Drawing.Size(258, 20);
            this.txt_CodigoError.TabIndex = 43;
            // 
            // Txt_problema
            // 
            this.Txt_problema.AutoSize = true;
            this.Txt_problema.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_problema.Location = new System.Drawing.Point(34, 201);
            this.Txt_problema.Name = "Txt_problema";
            this.Txt_problema.Size = new System.Drawing.Size(67, 19);
            this.Txt_problema.TabIndex = 42;
            this.Txt_problema.Text = "Problema";
            // 
            // txt_responsableAsignado
            // 
            this.txt_responsableAsignado.Location = new System.Drawing.Point(573, 146);
            this.txt_responsableAsignado.Name = "txt_responsableAsignado";
            this.txt_responsableAsignado.Size = new System.Drawing.Size(215, 20);
            this.txt_responsableAsignado.TabIndex = 41;
            // 
            // Txt_responsable
            // 
            this.Txt_responsable.AutoSize = true;
            this.Txt_responsable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_responsable.Location = new System.Drawing.Point(409, 146);
            this.Txt_responsable.Name = "Txt_responsable";
            this.Txt_responsable.Size = new System.Drawing.Size(143, 19);
            this.Txt_responsable.TabIndex = 40;
            this.Txt_responsable.Text = "Responsable asignado";
            // 
            // Dgv_mantenimiento
            // 
            this.Dgv_mantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_mantenimiento.Location = new System.Drawing.Point(38, 404);
            this.Dgv_mantenimiento.Name = "Dgv_mantenimiento";
            this.Dgv_mantenimiento.Size = new System.Drawing.Size(743, 231);
            this.Dgv_mantenimiento.TabIndex = 55;
            this.Dgv_mantenimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbMantenimiento_CellClick);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.Image = global::MVC_JavierChamo.Properties.Resources.reporte;
            this.Btn_reporte.Location = new System.Drawing.Point(599, 307);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(78, 91);
            this.Btn_reporte.TabIndex = 57;
            this.toolTip5.SetToolTip(this.Btn_reporte, "Generar Reportes");
            this.Btn_reporte.UseVisualStyleBackColor = true;
            this.Btn_reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.Image = global::MVC_JavierChamo.Properties.Resources.image__2_;
            this.Btn_nuevo.Location = new System.Drawing.Point(38, 307);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(91, 91);
            this.Btn_nuevo.TabIndex = 56;
            this.toolTip1.SetToolTip(this.Btn_nuevo, "Limpiar textbox");
            this.Btn_nuevo.UseVisualStyleBackColor = true;
            this.Btn_nuevo.Click += new System.EventHandler(this.btn_NuevoRegistro_Click);
            // 
            // Btn_pdf
            // 
            this.Btn_pdf.Image = global::MVC_JavierChamo.Properties.Resources.PDF;
            this.Btn_pdf.Location = new System.Drawing.Point(692, 307);
            this.Btn_pdf.Name = "Btn_pdf";
            this.Btn_pdf.Size = new System.Drawing.Size(89, 91);
            this.Btn_pdf.TabIndex = 52;
            this.toolTip7.SetToolTip(this.Btn_pdf, "Generar PDF");
            this.Btn_pdf.UseVisualStyleBackColor = true;
            this.Btn_pdf.Click += new System.EventHandler(this.btn_generarPDF_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Image = global::MVC_JavierChamo.Properties.Resources.trash;
            this.Btn_eliminar.Location = new System.Drawing.Point(386, 307);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(89, 91);
            this.Btn_eliminar.TabIndex = 51;
            this.toolTip4.SetToolTip(this.Btn_eliminar, "Eliminar Registro");
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Image = global::MVC_JavierChamo.Properties.Resources.actualizarR;
            this.Btn_actualizar.Location = new System.Drawing.Point(504, 307);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(75, 91);
            this.Btn_actualizar.TabIndex = 50;
            this.toolTip5.SetToolTip(this.Btn_actualizar, "Actualizar Registro");
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Image = global::MVC_JavierChamo.Properties.Resources.lapiz;
            this.Btn_editar.Location = new System.Drawing.Point(275, 307);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(87, 91);
            this.Btn_editar.TabIndex = 49;
            this.toolTip3.SetToolTip(this.Btn_editar, "Editar Registro");
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Image = global::MVC_JavierChamo.Properties.Resources.Guardar;
            this.Btn_guardar.Location = new System.Drawing.Point(151, 307);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(92, 91);
            this.Btn_guardar.TabIndex = 48;
            this.toolTip2.SetToolTip(this.Btn_guardar, "Guardar Registro");
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = global::MVC_JavierChamo.Properties.Resources.ayuda;
            this.Btn_ayuda.Location = new System.Drawing.Point(666, 12);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(126, 49);
            this.Btn_ayuda.TabIndex = 58;
            this.toolTip7.SetToolTip(this.Btn_ayuda, "Ayuda\r\n");
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // Mantenimiento_de_Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Dgv_mantenimiento);
            this.Controls.Add(this.Txt_idVehiculo);
            this.Controls.Add(this.txt_fk_id_vehiculo);
            this.Controls.Add(this.Btn_pdf);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Txt_tiempo);
            this.Controls.Add(this.txt_TiempoEstimado);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.Txt_estado);
            this.Controls.Add(this.txt_CodigoError);
            this.Controls.Add(this.Txt_problema);
            this.Controls.Add(this.txt_responsableAsignado);
            this.Controls.Add(this.Txt_responsable);
            this.Controls.Add(this.Txt_componentenAfectado);
            this.Controls.Add(this.txt_NombreSolicitante);
            this.Controls.Add(this.Dtp_fecha);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.cmb_ComponenteAfectado);
            this.Controls.Add(this.cmb_TipoMantenimiento);
            this.Controls.Add(this.Txt_tipoMantenimiento);
            this.Controls.Add(this.txtID_mantenimiento);
            this.Controls.Add(this.Txt_idMantenimiento);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.Txt_nombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Mantenimiento_de_Vehiculos";
            this.Text = "Mantenimiento_de_Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_componentenAfectado;
        private System.Windows.Forms.Label Txt_fecha;
        private System.Windows.Forms.Label Txt_tipoMantenimiento;
        private System.Windows.Forms.Label Txt_idMantenimiento;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.Label Txt_nombre;
        private System.Windows.Forms.Label Txt_idVehiculo;
        private System.Windows.Forms.Button Btn_pdf;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Label Txt_tiempo;
        private System.Windows.Forms.Label Txt_estado;
        private System.Windows.Forms.Label Txt_problema;
        private System.Windows.Forms.Label Txt_responsable;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_reporte;
        public System.Windows.Forms.DataGridView Dgv_mantenimiento;
        public System.Windows.Forms.TextBox txt_NombreSolicitante;
        public System.Windows.Forms.TextBox txtID_mantenimiento;
        public System.Windows.Forms.TextBox txt_fk_id_vehiculo;
        public System.Windows.Forms.TextBox txt_TiempoEstimado;
        public System.Windows.Forms.TextBox txt_CodigoError;
        public System.Windows.Forms.TextBox txt_responsableAsignado;
        public System.Windows.Forms.DateTimePicker Dtp_fecha;
        public System.Windows.Forms.ComboBox cmb_ComponenteAfectado;
        public System.Windows.Forms.ComboBox cmb_TipoMantenimiento;
        public System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip7;
    }
}