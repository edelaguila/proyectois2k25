
namespace Capa_Vista
{
    partial class Frm_comisiones
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
            this.Lbl_total = new System.Windows.Forms.Label();
            this.Txt_comision = new System.Windows.Forms.TextBox();
            this.Txt_venta = new System.Windows.Forms.TextBox();
            this.Lbl_venta = new System.Windows.Forms.Label();
            this.Txt_porcentaje = new System.Windows.Forms.TextBox();
            this.Lbl_comision = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Dgv_ventas = new System.Windows.Forms.DataGridView();
            this.Gpb_ventas = new System.Windows.Forms.GroupBox();
            this.Lbl_filtro = new System.Windows.Forms.Label();
            this.Cbo_filtro = new System.Windows.Forms.ComboBox();
            this.Rdb_costo = new System.Windows.Forms.RadioButton();
            this.Rdb_lineas = new System.Windows.Forms.RadioButton();
            this.Rdb_inventario = new System.Windows.Forms.RadioButton();
            this.Rdb_marcas = new System.Windows.Forms.RadioButton();
            this.Dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.Lbl_al = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_del = new System.Windows.Forms.Label();
            this.Gpb_calculo = new System.Windows.Forms.GroupBox();
            this.Btn_calcular = new System.Windows.Forms.Button();
            this.Gpb_limpiar = new System.Windows.Forms.GroupBox();
            this.Gpb_reporte = new System.Windows.Forms.GroupBox();
            this.Cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.Lbl_vendedor = new System.Windows.Forms.Label();
            this.Tt_mensajes = new System.Windows.Forms.ToolTip(this.components);
            this.Gpb_ayuda = new System.Windows.Forms.GroupBox();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ventas)).BeginInit();
            this.Gpb_ventas.SuspendLayout();
            this.Gpb_calculo.SuspendLayout();
            this.Gpb_limpiar.SuspendLayout();
            this.Gpb_reporte.SuspendLayout();
            this.Gpb_ayuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_total
            // 
            this.Lbl_total.AutoSize = true;
            this.Lbl_total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_total.Location = new System.Drawing.Point(150, 72);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(126, 22);
            this.Lbl_total.TabIndex = 50;
            this.Lbl_total.Text = "Comsion total:";
            // 
            // Txt_comision
            // 
            this.Txt_comision.Enabled = false;
            this.Txt_comision.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_comision.Location = new System.Drawing.Point(287, 72);
            this.Txt_comision.Name = "Txt_comision";
            this.Txt_comision.Size = new System.Drawing.Size(154, 30);
            this.Txt_comision.TabIndex = 49;
            this.Tt_mensajes.SetToolTip(this.Txt_comision, "Monto total que se le pagara de comision al vendedor.");
            // 
            // Txt_venta
            // 
            this.Txt_venta.Enabled = false;
            this.Txt_venta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_venta.Location = new System.Drawing.Point(287, 26);
            this.Txt_venta.Name = "Txt_venta";
            this.Txt_venta.Size = new System.Drawing.Size(154, 30);
            this.Txt_venta.TabIndex = 48;
            this.Tt_mensajes.SetToolTip(this.Txt_venta, "Suma total de las ventas que se filtraron,");
            // 
            // Lbl_venta
            // 
            this.Lbl_venta.AutoSize = true;
            this.Lbl_venta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_venta.Location = new System.Drawing.Point(128, 29);
            this.Lbl_venta.Name = "Lbl_venta";
            this.Lbl_venta.Size = new System.Drawing.Size(148, 22);
            this.Lbl_venta.TabIndex = 47;
            this.Lbl_venta.Text = "Total de la venta:";
            // 
            // Txt_porcentaje
            // 
            this.Txt_porcentaje.Enabled = false;
            this.Txt_porcentaje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_porcentaje.Location = new System.Drawing.Point(1079, 304);
            this.Txt_porcentaje.Name = "Txt_porcentaje";
            this.Txt_porcentaje.Size = new System.Drawing.Size(80, 30);
            this.Txt_porcentaje.TabIndex = 46;
            // 
            // Lbl_comision
            // 
            this.Lbl_comision.AutoSize = true;
            this.Lbl_comision.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_comision.Location = new System.Drawing.Point(892, 312);
            this.Lbl_comision.Name = "Lbl_comision";
            this.Lbl_comision.Size = new System.Drawing.Size(181, 22);
            this.Lbl_comision.TabIndex = 45;
            this.Lbl_comision.Text = "Porcentaje Comision:";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Enabled = false;
            this.Txt_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(25, 304);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(383, 30);
            this.Txt_nombre.TabIndex = 43;
            // 
            // Dgv_ventas
            // 
            this.Dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ventas.Location = new System.Drawing.Point(26, 350);
            this.Dgv_ventas.Name = "Dgv_ventas";
            this.Dgv_ventas.RowHeadersWidth = 51;
            this.Dgv_ventas.RowTemplate.Height = 24;
            this.Dgv_ventas.Size = new System.Drawing.Size(1133, 292);
            this.Dgv_ventas.TabIndex = 42;
            // 
            // Gpb_ventas
            // 
            this.Gpb_ventas.Controls.Add(this.Lbl_filtro);
            this.Gpb_ventas.Controls.Add(this.Cbo_filtro);
            this.Gpb_ventas.Controls.Add(this.Rdb_costo);
            this.Gpb_ventas.Controls.Add(this.Rdb_lineas);
            this.Gpb_ventas.Controls.Add(this.Rdb_inventario);
            this.Gpb_ventas.Controls.Add(this.Rdb_marcas);
            this.Gpb_ventas.Controls.Add(this.Dtp_fecha_fin);
            this.Gpb_ventas.Controls.Add(this.Lbl_al);
            this.Gpb_ventas.Controls.Add(this.label2);
            this.Gpb_ventas.Controls.Add(this.Dtp_fecha_inicio);
            this.Gpb_ventas.Controls.Add(this.Lbl_del);
            this.Gpb_ventas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_ventas.Location = new System.Drawing.Point(55, 12);
            this.Gpb_ventas.Name = "Gpb_ventas";
            this.Gpb_ventas.Size = new System.Drawing.Size(934, 196);
            this.Gpb_ventas.TabIndex = 44;
            this.Gpb_ventas.TabStop = false;
            this.Gpb_ventas.Text = "Filtrar ventas por:";
            this.Gpb_ventas.Enter += new System.EventHandler(this.Gpb_ventas_Enter);
            // 
            // Lbl_filtro
            // 
            this.Lbl_filtro.AutoSize = true;
            this.Lbl_filtro.Location = new System.Drawing.Point(232, 94);
            this.Lbl_filtro.Name = "Lbl_filtro";
            this.Lbl_filtro.Size = new System.Drawing.Size(0, 22);
            this.Lbl_filtro.TabIndex = 18;
            // 
            // Cbo_filtro
            // 
            this.Cbo_filtro.FormattingEnabled = true;
            this.Cbo_filtro.Location = new System.Drawing.Point(369, 91);
            this.Cbo_filtro.Name = "Cbo_filtro";
            this.Cbo_filtro.Size = new System.Drawing.Size(271, 30);
            this.Cbo_filtro.TabIndex = 17;
            // 
            // Rdb_costo
            // 
            this.Rdb_costo.AutoSize = true;
            this.Rdb_costo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_costo.Location = new System.Drawing.Point(596, 46);
            this.Rdb_costo.Name = "Rdb_costo";
            this.Rdb_costo.Size = new System.Drawing.Size(163, 26);
            this.Rdb_costo.TabIndex = 16;
            this.Rdb_costo.TabStop = true;
            this.Rdb_costo.Text = "Basada en Costo";
            this.Tt_mensajes.SetToolTip(this.Rdb_costo, "Filtra basado en costos");
            this.Rdb_costo.UseVisualStyleBackColor = true;
            this.Rdb_costo.CheckedChanged += new System.EventHandler(this.Rdb_costo_CheckedChanged);
            // 
            // Rdb_lineas
            // 
            this.Rdb_lineas.AutoSize = true;
            this.Rdb_lineas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_lineas.Location = new System.Drawing.Point(507, 46);
            this.Rdb_lineas.Name = "Rdb_lineas";
            this.Rdb_lineas.Size = new System.Drawing.Size(83, 26);
            this.Rdb_lineas.TabIndex = 15;
            this.Rdb_lineas.TabStop = true;
            this.Rdb_lineas.Text = "Lineas";
            this.Tt_mensajes.SetToolTip(this.Rdb_lineas, "Filtra las ventas por marca segun la seleccion que elija en la lista desplegable " +
        "de abajo");
            this.Rdb_lineas.UseVisualStyleBackColor = true;
            this.Rdb_lineas.CheckedChanged += new System.EventHandler(this.Rdb_lineas_CheckedChanged);
            // 
            // Rdb_inventario
            // 
            this.Rdb_inventario.AutoSize = true;
            this.Rdb_inventario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_inventario.Location = new System.Drawing.Point(294, 46);
            this.Rdb_inventario.Name = "Rdb_inventario";
            this.Rdb_inventario.Size = new System.Drawing.Size(111, 26);
            this.Rdb_inventario.TabIndex = 14;
            this.Rdb_inventario.TabStop = true;
            this.Rdb_inventario.Text = "Inventario";
            this.Tt_mensajes.SetToolTip(this.Rdb_inventario, "Filtra las ventas por inventario.");
            this.Rdb_inventario.UseVisualStyleBackColor = true;
            this.Rdb_inventario.CheckedChanged += new System.EventHandler(this.Rdb_inventario_CheckedChanged);
            // 
            // Rdb_marcas
            // 
            this.Rdb_marcas.AutoSize = true;
            this.Rdb_marcas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_marcas.Location = new System.Drawing.Point(411, 46);
            this.Rdb_marcas.Name = "Rdb_marcas";
            this.Rdb_marcas.Size = new System.Drawing.Size(90, 26);
            this.Rdb_marcas.TabIndex = 13;
            this.Rdb_marcas.TabStop = true;
            this.Rdb_marcas.Text = "Marcas";
            this.Tt_mensajes.SetToolTip(this.Rdb_marcas, "Filtra las ventas por marca segun la seleccion que elija en la lista desplegable " +
        "de abajo.");
            this.Rdb_marcas.UseVisualStyleBackColor = true;
            this.Rdb_marcas.CheckedChanged += new System.EventHandler(this.Rdb_marcas_CheckedChanged);
            // 
            // Dtp_fecha_fin
            // 
            this.Dtp_fecha_fin.CalendarFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha_fin.Location = new System.Drawing.Point(544, 141);
            this.Dtp_fecha_fin.Name = "Dtp_fecha_fin";
            this.Dtp_fecha_fin.Size = new System.Drawing.Size(340, 30);
            this.Dtp_fecha_fin.TabIndex = 11;
            this.Tt_mensajes.SetToolTip(this.Dtp_fecha_fin, "Fecha final en la que desea mostrar las ventas.");
            // 
            // Lbl_al
            // 
            this.Lbl_al.AutoSize = true;
            this.Lbl_al.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_al.Location = new System.Drawing.Point(504, 147);
            this.Lbl_al.Name = "Lbl_al";
            this.Lbl_al.Size = new System.Drawing.Size(25, 22);
            this.Lbl_al.TabIndex = 10;
            this.Lbl_al.Text = "al";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comision por:";
            // 
            // Dtp_fecha_inicio
            // 
            this.Dtp_fecha_inicio.CalendarFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha_inicio.Location = new System.Drawing.Point(147, 141);
            this.Dtp_fecha_inicio.Name = "Dtp_fecha_inicio";
            this.Dtp_fecha_inicio.Size = new System.Drawing.Size(342, 30);
            this.Dtp_fecha_inicio.TabIndex = 9;
            this.Tt_mensajes.SetToolTip(this.Dtp_fecha_inicio, "Fecha inicial en la que desea mostrar las ventas.");
            // 
            // Lbl_del
            // 
            this.Lbl_del.AutoSize = true;
            this.Lbl_del.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_del.Location = new System.Drawing.Point(32, 147);
            this.Lbl_del.Name = "Lbl_del";
            this.Lbl_del.Size = new System.Drawing.Size(109, 22);
            this.Lbl_del.TabIndex = 7;
            this.Lbl_del.Text = "Periodo del:";
            // 
            // Gpb_calculo
            // 
            this.Gpb_calculo.Controls.Add(this.Btn_calcular);
            this.Gpb_calculo.Controls.Add(this.Lbl_venta);
            this.Gpb_calculo.Controls.Add(this.Txt_venta);
            this.Gpb_calculo.Controls.Add(this.Txt_comision);
            this.Gpb_calculo.Controls.Add(this.Lbl_total);
            this.Gpb_calculo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_calculo.Location = new System.Drawing.Point(691, 667);
            this.Gpb_calculo.Name = "Gpb_calculo";
            this.Gpb_calculo.Size = new System.Drawing.Size(468, 124);
            this.Gpb_calculo.TabIndex = 51;
            this.Gpb_calculo.TabStop = false;
            this.Gpb_calculo.Text = "Calculo de Comision:";
            // 
            // Btn_calcular
            // 
            this.Btn_calcular.Location = new System.Drawing.Point(31, 49);
            this.Btn_calcular.Name = "Btn_calcular";
            this.Btn_calcular.Size = new System.Drawing.Size(91, 35);
            this.Btn_calcular.TabIndex = 19;
            this.Btn_calcular.Text = "Calcular";
            this.Tt_mensajes.SetToolTip(this.Btn_calcular, "Presione para calcular la comision del vendedor, segun el filtro asignado");
            this.Btn_calcular.UseVisualStyleBackColor = true;
            this.Btn_calcular.Click += new System.EventHandler(this.Btn_calcular_Click_1);
            // 
            // Gpb_limpiar
            // 
            this.Gpb_limpiar.Controls.Add(this.Btn_limpiar);
            this.Gpb_limpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_limpiar.Location = new System.Drawing.Point(995, 165);
            this.Gpb_limpiar.Name = "Gpb_limpiar";
            this.Gpb_limpiar.Size = new System.Drawing.Size(164, 116);
            this.Gpb_limpiar.TabIndex = 55;
            this.Gpb_limpiar.TabStop = false;
            this.Gpb_limpiar.Text = "Limpiar campos:";
            // 
            // Gpb_reporte
            // 
            this.Gpb_reporte.Controls.Add(this.Btn_reporte);
            this.Gpb_reporte.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_reporte.Location = new System.Drawing.Point(38, 676);
            this.Gpb_reporte.Name = "Gpb_reporte";
            this.Gpb_reporte.Size = new System.Drawing.Size(182, 131);
            this.Gpb_reporte.TabIndex = 56;
            this.Gpb_reporte.TabStop = false;
            this.Gpb_reporte.Text = "Generar Reporte:";
            // 
            // Cbo_vendedor
            // 
            this.Cbo_vendedor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_vendedor.FormattingEnabled = true;
            this.Cbo_vendedor.Location = new System.Drawing.Point(124, 251);
            this.Cbo_vendedor.Name = "Cbo_vendedor";
            this.Cbo_vendedor.Size = new System.Drawing.Size(284, 30);
            this.Cbo_vendedor.TabIndex = 59;
            this.Tt_mensajes.SetToolTip(this.Cbo_vendedor, "Seleccione el vendedor al que desea calcular la comision");
            this.Cbo_vendedor.SelectedIndexChanged += new System.EventHandler(this.Cbo_vendedor_SelectedIndexChanged_1);
            // 
            // Lbl_vendedor
            // 
            this.Lbl_vendedor.AutoSize = true;
            this.Lbl_vendedor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_vendedor.Location = new System.Drawing.Point(26, 254);
            this.Lbl_vendedor.Name = "Lbl_vendedor";
            this.Lbl_vendedor.Size = new System.Drawing.Size(91, 22);
            this.Lbl_vendedor.TabIndex = 57;
            this.Lbl_vendedor.Text = "Vendedor:";
            // 
            // Tt_mensajes
            // 
            this.Tt_mensajes.AutoPopDelay = 5000;
            this.Tt_mensajes.InitialDelay = 100;
            this.Tt_mensajes.IsBalloon = true;
            this.Tt_mensajes.ReshowDelay = 100;
            this.Tt_mensajes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Tt_mensajes.ToolTipTitle = "Observacion";
            // 
            // Gpb_ayuda
            // 
            this.Gpb_ayuda.Controls.Add(this.Btn_ayuda);
            this.Gpb_ayuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_ayuda.Location = new System.Drawing.Point(995, 12);
            this.Gpb_ayuda.Name = "Gpb_ayuda";
            this.Gpb_ayuda.Size = new System.Drawing.Size(164, 116);
            this.Gpb_ayuda.TabIndex = 60;
            this.Gpb_ayuda.TabStop = false;
            this.Gpb_ayuda.Text = "Ayudas:";
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ayuda.Image = global::Capa_Vista.Properties.Resources.preguntas1;
            this.Btn_ayuda.Location = new System.Drawing.Point(47, 29);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(72, 68);
            this.Btn_ayuda.TabIndex = 53;
            this.Tt_mensajes.SetToolTip(this.Btn_ayuda, "Haga click aqui para ver informacion util del formulario.");
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.FlatAppearance.BorderSize = 0;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_buscar.Image = global::Capa_Vista.Properties.Resources.buscar__1_;
            this.Btn_buscar.Location = new System.Drawing.Point(424, 227);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(91, 85);
            this.Btn_buscar.TabIndex = 58;
            this.Tt_mensajes.SetToolTip(this.Btn_buscar, "Haga click aqui para confirmar el vendendor y los filtros que desea para las most" +
        "rar las ventas del mismo.");
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click_1);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.FlatAppearance.BorderSize = 0;
            this.Btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_limpiar.Image = global::Capa_Vista.Properties.Resources.cancelar1;
            this.Btn_limpiar.Location = new System.Drawing.Point(47, 29);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(72, 68);
            this.Btn_limpiar.TabIndex = 53;
            this.Tt_mensajes.SetToolTip(this.Btn_limpiar, "Haga click aqui para limpiar todos los campos y cancelar todas las selecciones he" +
        "chas.");
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.FlatAppearance.BorderSize = 0;
            this.Btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_reporte.Image = global::Capa_Vista.Properties.Resources.reporte2;
            this.Btn_reporte.Location = new System.Drawing.Point(57, 40);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(60, 53);
            this.Btn_reporte.TabIndex = 52;
            this.Tt_mensajes.SetToolTip(this.Btn_reporte, "Haga click aqui para mostrar el reporte de las comisiones de los vendedores.");
            this.Btn_reporte.UseVisualStyleBackColor = true;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Frm_comisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1183, 828);
            this.Controls.Add(this.Gpb_ayuda);
            this.Controls.Add(this.Cbo_vendedor);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Lbl_vendedor);
            this.Controls.Add(this.Gpb_limpiar);
            this.Controls.Add(this.Txt_porcentaje);
            this.Controls.Add(this.Lbl_comision);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Dgv_ventas);
            this.Controls.Add(this.Gpb_calculo);
            this.Controls.Add(this.Gpb_reporte);
            this.Controls.Add(this.Gpb_ventas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_comisiones";
            this.ShowIcon = false;
            this.Text = "Comisiones Vendedores";
            this.Load += new System.EventHandler(this.Frm_comisiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ventas)).EndInit();
            this.Gpb_ventas.ResumeLayout(false);
            this.Gpb_ventas.PerformLayout();
            this.Gpb_calculo.ResumeLayout(false);
            this.Gpb_calculo.PerformLayout();
            this.Gpb_limpiar.ResumeLayout(false);
            this.Gpb_reporte.ResumeLayout(false);
            this.Gpb_ayuda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.TextBox Txt_comision;
        private System.Windows.Forms.TextBox Txt_venta;
        private System.Windows.Forms.Label Lbl_venta;
        private System.Windows.Forms.TextBox Txt_porcentaje;
        private System.Windows.Forms.Label Lbl_comision;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.DataGridView Dgv_ventas;
        private System.Windows.Forms.GroupBox Gpb_ventas;
        private System.Windows.Forms.RadioButton Rdb_costo;
        private System.Windows.Forms.RadioButton Rdb_lineas;
        private System.Windows.Forms.RadioButton Rdb_inventario;
        private System.Windows.Forms.RadioButton Rdb_marcas;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_fin;
        private System.Windows.Forms.Label Lbl_al;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_inicio;
        private System.Windows.Forms.Label Lbl_del;
        private System.Windows.Forms.GroupBox Gpb_calculo;
        private System.Windows.Forms.Button Btn_calcular;
        private System.Windows.Forms.GroupBox Gpb_limpiar;
        private System.Windows.Forms.GroupBox Gpb_reporte;
        private System.Windows.Forms.ComboBox Cbo_vendedor;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label Lbl_vendedor;
        private System.Windows.Forms.Label Lbl_filtro;
        private System.Windows.Forms.ComboBox Cbo_filtro;
        private System.Windows.Forms.ToolTip Tt_mensajes;
        private System.Windows.Forms.GroupBox Gpb_ayuda;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}