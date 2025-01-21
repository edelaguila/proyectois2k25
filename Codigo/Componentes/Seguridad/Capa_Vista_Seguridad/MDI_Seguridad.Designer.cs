namespace Capa_Vista_Seguridad
{
    partial class MDI_Seguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Seguridad));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeAplicacionesAUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDePerfilesAUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeAplicacionesAPerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionModuloAAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Pnl_usuario = new System.Windows.Forms.Panel();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.Pnl_inferior = new System.Windows.Forms.Panel();
            this.Pnl_fecha = new System.Windows.Forms.Panel();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_inferiorfecha = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.Pnl_usuario.SuspendLayout();
            this.Pnl_inferior.SuspendLayout();
            this.Pnl_fecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.asignacionesToolStripMenuItem,
            this.cambioContraseñaToolStripMenuItem,
            this.bitacoraToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1053, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesionToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.aplicacionesToolStripMenuItem,
            this.modulosToolStripMenuItem,
            this.perfilesToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            this.aplicacionesToolStripMenuItem.Click += new System.EventHandler(this.AplicacionesToolStripMenuItem_Click);
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.modulosToolStripMenuItem.Text = "Modulos";
            this.modulosToolStripMenuItem.Click += new System.EventHandler(this.ModulosToolStripMenuItem_Click);
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.perfilesToolStripMenuItem.Text = "Perfiles";
            this.perfilesToolStripMenuItem.Click += new System.EventHandler(this.PerfilesToolStripMenuItem_Click);
            // 
            // asignacionesToolStripMenuItem
            // 
            this.asignacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignacionDeAplicacionesAUsuariosToolStripMenuItem,
            this.asignacionDePerfilesAUsuariosToolStripMenuItem,
            this.asignacionDeAplicacionesAPerfilesToolStripMenuItem,
            this.asignacionModuloAAplicacionesToolStripMenuItem});
            this.asignacionesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignacionesToolStripMenuItem.Name = "asignacionesToolStripMenuItem";
            this.asignacionesToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.asignacionesToolStripMenuItem.Text = "Asignaciones";
            // 
            // asignacionDeAplicacionesAUsuariosToolStripMenuItem
            // 
            this.asignacionDeAplicacionesAUsuariosToolStripMenuItem.Name = "asignacionDeAplicacionesAUsuariosToolStripMenuItem";
            this.asignacionDeAplicacionesAUsuariosToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.asignacionDeAplicacionesAUsuariosToolStripMenuItem.Text = "Asignacion de Aplicaciones a Usuarios";
            this.asignacionDeAplicacionesAUsuariosToolStripMenuItem.Click += new System.EventHandler(this.AsignacionDeAplicacionesAUsuariosToolStripMenuItem_Click);
            // 
            // asignacionDePerfilesAUsuariosToolStripMenuItem
            // 
            this.asignacionDePerfilesAUsuariosToolStripMenuItem.Name = "asignacionDePerfilesAUsuariosToolStripMenuItem";
            this.asignacionDePerfilesAUsuariosToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.asignacionDePerfilesAUsuariosToolStripMenuItem.Text = "Asignacion de Perfiles a Usuarios";
            this.asignacionDePerfilesAUsuariosToolStripMenuItem.Click += new System.EventHandler(this.AsignacionDePerfilesAUsuariosToolStripMenuItem_Click);
            // 
            // asignacionDeAplicacionesAPerfilesToolStripMenuItem
            // 
            this.asignacionDeAplicacionesAPerfilesToolStripMenuItem.Name = "asignacionDeAplicacionesAPerfilesToolStripMenuItem";
            this.asignacionDeAplicacionesAPerfilesToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.asignacionDeAplicacionesAPerfilesToolStripMenuItem.Text = "Asignacion de Aplicaciones a Perfiles";
            this.asignacionDeAplicacionesAPerfilesToolStripMenuItem.Click += new System.EventHandler(this.AsignacionDeAplicacionesAPerfilesToolStripMenuItem_Click);
            // 
            // asignacionModuloAAplicacionesToolStripMenuItem
            // 
            this.asignacionModuloAAplicacionesToolStripMenuItem.Name = "asignacionModuloAAplicacionesToolStripMenuItem";
            this.asignacionModuloAAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.asignacionModuloAAplicacionesToolStripMenuItem.Text = "Asignacion Modulo a Aplicaciones";
            this.asignacionModuloAAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.asignacionModuloAAplicacionesToolStripMenuItem_Click);
            // 
            // cambioContraseñaToolStripMenuItem
            // 
            this.cambioContraseñaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambioContraseñaToolStripMenuItem.Name = "cambioContraseñaToolStripMenuItem";
            this.cambioContraseñaToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.cambioContraseñaToolStripMenuItem.Text = "Cambio Contraseña";
            this.cambioContraseñaToolStripMenuItem.Click += new System.EventHandler(this.CambioContraseñaToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.BitacoraToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 993);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 22, 0);
            this.statusStrip.Size = new System.Drawing.Size(1053, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Estado";
            // 
            // Pnl_usuario
            // 
            this.Pnl_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_usuario.Controls.Add(this.lbl_nombreUsuario);
            this.Pnl_usuario.Controls.Add(this.lbl_usuario);
            this.Pnl_usuario.Location = new System.Drawing.Point(442, 6);
            this.Pnl_usuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_usuario.Name = "Pnl_usuario";
            this.Pnl_usuario.Size = new System.Drawing.Size(225, 46);
            this.Pnl_usuario.TabIndex = 1;
            this.Pnl_usuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(94, 11);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(19, 20);
            this.lbl_nombreUsuario.TabIndex = 1;
            this.lbl_nombreUsuario.Text = "--";
            this.lbl_nombreUsuario.Click += new System.EventHandler(this.lbl_nombreUsuario_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(3, 11);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(68, 20);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // Pnl_inferior
            // 
            this.Pnl_inferior.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_inferior.Controls.Add(this.Pnl_fecha);
            this.Pnl_inferior.Controls.Add(this.Pnl_usuario);
            this.Pnl_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_inferior.Location = new System.Drawing.Point(0, 942);
            this.Pnl_inferior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_inferior.Name = "Pnl_inferior";
            this.Pnl_inferior.Size = new System.Drawing.Size(1053, 51);
            this.Pnl_inferior.TabIndex = 4;
            this.Pnl_inferior.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Pnl_fecha
            // 
            this.Pnl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_fecha.Controls.Add(this.Lbl_fecha);
            this.Pnl_fecha.Controls.Add(this.Lbl_inferiorfecha);
            this.Pnl_fecha.Location = new System.Drawing.Point(706, 4);
            this.Pnl_fecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_fecha.Name = "Pnl_fecha";
            this.Pnl_fecha.Size = new System.Drawing.Size(259, 46);
            this.Pnl_fecha.TabIndex = 2;
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(82, 11);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(18, 17);
            this.Lbl_fecha.TabIndex = 1;
            this.Lbl_fecha.Text = "--";
            // 
            // Lbl_inferiorfecha
            // 
            this.Lbl_inferiorfecha.AutoSize = true;
            this.Lbl_inferiorfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_inferiorfecha.Location = new System.Drawing.Point(3, 11);
            this.Lbl_inferiorfecha.Name = "Lbl_inferiorfecha";
            this.Lbl_inferiorfecha.Size = new System.Drawing.Size(58, 20);
            this.Lbl_inferiorfecha.TabIndex = 0;
            this.Lbl_inferiorfecha.Text = "Fecha:";
            // 
            // MDI_Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 1015);
            this.Controls.Add(this.Pnl_inferior);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDI_Seguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Seguridad_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.Pnl_usuario.ResumeLayout(false);
            this.Pnl_usuario.PerformLayout();
            this.Pnl_inferior.ResumeLayout(false);
            this.Pnl_fecha.ResumeLayout(false);
            this.Pnl_fecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeAplicacionesAUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDePerfilesAUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeAplicacionesAPerfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionModuloAAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel Pnl_usuario;
        public System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.Label lbl_usuario;
        public System.Windows.Forms.Panel Pnl_inferior;
        private System.Windows.Forms.Panel Pnl_fecha;
        public System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_inferiorfecha;
    }
}



