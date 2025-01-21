
namespace Capa_Vista_ListaPrecios
{
    partial class frm_ListadoPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ListadoPrecios));
            this.Gpb_listaEncabezado = new System.Windows.Forms.GroupBox();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cbo_tipoLista = new System.Windows.Forms.ComboBox();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Lbl_identificacion = new System.Windows.Forms.Label();
            this.Dgv_detalleProductos = new System.Windows.Forms.DataGridView();
            this.Gbp_datos2 = new System.Windows.Forms.GroupBox();
            this.Dgv_seleccionados = new System.Windows.Forms.DataGridView();
            this.Gpb_modo = new System.Windows.Forms.GroupBox();
            this.Txt_aplicar = new System.Windows.Forms.Label();
            this.Txt_porcentaje = new System.Windows.Forms.TextBox();
            this.Txt_forzado = new System.Windows.Forms.TextBox();
            this.Rdb_forzar = new System.Windows.Forms.RadioButton();
            this.Rdb_precioventa = new System.Windows.Forms.RadioButton();
            this.Rdb_costocompra = new System.Windows.Forms.RadioButton();
            this.Btn_aplicar = new System.Windows.Forms.Button();
            this.Txt_precioforzado = new System.Windows.Forms.Label();
            this.Gpb_filtros = new System.Windows.Forms.GroupBox();
            this.Lbl_especifico = new System.Windows.Forms.Label();
            this.Lbl_clasificaciones = new System.Windows.Forms.Label();
            this.Txt_inventario = new System.Windows.Forms.Label();
            this.Txt_busqueda = new System.Windows.Forms.Label();
            this.Cbo_clasificacionEspecifica = new System.Windows.Forms.ComboBox();
            this.Cbo_clasificacionGeneral = new System.Windows.Forms.ComboBox();
            this.Txt_clasificacion = new System.Windows.Forms.Label();
            this.Txt_productobuscado = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_clasificacionInventario = new System.Windows.Forms.TextBox();
            this.Txt_clasificacionEspecificaSeleccionada = new System.Windows.Forms.TextBox();
            this.Dgv_combinado = new System.Windows.Forms.DataGridView();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Txt_tituloLista = new System.Windows.Forms.Label();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_cancelarLista = new System.Windows.Forms.Button();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.Gpb_listaEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleProductos)).BeginInit();
            this.Gbp_datos2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_seleccionados)).BeginInit();
            this.Gpb_modo.SuspendLayout();
            this.Gpb_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_combinado)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_listaEncabezado
            // 
            this.Gpb_listaEncabezado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_listaEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.Gpb_listaEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gpb_listaEncabezado.Controls.Add(this.Txt_fecha);
            this.Gpb_listaEncabezado.Controls.Add(this.label6);
            this.Gpb_listaEncabezado.Controls.Add(this.Cbo_tipoLista);
            this.Gpb_listaEncabezado.Controls.Add(this.Cbo_estado);
            this.Gpb_listaEncabezado.Controls.Add(this.Txt_codigo);
            this.Gpb_listaEncabezado.Controls.Add(this.label7);
            this.Gpb_listaEncabezado.Controls.Add(this.label8);
            this.Gpb_listaEncabezado.Controls.Add(this.label10);
            this.Gpb_listaEncabezado.Controls.Add(this.Lbl_identificacion);
            this.Gpb_listaEncabezado.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.Gpb_listaEncabezado.Location = new System.Drawing.Point(51, 59);
            this.Gpb_listaEncabezado.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_listaEncabezado.Name = "Gpb_listaEncabezado";
            this.Gpb_listaEncabezado.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_listaEncabezado.Size = new System.Drawing.Size(1192, 130);
            this.Gpb_listaEncabezado.TabIndex = 345;
            this.Gpb_listaEncabezado.TabStop = false;
            this.Gpb_listaEncabezado.Text = "1. Identificación de la Lista";
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Txt_fecha.Location = new System.Drawing.Point(428, 85);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(266, 22);
            this.Txt_fecha.TabIndex = 345;
            this.Txt_fecha.TextChanged += new System.EventHandler(this.Txt_fecha_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(359, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 346;
            this.label6.Text = "Fecha:";
            // 
            // Cbo_tipoLista
            // 
            this.Cbo_tipoLista.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cbo_tipoLista.FormattingEnabled = true;
            this.Cbo_tipoLista.Location = new System.Drawing.Point(428, 46);
            this.Cbo_tipoLista.Name = "Cbo_tipoLista";
            this.Cbo_tipoLista.Size = new System.Drawing.Size(266, 23);
            this.Cbo_tipoLista.TabIndex = 339;
            this.Cbo_tipoLista.SelectedIndexChanged += new System.EventHandler(this.Cbo_tipoLista_SelectedIndexChanged);
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Location = new System.Drawing.Point(91, 84);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(235, 23);
            this.Cbo_estado.TabIndex = 344;
            this.Cbo_estado.SelectedIndexChanged += new System.EventHandler(this.Cbo_estado_SelectedIndexChanged);
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Txt_codigo.Location = new System.Drawing.Point(91, 46);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(235, 22);
            this.Txt_codigo.TabIndex = 342;
            this.Txt_codigo.TextChanged += new System.EventHandler(this.Txt_codigo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(28, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 339;
            this.label7.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label8.Location = new System.Drawing.Point(359, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 341;
            this.label8.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label10.Location = new System.Drawing.Point(28, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 340;
            this.label10.Text = "Código:";
            // 
            // Lbl_identificacion
            // 
            this.Lbl_identificacion.AutoSize = true;
            this.Lbl_identificacion.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_identificacion.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_identificacion.Location = new System.Drawing.Point(28, 23);
            this.Lbl_identificacion.Name = "Lbl_identificacion";
            this.Lbl_identificacion.Size = new System.Drawing.Size(154, 11);
            this.Lbl_identificacion.TabIndex = 338;
            this.Lbl_identificacion.Text = "Selección del Nombre de la Lista";
            // 
            // Dgv_detalleProductos
            // 
            this.Dgv_detalleProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_detalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalleProductos.Location = new System.Drawing.Point(50, 356);
            this.Dgv_detalleProductos.Name = "Dgv_detalleProductos";
            this.Dgv_detalleProductos.Size = new System.Drawing.Size(662, 190);
            this.Dgv_detalleProductos.TabIndex = 340;
            this.Dgv_detalleProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_detalleProductos_CellContentClick);
            // 
            // Gbp_datos2
            // 
            this.Gbp_datos2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbp_datos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.Gbp_datos2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gbp_datos2.Controls.Add(this.Dgv_seleccionados);
            this.Gbp_datos2.Controls.Add(this.Gpb_modo);
            this.Gbp_datos2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.Gbp_datos2.Location = new System.Drawing.Point(718, 197);
            this.Gbp_datos2.Margin = new System.Windows.Forms.Padding(4);
            this.Gbp_datos2.Name = "Gbp_datos2";
            this.Gbp_datos2.Padding = new System.Windows.Forms.Padding(4);
            this.Gbp_datos2.Size = new System.Drawing.Size(524, 345);
            this.Gbp_datos2.TabIndex = 343;
            this.Gbp_datos2.TabStop = false;
            this.Gbp_datos2.Text = "3. Consulta de Precios a Aplicar";
            // 
            // Dgv_seleccionados
            // 
            this.Dgv_seleccionados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_seleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_seleccionados.Location = new System.Drawing.Point(10, 24);
            this.Dgv_seleccionados.Name = "Dgv_seleccionados";
            this.Dgv_seleccionados.Size = new System.Drawing.Size(505, 154);
            this.Dgv_seleccionados.TabIndex = 327;
            // 
            // Gpb_modo
            // 
            this.Gpb_modo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.Gpb_modo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gpb_modo.Controls.Add(this.Txt_aplicar);
            this.Gpb_modo.Controls.Add(this.Txt_porcentaje);
            this.Gpb_modo.Controls.Add(this.Txt_forzado);
            this.Gpb_modo.Controls.Add(this.Rdb_forzar);
            this.Gpb_modo.Controls.Add(this.Rdb_precioventa);
            this.Gpb_modo.Controls.Add(this.Rdb_costocompra);
            this.Gpb_modo.Controls.Add(this.Btn_aplicar);
            this.Gpb_modo.Controls.Add(this.Txt_precioforzado);
            this.Gpb_modo.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold);
            this.Gpb_modo.ForeColor = System.Drawing.Color.Blue;
            this.Gpb_modo.Location = new System.Drawing.Point(10, 184);
            this.Gpb_modo.Name = "Gpb_modo";
            this.Gpb_modo.Size = new System.Drawing.Size(505, 156);
            this.Gpb_modo.TabIndex = 326;
            this.Gpb_modo.TabStop = false;
            this.Gpb_modo.Text = "Métodos de fijación de precios";
            // 
            // Txt_aplicar
            // 
            this.Txt_aplicar.AutoSize = true;
            this.Txt_aplicar.ForeColor = System.Drawing.Color.Black;
            this.Txt_aplicar.Location = new System.Drawing.Point(478, 67);
            this.Txt_aplicar.Name = "Txt_aplicar";
            this.Txt_aplicar.Size = new System.Drawing.Size(13, 11);
            this.Txt_aplicar.TabIndex = 317;
            this.Txt_aplicar.Text = "%";
            // 
            // Txt_porcentaje
            // 
            this.Txt_porcentaje.Location = new System.Drawing.Point(360, 60);
            this.Txt_porcentaje.Name = "Txt_porcentaje";
            this.Txt_porcentaje.Size = new System.Drawing.Size(121, 18);
            this.Txt_porcentaje.TabIndex = 315;
            this.Txt_porcentaje.TextChanged += new System.EventHandler(this.Txt_porcentaje_TextChanged);
            // 
            // Txt_forzado
            // 
            this.Txt_forzado.Location = new System.Drawing.Point(128, 120);
            this.Txt_forzado.Name = "Txt_forzado";
            this.Txt_forzado.Size = new System.Drawing.Size(93, 18);
            this.Txt_forzado.TabIndex = 314;
            this.Txt_forzado.TextChanged += new System.EventHandler(this.Txt_forzado_TextChanged);
            // 
            // Rdb_forzar
            // 
            this.Rdb_forzar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_forzar.AutoSize = true;
            this.Rdb_forzar.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.Rdb_forzar.ForeColor = System.Drawing.Color.Black;
            this.Rdb_forzar.Location = new System.Drawing.Point(19, 102);
            this.Rdb_forzar.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_forzar.Name = "Rdb_forzar";
            this.Rdb_forzar.Size = new System.Drawing.Size(102, 20);
            this.Rdb_forzar.TabIndex = 4;
            this.Rdb_forzar.TabStop = true;
            this.Rdb_forzar.Text = "Forzar precio";
            this.Rdb_forzar.UseVisualStyleBackColor = true;
            this.Rdb_forzar.CheckedChanged += new System.EventHandler(this.Rdb_forzar_CheckedChanged);
            // 
            // Rdb_precioventa
            // 
            this.Rdb_precioventa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_precioventa.AutoSize = true;
            this.Rdb_precioventa.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.Rdb_precioventa.ForeColor = System.Drawing.Color.Black;
            this.Rdb_precioventa.Location = new System.Drawing.Point(19, 28);
            this.Rdb_precioventa.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_precioventa.Name = "Rdb_precioventa";
            this.Rdb_precioventa.Size = new System.Drawing.Size(256, 20);
            this.Rdb_precioventa.TabIndex = 2;
            this.Rdb_precioventa.TabStop = true;
            this.Rdb_precioventa.Text = "Usar descuento contra el precio de venta";
            this.Rdb_precioventa.UseVisualStyleBackColor = true;
            this.Rdb_precioventa.CheckedChanged += new System.EventHandler(this.Rdb_precioventa_CheckedChanged);
            // 
            // Rdb_costocompra
            // 
            this.Rdb_costocompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_costocompra.AutoSize = true;
            this.Rdb_costocompra.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.Rdb_costocompra.ForeColor = System.Drawing.Color.Black;
            this.Rdb_costocompra.Location = new System.Drawing.Point(19, 63);
            this.Rdb_costocompra.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_costocompra.Name = "Rdb_costocompra";
            this.Rdb_costocompra.Size = new System.Drawing.Size(325, 20);
            this.Rdb_costocompra.TabIndex = 3;
            this.Rdb_costocompra.TabStop = true;
            this.Rdb_costocompra.Text = "Usar ganancia a partir del costo promedio de compra";
            this.Rdb_costocompra.UseVisualStyleBackColor = true;
            this.Rdb_costocompra.CheckedChanged += new System.EventHandler(this.Rdb_costocompra_CheckedChanged);
            // 
            // Btn_aplicar
            // 
            this.Btn_aplicar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_aplicar.Image")));
            this.Btn_aplicar.Location = new System.Drawing.Point(421, 90);
            this.Btn_aplicar.Name = "Btn_aplicar";
            this.Btn_aplicar.Size = new System.Drawing.Size(60, 60);
            this.Btn_aplicar.TabIndex = 346;
            this.Btn_aplicar.UseVisualStyleBackColor = true;
            this.Btn_aplicar.Click += new System.EventHandler(this.Btn_aplicar_Click);
            // 
            // Txt_precioforzado
            // 
            this.Txt_precioforzado.AutoSize = true;
            this.Txt_precioforzado.ForeColor = System.Drawing.Color.Red;
            this.Txt_precioforzado.Location = new System.Drawing.Point(137, 106);
            this.Txt_precioforzado.Name = "Txt_precioforzado";
            this.Txt_precioforzado.Size = new System.Drawing.Size(72, 11);
            this.Txt_precioforzado.TabIndex = 0;
            this.Txt_precioforzado.Text = "Precio forzado";
            // 
            // Gpb_filtros
            // 
            this.Gpb_filtros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_filtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.Gpb_filtros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gpb_filtros.Controls.Add(this.Lbl_especifico);
            this.Gpb_filtros.Controls.Add(this.Lbl_clasificaciones);
            this.Gpb_filtros.Controls.Add(this.Txt_inventario);
            this.Gpb_filtros.Controls.Add(this.Txt_busqueda);
            this.Gpb_filtros.Controls.Add(this.Cbo_clasificacionEspecifica);
            this.Gpb_filtros.Controls.Add(this.Cbo_clasificacionGeneral);
            this.Gpb_filtros.Controls.Add(this.Txt_clasificacion);
            this.Gpb_filtros.Controls.Add(this.Txt_productobuscado);
            this.Gpb_filtros.Controls.Add(this.Btn_buscar);
            this.Gpb_filtros.Controls.Add(this.Txt_clasificacionInventario);
            this.Gpb_filtros.Controls.Add(this.Txt_clasificacionEspecificaSeleccionada);
            this.Gpb_filtros.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.Gpb_filtros.Location = new System.Drawing.Point(51, 197);
            this.Gpb_filtros.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_filtros.Name = "Gpb_filtros";
            this.Gpb_filtros.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_filtros.Size = new System.Drawing.Size(662, 148);
            this.Gpb_filtros.TabIndex = 344;
            this.Gpb_filtros.TabStop = false;
            this.Gpb_filtros.Text = "2. Filtros de búsqueda";
            // 
            // Lbl_especifico
            // 
            this.Lbl_especifico.AutoSize = true;
            this.Lbl_especifico.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_especifico.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_especifico.Location = new System.Drawing.Point(29, 78);
            this.Lbl_especifico.Name = "Lbl_especifico";
            this.Lbl_especifico.Size = new System.Drawing.Size(161, 11);
            this.Lbl_especifico.TabIndex = 337;
            this.Lbl_especifico.Text = "Selección por producto específico";
            // 
            // Lbl_clasificaciones
            // 
            this.Lbl_clasificaciones.AutoSize = true;
            this.Lbl_clasificaciones.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_clasificaciones.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_clasificaciones.Location = new System.Drawing.Point(27, 25);
            this.Lbl_clasificaciones.Name = "Lbl_clasificaciones";
            this.Lbl_clasificaciones.Size = new System.Drawing.Size(201, 11);
            this.Lbl_clasificaciones.TabIndex = 318;
            this.Lbl_clasificaciones.Text = "Selección de productos por clasificaciones";
            // 
            // Txt_inventario
            // 
            this.Txt_inventario.AutoSize = true;
            this.Txt_inventario.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Txt_inventario.ForeColor = System.Drawing.Color.Black;
            this.Txt_inventario.Location = new System.Drawing.Point(27, 101);
            this.Txt_inventario.Name = "Txt_inventario";
            this.Txt_inventario.Size = new System.Drawing.Size(72, 19);
            this.Txt_inventario.TabIndex = 336;
            this.Txt_inventario.Text = "Inventario:";
            // 
            // Txt_busqueda
            // 
            this.Txt_busqueda.AutoSize = true;
            this.Txt_busqueda.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Txt_busqueda.ForeColor = System.Drawing.Color.Black;
            this.Txt_busqueda.Location = new System.Drawing.Point(364, 46);
            this.Txt_busqueda.Name = "Txt_busqueda";
            this.Txt_busqueda.Size = new System.Drawing.Size(39, 19);
            this.Txt_busqueda.TabIndex = 313;
            this.Txt_busqueda.Text = "Tipo:";
            // 
            // Cbo_clasificacionEspecifica
            // 
            this.Cbo_clasificacionEspecifica.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Cbo_clasificacionEspecifica.FormattingEnabled = true;
            this.Cbo_clasificacionEspecifica.Items.AddRange(new object[] {
            "Posturepedic",
            "Hybrid",
            "Conform",
            "World Luxury",
            "Mattress",
            "Extended ",
            "Life"});
            this.Cbo_clasificacionEspecifica.Location = new System.Drawing.Point(409, 46);
            this.Cbo_clasificacionEspecifica.Name = "Cbo_clasificacionEspecifica";
            this.Cbo_clasificacionEspecifica.Size = new System.Drawing.Size(223, 23);
            this.Cbo_clasificacionEspecifica.TabIndex = 321;
            this.Cbo_clasificacionEspecifica.SelectedIndexChanged += new System.EventHandler(this.Cbo_clasificacionEspecifica_SelectedIndexChanged);
            // 
            // Cbo_clasificacionGeneral
            // 
            this.Cbo_clasificacionGeneral.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Cbo_clasificacionGeneral.FormattingEnabled = true;
            this.Cbo_clasificacionGeneral.Items.AddRange(new object[] {
            "Posturepedic",
            "Hybrid",
            "Conform",
            "World Luxury",
            "Mattress",
            "Extended ",
            "Life"});
            this.Cbo_clasificacionGeneral.Location = new System.Drawing.Point(119, 46);
            this.Cbo_clasificacionGeneral.Name = "Cbo_clasificacionGeneral";
            this.Cbo_clasificacionGeneral.Size = new System.Drawing.Size(216, 23);
            this.Cbo_clasificacionGeneral.TabIndex = 317;
            this.Cbo_clasificacionGeneral.SelectedIndexChanged += new System.EventHandler(this.Cbo_clasificacionGeneral_SelectedIndexChanged);
            // 
            // Txt_clasificacion
            // 
            this.Txt_clasificacion.AutoSize = true;
            this.Txt_clasificacion.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Txt_clasificacion.ForeColor = System.Drawing.Color.Black;
            this.Txt_clasificacion.Location = new System.Drawing.Point(25, 46);
            this.Txt_clasificacion.Name = "Txt_clasificacion";
            this.Txt_clasificacion.Size = new System.Drawing.Size(88, 19);
            this.Txt_clasificacion.TabIndex = 325;
            this.Txt_clasificacion.Text = "Clasificación:";
            // 
            // Txt_productobuscado
            // 
            this.Txt_productobuscado.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Txt_productobuscado.Location = new System.Drawing.Point(121, 101);
            this.Txt_productobuscado.Name = "Txt_productobuscado";
            this.Txt_productobuscado.Size = new System.Drawing.Size(216, 22);
            this.Txt_productobuscado.TabIndex = 315;
            this.Txt_productobuscado.TextChanged += new System.EventHandler(this.Txt_productobuscado_TextChanged);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.White;
            this.Btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.Btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscar.Image")));
            this.Btn_buscar.Location = new System.Drawing.Point(343, 80);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(60, 60);
            this.Btn_buscar.TabIndex = 314;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txt_clasificacionInventario
            // 
            this.Txt_clasificacionInventario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_clasificacionInventario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_clasificacionInventario.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Txt_clasificacionInventario.Location = new System.Drawing.Point(119, 46);
            this.Txt_clasificacionInventario.Name = "Txt_clasificacionInventario";
            this.Txt_clasificacionInventario.Size = new System.Drawing.Size(216, 22);
            this.Txt_clasificacionInventario.TabIndex = 322;
            this.Txt_clasificacionInventario.Visible = false;
            // 
            // Txt_clasificacionEspecificaSeleccionada
            // 
            this.Txt_clasificacionEspecificaSeleccionada.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Txt_clasificacionEspecificaSeleccionada.Location = new System.Drawing.Point(409, 46);
            this.Txt_clasificacionEspecificaSeleccionada.Name = "Txt_clasificacionEspecificaSeleccionada";
            this.Txt_clasificacionEspecificaSeleccionada.Size = new System.Drawing.Size(223, 22);
            this.Txt_clasificacionEspecificaSeleccionada.TabIndex = 323;
            this.Txt_clasificacionEspecificaSeleccionada.Visible = false;
            // 
            // Dgv_combinado
            // 
            this.Dgv_combinado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_combinado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_combinado.Location = new System.Drawing.Point(51, 618);
            this.Dgv_combinado.Name = "Dgv_combinado";
            this.Dgv_combinado.Size = new System.Drawing.Size(925, 165);
            this.Dgv_combinado.TabIndex = 347;
            this.Dgv_combinado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_combinado_CellContentClick);
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_titulo.Location = new System.Drawing.Point(45, 594);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(61, 21);
            this.Txt_titulo.TabIndex = 348;
            this.Txt_titulo.Text = "Listas";
            // 
            // Txt_tituloLista
            // 
            this.Txt_tituloLista.AutoSize = true;
            this.Txt_tituloLista.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_tituloLista.Location = new System.Drawing.Point(519, 20);
            this.Txt_tituloLista.Name = "Txt_tituloLista";
            this.Txt_tituloLista.Size = new System.Drawing.Size(282, 21);
            this.Txt_tituloLista.TabIndex = 350;
            this.Txt_tituloLista.Text = "C R E A C I Ó N   D E   L I S T A";
            this.Txt_tituloLista.Click += new System.EventHandler(this.label4_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_actualizar.Image")));
            this.Btn_actualizar.Location = new System.Drawing.Point(1180, 618);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(60, 60);
            this.Btn_actualizar.TabIndex = 353;
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.Location = new System.Drawing.Point(1114, 618);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(60, 60);
            this.Btn_editar.TabIndex = 352;
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_cancelarLista
            // 
            this.Btn_cancelarLista.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelarLista.Image")));
            this.Btn_cancelarLista.Location = new System.Drawing.Point(1048, 618);
            this.Btn_cancelarLista.Name = "Btn_cancelarLista";
            this.Btn_cancelarLista.Size = new System.Drawing.Size(60, 60);
            this.Btn_cancelarLista.TabIndex = 351;
            this.Btn_cancelarLista.UseVisualStyleBackColor = true;
            this.Btn_cancelarLista.Click += new System.EventHandler(this.Btn_cancelarLista_Click);
            // 
            // Btn_crear
            // 
            this.Btn_crear.Image = ((System.Drawing.Image)(resources.GetObject("Btn_crear.Image")));
            this.Btn_crear.Location = new System.Drawing.Point(982, 618);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(60, 60);
            this.Btn_crear.TabIndex = 349;
            this.Btn_crear.UseVisualStyleBackColor = true;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.Location = new System.Drawing.Point(652, 552);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(60, 60);
            this.Btn_cancelar.TabIndex = 342;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_aceptar.Image")));
            this.Btn_aceptar.Location = new System.Drawing.Point(586, 552);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(60, 60);
            this.Btn_aceptar.TabIndex = 341;
            this.Btn_aceptar.UseVisualStyleBackColor = true;
            this.Btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // frm_ListadoPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1289, 811);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_cancelarLista);
            this.Controls.Add(this.Txt_tituloLista);
            this.Controls.Add(this.Btn_crear);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.Dgv_combinado);
            this.Controls.Add(this.Gpb_listaEncabezado);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_aceptar);
            this.Controls.Add(this.Dgv_detalleProductos);
            this.Controls.Add(this.Gbp_datos2);
            this.Controls.Add(this.Gpb_filtros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ListadoPrecios";
            this.Text = "Creación de Listas";
            this.Load += new System.EventHandler(this.frm_ListadoPrecios_Load);
            this.Gpb_listaEncabezado.ResumeLayout(false);
            this.Gpb_listaEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleProductos)).EndInit();
            this.Gbp_datos2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_seleccionados)).EndInit();
            this.Gpb_modo.ResumeLayout(false);
            this.Gpb_modo.PerformLayout();
            this.Gpb_filtros.ResumeLayout(false);
            this.Gpb_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_combinado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_listaEncabezado;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Lbl_identificacion;
        private System.Windows.Forms.ComboBox Cbo_tipoLista;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_aceptar;
        private System.Windows.Forms.DataGridView Dgv_detalleProductos;
        private System.Windows.Forms.GroupBox Gbp_datos2;
        private System.Windows.Forms.DataGridView Dgv_seleccionados;
        private System.Windows.Forms.GroupBox Gpb_modo;
        private System.Windows.Forms.Label Txt_aplicar;
        private System.Windows.Forms.TextBox Txt_porcentaje;
        private System.Windows.Forms.RadioButton Rdb_forzar;
        private System.Windows.Forms.RadioButton Rdb_precioventa;
        private System.Windows.Forms.RadioButton Rdb_costocompra;
        private System.Windows.Forms.Label Txt_precioforzado;
        private System.Windows.Forms.GroupBox Gpb_filtros;
        private System.Windows.Forms.Label Lbl_especifico;
        private System.Windows.Forms.Label Lbl_clasificaciones;
        private System.Windows.Forms.Label Txt_inventario;
        private System.Windows.Forms.TextBox Txt_clasificacionEspecificaSeleccionada;
        private System.Windows.Forms.Label Txt_busqueda;
        private System.Windows.Forms.ComboBox Cbo_clasificacionEspecifica;
        private System.Windows.Forms.TextBox Txt_clasificacionInventario;
        private System.Windows.Forms.ComboBox Cbo_clasificacionGeneral;
        private System.Windows.Forms.Label Txt_clasificacion;
        private System.Windows.Forms.TextBox Txt_productobuscado;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_aplicar;
        private System.Windows.Forms.DataGridView Dgv_combinado;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.Label Txt_tituloLista;
        private System.Windows.Forms.Button Btn_cancelarLista;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.TextBox Txt_forzado;
    }
}