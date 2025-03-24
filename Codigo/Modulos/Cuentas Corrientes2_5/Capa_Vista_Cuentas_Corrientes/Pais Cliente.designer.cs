
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Pais_Cliente
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
            this.Lbl_id_pais = new System.Windows.Forms.Label();
            this.Lbl_nombre_pais = new System.Windows.Forms.Label();
            this.lbl_region_pais = new System.Windows.Forms.Label();
            this.lbl_estatus_pais = new System.Windows.Forms.Label();
            this.Txt_id_pais = new System.Windows.Forms.TextBox();
            this.Txt_nombre_pais = new System.Windows.Forms.TextBox();
            this.Txt_region_pais = new System.Windows.Forms.TextBox();
            this.Cbo_estatus_pais = new System.Windows.Forms.ComboBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Dgv_paises = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_paises)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_id_pais
            // 
            this.Lbl_id_pais.AutoSize = true;
            this.Lbl_id_pais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_id_pais.Location = new System.Drawing.Point(32, 129);
            this.Lbl_id_pais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_pais.Name = "Lbl_id_pais";
            this.Lbl_id_pais.Size = new System.Drawing.Size(56, 17);
            this.Lbl_id_pais.TabIndex = 0;
            this.Lbl_id_pais.Text = "ID Pais:";
            // 
            // Lbl_nombre_pais
            // 
            this.Lbl_nombre_pais.AutoSize = true;
            this.Lbl_nombre_pais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_nombre_pais.Location = new System.Drawing.Point(32, 165);
            this.Lbl_nombre_pais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombre_pais.Name = "Lbl_nombre_pais";
            this.Lbl_nombre_pais.Size = new System.Drawing.Size(62, 17);
            this.Lbl_nombre_pais.TabIndex = 1;
            this.Lbl_nombre_pais.Text = "Nombre:";
            // 
            // lbl_region_pais
            // 
            this.lbl_region_pais.AutoSize = true;
            this.lbl_region_pais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_region_pais.Location = new System.Drawing.Point(33, 199);
            this.lbl_region_pais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_region_pais.Name = "lbl_region_pais";
            this.lbl_region_pais.Size = new System.Drawing.Size(57, 17);
            this.lbl_region_pais.TabIndex = 2;
            this.lbl_region_pais.Text = "Región:";
            // 
            // lbl_estatus_pais
            // 
            this.lbl_estatus_pais.AutoSize = true;
            this.lbl_estatus_pais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_estatus_pais.Location = new System.Drawing.Point(33, 228);
            this.lbl_estatus_pais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estatus_pais.Name = "lbl_estatus_pais";
            this.lbl_estatus_pais.Size = new System.Drawing.Size(59, 17);
            this.lbl_estatus_pais.TabIndex = 3;
            this.lbl_estatus_pais.Text = "Estatus:";
            // 
            // Txt_id_pais
            // 
            this.Txt_id_pais.Location = new System.Drawing.Point(129, 126);
            this.Txt_id_pais.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_id_pais.Name = "Txt_id_pais";
            this.Txt_id_pais.Size = new System.Drawing.Size(208, 22);
            this.Txt_id_pais.TabIndex = 4;
            // 
            // Txt_nombre_pais
            // 
            this.Txt_nombre_pais.Location = new System.Drawing.Point(129, 161);
            this.Txt_nombre_pais.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nombre_pais.Name = "Txt_nombre_pais";
            this.Txt_nombre_pais.Size = new System.Drawing.Size(208, 22);
            this.Txt_nombre_pais.TabIndex = 5;
            // 
            // Txt_region_pais
            // 
            this.Txt_region_pais.Location = new System.Drawing.Point(129, 196);
            this.Txt_region_pais.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_region_pais.Name = "Txt_region_pais";
            this.Txt_region_pais.Size = new System.Drawing.Size(208, 22);
            this.Txt_region_pais.TabIndex = 6;
            // 
            // Cbo_estatus_pais
            // 
            this.Cbo_estatus_pais.FormattingEnabled = true;
            this.Cbo_estatus_pais.Items.AddRange(new object[] {
            "1",
            "0"});
            this.Cbo_estatus_pais.Location = new System.Drawing.Point(129, 228);
            this.Cbo_estatus_pais.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_estatus_pais.Name = "Cbo_estatus_pais";
            this.Cbo_estatus_pais.Size = new System.Drawing.Size(160, 24);
            this.Cbo_estatus_pais.TabIndex = 7;
            this.Cbo_estatus_pais.SelectedIndexChanged += new System.EventHandler(this.Cbo_estatus_pais_SelectedIndexChanged);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_titulo.Location = new System.Drawing.Point(192, 33);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(140, 17);
            this.Lbl_titulo.TabIndex = 8;
            this.Lbl_titulo.Text = "PAISES ASOCIADOS";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.Btn_buscar.Location = new System.Drawing.Point(175, 283);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(133, 44);
            this.Btn_buscar.TabIndex = 43;
            this.Btn_buscar.Text = "Buscar ";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.Btn_eliminar.Location = new System.Drawing.Point(584, 283);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(133, 44);
            this.Btn_eliminar.TabIndex = 42;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.ForeColor = System.Drawing.Color.Black;
            this.Btn_actualizar.Location = new System.Drawing.Point(316, 283);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(123, 44);
            this.Btn_actualizar.TabIndex = 41;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.ForeColor = System.Drawing.Color.Black;
            this.Btn_editar.Location = new System.Drawing.Point(447, 283);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(129, 44);
            this.Btn_editar.TabIndex = 40;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.Btn_guardar.Location = new System.Drawing.Point(21, 283);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(145, 44);
            this.Btn_guardar.TabIndex = 39;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Dgv_paises
            // 
            this.Dgv_paises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_paises.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dgv_paises.Location = new System.Drawing.Point(21, 377);
            this.Dgv_paises.Name = "Dgv_paises";
            this.Dgv_paises.RowHeadersWidth = 51;
            this.Dgv_paises.RowTemplate.Height = 24;
            this.Dgv_paises.Size = new System.Drawing.Size(698, 202);
            this.Dgv_paises.TabIndex = 44;
            this.Dgv_paises.DoubleClick += new System.EventHandler(this.Dgv_paises_DoubleClick_1);
            // 
            // Pais_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(787, 661);
            this.Controls.Add(this.Dgv_paises);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.Cbo_estatus_pais);
            this.Controls.Add(this.Txt_region_pais);
            this.Controls.Add(this.Txt_nombre_pais);
            this.Controls.Add(this.Txt_id_pais);
            this.Controls.Add(this.lbl_estatus_pais);
            this.Controls.Add(this.lbl_region_pais);
            this.Controls.Add(this.Lbl_nombre_pais);
            this.Controls.Add(this.Lbl_id_pais);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pais_Cliente";
            this.Text = "Pais_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_paises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_id_pais;
        private System.Windows.Forms.Label Lbl_nombre_pais;
        private System.Windows.Forms.Label lbl_region_pais;
        private System.Windows.Forms.Label lbl_estatus_pais;
        private System.Windows.Forms.TextBox Txt_id_pais;
        private System.Windows.Forms.TextBox Txt_nombre_pais;
        private System.Windows.Forms.TextBox Txt_region_pais;
        private System.Windows.Forms.ComboBox Cbo_estatus_pais;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.DataGridView Dgv_paises;
    }
}