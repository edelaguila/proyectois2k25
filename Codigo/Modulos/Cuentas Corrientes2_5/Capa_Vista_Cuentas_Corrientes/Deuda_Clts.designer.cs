
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Deuda_Clts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deuda_Clts));
            this.Txt_montoDeuda = new System.Windows.Forms.TextBox();
            this.Lbl_monto_dueda = new System.Windows.Forms.Label();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_id_deuda = new System.Windows.Forms.TextBox();
            this.Lbl_id_deuda = new System.Windows.Forms.Label();
            this.Lbl_inicio_deuda = new System.Windows.Forms.Label();
            this.Lbl_vencimiento_deuda = new System.Windows.Forms.Label();
            this.Lbl_id_cobra_deuda = new System.Windows.Forms.Label();
            this.Lbl_id_clt_deuda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_estado_deuda = new System.Windows.Forms.Label();
            this.Lbl_descrip_deuda = new System.Windows.Forms.Label();
            this.Cbo_id_clientes = new System.Windows.Forms.ComboBox();
            this.Cbo_id_cobrador = new System.Windows.Forms.ComboBox();
            this.Dgv_deudas = new System.Windows.Forms.DataGridView();
            this.Cbo_idfactura = new System.Windows.Forms.ComboBox();
            this.Text_IdFactura = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Txt_Descipcion = new System.Windows.Forms.TextBox();
            this.Dtp_FechaV = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaI = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_reportes = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_Ayudas = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deudas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_montoDeuda
            // 
            this.Txt_montoDeuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_montoDeuda.Location = new System.Drawing.Point(296, 269);
            this.Txt_montoDeuda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_montoDeuda.Name = "Txt_montoDeuda";
            this.Txt_montoDeuda.Size = new System.Drawing.Size(206, 35);
            this.Txt_montoDeuda.TabIndex = 56;
            this.Txt_montoDeuda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_montoDeuda_KeyPress);
            // 
            // Lbl_monto_dueda
            // 
            this.Lbl_monto_dueda.AutoSize = true;
            this.Lbl_monto_dueda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_monto_dueda.Location = new System.Drawing.Point(14, 277);
            this.Lbl_monto_dueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_monto_dueda.Name = "Lbl_monto_dueda";
            this.Lbl_monto_dueda.Size = new System.Drawing.Size(180, 27);
            this.Lbl_monto_dueda.TabIndex = 54;
            this.Lbl_monto_dueda.Text = "Monto de Deuda:";
            this.Lbl_monto_dueda.Click += new System.EventHandler(this.Lbl_monto_dueda_Click);
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.AutoCompleteCustomSource.AddRange(new string[] {
            "1. Habilitado",
            "2. Inhabilitado"});
            this.Cbo_estado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "1",
            "0"});
            this.Cbo_estado.Location = new System.Drawing.Point(860, 228);
            this.Cbo_estado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(164, 35);
            this.Cbo_estado.TabIndex = 53;
            this.Cbo_estado.SelectedIndexChanged += new System.EventHandler(this.Cbo_estado_SelectedIndexChanged);
            // 
            // Txt_id_deuda
            // 
            this.Txt_id_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_deuda.Location = new System.Drawing.Point(296, 72);
            this.Txt_id_deuda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_id_deuda.Name = "Txt_id_deuda";
            this.Txt_id_deuda.Size = new System.Drawing.Size(192, 35);
            this.Txt_id_deuda.TabIndex = 52;
            // 
            // Lbl_id_deuda
            // 
            this.Lbl_id_deuda.AutoSize = true;
            this.Lbl_id_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_deuda.Location = new System.Drawing.Point(56, 75);
            this.Lbl_id_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_deuda.Name = "Lbl_id_deuda";
            this.Lbl_id_deuda.Size = new System.Drawing.Size(107, 27);
            this.Lbl_id_deuda.TabIndex = 51;
            this.Lbl_id_deuda.Text = "Id Deuda:";
            // 
            // Lbl_inicio_deuda
            // 
            this.Lbl_inicio_deuda.AutoSize = true;
            this.Lbl_inicio_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_inicio_deuda.Location = new System.Drawing.Point(577, 70);
            this.Lbl_inicio_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_inicio_deuda.Name = "Lbl_inicio_deuda";
            this.Lbl_inicio_deuda.Size = new System.Drawing.Size(206, 27);
            this.Lbl_inicio_deuda.TabIndex = 49;
            this.Lbl_inicio_deuda.Text = "Fecha Inicio Deuda:";
            // 
            // Lbl_vencimiento_deuda
            // 
            this.Lbl_vencimiento_deuda.AutoSize = true;
            this.Lbl_vencimiento_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_vencimiento_deuda.Location = new System.Drawing.Point(577, 123);
            this.Lbl_vencimiento_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_vencimiento_deuda.Name = "Lbl_vencimiento_deuda";
            this.Lbl_vencimiento_deuda.Size = new System.Drawing.Size(270, 27);
            this.Lbl_vencimiento_deuda.TabIndex = 46;
            this.Lbl_vencimiento_deuda.Text = "Fecha Vencimiento Deuda:";
            // 
            // Lbl_id_cobra_deuda
            // 
            this.Lbl_id_cobra_deuda.AutoSize = true;
            this.Lbl_id_cobra_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_cobra_deuda.Location = new System.Drawing.Point(56, 167);
            this.Lbl_id_cobra_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_cobra_deuda.Name = "Lbl_id_cobra_deuda";
            this.Lbl_id_cobra_deuda.Size = new System.Drawing.Size(135, 27);
            this.Lbl_id_cobra_deuda.TabIndex = 45;
            this.Lbl_id_cobra_deuda.Text = "Id Cobrador:";
            // 
            // Lbl_id_clt_deuda
            // 
            this.Lbl_id_clt_deuda.AutoSize = true;
            this.Lbl_id_clt_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_clt_deuda.Location = new System.Drawing.Point(56, 125);
            this.Lbl_id_clt_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_clt_deuda.Name = "Lbl_id_clt_deuda";
            this.Lbl_id_clt_deuda.Size = new System.Drawing.Size(119, 27);
            this.Lbl_id_clt_deuda.TabIndex = 44;
            this.Lbl_id_clt_deuda.Text = "Id Cliente: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 37);
            this.label3.TabIndex = 60;
            this.label3.Text = "DEUDAS - CLIENTES -\r\n";
            // 
            // Lbl_estado_deuda
            // 
            this.Lbl_estado_deuda.AutoSize = true;
            this.Lbl_estado_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado_deuda.Location = new System.Drawing.Point(593, 228);
            this.Lbl_estado_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_estado_deuda.Name = "Lbl_estado_deuda";
            this.Lbl_estado_deuda.Size = new System.Drawing.Size(205, 27);
            this.Lbl_estado_deuda.TabIndex = 61;
            this.Lbl_estado_deuda.Text = "Estado de la Deuda:";
            // 
            // Lbl_descrip_deuda
            // 
            this.Lbl_descrip_deuda.AutoSize = true;
            this.Lbl_descrip_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descrip_deuda.Location = new System.Drawing.Point(580, 176);
            this.Lbl_descrip_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_descrip_deuda.Name = "Lbl_descrip_deuda";
            this.Lbl_descrip_deuda.Size = new System.Drawing.Size(254, 27);
            this.Lbl_descrip_deuda.TabIndex = 62;
            this.Lbl_descrip_deuda.Text = "Descripcion de la Deuda:";
            // 
            // Cbo_id_clientes
            // 
            this.Cbo_id_clientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_id_clientes.FormattingEnabled = true;
            this.Cbo_id_clientes.Location = new System.Drawing.Point(295, 124);
            this.Cbo_id_clientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cbo_id_clientes.Name = "Cbo_id_clientes";
            this.Cbo_id_clientes.Size = new System.Drawing.Size(136, 35);
            this.Cbo_id_clientes.TabIndex = 76;
            // 
            // Cbo_id_cobrador
            // 
            this.Cbo_id_cobrador.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_id_cobrador.FormattingEnabled = true;
            this.Cbo_id_cobrador.Location = new System.Drawing.Point(295, 168);
            this.Cbo_id_cobrador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cbo_id_cobrador.Name = "Cbo_id_cobrador";
            this.Cbo_id_cobrador.Size = new System.Drawing.Size(136, 35);
            this.Cbo_id_cobrador.TabIndex = 77;
            // 
            // Dgv_deudas
            // 
            this.Dgv_deudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_deudas.Location = new System.Drawing.Point(74, 592);
            this.Dgv_deudas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv_deudas.Name = "Dgv_deudas";
            this.Dgv_deudas.RowHeadersWidth = 51;
            this.Dgv_deudas.RowTemplate.Height = 24;
            this.Dgv_deudas.Size = new System.Drawing.Size(1042, 325);
            this.Dgv_deudas.TabIndex = 79;
            this.Dgv_deudas.DoubleClick += new System.EventHandler(this.Dgv_deudas_DoubleClick);
            // 
            // Cbo_idfactura
            // 
            this.Cbo_idfactura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_idfactura.FormattingEnabled = true;
            this.Cbo_idfactura.Location = new System.Drawing.Point(296, 220);
            this.Cbo_idfactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cbo_idfactura.Name = "Cbo_idfactura";
            this.Cbo_idfactura.Size = new System.Drawing.Size(136, 35);
            this.Cbo_idfactura.TabIndex = 86;
            // 
            // Text_IdFactura
            // 
            this.Text_IdFactura.AutoSize = true;
            this.Text_IdFactura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_IdFactura.Location = new System.Drawing.Point(62, 221);
            this.Text_IdFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Text_IdFactura.Name = "Text_IdFactura";
            this.Text_IdFactura.Size = new System.Drawing.Size(132, 27);
            this.Text_IdFactura.TabIndex = 85;
            this.Text_IdFactura.Text = "No. Factura:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            // 
            // Txt_Descipcion
            // 
            this.Txt_Descipcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descipcion.Location = new System.Drawing.Point(860, 168);
            this.Txt_Descipcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Descipcion.Multiline = true;
            this.Txt_Descipcion.Name = "Txt_Descipcion";
            this.Txt_Descipcion.Size = new System.Drawing.Size(301, 38);
            this.Txt_Descipcion.TabIndex = 65;
            // 
            // Dtp_FechaV
            // 
            this.Dtp_FechaV.Location = new System.Drawing.Point(885, 127);
            this.Dtp_FechaV.Name = "Dtp_FechaV";
            this.Dtp_FechaV.Size = new System.Drawing.Size(200, 26);
            this.Dtp_FechaV.TabIndex = 117;
            // 
            // Dtp_FechaI
            // 
            this.Dtp_FechaI.Location = new System.Drawing.Point(860, 72);
            this.Dtp_FechaI.Name = "Dtp_FechaI";
            this.Dtp_FechaI.Size = new System.Drawing.Size(200, 26);
            this.Dtp_FechaI.TabIndex = 118;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Actualizar);
            this.groupBox1.Controls.Add(this.Btn_editar);
            this.groupBox1.Controls.Add(this.Btn_reportes);
            this.groupBox1.Controls.Add(this.Btn_eliminar);
            this.groupBox1.Controls.Add(this.Btn_Ayudas);
            this.groupBox1.Controls.Add(this.Btn_guardar);
            this.groupBox1.Controls.Add(this.Btn_salir);
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(288, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 99);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lbl_descrip_deuda);
            this.groupBox2.Controls.Add(this.Lbl_id_clt_deuda);
            this.groupBox2.Controls.Add(this.Lbl_id_cobra_deuda);
            this.groupBox2.Controls.Add(this.Dtp_FechaI);
            this.groupBox2.Controls.Add(this.Lbl_vencimiento_deuda);
            this.groupBox2.Controls.Add(this.Dtp_FechaV);
            this.groupBox2.Controls.Add(this.Lbl_inicio_deuda);
            this.groupBox2.Controls.Add(this.Cbo_idfactura);
            this.groupBox2.Controls.Add(this.Lbl_id_deuda);
            this.groupBox2.Controls.Add(this.Text_IdFactura);
            this.groupBox2.Controls.Add(this.Txt_id_deuda);
            this.groupBox2.Controls.Add(this.Cbo_estado);
            this.groupBox2.Controls.Add(this.Cbo_id_cobrador);
            this.groupBox2.Controls.Add(this.Lbl_monto_dueda);
            this.groupBox2.Controls.Add(this.Cbo_id_clientes);
            this.groupBox2.Controls.Add(this.Txt_montoDeuda);
            this.groupBox2.Controls.Add(this.Txt_Descipcion);
            this.groupBox2.Controls.Add(this.Lbl_estado_deuda);
            this.groupBox2.Location = new System.Drawing.Point(37, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1142, 342);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Actualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Actualizar.Image")));
            this.Btn_Actualizar.Location = new System.Drawing.Point(47, 13);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(68, 78);
            this.Btn_Actualizar.TabIndex = 75;
            this.toolTip1.SetToolTip(this.Btn_Actualizar, "Agregar Registro");
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_editar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.Location = new System.Drawing.Point(277, 13);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(68, 78);
            this.Btn_editar.TabIndex = 71;
            this.toolTip1.SetToolTip(this.Btn_editar, "Modificar Registro");
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_reportes
            // 
            this.Btn_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_reportes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reportes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_reportes.Image")));
            this.Btn_reportes.Location = new System.Drawing.Point(430, 14);
            this.Btn_reportes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_reportes.Name = "Btn_reportes";
            this.Btn_reportes.Size = new System.Drawing.Size(73, 76);
            this.Btn_reportes.TabIndex = 116;
            this.toolTip1.SetToolTip(this.Btn_reportes, "Ver Reporte");
            this.Btn_reportes.UseVisualStyleBackColor = false;
            this.Btn_reportes.Click += new System.EventHandler(this.Btn_reportes_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_eliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(202, 13);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(65, 78);
            this.Btn_eliminar.TabIndex = 73;
            this.toolTip1.SetToolTip(this.Btn_eliminar, "Eliminar Registro");
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_Ayudas
            // 
            this.Btn_Ayudas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Ayudas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayudas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayudas.Image")));
            this.Btn_Ayudas.Location = new System.Drawing.Point(509, 14);
            this.Btn_Ayudas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Ayudas.Name = "Btn_Ayudas";
            this.Btn_Ayudas.Size = new System.Drawing.Size(73, 76);
            this.Btn_Ayudas.TabIndex = 115;
            this.toolTip1.SetToolTip(this.Btn_Ayudas, "Ver Ayudas");
            this.Btn_Ayudas.UseVisualStyleBackColor = false;
            this.Btn_Ayudas.Click += new System.EventHandler(this.Btn_Ayudas_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_guardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(123, 14);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(71, 76);
            this.Btn_guardar.TabIndex = 74;
            this.toolTip1.SetToolTip(this.Btn_guardar, "Guardar Registro");
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_salir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salir.Image")));
            this.Btn_salir.Location = new System.Drawing.Point(589, 13);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(71, 77);
            this.Btn_salir.TabIndex = 87;
            this.toolTip1.SetToolTip(this.Btn_salir, "Salir");
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(353, 13);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(70, 78);
            this.Btn_Buscar.TabIndex = 80;
            this.toolTip1.SetToolTip(this.Btn_Buscar, "Buscar Registro");
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Deuda_Clts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1220, 930);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dgv_deudas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Deuda_Clts";
            this.Text = "Deuda_Clts";
            this.Load += new System.EventHandler(this.Deuda_Clts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deudas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_montoDeuda;
        private System.Windows.Forms.Label Lbl_monto_dueda;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_id_deuda;
        private System.Windows.Forms.Label Lbl_id_deuda;
        private System.Windows.Forms.Label Lbl_inicio_deuda;
        private System.Windows.Forms.Label Lbl_vencimiento_deuda;
        private System.Windows.Forms.Label Lbl_id_cobra_deuda;
        private System.Windows.Forms.Label Lbl_id_clt_deuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_estado_deuda;
        private System.Windows.Forms.Label Lbl_descrip_deuda;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.ComboBox Cbo_id_clientes;
        private System.Windows.Forms.ComboBox Cbo_id_cobrador;
        private System.Windows.Forms.DataGridView Dgv_deudas;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.ComboBox Cbo_idfactura;
        private System.Windows.Forms.Label Text_IdFactura;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_reportes;
        private System.Windows.Forms.Button Btn_Ayudas;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox Txt_Descipcion;
        private System.Windows.Forms.DateTimePicker Dtp_FechaV;
        private System.Windows.Forms.DateTimePicker Dtp_FechaI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}