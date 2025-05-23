
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Movimientos_Proveedor
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
            this.Dgv_movi_provee = new System.Windows.Forms.DataGridView();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Generar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Txt_Movimiento = new System.Windows.Forms.Label();
            this.txt_nmovimiento = new System.Windows.Forms.TextBox();
            this.Txt_Estado = new System.Windows.Forms.Label();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Dtp_del = new System.Windows.Forms.DateTimePicker();
            this.Txt_fecha_ini = new System.Windows.Forms.Label();
            this.Txt_fecha_fin = new System.Windows.Forms.Label();
            this.Dtp_al = new System.Windows.Forms.DateTimePicker();
            this.Txt_Proveedor = new System.Windows.Forms.Label();
            this.Cbo_proveedor = new System.Windows.Forms.ComboBox();
            this.Txt_Tipo_mov = new System.Windows.Forms.Label();
            this.Cbo_tipo_mov = new System.Windows.Forms.ComboBox();
            this.Txt_Monto = new System.Windows.Forms.Label();
            this.txt_monto_mov = new System.Windows.Forms.TextBox();
            this.Txt_metodo = new System.Windows.Forms.Label();
            this.Cbo_metodo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movi_provee)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_movi_provee
            // 
            this.Dgv_movi_provee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_movi_provee.Location = new System.Drawing.Point(2, 358);
            this.Dgv_movi_provee.Name = "Dgv_movi_provee";
            this.Dgv_movi_provee.RowHeadersWidth = 51;
            this.Dgv_movi_provee.RowTemplate.Height = 24;
            this.Dgv_movi_provee.Size = new System.Drawing.Size(795, 187);
            this.Dgv_movi_provee.TabIndex = 0;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(12, 26);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Nuevo.TabIndex = 1;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(172, 26);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 2;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(343, 27);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Editar.TabIndex = 3;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(503, 27);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Eliminar.TabIndex = 4;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(678, 27);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpiar.TabIndex = 5;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_Generar
            // 
            this.Btn_Generar.Location = new System.Drawing.Point(661, 155);
            this.Btn_Generar.Name = "Btn_Generar";
            this.Btn_Generar.Size = new System.Drawing.Size(101, 23);
            this.Btn_Generar.TabIndex = 6;
            this.Btn_Generar.Text = "Generar PDF";
            this.Btn_Generar.UseVisualStyleBackColor = true;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Location = new System.Drawing.Point(669, 278);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(84, 23);
            this.Btn_Actualizar.TabIndex = 7;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // Txt_Movimiento
            // 
            this.Txt_Movimiento.AutoSize = true;
            this.Txt_Movimiento.Location = new System.Drawing.Point(12, 88);
            this.Txt_Movimiento.Name = "Txt_Movimiento";
            this.Txt_Movimiento.Size = new System.Drawing.Size(120, 17);
            this.Txt_Movimiento.TabIndex = 8;
            this.Txt_Movimiento.Text = "Núm_movimiento:";
            this.Txt_Movimiento.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nmovimiento
            // 
            this.txt_nmovimiento.Location = new System.Drawing.Point(129, 88);
            this.txt_nmovimiento.Name = "txt_nmovimiento";
            this.txt_nmovimiento.Size = new System.Drawing.Size(150, 22);
            this.txt_nmovimiento.TabIndex = 9;
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.AutoSize = true;
            this.Txt_Estado.Location = new System.Drawing.Point(362, 93);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(56, 17);
            this.Txt_Estado.TabIndex = 10;
            this.Txt_Estado.Text = "Estado:";
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(424, 88);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(172, 24);
            this.Cbo_Estado.TabIndex = 11;
            // 
            // Dtp_del
            // 
            this.Dtp_del.Location = new System.Drawing.Point(47, 150);
            this.Dtp_del.Name = "Dtp_del";
            this.Dtp_del.Size = new System.Drawing.Size(244, 22);
            this.Dtp_del.TabIndex = 12;
            // 
            // Txt_fecha_ini
            // 
            this.Txt_fecha_ini.AutoSize = true;
            this.Txt_fecha_ini.Location = new System.Drawing.Point(12, 150);
            this.Txt_fecha_ini.Name = "Txt_fecha_ini";
            this.Txt_fecha_ini.Size = new System.Drawing.Size(33, 17);
            this.Txt_fecha_ini.TabIndex = 13;
            this.Txt_fecha_ini.Text = "Del:";
            // 
            // Txt_fecha_fin
            // 
            this.Txt_fecha_fin.AutoSize = true;
            this.Txt_fecha_fin.Location = new System.Drawing.Point(340, 155);
            this.Txt_fecha_fin.Name = "Txt_fecha_fin";
            this.Txt_fecha_fin.Size = new System.Drawing.Size(24, 17);
            this.Txt_fecha_fin.TabIndex = 14;
            this.Txt_fecha_fin.Text = "Al:";
            // 
            // Dtp_al
            // 
            this.Dtp_al.Location = new System.Drawing.Point(370, 155);
            this.Dtp_al.Name = "Dtp_al";
            this.Dtp_al.Size = new System.Drawing.Size(245, 22);
            this.Dtp_al.TabIndex = 15;
            // 
            // Txt_Proveedor
            // 
            this.Txt_Proveedor.AutoSize = true;
            this.Txt_Proveedor.Location = new System.Drawing.Point(12, 214);
            this.Txt_Proveedor.Name = "Txt_Proveedor";
            this.Txt_Proveedor.Size = new System.Drawing.Size(78, 17);
            this.Txt_Proveedor.TabIndex = 16;
            this.Txt_Proveedor.Text = "Proveedor:";
            // 
            // Cbo_proveedor
            // 
            this.Cbo_proveedor.FormattingEnabled = true;
            this.Cbo_proveedor.Location = new System.Drawing.Point(96, 211);
            this.Cbo_proveedor.Name = "Cbo_proveedor";
            this.Cbo_proveedor.Size = new System.Drawing.Size(166, 24);
            this.Cbo_proveedor.TabIndex = 17;
            // 
            // Txt_Tipo_mov
            // 
            this.Txt_Tipo_mov.AutoSize = true;
            this.Txt_Tipo_mov.Location = new System.Drawing.Point(330, 214);
            this.Txt_Tipo_mov.Name = "Txt_Tipo_mov";
            this.Txt_Tipo_mov.Size = new System.Drawing.Size(135, 17);
            this.Txt_Tipo_mov.TabIndex = 18;
            this.Txt_Tipo_mov.Text = "Tipo de movimiento:";
            // 
            // Cbo_tipo_mov
            // 
            this.Cbo_tipo_mov.FormattingEnabled = true;
            this.Cbo_tipo_mov.Location = new System.Drawing.Point(472, 214);
            this.Cbo_tipo_mov.Name = "Cbo_tipo_mov";
            this.Cbo_tipo_mov.Size = new System.Drawing.Size(187, 24);
            this.Cbo_tipo_mov.TabIndex = 19;
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.AutoSize = true;
            this.Txt_Monto.Location = new System.Drawing.Point(12, 274);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(149, 17);
            this.Txt_Monto.TabIndex = 20;
            this.Txt_Monto.Text = "Monto del movimiento:";
            // 
            // txt_monto_mov
            // 
            this.txt_monto_mov.Location = new System.Drawing.Point(168, 274);
            this.txt_monto_mov.Name = "txt_monto_mov";
            this.txt_monto_mov.Size = new System.Drawing.Size(131, 22);
            this.txt_monto_mov.TabIndex = 21;
            // 
            // Txt_metodo
            // 
            this.Txt_metodo.AutoSize = true;
            this.Txt_metodo.Location = new System.Drawing.Point(330, 277);
            this.Txt_metodo.Name = "Txt_metodo";
            this.Txt_metodo.Size = new System.Drawing.Size(115, 17);
            this.Txt_metodo.TabIndex = 22;
            this.Txt_metodo.Text = "Método de pago:";
            // 
            // Cbo_metodo
            // 
            this.Cbo_metodo.FormattingEnabled = true;
            this.Cbo_metodo.Location = new System.Drawing.Point(452, 277);
            this.Cbo_metodo.Name = "Cbo_metodo";
            this.Cbo_metodo.Size = new System.Drawing.Size(144, 24);
            this.Cbo_metodo.TabIndex = 23;
            // 
            // Movimientos_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 618);
            this.Controls.Add(this.Cbo_metodo);
            this.Controls.Add(this.Txt_metodo);
            this.Controls.Add(this.txt_monto_mov);
            this.Controls.Add(this.Txt_Monto);
            this.Controls.Add(this.Cbo_tipo_mov);
            this.Controls.Add(this.Txt_Tipo_mov);
            this.Controls.Add(this.Cbo_proveedor);
            this.Controls.Add(this.Txt_Proveedor);
            this.Controls.Add(this.Dtp_al);
            this.Controls.Add(this.Txt_fecha_fin);
            this.Controls.Add(this.Txt_fecha_ini);
            this.Controls.Add(this.Dtp_del);
            this.Controls.Add(this.Cbo_Estado);
            this.Controls.Add(this.Txt_Estado);
            this.Controls.Add(this.txt_nmovimiento);
            this.Controls.Add(this.Txt_Movimiento);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Generar);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Dgv_movi_provee);
            this.Name = "Movimientos_Proveedor";
            this.Text = "Movimientos_Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movi_provee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_movi_provee;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Generar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Label Txt_Movimiento;
        private System.Windows.Forms.TextBox txt_nmovimiento;
        private System.Windows.Forms.Label Txt_Estado;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.DateTimePicker Dtp_del;
        private System.Windows.Forms.Label Txt_fecha_ini;
        private System.Windows.Forms.Label Txt_fecha_fin;
        private System.Windows.Forms.DateTimePicker Dtp_al;
        private System.Windows.Forms.Label Txt_Proveedor;
        private System.Windows.Forms.ComboBox Cbo_proveedor;
        private System.Windows.Forms.Label Txt_Tipo_mov;
        private System.Windows.Forms.ComboBox Cbo_tipo_mov;
        private System.Windows.Forms.Label Txt_Monto;
        private System.Windows.Forms.TextBox txt_monto_mov;
        private System.Windows.Forms.Label Txt_metodo;
        private System.Windows.Forms.ComboBox Cbo_metodo;
    }
}