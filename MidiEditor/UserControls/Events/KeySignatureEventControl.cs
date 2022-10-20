using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class KeySignatureEventControl : UserControl
    {
        public KeySignatureEventProperties KeySignatureEventProperties { get; set; }

        public KeySignatureEventControl(long time, sbyte key, byte scale, int track, KeySignatureEvent keySignatureEvent)
        {
            InitializeComponent();
            KeySignatureEventProperties = new KeySignatureEventProperties(time, key, scale, track, keySignatureEvent);
            propertyGridKeySignatureEvent.SelectedObject = KeySignatureEventProperties;
            AppSettings.EditorsControl.flowLayoutPanelTabPageKeySignatureEvents.Controls.Add(this);
            AppSettings.KeySignatureEventControls.Add(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AppSettings.KeySignatureEventControls.Remove(this);
            AppSettings.EditorsControl.flowLayoutPanelTabPageKeySignatureEvents.Controls.Remove(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;

            Dispose();
        }
    }
}
