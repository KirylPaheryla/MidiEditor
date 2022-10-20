using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class NewSysExEventForm : Form
    {
        public NewSysExEventForm()
        {
            InitializeComponent();

            foreach (var track in AppSettings.TrackControls)
                comboBoxTrack.Items.Add($@"{track.TrackNumber} ({track.TrackName})");
            comboBoxTrack.SelectedIndex = 0;
            comboBoxTrack.Text = (string)comboBoxTrack.SelectedItem;

            comboBoxType.Items.Add("NormalSysExEvent");
            comboBoxType.Items.Add("EscapeSysExEvent");
            comboBoxType.SelectedText = "NormalSysExEvent";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string[] s = richTextBoxData.Text.Split(',');
            byte[] data = new byte[s.Length];
            for (int i = 0; i < data.Length; i++)
                data[i] = byte.Parse(s[i].Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);

            SysExEvent sysExEvent;
            switch (comboBoxType.SelectedIndex)
            {
                case 0:
                    sysExEvent = new NormalSysExEvent();
                    sysExEvent.DeltaTime = (long)numericUpDownTime.Value;
                    sysExEvent.Data = data;
                    AppSettings.SysExEventControls.Add(new SysExEventControl((long)numericUpDownTime.Value, MidiEventType.EscapeSysEx, data, comboBoxTrack.SelectedIndex, sysExEvent));
                    break;
                case 1:
                    sysExEvent = new EscapeSysExEvent();
                    sysExEvent.DeltaTime = (long)numericUpDownTime.Value;
                    sysExEvent.Data = data;
                    AppSettings.SysExEventControls.Add(new SysExEventControl((long)numericUpDownTime.Value, MidiEventType.EscapeSysEx, data, comboBoxTrack.SelectedIndex, sysExEvent));
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
