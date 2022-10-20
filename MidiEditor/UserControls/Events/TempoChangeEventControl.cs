using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class TempoChangeEventControl : UserControl
    {
        public TempoChangeEventProperties TempoChangeEventProperties { get; set; }

        public TempoChangeEventControl(long time, long microsecondsPerQuarterNote, int track, SetTempoEvent setTempoEvent)
        {
            InitializeComponent();
            TempoChangeEventProperties = new TempoChangeEventProperties(time, microsecondsPerQuarterNote, track, setTempoEvent);
            propertyGridTempoChangeEvent.SelectedObject = TempoChangeEventProperties;
            AppSettings.EditorsControl.flowLayoutPanelTabPageTempoChangeEvents.Controls.Add(this);
            AppSettings.TempoChangeEventControls.Add(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AppSettings.TempoChangeEventControls.Remove(this);
            AppSettings.EditorsControl.flowLayoutPanelTabPageTempoChangeEvents.Controls.Remove(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;

            Dispose();
        }
    }
}
