using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class NewChannelPressureEventForm : Form
    {
        public NewChannelPressureEventForm()
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
            ChannelAftertouchEvent channelAftertouchEvent = new ChannelAftertouchEvent();
            channelAftertouchEvent.DeltaTime = (long)numericUpDownTime.Value;
            channelAftertouchEvent.AftertouchValue = (SevenBitNumber)numericUpDownValue.Value;
            channelAftertouchEvent.Channel = (FourBitNumber)comboBoxChannel.SelectedIndex;

            AppSettings.ChannelPressureEventControls.Add(new ChannelPressureEventControl((long)numericUpDownTime.Value, (int)numericUpDownValue.Value, comboBoxChannel.SelectedIndex, comboBoxTrack.SelectedIndex, channelAftertouchEvent));

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
