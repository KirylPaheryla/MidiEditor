using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class NewTextEventForm : Form
    {
        public NewTextEventForm()
        {
            InitializeComponent();

            foreach (var track in AppSettings.TrackControls)
                comboBoxTrack.Items.Add($@"{track.TrackNumber} ({track.TrackName})");
            comboBoxTrack.SelectedIndex = 0;
            comboBoxTrack.Text = (string)comboBoxTrack.SelectedItem;

            comboBoxType.Items.Add("CopyrightNoticeEvent");
            comboBoxType.Items.Add("CuePointEvent");
            comboBoxType.Items.Add("DeviceNameEvent");
            comboBoxType.Items.Add("InstrumentNameEvent");
            comboBoxType.Items.Add("LyricEvent");
            comboBoxType.Items.Add("MarkerEvent");
            comboBoxType.Items.Add("ProgramNameEvent");
            comboBoxType.Items.Add("SequenceTrackNameEvent");
            comboBoxType.Items.Add("TextEvent");

            comboBoxType.SelectedText = "TextEvent";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            switch (comboBoxType.SelectedIndex)
            {
                case 0:
                    CopyrightNoticeEvent copyrightNoticeEvent = new CopyrightNoticeEvent();
                    copyrightNoticeEvent.DeltaTime = (long)numericUpDownTime.Value;
                    copyrightNoticeEvent.Text = richTextBoxText.Text;
                    AppSettings.TextEventControls.Add(new TextEventControl((long)numericUpDownTime.Value, MidiEventType.CopyrightNotice, richTextBoxText.Text, comboBoxTrack.SelectedIndex, copyrightNoticeEvent));
                    break;
                case 1:
                    CuePointEvent cuePointEvent = new CuePointEvent();
                    cuePointEvent.DeltaTime = (long)numericUpDownTime.Value;
                    cuePointEvent.Text = richTextBoxText.Text;
                    AppSettings.TextEventControls.Add(new TextEventControl((long)numericUpDownTime.Value, MidiEventType.CuePoint, richTextBoxText.Text, comboBoxTrack.SelectedIndex, cuePointEvent));
                    break;
                case 2:
                    DeviceNameEvent deviceNameEvent = new DeviceNameEvent();
                    deviceNameEvent.DeltaTime = (long)numericUpDownTime.Value;
                    deviceNameEvent.Text = richTextBoxText.Text;
                    AppSettings.TextEventControls.Add(new TextEventControl((long)numericUpDownTime.Value, MidiEventType.DeviceName, richTextBoxText.Text, comboBoxTrack.SelectedIndex, deviceNameEvent));
                    break;
                case 3:
                    InstrumentNameEvent instrumentNameEvent = new InstrumentNameEvent();
                    instrumentNameEvent.DeltaTime = (long)numericUpDownTime.Value;
                    instrumentNameEvent.Text = richTextBoxText.Text;
                    AppSettings.TextEventControls.Add(new TextEventControl((long)numericUpDownTime.Value, MidiEventType.InstrumentName, richTextBoxText.Text, comboBoxTrack.SelectedIndex, instrumentNameEvent));
                    break;
                case 4:
                    LyricEvent lyricEvent = new LyricEvent();
                    lyricEvent.DeltaTime = (long)numericUpDownTime.Value;
                    lyricEvent.Text = richTextBoxText.Text;
                    AppSettings.TextEventControls.Add(new TextEventControl((long)numericUpDownTime.Value, MidiEventType.Lyric, richTextBoxText.Text, comboBoxTrack.SelectedIndex, lyricEvent));
                    break;
                case 5:
                    MarkerEvent markerEvent = new MarkerEvent();
                    markerEvent.DeltaTime = (long)numericUpDownTime.Value;
                    markerEvent.Text = richTextBoxText.Text;
                    AppSettings.TextEventControls.Add(new TextEventControl((long)numericUpDownTime.Value, MidiEventType.Marker, richTextBoxText.Text, comboBoxTrack.SelectedIndex, markerEvent));
                    break;
                case 6:
                    ProgramNameEvent programNameEvent = new ProgramNameEvent();
                    programNameEvent.DeltaTime = (long)numericUpDownTime.Value;
                    programNameEvent.Text = richTextBoxText.Text;
                    AppSettings.TextEventControls.Add(new TextEventControl((long)numericUpDownTime.Value, MidiEventType.ProgramName, richTextBoxText.Text, comboBoxTrack.SelectedIndex, programNameEvent));
                    break;
                case 7:
                    SequenceTrackNameEvent sequenceTrackNameEvent = new SequenceTrackNameEvent();
                    sequenceTrackNameEvent.DeltaTime = (long)numericUpDownTime.Value;
                    sequenceTrackNameEvent.Text = richTextBoxText.Text;
                    AppSettings.TextEventControls.Add(new TextEventControl((long)numericUpDownTime.Value, MidiEventType.SequenceTrackName, richTextBoxText.Text, comboBoxTrack.SelectedIndex, sequenceTrackNameEvent));
                    break;
                case 8:
                    TextEvent textEvent = new TextEvent();
                    textEvent.DeltaTime = (long)numericUpDownTime.Value;
                    textEvent.Text = richTextBoxText.Text;
                    AppSettings.TextEventControls.Add(new TextEventControl((long)numericUpDownTime.Value, MidiEventType.Text, richTextBoxText.Text, comboBoxTrack.SelectedIndex, textEvent));
                    break;
            }


            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
