namespace MidiEditor
{
    partial class TrackControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackControl));
            this.labelTrackNumber = new System.Windows.Forms.Label();
            this.labelTrackName = new System.Windows.Forms.Label();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.buttonTrash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTrackNumber
            // 
            this.labelTrackNumber.AutoSize = true;
            this.labelTrackNumber.Location = new System.Drawing.Point(3, 3);
            this.labelTrackNumber.Name = "labelTrackNumber";
            this.labelTrackNumber.Size = new System.Drawing.Size(44, 13);
            this.labelTrackNumber.TabIndex = 0;
            this.labelTrackNumber.Text = "Track 0";
            // 
            // labelTrackName
            // 
            this.labelTrackName.AutoSize = true;
            this.labelTrackName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelTrackName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackName.Location = new System.Drawing.Point(3, 17);
            this.labelTrackName.Name = "labelTrackName";
            this.labelTrackName.Size = new System.Drawing.Size(70, 13);
            this.labelTrackName.TabIndex = 1;
            this.labelTrackName.Text = "Untitled track";
            this.labelTrackName.Click += new System.EventHandler(this.labelTrackName_Click);
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Checked = true;
            this.checkBoxShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShow.Location = new System.Drawing.Point(6, 33);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(53, 17);
            this.checkBoxShow.TabIndex = 4;
            this.checkBoxShow.Text = "Show";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // buttonTrash
            // 
            this.buttonTrash.Image = ((System.Drawing.Image)(resources.GetObject("buttonTrash.Image")));
            this.buttonTrash.Location = new System.Drawing.Point(150, 4);
            this.buttonTrash.Name = "buttonTrash";
            this.buttonTrash.Size = new System.Drawing.Size(27, 46);
            this.buttonTrash.TabIndex = 3;
            this.buttonTrash.UseVisualStyleBackColor = true;
            this.buttonTrash.Click += new System.EventHandler(this.buttonTrash_Click);
            // 
            // TrackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.buttonTrash);
            this.Controls.Add(this.labelTrackName);
            this.Controls.Add(this.labelTrackNumber);
            this.Name = "TrackControl";
            this.Size = new System.Drawing.Size(180, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTrackNumber;
        private System.Windows.Forms.Label labelTrackName;
        private System.Windows.Forms.Button buttonTrash;
        public System.Windows.Forms.CheckBox checkBoxShow;
    }
}
