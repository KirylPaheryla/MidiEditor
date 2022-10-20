using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class TimeSignatureEventControl : UserControl
    {
        public TimeSignatureEventProperties TimeSignatureEventProperties { get; set; }

        public TimeSignatureEventControl(long time, int numerator, int denominator, int track, TimeSignatureEvent timeSignatureEvent)
        {
            InitializeComponent();
            TimeSignatureEventProperties = new TimeSignatureEventProperties(time, numerator, denominator, track, timeSignatureEvent);
            propertyGridTimeSignatureEvent.SelectedObject = TimeSignatureEventProperties;
            AppSettings.EditorsControl.flowLayoutPanelTabPageTimeSignatureEvents.Controls.Add(this);
            AppSettings.TimeSignatureEventControls.Add(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AppSettings.TimeSignatureEventControls.Remove(this);
            AppSettings.EditorsControl.flowLayoutPanelTabPageTimeSignatureEvents.Controls.Remove(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;

            Dispose();
        }
    }
}
