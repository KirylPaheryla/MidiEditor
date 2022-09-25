namespace MidiEditor
{
    partial class EditorsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorsControl));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTracks = new System.Windows.Forms.TabPage();
            this.panelTrackList = new System.Windows.Forms.Panel();
            this.toolStripTabTracks = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddTrack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonShowAllTracks = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHideAllTracks = new System.Windows.Forms.ToolStripButton();
            this.tabPageChannels = new System.Windows.Forms.TabPage();
            this.panelChannelList = new System.Windows.Forms.Panel();
            this.toolStripTabChannels = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonShowAllChannels = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHideAllChannels = new System.Windows.Forms.ToolStripButton();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageTracks.SuspendLayout();
            this.toolStripTabTracks.SuspendLayout();
            this.tabPageChannels.SuspendLayout();
            this.toolStripTabChannels.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.propertyGrid, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(370, 497);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTracks);
            this.tabControl.Controls.Add(this.tabPageChannels);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(364, 224);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageTracks
            // 
            this.tabPageTracks.Controls.Add(this.panelTrackList);
            this.tabPageTracks.Controls.Add(this.toolStripTabTracks);
            this.tabPageTracks.Location = new System.Drawing.Point(4, 22);
            this.tabPageTracks.Name = "tabPageTracks";
            this.tabPageTracks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTracks.Size = new System.Drawing.Size(356, 198);
            this.tabPageTracks.TabIndex = 0;
            this.tabPageTracks.Text = "Tracks";
            this.tabPageTracks.UseVisualStyleBackColor = true;
            // 
            // panelTrackList
            // 
            this.panelTrackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrackList.Location = new System.Drawing.Point(3, 28);
            this.panelTrackList.Name = "panelTrackList";
            this.panelTrackList.Size = new System.Drawing.Size(350, 167);
            this.panelTrackList.TabIndex = 1;
            // 
            // toolStripTabTracks
            // 
            this.toolStripTabTracks.Location = new System.Drawing.Point(3, 3);
            this.toolStripTabTracks.Name = "toolStripTabTracks";
            this.toolStripTabTracks.Size = new System.Drawing.Size(350, 25);
            this.toolStripTabTracks.TabIndex = 0;
            // 
            // toolStripButtonAddTrack
            // 
            this.toolStripButtonAddTrack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddTrack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddTrack.Image")));
            this.toolStripButtonAddTrack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddTrack.Name = "toolStripButtonAddTrack";
            this.toolStripButtonAddTrack.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddTrack.Text = "toolStripButton1";
            this.toolStripButtonAddTrack.ToolTipText = "Add new track";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonShowAllTracks
            // 
            this.toolStripButtonShowAllTracks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowAllTracks.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowAllTracks.Image")));
            this.toolStripButtonShowAllTracks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowAllTracks.Name = "toolStripButtonShowAllTracks";
            this.toolStripButtonShowAllTracks.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonShowAllTracks.Text = "toolStripButton2";
            this.toolStripButtonShowAllTracks.ToolTipText = "Make all tracks visible";
            // 
            // toolStripButtonHideAllTracks
            // 
            this.toolStripButtonHideAllTracks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHideAllTracks.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHideAllTracks.Image")));
            this.toolStripButtonHideAllTracks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHideAllTracks.Name = "toolStripButtonHideAllTracks";
            this.toolStripButtonHideAllTracks.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonHideAllTracks.Text = "toolStripButton3";
            this.toolStripButtonHideAllTracks.ToolTipText = "Hide all tracks";
            // 
            // tabPageChannels
            // 
            this.tabPageChannels.Controls.Add(this.panelChannelList);
            this.tabPageChannels.Controls.Add(this.toolStripTabChannels);
            this.tabPageChannels.Location = new System.Drawing.Point(4, 22);
            this.tabPageChannels.Name = "tabPageChannels";
            this.tabPageChannels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChannels.Size = new System.Drawing.Size(356, 198);
            this.tabPageChannels.TabIndex = 1;
            this.tabPageChannels.Text = "Channels";
            this.tabPageChannels.UseVisualStyleBackColor = true;
            // 
            // panelChannelList
            // 
            this.panelChannelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChannelList.Location = new System.Drawing.Point(3, 28);
            this.panelChannelList.Name = "panelChannelList";
            this.panelChannelList.Size = new System.Drawing.Size(350, 167);
            this.panelChannelList.TabIndex = 1;
            // 
            // toolStripTabChannels
            // 
            this.toolStripTabChannels.Location = new System.Drawing.Point(3, 3);
            this.toolStripTabChannels.Name = "toolStripTabChannels";
            this.toolStripTabChannels.Size = new System.Drawing.Size(350, 25);
            this.toolStripTabChannels.TabIndex = 0;
            // 
            // toolStripButtonShowAllChannels
            // 
            this.toolStripButtonShowAllChannels.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowAllChannels.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowAllChannels.Image")));
            this.toolStripButtonShowAllChannels.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowAllChannels.Name = "toolStripButtonShowAllChannels";
            this.toolStripButtonShowAllChannels.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonShowAllChannels.Text = "toolStripButton1";
            this.toolStripButtonShowAllChannels.ToolTipText = "Make all channels visible";
            // 
            // toolStripButtonHideAllChannels
            // 
            this.toolStripButtonHideAllChannels.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHideAllChannels.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHideAllChannels.Image")));
            this.toolStripButtonHideAllChannels.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHideAllChannels.Name = "toolStripButtonHideAllChannels";
            this.toolStripButtonHideAllChannels.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonHideAllChannels.Text = "toolStripButton2";
            this.toolStripButtonHideAllChannels.ToolTipText = "Hide all channels";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(3, 233);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(364, 261);
            this.propertyGrid.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(350, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStripTabTracks";
            // 
            // EditorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "EditorsControl";
            this.Size = new System.Drawing.Size(370, 497);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageTracks.ResumeLayout(false);
            this.tabPageTracks.PerformLayout();
            this.toolStripTabTracks.ResumeLayout(false);
            this.toolStripTabTracks.PerformLayout();
            this.tabPageChannels.ResumeLayout(false);
            this.tabPageChannels.PerformLayout();
            this.toolStripTabChannels.ResumeLayout(false);
            this.toolStripTabChannels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTracks;
        private System.Windows.Forms.TabPage tabPageChannels;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.ToolStrip toolStripTabTracks;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddTrack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowAllTracks;
        private System.Windows.Forms.ToolStripButton toolStripButtonHideAllTracks;
        private System.Windows.Forms.ToolStrip toolStripTabChannels;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowAllChannels;
        private System.Windows.Forms.ToolStripButton toolStripButtonHideAllChannels;
        private System.Windows.Forms.Panel panelTrackList;
        private System.Windows.Forms.Panel panelChannelList;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}
