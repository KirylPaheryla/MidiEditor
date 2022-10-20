using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class NewTempoChangeEventForm : Form
    {
        public NewTempoChangeEventForm()
        {
            InitializeComponent();

            foreach (var track in AppSettings.TrackControls)
                comboBoxTrack.Items.Add($@"{track.TrackNumber} ({track.TrackName})");
            comboBoxTrack.SelectedIndex = 0;
            comboBoxTrack.Text = (string)comboBoxTrack.SelectedItem;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SetTempoEvent setTempoEvent = new SetTempoEvent();
            setTempoEvent.DeltaTime = (long)numericUpDownTime.Value;
            setTempoEvent.MicrosecondsPerQuarterNote = (long)numericUpDownMicrosecondsPerQuarterNote.Value;

            AppSettings.TempoChangeEventControls.Add(new TempoChangeEventControl((long)numericUpDownTime.Value, (long)numericUpDownMicrosecondsPerQuarterNote.Value, comboBoxTrack.SelectedIndex, setTempoEvent));

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
