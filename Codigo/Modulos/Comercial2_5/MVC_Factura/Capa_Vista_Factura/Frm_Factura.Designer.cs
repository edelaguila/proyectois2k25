
namespace Capa_Vista_Factura
{
    partial class Frm_Factura
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
            this.Gpb_Encabezado = new System.Windows.Forms.GroupBox();
            this.Cbo_nit = new System.Windows.Forms.ComboBox();
            this.Lbl_nit = new System.Windows.Forms.Label();
            this.Txt_IDEncab = new System.Windows.Forms.TextBox();
            this.Btn_cancelarE = new System.Windows.Forms.Button();
            this.Btn_insertarE = new System.Windows.Forms.Button();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Cbo_cliente = new System.Windows.Forms.ComboBox();
            this.Cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.Lbl_FechaVencimiento = new System.Windows.Forms.Label();
            this.Lbl_Clientes = new System.Windows.Forms.Label();
            this.Lbl_Vendedor = new System.Windows.Forms.Label();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Gpb_Detalle = new System.Windows.Forms.GroupBox();
            this.Cbo_metodoPago = new System.Windows.Forms.ComboBox();
            this.Lbl_metodoPago = new System.Windows.Forms.Label();
            this.Btn_insertarD = new System.Windows.Forms.Button();
            this.Btn_cancelarD = new System.Windows.Forms.Button();
            this.Cbo_encabezado = new System.Windows.Forms.ComboBox();
            this.Lbl_IdEncab = new System.Windows.Forms.Label();
            this.Txt_idDetalle = new System.Windows.Forms.TextBox();
            this.Lbl_IDdet = new System.Windows.Forms.Label();
            this.Cbo_IdCoti = new System.Windows.Forms.ComboBox();
            this.Lbl_IdCoti = new System.Windows.Forms.Label();
            this.Lbl_PrecioTot = new System.Windows.Forms.Label();
            this.Txt_precioTotal = new System.Windows.Forms.TextBox();
            this.Txt_subtotal = new System.Windows.Forms.TextBox();
            this.Lbl_iva = new System.Windows.Forms.Label();
            this.Txt_IVA = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Lbl_subtotal = new System.Windows.Forms.Label();
            this.Dgv_factura = new System.Windows.Forms.DataGridView();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Gpb_Encabezado.SuspendLayout();
            this.Gpb_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_factura)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_Encabezado
            // 
            this.Gpb_Encabezado.Controls.Add(this.Cbo_nit);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_nit);
            this.Gpb_Encabezado.Controls.Add(this.Txt_IDEncab);
            this.Gpb_Encabezado.Controls.Add(this.Btn_cancelarE);
            this.Gpb_Encabezado.Controls.Add(this.Btn_insertarE);
            this.Gpb_Encabezado.Controls.Add(this.Dtp_fecha);
            this.Gpb_Encabezado.Controls.Add(this.Cbo_cliente);
            this.Gpb_Encabezado.Controls.Add(this.Cbo_vendedor);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_FechaVencimiento);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_Clientes);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_Vendedor);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_ID);
            this.Gpb_Encabezado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Encabezado.Location = new System.Drawing.Point(83, 50);
            this.Gpb_Encabezado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gpb_Encabezado.Name = "Gpb_Encabezado";
            this.Gpb_Encabezado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gpb_Encabezado.Size = new System.Drawing.Size(980, 146);
            this.Gpb_Encabezado.TabIndex = 16;
            this.Gpb_Encabezado.TabStop = false;
            this.Gpb_Encabezado.Text = "Encabezado";
            // 
            // Cbo_nit
            // 
            this.Cbo_nit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_nit.FormattingEnabled = true;
            this.Cbo_nit.Location = new System.Drawing.Point(539, 91);
            this.Cbo_nit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_nit.Name = "Cbo_nit";
            this.Cbo_nit.Size = new System.Drawing.Size(160, 27);
            this.Cbo_nit.TabIndex = 31;
            // 
            // Lbl_nit
            // 
            this.Lbl_nit.AutoSize = true;
            this.Lbl_nit.Location = new System.Drawing.Point(440, 95);
            this.Lbl_nit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nit.Name = "Lbl_nit";
            this.Lbl_nit.Size = new System.Drawing.Size(35, 22);
            this.Lbl_nit.TabIndex = 30;
            this.Lbl_nit.Text = "Nit";
            // 
            // Txt_IDEncab
            // 
            this.Txt_IDEncab.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IDEncab.Location = new System.Drawing.Point(137, 38);
            this.Txt_IDEncab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_IDEncab.Name = "Txt_IDEncab";
            this.Txt_IDEncab.Size = new System.Drawing.Size(160, 26);
            this.Txt_IDEncab.TabIndex = 9;
            // 
            // Btn_cancelarE
            // 
            this.Btn_cancelarE.Location = new System.Drawing.Point(817, 89);
            this.Btn_cancelarE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_cancelarE.Name = "Btn_cancelarE";
            this.Btn_cancelarE.Size = new System.Drawing.Size(100, 28);
            this.Btn_cancelarE.TabIndex = 8;
            this.Btn_cancelarE.Text = "Cancelar";
            this.Btn_cancelarE.UseVisualStyleBackColor = true;
            // 
            // Btn_insertarE
            // 
            this.Btn_insertarE.Location = new System.Drawing.Point(817, 38);
            this.Btn_insertarE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_insertarE.Name = "Btn_insertarE";
            this.Btn_insertarE.Size = new System.Drawing.Size(100, 28);
            this.Btn_insertarE.TabIndex = 7;
            this.Btn_insertarE.Text = "Insertar";
            this.Btn_insertarE.UseVisualStyleBackColor = true;
            this.Btn_insertarE.Click += new System.EventHandler(this.Btn_insertarE_Click);
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha.Location = new System.Drawing.Point(433, 42);
            this.Dtp_fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(265, 26);
            this.Dtp_fecha.TabIndex = 6;
            // 
            // Cbo_cliente
            // 
            this.Cbo_cliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cliente.FormattingEnabled = true;
            this.Cbo_cliente.Location = new System.Drawing.Point(137, 112);
            this.Cbo_cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_cliente.Name = "Cbo_cliente";
            this.Cbo_cliente.Size = new System.Drawing.Size(160, 27);
            this.Cbo_cliente.TabIndex = 5;
            // 
            // Cbo_vendedor
            // 
            this.Cbo_vendedor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_vendedor.FormattingEnabled = true;
            this.Cbo_vendedor.Location = new System.Drawing.Point(137, 73);
            this.Cbo_vendedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_vendedor.Name = "Cbo_vendedor";
            this.Cbo_vendedor.Size = new System.Drawing.Size(160, 27);
            this.Cbo_vendedor.TabIndex = 4;
            // 
            // Lbl_FechaVencimiento
            // 
            this.Lbl_FechaVencimiento.AutoSize = true;
            this.Lbl_FechaVencimiento.Location = new System.Drawing.Point(489, 20);
            this.Lbl_FechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_FechaVencimiento.Name = "Lbl_FechaVencimiento";
            this.Lbl_FechaVencimiento.Size = new System.Drawing.Size(159, 22);
            this.Lbl_FechaVencimiento.TabIndex = 3;
            this.Lbl_FechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // Lbl_Clientes
            // 
            this.Lbl_Clientes.AutoSize = true;
            this.Lbl_Clientes.Location = new System.Drawing.Point(39, 116);
            this.Lbl_Clientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Clientes.Name = "Lbl_Clientes";
            this.Lbl_Clientes.Size = new System.Drawing.Size(67, 22);
            this.Lbl_Clientes.TabIndex = 2;
            this.Lbl_Clientes.Text = "Cliente";
            // 
            // Lbl_Vendedor
            // 
            this.Lbl_Vendedor.AutoSize = true;
            this.Lbl_Vendedor.Location = new System.Drawing.Point(39, 73);
            this.Lbl_Vendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Vendedor.Name = "Lbl_Vendedor";
            this.Lbl_Vendedor.Size = new System.Drawing.Size(85, 22);
            this.Lbl_Vendedor.TabIndex = 1;
            this.Lbl_Vendedor.Text = "Vendedor";
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(39, 38);
            this.Lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(30, 22);
            this.Lbl_ID.TabIndex = 0;
            this.Lbl_ID.Text = "ID";
            // 
            // Gpb_Detalle
            // 
            this.Gpb_Detalle.Controls.Add(this.Cbo_metodoPago);
            this.Gpb_Detalle.Controls.Add(this.Lbl_metodoPago);
            this.Gpb_Detalle.Controls.Add(this.Btn_insertarD);
            this.Gpb_Detalle.Controls.Add(this.Btn_cancelarD);
            this.Gpb_Detalle.Controls.Add(this.Cbo_encabezado);
            this.Gpb_Detalle.Controls.Add(this.Lbl_IdEncab);
            this.Gpb_Detalle.Controls.Add(this.Txt_idDetalle);
            this.Gpb_Detalle.Controls.Add(this.Lbl_IDdet);
            this.Gpb_Detalle.Controls.Add(this.Cbo_IdCoti);
            this.Gpb_Detalle.Controls.Add(this.Lbl_IdCoti);
            this.Gpb_Detalle.Controls.Add(this.Lbl_PrecioTot);
            this.Gpb_Detalle.Controls.Add(this.Txt_precioTotal);
            this.Gpb_Detalle.Controls.Add(this.Txt_subtotal);
            this.Gpb_Detalle.Controls.Add(this.Lbl_iva);
            this.Gpb_Detalle.Controls.Add(this.Txt_IVA);
            this.Gpb_Detalle.Controls.Add(this.label14);
            this.Gpb_Detalle.Controls.Add(this.Lbl_subtotal);
            this.Gpb_Detalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Detalle.Location = new System.Drawing.Point(83, 206);
            this.Gpb_Detalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gpb_Detalle.Name = "Gpb_Detalle";
            this.Gpb_Detalle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gpb_Detalle.Size = new System.Drawing.Size(980, 209);
            this.Gpb_Detalle.TabIndex = 15;
            this.Gpb_Detalle.TabStop = false;
            this.Gpb_Detalle.Text = "Detalle";
            // 
            // Cbo_metodoPago
            // 
            this.Cbo_metodoPago.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_metodoPago.FormattingEnabled = true;
            this.Cbo_metodoPago.Location = new System.Drawing.Point(217, 170);
            this.Cbo_metodoPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_metodoPago.Name = "Cbo_metodoPago";
            this.Cbo_metodoPago.Size = new System.Drawing.Size(160, 27);
            this.Cbo_metodoPago.TabIndex = 31;
            // 
            // Lbl_metodoPago
            // 
            this.Lbl_metodoPago.AutoSize = true;
            this.Lbl_metodoPago.Location = new System.Drawing.Point(60, 171);
            this.Lbl_metodoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_metodoPago.Name = "Lbl_metodoPago";
            this.Lbl_metodoPago.Size = new System.Drawing.Size(138, 22);
            this.Lbl_metodoPago.TabIndex = 30;
            this.Lbl_metodoPago.Text = "Metodo de pago";
            // 
            // Btn_insertarD
            // 
            this.Btn_insertarD.Location = new System.Drawing.Point(817, 57);
            this.Btn_insertarD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_insertarD.Name = "Btn_insertarD";
            this.Btn_insertarD.Size = new System.Drawing.Size(100, 28);
            this.Btn_insertarD.TabIndex = 26;
            this.Btn_insertarD.Text = "Insertar";
            this.Btn_insertarD.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelarD
            // 
            this.Btn_cancelarD.Location = new System.Drawing.Point(817, 129);
            this.Btn_cancelarD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_cancelarD.Name = "Btn_cancelarD";
            this.Btn_cancelarD.Size = new System.Drawing.Size(100, 28);
            this.Btn_cancelarD.TabIndex = 27;
            this.Btn_cancelarD.Text = "Cancelar";
            this.Btn_cancelarD.UseVisualStyleBackColor = true;
            // 
            // Cbo_encabezado
            // 
            this.Cbo_encabezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_encabezado.FormattingEnabled = true;
            this.Cbo_encabezado.Location = new System.Drawing.Point(220, 89);
            this.Cbo_encabezado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_encabezado.Name = "Cbo_encabezado";
            this.Cbo_encabezado.Size = new System.Drawing.Size(160, 27);
            this.Cbo_encabezado.TabIndex = 25;
            // 
            // Lbl_IdEncab
            // 
            this.Lbl_IdEncab.AutoSize = true;
            this.Lbl_IdEncab.Location = new System.Drawing.Point(60, 98);
            this.Lbl_IdEncab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IdEncab.Name = "Lbl_IdEncab";
            this.Lbl_IdEncab.Size = new System.Drawing.Size(130, 22);
            this.Lbl_IdEncab.TabIndex = 24;
            this.Lbl_IdEncab.Text = "ID Encabezado";
            // 
            // Txt_idDetalle
            // 
            this.Txt_idDetalle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idDetalle.Location = new System.Drawing.Point(220, 46);
            this.Txt_idDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_idDetalle.Name = "Txt_idDetalle";
            this.Txt_idDetalle.Size = new System.Drawing.Size(160, 26);
            this.Txt_idDetalle.TabIndex = 23;
            // 
            // Lbl_IDdet
            // 
            this.Lbl_IDdet.AutoSize = true;
            this.Lbl_IDdet.Location = new System.Drawing.Point(60, 55);
            this.Lbl_IDdet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IDdet.Name = "Lbl_IDdet";
            this.Lbl_IDdet.Size = new System.Drawing.Size(30, 22);
            this.Lbl_IDdet.TabIndex = 22;
            this.Lbl_IDdet.Text = "ID";
            // 
            // Cbo_IdCoti
            // 
            this.Cbo_IdCoti.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_IdCoti.FormattingEnabled = true;
            this.Cbo_IdCoti.Location = new System.Drawing.Point(217, 129);
            this.Cbo_IdCoti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_IdCoti.Name = "Cbo_IdCoti";
            this.Cbo_IdCoti.Size = new System.Drawing.Size(160, 27);
            this.Cbo_IdCoti.TabIndex = 20;
            // 
            // Lbl_IdCoti
            // 
            this.Lbl_IdCoti.AutoSize = true;
            this.Lbl_IdCoti.Location = new System.Drawing.Point(60, 134);
            this.Lbl_IdCoti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IdCoti.Name = "Lbl_IdCoti";
            this.Lbl_IdCoti.Size = new System.Drawing.Size(120, 22);
            this.Lbl_IdCoti.TabIndex = 19;
            this.Lbl_IdCoti.Text = "ID Cotización";
            // 
            // Lbl_PrecioTot
            // 
            this.Lbl_PrecioTot.AutoSize = true;
            this.Lbl_PrecioTot.Location = new System.Drawing.Point(452, 132);
            this.Lbl_PrecioTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_PrecioTot.Name = "Lbl_PrecioTot";
            this.Lbl_PrecioTot.Size = new System.Drawing.Size(108, 22);
            this.Lbl_PrecioTot.TabIndex = 21;
            this.Lbl_PrecioTot.Text = "Precio Total";
            // 
            // Txt_precioTotal
            // 
            this.Txt_precioTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precioTotal.Location = new System.Drawing.Point(577, 132);
            this.Txt_precioTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_precioTotal.Name = "Txt_precioTotal";
            this.Txt_precioTotal.Size = new System.Drawing.Size(160, 26);
            this.Txt_precioTotal.TabIndex = 20;
            // 
            // Txt_subtotal
            // 
            this.Txt_subtotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_subtotal.Location = new System.Drawing.Point(577, 48);
            this.Txt_subtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_subtotal.Name = "Txt_subtotal";
            this.Txt_subtotal.Size = new System.Drawing.Size(160, 26);
            this.Txt_subtotal.TabIndex = 19;
            // 
            // Lbl_iva
            // 
            this.Lbl_iva.AutoSize = true;
            this.Lbl_iva.Location = new System.Drawing.Point(451, 96);
            this.Lbl_iva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_iva.Name = "Lbl_iva";
            this.Lbl_iva.Size = new System.Drawing.Size(40, 22);
            this.Lbl_iva.TabIndex = 16;
            this.Lbl_iva.Text = "IVA";
            // 
            // Txt_IVA
            // 
            this.Txt_IVA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IVA.Location = new System.Drawing.Point(577, 87);
            this.Txt_IVA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_IVA.Name = "Txt_IVA";
            this.Txt_IVA.Size = new System.Drawing.Size(160, 26);
            this.Txt_IVA.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 98);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 22);
            this.label14.TabIndex = 10;
            // 
            // Lbl_subtotal
            // 
            this.Lbl_subtotal.AutoSize = true;
            this.Lbl_subtotal.Location = new System.Drawing.Point(451, 57);
            this.Lbl_subtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_subtotal.Name = "Lbl_subtotal";
            this.Lbl_subtotal.Size = new System.Drawing.Size(75, 22);
            this.Lbl_subtotal.TabIndex = 9;
            this.Lbl_subtotal.Text = "Subtotal";
            // 
            // Dgv_factura
            // 
            this.Dgv_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_factura.Location = new System.Drawing.Point(83, 422);
            this.Dgv_factura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgv_factura.Name = "Dgv_factura";
            this.Dgv_factura.RowHeadersWidth = 51;
            this.Dgv_factura.Size = new System.Drawing.Size(980, 174);
            this.Dgv_factura.TabIndex = 14;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(465, 11);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(122, 36);
            this.Lbl_titulo.TabIndex = 13;
            this.Lbl_titulo.Text = "Factura";
            // 
            // Frm_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1141, 609);
            this.Controls.Add(this.Gpb_Encabezado);
            this.Controls.Add(this.Gpb_Detalle);
            this.Controls.Add(this.Dgv_factura);
            this.Controls.Add(this.Lbl_titulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Factura";
            this.Text = "Frm_Factura";
            this.Gpb_Encabezado.ResumeLayout(false);
            this.Gpb_Encabezado.PerformLayout();
            this.Gpb_Detalle.ResumeLayout(false);
            this.Gpb_Detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_factura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Encabezado;
        private System.Windows.Forms.ComboBox Cbo_nit;
        private System.Windows.Forms.Label Lbl_nit;
        private System.Windows.Forms.TextBox Txt_IDEncab;
        private System.Windows.Forms.Button Btn_cancelarE;
        private System.Windows.Forms.Button Btn_insertarE;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.ComboBox Cbo_cliente;
        private System.Windows.Forms.ComboBox Cbo_vendedor;
        private System.Windows.Forms.Label Lbl_FechaVencimiento;
        private System.Windows.Forms.Label Lbl_Clientes;
        private System.Windows.Forms.Label Lbl_Vendedor;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.GroupBox Gpb_Detalle;
        private System.Windows.Forms.ComboBox Cbo_metodoPago;
        private System.Windows.Forms.Label Lbl_metodoPago;
        private System.Windows.Forms.Button Btn_insertarD;
        private System.Windows.Forms.Button Btn_cancelarD;
        private System.Windows.Forms.ComboBox Cbo_encabezado;
        private System.Windows.Forms.Label Lbl_IdEncab;
        private System.Windows.Forms.TextBox Txt_idDetalle;
        private System.Windows.Forms.Label Lbl_IDdet;
        private System.Windows.Forms.ComboBox Cbo_IdCoti;
        private System.Windows.Forms.Label Lbl_IdCoti;
        private System.Windows.Forms.Label Lbl_PrecioTot;
        private System.Windows.Forms.TextBox Txt_precioTotal;
        private System.Windows.Forms.TextBox Txt_subtotal;
        private System.Windows.Forms.Label Lbl_iva;
        private System.Windows.Forms.TextBox Txt_IVA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Lbl_subtotal;
        private System.Windows.Forms.DataGridView Dgv_factura;
        private System.Windows.Forms.Label Lbl_titulo;
    }
}