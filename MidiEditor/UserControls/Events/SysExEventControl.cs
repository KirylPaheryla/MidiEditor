using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class SysExEventControl : UserControl
    {
        public SysExEventProperties SysExEventProperties { get; set; }

        public SysExEventControl(long time, MidiEventType type, byte[] data, int track, SysExEvent sysExEvent)
        {
            InitializeComponent();
            SysExEventProperties = new SysExEventProperties(time, type, data, track, sysExEvent);
            propertyGridSysExEvent.SelectedObject = SysExEventProperties;
            AppSettings.EditorsControl.flowLayoutPanelTabPageSysExEvents.Controls.Add(this);
            AppSettings.SysExEventControls.Add(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AppSettings.SysExEventControls.Remove(this);
            AppSettings.EditorsControl.flowLayoutPanelTabPageSysExEvents.Controls.Remove(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;

            Dispose();
        }
    }
}
