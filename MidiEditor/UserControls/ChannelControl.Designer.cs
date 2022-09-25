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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChannelControl));
            this.labelChannelNumber = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.labelChannelInstrument = new System.Windows.Forms.Label();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.buttonInstrumentSelection = new System.Windows.Forms.Button();
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
            // labelChannelInstrument
            // 
            this.labelChannelInstrument.AutoSize = true;
            this.labelChannelInstrument.Location = new System.Drawing.Point(36, 16);
            this.labelChannelInstrument.Name = "labelChannelInstrument";
            this.labelChannelInstrument.Size = new System.Drawing.Size(34, 13);
            this.labelChannelInstrument.TabIndex = 5;
            this.labelChannelInstrument.Text = "Piano";
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Checked = true;
            this.checkBoxShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShow.Location = new System.Drawing.Point(39, 32);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(53, 17);
            this.checkBoxShow.TabIndex = 6;
            this.checkBoxShow.Text = "Show";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // buttonInstrumentSelection
            // 
            this.buttonInstrumentSelection.Image = ((System.Drawing.Image)(resources.GetObject("buttonInstrumentSelection.Image")));
            this.buttonInstrumentSelection.Location = new System.Drawing.Point(146, 3);
            this.buttonInstrumentSelection.Name = "buttonInstrumentSelection";
            this.buttonInstrumentSelection.Size = new System.Drawing.Size(27, 46);
            this.buttonInstrumentSelection.TabIndex = 7;
            this.buttonInstrumentSelection.UseVisualStyleBackColor = true;
            this.buttonInstrumentSelection.Click += new System.EventHandler(this.buttonInstrumentSelection_Click);
            // 
            // ChannelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonInstrumentSelection);
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.labelChannelInstrument);
            this.Controls.Add(this.labelChannelNumber);
            this.Controls.Add(this.buttonColor);
            this.Name = "ChannelControl";
            this.Size = new System.Drawing.Size(176, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelChannelNumber;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.CheckBox checkBoxShow;
        private System.Windows.Forms.Button buttonInstrumentSelection;
        public System.Windows.Forms.Label labelChannelInstrument;
    }
}
