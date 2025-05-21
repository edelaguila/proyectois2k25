namespace Capa_Vista_Carrera
{
    partial class frm_Carrera
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
            this.Lbl_Emp = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.dgv_nominas = new System.Windows.Forms.DataGridView();
            this.dgv_Reclutamiento = new System.Windows.Forms.DataGridView();
            this.Lbl_Nominas = new System.Windows.Forms.Label();
            this.dgv_Capacitaciones = new System.Windows.Forms.DataGridView();
            this.Lbl_Reclutamiento = new System.Windows.Forms.Label();
            this.dgv_desempenio = new System.Windows.Forms.DataGridView();
            this.dgv_disciplina = new System.Windows.Forms.DataGridView();
            this.Lbl_Capacitaciones = new System.Windows.Forms.Label();
            this.Lbl_Disciplina = new System.Windows.Forms.Label();
            this.Lbl_Desempenio = new System.Windows.Forms.Label();
            this.cmb_empleado = new System.Windows.Forms.ComboBox();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nominas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reclutamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Capacitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_desempenio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Emp
            // 
            this.Lbl_Emp.AutoSize = true;
            this.Lbl_Emp.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Lbl_Emp.Location = new System.Drawing.Point(40, 61);
            this.Lbl_Emp.Name = "Lbl_Emp";
            this.Lbl_Emp.Size = new System.Drawing.Size(90, 22);
            this.Lbl_Emp.TabIndex = 20;
            this.Lbl_Emp.Text = "Empleado";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackgroundImage = global::Capa_Vista_Carrera.Properties.Resources.buscar__1___1___1_1;
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Buscar.Location = new System.Drawing.Point(390, 42);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(67, 62);
            this.Btn_Buscar.TabIndex = 22;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // dgv_nominas
            // 
            this.dgv_nominas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nominas.Location = new System.Drawing.Point(58, 212);
            this.dgv_nominas.Name = "dgv_nominas";
            this.dgv_nominas.RowHeadersWidth = 51;
            this.dgv_nominas.RowTemplate.Height = 24;
            this.dgv_nominas.Size = new System.Drawing.Size(509, 233);
            this.dgv_nominas.TabIndex = 23;
            // 
            // dgv_Reclutamiento
            // 
            this.dgv_Reclutamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reclutamiento.Location = new System.Drawing.Point(627, 212);
            this.dgv_Reclutamiento.Name = "dgv_Reclutamiento";
            this.dgv_Reclutamiento.RowHeadersWidth = 51;
            this.dgv_Reclutamiento.RowTemplate.Height = 24;
            this.dgv_Reclutamiento.Size = new System.Drawing.Size(509, 233);
            this.dgv_Reclutamiento.TabIndex = 24;
            // 
            // Lbl_Nominas
            // 
            this.Lbl_Nominas.AutoSize = true;
            this.Lbl_Nominas.Font = new System.Drawing.Font("Haettenschweiler", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nominas.Location = new System.Drawing.Point(234, 141);
            this.Lbl_Nominas.Name = "Lbl_Nominas";
            this.Lbl_Nominas.Size = new System.Drawing.Size(99, 34);
            this.Lbl_Nominas.TabIndex = 28;
            this.Lbl_Nominas.Text = "Nóminas";
            // 
            // dgv_Capacitaciones
            // 
            this.dgv_Capacitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Capacitaciones.Location = new System.Drawing.Point(49, 512);
            this.dgv_Capacitaciones.Name = "dgv_Capacitaciones";
            this.dgv_Capacitaciones.RowHeadersWidth = 51;
            this.dgv_Capacitaciones.RowTemplate.Height = 24;
            this.dgv_Capacitaciones.Size = new System.Drawing.Size(509, 233);
            this.dgv_Capacitaciones.TabIndex = 26;
            // 
            // Lbl_Reclutamiento
            // 
            this.Lbl_Reclutamiento.AutoSize = true;
            this.Lbl_Reclutamiento.Font = new System.Drawing.Font("Haettenschweiler", 19.8F);
            this.Lbl_Reclutamiento.Location = new System.Drawing.Point(733, 141);
            this.Lbl_Reclutamiento.Name = "Lbl_Reclutamiento";
            this.Lbl_Reclutamiento.Size = new System.Drawing.Size(276, 34);
            this.Lbl_Reclutamiento.TabIndex = 29;
            this.Lbl_Reclutamiento.Text = "Reclutamiento y selección";
            // 
            // dgv_desempenio
            // 
            this.dgv_desempenio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_desempenio.Location = new System.Drawing.Point(632, 512);
            this.dgv_desempenio.Name = "dgv_desempenio";
            this.dgv_desempenio.RowHeadersWidth = 51;
            this.dgv_desempenio.RowTemplate.Height = 24;
            this.dgv_desempenio.Size = new System.Drawing.Size(509, 233);
            this.dgv_desempenio.TabIndex = 27;
            // 
            // dgv_disciplina
            // 
            this.dgv_disciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_disciplina.Location = new System.Drawing.Point(49, 810);
            this.dgv_disciplina.Name = "dgv_disciplina";
            this.dgv_disciplina.RowHeadersWidth = 51;
            this.dgv_disciplina.RowTemplate.Height = 24;
            this.dgv_disciplina.Size = new System.Drawing.Size(509, 233);
            this.dgv_disciplina.TabIndex = 32;
            // 
            // Lbl_Capacitaciones
            // 
            this.Lbl_Capacitaciones.AutoSize = true;
            this.Lbl_Capacitaciones.Font = new System.Drawing.Font("Haettenschweiler", 19.8F);
            this.Lbl_Capacitaciones.Location = new System.Drawing.Point(219, 458);
            this.Lbl_Capacitaciones.Name = "Lbl_Capacitaciones";
            this.Lbl_Capacitaciones.Size = new System.Drawing.Size(167, 34);
            this.Lbl_Capacitaciones.TabIndex = 30;
            this.Lbl_Capacitaciones.Text = "Capacitaciones";
            // 
            // Lbl_Disciplina
            // 
            this.Lbl_Disciplina.AutoSize = true;
            this.Lbl_Disciplina.Font = new System.Drawing.Font("Haettenschweiler", 19.8F);
            this.Lbl_Disciplina.Location = new System.Drawing.Point(219, 763);
            this.Lbl_Disciplina.Name = "Lbl_Disciplina";
            this.Lbl_Disciplina.Size = new System.Drawing.Size(137, 34);
            this.Lbl_Disciplina.TabIndex = 33;
            this.Lbl_Disciplina.Text = "Disciplinaria";
            // 
            // Lbl_Desempenio
            // 
            this.Lbl_Desempenio.AutoSize = true;
            this.Lbl_Desempenio.Font = new System.Drawing.Font("Haettenschweiler", 19.8F);
            this.Lbl_Desempenio.Location = new System.Drawing.Point(759, 458);
            this.Lbl_Desempenio.Name = "Lbl_Desempenio";
            this.Lbl_Desempenio.Size = new System.Drawing.Size(292, 34);
            this.Lbl_Desempenio.TabIndex = 31;
            this.Lbl_Desempenio.Text = "Evaluaciones de desempeño";
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.FormattingEnabled = true;
            this.cmb_empleado.Location = new System.Drawing.Point(152, 59);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Size = new System.Drawing.Size(220, 24);
            this.cmb_empleado.TabIndex = 34;
            this.cmb_empleado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackgroundImage = global::Capa_Vista_Carrera.Properties.Resources.preguntas__1___1_;
            this.Btn_Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ayuda.Location = new System.Drawing.Point(463, 42);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(67, 62);
            this.Btn_Ayuda.TabIndex = 35;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // frm_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1174, 1055);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.cmb_empleado);
            this.Controls.Add(this.dgv_disciplina);
            this.Controls.Add(this.Lbl_Desempenio);
            this.Controls.Add(this.Lbl_Capacitaciones);
            this.Controls.Add(this.Lbl_Disciplina);
            this.Controls.Add(this.dgv_desempenio);
            this.Controls.Add(this.dgv_Capacitaciones);
            this.Controls.Add(this.Lbl_Emp);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lbl_Nominas);
            this.Controls.Add(this.Lbl_Reclutamiento);
            this.Controls.Add(this.dgv_nominas);
            this.Controls.Add(this.dgv_Reclutamiento);
            this.Name = "frm_Carrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "12002-Carrera";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nominas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reclutamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Capacitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_desempenio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Emp;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.DataGridView dgv_nominas;
        private System.Windows.Forms.DataGridView dgv_Reclutamiento;
        private System.Windows.Forms.Label Lbl_Nominas;
        private System.Windows.Forms.DataGridView dgv_Capacitaciones;
        private System.Windows.Forms.Label Lbl_Reclutamiento;
        private System.Windows.Forms.DataGridView dgv_desempenio;
        private System.Windows.Forms.DataGridView dgv_disciplina;
        private System.Windows.Forms.Label Lbl_Capacitaciones;
        private System.Windows.Forms.Label Lbl_Disciplina;
        private System.Windows.Forms.Label Lbl_Desempenio;
        private System.Windows.Forms.ComboBox cmb_empleado;
        private System.Windows.Forms.Button Btn_Ayuda;
    }
}