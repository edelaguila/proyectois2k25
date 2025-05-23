
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Cobrador_Clts
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
            this.CmbBoxEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvCobrador = new System.Windows.Forms.DataGridView();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_depto_cobrador = new System.Windows.Forms.TextBox();
            this.Lbl_depto_cobrador = new System.Windows.Forms.Label();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Txt_tel_cobrador = new System.Windows.Forms.TextBox();
            this.Txt_nom_cobrador = new System.Windows.Forms.TextBox();
            this.Txt_id_cobrador = new System.Windows.Forms.TextBox();
            this.Txt_direc_cobrador = new System.Windows.Forms.TextBox();
            this.Lbl_telef_cobrador = new System.Windows.Forms.Label();
            this.Lbl_direc_cobrador = new System.Windows.Forms.Label();
            this.Lbl_nombre_cobrador = new System.Windows.Forms.Label();
            this.Lbl_id_cobrador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCobrador)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbBoxEstado
            // 
            this.CmbBoxEstado.FormattingEnabled = true;
            this.CmbBoxEstado.Items.AddRange(new object[] {
            "0",
            "1"});
            this.CmbBoxEstado.Location = new System.Drawing.Point(463, 242);
            this.CmbBoxEstado.Name = "CmbBoxEstado";
            this.CmbBoxEstado.Size = new System.Drawing.Size(280, 24);
            this.CmbBoxEstado.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 107;
            this.label1.Text = "Estado Cobrador";
            // 
            // DgvCobrador
            // 
            this.DgvCobrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCobrador.Location = new System.Drawing.Point(25, 359);
            this.DgvCobrador.Name = "DgvCobrador";
            this.DgvCobrador.RowHeadersWidth = 51;
            this.DgvCobrador.RowTemplate.Height = 24;
            this.DgvCobrador.Size = new System.Drawing.Size(1003, 150);
            this.DgvCobrador.TabIndex = 106;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(286, 292);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(151, 43);
            this.Btn_guardar.TabIndex = 105;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click_1);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.Location = new System.Drawing.Point(806, 292);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(151, 43);
            this.Btn_borrar.TabIndex = 104;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.UseVisualStyleBackColor = true;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click_1);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Btn_actualizar.Location = new System.Drawing.Point(633, 292);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(151, 43);
            this.Btn_actualizar.TabIndex = 103;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click_1);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(460, 292);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(151, 43);
            this.Btn_editar.TabIndex = 102;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(110, 292);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(151, 43);
            this.Btn_buscar.TabIndex = 101;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click_1);
            // 
            // Txt_depto_cobrador
            // 
            this.Txt_depto_cobrador.Location = new System.Drawing.Point(463, 198);
            this.Txt_depto_cobrador.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_depto_cobrador.Name = "Txt_depto_cobrador";
            this.Txt_depto_cobrador.Size = new System.Drawing.Size(280, 22);
            this.Txt_depto_cobrador.TabIndex = 100;
            // 
            // Lbl_depto_cobrador
            // 
            this.Lbl_depto_cobrador.AutoSize = true;
            this.Lbl_depto_cobrador.Location = new System.Drawing.Point(278, 202);
            this.Lbl_depto_cobrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_depto_cobrador.Name = "Lbl_depto_cobrador";
            this.Lbl_depto_cobrador.Size = new System.Drawing.Size(169, 17);
            this.Lbl_depto_cobrador.TabIndex = 99;
            this.Lbl_depto_cobrador.Text = "Departamento Cobrador: ";
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(456, 18);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(196, 21);
            this.Lbl_titulo.TabIndex = 98;
            this.Lbl_titulo.Text = "COBRADOR  - CLIENTE- ";
            // 
            // Txt_tel_cobrador
            // 
            this.Txt_tel_cobrador.Location = new System.Drawing.Point(463, 160);
            this.Txt_tel_cobrador.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_tel_cobrador.Name = "Txt_tel_cobrador";
            this.Txt_tel_cobrador.Size = new System.Drawing.Size(280, 22);
            this.Txt_tel_cobrador.TabIndex = 97;
            // 
            // Txt_nom_cobrador
            // 
            this.Txt_nom_cobrador.Location = new System.Drawing.Point(463, 93);
            this.Txt_nom_cobrador.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nom_cobrador.Name = "Txt_nom_cobrador";
            this.Txt_nom_cobrador.Size = new System.Drawing.Size(280, 22);
            this.Txt_nom_cobrador.TabIndex = 96;
            // 
            // Txt_id_cobrador
            // 
            this.Txt_id_cobrador.Location = new System.Drawing.Point(463, 58);
            this.Txt_id_cobrador.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_id_cobrador.Name = "Txt_id_cobrador";
            this.Txt_id_cobrador.Size = new System.Drawing.Size(280, 22);
            this.Txt_id_cobrador.TabIndex = 95;
            // 
            // Txt_direc_cobrador
            // 
            this.Txt_direc_cobrador.Location = new System.Drawing.Point(463, 127);
            this.Txt_direc_cobrador.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_direc_cobrador.Name = "Txt_direc_cobrador";
            this.Txt_direc_cobrador.Size = new System.Drawing.Size(280, 22);
            this.Txt_direc_cobrador.TabIndex = 94;
            // 
            // Lbl_telef_cobrador
            // 
            this.Lbl_telef_cobrador.AutoSize = true;
            this.Lbl_telef_cobrador.Location = new System.Drawing.Point(278, 164);
            this.Lbl_telef_cobrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_telef_cobrador.Name = "Lbl_telef_cobrador";
            this.Lbl_telef_cobrador.Size = new System.Drawing.Size(135, 17);
            this.Lbl_telef_cobrador.TabIndex = 93;
            this.Lbl_telef_cobrador.Text = "Telefono Cobrador: ";
            // 
            // Lbl_direc_cobrador
            // 
            this.Lbl_direc_cobrador.AutoSize = true;
            this.Lbl_direc_cobrador.Location = new System.Drawing.Point(278, 127);
            this.Lbl_direc_cobrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_direc_cobrador.Name = "Lbl_direc_cobrador";
            this.Lbl_direc_cobrador.Size = new System.Drawing.Size(134, 17);
            this.Lbl_direc_cobrador.TabIndex = 92;
            this.Lbl_direc_cobrador.Text = "Dirección Cobrador:";
            // 
            // Lbl_nombre_cobrador
            // 
            this.Lbl_nombre_cobrador.AutoSize = true;
            this.Lbl_nombre_cobrador.Location = new System.Drawing.Point(278, 96);
            this.Lbl_nombre_cobrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombre_cobrador.Name = "Lbl_nombre_cobrador";
            this.Lbl_nombre_cobrador.Size = new System.Drawing.Size(125, 17);
            this.Lbl_nombre_cobrador.TabIndex = 91;
            this.Lbl_nombre_cobrador.Text = "Nombre Cobrador:";
            // 
            // Lbl_id_cobrador
            // 
            this.Lbl_id_cobrador.AutoSize = true;
            this.Lbl_id_cobrador.Location = new System.Drawing.Point(278, 67);
            this.Lbl_id_cobrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_cobrador.Name = "Lbl_id_cobrador";
            this.Lbl_id_cobrador.Size = new System.Drawing.Size(88, 17);
            this.Lbl_id_cobrador.TabIndex = 90;
            this.Lbl_id_cobrador.Text = "ID Cobrador:";
            // 
            // Cobrador_Clts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1082, 558);
            this.Controls.Add(this.CmbBoxEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvCobrador);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_depto_cobrador);
            this.Controls.Add(this.Lbl_depto_cobrador);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.Txt_tel_cobrador);
            this.Controls.Add(this.Txt_nom_cobrador);
            this.Controls.Add(this.Txt_id_cobrador);
            this.Controls.Add(this.Txt_direc_cobrador);
            this.Controls.Add(this.Lbl_telef_cobrador);
            this.Controls.Add(this.Lbl_direc_cobrador);
            this.Controls.Add(this.Lbl_nombre_cobrador);
            this.Controls.Add(this.Lbl_id_cobrador);
            this.Name = "Cobrador_Clts";
            this.Text = "Cobrador_Clts";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCobrador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbBoxEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvCobrador;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_depto_cobrador;
        private System.Windows.Forms.Label Lbl_depto_cobrador;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.TextBox Txt_tel_cobrador;
        private System.Windows.Forms.TextBox Txt_nom_cobrador;
        private System.Windows.Forms.TextBox Txt_id_cobrador;
        private System.Windows.Forms.TextBox Txt_direc_cobrador;
        private System.Windows.Forms.Label Lbl_telef_cobrador;
        private System.Windows.Forms.Label Lbl_direc_cobrador;
        private System.Windows.Forms.Label Lbl_nombre_cobrador;
        private System.Windows.Forms.Label Lbl_id_cobrador;
    }
}