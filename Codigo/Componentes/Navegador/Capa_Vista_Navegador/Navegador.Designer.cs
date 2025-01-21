namespace Capa_Vista_Navegador
{
    partial class Navegador
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navegador));
            this.Dgv_Informacion = new System.Windows.Forms.DataGridView();
            this.Tlp_Panel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_FlechaFin = new System.Windows.Forms.Button();
            this.Btn_Siguiente = new System.Windows.Forms.Button();
            this.Btn_Anterior = new System.Windows.Forms.Button();
            this.Btn_FlechaInicio = new System.Windows.Forms.Button();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.Txt_Tabla = new System.Windows.Forms.Label();
            this.Bw_1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Informacion)).BeginInit();
            this.Tlp_Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Informacion
            // 
            this.Dgv_Informacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Informacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Informacion.Location = new System.Drawing.Point(28, 629);
            this.Dgv_Informacion.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Informacion.Name = "Dgv_Informacion";
            this.Dgv_Informacion.ReadOnly = true;
            this.Dgv_Informacion.RowHeadersWidth = 51;
            this.Dgv_Informacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Informacion.Size = new System.Drawing.Size(1064, 238);
            this.Dgv_Informacion.TabIndex = 6;
            this.Dgv_Informacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.Dgv_Informacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Tlp_Panel2
            // 
            this.Tlp_Panel2.ColumnCount = 14;
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.107032F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.107032F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.107032F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.107032F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.107032F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.107032F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.107032F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.107032F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.107032F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.107032F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.107032F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.107032F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.104187F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.611428F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.Tlp_Panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.Tlp_Panel2.Controls.Add(this.Btn_Imprimir, 6, 0);
            this.Tlp_Panel2.Controls.Add(this.Btn_Ayuda, 12, 0);
            this.Tlp_Panel2.Controls.Add(this.Btn_Salir, 13, 0);
            this.Tlp_Panel2.Controls.Add(this.Btn_FlechaFin, 11, 0);
            this.Tlp_Panel2.Controls.Add(this.Btn_Siguiente, 10, 0);
            this.Tlp_Panel2.Controls.Add(this.Btn_Anterior, 9, 0);
            this.Tlp_Panel2.Controls.Add(this.Btn_FlechaInicio, 8, 0);
            this.Tlp_Panel2.Controls.Add(this.Btn_Refrescar, 7, 0);
            this.Tlp_Panel2.Controls.Add(this.Btn_Consultar, 5, 0);
            this.Tlp_Panel2.Controls.Add(this.Btn_Eliminar, 4, 0);
            this.Tlp_Panel2.Controls.Add(this.Btn_Cancelar, 3, 0);
            this.Tlp_Panel2.Controls.Add(this.Btn_Guardar, 2, 0);
            this.Tlp_Panel2.Controls.Add(this.Btn_Modificar, 1, 0);
            this.Tlp_Panel2.Controls.Add(this.Btn_Ingresar, 0, 0);
            this.Tlp_Panel2.Location = new System.Drawing.Point(28, 27);
            this.Tlp_Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Tlp_Panel2.Name = "Tlp_Panel2";
            this.Tlp_Panel2.RowCount = 1;
            this.Tlp_Panel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Panel2.Size = new System.Drawing.Size(1064, 65);
            this.Tlp_Panel2.TabIndex = 8;
            this.Tlp_Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Tlp_Panel2_Paint);
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Imprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Imprimir.Enabled = false;
            this.Btn_Imprimir.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Imprimir.Image")));
            this.Btn_Imprimir.Location = new System.Drawing.Point(450, 0);
            this.Btn_Imprimir.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(75, 65);
            this.Btn_Imprimir.TabIndex = 14;
            this.Btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Imprimir.UseVisualStyleBackColor = false;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click_1);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Ayuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Ayuda.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Ayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda.ForeColor = System.Drawing.Color.Black;
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(900, 0);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(75, 65);
            this.Btn_Ayuda.TabIndex = 1;
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = false;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Salir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(975, 0);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(89, 65);
            this.Btn_Salir.TabIndex = 13;
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_FlechaFin
            // 
            this.Btn_FlechaFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_FlechaFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_FlechaFin.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_FlechaFin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_FlechaFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FlechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FlechaFin.Image = ((System.Drawing.Image)(resources.GetObject("Btn_FlechaFin.Image")));
            this.Btn_FlechaFin.Location = new System.Drawing.Point(825, 0);
            this.Btn_FlechaFin.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_FlechaFin.Name = "Btn_FlechaFin";
            this.Btn_FlechaFin.Size = new System.Drawing.Size(75, 65);
            this.Btn_FlechaFin.TabIndex = 11;
            this.Btn_FlechaFin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_FlechaFin.UseVisualStyleBackColor = false;
            this.Btn_FlechaFin.Click += new System.EventHandler(this.Btn_FlechaFin_Click);
            // 
            // Btn_Siguiente
            // 
            this.Btn_Siguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Siguiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Siguiente.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Siguiente.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Siguiente.Image")));
            this.Btn_Siguiente.Location = new System.Drawing.Point(750, 0);
            this.Btn_Siguiente.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Siguiente.Name = "Btn_Siguiente";
            this.Btn_Siguiente.Size = new System.Drawing.Size(75, 65);
            this.Btn_Siguiente.TabIndex = 10;
            this.Btn_Siguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Siguiente.UseVisualStyleBackColor = false;
            this.Btn_Siguiente.Click += new System.EventHandler(this.Btn_Siguiente_Click);
            // 
            // Btn_Anterior
            // 
            this.Btn_Anterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Anterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Anterior.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Anterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Anterior.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Anterior.Image")));
            this.Btn_Anterior.Location = new System.Drawing.Point(675, 0);
            this.Btn_Anterior.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Anterior.Name = "Btn_Anterior";
            this.Btn_Anterior.Size = new System.Drawing.Size(75, 65);
            this.Btn_Anterior.TabIndex = 9;
            this.Btn_Anterior.Text = " ";
            this.Btn_Anterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Anterior.UseVisualStyleBackColor = false;
            this.Btn_Anterior.Click += new System.EventHandler(this.Btn_Anterior_Click);
            // 
            // Btn_FlechaInicio
            // 
            this.Btn_FlechaInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_FlechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_FlechaInicio.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_FlechaInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_FlechaInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FlechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FlechaInicio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_FlechaInicio.Image")));
            this.Btn_FlechaInicio.Location = new System.Drawing.Point(600, 0);
            this.Btn_FlechaInicio.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_FlechaInicio.Name = "Btn_FlechaInicio";
            this.Btn_FlechaInicio.Size = new System.Drawing.Size(75, 65);
            this.Btn_FlechaInicio.TabIndex = 8;
            this.Btn_FlechaInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_FlechaInicio.UseVisualStyleBackColor = false;
            this.Btn_FlechaInicio.Click += new System.EventHandler(this.Btn_FlechaInicio_Click);
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Refrescar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Refrescar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Refrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Refrescar.Image")));
            this.Btn_Refrescar.Location = new System.Drawing.Point(525, 0);
            this.Btn_Refrescar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(75, 65);
            this.Btn_Refrescar.TabIndex = 7;
            this.Btn_Refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refrescar.UseVisualStyleBackColor = false;
            this.Btn_Refrescar.Click += new System.EventHandler(this.Btn_Refrescar_Click);
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Consultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Consultar.Enabled = false;
            this.Btn_Consultar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Consultar.Image")));
            this.Btn_Consultar.Location = new System.Drawing.Point(375, 0);
            this.Btn_Consultar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(75, 65);
            this.Btn_Consultar.TabIndex = 5;
            this.Btn_Consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Consultar.UseVisualStyleBackColor = false;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(300, 0);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 65);
            this.Btn_Eliminar.TabIndex = 4;
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(225, 0);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 65);
            this.Btn_Cancelar.TabIndex = 3;
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Guardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Guardar.Enabled = false;
            this.Btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(150, 0);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 65);
            this.Btn_Guardar.TabIndex = 2;
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Modificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(75, 0);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(75, 65);
            this.Btn_Modificar.TabIndex = 1;
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Ingresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Ingresar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ingresar.Image")));
            this.Btn_Ingresar.Location = new System.Drawing.Point(0, 0);
            this.Btn_Ingresar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(75, 65);
            this.Btn_Ingresar.TabIndex = 0;
            this.Btn_Ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ingresar.UseVisualStyleBackColor = false;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            this.Btn_Ingresar.Paint += new System.Windows.Forms.PaintEventHandler(this.Btn_Ingresar_Paint);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // Txt_Tabla
            // 
            this.Txt_Tabla.AutoSize = true;
            this.Txt_Tabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Tabla.Location = new System.Drawing.Point(497, 123);
            this.Txt_Tabla.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_Tabla.Name = "Txt_Tabla";
            this.Txt_Tabla.Size = new System.Drawing.Size(94, 36);
            this.Txt_Tabla.TabIndex = 0;
            this.Txt_Tabla.Text = "Tabla";
            this.Txt_Tabla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Txt_Tabla.Click += new System.EventHandler(this.LblTabla_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(178, 158);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // Navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Txt_Tabla);
            this.Controls.Add(this.Tlp_Panel2);
            this.Controls.Add(this.Dgv_Informacion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Navegador";
            this.Size = new System.Drawing.Size(1123, 891);
            this.Load += new System.EventHandler(this.Navegador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Informacion)).EndInit();
            this.Tlp_Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView Dgv_Informacion;
        public System.Windows.Forms.TableLayoutPanel Tlp_Panel2;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_FlechaFin;
        private System.Windows.Forms.Button Btn_Siguiente;
        private System.Windows.Forms.Button Btn_Anterior;
        private System.Windows.Forms.Button Btn_FlechaInicio;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label Txt_Tabla;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.ComponentModel.BackgroundWorker Bw_1;
        private System.Windows.Forms.Button Btn_Refrescar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
