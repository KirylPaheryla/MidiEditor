using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class ChannelPressureEventControl : UserControl
    {
        public ChannelPressureEventProperties ChannelPressureEventProperties { get; set; }

        public ChannelPressureEventControl(long time, int value, int channel, int track, ChannelAftertouchEvent channelAftertouchEvent)
        {
            InitializeComponent();
            ChannelPressureEventProperties = new ChannelPressureEventProperties(time, value, channel, track, channelAftertouchEvent);
            propertyGridChannelPressureEvent.SelectedObject = ChannelPressureEventProperties;
            AppSettings.EditorsControl.flowLayoutPanelTabPageChannelPressureEvents.Controls.Add(this);
            AppSettings.ChannelPressureEventControls.Add(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AppSettings.ChannelPressureEventControls.Remove(this);
            AppSettings.EditorsControl.flowLayoutPanelTabPageChannelPressureEvents.Controls.Remove(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;

            Dispose();
        }
    }
}
