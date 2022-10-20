using Melanchall.DryWetMidi.Core;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class ChangeTrackNameForm : Form
    {
        private TrackControl trackControl;
        public ChangeTrackNameForm(TrackControl trackControl)
        {
            InitializeComponent();
            this.trackControl = trackControl;
            label.Text = $@"Track name (Track {trackControl.TrackNumber})";
            textBoxNewTrackName.Text = trackControl.TrackName;
            this.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            trackControl.TrackName = textBoxNewTrackName.Text;

            TextEventControl textEventControl = AppSettings.TextEventControls.Where(x => x.TextEventProperties.Track == trackControl.TrackNumber).FirstOrDefault();
            if (textEventControl != null)
            {
                textEventControl.TextEventProperties.Text = textBoxNewTrackName.Text;
            }
            else
            {
                var textEvent = new SequenceTrackNameEvent();
                textEvent.DeltaTime = 0;
                textEvent.Text = textBoxNewTrackName.Text;

                new TextEventControl(0, MidiEventType.SequenceTrackName, textBoxNewTrackName.Text, trackControl.TrackNumber, textEvent);
            }

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;

            this.Close();
        }
    }
}
