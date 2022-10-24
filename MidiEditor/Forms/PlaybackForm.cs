using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using Melanchall.DryWetMidi.Multimedia;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class PlaybackForm : Form
    {
        private Playback _playback;
        public PlaybackForm()
        {
            InitializeComponent();
            MidiFileWriter.CompileMidiFile();
            _playback = AppSettings.MidiFile.GetPlayback();
            _playback.TrackNotes = true;
            _playback.TrackControlValue = true;
            _playback.TrackPitchValue = true;
            _playback.TrackProgram = true;
            _playback.OutputDevice = AppSettings.OutputDevice;
            labelTime.Text = "0:0:0 - " + _playback.GetDuration(TimeSpanType.Metric);
            _playback.EventPlayed += _playback_EventPlayed;

            trackBarTimeLine.Maximum = (int)_playback.GetDuration<MetricTimeSpan>().TotalMicroseconds;

            foreach (var outputDevice in OutputDevice.GetAll())
            {
                comboBoxOutputDevice.Items.Add(outputDevice.Name);
            }
            comboBoxOutputDevice.SelectedIndex = 0;
            comboBoxOutputDevice.Text = "Microsoft GS Wavetable Synth";
        }

        private void _playback_EventPlayed(object sender, MidiEventPlayedEventArgs e)
        {
            switch (e.Event.EventType)
            {
                case MidiEventType.NoteOn:
                    if (checkedListBoxTracking.GetItemChecked(0))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.NoteOff:
                    if (checkedListBoxTracking.GetItemChecked(1))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.ChannelAftertouch:
                    if (checkedListBoxTracking.GetItemChecked(2))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.ControlChange:
                    if (checkedListBoxTracking.GetItemChecked(3))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.NoteAftertouch:
                    if (checkedListBoxTracking.GetItemChecked(4))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.KeySignature:
                    if (checkedListBoxTracking.GetItemChecked(5))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.PitchBend:
                    if (checkedListBoxTracking.GetItemChecked(6))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.ProgramChange:
                    if (checkedListBoxTracking.GetItemChecked(7))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.EscapeSysEx:
                    if (checkedListBoxTracking.GetItemChecked(8))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.NormalSysEx:
                    if (checkedListBoxTracking.GetItemChecked(9))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.SetTempo:
                    if (checkedListBoxTracking.GetItemChecked(10))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.TimeSignature:
                    if (checkedListBoxTracking.GetItemChecked(11))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.CopyrightNotice:
                    if (checkedListBoxTracking.GetItemChecked(12))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.CuePoint:
                    if (checkedListBoxTracking.GetItemChecked(13))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.DeviceName:
                    if (checkedListBoxTracking.GetItemChecked(14))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.InstrumentName:
                    if (checkedListBoxTracking.GetItemChecked(15))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.Lyric:
                    if (checkedListBoxTracking.GetItemChecked(16))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.Marker:
                    if (checkedListBoxTracking.GetItemChecked(17))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.ProgramName:
                    if (checkedListBoxTracking.GetItemChecked(18))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.SequenceTrackName:
                    if (checkedListBoxTracking.GetItemChecked(19))
                        SetText("Event " + e.Event + "\n");
                    break;
                case MidiEventType.Text:
                    if (checkedListBoxTracking.GetItemChecked(20))
                        SetText("Event " + e.Event + "\n");
                    break;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (_playback.IsRunning)
                return;

            _playback.Start();
            timer1.Start();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            _playback.Stop();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = _playback.GetCurrentTime(TimeSpanType.Metric) + " - " + _playback.GetDuration(TimeSpanType.Metric);
            trackBarTimeLine.Value = (int)_playback.GetCurrentTime<MetricTimeSpan>().TotalMicroseconds;
        }

        private void PlaybackForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _playback.Dispose();
        }

        private void buttonMoveToStart_Click(object sender, EventArgs e)
        {
            _playback.MoveToStart();
        }

        private void buttonLoop_Click(object sender, EventArgs e)
        {
            _playback.Loop = !_playback.Loop;
            buttonLoop.BackColor = buttonLoop.BackColor == Color.White ? Color.LightGray : Color.White;
        }

        private void buttonMoveBack5sec_Click(object sender, EventArgs e)
        {
            _playback.MoveBack(new MetricTimeSpan(0, 0, 5));
        }

        private void buttonMoveForward5sec_Click(object sender, EventArgs e)
        {
            _playback.MoveForward(new MetricTimeSpan(0, 0, 5));
        }

        private void buttonSpeedHalf_Click(object sender, EventArgs e)
        {
            _playback.Speed = 0.5;
        }

        private void buttonSpeedNormal_Click(object sender, EventArgs e)
        {
            _playback.Speed = 1;
        }

        private void buttonSpeed2x_Click(object sender, EventArgs e)
        {
            _playback.Speed = 2;
        }

        private void trackBarTimeLine_Scroll(object sender, EventArgs e)
        {
            _playback.MoveToTime(new MetricTimeSpan((long)(trackBarTimeLine.Value)));
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (richTextBoxLogs.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                richTextBoxLogs.Text += text;
                richTextBoxLogs.SelectionStart = richTextBoxLogs.Text.Length;
                richTextBoxLogs.ScrollToCaret();
            }
        }

        private void comboBoxOutputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            _playback.OutputDevice = OutputDevice.GetByIndex(comboBoxOutputDevice.SelectedIndex);
        }
    }
}
