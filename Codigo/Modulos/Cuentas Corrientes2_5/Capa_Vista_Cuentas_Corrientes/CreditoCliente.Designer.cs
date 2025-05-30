
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class CreditoCliente
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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_depto = new System.Windows.Forms.TextBox();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.Txt_encargado = new System.Windows.Forms.TextBox();
            this.Txt_documento = new System.Windows.Forms.TextBox();
            this.Lbl_depto = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_encargado = new System.Windows.Forms.Label();
            this.Lbl_documento = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Txt_saldo = new System.Windows.Forms.TextBox();
            this.Lbl_saldo = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(299, 24);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(288, 16);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "ACTUALIZACION DE CREDITO MENSUAL";
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Location = new System.Drawing.Point(617, 154);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(113, 31);
            this.Btn_actualizar.TabIndex = 24;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(617, 113);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(113, 32);
            this.Btn_editar.TabIndex = 23;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(617, 72);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(113, 35);
            this.Btn_buscar.TabIndex = 22;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Txt_depto
            // 
            this.Txt_depto.Location = new System.Drawing.Point(215, 167);
            this.Txt_depto.Name = "Txt_depto";
            this.Txt_depto.Size = new System.Drawing.Size(198, 20);
            this.Txt_depto.TabIndex = 21;
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Location = new System.Drawing.Point(215, 140);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(198, 20);
            this.Txt_fecha.TabIndex = 20;
            // 
            // Txt_encargado
            // 
            this.Txt_encargado.Location = new System.Drawing.Point(215, 113);
            this.Txt_encargado.Name = "Txt_encargado";
            this.Txt_encargado.Size = new System.Drawing.Size(198, 20);
            this.Txt_encargado.TabIndex = 19;
            // 
            // Txt_documento
            // 
            this.Txt_documento.Location = new System.Drawing.Point(215, 86);
            this.Txt_documento.Name = "Txt_documento";
            this.Txt_documento.Size = new System.Drawing.Size(116, 20);
            this.Txt_documento.TabIndex = 18;
            // 
            // Lbl_depto
            // 
            this.Lbl_depto.AutoSize = true;
            this.Lbl_depto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_depto.Location = new System.Drawing.Point(56, 170);
            this.Lbl_depto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_depto.Name = "Lbl_depto";
            this.Lbl_depto.Size = new System.Drawing.Size(89, 15);
            this.Lbl_depto.TabIndex = 17;
            this.Lbl_depto.Text = "Departamento:";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(56, 140);
            this.Lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(44, 15);
            this.Lbl_fecha.TabIndex = 16;
            this.Lbl_fecha.Text = "Fecha:";
            // 
            // Lbl_encargado
            // 
            this.Lbl_encargado.AutoSize = true;
            this.Lbl_encargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_encargado.Location = new System.Drawing.Point(56, 113);
            this.Lbl_encargado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_encargado.Name = "Lbl_encargado";
            this.Lbl_encargado.Size = new System.Drawing.Size(70, 15);
            this.Lbl_encargado.TabIndex = 15;
            this.Lbl_encargado.Text = "Encargado:";
            // 
            // Lbl_documento
            // 
            this.Lbl_documento.AutoSize = true;
            this.Lbl_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_documento.Location = new System.Drawing.Point(56, 86);
            this.Lbl_documento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_documento.Name = "Lbl_documento";
            this.Lbl_documento.Size = new System.Drawing.Size(115, 15);
            this.Lbl_documento.TabIndex = 14;
            this.Lbl_documento.Text = "No. De Documento:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 189);
            this.dataGridView1.TabIndex = 25;
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.Location = new System.Drawing.Point(617, 191);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(113, 31);
            this.Btn_borrar.TabIndex = 26;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.UseVisualStyleBackColor = true;
            // 
            // Txt_saldo
            // 
            this.Txt_saldo.Location = new System.Drawing.Point(215, 197);
            this.Txt_saldo.Name = "Txt_saldo";
            this.Txt_saldo.Size = new System.Drawing.Size(198, 20);
            this.Txt_saldo.TabIndex = 28;
            // 
            // Lbl_saldo
            // 
            this.Lbl_saldo.AutoSize = true;
            this.Lbl_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_saldo.Location = new System.Drawing.Point(56, 200);
            this.Lbl_saldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_saldo.Name = "Lbl_saldo";
            this.Lbl_saldo.Size = new System.Drawing.Size(45, 15);
            this.Lbl_saldo.TabIndex = 27;
            this.Lbl_saldo.Text = "Saldo: ";
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Location = new System.Drawing.Point(338, 470);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(104, 36);
            this.Btn_imprimir.TabIndex = 29;
            this.Btn_imprimir.Text = "Imprimir ";
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // CreditoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(814, 518);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.Txt_saldo);
            this.Controls.Add(this.Lbl_saldo);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_depto);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.Txt_encargado);
            this.Controls.Add(this.Txt_documento);
            this.Controls.Add(this.Lbl_depto);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_encargado);
            this.Controls.Add(this.Lbl_documento);
            this.Controls.Add(this.Lbl_titulo);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "CreditoCliente";
            this.Text = "CreditoCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_depto;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.TextBox Txt_encargado;
        private System.Windows.Forms.TextBox Txt_documento;
        private System.Windows.Forms.Label Lbl_depto;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_encargado;
        private System.Windows.Forms.Label Lbl_documento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.TextBox Txt_saldo;
        private System.Windows.Forms.Label Lbl_saldo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button Btn_imprimir;
    }
}