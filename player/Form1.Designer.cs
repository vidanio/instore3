namespace player
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyBarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esconderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyBarIcon
            // 
            this.notifyBarIcon.ContextMenuStrip = this.contextMainMenu;
            this.notifyBarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyBarIcon.Icon")));
            this.notifyBarIcon.Text = "HMPro Player";
            this.notifyBarIcon.Visible = true;
            this.notifyBarIcon.DoubleClick += new System.EventHandler(this.notifyBarIcon_DoubleClick);
            // 
            // contextMainMenu
            // 
            this.contextMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.esconderToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.contextMainMenu.Name = "contextMainMenu";
            this.contextMainMenu.Size = new System.Drawing.Size(123, 70);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // esconderToolStripMenuItem
            // 
            this.esconderToolStripMenuItem.Name = "esconderToolStripMenuItem";
            this.esconderToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.esconderToolStripMenuItem.Text = "Esconder";
            this.esconderToolStripMenuItem.Click += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HMPro Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyBarIcon;
        private System.Windows.Forms.ContextMenuStrip contextMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esconderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

