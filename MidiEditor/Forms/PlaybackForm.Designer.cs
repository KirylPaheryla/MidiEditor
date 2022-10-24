namespace MidiEditor
{
    partial class PlaybackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaybackForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxLogs = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonMoveForward5sec = new System.Windows.Forms.Button();
            this.buttonMoveBack5sec = new System.Windows.Forms.Button();
            this.buttonMoveToStart = new System.Windows.Forms.Button();
            this.buttonLoop = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.trackBarTimeLine = new System.Windows.Forms.TrackBar();
            this.groupBoxPlaybackSettings = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonSpeedHalf = new System.Windows.Forms.Button();
            this.buttonSpeed2x = new System.Windows.Forms.Button();
            this.buttonSpeedNormal = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxOutputDevice = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkedListBoxTracking = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimeLine)).BeginInit();
            this.groupBoxPlaybackSettings.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxLogs);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
            // 
            // richTextBoxLogs
            // 
            this.richTextBoxLogs.Location = new System.Drawing.Point(0, 19);
            this.richTextBoxLogs.Name = "richTextBoxLogs";
            this.richTextBoxLogs.ReadOnly = true;
            this.richTextBoxLogs.Size = new System.Drawing.Size(490, 317);
            this.richTextBoxLogs.TabIndex = 0;
            this.richTextBoxLogs.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTime);
            this.groupBox2.Controls.Add(this.buttonMoveForward5sec);
            this.groupBox2.Controls.Add(this.buttonMoveBack5sec);
            this.groupBox2.Controls.Add(this.buttonMoveToStart);
            this.groupBox2.Controls.Add(this.buttonLoop);
            this.groupBox2.Controls.Add(this.buttonPause);
            this.groupBox2.Controls.Add(this.buttonPlay);
            this.groupBox2.Controls.Add(this.trackBarTimeLine);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Play panel";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(299, 55);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(100, 13);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "00:00:00 - 00:00:00";
            // 
            // buttonMoveForward5sec
            // 
            this.buttonMoveForward5sec.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveForward5sec.Image")));
            this.buttonMoveForward5sec.Location = new System.Drawing.Point(161, 29);
            this.buttonMoveForward5sec.Name = "buttonMoveForward5sec";
            this.buttonMoveForward5sec.Size = new System.Drawing.Size(25, 25);
            this.buttonMoveForward5sec.TabIndex = 7;
            this.buttonMoveForward5sec.UseVisualStyleBackColor = true;
            this.buttonMoveForward5sec.Click += new System.EventHandler(this.buttonMoveForward5sec_Click);
            // 
            // buttonMoveBack5sec
            // 
            this.buttonMoveBack5sec.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveBack5sec.Image")));
            this.buttonMoveBack5sec.Location = new System.Drawing.Point(130, 29);
            this.buttonMoveBack5sec.Name = "buttonMoveBack5sec";
            this.buttonMoveBack5sec.Size = new System.Drawing.Size(25, 25);
            this.buttonMoveBack5sec.TabIndex = 6;
            this.buttonMoveBack5sec.UseVisualStyleBackColor = true;
            this.buttonMoveBack5sec.Click += new System.EventHandler(this.buttonMoveBack5sec_Click);
            // 
            // buttonMoveToStart
            // 
            this.buttonMoveToStart.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveToStart.Image")));
            this.buttonMoveToStart.Location = new System.Drawing.Point(6, 29);
            this.buttonMoveToStart.Name = "buttonMoveToStart";
            this.buttonMoveToStart.Size = new System.Drawing.Size(25, 25);
            this.buttonMoveToStart.TabIndex = 5;
            this.buttonMoveToStart.UseVisualStyleBackColor = true;
            this.buttonMoveToStart.Click += new System.EventHandler(this.buttonMoveToStart_Click);
            // 
            // buttonLoop
            // 
            this.buttonLoop.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoop.Image")));
            this.buttonLoop.Location = new System.Drawing.Point(99, 29);
            this.buttonLoop.Name = "buttonLoop";
            this.buttonLoop.Size = new System.Drawing.Size(25, 25);
            this.buttonLoop.TabIndex = 4;
            this.buttonLoop.UseVisualStyleBackColor = true;
            this.buttonLoop.Click += new System.EventHandler(this.buttonLoop_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonPause.Image")));
            this.buttonPause.Location = new System.Drawing.Point(68, 29);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(25, 25);
            this.buttonPause.TabIndex = 3;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.Location = new System.Drawing.Point(37, 29);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(25, 25);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // trackBarTimeLine
            // 
            this.trackBarTimeLine.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarTimeLine.Location = new System.Drawing.Point(205, 29);
            this.trackBarTimeLine.Name = "trackBarTimeLine";
            this.trackBarTimeLine.Size = new System.Drawing.Size(279, 37);
            this.trackBarTimeLine.TabIndex = 2;
            this.trackBarTimeLine.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarTimeLine.Scroll += new System.EventHandler(this.trackBarTimeLine_Scroll);
            // 
            // groupBoxPlaybackSettings
            // 
            this.groupBoxPlaybackSettings.Controls.Add(this.groupBox6);
            this.groupBoxPlaybackSettings.Controls.Add(this.groupBox5);
            this.groupBoxPlaybackSettings.Controls.Add(this.groupBox4);
            this.groupBoxPlaybackSettings.Location = new System.Drawing.Point(514, 12);
            this.groupBoxPlaybackSettings.Name = "groupBoxPlaybackSettings";
            this.groupBoxPlaybackSettings.Size = new System.Drawing.Size(274, 426);
            this.groupBoxPlaybackSettings.TabIndex = 1;
            this.groupBoxPlaybackSettings.TabStop = false;
            this.groupBoxPlaybackSettings.Text = "Playback settings";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkedListBoxTracking);
            this.groupBox6.Location = new System.Drawing.Point(6, 133);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(262, 287);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data tracking";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonSpeedHalf);
            this.groupBox5.Controls.Add(this.buttonSpeed2x);
            this.groupBox5.Controls.Add(this.buttonSpeedNormal);
            this.groupBox5.Location = new System.Drawing.Point(6, 76);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 51);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Playback Speed";
            // 
            // buttonSpeedHalf
            // 
            this.buttonSpeedHalf.Location = new System.Drawing.Point(6, 17);
            this.buttonSpeedHalf.Name = "buttonSpeedHalf";
            this.buttonSpeedHalf.Size = new System.Drawing.Size(70, 23);
            this.buttonSpeedHalf.TabIndex = 2;
            this.buttonSpeedHalf.Text = "0.5x";
            this.buttonSpeedHalf.UseVisualStyleBackColor = true;
            this.buttonSpeedHalf.Click += new System.EventHandler(this.buttonSpeedHalf_Click);
            // 
            // buttonSpeed2x
            // 
            this.buttonSpeed2x.Location = new System.Drawing.Point(186, 17);
            this.buttonSpeed2x.Name = "buttonSpeed2x";
            this.buttonSpeed2x.Size = new System.Drawing.Size(70, 23);
            this.buttonSpeed2x.TabIndex = 1;
            this.buttonSpeed2x.Text = "2x";
            this.buttonSpeed2x.UseVisualStyleBackColor = true;
            this.buttonSpeed2x.Click += new System.EventHandler(this.buttonSpeed2x_Click);
            // 
            // buttonSpeedNormal
            // 
            this.buttonSpeedNormal.Location = new System.Drawing.Point(98, 17);
            this.buttonSpeedNormal.Name = "buttonSpeedNormal";
            this.buttonSpeedNormal.Size = new System.Drawing.Size(70, 23);
            this.buttonSpeedNormal.TabIndex = 0;
            this.buttonSpeedNormal.Text = "1x";
            this.buttonSpeedNormal.UseVisualStyleBackColor = true;
            this.buttonSpeedNormal.Click += new System.EventHandler(this.buttonSpeedNormal_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxOutputDevice);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 51);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output device";
            // 
            // comboBoxOutputDevice
            // 
            this.comboBoxOutputDevice.FormattingEnabled = true;
            this.comboBoxOutputDevice.Location = new System.Drawing.Point(6, 19);
            this.comboBoxOutputDevice.Name = "comboBoxOutputDevice";
            this.comboBoxOutputDevice.Size = new System.Drawing.Size(233, 21);
            this.comboBoxOutputDevice.TabIndex = 0;
            this.comboBoxOutputDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutputDevice_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkedListBoxTracking
            // 
            this.checkedListBoxTracking.CheckOnClick = true;
            this.checkedListBoxTracking.FormattingEnabled = true;
            this.checkedListBoxTracking.Items.AddRange(new object[] {
            "NoteOn",
            "NoteOff",
            "ChannelAftertouch",
            "ControlChange",
            "NoteAftertouch",
            "KeySignature",
            "PitchBend",
            "ProgramChange",
            "EscapeSysEx",
            "NormalSysEx",
            "SetTempo",
            "TimeSignature",
            "CopyrightNotice",
            "CuePoint",
            "DeviceName",
            "InstrumentName",
            "Lyric",
            "Marker",
            "ProgramName",
            "SequenceTrackName",
            "Text"});
            this.checkedListBoxTracking.Location = new System.Drawing.Point(6, 17);
            this.checkedListBoxTracking.MultiColumn = true;
            this.checkedListBoxTracking.Name = "checkedListBoxTracking";
            this.checkedListBoxTracking.Size = new System.Drawing.Size(250, 259);
            this.checkedListBoxTracking.TabIndex = 0;
            // 
            // PlaybackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxPlaybackSettings);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PlaybackForm";
            this.Text = "Playback";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlaybackForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimeLine)).EndInit();
            this.groupBoxPlaybackSettings.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TrackBar trackBarTimeLine;
        private System.Windows.Forms.RichTextBox richTextBoxLogs;
        private System.Windows.Forms.GroupBox groupBoxPlaybackSettings;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxOutputDevice;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonMoveToStart;
        private System.Windows.Forms.Button buttonLoop;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonMoveForward5sec;
        private System.Windows.Forms.Button buttonMoveBack5sec;
        private System.Windows.Forms.Button buttonSpeedHalf;
        private System.Windows.Forms.Button buttonSpeed2x;
        private System.Windows.Forms.Button buttonSpeedNormal;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckedListBox checkedListBoxTracking;
    }
}