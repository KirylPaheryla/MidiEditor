using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class ProgramChangeEventControl : UserControl
    {
        public ProgramChangeEventProperties ProgramChangeEventProperties { get; set; }

        public ProgramChangeEventControl(long time, SevenBitNumber programNumber, int channel, int track, ProgramChangeEvent programChangeEvent)
        {
            InitializeComponent();
            ProgramChangeEventProperties = new ProgramChangeEventProperties(time, programNumber, channel, track, programChangeEvent);
            propertyGridProgramChangeEvent.SelectedObject = ProgramChangeEventProperties;
            AppSettings.EditorsControl.flowLayoutPanelTabPageProgramChangeEvens.Controls.Add(this);
            AppSettings.ProgramChangeEventControls.Add(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AppSettings.ProgramChangeEventControls.Remove(this);
            AppSettings.EditorsControl.flowLayoutPanelTabPageProgramChangeEvens.Controls.Remove(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;

            Dispose();
        }
    }
}
