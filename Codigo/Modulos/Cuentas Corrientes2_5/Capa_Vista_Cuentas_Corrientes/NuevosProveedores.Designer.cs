
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class NuevosProveedores
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
            this.Dgv_proveedor = new System.Windows.Forms.DataGridView();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Txt_email = new System.Windows.Forms.TextBox();
            this.txt_email_provee = new System.Windows.Forms.Label();
            this.Txt_telefono = new System.Windows.Forms.TextBox();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Txt_telefono_provee = new System.Windows.Forms.Label();
            this.Txt_direccion_provee = new System.Windows.Forms.Label();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_id_proveedor = new System.Windows.Forms.TextBox();
            this.Txt_proveedor = new System.Windows.Forms.Label();
            this.Txt_saldo = new System.Windows.Forms.TextBox();
            this.txt_saldo_provee = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_estado_provee = new System.Windows.Forms.Label();
            this.Txt_nombre_provee = new System.Windows.Forms.Label();
            this.Txt_fecha_registro = new System.Windows.Forms.Label();
            this.Txt_Titulo = new System.Windows.Forms.Label();
            this.dtp_fecha_registro = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_proveedor
            // 
            this.Dgv_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_proveedor.Location = new System.Drawing.Point(96, 419);
            this.Dgv_proveedor.Name = "Dgv_proveedor";
            this.Dgv_proveedor.RowHeadersWidth = 51;
            this.Dgv_proveedor.RowTemplate.Height = 24;
            this.Dgv_proveedor.Size = new System.Drawing.Size(818, 195);
            this.Dgv_proveedor.TabIndex = 64;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(379, 97);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(100, 36);
            this.Btn_buscar.TabIndex = 59;
            this.Btn_buscar.Text = "Buscar ";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Location = new System.Drawing.Point(686, 97);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(100, 36);
            this.Btn_eliminar.TabIndex = 58;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(485, 97);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(92, 36);
            this.Btn_actualizar.TabIndex = 57;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Location = new System.Drawing.Point(583, 97);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(97, 36);
            this.Btn_editar.TabIndex = 56;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Location = new System.Drawing.Point(264, 97);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(109, 36);
            this.Btn_guardar.TabIndex = 55;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Location = new System.Drawing.Point(246, -52);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(176, 17);
            this.Lbl_Titulo.TabIndex = 45;
            this.Lbl_Titulo.Text = "Creacion de Cliente Nuevo";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Titulo.UseMnemonic = false;
            // 
            // Txt_email
            // 
            this.Txt_email.Location = new System.Drawing.Point(205, 382);
            this.Txt_email.Name = "Txt_email";
            this.Txt_email.Size = new System.Drawing.Size(279, 22);
            this.Txt_email.TabIndex = 80;
            // 
            // txt_email_provee
            // 
            this.txt_email_provee.AutoSize = true;
            this.txt_email_provee.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_provee.Location = new System.Drawing.Point(141, 369);
            this.txt_email_provee.Name = "txt_email_provee";
            this.txt_email_provee.Size = new System.Drawing.Size(58, 23);
            this.txt_email_provee.TabIndex = 79;
            this.txt_email_provee.Text = "Email:";
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefono.Location = new System.Drawing.Point(205, 327);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(279, 30);
            this.Txt_telefono.TabIndex = 78;
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccion.Location = new System.Drawing.Point(205, 283);
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(279, 30);
            this.Txt_direccion.TabIndex = 77;
            // 
            // Txt_telefono_provee
            // 
            this.Txt_telefono_provee.AutoSize = true;
            this.Txt_telefono_provee.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefono_provee.Location = new System.Drawing.Point(120, 327);
            this.Txt_telefono_provee.Name = "Txt_telefono_provee";
            this.Txt_telefono_provee.Size = new System.Drawing.Size(79, 23);
            this.Txt_telefono_provee.TabIndex = 76;
            this.Txt_telefono_provee.Text = "Telefono:";
            // 
            // Txt_direccion_provee
            // 
            this.Txt_direccion_provee.AutoSize = true;
            this.Txt_direccion_provee.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccion_provee.Location = new System.Drawing.Point(111, 288);
            this.Txt_direccion_provee.Name = "Txt_direccion_provee";
            this.Txt_direccion_provee.Size = new System.Drawing.Size(88, 23);
            this.Txt_direccion_provee.TabIndex = 75;
            this.Txt_direccion_provee.Text = "Dirección:";
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "0"});
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "1",
            "0"});
            this.Cbo_estado.Location = new System.Drawing.Point(686, 228);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(202, 24);
            this.Cbo_estado.TabIndex = 74;
            // 
            // Txt_id_proveedor
            // 
            this.Txt_id_proveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_proveedor.Location = new System.Drawing.Point(205, 162);
            this.Txt_id_proveedor.Name = "Txt_id_proveedor";
            this.Txt_id_proveedor.Size = new System.Drawing.Size(202, 30);
            this.Txt_id_proveedor.TabIndex = 73;
            // 
            // Txt_proveedor
            // 
            this.Txt_proveedor.AutoSize = true;
            this.Txt_proveedor.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_proveedor.Location = new System.Drawing.Point(88, 162);
            this.Txt_proveedor.Name = "Txt_proveedor";
            this.Txt_proveedor.Size = new System.Drawing.Size(111, 23);
            this.Txt_proveedor.TabIndex = 72;
            this.Txt_proveedor.Text = "Id Proveedor:";
            // 
            // Txt_saldo
            // 
            this.Txt_saldo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_saldo.Location = new System.Drawing.Point(685, 178);
            this.Txt_saldo.Name = "Txt_saldo";
            this.Txt_saldo.Size = new System.Drawing.Size(279, 30);
            this.Txt_saldo.TabIndex = 71;
            // 
            // txt_saldo_provee
            // 
            this.txt_saldo_provee.AutoSize = true;
            this.txt_saldo_provee.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_saldo_provee.Location = new System.Drawing.Point(564, 178);
            this.txt_saldo_provee.Name = "txt_saldo_provee";
            this.txt_saldo_provee.Size = new System.Drawing.Size(116, 23);
            this.txt_saldo_provee.TabIndex = 70;
            this.txt_saldo_provee.Text = "Saldo cuenta: ";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(205, 244);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(279, 30);
            this.Txt_nombre.TabIndex = 69;
            // 
            // txt_estado_provee
            // 
            this.txt_estado_provee.AutoSize = true;
            this.txt_estado_provee.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado_provee.Location = new System.Drawing.Point(533, 229);
            this.txt_estado_provee.Name = "txt_estado_provee";
            this.txt_estado_provee.Size = new System.Drawing.Size(147, 23);
            this.txt_estado_provee.TabIndex = 67;
            this.txt_estado_provee.Text = "Estado Proveedor:";
            // 
            // Txt_nombre_provee
            // 
            this.Txt_nombre_provee.AutoSize = true;
            this.Txt_nombre_provee.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre_provee.Location = new System.Drawing.Point(122, 244);
            this.Txt_nombre_provee.Name = "Txt_nombre_provee";
            this.Txt_nombre_provee.Size = new System.Drawing.Size(77, 23);
            this.Txt_nombre_provee.TabIndex = 66;
            this.Txt_nombre_provee.Text = "Nombre:";
            // 
            // Txt_fecha_registro
            // 
            this.Txt_fecha_registro.AutoSize = true;
            this.Txt_fecha_registro.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fecha_registro.Location = new System.Drawing.Point(52, 204);
            this.Txt_fecha_registro.Name = "Txt_fecha_registro";
            this.Txt_fecha_registro.Size = new System.Drawing.Size(147, 23);
            this.Txt_fecha_registro.TabIndex = 65;
            this.Txt_fecha_registro.Text = "Fecha de registro: ";
            // 
            // Txt_Titulo
            // 
            this.Txt_Titulo.AutoSize = true;
            this.Txt_Titulo.Location = new System.Drawing.Point(425, 48);
            this.Txt_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Titulo.Name = "Txt_Titulo";
            this.Txt_Titulo.Size = new System.Drawing.Size(199, 17);
            this.Txt_Titulo.TabIndex = 81;
            this.Txt_Titulo.Text = "Creacion de Proveedor Nuevo";
            this.Txt_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Txt_Titulo.UseMnemonic = false;
            // 
            // dtp_fecha_registro
            // 
            this.dtp_fecha_registro.Location = new System.Drawing.Point(206, 204);
            this.dtp_fecha_registro.Name = "dtp_fecha_registro";
            this.dtp_fecha_registro.Size = new System.Drawing.Size(273, 22);
            this.dtp_fecha_registro.TabIndex = 82;
            // 
            // NuevosProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1052, 649);
            this.Controls.Add(this.dtp_fecha_registro);
            this.Controls.Add(this.Txt_Titulo);
            this.Controls.Add(this.Txt_email);
            this.Controls.Add(this.txt_email_provee);
            this.Controls.Add(this.Txt_telefono);
            this.Controls.Add(this.Txt_direccion);
            this.Controls.Add(this.Txt_telefono_provee);
            this.Controls.Add(this.Txt_direccion_provee);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Txt_id_proveedor);
            this.Controls.Add(this.Txt_proveedor);
            this.Controls.Add(this.Txt_saldo);
            this.Controls.Add(this.txt_saldo_provee);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.txt_estado_provee);
            this.Controls.Add(this.Txt_nombre_provee);
            this.Controls.Add(this.Txt_fecha_registro);
            this.Controls.Add(this.Dgv_proveedor);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "NuevosProveedores";
            this.Text = "NuevosProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_proveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_proveedor;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.TextBox Txt_email;
        private System.Windows.Forms.Label txt_email_provee;
        private System.Windows.Forms.TextBox Txt_telefono;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.Label Txt_telefono_provee;
        private System.Windows.Forms.Label Txt_direccion_provee;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_id_proveedor;
        private System.Windows.Forms.Label Txt_proveedor;
        private System.Windows.Forms.TextBox Txt_saldo;
        private System.Windows.Forms.Label txt_saldo_provee;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label txt_estado_provee;
        private System.Windows.Forms.Label Txt_nombre_provee;
        private System.Windows.Forms.Label Txt_fecha_registro;
        private System.Windows.Forms.Label Txt_Titulo;
        private System.Windows.Forms.DateTimePicker dtp_fecha_registro;
    }
}