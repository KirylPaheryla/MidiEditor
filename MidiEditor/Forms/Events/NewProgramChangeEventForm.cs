using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class NewProgramChangeEventForm : Form
    {
        public NewProgramChangeEventForm()
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

            for (int i = 0; i <= 127; i++)
                comboBoxProgramNumber.Items.Add(AppTools.GetInstrumentName(i));
            comboBoxProgramNumber.SelectedIndex = 0;
            comboBoxProgramNumber.Text = "0";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ProgramChangeEvent programChangeEvent = new ProgramChangeEvent();
            programChangeEvent.DeltaTime = (long)numericUpDownTime.Value;
            programChangeEvent.ProgramNumber = (SevenBitNumber)comboBoxProgramNumber.SelectedIndex;
            programChangeEvent.Channel = (FourBitNumber)comboBoxChannel.SelectedIndex;

            AppSettings.ProgramChangeEventControls.Add(new ProgramChangeEventControl((long)numericUpDownTime.Value, (SevenBitNumber)comboBoxProgramNumber.SelectedIndex, comboBoxChannel.SelectedIndex, comboBoxTrack.SelectedIndex, programChangeEvent));

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
