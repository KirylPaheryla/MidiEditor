namespace MidiEditor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playbackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.selectEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideAllTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.showAllChannelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideAllChannelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainForm = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonSelectEvent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCreateNewEvent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteEvent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonZoomHorOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZoomHorIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonZoomVerOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZoomVerIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxTracks = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxChannels = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStripPianoRoll = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pianoRollControl = new MidiEditor.PianoRollControl();
            this.pianoKeysControl = new MidiEditor.PianoKeysControl();
            this.timelineControl = new MidiEditor.TimelineControl();
            this.editorsControl = new MidiEditor.EditorsControl();
            this.menuStripMainForm.SuspendLayout();
            this.toolStripMainForm.SuspendLayout();
            this.contextMenuStripPianoRoll.SuspendLayout();
            this.contextMenuStripEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripMainForm.Size = new System.Drawing.Size(964, 24);
            this.menuStripMainForm.TabIndex = 1;
            this.menuStripMainForm.Text = "Menu strip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitToolStripMenuItem.Image")));
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Shutdown";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playbackToolStripMenuItem1,
            this.toolStripSeparator14,
            this.selectEventToolStripMenuItem,
            this.createNewEventToolStripMenuItem,
            this.deleteEventToolStripMenuItem,
            this.toolStripSeparator3,
            this.addToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // playbackToolStripMenuItem1
            // 
            this.playbackToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("playbackToolStripMenuItem1.Image")));
            this.playbackToolStripMenuItem1.Name = "playbackToolStripMenuItem1";
            this.playbackToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.playbackToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.playbackToolStripMenuItem1.Text = "Playback";
            this.playbackToolStripMenuItem1.Click += new System.EventHandler(this.playbackToolStripMenuItem1_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(200, 6);
            // 
            // selectEventToolStripMenuItem
            // 
            this.selectEventToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectEventToolStripMenuItem.Image")));
            this.selectEventToolStripMenuItem.Name = "selectEventToolStripMenuItem";
            this.selectEventToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.selectEventToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.selectEventToolStripMenuItem.Text = "Select event";
            this.selectEventToolStripMenuItem.Click += new System.EventHandler(this.selectEventToolStripMenuItem_Click);
            // 
            // createNewEventToolStripMenuItem
            // 
            this.createNewEventToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewEventToolStripMenuItem.Image")));
            this.createNewEventToolStripMenuItem.Name = "createNewEventToolStripMenuItem";
            this.createNewEventToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.createNewEventToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.createNewEventToolStripMenuItem.Text = "Create new event";
            this.createNewEventToolStripMenuItem.Click += new System.EventHandler(this.createNewEventToolStripMenuItem_Click);
            // 
            // deleteEventToolStripMenuItem
            // 
            this.deleteEventToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteEventToolStripMenuItem.Image")));
            this.deleteEventToolStripMenuItem.Name = "deleteEventToolStripMenuItem";
            this.deleteEventToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.deleteEventToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.deleteEventToolStripMenuItem.Text = "Delete event";
            this.deleteEventToolStripMenuItem.Click += new System.EventHandler(this.deleteEventToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(200, 6);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.addToolStripMenuItem.Text = "Add track";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.toolStripSeparator8,
            this.showAllToolStripMenuItem,
            this.hideAllTracksToolStripMenuItem,
            this.toolStripSeparator9,
            this.showAllChannelsToolStripMenuItem,
            this.hideAllChannelsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizToolStripMenuItem,
            this.horizontalInToolStripMenuItem,
            this.toolStripSeparator6,
            this.verticalToolStripMenuItem,
            this.verticalInToolStripMenuItem});
            this.zoomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoomToolStripMenuItem.Image")));
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.zoomToolStripMenuItem.Text = "PianoRoll zoom";
            // 
            // horizToolStripMenuItem
            // 
            this.horizToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("horizToolStripMenuItem.Image")));
            this.horizToolStripMenuItem.Name = "horizToolStripMenuItem";
            this.horizToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Down)));
            this.horizToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.horizToolStripMenuItem.Text = "Horizontal out";
            this.horizToolStripMenuItem.Click += new System.EventHandler(this.horizToolStripMenuItem_Click);
            // 
            // horizontalInToolStripMenuItem
            // 
            this.horizontalInToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("horizontalInToolStripMenuItem.Image")));
            this.horizontalInToolStripMenuItem.Name = "horizontalInToolStripMenuItem";
            this.horizontalInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Up)));
            this.horizontalInToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.horizontalInToolStripMenuItem.Text = "Horizontal in";
            this.horizontalInToolStripMenuItem.Click += new System.EventHandler(this.horizontalInToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verticalToolStripMenuItem.Image")));
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.verticalToolStripMenuItem.Text = "Vertical out";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // verticalInToolStripMenuItem
            // 
            this.verticalInToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verticalInToolStripMenuItem.Image")));
            this.verticalInToolStripMenuItem.Name = "verticalInToolStripMenuItem";
            this.verticalInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.verticalInToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.verticalInToolStripMenuItem.Text = "Vertical in";
            this.verticalInToolStripMenuItem.Click += new System.EventHandler(this.verticalInToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(252, 6);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showAllToolStripMenuItem.Image")));
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.showAllToolStripMenuItem.Text = "Show all tracks";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // hideAllTracksToolStripMenuItem
            // 
            this.hideAllTracksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hideAllTracksToolStripMenuItem.Image")));
            this.hideAllTracksToolStripMenuItem.Name = "hideAllTracksToolStripMenuItem";
            this.hideAllTracksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.hideAllTracksToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.hideAllTracksToolStripMenuItem.Text = "Hide all tracks";
            this.hideAllTracksToolStripMenuItem.Click += new System.EventHandler(this.hideAllTracksToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(252, 6);
            // 
            // showAllChannelsToolStripMenuItem
            // 
            this.showAllChannelsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showAllChannelsToolStripMenuItem.Image")));
            this.showAllChannelsToolStripMenuItem.Name = "showAllChannelsToolStripMenuItem";
            this.showAllChannelsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.showAllChannelsToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.showAllChannelsToolStripMenuItem.Text = "Show all channels on current track";
            this.showAllChannelsToolStripMenuItem.Click += new System.EventHandler(this.showAllChannelsToolStripMenuItem_Click);
            // 
            // hideAllChannelsToolStripMenuItem
            // 
            this.hideAllChannelsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hideAllChannelsToolStripMenuItem.Image")));
            this.hideAllChannelsToolStripMenuItem.Name = "hideAllChannelsToolStripMenuItem";
            this.hideAllChannelsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.H)));
            this.hideAllChannelsToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.hideAllChannelsToolStripMenuItem.Text = "Hide all channels on current track";
            this.hideAllChannelsToolStripMenuItem.Click += new System.EventHandler(this.hideAllChannelsToolStripMenuItem_Click);
            // 
            // toolStripMainForm
            // 
            this.toolStripMainForm.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStripMainForm.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.toolStripButtonPlay,
            this.toolStripSeparator10,
            this.toolStripLabel6,
            this.toolStripButtonSelectEvent,
            this.toolStripButtonCreateNewEvent,
            this.toolStripButtonDeleteEvent,
            this.toolStripSeparator11,
            this.toolStripLabel1,
            this.toolStripButtonZoomHorOut,
            this.toolStripButtonZoomHorIn,
            this.toolStripSeparator12,
            this.toolStripLabel2,
            this.toolStripButtonZoomVerOut,
            this.toolStripButtonZoomVerIn,
            this.toolStripSeparator13,
            this.toolStripLabel3,
            this.toolStripLabel7,
            this.toolStripComboBoxTracks,
            this.toolStripLabel4,
            this.toolStripComboBoxChannels});
            this.toolStripMainForm.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripMainForm.Location = new System.Drawing.Point(0, 24);
            this.toolStripMainForm.Name = "toolStripMainForm";
            this.toolStripMainForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMainForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMainForm.Size = new System.Drawing.Size(964, 23);
            this.toolStripMainForm.TabIndex = 2;
            this.toolStripMainForm.Text = "Tool strip";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(57, 15);
            this.toolStripLabel5.Text = "Playback:";
            // 
            // toolStripButtonPlay
            // 
            this.toolStripButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlay.Image")));
            this.toolStripButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPlay.Name = "toolStripButtonPlay";
            this.toolStripButtonPlay.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonPlay.Text = "toolStripButton1";
            this.toolStripButtonPlay.ToolTipText = "Play";
            this.toolStripButtonPlay.Click += new System.EventHandler(this.toolStripButtonPlay_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(37, 15);
            this.toolStripLabel6.Text = "Tools:";
            // 
            // toolStripButtonSelectEvent
            // 
            this.toolStripButtonSelectEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSelectEvent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelectEvent.Image")));
            this.toolStripButtonSelectEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelectEvent.Name = "toolStripButtonSelectEvent";
            this.toolStripButtonSelectEvent.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonSelectEvent.Text = "toolStripButton3";
            this.toolStripButtonSelectEvent.ToolTipText = "Select event";
            this.toolStripButtonSelectEvent.Click += new System.EventHandler(this.toolStripButtonSelectEvent_Click);
            // 
            // toolStripButtonCreateNewEvent
            // 
            this.toolStripButtonCreateNewEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCreateNewEvent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreateNewEvent.Image")));
            this.toolStripButtonCreateNewEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreateNewEvent.Name = "toolStripButtonCreateNewEvent";
            this.toolStripButtonCreateNewEvent.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonCreateNewEvent.Text = "toolStripButton4";
            this.toolStripButtonCreateNewEvent.ToolTipText = "Create new event";
            this.toolStripButtonCreateNewEvent.Click += new System.EventHandler(this.toolStripButtonCreateNewEvent_Click);
            // 
            // toolStripButtonDeleteEvent
            // 
            this.toolStripButtonDeleteEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteEvent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteEvent.Image")));
            this.toolStripButtonDeleteEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteEvent.Name = "toolStripButtonDeleteEvent";
            this.toolStripButtonDeleteEvent.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonDeleteEvent.Text = "toolStripButton5";
            this.toolStripButtonDeleteEvent.ToolTipText = "Delete event";
            this.toolStripButtonDeleteEvent.Click += new System.EventHandler(this.toolStripButtonDeleteEvent_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 15);
            this.toolStripLabel1.Text = "Horizontal zoom:";
            // 
            // toolStripButtonZoomHorOut
            // 
            this.toolStripButtonZoomHorOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomHorOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZoomHorOut.Image")));
            this.toolStripButtonZoomHorOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomHorOut.Name = "toolStripButtonZoomHorOut";
            this.toolStripButtonZoomHorOut.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonZoomHorOut.Text = "toolStripButton6";
            this.toolStripButtonZoomHorOut.ToolTipText = "Horizontal zoom out";
            this.toolStripButtonZoomHorOut.Click += new System.EventHandler(this.toolStripButtonZoomHorOut_Click);
            // 
            // toolStripButtonZoomHorIn
            // 
            this.toolStripButtonZoomHorIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomHorIn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZoomHorIn.Image")));
            this.toolStripButtonZoomHorIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomHorIn.Name = "toolStripButtonZoomHorIn";
            this.toolStripButtonZoomHorIn.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonZoomHorIn.Text = "toolStripButton7";
            this.toolStripButtonZoomHorIn.ToolTipText = "Horizontal zoom in";
            this.toolStripButtonZoomHorIn.Click += new System.EventHandler(this.toolStripButtonZoomHorIn_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(81, 15);
            this.toolStripLabel2.Text = "Vertical zoom:";
            // 
            // toolStripButtonZoomVerOut
            // 
            this.toolStripButtonZoomVerOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomVerOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZoomVerOut.Image")));
            this.toolStripButtonZoomVerOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomVerOut.Name = "toolStripButtonZoomVerOut";
            this.toolStripButtonZoomVerOut.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonZoomVerOut.Text = "toolStripButton8";
            this.toolStripButtonZoomVerOut.ToolTipText = "Vertical zoom out";
            this.toolStripButtonZoomVerOut.Click += new System.EventHandler(this.toolStripButtonZoomVerOut_Click);
            // 
            // toolStripButtonZoomVerIn
            // 
            this.toolStripButtonZoomVerIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomVerIn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZoomVerIn.Image")));
            this.toolStripButtonZoomVerIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomVerIn.Name = "toolStripButtonZoomVerIn";
            this.toolStripButtonZoomVerIn.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonZoomVerIn.Text = "toolStripButton9";
            this.toolStripButtonZoomVerIn.ToolTipText = "Vertical zoom in";
            this.toolStripButtonZoomVerIn.Click += new System.EventHandler(this.toolStripButtonZoomVerIn_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(117, 15);
            this.toolStripLabel3.Text = "Add new events to ...";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(37, 15);
            this.toolStripLabel7.Text = "Track:";
            // 
            // toolStripComboBoxTracks
            // 
            this.toolStripComboBoxTracks.Name = "toolStripComboBoxTracks";
            this.toolStripComboBoxTracks.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(54, 15);
            this.toolStripLabel4.Text = "Channel:";
            // 
            // toolStripComboBoxChannels
            // 
            this.toolStripComboBoxChannels.Name = "toolStripComboBoxChannels";
            this.toolStripComboBoxChannels.Size = new System.Drawing.Size(121, 23);
            // 
            // contextMenuStripPianoRoll
            // 
            this.contextMenuStripPianoRoll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.contextMenuStripPianoRoll.Name = "contextMenuStripPianoRoll";
            this.contextMenuStripPianoRoll.Size = new System.Drawing.Size(109, 26);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createToolStripMenuItem.Image")));
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // contextMenuStripEvent
            // 
            this.contextMenuStripEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStripEvent.Name = "contextMenuStripEvent";
            this.contextMenuStripEvent.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(0, 50);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pianoRollControl);
            this.splitContainer.Panel1.Controls.Add(this.pianoKeysControl);
            this.splitContainer.Panel1.Controls.Add(this.timelineControl);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.editorsControl);
            this.splitContainer.Size = new System.Drawing.Size(964, 441);
            this.splitContainer.SplitterDistance = 742;
            this.splitContainer.TabIndex = 9;
            // 
            // pianoRollControl
            // 
            this.pianoRollControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pianoRollControl.AutoScroll = true;
            this.pianoRollControl.BackColor = System.Drawing.Color.Linen;
            this.pianoRollControl.ContextMenuStrip = this.contextMenuStripPianoRoll;
            this.pianoRollControl.Location = new System.Drawing.Point(103, 18);
            this.pianoRollControl.Name = "pianoRollControl";
            this.pianoRollControl.Size = new System.Drawing.Size(638, 423);
            this.pianoRollControl.TabIndex = 4;
            this.pianoRollControl.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pianoRollControl_Scroll);
            this.pianoRollControl.ClientSizeChanged += new System.EventHandler(this.pianoRollControl_ClientSizeChanged);
            this.pianoRollControl.Paint += new System.Windows.Forms.PaintEventHandler(this.pianoRollControl_Paint);
            this.pianoRollControl.Layout += new System.Windows.Forms.LayoutEventHandler(this.pianoRollControl_Layout);
            // 
            // pianoKeysControl
            // 
            this.pianoKeysControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pianoKeysControl.AutoScroll = true;
            this.pianoKeysControl.Location = new System.Drawing.Point(0, 18);
            this.pianoKeysControl.Name = "pianoKeysControl";
            this.pianoKeysControl.Size = new System.Drawing.Size(741, 423);
            this.pianoKeysControl.TabIndex = 5;
            // 
            // timelineControl
            // 
            this.timelineControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timelineControl.AutoScroll = true;
            this.timelineControl.BackColor = System.Drawing.Color.Transparent;
            this.timelineControl.Location = new System.Drawing.Point(103, 0);
            this.timelineControl.Name = "timelineControl";
            this.timelineControl.Size = new System.Drawing.Size(681, 44);
            this.timelineControl.TabIndex = 8;
            this.timelineControl.Load += new System.EventHandler(this.timelineControl_Load);
            this.timelineControl.Resize += new System.EventHandler(this.timelineControl_Resize);
            // 
            // editorsControl
            // 
            this.editorsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorsControl.Location = new System.Drawing.Point(0, 0);
            this.editorsControl.Name = "editorsControl";
            this.editorsControl.Size = new System.Drawing.Size(218, 441);
            this.editorsControl.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(964, 491);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStripMainForm);
            this.Controls.Add(this.menuStripMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(980, 530);
            this.Name = "MainForm";
            this.Text = "MidiEditor";
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            this.toolStripMainForm.ResumeLayout(false);
            this.toolStripMainForm.PerformLayout();
            this.contextMenuStripPianoRoll.ResumeLayout(false);
            this.contextMenuStripEvent.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalInToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalInToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideAllTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem showAllChannelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideAllChannelsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMainForm;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButtonPlay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelectEvent;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreateNewEvent;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteEvent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoomHorOut;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoomHorIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoomVerOut;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoomVerIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private PianoKeysControl pianoKeysControl;
        private PianoRollControl pianoRollControl;
        private EditorsControl editorsControl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPianoRoll;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEvent;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private TimelineControl timelineControl;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem playbackToolStripMenuItem1;
        public System.Windows.Forms.ToolStripComboBox toolStripComboBoxTracks;
        public System.Windows.Forms.ToolStripComboBox toolStripComboBoxChannels;
    }
}

