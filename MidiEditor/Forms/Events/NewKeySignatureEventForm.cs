using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class NewKeySignatureEventForm : Form
    {
        public NewKeySignatureEventForm()
        {
            InitializeComponent();

            foreach (var track in AppSettings.TrackControls)
                comboBoxTrack.Items.Add($@"{track.TrackNumber} ({track.TrackName})");
            comboBoxTrack.SelectedIndex = 0;
            comboBoxTrack.Text = (string)comboBoxTrack.SelectedItem;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            KeySignatureEvent keySignatureEvent = new KeySignatureEvent();
            keySignatureEvent.DeltaTime = (long)numericUpDownTime.Value;
            keySignatureEvent.Key = (sbyte)numericUpDownKey.Value;
            keySignatureEvent.Scale = (byte)numericUpDownScale.Value;

            AppSettings.KeySignatureEventControls.Add(new KeySignatureEventControl((long)numericUpDownTime.Value, (sbyte)numericUpDownKey.Value, (byte)numericUpDownScale.Value, comboBoxTrack.SelectedIndex, keySignatureEvent));

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
