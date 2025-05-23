
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class SaldoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaldoCliente));
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Dgv_saldomensual = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_documento = new System.Windows.Forms.Label();
            this.Lbl_encargado = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_depto = new System.Windows.Forms.Label();
            this.Txt_documento = new System.Windows.Forms.TextBox();
            this.Txt_encargado = new System.Windows.Forms.TextBox();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.Txt_depto = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_saldomensual)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(363, 39);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(211, 16);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "SALDO MENSUAL CLIENTES";
            // 
            // Dgv_saldomensual
            // 
            this.Dgv_saldomensual.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Dgv_saldomensual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_saldomensual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Saldo,
            this.Producto,
            this.Encargado});
            this.Dgv_saldomensual.Location = new System.Drawing.Point(72, 321);
            this.Dgv_saldomensual.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_saldomensual.Name = "Dgv_saldomensual";
            this.Dgv_saldomensual.Size = new System.Drawing.Size(758, 231);
            this.Dgv_saldomensual.TabIndex = 1;
            this.Dgv_saldomensual.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Column1";
            this.Nombre.Name = "Nombre";
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Column1";
            this.Saldo.Name = "Saldo";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Column1";
            this.Producto.Name = "Producto";
            // 
            // Encargado
            // 
            this.Encargado.HeaderText = "Column1";
            this.Encargado.Name = "Encargado";
            // 
            // Lbl_documento
            // 
            this.Lbl_documento.AutoSize = true;
            this.Lbl_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_documento.Location = new System.Drawing.Point(69, 95);
            this.Lbl_documento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_documento.Name = "Lbl_documento";
            this.Lbl_documento.Size = new System.Drawing.Size(115, 15);
            this.Lbl_documento.TabIndex = 2;
            this.Lbl_documento.Text = "No. De Documento:";
            // 
            // Lbl_encargado
            // 
            this.Lbl_encargado.AutoSize = true;
            this.Lbl_encargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_encargado.Location = new System.Drawing.Point(69, 122);
            this.Lbl_encargado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_encargado.Name = "Lbl_encargado";
            this.Lbl_encargado.Size = new System.Drawing.Size(70, 15);
            this.Lbl_encargado.TabIndex = 3;
            this.Lbl_encargado.Text = "Encargado:";
            this.Lbl_encargado.Click += new System.EventHandler(this.Lbl_encargado_Click);
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(69, 149);
            this.Lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(44, 15);
            this.Lbl_fecha.TabIndex = 4;
            this.Lbl_fecha.Text = "Fecha:";
            this.Lbl_fecha.Click += new System.EventHandler(this.Lbl_fecha_Click);
            // 
            // Lbl_depto
            // 
            this.Lbl_depto.AutoSize = true;
            this.Lbl_depto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_depto.Location = new System.Drawing.Point(69, 179);
            this.Lbl_depto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_depto.Name = "Lbl_depto";
            this.Lbl_depto.Size = new System.Drawing.Size(89, 15);
            this.Lbl_depto.TabIndex = 5;
            this.Lbl_depto.Text = "Departamento:";
            this.Lbl_depto.Click += new System.EventHandler(this.label5_Click);
            // 
            // Txt_documento
            // 
            this.Txt_documento.Location = new System.Drawing.Point(228, 95);
            this.Txt_documento.Name = "Txt_documento";
            this.Txt_documento.Size = new System.Drawing.Size(116, 21);
            this.Txt_documento.TabIndex = 6;
            // 
            // Txt_encargado
            // 
            this.Txt_encargado.Location = new System.Drawing.Point(228, 122);
            this.Txt_encargado.Name = "Txt_encargado";
            this.Txt_encargado.Size = new System.Drawing.Size(198, 21);
            this.Txt_encargado.TabIndex = 7;
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Location = new System.Drawing.Point(228, 149);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(198, 21);
            this.Txt_fecha.TabIndex = 8;
            // 
            // Txt_depto
            // 
            this.Txt_depto.Location = new System.Drawing.Point(228, 176);
            this.Txt_depto.Name = "Txt_depto";
            this.Txt_depto.Size = new System.Drawing.Size(198, 21);
            this.Txt_depto.TabIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(630, 81);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(113, 35);
            this.Btn_buscar.TabIndex = 11;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(630, 122);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(113, 35);
            this.Btn_editar.TabIndex = 12;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Location = new System.Drawing.Point(630, 163);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(113, 35);
            this.Btn_actualizar.TabIndex = 13;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // SaldoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(934, 565);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Txt_depto);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.Txt_encargado);
            this.Controls.Add(this.Txt_documento);
            this.Controls.Add(this.Lbl_depto);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_encargado);
            this.Controls.Add(this.Lbl_documento);
            this.Controls.Add(this.Dgv_saldomensual);
            this.Controls.Add(this.Lbl_titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaldoCliente";
            this.Text = "SaldoCliente";
            this.Load += new System.EventHandler(this.SaldoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_saldomensual)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.DataGridView Dgv_saldomensual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
        private System.Windows.Forms.Label Lbl_documento;
        private System.Windows.Forms.Label Lbl_encargado;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_depto;
        private System.Windows.Forms.TextBox Txt_documento;
        private System.Windows.Forms.TextBox Txt_encargado;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.TextBox Txt_depto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_actualizar;
    }
}