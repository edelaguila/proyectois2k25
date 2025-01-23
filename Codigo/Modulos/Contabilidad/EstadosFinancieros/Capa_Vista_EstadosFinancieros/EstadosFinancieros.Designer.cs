
namespace Capa_Vista_EstadosFinancieros
{
    partial class EstadosFinancieros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadosFinancieros));
            this.Gpb_Balance = new System.Windows.Forms.GroupBox();
            this.Cbo_BalanceAnio = new System.Windows.Forms.ComboBox();
            this.Cbo_BalanceMes = new System.Windows.Forms.ComboBox();
            this.Btn_Ver_BalanceHistorico = new System.Windows.Forms.Button();
            this.Txt_BalanceHistorico = new System.Windows.Forms.Label();
            this.Txt_BalanceActual = new System.Windows.Forms.Label();
            this.Btn_Ver_Balance = new System.Windows.Forms.Button();
            this.Gbp_EstadoDeResultados = new System.Windows.Forms.GroupBox();
            this.Cbo_EResultadosAnio = new System.Windows.Forms.ComboBox();
            this.Cbo_EResultadosMes = new System.Windows.Forms.ComboBox();
            this.Txt_EstadoDeResultadosHistorico = new System.Windows.Forms.Label();
            this.Btn_Ver_EResultadosHistorico = new System.Windows.Forms.Button();
            this.Txt_EstadoDeResultadosActual = new System.Windows.Forms.Label();
            this.Btn_Ver_EstadoResultados = new System.Windows.Forms.Button();
            this.Gbp_FlujoDeEfectivo = new System.Windows.Forms.GroupBox();
            this.Cbo_FEfectivoAnio = new System.Windows.Forms.ComboBox();
            this.Cbo_FEfectivoMes = new System.Windows.Forms.ComboBox();
            this.Txt_FlujoDeEfectivoHistorico = new System.Windows.Forms.Label();
            this.Btn_Ver_FEfectivoHistorico = new System.Windows.Forms.Button();
            this.Txt_FlujoDeEfectivoActual = new System.Windows.Forms.Label();
            this.Btn_Ver_Flujo = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Ver_Ayuda = new System.Windows.Forms.Button();
            this.Gpb_Balance.SuspendLayout();
            this.Gbp_EstadoDeResultados.SuspendLayout();
            this.Gbp_FlujoDeEfectivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_Balance
            // 
            this.Gpb_Balance.Controls.Add(this.Cbo_BalanceAnio);
            this.Gpb_Balance.Controls.Add(this.Cbo_BalanceMes);
            this.Gpb_Balance.Controls.Add(this.Btn_Ver_BalanceHistorico);
            this.Gpb_Balance.Controls.Add(this.Txt_BalanceHistorico);
            this.Gpb_Balance.Controls.Add(this.Txt_BalanceActual);
            this.Gpb_Balance.Controls.Add(this.Btn_Ver_Balance);
            this.Gpb_Balance.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Balance.Location = new System.Drawing.Point(41, 22);
            this.Gpb_Balance.Name = "Gpb_Balance";
            this.Gpb_Balance.Size = new System.Drawing.Size(387, 145);
            this.Gpb_Balance.TabIndex = 3;
            this.Gpb_Balance.TabStop = false;
            this.Gpb_Balance.Text = "Balance General";
            // 
            // Cbo_BalanceAnio
            // 
            this.Cbo_BalanceAnio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_BalanceAnio.FormattingEnabled = true;
            this.Cbo_BalanceAnio.Items.AddRange(new object[] {
            "2024",
            "2023"});
            this.Cbo_BalanceAnio.Location = new System.Drawing.Point(272, 57);
            this.Cbo_BalanceAnio.Name = "Cbo_BalanceAnio";
            this.Cbo_BalanceAnio.Size = new System.Drawing.Size(63, 27);
            this.Cbo_BalanceAnio.TabIndex = 8;
            this.Cbo_BalanceAnio.Text = "Año";
            // 
            // Cbo_BalanceMes
            // 
            this.Cbo_BalanceMes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_BalanceMes.FormattingEnabled = true;
            this.Cbo_BalanceMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Cbo_BalanceMes.Location = new System.Drawing.Point(204, 57);
            this.Cbo_BalanceMes.Name = "Cbo_BalanceMes";
            this.Cbo_BalanceMes.Size = new System.Drawing.Size(62, 27);
            this.Cbo_BalanceMes.TabIndex = 7;
            this.Cbo_BalanceMes.Text = "Mes";
            // 
            // Btn_Ver_BalanceHistorico
            // 
            this.Btn_Ver_BalanceHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_Ver_BalanceHistorico.BackgroundImage = global::Capa_Vista_EstadosFinancieros.Properties.Resources.BUCAR_V4;
            this.Btn_Ver_BalanceHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ver_BalanceHistorico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ver_BalanceHistorico.Location = new System.Drawing.Point(248, 90);
            this.Btn_Ver_BalanceHistorico.Name = "Btn_Ver_BalanceHistorico";
            this.Btn_Ver_BalanceHistorico.Size = new System.Drawing.Size(40, 40);
            this.Btn_Ver_BalanceHistorico.TabIndex = 6;
            this.Btn_Ver_BalanceHistorico.UseVisualStyleBackColor = false;
            this.Btn_Ver_BalanceHistorico.Click += new System.EventHandler(this.btn_Ver_BalanceHistorico_Click);
            // 
            // Txt_BalanceHistorico
            // 
            this.Txt_BalanceHistorico.AutoSize = true;
            this.Txt_BalanceHistorico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BalanceHistorico.Location = new System.Drawing.Point(207, 32);
            this.Txt_BalanceHistorico.Name = "Txt_BalanceHistorico";
            this.Txt_BalanceHistorico.Size = new System.Drawing.Size(128, 19);
            this.Txt_BalanceHistorico.TabIndex = 5;
            this.Txt_BalanceHistorico.Text = "Balance Historico";
            // 
            // Txt_BalanceActual
            // 
            this.Txt_BalanceActual.AutoSize = true;
            this.Txt_BalanceActual.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BalanceActual.Location = new System.Drawing.Point(35, 40);
            this.Txt_BalanceActual.Name = "Txt_BalanceActual";
            this.Txt_BalanceActual.Size = new System.Drawing.Size(109, 19);
            this.Txt_BalanceActual.TabIndex = 4;
            this.Txt_BalanceActual.Text = "Balance Actual";
            // 
            // Btn_Ver_Balance
            // 
            this.Btn_Ver_Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_Ver_Balance.BackgroundImage = global::Capa_Vista_EstadosFinancieros.Properties.Resources.BUCAR_V4;
            this.Btn_Ver_Balance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ver_Balance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ver_Balance.Location = new System.Drawing.Point(67, 62);
            this.Btn_Ver_Balance.Name = "Btn_Ver_Balance";
            this.Btn_Ver_Balance.Size = new System.Drawing.Size(40, 40);
            this.Btn_Ver_Balance.TabIndex = 0;
            this.Btn_Ver_Balance.UseVisualStyleBackColor = false;
            this.Btn_Ver_Balance.Click += new System.EventHandler(this.btn_Ver_Balance_Click);
            // 
            // Gbp_EstadoDeResultados
            // 
            this.Gbp_EstadoDeResultados.Controls.Add(this.Cbo_EResultadosAnio);
            this.Gbp_EstadoDeResultados.Controls.Add(this.Cbo_EResultadosMes);
            this.Gbp_EstadoDeResultados.Controls.Add(this.Txt_EstadoDeResultadosHistorico);
            this.Gbp_EstadoDeResultados.Controls.Add(this.Btn_Ver_EResultadosHistorico);
            this.Gbp_EstadoDeResultados.Controls.Add(this.Txt_EstadoDeResultadosActual);
            this.Gbp_EstadoDeResultados.Controls.Add(this.Btn_Ver_EstadoResultados);
            this.Gbp_EstadoDeResultados.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbp_EstadoDeResultados.Location = new System.Drawing.Point(41, 155);
            this.Gbp_EstadoDeResultados.Name = "Gbp_EstadoDeResultados";
            this.Gbp_EstadoDeResultados.Size = new System.Drawing.Size(387, 145);
            this.Gbp_EstadoDeResultados.TabIndex = 4;
            this.Gbp_EstadoDeResultados.TabStop = false;
            this.Gbp_EstadoDeResultados.Text = "Estado de resultados";
            // 
            // Cbo_EResultadosAnio
            // 
            this.Cbo_EResultadosAnio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_EResultadosAnio.FormattingEnabled = true;
            this.Cbo_EResultadosAnio.Items.AddRange(new object[] {
            "2024",
            "2023"});
            this.Cbo_EResultadosAnio.Location = new System.Drawing.Point(272, 63);
            this.Cbo_EResultadosAnio.Name = "Cbo_EResultadosAnio";
            this.Cbo_EResultadosAnio.Size = new System.Drawing.Size(63, 27);
            this.Cbo_EResultadosAnio.TabIndex = 10;
            this.Cbo_EResultadosAnio.Text = "Año";
            this.Cbo_EResultadosAnio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Cbo_EResultadosMes
            // 
            this.Cbo_EResultadosMes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_EResultadosMes.FormattingEnabled = true;
            this.Cbo_EResultadosMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Cbo_EResultadosMes.Location = new System.Drawing.Point(204, 63);
            this.Cbo_EResultadosMes.Name = "Cbo_EResultadosMes";
            this.Cbo_EResultadosMes.Size = new System.Drawing.Size(62, 27);
            this.Cbo_EResultadosMes.TabIndex = 9;
            this.Cbo_EResultadosMes.Text = "Mes";
            this.Cbo_EResultadosMes.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Txt_EstadoDeResultadosHistorico
            // 
            this.Txt_EstadoDeResultadosHistorico.AutoSize = true;
            this.Txt_EstadoDeResultadosHistorico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EstadoDeResultadosHistorico.Location = new System.Drawing.Point(183, 41);
            this.Txt_EstadoDeResultadosHistorico.Name = "Txt_EstadoDeResultadosHistorico";
            this.Txt_EstadoDeResultadosHistorico.Size = new System.Drawing.Size(187, 19);
            this.Txt_EstadoDeResultadosHistorico.TabIndex = 9;
            this.Txt_EstadoDeResultadosHistorico.Text = "E. de Resultados Historico";
            // 
            // Btn_Ver_EResultadosHistorico
            // 
            this.Btn_Ver_EResultadosHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_Ver_EResultadosHistorico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Ver_EResultadosHistorico.BackgroundImage")));
            this.Btn_Ver_EResultadosHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ver_EResultadosHistorico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ver_EResultadosHistorico.Location = new System.Drawing.Point(248, 96);
            this.Btn_Ver_EResultadosHistorico.Name = "Btn_Ver_EResultadosHistorico";
            this.Btn_Ver_EResultadosHistorico.Size = new System.Drawing.Size(40, 40);
            this.Btn_Ver_EResultadosHistorico.TabIndex = 8;
            this.Btn_Ver_EResultadosHistorico.UseVisualStyleBackColor = false;
            this.Btn_Ver_EResultadosHistorico.Click += new System.EventHandler(this.btn_Ver_EResultadosHistorico_Click);
            // 
            // Txt_EstadoDeResultadosActual
            // 
            this.Txt_EstadoDeResultadosActual.AutoSize = true;
            this.Txt_EstadoDeResultadosActual.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EstadoDeResultadosActual.Location = new System.Drawing.Point(6, 48);
            this.Txt_EstadoDeResultadosActual.Name = "Txt_EstadoDeResultadosActual";
            this.Txt_EstadoDeResultadosActual.Size = new System.Drawing.Size(168, 19);
            this.Txt_EstadoDeResultadosActual.TabIndex = 7;
            this.Txt_EstadoDeResultadosActual.Text = "E. de Resultados Actual";
            // 
            // Btn_Ver_EstadoResultados
            // 
            this.Btn_Ver_EstadoResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_Ver_EstadoResultados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Ver_EstadoResultados.BackgroundImage")));
            this.Btn_Ver_EstadoResultados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ver_EstadoResultados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ver_EstadoResultados.Location = new System.Drawing.Point(67, 70);
            this.Btn_Ver_EstadoResultados.Name = "Btn_Ver_EstadoResultados";
            this.Btn_Ver_EstadoResultados.Size = new System.Drawing.Size(40, 40);
            this.Btn_Ver_EstadoResultados.TabIndex = 1;
            this.Btn_Ver_EstadoResultados.UseVisualStyleBackColor = false;
            this.Btn_Ver_EstadoResultados.Click += new System.EventHandler(this.btn_VerEstadoResultados_Click);
            // 
            // Gbp_FlujoDeEfectivo
            // 
            this.Gbp_FlujoDeEfectivo.Controls.Add(this.Cbo_FEfectivoAnio);
            this.Gbp_FlujoDeEfectivo.Controls.Add(this.Cbo_FEfectivoMes);
            this.Gbp_FlujoDeEfectivo.Controls.Add(this.Txt_FlujoDeEfectivoHistorico);
            this.Gbp_FlujoDeEfectivo.Controls.Add(this.Btn_Ver_FEfectivoHistorico);
            this.Gbp_FlujoDeEfectivo.Controls.Add(this.Txt_FlujoDeEfectivoActual);
            this.Gbp_FlujoDeEfectivo.Controls.Add(this.Btn_Ver_Flujo);
            this.Gbp_FlujoDeEfectivo.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbp_FlujoDeEfectivo.Location = new System.Drawing.Point(41, 304);
            this.Gbp_FlujoDeEfectivo.Name = "Gbp_FlujoDeEfectivo";
            this.Gbp_FlujoDeEfectivo.Size = new System.Drawing.Size(387, 145);
            this.Gbp_FlujoDeEfectivo.TabIndex = 5;
            this.Gbp_FlujoDeEfectivo.TabStop = false;
            this.Gbp_FlujoDeEfectivo.Text = "Flujo de efectivo";
            // 
            // Cbo_FEfectivoAnio
            // 
            this.Cbo_FEfectivoAnio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_FEfectivoAnio.FormattingEnabled = true;
            this.Cbo_FEfectivoAnio.Items.AddRange(new object[] {
            "2024",
            "2023"});
            this.Cbo_FEfectivoAnio.Location = new System.Drawing.Point(272, 61);
            this.Cbo_FEfectivoAnio.Name = "Cbo_FEfectivoAnio";
            this.Cbo_FEfectivoAnio.Size = new System.Drawing.Size(63, 27);
            this.Cbo_FEfectivoAnio.TabIndex = 12;
            this.Cbo_FEfectivoAnio.Text = "Año";
            this.Cbo_FEfectivoAnio.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Cbo_FEfectivoMes
            // 
            this.Cbo_FEfectivoMes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_FEfectivoMes.FormattingEnabled = true;
            this.Cbo_FEfectivoMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Cbo_FEfectivoMes.Location = new System.Drawing.Point(204, 61);
            this.Cbo_FEfectivoMes.Name = "Cbo_FEfectivoMes";
            this.Cbo_FEfectivoMes.Size = new System.Drawing.Size(62, 27);
            this.Cbo_FEfectivoMes.TabIndex = 11;
            this.Cbo_FEfectivoMes.Text = "Mes";
            this.Cbo_FEfectivoMes.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // Txt_FlujoDeEfectivoHistorico
            // 
            this.Txt_FlujoDeEfectivoHistorico.AutoSize = true;
            this.Txt_FlujoDeEfectivoHistorico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FlujoDeEfectivoHistorico.Location = new System.Drawing.Point(189, 38);
            this.Txt_FlujoDeEfectivoHistorico.Name = "Txt_FlujoDeEfectivoHistorico";
            this.Txt_FlujoDeEfectivoHistorico.Size = new System.Drawing.Size(165, 19);
            this.Txt_FlujoDeEfectivoHistorico.TabIndex = 10;
            this.Txt_FlujoDeEfectivoHistorico.Text = "F. de Efectivo Historico";
            // 
            // Btn_Ver_FEfectivoHistorico
            // 
            this.Btn_Ver_FEfectivoHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_Ver_FEfectivoHistorico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Ver_FEfectivoHistorico.BackgroundImage")));
            this.Btn_Ver_FEfectivoHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ver_FEfectivoHistorico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ver_FEfectivoHistorico.Location = new System.Drawing.Point(248, 94);
            this.Btn_Ver_FEfectivoHistorico.Name = "Btn_Ver_FEfectivoHistorico";
            this.Btn_Ver_FEfectivoHistorico.Size = new System.Drawing.Size(40, 40);
            this.Btn_Ver_FEfectivoHistorico.TabIndex = 9;
            this.Btn_Ver_FEfectivoHistorico.UseVisualStyleBackColor = false;
            this.Btn_Ver_FEfectivoHistorico.Click += new System.EventHandler(this.btn_Ver_FEfectivoHistorico_Click);
            // 
            // Txt_FlujoDeEfectivoActual
            // 
            this.Txt_FlujoDeEfectivoActual.AutoSize = true;
            this.Txt_FlujoDeEfectivoActual.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FlujoDeEfectivoActual.Location = new System.Drawing.Point(17, 47);
            this.Txt_FlujoDeEfectivoActual.Name = "Txt_FlujoDeEfectivoActual";
            this.Txt_FlujoDeEfectivoActual.Size = new System.Drawing.Size(146, 19);
            this.Txt_FlujoDeEfectivoActual.TabIndex = 8;
            this.Txt_FlujoDeEfectivoActual.Text = "F. de Efectivo Actual";
            // 
            // Btn_Ver_Flujo
            // 
            this.Btn_Ver_Flujo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_Ver_Flujo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Ver_Flujo.BackgroundImage")));
            this.Btn_Ver_Flujo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ver_Flujo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ver_Flujo.Location = new System.Drawing.Point(67, 69);
            this.Btn_Ver_Flujo.Name = "Btn_Ver_Flujo";
            this.Btn_Ver_Flujo.Size = new System.Drawing.Size(40, 40);
            this.Btn_Ver_Flujo.TabIndex = 1;
            this.Btn_Ver_Flujo.UseVisualStyleBackColor = false;
            this.Btn_Ver_Flujo.Click += new System.EventHandler(this.btn_VerFlujo_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_Salir.BackgroundImage = global::Capa_Vista_EstadosFinancieros.Properties.Resources.SalirMDI;
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Salir.Location = new System.Drawing.Point(460, 401);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(49, 48);
            this.Btn_Salir.TabIndex = 8;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Ver_Ayuda
            // 
            this.Btn_Ver_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.Btn_Ver_Ayuda.BackgroundImage = global::Capa_Vista_EstadosFinancieros.Properties.Resources.AYUDA_V4;
            this.Btn_Ver_Ayuda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Ver_Ayuda.Location = new System.Drawing.Point(445, 8);
            this.Btn_Ver_Ayuda.Name = "Btn_Ver_Ayuda";
            this.Btn_Ver_Ayuda.Size = new System.Drawing.Size(67, 65);
            this.Btn_Ver_Ayuda.TabIndex = 7;
            this.Btn_Ver_Ayuda.UseVisualStyleBackColor = false;
            this.Btn_Ver_Ayuda.Click += new System.EventHandler(this.btn_Ver_Ayuda_Click);
            // 
            // EstadosFinancieros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(152)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(529, 471);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Ver_Ayuda);
            this.Controls.Add(this.Gbp_EstadoDeResultados);
            this.Controls.Add(this.Gbp_FlujoDeEfectivo);
            this.Controls.Add(this.Gpb_Balance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EstadosFinancieros";
            this.Text = "EstadosFinancieros";
            this.Load += new System.EventHandler(this.EstadosFinancieros_Load);
            this.Gpb_Balance.ResumeLayout(false);
            this.Gpb_Balance.PerformLayout();
            this.Gbp_EstadoDeResultados.ResumeLayout(false);
            this.Gbp_EstadoDeResultados.PerformLayout();
            this.Gbp_FlujoDeEfectivo.ResumeLayout(false);
            this.Gbp_FlujoDeEfectivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Balance;
        private System.Windows.Forms.GroupBox Gbp_EstadoDeResultados;
        private System.Windows.Forms.Button Btn_Ver_Balance;
        private System.Windows.Forms.GroupBox Gbp_FlujoDeEfectivo;
        private System.Windows.Forms.Button Btn_Ver_Flujo;
        private System.Windows.Forms.Button Btn_Ver_EstadoResultados;
        private System.Windows.Forms.Label Txt_BalanceActual;
        private System.Windows.Forms.Button Btn_Ver_BalanceHistorico;
        private System.Windows.Forms.Label Txt_BalanceHistorico;
        private System.Windows.Forms.Label Txt_EstadoDeResultadosHistorico;
        private System.Windows.Forms.Button Btn_Ver_EResultadosHistorico;
        private System.Windows.Forms.Label Txt_EstadoDeResultadosActual;
        private System.Windows.Forms.Label Txt_FlujoDeEfectivoHistorico;
        private System.Windows.Forms.Button Btn_Ver_FEfectivoHistorico;
        private System.Windows.Forms.Label Txt_FlujoDeEfectivoActual;
        private System.Windows.Forms.ComboBox Cbo_BalanceAnio;
        private System.Windows.Forms.ComboBox Cbo_BalanceMes;
        private System.Windows.Forms.ComboBox Cbo_EResultadosAnio;
        private System.Windows.Forms.ComboBox Cbo_EResultadosMes;
        private System.Windows.Forms.ComboBox Cbo_FEfectivoAnio;
        private System.Windows.Forms.ComboBox Cbo_FEfectivoMes;
        private System.Windows.Forms.Button Btn_Ver_Ayuda;
        private System.Windows.Forms.Button Btn_Salir;
    }
}