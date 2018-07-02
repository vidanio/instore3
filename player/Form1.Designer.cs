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
            this.axWMPMain = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWMPMsg = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlayMsg = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtboxMessage = new System.Windows.Forms.TextBox();
            this.txtboxMusicFolder = new System.Windows.Forms.TextBox();
            this.lblMusicStyles = new System.Windows.Forms.Label();
            this.lblMusicFolder = new System.Windows.Forms.Label();
            this.chklstMusicStyles = new System.Windows.Forms.CheckedListBox();
            this.tabControls = new System.Windows.Forms.TabPage();
            this.grpboxVolume = new System.Windows.Forms.GroupBox();
            this.lblFadeVol = new System.Windows.Forms.Label();
            this.lblMsgVol = new System.Windows.Forms.Label();
            this.lblPubliVol = new System.Windows.Forms.Label();
            this.lblMusicVol = new System.Windows.Forms.Label();
            this.lblFadeOut = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblPubli = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.tbarMin = new System.Windows.Forms.TrackBar();
            this.tbarMsg = new System.Windows.Forms.TrackBar();
            this.tbarPubli = new System.Windows.Forms.TrackBar();
            this.tbarMusic = new System.Windows.Forms.TrackBar();
            this.grpboxHoras = new System.Windows.Forms.GroupBox();
            this.timeDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.timeHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnHorasOK = new System.Windows.Forms.Button();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.fldbrwMusicFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.openMsgToPlay = new System.Windows.Forms.OpenFileDialog();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.statusLblConn = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPbarPlaying = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLblPlaying = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMainMenu.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPMsg)).BeginInit();
            this.tabControls.SuspendLayout();
            this.grpboxVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarPubli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMusic)).BeginInit();
            this.grpboxHoras.SuspendLayout();
            this.statusMain.SuspendLayout();
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
            this.tabMusic.Controls.Add(this.axWMPMain);
            this.tabMusic.Controls.Add(this.axWMPMsg);
            this.tabMusic.Controls.Add(this.btnPlayMsg);
            this.tabMusic.Controls.Add(this.lblMessage);
            this.tabMusic.Controls.Add(this.txtboxMessage);
            this.tabMusic.Controls.Add(this.txtboxMusicFolder);
            this.tabMusic.Controls.Add(this.lblMusicStyles);
            this.tabMusic.Controls.Add(this.lblMusicFolder);
            this.tabMusic.Controls.Add(this.chklstMusicStyles);
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
            // axWMPMain
            // 
            this.axWMPMain.Enabled = true;
            this.axWMPMain.Location = new System.Drawing.Point(138, 369);
            this.axWMPMain.Name = "axWMPMain";
            this.axWMPMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPMain.OcxState")));
            this.axWMPMain.Size = new System.Drawing.Size(188, 38);
            this.axWMPMain.TabIndex = 7;
            this.axWMPMain.Visible = false;
            // 
            // axWMPMsg
            // 
            this.axWMPMsg.Enabled = true;
            this.axWMPMsg.Location = new System.Drawing.Point(346, 369);
            this.axWMPMsg.Name = "axWMPMsg";
            this.axWMPMsg.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPMsg.OcxState")));
            this.axWMPMsg.Size = new System.Drawing.Size(188, 38);
            this.axWMPMsg.TabIndex = 6;
            this.axWMPMsg.Visible = false;
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
            // tabControls
            // 
            this.tabControls.Controls.Add(this.grpboxVolume);
            this.tabControls.Controls.Add(this.grpboxHoras);
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
            // grpboxVolume
            // 
            this.grpboxVolume.Controls.Add(this.lblFadeVol);
            this.grpboxVolume.Controls.Add(this.lblMsgVol);
            this.grpboxVolume.Controls.Add(this.lblPubliVol);
            this.grpboxVolume.Controls.Add(this.lblMusicVol);
            this.grpboxVolume.Controls.Add(this.lblFadeOut);
            this.grpboxVolume.Controls.Add(this.lblMsg);
            this.grpboxVolume.Controls.Add(this.lblPubli);
            this.grpboxVolume.Controls.Add(this.lblMusic);
            this.grpboxVolume.Controls.Add(this.tbarMin);
            this.grpboxVolume.Controls.Add(this.tbarMsg);
            this.grpboxVolume.Controls.Add(this.tbarPubli);
            this.grpboxVolume.Controls.Add(this.tbarMusic);
            this.grpboxVolume.Location = new System.Drawing.Point(132, 136);
            this.grpboxVolume.Name = "grpboxVolume";
            this.grpboxVolume.Size = new System.Drawing.Size(424, 254);
            this.grpboxVolume.TabIndex = 4;
            this.grpboxVolume.TabStop = false;
            this.grpboxVolume.Text = "Volumen";
            // 
            // lblFadeVol
            // 
            this.lblFadeVol.AutoSize = true;
            this.lblFadeVol.Location = new System.Drawing.Point(354, 228);
            this.lblFadeVol.Name = "lblFadeVol";
            this.lblFadeVol.Size = new System.Drawing.Size(19, 13);
            this.lblFadeVol.TabIndex = 7;
            this.lblFadeVol.Text = "10";
            // 
            // lblMsgVol
            // 
            this.lblMsgVol.AutoSize = true;
            this.lblMsgVol.Location = new System.Drawing.Point(247, 228);
            this.lblMsgVol.Name = "lblMsgVol";
            this.lblMsgVol.Size = new System.Drawing.Size(19, 13);
            this.lblMsgVol.TabIndex = 6;
            this.lblMsgVol.Text = "90";
            // 
            // lblPubliVol
            // 
            this.lblPubliVol.AutoSize = true;
            this.lblPubliVol.Location = new System.Drawing.Point(144, 228);
            this.lblPubliVol.Name = "lblPubliVol";
            this.lblPubliVol.Size = new System.Drawing.Size(19, 13);
            this.lblPubliVol.TabIndex = 5;
            this.lblPubliVol.Text = "70";
            // 
            // lblMusicVol
            // 
            this.lblMusicVol.AutoSize = true;
            this.lblMusicVol.Location = new System.Drawing.Point(45, 228);
            this.lblMusicVol.Name = "lblMusicVol";
            this.lblMusicVol.Size = new System.Drawing.Size(19, 13);
            this.lblMusicVol.TabIndex = 4;
            this.lblMusicVol.Text = "50";
            // 
            // lblFadeOut
            // 
            this.lblFadeOut.AutoSize = true;
            this.lblFadeOut.Location = new System.Drawing.Point(338, 42);
            this.lblFadeOut.Name = "lblFadeOut";
            this.lblFadeOut.Size = new System.Drawing.Size(49, 13);
            this.lblFadeOut.TabIndex = 3;
            this.lblFadeOut.Text = "Fade out";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(233, 42);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(52, 13);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "Mensajes";
            // 
            // lblPubli
            // 
            this.lblPubli.AutoSize = true;
            this.lblPubli.Location = new System.Drawing.Point(130, 42);
            this.lblPubli.Name = "lblPubli";
            this.lblPubli.Size = new System.Drawing.Size(56, 13);
            this.lblPubli.TabIndex = 1;
            this.lblPubli.Text = "Publicidad";
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Location = new System.Drawing.Point(36, 42);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(41, 13);
            this.lblMusic.TabIndex = 1;
            this.lblMusic.Text = "Música";
            // 
            // tbarMin
            // 
            this.tbarMin.Location = new System.Drawing.Point(341, 61);
            this.tbarMin.Maximum = 100;
            this.tbarMin.Name = "tbarMin";
            this.tbarMin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarMin.Size = new System.Drawing.Size(45, 155);
            this.tbarMin.TabIndex = 0;
            this.tbarMin.TickFrequency = 10;
            this.tbarMin.Value = 10;
            this.tbarMin.Scroll += new System.EventHandler(this.tbarMin_Scroll);
            // 
            // tbarMsg
            // 
            this.tbarMsg.Location = new System.Drawing.Point(236, 61);
            this.tbarMsg.Maximum = 100;
            this.tbarMsg.Name = "tbarMsg";
            this.tbarMsg.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarMsg.Size = new System.Drawing.Size(45, 155);
            this.tbarMsg.TabIndex = 0;
            this.tbarMsg.TickFrequency = 10;
            this.tbarMsg.Value = 90;
            this.tbarMsg.Scroll += new System.EventHandler(this.tbarMsg_Scroll);
            // 
            // tbarPubli
            // 
            this.tbarPubli.Location = new System.Drawing.Point(133, 61);
            this.tbarPubli.Maximum = 100;
            this.tbarPubli.Name = "tbarPubli";
            this.tbarPubli.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarPubli.Size = new System.Drawing.Size(45, 155);
            this.tbarPubli.TabIndex = 0;
            this.tbarPubli.TickFrequency = 10;
            this.tbarPubli.Value = 70;
            this.tbarPubli.Scroll += new System.EventHandler(this.tbarPubli_Scroll);
            // 
            // tbarMusic
            // 
            this.tbarMusic.Location = new System.Drawing.Point(32, 61);
            this.tbarMusic.Maximum = 100;
            this.tbarMusic.Name = "tbarMusic";
            this.tbarMusic.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarMusic.Size = new System.Drawing.Size(45, 155);
            this.tbarMusic.TabIndex = 0;
            this.tbarMusic.TickFrequency = 10;
            this.tbarMusic.Value = 50;
            this.tbarMusic.Scroll += new System.EventHandler(this.tbarMusic_Scroll);
            // 
            // grpboxHoras
            // 
            this.grpboxHoras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpboxHoras.Controls.Add(this.timeDesde);
            this.grpboxHoras.Controls.Add(this.lblDesde);
            this.grpboxHoras.Controls.Add(this.timeHasta);
            this.grpboxHoras.Controls.Add(this.lblHasta);
            this.grpboxHoras.Controls.Add(this.btnHorasOK);
            this.grpboxHoras.Location = new System.Drawing.Point(132, 46);
            this.grpboxHoras.Name = "grpboxHoras";
            this.grpboxHoras.Size = new System.Drawing.Size(424, 72);
            this.grpboxHoras.TabIndex = 3;
            this.grpboxHoras.TabStop = false;
            this.grpboxHoras.Text = "Horario de Reproducción";
            // 
            // timeDesde
            // 
            this.timeDesde.CustomFormat = "HH:mm";
            this.timeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeDesde.Location = new System.Drawing.Point(109, 28);
            this.timeDesde.Name = "timeDesde";
            this.timeDesde.ShowUpDown = true;
            this.timeDesde.Size = new System.Drawing.Size(54, 20);
            this.timeDesde.TabIndex = 0;
            this.timeDesde.Value = new System.DateTime(2018, 7, 2, 0, 0, 0, 0);
            this.timeDesde.ValueChanged += new System.EventHandler(this.timeDesde_ValueChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(62, 32);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // timeHasta
            // 
            this.timeHasta.CustomFormat = "HH:mm";
            this.timeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeHasta.Location = new System.Drawing.Point(261, 28);
            this.timeHasta.Name = "timeHasta";
            this.timeHasta.ShowUpDown = true;
            this.timeHasta.Size = new System.Drawing.Size(54, 20);
            this.timeHasta.TabIndex = 0;
            this.timeHasta.Value = new System.DateTime(2018, 7, 2, 23, 59, 0, 0);
            this.timeHasta.ValueChanged += new System.EventHandler(this.timeHasta_ValueChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(217, 32);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnHorasOK
            // 
            this.btnHorasOK.Location = new System.Drawing.Point(338, 28);
            this.btnHorasOK.Name = "btnHorasOK";
            this.btnHorasOK.Size = new System.Drawing.Size(48, 20);
            this.btnHorasOK.TabIndex = 1;
            this.btnHorasOK.Text = "OK";
            this.btnHorasOK.UseVisualStyleBackColor = true;
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
            // toolTipMain
            // 
            this.toolTipMain.ShowAlways = true;
            // 
            // openMsgToPlay
            // 
            this.openMsgToPlay.Filter = "Audio MP3|*.mp3|Audio WMA|*.wma|Todos|*.*";
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLblConn,
            this.statusPbarPlaying,
            this.statusLblPlaying});
            this.statusMain.Location = new System.Drawing.Point(0, 439);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(764, 22);
            this.statusMain.TabIndex = 2;
            // 
            // statusLblConn
            // 
            this.statusLblConn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.statusLblConn.Name = "statusLblConn";
            this.statusLblConn.Size = new System.Drawing.Size(131, 17);
            this.statusLblConn.Text = "Conectado al Server OK";
            // 
            // statusPbarPlaying
            // 
            this.statusPbarPlaying.Name = "statusPbarPlaying";
            this.statusPbarPlaying.Size = new System.Drawing.Size(100, 16);
            this.statusPbarPlaying.Value = 40;
            // 
            // statusLblPlaying
            // 
            this.statusLblPlaying.Name = "statusLblPlaying";
            this.statusLblPlaying.Size = new System.Drawing.Size(287, 17);
            this.statusLblPlaying.Text = "Playing \"Just cant get enough - Depeche Mode.mp3\"";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.Controls.Add(this.statusMain);
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
            ((System.ComponentModel.ISupportInitialize)(this.axWMPMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPMsg)).EndInit();
            this.tabControls.ResumeLayout(false);
            this.grpboxVolume.ResumeLayout(false);
            this.grpboxVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarPubli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMusic)).EndInit();
            this.grpboxHoras.ResumeLayout(false);
            this.grpboxHoras.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DateTimePicker timeDesde;
        private System.Windows.Forms.GroupBox grpboxVolume;
        private System.Windows.Forms.Label lblFadeVol;
        private System.Windows.Forms.Label lblMsgVol;
        private System.Windows.Forms.Label lblPubliVol;
        private System.Windows.Forms.Label lblMusicVol;
        private System.Windows.Forms.Label lblFadeOut;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblPubli;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.TrackBar tbarMin;
        private System.Windows.Forms.TrackBar tbarMsg;
        private System.Windows.Forms.TrackBar tbarPubli;
        private System.Windows.Forms.TrackBar tbarMusic;
        private System.Windows.Forms.GroupBox grpboxHoras;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker timeHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnHorasOK;
        private AxWMPLib.AxWindowsMediaPlayer axWMPMain;
        private AxWMPLib.AxWindowsMediaPlayer axWMPMsg;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel statusLblConn;
        private System.Windows.Forms.ToolStripProgressBar statusPbarPlaying;
        private System.Windows.Forms.ToolStripStatusLabel statusLblPlaying;
    }
}

