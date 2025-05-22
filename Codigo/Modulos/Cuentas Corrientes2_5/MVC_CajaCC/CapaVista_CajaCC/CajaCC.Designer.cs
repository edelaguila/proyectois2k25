
namespace CapaVista_CajaCC
{
    partial class frm_CajaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CajaCC));
            this.lbl_titulo_caja = new System.Windows.Forms.Label();
            this.dgv_caja_general = new System.Windows.Forms.DataGridView();
            this.lbl_id_cajacc = new System.Windows.Forms.Label();
            this.lbl_id_cliente_caja = new System.Windows.Forms.Label();
            this.lbl_id_proveedor_caja = new System.Windows.Forms.Label();
            this.lbl_saldo_restante_caja = new System.Windows.Forms.Label();
            this.lbl_estado_caja = new System.Windows.Forms.Label();
            this.lbl_fechareg_caja = new System.Windows.Forms.Label();
            this.txt_idcaja = new System.Windows.Forms.TextBox();
            this.txt_saldocaja = new System.Windows.Forms.TextBox();
            this.txt_estadocaja = new System.Windows.Forms.TextBox();
            this.gpb_datos_caja = new System.Windows.Forms.GroupBox();
            this.dtp_caja = new System.Windows.Forms.DateTimePicker();
            this.cbo_deuda_caja = new System.Windows.Forms.ComboBox();
            this.lbl_iddeuda_caja = new System.Windows.Forms.Label();
            this.cbo_proveedor_caja = new System.Windows.Forms.ComboBox();
            this.cbo_cliente_caja = new System.Windows.Forms.ComboBox();
            this.Btn_nueva_caja = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_reportes = new System.Windows.Forms.Button();
            this.Btn_Ayudas = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.gpb_botones_caja = new System.Windows.Forms.GroupBox();
            this.cbo_deuda_prov = new System.Windows.Forms.ComboBox();
            this.lbl_deuda_prov = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_caja_general)).BeginInit();
            this.gpb_datos_caja.SuspendLayout();
            this.gpb_botones_caja.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo_caja
            // 
            this.lbl_titulo_caja.AutoSize = true;
            this.lbl_titulo_caja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_caja.Location = new System.Drawing.Point(579, 117);
            this.lbl_titulo_caja.Name = "lbl_titulo_caja";
            this.lbl_titulo_caja.Size = new System.Drawing.Size(206, 34);
            this.lbl_titulo_caja.TabIndex = 62;
            this.lbl_titulo_caja.Text = "Caja General";
            // 
            // dgv_caja_general
            // 
            this.dgv_caja_general.ColumnHeadersHeight = 29;
            this.dgv_caja_general.Location = new System.Drawing.Point(3, 422);
            this.dgv_caja_general.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_caja_general.Name = "dgv_caja_general";
            this.dgv_caja_general.RowHeadersWidth = 51;
            this.dgv_caja_general.Size = new System.Drawing.Size(1364, 174);
            this.dgv_caja_general.TabIndex = 63;
            this.dgv_caja_general.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_caja_general_CellContentClick);
            // 
            // lbl_id_cajacc
            // 
            this.lbl_id_cajacc.AutoSize = true;
            this.lbl_id_cajacc.Location = new System.Drawing.Point(10, 20);
            this.lbl_id_cajacc.Name = "lbl_id_cajacc";
            this.lbl_id_cajacc.Size = new System.Drawing.Size(86, 17);
            this.lbl_id_cajacc.TabIndex = 64;
            this.lbl_id_cajacc.Text = "Nro. Ingreso";
            // 
            // lbl_id_cliente_caja
            // 
            this.lbl_id_cliente_caja.AutoSize = true;
            this.lbl_id_cliente_caja.Location = new System.Drawing.Point(10, 76);
            this.lbl_id_cliente_caja.Name = "lbl_id_cliente_caja";
            this.lbl_id_cliente_caja.Size = new System.Drawing.Size(51, 17);
            this.lbl_id_cliente_caja.TabIndex = 65;
            this.lbl_id_cliente_caja.Text = "Cliente";
            // 
            // lbl_id_proveedor_caja
            // 
            this.lbl_id_proveedor_caja.AutoSize = true;
            this.lbl_id_proveedor_caja.Location = new System.Drawing.Point(6, 146);
            this.lbl_id_proveedor_caja.Name = "lbl_id_proveedor_caja";
            this.lbl_id_proveedor_caja.Size = new System.Drawing.Size(74, 17);
            this.lbl_id_proveedor_caja.TabIndex = 66;
            this.lbl_id_proveedor_caja.Text = "Proveedor";
            // 
            // lbl_saldo_restante_caja
            // 
            this.lbl_saldo_restante_caja.AutoSize = true;
            this.lbl_saldo_restante_caja.Location = new System.Drawing.Point(719, 15);
            this.lbl_saldo_restante_caja.Name = "lbl_saldo_restante_caja";
            this.lbl_saldo_restante_caja.Size = new System.Drawing.Size(105, 17);
            this.lbl_saldo_restante_caja.TabIndex = 70;
            this.lbl_saldo_restante_caja.Text = "Saldo Restante";
            // 
            // lbl_estado_caja
            // 
            this.lbl_estado_caja.AutoSize = true;
            this.lbl_estado_caja.Location = new System.Drawing.Point(772, 73);
            this.lbl_estado_caja.Name = "lbl_estado_caja";
            this.lbl_estado_caja.Size = new System.Drawing.Size(52, 17);
            this.lbl_estado_caja.TabIndex = 71;
            this.lbl_estado_caja.Text = "Estado";
            // 
            // lbl_fechareg_caja
            // 
            this.lbl_fechareg_caja.AutoSize = true;
            this.lbl_fechareg_caja.Location = new System.Drawing.Point(709, 127);
            this.lbl_fechareg_caja.Name = "lbl_fechareg_caja";
            this.lbl_fechareg_caja.Size = new System.Drawing.Size(124, 17);
            this.lbl_fechareg_caja.TabIndex = 72;
            this.lbl_fechareg_caja.Text = "Fecha de Registro";
            // 
            // txt_idcaja
            // 
            this.txt_idcaja.Location = new System.Drawing.Point(105, 20);
            this.txt_idcaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idcaja.Name = "txt_idcaja";
            this.txt_idcaja.Size = new System.Drawing.Size(176, 22);
            this.txt_idcaja.TabIndex = 73;
            // 
            // txt_saldocaja
            // 
            this.txt_saldocaja.Location = new System.Drawing.Point(830, 12);
            this.txt_saldocaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_saldocaja.Name = "txt_saldocaja";
            this.txt_saldocaja.Size = new System.Drawing.Size(176, 22);
            this.txt_saldocaja.TabIndex = 79;
            // 
            // txt_estadocaja
            // 
            this.txt_estadocaja.Location = new System.Drawing.Point(834, 71);
            this.txt_estadocaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_estadocaja.Name = "txt_estadocaja";
            this.txt_estadocaja.Size = new System.Drawing.Size(176, 22);
            this.txt_estadocaja.TabIndex = 80;
            // 
            // gpb_datos_caja
            // 
            this.gpb_datos_caja.Controls.Add(this.lbl_deuda_prov);
            this.gpb_datos_caja.Controls.Add(this.cbo_deuda_prov);
            this.gpb_datos_caja.Controls.Add(this.dtp_caja);
            this.gpb_datos_caja.Controls.Add(this.cbo_deuda_caja);
            this.gpb_datos_caja.Controls.Add(this.lbl_iddeuda_caja);
            this.gpb_datos_caja.Controls.Add(this.cbo_proveedor_caja);
            this.gpb_datos_caja.Controls.Add(this.cbo_cliente_caja);
            this.gpb_datos_caja.Controls.Add(this.txt_estadocaja);
            this.gpb_datos_caja.Controls.Add(this.txt_saldocaja);
            this.gpb_datos_caja.Controls.Add(this.txt_idcaja);
            this.gpb_datos_caja.Controls.Add(this.lbl_fechareg_caja);
            this.gpb_datos_caja.Controls.Add(this.lbl_estado_caja);
            this.gpb_datos_caja.Controls.Add(this.lbl_saldo_restante_caja);
            this.gpb_datos_caja.Controls.Add(this.lbl_id_proveedor_caja);
            this.gpb_datos_caja.Controls.Add(this.lbl_id_cliente_caja);
            this.gpb_datos_caja.Controls.Add(this.lbl_id_cajacc);
            this.gpb_datos_caja.Location = new System.Drawing.Point(161, 176);
            this.gpb_datos_caja.Name = "gpb_datos_caja";
            this.gpb_datos_caja.Size = new System.Drawing.Size(1094, 215);
            this.gpb_datos_caja.TabIndex = 82;
            this.gpb_datos_caja.TabStop = false;
            this.gpb_datos_caja.Text = "Ingreso de Datos";
            // 
            // dtp_caja
            // 
            this.dtp_caja.Location = new System.Drawing.Point(839, 127);
            this.dtp_caja.Name = "dtp_caja";
            this.dtp_caja.Size = new System.Drawing.Size(197, 22);
            this.dtp_caja.TabIndex = 86;
            // 
            // cbo_deuda_caja
            // 
            this.cbo_deuda_caja.FormattingEnabled = true;
            this.cbo_deuda_caja.Location = new System.Drawing.Point(466, 21);
            this.cbo_deuda_caja.Name = "cbo_deuda_caja";
            this.cbo_deuda_caja.Size = new System.Drawing.Size(176, 24);
            this.cbo_deuda_caja.TabIndex = 85;
            // 
            // lbl_iddeuda_caja
            // 
            this.lbl_iddeuda_caja.AutoSize = true;
            this.lbl_iddeuda_caja.Location = new System.Drawing.Point(374, 25);
            this.lbl_iddeuda_caja.Name = "lbl_iddeuda_caja";
            this.lbl_iddeuda_caja.Size = new System.Drawing.Size(50, 17);
            this.lbl_iddeuda_caja.TabIndex = 84;
            this.lbl_iddeuda_caja.Text = "Deuda";
            // 
            // cbo_proveedor_caja
            // 
            this.cbo_proveedor_caja.FormattingEnabled = true;
            this.cbo_proveedor_caja.Location = new System.Drawing.Point(105, 139);
            this.cbo_proveedor_caja.Name = "cbo_proveedor_caja";
            this.cbo_proveedor_caja.Size = new System.Drawing.Size(176, 24);
            this.cbo_proveedor_caja.TabIndex = 83;
            // 
            // cbo_cliente_caja
            // 
            this.cbo_cliente_caja.FormattingEnabled = true;
            this.cbo_cliente_caja.Location = new System.Drawing.Point(105, 79);
            this.cbo_cliente_caja.Name = "cbo_cliente_caja";
            this.cbo_cliente_caja.Size = new System.Drawing.Size(176, 24);
            this.cbo_cliente_caja.TabIndex = 82;
            // 
            // Btn_nueva_caja
            // 
            this.Btn_nueva_caja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_nueva_caja.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nueva_caja.Image = ((System.Drawing.Image)(resources.GetObject("Btn_nueva_caja.Image")));
            this.Btn_nueva_caja.Location = new System.Drawing.Point(23, 16);
            this.Btn_nueva_caja.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_nueva_caja.Name = "Btn_nueva_caja";
            this.Btn_nueva_caja.Size = new System.Drawing.Size(62, 59);
            this.Btn_nueva_caja.TabIndex = 101;
            this.Btn_nueva_caja.UseVisualStyleBackColor = false;
            this.Btn_nueva_caja.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_guardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(93, 16);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 59);
            this.Btn_guardar.TabIndex = 102;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_editar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.Location = new System.Drawing.Point(154, 16);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(58, 59);
            this.Btn_editar.TabIndex = 103;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_eliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(220, 16);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(60, 59);
            this.Btn_eliminar.TabIndex = 104;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(288, 16);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(56, 59);
            this.Btn_Buscar.TabIndex = 106;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_reportes
            // 
            this.Btn_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_reportes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reportes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_reportes.Image")));
            this.Btn_reportes.Location = new System.Drawing.Point(351, 16);
            this.Btn_reportes.Name = "Btn_reportes";
            this.Btn_reportes.Size = new System.Drawing.Size(65, 59);
            this.Btn_reportes.TabIndex = 115;
            this.Btn_reportes.UseVisualStyleBackColor = false;
            // 
            // Btn_Ayudas
            // 
            this.Btn_Ayudas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Ayudas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayudas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayudas.Image")));
            this.Btn_Ayudas.Location = new System.Drawing.Point(422, 16);
            this.Btn_Ayudas.Name = "Btn_Ayudas";
            this.Btn_Ayudas.Size = new System.Drawing.Size(65, 59);
            this.Btn_Ayudas.TabIndex = 116;
            this.Btn_Ayudas.UseVisualStyleBackColor = false;
            this.Btn_Ayudas.Click += new System.EventHandler(this.Btn_Ayudas_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_salir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salir.Image")));
            this.Btn_salir.Location = new System.Drawing.Point(493, 16);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(63, 59);
            this.Btn_salir.TabIndex = 117;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // gpb_botones_caja
            // 
            this.gpb_botones_caja.Controls.Add(this.Btn_salir);
            this.gpb_botones_caja.Controls.Add(this.Btn_Ayudas);
            this.gpb_botones_caja.Controls.Add(this.Btn_reportes);
            this.gpb_botones_caja.Controls.Add(this.Btn_Buscar);
            this.gpb_botones_caja.Controls.Add(this.Btn_eliminar);
            this.gpb_botones_caja.Controls.Add(this.Btn_editar);
            this.gpb_botones_caja.Controls.Add(this.Btn_guardar);
            this.gpb_botones_caja.Controls.Add(this.Btn_nueva_caja);
            this.gpb_botones_caja.Location = new System.Drawing.Point(407, 12);
            this.gpb_botones_caja.Name = "gpb_botones_caja";
            this.gpb_botones_caja.Size = new System.Drawing.Size(578, 90);
            this.gpb_botones_caja.TabIndex = 118;
            this.gpb_botones_caja.TabStop = false;
            // 
            // cbo_deuda_prov
            // 
            this.cbo_deuda_prov.FormattingEnabled = true;
            this.cbo_deuda_prov.Location = new System.Drawing.Point(466, 120);
            this.cbo_deuda_prov.Name = "cbo_deuda_prov";
            this.cbo_deuda_prov.Size = new System.Drawing.Size(176, 24);
            this.cbo_deuda_prov.TabIndex = 87;
            // 
            // lbl_deuda_prov
            // 
            this.lbl_deuda_prov.AutoSize = true;
            this.lbl_deuda_prov.Location = new System.Drawing.Point(374, 123);
            this.lbl_deuda_prov.Name = "lbl_deuda_prov";
            this.lbl_deuda_prov.Size = new System.Drawing.Size(50, 17);
            this.lbl_deuda_prov.TabIndex = 88;
            this.lbl_deuda_prov.Text = "Deuda";
            this.lbl_deuda_prov.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_CajaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1379, 607);
            this.Controls.Add(this.gpb_botones_caja);
            this.Controls.Add(this.gpb_datos_caja);
            this.Controls.Add(this.dgv_caja_general);
            this.Controls.Add(this.lbl_titulo_caja);
            this.Name = "frm_CajaCC";
            this.Text = "CajaCC";
            this.Load += new System.EventHandler(this.CajaCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_caja_general)).EndInit();
            this.gpb_datos_caja.ResumeLayout(false);
            this.gpb_datos_caja.PerformLayout();
            this.gpb_botones_caja.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_caja;
        private System.Windows.Forms.DataGridView dgv_caja_general;
        private System.Windows.Forms.Label lbl_id_cajacc;
        private System.Windows.Forms.Label lbl_id_cliente_caja;
        private System.Windows.Forms.Label lbl_id_proveedor_caja;
        private System.Windows.Forms.Label lbl_saldo_restante_caja;
        private System.Windows.Forms.Label lbl_estado_caja;
        private System.Windows.Forms.Label lbl_fechareg_caja;
        private System.Windows.Forms.TextBox txt_idcaja;
        private System.Windows.Forms.TextBox txt_saldocaja;
        private System.Windows.Forms.TextBox txt_estadocaja;
        private System.Windows.Forms.GroupBox gpb_datos_caja;
        private System.Windows.Forms.ComboBox cbo_proveedor_caja;
        private System.Windows.Forms.ComboBox cbo_cliente_caja;
        private System.Windows.Forms.Button Btn_nueva_caja;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_reportes;
        private System.Windows.Forms.Button Btn_Ayudas;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.GroupBox gpb_botones_caja;
        private System.Windows.Forms.ComboBox cbo_deuda_caja;
        private System.Windows.Forms.Label lbl_iddeuda_caja;
        private System.Windows.Forms.DateTimePicker dtp_caja;
        private System.Windows.Forms.Label lbl_deuda_prov;
        private System.Windows.Forms.ComboBox cbo_deuda_prov;
    }
}