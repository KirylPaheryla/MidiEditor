using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class NewControlChangeEventForm : Form
    {
        public NewControlChangeEventForm()
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
            ControlChangeEvent controlChangeEvent = new ControlChangeEvent();
            controlChangeEvent.DeltaTime = (long)numericUpDownTime.Value;
            controlChangeEvent.ControlNumber = (SevenBitNumber)numericUpDownNumber.Value;
            controlChangeEvent.ControlValue = (SevenBitNumber)numericUpDownValue.Value;
            controlChangeEvent.Channel = (FourBitNumber)comboBoxChannel.SelectedIndex;

            AppSettings.ControlChangeEventControls.Add(new ControlChangeEventControl((long)numericUpDownTime.Value, (SevenBitNumber)numericUpDownNumber.Value, (SevenBitNumber)numericUpDownValue.Value, comboBoxChannel.SelectedIndex, comboBoxTrack.SelectedIndex, controlChangeEvent));

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
