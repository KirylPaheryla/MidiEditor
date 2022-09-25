using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class ChangeTrackNameForm : Form
    {
        private TrackControl trackControl;
        public ChangeTrackNameForm(TrackControl trackControl) // public ChangeTrackNameForm(track, oldname)
        {
            InitializeComponent();
            this.trackControl = trackControl;
            label.Text = $@"Track name ({trackControl.TrackNumber})";
            textBoxNewTrackName.Text = trackControl.TrackName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // change track name
            trackControl.TrackName = textBoxNewTrackName.Text;
            this.Close();
        }
    }
}
