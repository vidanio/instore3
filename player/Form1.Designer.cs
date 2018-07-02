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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabMusic = new System.Windows.Forms.TabPage();
            this.tabControls = new System.Windows.Forms.TabPage();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.chklstMusicStyles = new System.Windows.Forms.CheckedListBox();
            this.lblMusicFolder = new System.Windows.Forms.Label();
            this.fldbrwMusicFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.lblMusicStyles = new System.Windows.Forms.Label();
            this.txtboxMusicFolder = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtboxMessage = new System.Windows.Forms.TextBox();
            this.btnPlayMsg = new System.Windows.Forms.Button();
            this.openMsgToPlay = new System.Windows.Forms.OpenFileDialog();
            this.contextMainMenu.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabMusic.SuspendLayout();
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
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabMusic);
            this.tabMenu.Controls.Add(this.tabControls);
            this.tabMenu.Controls.Add(this.tabConfig);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.ShowToolTips = true;
            this.tabMenu.Size = new System.Drawing.Size(764, 461);
            this.tabMenu.TabIndex = 1;
            // 
            // tabMusic
            // 
            this.tabMusic.Controls.Add(this.btnPlayMsg);
            this.tabMusic.Controls.Add(this.lblMessage);
            this.tabMusic.Controls.Add(this.txtboxMessage);
            this.tabMusic.Controls.Add(this.txtboxMusicFolder);
            this.tabMusic.Controls.Add(this.lblMusicStyles);
            this.tabMusic.Controls.Add(this.lblMusicFolder);
            this.tabMusic.Controls.Add(this.chklstMusicStyles);
            this.tabMusic.Controls.Add(this.statusBar);
            this.tabMusic.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabMusic.Location = new System.Drawing.Point(4, 22);
            this.tabMusic.Name = "tabMusic";
            this.tabMusic.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusic.Size = new System.Drawing.Size(756, 435);
            this.tabMusic.TabIndex = 0;
            this.tabMusic.Text = "Musica";
            this.tabMusic.ToolTipText = "Programación de Música y Reproducción de Mensajes";
            this.tabMusic.UseVisualStyleBackColor = true;
            // 
            // tabControls
            // 
            this.tabControls.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControls.Location = new System.Drawing.Point(4, 22);
            this.tabControls.Name = "tabControls";
            this.tabControls.Padding = new System.Windows.Forms.Padding(3);
            this.tabControls.Size = new System.Drawing.Size(756, 435);
            this.tabControls.TabIndex = 2;
            this.tabControls.Text = "Controles";
            this.tabControls.ToolTipText = "Controles de Reproducción";
            this.tabControls.UseVisualStyleBackColor = true;
            // 
            // tabConfig
            // 
            this.tabConfig.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(756, 435);
            this.tabConfig.TabIndex = 3;
            this.tabConfig.Text = "Configuracion";
            this.tabConfig.ToolTipText = "Configuración de la Tienda";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(3, 410);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(750, 22);
            this.statusBar.TabIndex = 0;
            // 
            // toolTipMain
            // 
            this.toolTipMain.ShowAlways = true;
            // 
            // chklstMusicStyles
            // 
            this.chklstMusicStyles.CheckOnClick = true;
            this.chklstMusicStyles.FormattingEnabled = true;
            this.chklstMusicStyles.HorizontalScrollbar = true;
            this.chklstMusicStyles.Items.AddRange(new object[] {
            "Rock & Roll",
            "Techno",
            "Chillout",
            "Rap",
            "Años 60",
            "Años 70",
            "Años 80",
            "Años 90",
            "Siglo XXI",
            "Clásicos",
            "Locos Años 20",
            "Jazz",
            "Soul",
            "Reggae",
            "Reguetón",
            "Ballenato"});
            this.chklstMusicStyles.Location = new System.Drawing.Point(250, 86);
            this.chklstMusicStyles.Name = "chklstMusicStyles";
            this.chklstMusicStyles.Size = new System.Drawing.Size(284, 229);
            this.chklstMusicStyles.TabIndex = 1;
            this.toolTipMain.SetToolTip(this.chklstMusicStyles, "Seleccione los estilos de música que desee");
            // 
            // lblMusicFolder
            // 
            this.lblMusicFolder.AutoSize = true;
            this.lblMusicFolder.Location = new System.Drawing.Point(132, 61);
            this.lblMusicFolder.Name = "lblMusicFolder";
            this.lblMusicFolder.Size = new System.Drawing.Size(99, 13);
            this.lblMusicFolder.TabIndex = 2;
            this.lblMusicFolder.Text = "Carpeta de Música:";
            this.toolTipMain.SetToolTip(this.lblMusicFolder, "Carpeta Principal de Música");
            // 
            // lblMusicStyles
            // 
            this.lblMusicStyles.AutoSize = true;
            this.lblMusicStyles.Location = new System.Drawing.Point(132, 183);
            this.lblMusicStyles.Name = "lblMusicStyles";
            this.lblMusicStyles.Size = new System.Drawing.Size(92, 13);
            this.lblMusicStyles.TabIndex = 2;
            this.lblMusicStyles.Text = "Estilos de Música:";
            this.toolTipMain.SetToolTip(this.lblMusicStyles, "Subcarpetas de Estilos de Música");
            // 
            // txtboxMusicFolder
            // 
            this.txtboxMusicFolder.Location = new System.Drawing.Point(250, 58);
            this.txtboxMusicFolder.Name = "txtboxMusicFolder";
            this.txtboxMusicFolder.ReadOnly = true;
            this.txtboxMusicFolder.Size = new System.Drawing.Size(284, 20);
            this.txtboxMusicFolder.TabIndex = 3;
            this.toolTipMain.SetToolTip(this.txtboxMusicFolder, "Haga Click para Elegir la Carpeta Principal de Música");
            this.txtboxMusicFolder.Click += new System.EventHandler(this.txtboxMusicFolder_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(135, 330);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(87, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Mensaje manual:";
            // 
            // txtboxMessage
            // 
            this.txtboxMessage.Location = new System.Drawing.Point(250, 327);
            this.txtboxMessage.Name = "txtboxMessage";
            this.txtboxMessage.ReadOnly = true;
            this.txtboxMessage.Size = new System.Drawing.Size(226, 20);
            this.txtboxMessage.TabIndex = 3;
            this.txtboxMessage.Click += new System.EventHandler(this.txtboxMessage_Click);
            // 
            // btnPlayMsg
            // 
            this.btnPlayMsg.Location = new System.Drawing.Point(482, 327);
            this.btnPlayMsg.Name = "btnPlayMsg";
            this.btnPlayMsg.Size = new System.Drawing.Size(52, 21);
            this.btnPlayMsg.TabIndex = 5;
            this.btnPlayMsg.Text = "Play";
            this.btnPlayMsg.UseVisualStyleBackColor = true;
            // 
            // openMsgToPlay
            // 
            this.openMsgToPlay.Filter = "Audio MP3|*.mp3|Audio WMA|*.wma|Todos|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.Controls.Add(this.tabMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HMPro Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMainMenu.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMusic.ResumeLayout(false);
            this.tabMusic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyBarIcon;
        private System.Windows.Forms.ContextMenuStrip contextMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esconderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabMusic;
        private System.Windows.Forms.TabPage tabControls;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.TextBox txtboxMusicFolder;
        private System.Windows.Forms.Label lblMusicStyles;
        private System.Windows.Forms.Label lblMusicFolder;
        private System.Windows.Forms.CheckedListBox chklstMusicStyles;
        private System.Windows.Forms.FolderBrowserDialog fldbrwMusicFolder;
        private System.Windows.Forms.Button btnPlayMsg;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtboxMessage;
        private System.Windows.Forms.OpenFileDialog openMsgToPlay;
    }
}

