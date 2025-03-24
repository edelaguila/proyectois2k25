
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class MovimientoMensual
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
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Dgv_movimiento = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_documento = new System.Windows.Forms.TextBox();
            this.Lbl_documento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(616, 86);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(123, 38);
            this.Btn_buscar.TabIndex = 0;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Dgv_movimiento
            // 
            this.Dgv_movimiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Dgv_movimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_movimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Pago,
            this.Cliente,
            this.Movimiento});
            this.Dgv_movimiento.Location = new System.Drawing.Point(41, 271);
            this.Dgv_movimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgv_movimiento.Name = "Dgv_movimiento";
            this.Dgv_movimiento.RowHeadersWidth = 51;
            this.Dgv_movimiento.Size = new System.Drawing.Size(720, 171);
            this.Dgv_movimiento.TabIndex = 3;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Column1";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Column1";
            this.Pago.MinimumWidth = 6;
            this.Pago.Name = "Pago";
            this.Pago.Width = 125;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Column1";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 125;
            // 
            // Movimiento
            // 
            this.Movimiento.HeaderText = "Column1";
            this.Movimiento.MinimumWidth = 6;
            this.Movimiento.Name = "Movimiento";
            this.Movimiento.Width = 125;
            // 
            // Txt_documento
            // 
            this.Txt_documento.Location = new System.Drawing.Point(174, 113);
            this.Txt_documento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_documento.Name = "Txt_documento";
            this.Txt_documento.Size = new System.Drawing.Size(360, 22);
            this.Txt_documento.TabIndex = 5;
            // 
            // Lbl_documento
            // 
            this.Lbl_documento.AutoSize = true;
            this.Lbl_documento.Location = new System.Drawing.Point(19, 116);
            this.Lbl_documento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_documento.Name = "Lbl_documento";
            this.Lbl_documento.Size = new System.Drawing.Size(136, 17);
            this.Lbl_documento.TabIndex = 6;
            this.Lbl_documento.Text = "No. De Documento: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha: ";
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Location = new System.Drawing.Point(616, 132);
            this.Btn_imprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(123, 40);
            this.Btn_imprimir.TabIndex = 8;
            this.Btn_imprimir.Text = "Imprimir";
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // MovimientoMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(847, 544);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_documento);
            this.Controls.Add(this.Txt_documento);
            this.Controls.Add(this.Dgv_movimiento);
            this.Controls.Add(this.Btn_buscar);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MovimientoMensual";
            this.Text = "MovimientoMensual";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.DataGridView Dgv_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movimiento;
        private System.Windows.Forms.TextBox Txt_documento;
        private System.Windows.Forms.Label Lbl_documento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}