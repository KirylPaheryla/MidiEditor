﻿namespace MidiEditor
{
    partial class KeySignatureEventControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeySignatureEventControl));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.propertyGridKeySignatureEvent = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(0, 191);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(180, 29);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // propertyGridKeySignatureEvent
            // 
            this.propertyGridKeySignatureEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridKeySignatureEvent.Location = new System.Drawing.Point(0, 0);
            this.propertyGridKeySignatureEvent.Name = "propertyGridKeySignatureEvent";
            this.propertyGridKeySignatureEvent.Size = new System.Drawing.Size(180, 193);
            this.propertyGridKeySignatureEvent.TabIndex = 6;
            this.propertyGridKeySignatureEvent.ToolbarVisible = false;
            // 
            // KeySignatureEventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.propertyGridKeySignatureEvent);
            this.Name = "KeySignatureEventControl";
            this.Size = new System.Drawing.Size(180, 220);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.PropertyGrid propertyGridKeySignatureEvent;
    }
}
