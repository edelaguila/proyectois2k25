
using System;

namespace Capa_Vista_AmmyCatun
{
    partial class Transporte_Vehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transporte_Vehiculos));
            this.Gpb_Mantenimiento = new System.Windows.Forms.GroupBox();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Gpb_Metodos = new System.Windows.Forms.GroupBox();
            this.Txt_Destino = new System.Windows.Forms.TextBox();
            this.Txt_FormaPago = new System.Windows.Forms.Label();
            this.Cbo_Forma = new System.Windows.Forms.ComboBox();
            this.Txt_Dest = new System.Windows.Forms.Label();
            this.Gpb_Pedido = new System.Windows.Forms.GroupBox();
            this.Txt_IdGuia = new System.Windows.Forms.Label();
            this.Txt_Guia = new System.Windows.Forms.TextBox();
            this.Txt_id_Vehiculo = new System.Windows.Forms.TextBox();
            this.Txt_IdVehiculo = new System.Windows.Forms.Label();
            this.dtp_Fecha_Traslado = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fecha_Emision = new System.Windows.Forms.DateTimePicker();
            this.Txt_LLegada = new System.Windows.Forms.TextBox();
            this.Txt_Recojo = new System.Windows.Forms.TextBox();
            this.Txt_Partida = new System.Windows.Forms.TextBox();
            this.Txt_DirLLegada = new System.Windows.Forms.Label();
            this.Txt_DirPartida = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_FechaTraslado = new System.Windows.Forms.Label();
            this.Txt_Fechaemision = new System.Windows.Forms.Label();
            this.Txt_Datos = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_Clientes = new System.Windows.Forms.ComboBox();
            this.Gpb_Mantenimiento.SuspendLayout();
            this.Gpb_Metodos.SuspendLayout();
            this.Gpb_Pedido.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_Mantenimiento
            // 
            this.Gpb_Mantenimiento.Controls.Add(this.Btn_Ayuda);
            this.Gpb_Mantenimiento.Controls.Add(this.Btn_Reporte);
            this.Gpb_Mantenimiento.Controls.Add(this.Btn_Modificar);
            this.Gpb_Mantenimiento.Controls.Add(this.Btn_Eliminar);
            this.Gpb_Mantenimiento.Controls.Add(this.Btn_Ingresar);
            this.Gpb_Mantenimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Mantenimiento.Location = new System.Drawing.Point(233, 92);
            this.Gpb_Mantenimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Mantenimiento.Name = "Gpb_Mantenimiento";
            this.Gpb_Mantenimiento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Mantenimiento.Size = new System.Drawing.Size(461, 121);
            this.Gpb_Mantenimiento.TabIndex = 32;
            this.Gpb_Mantenimiento.TabStop = false;
            this.Gpb_Mantenimiento.Text = "MANTENIMIENTO";
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(192, 31);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(85, 71);
            this.Btn_Ayuda.TabIndex = 6;
            this.Btn_Ayuda.UseVisualStyleBackColor = false;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Reporte.Image = global::Capa_Vista_AmmyCatun.Properties.Resources.reporte;
            this.Btn_Reporte.Location = new System.Drawing.Point(283, 31);
            this.Btn_Reporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(85, 71);
            this.Btn_Reporte.TabIndex = 4;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(374, 31);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(73, 71);
            this.Btn_Modificar.TabIndex = 2;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(104, 31);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 71);
            this.Btn_Eliminar.TabIndex = 1;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ingresar.Image")));
            this.Btn_Ingresar.Location = new System.Drawing.Point(21, 31);
            this.Btn_Ingresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(77, 71);
            this.Btn_Ingresar.TabIndex = 0;
            this.Btn_Ingresar.UseVisualStyleBackColor = false;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // Gpb_Metodos
            // 
            this.Gpb_Metodos.Controls.Add(this.Txt_Destino);
            this.Gpb_Metodos.Controls.Add(this.Txt_FormaPago);
            this.Gpb_Metodos.Controls.Add(this.Cbo_Forma);
            this.Gpb_Metodos.Controls.Add(this.Txt_Dest);
            this.Gpb_Metodos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Metodos.Location = new System.Drawing.Point(19, 510);
            this.Gpb_Metodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Metodos.Name = "Gpb_Metodos";
            this.Gpb_Metodos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Metodos.Size = new System.Drawing.Size(925, 62);
            this.Gpb_Metodos.TabIndex = 31;
            this.Gpb_Metodos.TabStop = false;
            // 
            // Txt_Destino
            // 
            this.Txt_Destino.Location = new System.Drawing.Point(136, 23);
            this.Txt_Destino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Destino.Name = "Txt_Destino";
            this.Txt_Destino.Size = new System.Drawing.Size(214, 30);
            this.Txt_Destino.TabIndex = 32;
            // 
            // Txt_FormaPago
            // 
            this.Txt_FormaPago.AutoSize = true;
            this.Txt_FormaPago.Location = new System.Drawing.Point(383, 27);
            this.Txt_FormaPago.Name = "Txt_FormaPago";
            this.Txt_FormaPago.Size = new System.Drawing.Size(183, 23);
            this.Txt_FormaPago.TabIndex = 16;
            this.Txt_FormaPago.Text = "FORMA DE PAGO:";
            // 
            // Cbo_Forma
            // 
            this.Cbo_Forma.FormattingEnabled = true;
            this.Cbo_Forma.Location = new System.Drawing.Point(589, 19);
            this.Cbo_Forma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbo_Forma.Name = "Cbo_Forma";
            this.Cbo_Forma.Size = new System.Drawing.Size(304, 31);
            this.Cbo_Forma.TabIndex = 15;
            // 
            // Txt_Dest
            // 
            this.Txt_Dest.AutoSize = true;
            this.Txt_Dest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Dest.Location = new System.Drawing.Point(21, 26);
            this.Txt_Dest.Name = "Txt_Dest";
            this.Txt_Dest.Size = new System.Drawing.Size(110, 23);
            this.Txt_Dest.TabIndex = 7;
            this.Txt_Dest.Text = "DESTINO: ";
            // 
            // Gpb_Pedido
            // 
            this.Gpb_Pedido.Controls.Add(this.Txt_IdGuia);
            this.Gpb_Pedido.Controls.Add(this.Txt_Guia);
            this.Gpb_Pedido.Controls.Add(this.Txt_id_Vehiculo);
            this.Gpb_Pedido.Controls.Add(this.Txt_IdVehiculo);
            this.Gpb_Pedido.Controls.Add(this.dtp_Fecha_Traslado);
            this.Gpb_Pedido.Controls.Add(this.dtp_Fecha_Emision);
            this.Gpb_Pedido.Controls.Add(this.Txt_LLegada);
            this.Gpb_Pedido.Controls.Add(this.Txt_Recojo);
            this.Gpb_Pedido.Controls.Add(this.Txt_Partida);
            this.Gpb_Pedido.Controls.Add(this.Txt_DirLLegada);
            this.Gpb_Pedido.Controls.Add(this.Txt_DirPartida);
            this.Gpb_Pedido.Controls.Add(this.label8);
            this.Gpb_Pedido.Controls.Add(this.Txt_FechaTraslado);
            this.Gpb_Pedido.Controls.Add(this.Txt_Fechaemision);
            this.Gpb_Pedido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Pedido.Location = new System.Drawing.Point(27, 290);
            this.Gpb_Pedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Pedido.Name = "Gpb_Pedido";
            this.Gpb_Pedido.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Pedido.Size = new System.Drawing.Size(1504, 190);
            this.Gpb_Pedido.TabIndex = 30;
            this.Gpb_Pedido.TabStop = false;
            this.Gpb_Pedido.Text = "DATOS PEDIDO";
            this.Gpb_Pedido.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Txt_IdGuia
            // 
            this.Txt_IdGuia.AutoSize = true;
            this.Txt_IdGuia.Location = new System.Drawing.Point(1084, 94);
            this.Txt_IdGuia.Name = "Txt_IdGuia";
            this.Txt_IdGuia.Size = new System.Drawing.Size(73, 23);
            this.Txt_IdGuia.TabIndex = 34;
            this.Txt_IdGuia.Text = "Id Guia";
            // 
            // Txt_Guia
            // 
            this.Txt_Guia.Location = new System.Drawing.Point(1229, 94);
            this.Txt_Guia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Guia.Name = "Txt_Guia";
            this.Txt_Guia.Size = new System.Drawing.Size(252, 30);
            this.Txt_Guia.TabIndex = 29;
            // 
            // Txt_id_Vehiculo
            // 
            this.Txt_id_Vehiculo.Location = new System.Drawing.Point(1229, 44);
            this.Txt_id_Vehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_id_Vehiculo.Name = "Txt_id_Vehiculo";
            this.Txt_id_Vehiculo.Size = new System.Drawing.Size(252, 30);
            this.Txt_id_Vehiculo.TabIndex = 28;
            // 
            // Txt_IdVehiculo
            // 
            this.Txt_IdVehiculo.AutoSize = true;
            this.Txt_IdVehiculo.Location = new System.Drawing.Point(1093, 44);
            this.Txt_IdVehiculo.Name = "Txt_IdVehiculo";
            this.Txt_IdVehiculo.Size = new System.Drawing.Size(101, 23);
            this.Txt_IdVehiculo.TabIndex = 27;
            this.Txt_IdVehiculo.Text = "Id vehiculo";
            // 
            // dtp_Fecha_Traslado
            // 
            this.dtp_Fecha_Traslado.Location = new System.Drawing.Point(800, 39);
            this.dtp_Fecha_Traslado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Fecha_Traslado.Name = "dtp_Fecha_Traslado";
            this.dtp_Fecha_Traslado.Size = new System.Drawing.Size(280, 30);
            this.dtp_Fecha_Traslado.TabIndex = 26;
            // 
            // dtp_Fecha_Emision
            // 
            this.dtp_Fecha_Emision.Location = new System.Drawing.Point(249, 37);
            this.dtp_Fecha_Emision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Fecha_Emision.Name = "dtp_Fecha_Emision";
            this.dtp_Fecha_Emision.Size = new System.Drawing.Size(295, 30);
            this.dtp_Fecha_Emision.TabIndex = 25;
            // 
            // Txt_LLegada
            // 
            this.Txt_LLegada.Location = new System.Drawing.Point(800, 82);
            this.Txt_LLegada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_LLegada.Name = "Txt_LLegada";
            this.Txt_LLegada.Size = new System.Drawing.Size(250, 30);
            this.Txt_LLegada.TabIndex = 23;
            // 
            // Txt_Recojo
            // 
            this.Txt_Recojo.Location = new System.Drawing.Point(275, 135);
            this.Txt_Recojo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Recojo.Name = "Txt_Recojo";
            this.Txt_Recojo.Size = new System.Drawing.Size(227, 30);
            this.Txt_Recojo.TabIndex = 20;
            // 
            // Txt_Partida
            // 
            this.Txt_Partida.Location = new System.Drawing.Point(284, 89);
            this.Txt_Partida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Partida.Name = "Txt_Partida";
            this.Txt_Partida.Size = new System.Drawing.Size(218, 30);
            this.Txt_Partida.TabIndex = 19;
            // 
            // Txt_DirLLegada
            // 
            this.Txt_DirLLegada.AutoSize = true;
            this.Txt_DirLLegada.Location = new System.Drawing.Point(507, 91);
            this.Txt_DirLLegada.Name = "Txt_DirLLegada";
            this.Txt_DirLLegada.Size = new System.Drawing.Size(264, 23);
            this.Txt_DirLLegada.TabIndex = 9;
            this.Txt_DirLLegada.Text = "DIRECCIÓN DE LLEGADA:";
            // 
            // Txt_DirPartida
            // 
            this.Txt_DirPartida.AutoSize = true;
            this.Txt_DirPartida.Location = new System.Drawing.Point(9, 91);
            this.Txt_DirPartida.Name = "Txt_DirPartida";
            this.Txt_DirPartida.Size = new System.Drawing.Size(253, 23);
            this.Txt_DirPartida.TabIndex = 10;
            this.Txt_DirPartida.Text = "DIRECCIÓN DE PARTIDA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nª ORDEN DE RECOJO:";
            // 
            // Txt_FechaTraslado
            // 
            this.Txt_FechaTraslado.AutoSize = true;
            this.Txt_FechaTraslado.Location = new System.Drawing.Point(548, 44);
            this.Txt_FechaTraslado.Name = "Txt_FechaTraslado";
            this.Txt_FechaTraslado.Size = new System.Drawing.Size(234, 23);
            this.Txt_FechaTraslado.TabIndex = 2;
            this.Txt_FechaTraslado.Text = "FECHA DE TRASLADO: ";
            // 
            // Txt_Fechaemision
            // 
            this.Txt_Fechaemision.AutoSize = true;
            this.Txt_Fechaemision.Location = new System.Drawing.Point(12, 37);
            this.Txt_Fechaemision.Name = "Txt_Fechaemision";
            this.Txt_Fechaemision.Size = new System.Drawing.Size(211, 23);
            this.Txt_Fechaemision.TabIndex = 1;
            this.Txt_Fechaemision.Text = "FECHA DE EMISIÓN: ";
            // 
            // Txt_Datos
            // 
            this.Txt_Datos.AutoSize = true;
            this.Txt_Datos.Font = new System.Drawing.Font("Haettenschweiler", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Datos.Location = new System.Drawing.Point(572, 12);
            this.Txt_Datos.Name = "Txt_Datos";
            this.Txt_Datos.Size = new System.Drawing.Size(261, 45);
            this.Txt_Datos.TabIndex = 27;
            this.Txt_Datos.Text = "GUÍA DE DESPACHO";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Dgv_Cliente);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(11, 601);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(1741, 469);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Vista Cliente";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // Dgv_Cliente
            // 
            this.Dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Cliente.Location = new System.Drawing.Point(16, 43);
            this.Dgv_Cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Cliente.Name = "Dgv_Cliente";
            this.Dgv_Cliente.RowHeadersWidth = 51;
            this.Dgv_Cliente.RowTemplate.Height = 24;
            this.Dgv_Cliente.Size = new System.Drawing.Size(1481, 384);
            this.Dgv_Cliente.TabIndex = 17;
            this.Dgv_Cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Cliente_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(760, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "CLIENTES";
            // 
            // Cmb_Clientes
            // 
            this.Cmb_Clientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Clientes.FormattingEnabled = true;
            this.Cmb_Clientes.Location = new System.Drawing.Point(874, 163);
            this.Cmb_Clientes.Name = "Cmb_Clientes";
            this.Cmb_Clientes.Size = new System.Drawing.Size(169, 31);
            this.Cmb_Clientes.TabIndex = 39;
            this.Cmb_Clientes.SelectedIndexChanged += new System.EventHandler(this.Cmb_Clientes_SelectedIndexChanged);
            // 
            // Transporte_Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1710, 840);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_Clientes);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.Gpb_Mantenimiento);
            this.Controls.Add(this.Gpb_Metodos);
            this.Controls.Add(this.Gpb_Pedido);
            this.Controls.Add(this.Txt_Datos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Transporte_Vehiculos";
            this.Gpb_Mantenimiento.ResumeLayout(false);
            this.Gpb_Metodos.ResumeLayout(false);
            this.Gpb_Metodos.PerformLayout();
            this.Gpb_Pedido.ResumeLayout(false);
            this.Gpb_Pedido.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Mantenimiento;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.GroupBox Gpb_Metodos;
        private System.Windows.Forms.TextBox Txt_Destino;
        private System.Windows.Forms.Label Txt_FormaPago;
        private System.Windows.Forms.ComboBox Cbo_Forma;
        private System.Windows.Forms.Label Txt_Dest;
        private System.Windows.Forms.GroupBox Gpb_Pedido;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Traslado;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Emision;
        private System.Windows.Forms.TextBox Txt_LLegada;
        private System.Windows.Forms.TextBox Txt_Recojo;
        private System.Windows.Forms.TextBox Txt_Partida;
        private System.Windows.Forms.Label Txt_DirLLegada;
        private System.Windows.Forms.Label Txt_DirPartida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Txt_FechaTraslado;
        private System.Windows.Forms.Label Txt_Fechaemision;
        private System.Windows.Forms.Label Txt_Datos;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView Dgv_Cliente;
        private System.Windows.Forms.Label Txt_IdVehiculo;
        private System.Windows.Forms.Label Txt_IdGuia;
        private System.Windows.Forms.TextBox Txt_Guia;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_Clientes;
        private System.Windows.Forms.TextBox Txt_id_Vehiculo;
    }
}