using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class PitchBendEventControl : UserControl
    {
        public PitchBendEventProperties PitchBendEventProperties { get; set; }

        public PitchBendEventControl(long time, ushort value, int channel, int track, PitchBendEvent pitchBendEvent)
        {
            InitializeComponent();
            PitchBendEventProperties = new PitchBendEventProperties(time, value, channel, track, pitchBendEvent);
            propertyGridPitchBendEvent.SelectedObject = PitchBendEventProperties;
            AppSettings.EditorsControl.flowLayoutPanelTabPagePitchBendEvents.Controls.Add(this);
            AppSettings.PitchBendEventControls.Add(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AppSettings.PitchBendEventControls.Remove(this);
            AppSettings.EditorsControl.flowLayoutPanelTabPagePitchBendEvents.Controls.Remove(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;

            Dispose();
        }
    }
}
