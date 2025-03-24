
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Mantenimiento
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Text_ID = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Cmbo_Tipo = new System.Windows.Forms.ComboBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Cmbo_Estado = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Cmbo_EstadoFinanciero = new System.Windows.Forms.ComboBox();
            this.Lbl_EstadoFinanciero = new System.Windows.Forms.Label();
            this.Dgv_Mantenimiento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(324, 18);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(326, 24);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Mantenimiento de Cuentas Corrientes";
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Lbl_ID.Location = new System.Drawing.Point(54, 79);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(117, 17);
            this.Lbl_ID.TabIndex = 1;
            this.Lbl_ID.Text = "ID Mantenimiento";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.Location = new System.Drawing.Point(8, 127);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(163, 40);
            this.Lbl_Nombre.TabIndex = 2;
            this.Lbl_Nombre.Text = "Nombre de quien solicita el mantenimiento";
            this.Lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Location = new System.Drawing.Point(486, 134);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(152, 17);
            this.Lbl_Tipo.TabIndex = 3;
            this.Lbl_Tipo.Text = "Tipo de mantenimiento";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Location = new System.Drawing.Point(584, 203);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(47, 17);
            this.Lbl_Fecha.TabIndex = 4;
            this.Lbl_Fecha.Text = "Fecha";
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(644, 198);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(266, 22);
            this.Dtp_Fecha.TabIndex = 7;
            // 
            // Text_ID
            // 
            this.Text_ID.Location = new System.Drawing.Point(178, 79);
            this.Text_ID.Name = "Text_ID";
            this.Text_ID.Size = new System.Drawing.Size(272, 22);
            this.Text_ID.TabIndex = 8;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(178, 136);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(272, 22);
            this.Txt_Nombre.TabIndex = 9;
            // 
            // Cmbo_Tipo
            // 
            this.Cmbo_Tipo.FormattingEnabled = true;
            this.Cmbo_Tipo.Location = new System.Drawing.Point(645, 134);
            this.Cmbo_Tipo.Name = "Cmbo_Tipo";
            this.Cmbo_Tipo.Size = new System.Drawing.Size(272, 24);
            this.Cmbo_Tipo.TabIndex = 10;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(275, 264);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(87, 46);
            this.Btn_Guardar.TabIndex = 11;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(370, 264);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(90, 46);
            this.Btn_Editar.TabIndex = 12;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Location = new System.Drawing.Point(466, 264);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(90, 46);
            this.Btn_Actualizar.TabIndex = 13;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(562, 264);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(88, 46);
            this.Btn_Eliminar.TabIndex = 14;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Location = new System.Drawing.Point(895, 12);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(75, 30);
            this.Btn_Regresar.TabIndex = 15;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Location = new System.Drawing.Point(656, 264);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(88, 46);
            this.Btn_Imprimir.TabIndex = 16;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // Cmbo_Estado
            // 
            this.Cmbo_Estado.FormattingEnabled = true;
            this.Cmbo_Estado.Location = new System.Drawing.Point(178, 200);
            this.Cmbo_Estado.Name = "Cmbo_Estado";
            this.Cmbo_Estado.Size = new System.Drawing.Size(272, 24);
            this.Cmbo_Estado.TabIndex = 18;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.Location = new System.Drawing.Point(12, 193);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(152, 36);
            this.Lbl_Estado.TabIndex = 17;
            this.Lbl_Estado.Text = "Estado del Cliente/Proveedor";
            this.Lbl_Estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cmbo_EstadoFinanciero
            // 
            this.Cmbo_EstadoFinanciero.FormattingEnabled = true;
            this.Cmbo_EstadoFinanciero.Location = new System.Drawing.Point(645, 79);
            this.Cmbo_EstadoFinanciero.Name = "Cmbo_EstadoFinanciero";
            this.Cmbo_EstadoFinanciero.Size = new System.Drawing.Size(272, 24);
            this.Cmbo_EstadoFinanciero.TabIndex = 20;
            // 
            // Lbl_EstadoFinanciero
            // 
            this.Lbl_EstadoFinanciero.Location = new System.Drawing.Point(479, 72);
            this.Lbl_EstadoFinanciero.Name = "Lbl_EstadoFinanciero";
            this.Lbl_EstadoFinanciero.Size = new System.Drawing.Size(152, 36);
            this.Lbl_EstadoFinanciero.TabIndex = 19;
            this.Lbl_EstadoFinanciero.Text = "Estado financiero del Cliente/Proveedor";
            this.Lbl_EstadoFinanciero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Dgv_Mantenimiento
            // 
            this.Dgv_Mantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Mantenimiento.Location = new System.Drawing.Point(15, 329);
            this.Dgv_Mantenimiento.Name = "Dgv_Mantenimiento";
            this.Dgv_Mantenimiento.RowHeadersWidth = 51;
            this.Dgv_Mantenimiento.RowTemplate.Height = 24;
            this.Dgv_Mantenimiento.Size = new System.Drawing.Size(928, 208);
            this.Dgv_Mantenimiento.TabIndex = 21;
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(982, 573);
            this.Controls.Add(this.Dgv_Mantenimiento);
            this.Controls.Add(this.Cmbo_EstadoFinanciero);
            this.Controls.Add(this.Lbl_EstadoFinanciero);
            this.Controls.Add(this.Cmbo_Estado);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.Btn_Regresar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Cmbo_Tipo);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Text_ID);
            this.Controls.Add(this.Dtp_Fecha);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Lbl_Tipo);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.TextBox Text_ID;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.ComboBox Cmbo_Tipo;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.ComboBox Cmbo_Estado;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.ComboBox Cmbo_EstadoFinanciero;
        private System.Windows.Forms.Label Lbl_EstadoFinanciero;
        private System.Windows.Forms.DataGridView Dgv_Mantenimiento;
    }
}