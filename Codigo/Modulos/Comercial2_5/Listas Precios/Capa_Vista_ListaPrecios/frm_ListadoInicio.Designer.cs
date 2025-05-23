
namespace Capa_Vista_ListaPrecios
{
    partial class frm_ListadoInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ListadoInicio));
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Dgv_listado = new System.Windows.Forms.DataGridView();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Cbo_tipo = new System.Windows.Forms.ComboBox();
            this.Rdb_estado = new System.Windows.Forms.RadioButton();
            this.Rdb_tipo = new System.Windows.Forms.RadioButton();
            this.Txt_filtroBusqueda = new System.Windows.Forms.Label();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_repote = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_eliminarLista = new System.Windows.Forms.Button();
            this.Btn_crearLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_titulo.Location = new System.Drawing.Point(260, 29);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(166, 21);
            this.Txt_titulo.TabIndex = 307;
            this.Txt_titulo.Text = "Listado de Precios";
            // 
            // Dgv_listado
            // 
            this.Dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_listado.Location = new System.Drawing.Point(36, 220);
            this.Dgv_listado.Name = "Dgv_listado";
            this.Dgv_listado.Size = new System.Drawing.Size(592, 289);
            this.Dgv_listado.TabIndex = 347;
            this.Dgv_listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_listado_CellContentClick);
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Location = new System.Drawing.Point(315, 177);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(98, 21);
            this.Cbo_estado.TabIndex = 356;
            this.Cbo_estado.SelectedIndexChanged += new System.EventHandler(this.Cbo_estado_SelectedIndexChanged);
            // 
            // Cbo_tipo
            // 
            this.Cbo_tipo.FormattingEnabled = true;
            this.Cbo_tipo.Location = new System.Drawing.Point(126, 174);
            this.Cbo_tipo.Name = "Cbo_tipo";
            this.Cbo_tipo.Size = new System.Drawing.Size(102, 21);
            this.Cbo_tipo.TabIndex = 355;
            this.Cbo_tipo.SelectedIndexChanged += new System.EventHandler(this.Cbo_tipo_SelectedIndexChanged);
            // 
            // Rdb_estado
            // 
            this.Rdb_estado.AutoSize = true;
            this.Rdb_estado.Location = new System.Drawing.Point(251, 178);
            this.Rdb_estado.Name = "Rdb_estado";
            this.Rdb_estado.Size = new System.Drawing.Size(58, 17);
            this.Rdb_estado.TabIndex = 353;
            this.Rdb_estado.TabStop = true;
            this.Rdb_estado.Text = "Estado";
            this.Rdb_estado.UseVisualStyleBackColor = true;
            // 
            // Rdb_tipo
            // 
            this.Rdb_tipo.AutoSize = true;
            this.Rdb_tipo.Location = new System.Drawing.Point(34, 174);
            this.Rdb_tipo.Name = "Rdb_tipo";
            this.Rdb_tipo.Size = new System.Drawing.Size(86, 17);
            this.Rdb_tipo.TabIndex = 352;
            this.Rdb_tipo.TabStop = true;
            this.Rdb_tipo.Text = "Tipo de Lista";
            this.Rdb_tipo.UseVisualStyleBackColor = true;
            // 
            // Txt_filtroBusqueda
            // 
            this.Txt_filtroBusqueda.AutoSize = true;
            this.Txt_filtroBusqueda.Font = new System.Drawing.Font("Arial Narrow", 7.5F, System.Drawing.FontStyle.Bold);
            this.Txt_filtroBusqueda.ForeColor = System.Drawing.Color.Red;
            this.Txt_filtroBusqueda.Location = new System.Drawing.Point(33, 155);
            this.Txt_filtroBusqueda.Name = "Txt_filtroBusqueda";
            this.Txt_filtroBusqueda.Size = new System.Drawing.Size(132, 14);
            this.Txt_filtroBusqueda.TabIndex = 357;
            this.Txt_filtroBusqueda.Text = "* F i l t r o s    d e    b ú s q u e d a";
            // 
            // Btn_salir
            // 
            this.Btn_salir.Image = global::Capa_Vista_ListaPrecios.Properties.Resources.salir;
            this.Btn_salir.Location = new System.Drawing.Point(233, 79);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(60, 60);
            this.Btn_salir.TabIndex = 350;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = global::Capa_Vista_ListaPrecios.Properties.Resources.ayuda;
            this.Btn_ayuda.Location = new System.Drawing.Point(568, 79);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(60, 60);
            this.Btn_ayuda.TabIndex = 349;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_repote
            // 
            this.Btn_repote.Image = global::Capa_Vista_ListaPrecios.Properties.Resources.reportes;
            this.Btn_repote.Location = new System.Drawing.Point(502, 79);
            this.Btn_repote.Name = "Btn_repote";
            this.Btn_repote.Size = new System.Drawing.Size(60, 60);
            this.Btn_repote.TabIndex = 346;
            this.Btn_repote.UseVisualStyleBackColor = true;
            this.Btn_repote.Click += new System.EventHandler(this.Btn_repote_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Image = global::Capa_Vista_ListaPrecios.Properties.Resources.buscar;
            this.Btn_buscar.Location = new System.Drawing.Point(167, 79);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(60, 60);
            this.Btn_buscar.TabIndex = 345;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_eliminarLista
            // 
            this.Btn_eliminarLista.Image = global::Capa_Vista_ListaPrecios.Properties.Resources.eliminar;
            this.Btn_eliminarLista.Location = new System.Drawing.Point(101, 79);
            this.Btn_eliminarLista.Name = "Btn_eliminarLista";
            this.Btn_eliminarLista.Size = new System.Drawing.Size(60, 60);
            this.Btn_eliminarLista.TabIndex = 344;
            this.Btn_eliminarLista.UseVisualStyleBackColor = true;
            this.Btn_eliminarLista.Click += new System.EventHandler(this.Btn_eliminarLista_Click);
            // 
            // Btn_crearLista
            // 
            this.Btn_crearLista.Image = global::Capa_Vista_ListaPrecios.Properties.Resources.agregar;
            this.Btn_crearLista.Location = new System.Drawing.Point(36, 79);
            this.Btn_crearLista.Name = "Btn_crearLista";
            this.Btn_crearLista.Size = new System.Drawing.Size(60, 60);
            this.Btn_crearLista.TabIndex = 342;
            this.Btn_crearLista.UseVisualStyleBackColor = true;
            this.Btn_crearLista.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // frm_ListadoInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(675, 546);
            this.Controls.Add(this.Txt_filtroBusqueda);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Cbo_tipo);
            this.Controls.Add(this.Rdb_estado);
            this.Controls.Add(this.Rdb_tipo);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Dgv_listado);
            this.Controls.Add(this.Btn_repote);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_eliminarLista);
            this.Controls.Add(this.Btn_crearLista);
            this.Controls.Add(this.Txt_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ListadoInicio";
            this.Text = "Listas de Precios";
            this.Load += new System.EventHandler(this.frm_ListadoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.Button Btn_crearLista;
        private System.Windows.Forms.Button Btn_eliminarLista;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_repote;
        private System.Windows.Forms.DataGridView Dgv_listado;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.ComboBox Cbo_tipo;
        private System.Windows.Forms.RadioButton Rdb_estado;
        private System.Windows.Forms.RadioButton Rdb_tipo;
        private System.Windows.Forms.Label Txt_filtroBusqueda;
    }
}