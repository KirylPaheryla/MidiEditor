using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class ControlChangeEventControl : UserControl
    {
        public ControlChangeEventProperties ControlChangeEventProperties { get; set; }

        public ControlChangeEventControl(long time, SevenBitNumber controlNumber, SevenBitNumber controlValue, int channel, int track, ControlChangeEvent controlChangeEvent)
        {
            InitializeComponent();
            ControlChangeEventProperties = new ControlChangeEventProperties(time, controlNumber, controlValue, channel, track, controlChangeEvent);
            propertyGridControlChangeEvent.SelectedObject = ControlChangeEventProperties;
            AppSettings.EditorsControl.flowLayoutPanelTabPageControlChangeEvents.Controls.Add(this);
            AppSettings.ControlChangeEventControls.Add(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AppSettings.ControlChangeEventControls.Remove(this);
            AppSettings.EditorsControl.flowLayoutPanelTabPageControlChangeEvents.Controls.Remove(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;

            Dispose();
        }
    }
}
