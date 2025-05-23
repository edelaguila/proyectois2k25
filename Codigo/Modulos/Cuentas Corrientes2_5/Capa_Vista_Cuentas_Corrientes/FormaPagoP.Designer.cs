
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class FormaPagoP
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
            this.DgvFormaPago = new System.Windows.Forms.DataGridView();
            this.Cbo_Moneda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbo_Nombre = new System.Windows.Forms.ComboBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Txt_id_pago = new System.Windows.Forms.TextBox();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_encargado = new System.Windows.Forms.Label();
            this.Lbl_documento = new System.Windows.Forms.Label();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFormaPago)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFormaPago
            // 
            this.DgvFormaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFormaPago.Location = new System.Drawing.Point(36, 281);
            this.DgvFormaPago.Name = "DgvFormaPago";
            this.DgvFormaPago.RowHeadersWidth = 51;
            this.DgvFormaPago.RowTemplate.Height = 24;
            this.DgvFormaPago.Size = new System.Drawing.Size(828, 235);
            this.DgvFormaPago.TabIndex = 80;
            // 
            // Cbo_Moneda
            // 
            this.Cbo_Moneda.FormattingEnabled = true;
            this.Cbo_Moneda.Items.AddRange(new object[] {
            "1.  Quetzal ",
            "2.  Dolar"});
            this.Cbo_Moneda.Location = new System.Drawing.Point(443, 133);
            this.Cbo_Moneda.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Moneda.Name = "Cbo_Moneda";
            this.Cbo_Moneda.Size = new System.Drawing.Size(176, 24);
            this.Cbo_Moneda.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 78;
            this.label2.Text = "Moneda: ";
            // 
            // Cbo_Nombre
            // 
            this.Cbo_Nombre.FormattingEnabled = true;
            this.Cbo_Nombre.Items.AddRange(new object[] {
            "1. Efectivo Quetzales ",
            "2. Efectivo Dolares",
            "3. Tarjeta de Crédito ",
            "4. Cheques",
            "5. Crédito",
            "6. Otros"});
            this.Cbo_Nombre.Location = new System.Drawing.Point(443, 96);
            this.Cbo_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Nombre.Name = "Cbo_Nombre";
            this.Cbo_Nombre.Size = new System.Drawing.Size(176, 24);
            this.Cbo_Nombre.TabIndex = 77;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(36, 216);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(151, 43);
            this.Btn_guardar.TabIndex = 76;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, -50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "TIPOS DE PAGO CLIENTE";
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Items.AddRange(new object[] {
            "1",
            "0"});
            this.Cbo_Estado.Location = new System.Drawing.Point(443, 166);
            this.Cbo_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(176, 24);
            this.Cbo_Estado.TabIndex = 74;
            // 
            // Txt_id_pago
            // 
            this.Txt_id_pago.Location = new System.Drawing.Point(443, 63);
            this.Txt_id_pago.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_id_pago.Name = "Txt_id_pago";
            this.Txt_id_pago.Size = new System.Drawing.Size(176, 22);
            this.Txt_id_pago.TabIndex = 73;
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(231, 165);
            this.Lbl_fecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(63, 18);
            this.Lbl_fecha.TabIndex = 72;
            this.Lbl_fecha.Text = "Estado: ";
            // 
            // Lbl_encargado
            // 
            this.Lbl_encargado.AutoSize = true;
            this.Lbl_encargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_encargado.Location = new System.Drawing.Point(231, 96);
            this.Lbl_encargado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_encargado.Name = "Lbl_encargado";
            this.Lbl_encargado.Size = new System.Drawing.Size(70, 18);
            this.Lbl_encargado.TabIndex = 71;
            this.Lbl_encargado.Text = "Nombre: ";
            // 
            // Lbl_documento
            // 
            this.Lbl_documento.AutoSize = true;
            this.Lbl_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_documento.Location = new System.Drawing.Point(231, 63);
            this.Lbl_documento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_documento.Name = "Lbl_documento";
            this.Lbl_documento.Size = new System.Drawing.Size(61, 18);
            this.Lbl_documento.TabIndex = 70;
            this.Lbl_documento.Text = "ID Pago";
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.Location = new System.Drawing.Point(713, 216);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(151, 43);
            this.Btn_borrar.TabIndex = 69;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.UseVisualStyleBackColor = true;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click_1);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Btn_actualizar.Location = new System.Drawing.Point(541, 216);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(151, 43);
            this.Btn_actualizar.TabIndex = 68;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click_1);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(368, 216);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(151, 43);
            this.Btn_editar.TabIndex = 67;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(194, 216);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(151, 43);
            this.Btn_buscar.TabIndex = 66;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click_1);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(340, 9);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(235, 21);
            this.Lbl_titulo.TabIndex = 81;
            this.Lbl_titulo.Text = "TIPOS DE PAGO PROVEEDOR";
            // 
            // FormaPagoP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(916, 555);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.DgvFormaPago);
            this.Controls.Add(this.Cbo_Moneda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cbo_Nombre);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbo_Estado);
            this.Controls.Add(this.Txt_id_pago);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_encargado);
            this.Controls.Add(this.Lbl_documento);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_buscar);
            this.Name = "FormaPagoP";
            this.Text = "FormaPagoP";
            ((System.ComponentModel.ISupportInitialize)(this.DgvFormaPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvFormaPago;
        private System.Windows.Forms.ComboBox Cbo_Moneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_Nombre;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.TextBox Txt_id_pago;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_encargado;
        private System.Windows.Forms.Label Lbl_documento;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label Lbl_titulo;
    }
}