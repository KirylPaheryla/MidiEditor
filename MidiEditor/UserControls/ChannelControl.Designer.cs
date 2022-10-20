namespace MidiEditor.UserControls
{
    partial class ChannelControl
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
            this.labelChannelNumber = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelChannelNumber
            // 
            this.labelChannelNumber.AutoSize = true;
            this.labelChannelNumber.Location = new System.Drawing.Point(36, 3);
            this.labelChannelNumber.Name = "labelChannelNumber";
            this.labelChannelNumber.Size = new System.Drawing.Size(49, 13);
            this.labelChannelNumber.TabIndex = 4;
            this.labelChannelNumber.Text = "Channel ";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(3, 3);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(27, 46);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Checked = true;
            this.checkBoxShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShow.Location = new System.Drawing.Point(36, 32);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(53, 17);
            this.checkBoxShow.TabIndex = 6;
            this.checkBoxShow.Text = "Show";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // ChannelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.labelChannelNumber);
            this.Controls.Add(this.buttonColor);
            this.Name = "ChannelControl";
            this.Size = new System.Drawing.Size(108, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelChannelNumber;
        private System.Windows.Forms.Button buttonColor;
        public System.Windows.Forms.CheckBox checkBoxShow;
    }
}
