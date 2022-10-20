using Melanchall.DryWetMidi.Interaction;
using Melanchall.DryWetMidi.Multimedia;
using System;
using System.Drawing;
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
            _playback.NotesPlaybackStarted += _playback_NotesPlaybackStarted;
            _playback.NotesPlaybackFinished += _playback_NotesPlaybackFinished;

            trackBarTimeLine.Maximum = (int)_playback.GetDuration<MetricTimeSpan>().TotalMicroseconds;

            foreach (var outputDevice in OutputDevice.GetAll())
            {
                comboBoxOutputDevice.Items.Add(outputDevice.Name);
            }
            comboBoxOutputDevice.SelectedIndex = 0;
            comboBoxOutputDevice.Text = "Microsoft GS Wavetable Synth";
        }

        private void _playback_NotesPlaybackFinished(object sender, NotesEventArgs e)
        {
            foreach (var note in e.Notes)
            {
                SetText("NoteOff " + note + "\n");
            }
        }

        private void _playback_NotesPlaybackStarted(object sender, NotesEventArgs e)
        {
            foreach (var note in e.Notes)
            {
                SetText("NoteOn " + note + "\n");
            }
        }

        private void _playback_EventPlayed(object sender, MidiEventPlayedEventArgs e)
        {
            SetText("Event " + e.Event + "\n");
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

        private void checkBoxNotes_CheckedChanged(object sender, EventArgs e)
        {
            _playback.TrackNotes = checkBoxNotes.Checked;
        }

        private void checkBoxControlValue_CheckedChanged(object sender, EventArgs e)
        {
            _playback.TrackControlValue = checkBoxNotes.Checked;
        }

        private void checkBoxPitchValue_CheckedChanged(object sender, EventArgs e)
        {
            _playback.TrackPitchValue = checkBoxNotes.Checked;
        }

        private void checkBoxProgram_CheckedChanged(object sender, EventArgs e)
        {
            _playback.TrackProgram = checkBoxNotes.Checked;
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
