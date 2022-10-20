using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class NewKeyPressureEventForm : Form
    {
        public NewKeyPressureEventForm()
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
            NoteAftertouchEvent noteAftertouchEvent = new NoteAftertouchEvent();
            noteAftertouchEvent.DeltaTime = (long)numericUpDownTime.Value;
            noteAftertouchEvent.NoteNumber = (SevenBitNumber)numericUpDownNote.Value;
            noteAftertouchEvent.AftertouchValue = (SevenBitNumber)numericUpDownValue.Value;
            noteAftertouchEvent.Channel = (FourBitNumber)comboBoxChannel.SelectedIndex;

            AppSettings.KeyPressureEventControls.Add(new KeyPressureEventControl((long)numericUpDownTime.Value, (int)numericUpDownNote.Value, (int)numericUpDownValue.Value, comboBoxChannel.SelectedIndex, comboBoxTrack.SelectedIndex, noteAftertouchEvent));

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
