using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class NewPitchBendEventForm : Form
    {
        public NewPitchBendEventForm()
        {
            InitializeComponent();

            foreach (var track in AppSettings.TrackControls)
                comboBoxTrack.Items.Add($@"{track.TrackNumber} ({track.TrackName})");
            comboBoxTrack.SelectedIndex = 0;
            comboBoxTrack.Text = (string)comboBoxTrack.SelectedItem;

            foreach (var channel in AppSettings.ChannelControls)
                comboBoxChannel.Items.Add($@"{channel.ChannelNumber}");
            comboBoxChannel.SelectedIndex = 0;
            comboBoxChannel.Text = "0";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            PitchBendEvent pitchBendEvent = new PitchBendEvent();
            pitchBendEvent.DeltaTime = (long)numericUpDownTime.Value;
            pitchBendEvent.PitchValue = (ushort)numericUpDownValue.Value;
            pitchBendEvent.Channel = (FourBitNumber)comboBoxChannel.SelectedIndex;

            AppSettings.PitchBendEventControls.Add(new PitchBendEventControl((long)numericUpDownTime.Value, (ushort)numericUpDownValue.Value, comboBoxChannel.SelectedIndex, comboBoxTrack.SelectedIndex, pitchBendEvent));

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
