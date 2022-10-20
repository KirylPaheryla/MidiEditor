using Melanchall.DryWetMidi.Core;
using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class TextEventControl : UserControl
    {
        public TextEventProperties TextEventProperties { get; set; }

        public TextEventControl(long time, MidiEventType type, string text, int track, BaseTextEvent baseTextEvent)
        {
            InitializeComponent();
            TextEventProperties = new TextEventProperties(time, type, text, track, baseTextEvent);
            propertyGridTextEvent.SelectedObject = TextEventProperties;
            AppSettings.EditorsControl.flowLayoutPanelTabPageTextEvents.Controls.Add(this);
            AppSettings.TextEventControls.Add(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AppSettings.TextEventControls.Remove(this);
            AppSettings.EditorsControl.flowLayoutPanelTabPageTextEvents.Controls.Remove(this);

            AppSettings.SaveStatus = false;
            AppSettings.IsFileCompiled = false;

            Dispose();
        }
    }
}
