
namespace Capa_Vista_Presupuesto
{
    partial class Opciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones));
            this.Btn_crear = new System.Windows.Forms.Button();
            this.Cb_ejercicio = new System.Windows.Forms.ComboBox();
            this.Txt_nombreB = new System.Windows.Forms.TextBox();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Cb_modificar = new System.Windows.Forms.ComboBox();
            this.Btn_ver = new System.Windows.Forms.Button();
            this.Cb_Ver = new System.Windows.Forms.ComboBox();
            this.Cb_LlenadoMod = new System.Windows.Forms.ComboBox();
            this.Cb_Base = new System.Windows.Forms.ComboBox();
            this.Txt_ejercicio = new System.Windows.Forms.Label();
            this.Txt_forma = new System.Windows.Forms.Label();
            this.Chb_plantilla = new System.Windows.Forms.CheckBox();
            this.Gpb_presupuesto = new System.Windows.Forms.GroupBox();
            this.Txt_trabajar = new System.Windows.Forms.Label();
            this.Cb_LlenadoCrear = new System.Windows.Forms.ComboBox();
            this.Txt_nombre = new System.Windows.Forms.Label();
            this.Gpb_modificar = new System.Windows.Forms.GroupBox();
            this.Txt_presupuesto = new System.Windows.Forms.Label();
            this.Gpb_ver = new System.Windows.Forms.GroupBox();
            this.Txt_verPresupuesto = new System.Windows.Forms.Label();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Gpb_presupuesto.SuspendLayout();
            this.Gpb_modificar.SuspendLayout();
            this.Gpb_ver.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_crear
            // 
            this.Btn_crear.Location = new System.Drawing.Point(155, 161);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(77, 30);
            this.Btn_crear.TabIndex = 6;
            this.Btn_crear.Text = "Crear";
            this.Btn_crear.UseVisualStyleBackColor = true;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // Cb_ejercicio
            // 
            this.Cb_ejercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_ejercicio.FormattingEnabled = true;
            this.Cb_ejercicio.Location = new System.Drawing.Point(10, 125);
            this.Cb_ejercicio.Name = "Cb_ejercicio";
            this.Cb_ejercicio.Size = new System.Drawing.Size(157, 27);
            this.Cb_ejercicio.TabIndex = 2;
            this.Cb_ejercicio.SelectedIndexChanged += new System.EventHandler(this.Cb_ejercicio_SelectedIndexChanged);
            // 
            // Txtbx_nombre
            // 
            this.Txt_nombreB.Location = new System.Drawing.Point(10, 76);
            this.Txt_nombreB.MaxLength = 25;
            this.Txt_nombreB.Name = "Txtbx_nombre";
            this.Txt_nombreB.Size = new System.Drawing.Size(157, 26);
            this.Txt_nombreB.TabIndex = 1;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(155, 100);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(77, 28);
            this.Btn_Modificar.TabIndex = 9;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Cb_modificar
            // 
            this.Cb_modificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_modificar.FormattingEnabled = true;
            this.Cb_modificar.Location = new System.Drawing.Point(220, 48);
            this.Cb_modificar.Name = "Cb_modificar";
            this.Cb_modificar.Size = new System.Drawing.Size(161, 27);
            this.Cb_modificar.TabIndex = 8;
            // 
            // Btn_ver
            // 
            this.Btn_ver.Location = new System.Drawing.Point(155, 85);
            this.Btn_ver.Name = "Btn_ver";
            this.Btn_ver.Size = new System.Drawing.Size(77, 23);
            this.Btn_ver.TabIndex = 11;
            this.Btn_ver.Text = "Ver";
            this.Btn_ver.UseVisualStyleBackColor = true;
            this.Btn_ver.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cb_Ver
            // 
            this.Cb_Ver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Ver.FormattingEnabled = true;
            this.Cb_Ver.Location = new System.Drawing.Point(113, 43);
            this.Cb_Ver.Name = "Cb_Ver";
            this.Cb_Ver.Size = new System.Drawing.Size(161, 27);
            this.Cb_Ver.TabIndex = 10;
            // 
            // Cb_LlenadoMod
            // 
            this.Cb_LlenadoMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_LlenadoMod.FormattingEnabled = true;
            this.Cb_LlenadoMod.Items.AddRange(new object[] {
            "Mensual",
            "Anual"});
            this.Cb_LlenadoMod.Location = new System.Drawing.Point(10, 48);
            this.Cb_LlenadoMod.Name = "Cb_LlenadoMod";
            this.Cb_LlenadoMod.Size = new System.Drawing.Size(157, 27);
            this.Cb_LlenadoMod.TabIndex = 7;
            // 
            // Cb_Base
            // 
            this.Cb_Base.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Base.FormattingEnabled = true;
            this.Cb_Base.Location = new System.Drawing.Point(220, 76);
            this.Cb_Base.Name = "Cb_Base";
            this.Cb_Base.Size = new System.Drawing.Size(161, 27);
            this.Cb_Base.TabIndex = 4;
            // 
            // Txt_ejercicio
            // 
            this.Txt_ejercicio.AutoSize = true;
            this.Txt_ejercicio.Location = new System.Drawing.Point(6, 105);
            this.Txt_ejercicio.Name = "Txt_ejercicio";
            this.Txt_ejercicio.Size = new System.Drawing.Size(161, 19);
            this.Txt_ejercicio.TabIndex = 9;
            this.Txt_ejercicio.Text = "Ejercicio del presupuesto";
            this.Txt_ejercicio.Click += new System.EventHandler(this.Txt_ejercicio_Click);
            // 
            // Txt_forma
            // 
            this.Txt_forma.AutoSize = true;
            this.Txt_forma.Location = new System.Drawing.Point(6, 26);
            this.Txt_forma.Name = "Txt_forma";
            this.Txt_forma.Size = new System.Drawing.Size(171, 19);
            this.Txt_forma.TabIndex = 10;
            this.Txt_forma.Text = "Modo de registro de datos";
            // 
            // Chb_plantilla
            // 
            this.Chb_plantilla.AutoSize = true;
            this.Chb_plantilla.Location = new System.Drawing.Point(220, 50);
            this.Chb_plantilla.Name = "Chb_plantilla";
            this.Chb_plantilla.Size = new System.Drawing.Size(184, 23);
            this.Chb_plantilla.TabIndex = 3;
            this.Chb_plantilla.Text = "Presupuesto de referencia";
            this.Chb_plantilla.UseVisualStyleBackColor = true;
            this.Chb_plantilla.CheckedChanged += new System.EventHandler(this.Chb_plantilla_CheckedChanged);
            // 
            // Gpb_presupuesto
            // 
            this.Gpb_presupuesto.Controls.Add(this.Txt_trabajar);
            this.Gpb_presupuesto.Controls.Add(this.Cb_LlenadoCrear);
            this.Gpb_presupuesto.Controls.Add(this.Txt_nombre);
            this.Gpb_presupuesto.Controls.Add(this.Chb_plantilla);
            this.Gpb_presupuesto.Controls.Add(this.Txt_nombreB);
            this.Gpb_presupuesto.Controls.Add(this.Txt_ejercicio);
            this.Gpb_presupuesto.Controls.Add(this.Cb_Base);
            this.Gpb_presupuesto.Controls.Add(this.Cb_ejercicio);
            this.Gpb_presupuesto.Controls.Add(this.Btn_crear);
            this.Gpb_presupuesto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_presupuesto.Location = new System.Drawing.Point(12, 46);
            this.Gpb_presupuesto.Name = "Gpb_presupuesto";
            this.Gpb_presupuesto.Size = new System.Drawing.Size(410, 207);
            this.Gpb_presupuesto.TabIndex = 12;
            this.Gpb_presupuesto.TabStop = false;
            this.Gpb_presupuesto.Text = "Crear Presupuesto";
            // 
            // Txt_trabajar
            // 
            this.Txt_trabajar.AutoSize = true;
            this.Txt_trabajar.Location = new System.Drawing.Point(216, 106);
            this.Txt_trabajar.Name = "Txt_trabajar";
            this.Txt_trabajar.Size = new System.Drawing.Size(171, 19);
            this.Txt_trabajar.TabIndex = 13;
            this.Txt_trabajar.Text = "Modo de registro de datos";
            this.Txt_trabajar.Click += new System.EventHandler(this.Txt_trabajar_Click);
            // 
            // Cb_LlenadoCrear
            // 
            this.Cb_LlenadoCrear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_LlenadoCrear.FormattingEnabled = true;
            this.Cb_LlenadoCrear.Items.AddRange(new object[] {
            "Mensual",
            "Anual"});
            this.Cb_LlenadoCrear.Location = new System.Drawing.Point(220, 128);
            this.Cb_LlenadoCrear.Name = "Cb_LlenadoCrear";
            this.Cb_LlenadoCrear.Size = new System.Drawing.Size(161, 27);
            this.Cb_LlenadoCrear.TabIndex = 5;
            this.Cb_LlenadoCrear.SelectedIndexChanged += new System.EventHandler(this.Cb_LlenadoCrear_SelectedIndexChanged);
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.AutoSize = true;
            this.Txt_nombre.Location = new System.Drawing.Point(6, 54);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(169, 19);
            this.Txt_nombre.TabIndex = 3;
            this.Txt_nombre.Text = "Nombre para Presupuesto";
            // 
            // Gpb_modificar
            // 
            this.Gpb_modificar.Controls.Add(this.Txt_presupuesto);
            this.Gpb_modificar.Controls.Add(this.Cb_modificar);
            this.Gpb_modificar.Controls.Add(this.Btn_Modificar);
            this.Gpb_modificar.Controls.Add(this.Txt_forma);
            this.Gpb_modificar.Controls.Add(this.Cb_LlenadoMod);
            this.Gpb_modificar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_modificar.Location = new System.Drawing.Point(12, 259);
            this.Gpb_modificar.Name = "Gpb_modificar";
            this.Gpb_modificar.Size = new System.Drawing.Size(410, 151);
            this.Gpb_modificar.TabIndex = 13;
            this.Gpb_modificar.TabStop = false;
            this.Gpb_modificar.Text = "Modificar Presupuesto";
            // 
            // Txt_presupuesto
            // 
            this.Txt_presupuesto.AutoSize = true;
            this.Txt_presupuesto.Location = new System.Drawing.Point(216, 26);
            this.Txt_presupuesto.Name = "Txt_presupuesto";
            this.Txt_presupuesto.Size = new System.Drawing.Size(154, 19);
            this.Txt_presupuesto.TabIndex = 14;
            this.Txt_presupuesto.Text = "Presupuesto a modificar";
            // 
            // Gpb_ver
            // 
            this.Gpb_ver.Controls.Add(this.Txt_verPresupuesto);
            this.Gpb_ver.Controls.Add(this.Cb_Ver);
            this.Gpb_ver.Controls.Add(this.Btn_ver);
            this.Gpb_ver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_ver.Location = new System.Drawing.Point(12, 416);
            this.Gpb_ver.Name = "Gpb_ver";
            this.Gpb_ver.Size = new System.Drawing.Size(410, 124);
            this.Gpb_ver.TabIndex = 14;
            this.Gpb_ver.TabStop = false;
            this.Gpb_ver.Text = "Ver presupuesto";
            // 
            // Txt_verPresupuesto
            // 
            this.Txt_verPresupuesto.AutoSize = true;
            this.Txt_verPresupuesto.Location = new System.Drawing.Point(138, 21);
            this.Txt_verPresupuesto.Name = "Txt_verPresupuesto";
            this.Txt_verPresupuesto.Size = new System.Drawing.Size(117, 19);
            this.Txt_verPresupuesto.TabIndex = 15;
            this.Txt_verPresupuesto.Text = "Presupuesto a ver";
            this.Txt_verPresupuesto.Click += new System.EventHandler(this.Txt_verPresupuesto_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(152)))), ((int)(((byte)(151)))));
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(378, 4);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(39, 36);
            this.Btn_ayuda.TabIndex = 12;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(152)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(429, 553);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Gpb_ver);
            this.Controls.Add(this.Gpb_modificar);
            this.Controls.Add(this.Gpb_presupuesto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opciones";
            this.Text = "Opciones de Presupuesto";
            this.Load += new System.EventHandler(this.Opciones_Load);
            this.Gpb_presupuesto.ResumeLayout(false);
            this.Gpb_presupuesto.PerformLayout();
            this.Gpb_modificar.ResumeLayout(false);
            this.Gpb_modificar.PerformLayout();
            this.Gpb_ver.ResumeLayout(false);
            this.Gpb_ver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.ComboBox Cb_ejercicio;
        private System.Windows.Forms.TextBox Txt_nombreB;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.ComboBox Cb_modificar;
        private System.Windows.Forms.Button Btn_ver;
        private System.Windows.Forms.ComboBox Cb_Ver;
        private System.Windows.Forms.ComboBox Cb_LlenadoMod;
        private System.Windows.Forms.ComboBox Cb_Base;
        private System.Windows.Forms.Label Txt_ejercicio;
        private System.Windows.Forms.Label Txt_forma;
        private System.Windows.Forms.CheckBox Chb_plantilla;
        private System.Windows.Forms.GroupBox Gpb_presupuesto;
        private System.Windows.Forms.Label Txt_nombre;
        private System.Windows.Forms.GroupBox Gpb_modificar;
        private System.Windows.Forms.Label Txt_presupuesto;
        private System.Windows.Forms.GroupBox Gpb_ver;
        private System.Windows.Forms.Label Txt_verPresupuesto;
        private System.Windows.Forms.Label Txt_trabajar;
        private System.Windows.Forms.ComboBox Cb_LlenadoCrear;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}