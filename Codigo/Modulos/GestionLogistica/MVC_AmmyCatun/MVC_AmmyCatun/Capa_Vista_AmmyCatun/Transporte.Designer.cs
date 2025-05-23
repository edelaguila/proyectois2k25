
using System;

namespace Capa_Vista_AmmyCatun
{
    partial class Transporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transporte));
            this.Gpb_Detalle = new System.Windows.Forms.GroupBox();
            this.Dgv_Vehiculo = new System.Windows.Forms.DataGridView();
            this.Gpb_Mantenimiento = new System.Windows.Forms.GroupBox();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Txt_Datos = new System.Windows.Forms.Label();
            this.Gpb_Vehiculo = new System.Windows.Forms.GroupBox();
            this.Txt_IDVeh = new System.Windows.Forms.TextBox();
            this.Txt_IdVehicu = new System.Windows.Forms.Label();
            this.Txt_HS = new System.Windows.Forms.TextBox();
            this.Txt_HLL = new System.Windows.Forms.TextBox();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Txt_Desc = new System.Windows.Forms.TextBox();
            this.Txt_Color = new System.Windows.Forms.TextBox();
            this.Txt_Marca = new System.Windows.Forms.TextBox();
            this.Txt_Placa = new System.Windows.Forms.TextBox();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Txt_HoraSalida = new System.Windows.Forms.Label();
            this.Txt_Peso = new System.Windows.Forms.Label();
            this.Txt_HoraLlegada = new System.Windows.Forms.Label();
            this.Txt_Descripcion = new System.Windows.Forms.Label();
            this.Txt_Col = new System.Windows.Forms.Label();
            this.Txt_Marc = new System.Windows.Forms.Label();
            this.Txt_Plac = new System.Windows.Forms.Label();
            this.Txt_IdChof = new System.Windows.Forms.Label();
            this.Pic_Transporte = new System.Windows.Forms.PictureBox();
            this.Gpb_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vehiculo)).BeginInit();
            this.Gpb_Mantenimiento.SuspendLayout();
            this.Gpb_Vehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Transporte)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_Detalle
            // 
            this.Gpb_Detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_Detalle.Controls.Add(this.Dgv_Vehiculo);
            this.Gpb_Detalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Detalle.Location = new System.Drawing.Point(24, 564);
            this.Gpb_Detalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Detalle.Name = "Gpb_Detalle";
            this.Gpb_Detalle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Detalle.Size = new System.Drawing.Size(1448, 315);
            this.Gpb_Detalle.TabIndex = 31;
            this.Gpb_Detalle.TabStop = false;
            this.Gpb_Detalle.Text = "Detalle Vehiculo";
            // 
            // Dgv_Vehiculo
            // 
            this.Dgv_Vehiculo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Dgv_Vehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Vehiculo.Location = new System.Drawing.Point(17, 50);
            this.Dgv_Vehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Vehiculo.Name = "Dgv_Vehiculo";
            this.Dgv_Vehiculo.RowHeadersWidth = 51;
            this.Dgv_Vehiculo.RowTemplate.Height = 24;
            this.Dgv_Vehiculo.Size = new System.Drawing.Size(1366, 186);
            this.Dgv_Vehiculo.TabIndex = 3;
            this.Dgv_Vehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Vehiculo_CellContentClick);
            // 
            // Gpb_Mantenimiento
            // 
            this.Gpb_Mantenimiento.Controls.Add(this.Btn_Ingresar);
            this.Gpb_Mantenimiento.Controls.Add(this.Btn_Ayuda);
            this.Gpb_Mantenimiento.Controls.Add(this.Btn_Reporte);
            this.Gpb_Mantenimiento.Controls.Add(this.Btn_Modificar);
            this.Gpb_Mantenimiento.Controls.Add(this.Btn_Eliminar);
            this.Gpb_Mantenimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Mantenimiento.Location = new System.Drawing.Point(98, 85);
            this.Gpb_Mantenimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Mantenimiento.Name = "Gpb_Mantenimiento";
            this.Gpb_Mantenimiento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Mantenimiento.Size = new System.Drawing.Size(511, 172);
            this.Gpb_Mantenimiento.TabIndex = 30;
            this.Gpb_Mantenimiento.TabStop = false;
            this.Gpb_Mantenimiento.Text = "MANTENIMIENTO";
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ingresar.Image")));
            this.Btn_Ingresar.Location = new System.Drawing.Point(18, 50);
            this.Btn_Ingresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(83, 74);
            this.Btn_Ingresar.TabIndex = 0;
            this.Btn_Ingresar.UseVisualStyleBackColor = false;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Ayuda.Image = global::Capa_Vista_AmmyCatun.Properties.Resources.preguntas;
            this.Btn_Ayuda.Location = new System.Drawing.Point(393, 47);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(85, 71);
            this.Btn_Ayuda.TabIndex = 5;
            this.Btn_Ayuda.UseVisualStyleBackColor = false;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Reporte.Image = global::Capa_Vista_AmmyCatun.Properties.Resources.reporte;
            this.Btn_Reporte.Location = new System.Drawing.Point(291, 47);
            this.Btn_Reporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(87, 71);
            this.Btn_Reporte.TabIndex = 4;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(107, 50);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(88, 74);
            this.Btn_Modificar.TabIndex = 2;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(201, 50);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(84, 74);
            this.Btn_Eliminar.TabIndex = 1;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Txt_Datos
            // 
            this.Txt_Datos.AutoSize = true;
            this.Txt_Datos.Font = new System.Drawing.Font("Haettenschweiler", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Datos.Location = new System.Drawing.Point(579, 20);
            this.Txt_Datos.Name = "Txt_Datos";
            this.Txt_Datos.Size = new System.Drawing.Size(321, 45);
            this.Txt_Datos.TabIndex = 33;
            this.Txt_Datos.Text = "DATOS DE TRANSPORTE";
            // 
            // Gpb_Vehiculo
            // 
            this.Gpb_Vehiculo.Controls.Add(this.Txt_IDVeh);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_IdVehicu);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_HS);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_HLL);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_Total);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_Desc);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_Color);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_Marca);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_Placa);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_ID);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_HoraSalida);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_Peso);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_HoraLlegada);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_Descripcion);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_Col);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_Marc);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_Plac);
            this.Gpb_Vehiculo.Controls.Add(this.Txt_IdChof);
            this.Gpb_Vehiculo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Vehiculo.Location = new System.Drawing.Point(24, 291);
            this.Gpb_Vehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Vehiculo.Name = "Gpb_Vehiculo";
            this.Gpb_Vehiculo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Vehiculo.Size = new System.Drawing.Size(902, 244);
            this.Gpb_Vehiculo.TabIndex = 32;
            this.Gpb_Vehiculo.TabStop = false;
            this.Gpb_Vehiculo.Text = "Datos Vehiculo";
            // 
            // Txt_IDVeh
            // 
            this.Txt_IDVeh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IDVeh.Location = new System.Drawing.Point(522, 21);
            this.Txt_IDVeh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_IDVeh.Name = "Txt_IDVeh";
            this.Txt_IDVeh.Size = new System.Drawing.Size(104, 30);
            this.Txt_IDVeh.TabIndex = 21;
            // 
            // Txt_IdVehicu
            // 
            this.Txt_IdVehicu.AutoSize = true;
            this.Txt_IdVehicu.Location = new System.Drawing.Point(401, 21);
            this.Txt_IdVehicu.Name = "Txt_IdVehicu";
            this.Txt_IdVehicu.Size = new System.Drawing.Size(115, 23);
            this.Txt_IdVehicu.TabIndex = 20;
            this.Txt_IdVehicu.Text = "ID Vehículo:";
            // 
            // Txt_HS
            // 
            this.Txt_HS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_HS.Location = new System.Drawing.Point(701, 116);
            this.Txt_HS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_HS.Name = "Txt_HS";
            this.Txt_HS.Size = new System.Drawing.Size(175, 30);
            this.Txt_HS.TabIndex = 19;
            this.Txt_HS.TextChanged += new System.EventHandler(this.Txt_HS_TextChanged);
            // 
            // Txt_HLL
            // 
            this.Txt_HLL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_HLL.Location = new System.Drawing.Point(701, 79);
            this.Txt_HLL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_HLL.Name = "Txt_HLL";
            this.Txt_HLL.Size = new System.Drawing.Size(175, 30);
            this.Txt_HLL.TabIndex = 18;
            this.Txt_HLL.TextChanged += new System.EventHandler(this.Txt_HLL_TextChanged);
            // 
            // Txt_Total
            // 
            this.Txt_Total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total.Location = new System.Drawing.Point(701, 157);
            this.Txt_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(175, 30);
            this.Txt_Total.TabIndex = 17;
            // 
            // Txt_Desc
            // 
            this.Txt_Desc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Desc.Location = new System.Drawing.Point(172, 198);
            this.Txt_Desc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Desc.Name = "Txt_Desc";
            this.Txt_Desc.Size = new System.Drawing.Size(208, 30);
            this.Txt_Desc.TabIndex = 14;
            // 
            // Txt_Color
            // 
            this.Txt_Color.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Color.Location = new System.Drawing.Point(166, 157);
            this.Txt_Color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Color.Name = "Txt_Color";
            this.Txt_Color.Size = new System.Drawing.Size(210, 30);
            this.Txt_Color.TabIndex = 13;
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Marca.Location = new System.Drawing.Point(174, 118);
            this.Txt_Marca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.Size = new System.Drawing.Size(210, 30);
            this.Txt_Marca.TabIndex = 12;
            // 
            // Txt_Placa
            // 
            this.Txt_Placa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Placa.Location = new System.Drawing.Point(174, 86);
            this.Txt_Placa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Placa.Name = "Txt_Placa";
            this.Txt_Placa.Size = new System.Drawing.Size(208, 30);
            this.Txt_Placa.TabIndex = 11;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ID.Location = new System.Drawing.Point(289, 19);
            this.Txt_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(80, 30);
            this.Txt_ID.TabIndex = 9;
            // 
            // Txt_HoraSalida
            // 
            this.Txt_HoraSalida.AutoSize = true;
            this.Txt_HoraSalida.Location = new System.Drawing.Point(542, 123);
            this.Txt_HoraSalida.Name = "Txt_HoraSalida";
            this.Txt_HoraSalida.Size = new System.Drawing.Size(153, 23);
            this.Txt_HoraSalida.TabIndex = 8;
            this.Txt_HoraSalida.Text = "HORA SALIDA:";
            // 
            // Txt_Peso
            // 
            this.Txt_Peso.AutoSize = true;
            this.Txt_Peso.Location = new System.Drawing.Point(553, 164);
            this.Txt_Peso.Name = "Txt_Peso";
            this.Txt_Peso.Size = new System.Drawing.Size(142, 23);
            this.Txt_Peso.TabIndex = 6;
            this.Txt_Peso.Text = "PESO TOTAL:";
            this.Txt_Peso.Click += new System.EventHandler(this.Txt_Peso_Click);
            // 
            // Txt_HoraLlegada
            // 
            this.Txt_HoraLlegada.AutoSize = true;
            this.Txt_HoraLlegada.Location = new System.Drawing.Point(518, 88);
            this.Txt_HoraLlegada.Name = "Txt_HoraLlegada";
            this.Txt_HoraLlegada.Size = new System.Drawing.Size(177, 23);
            this.Txt_HoraLlegada.TabIndex = 5;
            this.Txt_HoraLlegada.Text = "HORA LLEGADA:";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.AutoSize = true;
            this.Txt_Descripcion.Location = new System.Drawing.Point(13, 200);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(153, 23);
            this.Txt_Descripcion.TabIndex = 4;
            this.Txt_Descripcion.Text = "DESCRIPCION:";
            // 
            // Txt_Col
            // 
            this.Txt_Col.AutoSize = true;
            this.Txt_Col.Location = new System.Drawing.Point(70, 157);
            this.Txt_Col.Name = "Txt_Col";
            this.Txt_Col.Size = new System.Drawing.Size(90, 23);
            this.Txt_Col.TabIndex = 3;
            this.Txt_Col.Text = "COLOR:";
            // 
            // Txt_Marc
            // 
            this.Txt_Marc.AutoSize = true;
            this.Txt_Marc.Location = new System.Drawing.Point(70, 118);
            this.Txt_Marc.Name = "Txt_Marc";
            this.Txt_Marc.Size = new System.Drawing.Size(91, 23);
            this.Txt_Marc.TabIndex = 2;
            this.Txt_Marc.Text = "MARCA:";
            // 
            // Txt_Plac
            // 
            this.Txt_Plac.AutoSize = true;
            this.Txt_Plac.Location = new System.Drawing.Point(52, 86);
            this.Txt_Plac.Name = "Txt_Plac";
            this.Txt_Plac.Size = new System.Drawing.Size(109, 23);
            this.Txt_Plac.TabIndex = 1;
            this.Txt_Plac.Text = "Nª PLACA:";
            // 
            // Txt_IdChof
            // 
            this.Txt_IdChof.AutoSize = true;
            this.Txt_IdChof.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdChof.Location = new System.Drawing.Point(168, 28);
            this.Txt_IdChof.Name = "Txt_IdChof";
            this.Txt_IdChof.Size = new System.Drawing.Size(102, 23);
            this.Txt_IdChof.TabIndex = 0;
            this.Txt_IdChof.Text = "ID Chofer:";
            // 
            // Pic_Transporte
            // 
            this.Pic_Transporte.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Transporte.Image")));
            this.Pic_Transporte.Location = new System.Drawing.Point(993, 90);
            this.Pic_Transporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pic_Transporte.Name = "Pic_Transporte";
            this.Pic_Transporte.Size = new System.Drawing.Size(386, 310);
            this.Pic_Transporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Transporte.TabIndex = 34;
            this.Pic_Transporte.TabStop = false;
            // 
            // Transporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1700, 878);
            this.Controls.Add(this.Pic_Transporte);
            this.Controls.Add(this.Txt_Datos);
            this.Controls.Add(this.Gpb_Mantenimiento);
            this.Controls.Add(this.Gpb_Vehiculo);
            this.Controls.Add(this.Gpb_Detalle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Transporte";
            this.Text = "Transporte";
            this.Gpb_Detalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vehiculo)).EndInit();
            this.Gpb_Mantenimiento.ResumeLayout(false);
            this.Gpb_Vehiculo.ResumeLayout(false);
            this.Gpb_Vehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Transporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       



        #endregion

        private System.Windows.Forms.GroupBox Gpb_Detalle;
        private System.Windows.Forms.DataGridView Dgv_Vehiculo;
        private System.Windows.Forms.GroupBox Gpb_Mantenimiento;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.PictureBox Pic_Transporte;
        private System.Windows.Forms.Label Txt_Datos;
        private System.Windows.Forms.GroupBox Gpb_Vehiculo;
        private System.Windows.Forms.TextBox Txt_HS;
        private System.Windows.Forms.TextBox Txt_HLL;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.TextBox Txt_Desc;
        private System.Windows.Forms.TextBox Txt_Color;
        private System.Windows.Forms.TextBox Txt_Marca;
        private System.Windows.Forms.TextBox Txt_Placa;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label Txt_HoraSalida;
        private System.Windows.Forms.Label Txt_Peso;
        private System.Windows.Forms.Label Txt_HoraLlegada;
        private System.Windows.Forms.Label Txt_Descripcion;
        private System.Windows.Forms.Label Txt_Col;
        private System.Windows.Forms.Label Txt_Marc;
        private System.Windows.Forms.Label Txt_Plac;
        private System.Windows.Forms.Label Txt_IdChof;
        private System.Windows.Forms.TextBox Txt_IDVeh;
        private System.Windows.Forms.Label Txt_IdVehicu;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Reporte;
    }
}