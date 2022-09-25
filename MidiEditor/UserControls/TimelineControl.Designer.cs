namespace MidiEditor
{
    partial class TimelineControl
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
            this.pictureBoxTimeline = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimeline)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTimeline
            // 
            this.pictureBoxTimeline.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTimeline.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTimeline.Name = "pictureBoxTimeline";
            this.pictureBoxTimeline.Size = new System.Drawing.Size(145, 51);
            this.pictureBoxTimeline.TabIndex = 0;
            this.pictureBoxTimeline.TabStop = false;
            this.pictureBoxTimeline.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxTimeline_Paint);
            // 
            // TimelineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBoxTimeline);
            this.Name = "TimelineControl";
            this.Size = new System.Drawing.Size(145, 51);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimeline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTimeline;
    }
}
