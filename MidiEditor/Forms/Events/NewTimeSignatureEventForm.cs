using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class NewTimeSignatureEventForm : Form
    {
        public NewTimeSignatureEventForm()
        {
            InitializeComponent();

            foreach (var track in AppSettings.TrackControls)
                comboBoxTrack.Items.Add($@"{track.TrackNumber} ({track.TrackName})");
            comboBoxTrack.SelectedIndex = 0;
            comboBoxTrack.Text = (string)comboBoxTrack.SelectedItem;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            TimeSignatureEvent timeSignatureEvent = new TimeSignatureEvent();
            timeSignatureEvent.DeltaTime = (long)numericUpDownTime.Value;
            timeSignatureEvent.Numerator = (byte)numericUpNumerator.Value;
            timeSignatureEvent.Denominator = (byte)numericUpDenominator.Value;

            AppSettings.TimeSignatureEventControls.Add(new TimeSignatureEventControl((long)numericUpDownTime.Value, (int)numericUpNumerator.Value, (int)numericUpDenominator.Value, comboBoxTrack.SelectedIndex, timeSignatureEvent));

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
