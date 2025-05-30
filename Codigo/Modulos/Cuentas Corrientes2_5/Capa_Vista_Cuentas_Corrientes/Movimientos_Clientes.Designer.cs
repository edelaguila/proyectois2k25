
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Movimientos_Clientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.creacionClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deudasClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // creacionClientesToolStripMenuItem
            // 
            this.creacionClientesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.creacionClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevosToolStripMenuItem,
            this.cobradoresToolStripMenuItem,
            this.deudasClientesToolStripMenuItem,
            this.paisToolStripMenuItem,
            this.tiposDePagoToolStripMenuItem,
            this.vendedoresToolStripMenuItem});
            this.creacionClientesToolStripMenuItem.Name = "creacionClientesToolStripMenuItem";
            this.creacionClientesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.creacionClientesToolStripMenuItem.Text = "Catalogos";
            // 
            // nuevosToolStripMenuItem
            // 
            this.nuevosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.nuevosToolStripMenuItem.Name = "nuevosToolStripMenuItem";
            this.nuevosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevosToolStripMenuItem.Text = "Clientes";
            this.nuevosToolStripMenuItem.Click += new System.EventHandler(this.nuevosToolStripMenuItem_Click_1);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // cobradoresToolStripMenuItem
            // 
            this.cobradoresToolStripMenuItem.Name = "cobradoresToolStripMenuItem";
            this.cobradoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cobradoresToolStripMenuItem.Text = "Cobradores";
            this.cobradoresToolStripMenuItem.Click += new System.EventHandler(this.cobradoresToolStripMenuItem_Click);
            // 
            // tiposDePagoToolStripMenuItem
            // 
            this.tiposDePagoToolStripMenuItem.Name = "tiposDePagoToolStripMenuItem";
            this.tiposDePagoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tiposDePagoToolStripMenuItem.Text = "Tipos de Pago";
            this.tiposDePagoToolStripMenuItem.Click += new System.EventHandler(this.tiposDePagoToolStripMenuItem_Click);
            // 
            // paisToolStripMenuItem
            // 
            this.paisToolStripMenuItem.Name = "paisToolStripMenuItem";
            this.paisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paisToolStripMenuItem.Text = "Pais";
            this.paisToolStripMenuItem.Click += new System.EventHandler(this.paisToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creacionClientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deudasClientesToolStripMenuItem
            // 
            this.deudasClientesToolStripMenuItem.Name = "deudasClientesToolStripMenuItem";
            this.deudasClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deudasClientesToolStripMenuItem.Text = "Deudas Clientes";
            this.deudasClientesToolStripMenuItem.Click += new System.EventHandler(this.deudasClientesToolStripMenuItem_Click);
            // 
            // Movimientos_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Movimientos_Clientes";
            this.Text = "Movimientos Clientes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem creacionClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deudasClientesToolStripMenuItem;
    }
}

