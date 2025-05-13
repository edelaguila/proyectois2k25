
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
            this.Lbl_tipoSancion = new System.Windows.Forms.Label();
            this.Lbl_idFalta = new System.Windows.Forms.Label();
            this.Txt_descripcionSancion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_fechaSancion = new System.Windows.Forms.Label();
            this.Dtp_fechaSancion = new System.Windows.Forms.DateTimePicker();
            this.Cbo_tipoSancion = new System.Windows.Forms.ComboBox();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Cbo_operador = new System.Windows.Forms.ComboBox();
            this.Lbl_operador = new System.Windows.Forms.Label();
            this.Dgv_sanciones = new System.Windows.Forms.DataGridView();
            this.Btn_MostrarEliminados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Chk_sancion
            // 
            this.Chk_sancion.AutoSize = true;
            this.Chk_sancion.ForeColor = System.Drawing.Color.Black;
            this.Chk_sancion.Location = new System.Drawing.Point(383, 131);
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
            this.Cbo_idFalta.Location = new System.Drawing.Point(215, 129);
            this.Cbo_idFalta.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_idFalta.Name = "Cbo_idFalta";
            this.Cbo_idFalta.Size = new System.Drawing.Size(148, 30);
            this.Cbo_idFalta.TabIndex = 13;
            this.Cbo_idFalta.SelectedIndexChanged += new System.EventHandler(this.Cbo_idFalta_SelectedIndexChanged);
            // 
            // Lbl_tipoSancion
            // 
            this.Lbl_tipoSancion.AutoSize = true;
            this.Lbl_tipoSancion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoSancion.ForeColor = System.Drawing.Color.Black;
            this.Lbl_tipoSancion.Location = new System.Drawing.Point(83, 188);
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
            this.Lbl_idFalta.ForeColor = System.Drawing.Color.Black;
            this.Lbl_idFalta.Location = new System.Drawing.Point(83, 135);
            this.Lbl_idFalta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_idFalta.Name = "Lbl_idFalta";
            this.Lbl_idFalta.Size = new System.Drawing.Size(120, 22);
            this.Lbl_idFalta.TabIndex = 10;
            this.Lbl_idFalta.Text = "ID de la falta:";
            this.Lbl_idFalta.Click += new System.EventHandler(this.Lbl_idFalta_Click);
            // 
            // Txt_descripcionSancion
            // 
            this.Txt_descripcionSancion.Location = new System.Drawing.Point(383, 232);
            this.Txt_descripcionSancion.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_descripcionSancion.Name = "Txt_descripcionSancion";
            this.Txt_descripcionSancion.Size = new System.Drawing.Size(425, 30);
            this.Txt_descripcionSancion.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(83, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descripción de sanción:";
            // 
            // Lbl_fechaSancion
            // 
            this.Lbl_fechaSancion.AutoSize = true;
            this.Lbl_fechaSancion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechaSancion.ForeColor = System.Drawing.Color.Black;
            this.Lbl_fechaSancion.Location = new System.Drawing.Point(83, 297);
            this.Lbl_fechaSancion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_fechaSancion.Name = "Lbl_fechaSancion";
            this.Lbl_fechaSancion.Size = new System.Drawing.Size(280, 22);
            this.Lbl_fechaSancion.TabIndex = 17;
            this.Lbl_fechaSancion.Text = "Fecha en la que se aplica sanción:";
            // 
            // Dtp_fechaSancion
            // 
            this.Dtp_fechaSancion.Location = new System.Drawing.Point(383, 289);
            this.Dtp_fechaSancion.Name = "Dtp_fechaSancion";
            this.Dtp_fechaSancion.Size = new System.Drawing.Size(338, 30);
            this.Dtp_fechaSancion.TabIndex = 18;
            // 
            // Cbo_tipoSancion
            // 
            this.Cbo_tipoSancion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_tipoSancion.FormattingEnabled = true;
            this.Cbo_tipoSancion.Location = new System.Drawing.Point(383, 188);
            this.Cbo_tipoSancion.Name = "Cbo_tipoSancion";
            this.Cbo_tipoSancion.Size = new System.Drawing.Size(425, 30);
            this.Cbo_tipoSancion.TabIndex = 28;
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_reporte.Image = global::Capa_Vista_GD.Properties.Resources.reporte;
            this.Btn_reporte.Location = new System.Drawing.Point(590, 12);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(89, 77);
            this.Btn_reporte.TabIndex = 29;
            this.Btn_reporte.UseVisualStyleBackColor = true;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ayuda.Image = global::Capa_Vista_GD.Properties.Resources.ayuda;
            this.Btn_Ayuda.Location = new System.Drawing.Point(685, 12);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(89, 77);
            this.Btn_Ayuda.TabIndex = 26;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Salir.Image = global::Capa_Vista_GD.Properties.Resources.cerrar_sesion;
            this.Btn_Salir.Location = new System.Drawing.Point(780, 12);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(89, 77);
            this.Btn_Salir.TabIndex = 25;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
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
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
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
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
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
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
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
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
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
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
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
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Cbo_operador
            // 
            this.Cbo_operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_operador.FormattingEnabled = true;
            this.Cbo_operador.Items.AddRange(new object[] {
            "Ninguno",
            "Amonestación verbal",
            "Amonestación escrita",
            "Suspension de empleo y sueldo",
            "Traslado de Area/Departamento",
            "Inhabilitacion para ascenso",
            "Despido disciplinario",
            "Multa"});
            this.Cbo_operador.Location = new System.Drawing.Point(383, 346);
            this.Cbo_operador.Name = "Cbo_operador";
            this.Cbo_operador.Size = new System.Drawing.Size(425, 30);
            this.Cbo_operador.TabIndex = 31;
            // 
            // Lbl_operador
            // 
            this.Lbl_operador.AutoSize = true;
            this.Lbl_operador.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_operador.ForeColor = System.Drawing.Color.Black;
            this.Lbl_operador.Location = new System.Drawing.Point(83, 346);
            this.Lbl_operador.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_operador.Name = "Lbl_operador";
            this.Lbl_operador.Size = new System.Drawing.Size(92, 22);
            this.Lbl_operador.TabIndex = 30;
            this.Lbl_operador.Text = "Operador:";
            // 
            // Dgv_sanciones
            // 
            this.Dgv_sanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_sanciones.Location = new System.Drawing.Point(17, 393);
            this.Dgv_sanciones.Name = "Dgv_sanciones";
            this.Dgv_sanciones.RowHeadersWidth = 51;
            this.Dgv_sanciones.RowTemplate.Height = 24;
            this.Dgv_sanciones.Size = new System.Drawing.Size(852, 150);
            this.Dgv_sanciones.TabIndex = 32;
            this.Dgv_sanciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_sanciones_CellClick);
            // 
            // Btn_MostrarEliminados
            // 
            this.Btn_MostrarEliminados.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MostrarEliminados.ForeColor = System.Drawing.Color.Black;
            this.Btn_MostrarEliminados.Location = new System.Drawing.Point(334, 549);
            this.Btn_MostrarEliminados.Name = "Btn_MostrarEliminados";
            this.Btn_MostrarEliminados.Size = new System.Drawing.Size(182, 36);
            this.Btn_MostrarEliminados.TabIndex = 33;
            this.Btn_MostrarEliminados.Text = "Mostrar Eliminados";
            this.Btn_MostrarEliminados.UseVisualStyleBackColor = true;
            this.Btn_MostrarEliminados.Click += new System.EventHandler(this.Btn_MostrarEliminados_Click);
            // 
            // frm_sanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(884, 592);
            this.Controls.Add(this.Btn_MostrarEliminados);
            this.Controls.Add(this.Dgv_sanciones);
            this.Controls.Add(this.Cbo_operador);
            this.Controls.Add(this.Lbl_operador);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Cbo_tipoSancion);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Dtp_fechaSancion);
            this.Controls.Add(this.Lbl_fechaSancion);
            this.Controls.Add(this.Txt_descripcionSancion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chk_sancion);
            this.Controls.Add(this.Cbo_idFalta);
            this.Controls.Add(this.Lbl_tipoSancion);
            this.Controls.Add(this.Lbl_idFalta);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_sanciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "15003 - Registro de Sancion";
            this.Load += new System.EventHandler(this.frm_sanciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Chk_sancion;
        private System.Windows.Forms.ComboBox Cbo_idFalta;
        private System.Windows.Forms.Label Lbl_tipoSancion;
        private System.Windows.Forms.Label Lbl_idFalta;
        private System.Windows.Forms.TextBox Txt_descripcionSancion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_fechaSancion;
        private System.Windows.Forms.DateTimePicker Dtp_fechaSancion;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.ComboBox Cbo_tipoSancion;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.ComboBox Cbo_operador;
        private System.Windows.Forms.Label Lbl_operador;
        private System.Windows.Forms.DataGridView Dgv_sanciones;
        private System.Windows.Forms.Button Btn_MostrarEliminados;
    }
}