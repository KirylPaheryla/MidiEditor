using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class KeyPressureEventControl : UserControl
    {
        public KeyPressureEventProperties KeyPressureEventProperties { get; set; }

        public KeyPressureEventControl(long time, int note, int value, int channel, int track, NoteAftertouchEvent noteAftertouchEvent)
        {
            InitializeComponent();
            KeyPressureEventProperties = new KeyPressureEventProperties(time, note, value, channel, track, noteAftertouchEvent);
            propertyGridKeyPressureEvent.SelectedObject = KeyPressureEventProperties;
            AppSettings.EditorsControl.flowLayoutPanelTabPageKeyPressureEvents.Controls.Add(this);
            AppSettings.KeyPressureEventControls.Add(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AppSettings.KeyPressureEventControls.Remove(this);
            AppSettings.EditorsControl.flowLayoutPanelTabPageKeyPressureEvents.Controls.Remove(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;

            Dispose();
        }
    }
}
