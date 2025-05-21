
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editarparámetros = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cierres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAsistencia)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(101, 75);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(92, 51);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID Cierre";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(101, 126);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(92, 75);
            this.lblEmpleado.TabIndex = 10;
            this.lblEmpleado.Text = "Departamento";
            // 
            // lblCapacitación
            // 
            this.lblCapacitación.AutoSize = true;
            this.lblCapacitación.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCapacitación.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacitación.Location = new System.Drawing.Point(101, 201);
            this.lblCapacitación.Name = "lblCapacitación";
            this.lblCapacitación.Size = new System.Drawing.Size(92, 38);
            this.lblCapacitación.TabIndex = 11;
            this.lblCapacitación.Text = "Capacitación";
            // 
            // lblCierre
            // 
            this.lblCierre.AutoSize = true;
            this.lblCierre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCierre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCierre.Location = new System.Drawing.Point(395, 126);
            this.lblCierre.Name = "lblCierre";
            this.lblCierre.Size = new System.Drawing.Size(92, 75);
            this.lblCierre.TabIndex = 12;
            this.lblCierre.Text = "Asistencia";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPorcentaje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(395, 75);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(92, 51);
            this.lblPorcentaje.TabIndex = 13;
            this.lblPorcentaje.Text = "Puntuación";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(395, 201);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(92, 38);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha";
            // 
            // txtID
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtID, 2);
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(199, 78);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(190, 20);
            this.txtID.TabIndex = 15;
            // 
            // cbCapacitación
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbCapacitación, 2);
            this.cbCapacitación.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCapacitación.Enabled = false;
            this.cbCapacitación.FormattingEnabled = true;
            this.cbCapacitación.Location = new System.Drawing.Point(199, 204);
            this.cbCapacitación.Name = "cbCapacitación";
            this.cbCapacitación.Size = new System.Drawing.Size(190, 21);
            this.cbCapacitación.TabIndex = 17;
            this.cbCapacitación.Text = "Seleccione un Departamento";
            this.cbCapacitación.SelectedIndexChanged += new System.EventHandler(this.cbCapacitación_SelectedIndexChanged);
            // 
            // cbDepartamento
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbDepartamento, 2);
            this.cbDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(199, 129);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(190, 21);
            this.cbDepartamento.TabIndex = 18;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(493, 204);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(92, 20);
            this.dtpFecha.TabIndex = 19;
            this.dtpFecha.Value = new System.DateTime(2025, 4, 29, 0, 0, 0, 0);
            // 
            // dgv_Cierres
            // 
            this.dgv_Cierres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_Cierres, 10);
            this.dgv_Cierres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Cierres.Location = new System.Drawing.Point(3, 242);
            this.dgv_Cierres.Name = "dgv_Cierres";
            this.tableLayoutPanel1.SetRowSpan(this.dgv_Cierres, 2);
            this.dgv_Cierres.Size = new System.Drawing.Size(977, 407);
            this.dgv_Cierres.TabIndex = 21;
            // 
            // tbPorcentaje
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbPorcentaje, 2);
            this.tbPorcentaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPorcentaje.Location = new System.Drawing.Point(493, 78);
            this.tbPorcentaje.Maximum = 100;
            this.tbPorcentaje.Name = "tbPorcentaje";
            this.tbPorcentaje.Size = new System.Drawing.Size(190, 45);
            this.tbPorcentaje.TabIndex = 22;
            this.tbPorcentaje.Scroll += new System.EventHandler(this.tbPorcentaje_Scroll);
            // 
            // lblMostrarporcentaje
            // 
            this.lblMostrarporcentaje.AutoSize = true;
            this.lblMostrarporcentaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMostrarporcentaje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarporcentaje.Location = new System.Drawing.Point(689, 75);
            this.lblMostrarporcentaje.Name = "lblMostrarporcentaje";
            this.lblMostrarporcentaje.Size = new System.Drawing.Size(92, 51);
            this.lblMostrarporcentaje.TabIndex = 23;
            this.lblMostrarporcentaje.Text = "%";
            // 
            // tbAsistencia
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbAsistencia, 2);
            this.tbAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAsistencia.Location = new System.Drawing.Point(493, 129);
            this.tbAsistencia.Maximum = 100;
            this.tbAsistencia.Name = "tbAsistencia";
            this.tbAsistencia.Size = new System.Drawing.Size(190, 69);
            this.tbAsistencia.TabIndex = 24;
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAsistencia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(689, 126);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(92, 75);
            this.lblAsistencia.TabIndex = 25;
            this.lblAsistencia.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(787, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 38);
            this.label1.TabIndex = 27;
            this.label1.Text = "Editar Parámetros";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_nuevo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Cierres, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn_guardar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_editarparámetros, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_cancelar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMostrarporcentaje, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFecha, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpFecha, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAsistencia, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_ayuda, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCierre, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbAsistencia, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_reporte, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_salir, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPorcentaje, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEmpleado, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbCapacitación, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPorcentaje, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbDepartamento, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCapacitación, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(983, 652);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_nuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_nuevo.Image = global::Capa_Vista_Capacitacion.Properties.Resources.agregar_archivo__1___1___1_;
            this.Btn_nuevo.Location = new System.Drawing.Point(101, 3);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(92, 69);
            this.Btn_nuevo.TabIndex = 0;
            this.Btn_nuevo.UseVisualStyleBackColor = true;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_guardar.Enabled = false;
            this.Btn_guardar.Image = global::Capa_Vista_Capacitacion.Properties.Resources.ahorrar__1___1_;
            this.Btn_guardar.Location = new System.Drawing.Point(199, 3);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(92, 69);
            this.Btn_guardar.TabIndex = 1;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editarparámetros
            // 
            this.Btn_editarparámetros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_editarparámetros.Image = global::Capa_Vista_Capacitacion.Properties.Resources.convenio__1___1_;
            this.Btn_editarparámetros.Location = new System.Drawing.Point(787, 129);
            this.Btn_editarparámetros.Name = "Btn_editarparámetros";
            this.Btn_editarparámetros.Size = new System.Drawing.Size(92, 69);
            this.Btn_editarparámetros.TabIndex = 26;
            this.Btn_editarparámetros.UseVisualStyleBackColor = true;
            this.Btn_editarparámetros.Click += new System.EventHandler(this.Btn_editarparámetros_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_cancelar.Enabled = false;
            this.Btn_cancelar.Image = global::Capa_Vista_Capacitacion.Properties.Resources.cancelar__1___1_;
            this.Btn_cancelar.Location = new System.Drawing.Point(297, 3);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(92, 69);
            this.Btn_cancelar.TabIndex = 3;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_ayuda.Image = global::Capa_Vista_Capacitacion.Properties.Resources.preguntas__1___1_;
            this.Btn_ayuda.Location = new System.Drawing.Point(395, 3);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(92, 69);
            this.Btn_ayuda.TabIndex = 7;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_reporte.Image = global::Capa_Vista_Capacitacion.Properties.Resources.reporte__2_;
            this.Btn_reporte.Location = new System.Drawing.Point(493, 3);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(92, 69);
            this.Btn_reporte.TabIndex = 6;
            this.Btn_reporte.UseVisualStyleBackColor = true;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_salir.Image = global::Capa_Vista_Capacitacion.Properties.Resources.cerrar_sesion__1___1_;
            this.Btn_salir.Location = new System.Drawing.Point(787, 3);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(92, 69);
            this.Btn_salir.TabIndex = 2;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // cierre_capacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(983, 652);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "cierre_capacitacion";
            this.Text = "14003 - cierre_capacitación";
            this.Load += new System.EventHandler(this.cierre_capacitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cierres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAsistencia)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_cancelar;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}