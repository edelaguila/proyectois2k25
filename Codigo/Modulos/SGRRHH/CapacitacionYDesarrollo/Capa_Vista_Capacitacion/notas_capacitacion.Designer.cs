
namespace Capa_Vista_Capacitacion
{
    partial class notas_capacitación
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
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.cbCapacitacion = new System.Windows.Forms.ComboBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblCapacitación = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.lblMostrarporcentaje = new System.Windows.Forms.Label();
            this.tbPorcentaje = new System.Windows.Forms.TrackBar();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbPorcentaje)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEmpleado
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbEmpleado, 2);
            this.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleado.Enabled = false;
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(224, 250);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(146, 21);
            this.cbEmpleado.TabIndex = 9;
            // 
            // cbCapacitacion
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbCapacitacion, 2);
            this.cbCapacitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCapacitacion.Enabled = false;
            this.cbCapacitacion.FormattingEnabled = true;
            this.cbCapacitacion.Location = new System.Drawing.Point(224, 156);
            this.cbCapacitacion.Name = "cbCapacitacion";
            this.cbCapacitacion.Size = new System.Drawing.Size(146, 21);
            this.cbCapacitacion.TabIndex = 10;
            this.cbCapacitacion.SelectedIndexChanged += new System.EventHandler(this.cbCapacitacion_SelectedIndexChanged);
            // 
            // txtNota
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtNota, 2);
            this.txtNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNota.Enabled = false;
            this.txtNota.Location = new System.Drawing.Point(224, 109);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(168, 20);
            this.txtNota.TabIndex = 8;
            // 
            // lblCapacitación
            // 
            this.lblCapacitación.AutoSize = true;
            this.lblCapacitación.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacitación.Location = new System.Drawing.Point(90, 153);
            this.lblCapacitación.Name = "lblCapacitación";
            this.lblCapacitación.Size = new System.Drawing.Size(88, 19);
            this.lblCapacitación.TabIndex = 21;
            this.lblCapacitación.Text = "Capacitación";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(90, 247);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(70, 19);
            this.lblEmpleado.TabIndex = 20;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNota.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(90, 106);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(128, 47);
            this.lblNota.TabIndex = 19;
            this.lblNota.Text = "ID Nota";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNivel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(485, 106);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(81, 47);
            this.lblNivel.TabIndex = 25;
            this.lblNivel.Text = "Nivel Inicial";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPuntaje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.Location = new System.Drawing.Point(485, 153);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(81, 47);
            this.lblPuntaje.TabIndex = 26;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // cbNivel
            // 
            this.cbNivel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.Enabled = false;
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Location = new System.Drawing.Point(572, 109);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(81, 21);
            this.cbNivel.TabIndex = 11;
            // 
            // lblMostrarporcentaje
            // 
            this.lblMostrarporcentaje.AutoSize = true;
            this.lblMostrarporcentaje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarporcentaje.Location = new System.Drawing.Point(746, 153);
            this.lblMostrarporcentaje.Name = "lblMostrarporcentaje";
            this.lblMostrarporcentaje.Size = new System.Drawing.Size(22, 19);
            this.lblMostrarporcentaje.TabIndex = 30;
            this.lblMostrarporcentaje.Text = "%";
            // 
            // tbPorcentaje
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tbPorcentaje, 2);
            this.tbPorcentaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPorcentaje.Enabled = false;
            this.tbPorcentaje.Location = new System.Drawing.Point(572, 156);
            this.tbPorcentaje.Maximum = 100;
            this.tbPorcentaje.Name = "tbPorcentaje";
            this.tbPorcentaje.Size = new System.Drawing.Size(168, 45);
            this.tbPorcentaje.TabIndex = 12;
            this.tbPorcentaje.Scroll += new System.EventHandler(this.tbPorcentaje_Scroll);
            this.tbPorcentaje.ValueChanged += new System.EventHandler(this.tbPorcentaje_ValueChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(572, 203);
            this.dtpFecha.MaxDate = new System.DateTime(2025, 5, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(81, 20);
            this.dtpFecha.TabIndex = 13;
            this.dtpFecha.Value = new System.DateTime(2025, 4, 29, 0, 0, 0, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(485, 200);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(81, 47);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Fecha";
            // 
            // txtBuscar
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtBuscar, 7);
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.Location = new System.Drawing.Point(90, 78);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(650, 25);
            this.txtBuscar.TabIndex = 16;
            this.txtBuscar.Visible = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(921, 0);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.487854F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.6113F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.487854F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.487854F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.487854F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.487854F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.487854F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.487854F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.487854F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.485881F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_salir, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpFecha, 6, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblFecha, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbPorcentaje, 6, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblPuntaje, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.Btn_ayuda, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_nuevo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbNivel, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.Btn_eliminar, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblNivel, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.Btn_editar, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_buscar, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_guardar, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_cancelar, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNota, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblNota, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblMostrarporcentaje, 8, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtBuscar, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgvNotas, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblCapacitación, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbCapacitacion, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtDepartamento, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbEmpleado, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblEmpleado, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.Btn_reporte, 9, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(921, 535);
            this.tableLayoutPanel2.TabIndex = 33;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToOrderColumns = true;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dgvNotas, 10);
            this.dgvNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotas.Location = new System.Drawing.Point(3, 321);
            this.dgvNotas.Name = "dgvNotas";
            this.tableLayoutPanel2.SetRowSpan(this.dgvNotas, 2);
            this.dgvNotas.Size = new System.Drawing.Size(825, 211);
            this.dgvNotas.TabIndex = 34;
            this.dgvNotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotas_CellClick);
            this.dgvNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotas_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(90, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Departamento";
            // 
            // txtDepartamento
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtDepartamento, 2);
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Location = new System.Drawing.Point(224, 203);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(146, 20);
            this.txtDepartamento.TabIndex = 36;
            // 
            // Btn_salir
            // 
            this.Btn_salir.AccessibleName = "Salir";
            this.Btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_salir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_salir.Image = global::Capa_Vista_Capacitacion.Properties.Resources.cerrar_sesion__1___1_;
            this.Btn_salir.Location = new System.Drawing.Point(3, 3);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(81, 69);
            this.Btn_salir.TabIndex = 15;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_ayuda.Image = global::Capa_Vista_Capacitacion.Properties.Resources.preguntas__1___1_;
            this.Btn_ayuda.Location = new System.Drawing.Point(746, 3);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(82, 69);
            this.Btn_ayuda.TabIndex = 7;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_nuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_nuevo.Image = global::Capa_Vista_Capacitacion.Properties.Resources.agregar_archivo__1___1___1_;
            this.Btn_nuevo.Location = new System.Drawing.Point(224, 3);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(81, 69);
            this.Btn_nuevo.TabIndex = 1;
            this.Btn_nuevo.UseVisualStyleBackColor = true;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_eliminar.Enabled = false;
            this.Btn_eliminar.Image = global::Capa_Vista_Capacitacion.Properties.Resources.borrar__1___1_;
            this.Btn_eliminar.Location = new System.Drawing.Point(659, 3);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(81, 69);
            this.Btn_eliminar.TabIndex = 6;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_editar.Enabled = false;
            this.Btn_editar.Image = global::Capa_Vista_Capacitacion.Properties.Resources.convenio__1___1_;
            this.Btn_editar.Location = new System.Drawing.Point(311, 3);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(81, 69);
            this.Btn_editar.TabIndex = 2;
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_buscar.Image = global::Capa_Vista_Capacitacion.Properties.Resources.buscar__1___1_1;
            this.Btn_buscar.Location = new System.Drawing.Point(572, 3);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(81, 69);
            this.Btn_buscar.TabIndex = 5;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_guardar.Enabled = false;
            this.Btn_guardar.Image = global::Capa_Vista_Capacitacion.Properties.Resources.ahorrar__1___1_;
            this.Btn_guardar.Location = new System.Drawing.Point(398, 3);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(81, 69);
            this.Btn_guardar.TabIndex = 3;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_cancelar.Enabled = false;
            this.Btn_cancelar.Image = global::Capa_Vista_Capacitacion.Properties.Resources.cancelar__1___1_;
            this.Btn_cancelar.Location = new System.Drawing.Point(485, 3);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(81, 69);
            this.Btn_cancelar.TabIndex = 4;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_reporte.Image = global::Capa_Vista_Capacitacion.Properties.Resources.reporte__2_;
            this.Btn_reporte.Location = new System.Drawing.Point(826, 1);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(92, 69);
            this.Btn_reporte.TabIndex = 34;
            this.Btn_reporte.UseVisualStyleBackColor = true;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // notas_capacitación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(921, 535);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "notas_capacitación";
            this.Text = "14004 - notas_capacitacion";
            this.Load += new System.EventHandler(this.notas_capacitación_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPorcentaje)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.ComboBox cbCapacitacion;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblCapacitación;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Label lblMostrarporcentaje;
        private System.Windows.Forms.TrackBar tbPorcentaje;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button Btn_reporte;
    }
}