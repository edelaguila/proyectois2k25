
namespace Capa_Vista_Presupuesto
{
    partial class Incremento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incremento));
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Txt_incrementoB = new System.Windows.Forms.TextBox();
            this.Txt_texto = new System.Windows.Forms.Label();
            this.Chb_todos = new System.Windows.Forms.CheckBox();
            this.Cb_meses = new System.Windows.Forms.ComboBox();
            this.Chb_anual = new System.Windows.Forms.CheckBox();
            this.Chb_mes = new System.Windows.Forms.CheckBox();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Location = new System.Drawing.Point(66, 272);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(82, 28);
            this.Btn_Aceptar.TabIndex = 6;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.Location = new System.Drawing.Point(188, 272);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(82, 28);
            this.Btn_cancelar.TabIndex = 7;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Txtbx_incremento
            // 
            this.Txt_incrementoB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_incrementoB.Location = new System.Drawing.Point(101, 98);
            this.Txt_incrementoB.MaxLength = 3;
            this.Txt_incrementoB.Name = "Txtbx_incremento";
            this.Txt_incrementoB.Size = new System.Drawing.Size(131, 26);
            this.Txt_incrementoB.TabIndex = 1;
            this.Txt_incrementoB.TextChanged += new System.EventHandler(this.Txtbx_incremento_TextChanged);
            this.Txt_incrementoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Txt_texto
            // 
            this.Txt_texto.AutoSize = true;
            this.Txt_texto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_texto.Location = new System.Drawing.Point(12, 56);
            this.Txt_texto.Name = "Txt_texto";
            this.Txt_texto.Size = new System.Drawing.Size(300, 19);
            this.Txt_texto.TabIndex = 3;
            this.Txt_texto.Text = "Cuanto % desea incrementar/decrementar?";
            // 
            // Chb_todos
            // 
            this.Chb_todos.AutoSize = true;
            this.Chb_todos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_todos.Location = new System.Drawing.Point(101, 173);
            this.Chb_todos.Name = "Chb_todos";
            this.Chb_todos.Size = new System.Drawing.Size(131, 23);
            this.Chb_todos.TabIndex = 3;
            this.Chb_todos.Text = "Todos los Meses";
            this.Chb_todos.UseVisualStyleBackColor = true;
            this.Chb_todos.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Cb_meses
            // 
            this.Cb_meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_meses.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_meses.FormattingEnabled = true;
            this.Cb_meses.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.Cb_meses.Location = new System.Drawing.Point(101, 226);
            this.Cb_meses.Name = "Cb_meses";
            this.Cb_meses.Size = new System.Drawing.Size(131, 27);
            this.Cb_meses.TabIndex = 5;
            // 
            // Chb_anual
            // 
            this.Chb_anual.AutoSize = true;
            this.Chb_anual.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_anual.Location = new System.Drawing.Point(101, 150);
            this.Chb_anual.Name = "Chb_anual";
            this.Chb_anual.Size = new System.Drawing.Size(63, 23);
            this.Chb_anual.TabIndex = 2;
            this.Chb_anual.Text = "Anual";
            this.Chb_anual.UseVisualStyleBackColor = true;
            this.Chb_anual.CheckedChanged += new System.EventHandler(this.Chb_anual_CheckedChanged);
            // 
            // Chb_mes
            // 
            this.Chb_mes.AutoSize = true;
            this.Chb_mes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_mes.Location = new System.Drawing.Point(101, 197);
            this.Chb_mes.Name = "Chb_mes";
            this.Chb_mes.Size = new System.Drawing.Size(55, 23);
            this.Chb_mes.TabIndex = 4;
            this.Chb_mes.Text = "Mes";
            this.Chb_mes.UseVisualStyleBackColor = true;
            this.Chb_mes.CheckedChanged += new System.EventHandler(this.Chb_mes_CheckedChanged);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(152)))), ((int)(((byte)(151)))));
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(277, 12);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(39, 36);
            this.Btn_ayuda.TabIndex = 8;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Incremento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(152)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(328, 326);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Chb_mes);
            this.Controls.Add(this.Chb_anual);
            this.Controls.Add(this.Cb_meses);
            this.Controls.Add(this.Chb_todos);
            this.Controls.Add(this.Txt_texto);
            this.Controls.Add(this.Txt_incrementoB);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Incremento";
            this.Text = "Incremento";
            this.Load += new System.EventHandler(this.Incremento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.TextBox Txt_incrementoB;
        private System.Windows.Forms.Label Txt_texto;
        private System.Windows.Forms.CheckBox Chb_todos;
        private System.Windows.Forms.ComboBox Cb_meses;
        private System.Windows.Forms.CheckBox Chb_anual;
        private System.Windows.Forms.CheckBox Chb_mes;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}