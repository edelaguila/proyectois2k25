
namespace CapaVista_AndresVeron
{
    partial class frm_transaccion_clientes
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
            this.dgv_transaccion_cliente = new System.Windows.Forms.DataGridView();
            this.txt_Idtrans = new System.Windows.Forms.TextBox();
            this.txt_transCliente = new System.Windows.Forms.TextBox();
            this.txt_transmonto = new System.Windows.Forms.TextBox();
            this.txt_monedatrans = new System.Windows.Forms.TextBox();
            this.lbl_idtransclientes = new System.Windows.Forms.Label();
            this.lbl_id_transcl = new System.Windows.Forms.Label();
            this.lbl_montotrans = new System.Windows.Forms.Label();
            this.lbl_moneda_transcl = new System.Windows.Forms.Label();
            this.lbl_estado_transcl = new System.Windows.Forms.Label();
            this.lbl_fecha_transcl = new System.Windows.Forms.Label();
            this.txt_fechatrans = new System.Windows.Forms.TextBox();
            this.txt_estadotrans = new System.Windows.Forms.TextBox();
            this.gpb_transaccion_cliente = new System.Windows.Forms.GroupBox();
            this.txt_trans_cuentacl = new System.Windows.Forms.TextBox();
            this.txt_fac_transcl = new System.Windows.Forms.TextBox();
            this.txt_tipo_transcl = new System.Windows.Forms.TextBox();
            this.lbl_factura_transcl = new System.Windows.Forms.Label();
            this.lbl_tipotranscl = new System.Windows.Forms.Label();
            this.lbl_idcuenta_transcl = new System.Windows.Forms.Label();
            this.gpb_btns_trans = new System.Windows.Forms.GroupBox();
            this.m_guardar = new System.Windows.Forms.ToolTip(this.components);
            this.m_Eliminar = new System.Windows.Forms.ToolTip(this.components);
            this.m_Actu_cliente = new System.Windows.Forms.ToolTip(this.components);
            this.m_Buscar = new System.Windows.Forms.ToolTip(this.components);
            this.m_Reporte = new System.Windows.Forms.ToolTip(this.components);
            this.m_SalirTrans = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_titulo_transclientes = new System.Windows.Forms.Label();
            this.m_AyudasTransCliente = new System.Windows.Forms.ToolTip(this.components);
            this.btn_ayudatransclientes = new System.Windows.Forms.Button();
            this.btn_salirtransaclientes = new System.Windows.Forms.Button();
            this.btn_eliminar_trans = new System.Windows.Forms.Button();
            this.btn_guardar_trans = new System.Windows.Forms.Button();
            this.btn_buscar_trans = new System.Windows.Forms.Button();
            this.btn_editar_trans = new System.Windows.Forms.Button();
            this.btn_reportetrans_cl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaccion_cliente)).BeginInit();
            this.gpb_transaccion_cliente.SuspendLayout();
            this.gpb_btns_trans.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_transaccion_cliente
            // 
            this.dgv_transaccion_cliente.ColumnHeadersHeight = 29;
            this.dgv_transaccion_cliente.Location = new System.Drawing.Point(9, 193);
            this.dgv_transaccion_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_transaccion_cliente.Name = "dgv_transaccion_cliente";
            this.dgv_transaccion_cliente.RowHeadersWidth = 51;
            this.dgv_transaccion_cliente.Size = new System.Drawing.Size(280, 226);
            this.dgv_transaccion_cliente.TabIndex = 56;
            this.dgv_transaccion_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_transaccion_cliente_CellContentClick);
            // 
            // txt_Idtrans
            // 
            this.txt_Idtrans.Location = new System.Drawing.Point(97, 13);
            this.txt_Idtrans.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Idtrans.Name = "txt_Idtrans";
            this.txt_Idtrans.Size = new System.Drawing.Size(133, 20);
            this.txt_Idtrans.TabIndex = 29;
            // 
            // txt_transCliente
            // 
            this.txt_transCliente.Location = new System.Drawing.Point(97, 63);
            this.txt_transCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_transCliente.Name = "txt_transCliente";
            this.txt_transCliente.Size = new System.Drawing.Size(133, 20);
            this.txt_transCliente.TabIndex = 30;
            // 
            // txt_transmonto
            // 
            this.txt_transmonto.Location = new System.Drawing.Point(97, 110);
            this.txt_transmonto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_transmonto.Name = "txt_transmonto";
            this.txt_transmonto.Size = new System.Drawing.Size(133, 20);
            this.txt_transmonto.TabIndex = 31;
            // 
            // txt_monedatrans
            // 
            this.txt_monedatrans.Location = new System.Drawing.Point(97, 158);
            this.txt_monedatrans.Margin = new System.Windows.Forms.Padding(2);
            this.txt_monedatrans.Name = "txt_monedatrans";
            this.txt_monedatrans.Size = new System.Drawing.Size(133, 20);
            this.txt_monedatrans.TabIndex = 42;
            // 
            // lbl_idtransclientes
            // 
            this.lbl_idtransclientes.AutoSize = true;
            this.lbl_idtransclientes.Location = new System.Drawing.Point(21, 13);
            this.lbl_idtransclientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idtransclientes.Name = "lbl_idtransclientes";
            this.lbl_idtransclientes.Size = new System.Drawing.Size(74, 13);
            this.lbl_idtransclientes.TabIndex = 43;
            this.lbl_idtransclientes.Text = "ID Trasaccion";
            // 
            // lbl_id_transcl
            // 
            this.lbl_id_transcl.AutoSize = true;
            this.lbl_id_transcl.Location = new System.Drawing.Point(21, 63);
            this.lbl_id_transcl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id_transcl.Name = "lbl_id_transcl";
            this.lbl_id_transcl.Size = new System.Drawing.Size(58, 13);
            this.lbl_id_transcl.TabIndex = 44;
            this.lbl_id_transcl.Text = "ID Clientes";
            // 
            // lbl_montotrans
            // 
            this.lbl_montotrans.AutoSize = true;
            this.lbl_montotrans.Location = new System.Drawing.Point(34, 110);
            this.lbl_montotrans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_montotrans.Name = "lbl_montotrans";
            this.lbl_montotrans.Size = new System.Drawing.Size(37, 13);
            this.lbl_montotrans.TabIndex = 45;
            this.lbl_montotrans.Text = "Monto";
            // 
            // lbl_moneda_transcl
            // 
            this.lbl_moneda_transcl.AutoSize = true;
            this.lbl_moneda_transcl.Location = new System.Drawing.Point(34, 158);
            this.lbl_moneda_transcl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_moneda_transcl.Name = "lbl_moneda_transcl";
            this.lbl_moneda_transcl.Size = new System.Drawing.Size(46, 13);
            this.lbl_moneda_transcl.TabIndex = 48;
            this.lbl_moneda_transcl.Text = "Moneda";
            // 
            // lbl_estado_transcl
            // 
            this.lbl_estado_transcl.AutoSize = true;
            this.lbl_estado_transcl.Location = new System.Drawing.Point(276, 17);
            this.lbl_estado_transcl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_estado_transcl.Name = "lbl_estado_transcl";
            this.lbl_estado_transcl.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado_transcl.TabIndex = 50;
            this.lbl_estado_transcl.Text = "Estado";
            // 
            // lbl_fecha_transcl
            // 
            this.lbl_fecha_transcl.AutoSize = true;
            this.lbl_fecha_transcl.Location = new System.Drawing.Point(34, 210);
            this.lbl_fecha_transcl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fecha_transcl.Name = "lbl_fecha_transcl";
            this.lbl_fecha_transcl.Size = new System.Drawing.Size(37, 13);
            this.lbl_fecha_transcl.TabIndex = 53;
            this.lbl_fecha_transcl.Text = "Fecha";
            // 
            // txt_fechatrans
            // 
            this.txt_fechatrans.Location = new System.Drawing.Point(97, 210);
            this.txt_fechatrans.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fechatrans.Name = "txt_fechatrans";
            this.txt_fechatrans.Size = new System.Drawing.Size(133, 20);
            this.txt_fechatrans.TabIndex = 54;
            // 
            // txt_estadotrans
            // 
            this.txt_estadotrans.Location = new System.Drawing.Point(320, 13);
            this.txt_estadotrans.Margin = new System.Windows.Forms.Padding(2);
            this.txt_estadotrans.Name = "txt_estadotrans";
            this.txt_estadotrans.Size = new System.Drawing.Size(133, 20);
            this.txt_estadotrans.TabIndex = 55;
            // 
            // gpb_transaccion_cliente
            // 
            this.gpb_transaccion_cliente.Controls.Add(this.txt_trans_cuentacl);
            this.gpb_transaccion_cliente.Controls.Add(this.txt_fac_transcl);
            this.gpb_transaccion_cliente.Controls.Add(this.txt_tipo_transcl);
            this.gpb_transaccion_cliente.Controls.Add(this.lbl_factura_transcl);
            this.gpb_transaccion_cliente.Controls.Add(this.lbl_tipotranscl);
            this.gpb_transaccion_cliente.Controls.Add(this.lbl_idcuenta_transcl);
            this.gpb_transaccion_cliente.Controls.Add(this.txt_estadotrans);
            this.gpb_transaccion_cliente.Controls.Add(this.txt_fechatrans);
            this.gpb_transaccion_cliente.Controls.Add(this.btn_reportetrans_cl);
            this.gpb_transaccion_cliente.Controls.Add(this.lbl_fecha_transcl);
            this.gpb_transaccion_cliente.Controls.Add(this.lbl_estado_transcl);
            this.gpb_transaccion_cliente.Controls.Add(this.lbl_moneda_transcl);
            this.gpb_transaccion_cliente.Controls.Add(this.lbl_montotrans);
            this.gpb_transaccion_cliente.Controls.Add(this.lbl_id_transcl);
            this.gpb_transaccion_cliente.Controls.Add(this.lbl_idtransclientes);
            this.gpb_transaccion_cliente.Controls.Add(this.txt_monedatrans);
            this.gpb_transaccion_cliente.Controls.Add(this.txt_transmonto);
            this.gpb_transaccion_cliente.Controls.Add(this.txt_transCliente);
            this.gpb_transaccion_cliente.Controls.Add(this.txt_Idtrans);
            this.gpb_transaccion_cliente.Location = new System.Drawing.Point(315, 162);
            this.gpb_transaccion_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_transaccion_cliente.Name = "gpb_transaccion_cliente";
            this.gpb_transaccion_cliente.Padding = new System.Windows.Forms.Padding(2);
            this.gpb_transaccion_cliente.Size = new System.Drawing.Size(486, 258);
            this.gpb_transaccion_cliente.TabIndex = 58;
            this.gpb_transaccion_cliente.TabStop = false;
            this.gpb_transaccion_cliente.Text = "Ingreso de Registros";
            // 
            // txt_trans_cuentacl
            // 
            this.txt_trans_cuentacl.Location = new System.Drawing.Point(320, 158);
            this.txt_trans_cuentacl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_trans_cuentacl.Name = "txt_trans_cuentacl";
            this.txt_trans_cuentacl.Size = new System.Drawing.Size(133, 20);
            this.txt_trans_cuentacl.TabIndex = 63;
            // 
            // txt_fac_transcl
            // 
            this.txt_fac_transcl.Location = new System.Drawing.Point(320, 110);
            this.txt_fac_transcl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fac_transcl.Name = "txt_fac_transcl";
            this.txt_fac_transcl.Size = new System.Drawing.Size(133, 20);
            this.txt_fac_transcl.TabIndex = 62;
            this.txt_fac_transcl.TextChanged += new System.EventHandler(this.txt_fac_transcl_TextChanged);
            // 
            // txt_tipo_transcl
            // 
            this.txt_tipo_transcl.Location = new System.Drawing.Point(320, 63);
            this.txt_tipo_transcl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tipo_transcl.Name = "txt_tipo_transcl";
            this.txt_tipo_transcl.Size = new System.Drawing.Size(133, 20);
            this.txt_tipo_transcl.TabIndex = 61;
            // 
            // lbl_factura_transcl
            // 
            this.lbl_factura_transcl.AutoSize = true;
            this.lbl_factura_transcl.Location = new System.Drawing.Point(272, 112);
            this.lbl_factura_transcl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_factura_transcl.Name = "lbl_factura_transcl";
            this.lbl_factura_transcl.Size = new System.Drawing.Size(43, 13);
            this.lbl_factura_transcl.TabIndex = 60;
            this.lbl_factura_transcl.Text = "Factura";
            // 
            // lbl_tipotranscl
            // 
            this.lbl_tipotranscl.AutoSize = true;
            this.lbl_tipotranscl.Location = new System.Drawing.Point(276, 63);
            this.lbl_tipotranscl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tipotranscl.Name = "lbl_tipotranscl";
            this.lbl_tipotranscl.Size = new System.Drawing.Size(28, 13);
            this.lbl_tipotranscl.TabIndex = 59;
            this.lbl_tipotranscl.Text = "Tipo";
            // 
            // lbl_idcuenta_transcl
            // 
            this.lbl_idcuenta_transcl.AutoSize = true;
            this.lbl_idcuenta_transcl.Location = new System.Drawing.Point(272, 158);
            this.lbl_idcuenta_transcl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idcuenta_transcl.Name = "lbl_idcuenta_transcl";
            this.lbl_idcuenta_transcl.Size = new System.Drawing.Size(44, 13);
            this.lbl_idcuenta_transcl.TabIndex = 58;
            this.lbl_idcuenta_transcl.Text = " Cuenta";
            // 
            // gpb_btns_trans
            // 
            this.gpb_btns_trans.Controls.Add(this.btn_eliminar_trans);
            this.gpb_btns_trans.Controls.Add(this.btn_guardar_trans);
            this.gpb_btns_trans.Controls.Add(this.btn_buscar_trans);
            this.gpb_btns_trans.Controls.Add(this.btn_editar_trans);
            this.gpb_btns_trans.Location = new System.Drawing.Point(8, 105);
            this.gpb_btns_trans.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_btns_trans.Name = "gpb_btns_trans";
            this.gpb_btns_trans.Padding = new System.Windows.Forms.Padding(2);
            this.gpb_btns_trans.Size = new System.Drawing.Size(256, 76);
            this.gpb_btns_trans.TabIndex = 59;
            this.gpb_btns_trans.TabStop = false;
            // 
            // lbl_titulo_transclientes
            // 
            this.lbl_titulo_transclientes.AutoSize = true;
            this.lbl_titulo_transclientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_transclientes.Location = new System.Drawing.Point(235, 13);
            this.lbl_titulo_transclientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo_transclientes.Name = "lbl_titulo_transclientes";
            this.lbl_titulo_transclientes.Size = new System.Drawing.Size(353, 37);
            this.lbl_titulo_transclientes.TabIndex = 61;
            this.lbl_titulo_transclientes.Text = "Transacción Clientes ";
            // 
            // btn_ayudatransclientes
            // 
            this.btn_ayudatransclientes.BackColor = System.Drawing.Color.Transparent;
            this.btn_ayudatransclientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ayudatransclientes.Image = global::CapaVista_AndresVeron.Properties.Resources.preguntas;
            this.btn_ayudatransclientes.Location = new System.Drawing.Point(8, 10);
            this.btn_ayudatransclientes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ayudatransclientes.Name = "btn_ayudatransclientes";
            this.btn_ayudatransclientes.Size = new System.Drawing.Size(47, 49);
            this.btn_ayudatransclientes.TabIndex = 62;
            this.m_SalirTrans.SetToolTip(this.btn_ayudatransclientes, "\r\n");
            this.m_AyudasTransCliente.SetToolTip(this.btn_ayudatransclientes, "Ayuda Transacción Clientes\r\n");
            this.btn_ayudatransclientes.UseVisualStyleBackColor = false;
            this.btn_ayudatransclientes.Click += new System.EventHandler(this.btn_ayudatransclientes_Click);
            // 
            // btn_salirtransaclientes
            // 
            this.btn_salirtransaclientes.BackColor = System.Drawing.Color.Transparent;
            this.btn_salirtransaclientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salirtransaclientes.Image = global::CapaVista_AndresVeron.Properties.Resources.cerrar_sesion;
            this.btn_salirtransaclientes.Location = new System.Drawing.Point(722, 10);
            this.btn_salirtransaclientes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salirtransaclientes.Name = "btn_salirtransaclientes";
            this.btn_salirtransaclientes.Size = new System.Drawing.Size(47, 49);
            this.btn_salirtransaclientes.TabIndex = 60;
            this.m_SalirTrans.SetToolTip(this.btn_salirtransaclientes, "Salir de Transacciones Clientes\r\n");
            this.btn_salirtransaclientes.UseVisualStyleBackColor = false;
            this.btn_salirtransaclientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_eliminar_trans
            // 
            this.btn_eliminar_trans.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar_trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar_trans.Image = global::CapaVista_AndresVeron.Properties.Resources.borrar;
            this.btn_eliminar_trans.Location = new System.Drawing.Point(70, 10);
            this.btn_eliminar_trans.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar_trans.Name = "btn_eliminar_trans";
            this.btn_eliminar_trans.Size = new System.Drawing.Size(54, 54);
            this.btn_eliminar_trans.TabIndex = 38;
            this.m_Eliminar.SetToolTip(this.btn_eliminar_trans, "Eliminar Transacción ");
            this.btn_eliminar_trans.UseVisualStyleBackColor = false;
            this.btn_eliminar_trans.Click += new System.EventHandler(this.btn_eliminar_trans_Click);
            // 
            // btn_guardar_trans
            // 
            this.btn_guardar_trans.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar_trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar_trans.Image = global::CapaVista_AndresVeron.Properties.Resources.ahorrar__1_;
            this.btn_guardar_trans.Location = new System.Drawing.Point(11, 10);
            this.btn_guardar_trans.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar_trans.Name = "btn_guardar_trans";
            this.btn_guardar_trans.Size = new System.Drawing.Size(54, 54);
            this.btn_guardar_trans.TabIndex = 37;
            this.m_guardar.SetToolTip(this.btn_guardar_trans, "Guardar Transacción \r\n");
            this.btn_guardar_trans.UseVisualStyleBackColor = false;
            this.btn_guardar_trans.Click += new System.EventHandler(this.btn_guardar_trans_Click);
            // 
            // btn_buscar_trans
            // 
            this.btn_buscar_trans.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar_trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar_trans.Image = global::CapaVista_AndresVeron.Properties.Resources.agregar_archivo;
            this.btn_buscar_trans.Location = new System.Drawing.Point(187, 10);
            this.btn_buscar_trans.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar_trans.Name = "btn_buscar_trans";
            this.btn_buscar_trans.Size = new System.Drawing.Size(54, 54);
            this.btn_buscar_trans.TabIndex = 27;
            this.m_Buscar.SetToolTip(this.btn_buscar_trans, "Buscar Transacción \r\n");
            this.btn_buscar_trans.UseVisualStyleBackColor = false;
            this.btn_buscar_trans.Click += new System.EventHandler(this.btn_buscar_trans_Click);
            // 
            // btn_editar_trans
            // 
            this.btn_editar_trans.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar_trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar_trans.Image = global::CapaVista_AndresVeron.Properties.Resources.convenio__1_;
            this.btn_editar_trans.Location = new System.Drawing.Point(128, 10);
            this.btn_editar_trans.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editar_trans.Name = "btn_editar_trans";
            this.btn_editar_trans.Size = new System.Drawing.Size(54, 54);
            this.btn_editar_trans.TabIndex = 36;
            this.m_Actu_cliente.SetToolTip(this.btn_editar_trans, "Actualizar Transacción \r\n");
            this.btn_editar_trans.UseVisualStyleBackColor = false;
            this.btn_editar_trans.Click += new System.EventHandler(this.btn_editar_trans_Click);
            // 
            // btn_reportetrans_cl
            // 
            this.btn_reportetrans_cl.BackColor = System.Drawing.Color.Transparent;
            this.btn_reportetrans_cl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reportetrans_cl.Image = global::CapaVista_AndresVeron.Properties.Resources.reporte2;
            this.btn_reportetrans_cl.Location = new System.Drawing.Point(418, 199);
            this.btn_reportetrans_cl.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reportetrans_cl.Name = "btn_reportetrans_cl";
            this.btn_reportetrans_cl.Size = new System.Drawing.Size(54, 54);
            this.btn_reportetrans_cl.TabIndex = 57;
            this.m_Reporte.SetToolTip(this.btn_reportetrans_cl, "Reporte Transacción");
            this.btn_reportetrans_cl.UseVisualStyleBackColor = false;
            this.btn_reportetrans_cl.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // frm_transaccion_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(828, 437);
            this.Controls.Add(this.btn_ayudatransclientes);
            this.Controls.Add(this.lbl_titulo_transclientes);
            this.Controls.Add(this.btn_salirtransaclientes);
            this.Controls.Add(this.gpb_btns_trans);
            this.Controls.Add(this.gpb_transaccion_cliente);
            this.Controls.Add(this.dgv_transaccion_cliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_transaccion_clientes";
            this.Text = "frm_transaccion_clientes";
            this.Load += new System.EventHandler(this.frm_transaccion_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaccion_cliente)).EndInit();
            this.gpb_transaccion_cliente.ResumeLayout(false);
            this.gpb_transaccion_cliente.PerformLayout();
            this.gpb_btns_trans.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_buscar_trans;
        private System.Windows.Forms.DataGridView dgv_transaccion_cliente;
        private System.Windows.Forms.TextBox txt_Idtrans;
        private System.Windows.Forms.TextBox txt_transCliente;
        private System.Windows.Forms.TextBox txt_transmonto;
        private System.Windows.Forms.Button btn_editar_trans;
        private System.Windows.Forms.Button btn_guardar_trans;
        private System.Windows.Forms.Button btn_eliminar_trans;
        private System.Windows.Forms.TextBox txt_monedatrans;
        private System.Windows.Forms.Label lbl_idtransclientes;
        private System.Windows.Forms.Label lbl_id_transcl;
        private System.Windows.Forms.Label lbl_montotrans;
        private System.Windows.Forms.Label lbl_moneda_transcl;
        private System.Windows.Forms.Label lbl_estado_transcl;
        private System.Windows.Forms.Label lbl_fecha_transcl;
        private System.Windows.Forms.TextBox txt_fechatrans;
        private System.Windows.Forms.TextBox txt_estadotrans;
        private System.Windows.Forms.Button btn_reportetrans_cl;
        private System.Windows.Forms.GroupBox gpb_transaccion_cliente;
        private System.Windows.Forms.GroupBox gpb_btns_trans;
        private System.Windows.Forms.ToolTip m_Buscar;
        private System.Windows.Forms.ToolTip m_Actu_cliente;
        private System.Windows.Forms.ToolTip m_guardar;
        private System.Windows.Forms.ToolTip m_Eliminar;
        private System.Windows.Forms.ToolTip m_Reporte;
        private System.Windows.Forms.Button btn_salirtransaclientes;
        private System.Windows.Forms.ToolTip m_SalirTrans;
        private System.Windows.Forms.Label lbl_titulo_transclientes;
        private System.Windows.Forms.Button btn_ayudatransclientes;
        private System.Windows.Forms.ToolTip m_AyudasTransCliente;
        private System.Windows.Forms.TextBox txt_trans_cuentacl;
        private System.Windows.Forms.TextBox txt_fac_transcl;
        private System.Windows.Forms.TextBox txt_tipo_transcl;
        private System.Windows.Forms.Label lbl_factura_transcl;
        private System.Windows.Forms.Label lbl_tipotranscl;
        private System.Windows.Forms.Label lbl_idcuenta_transcl;
    }
}