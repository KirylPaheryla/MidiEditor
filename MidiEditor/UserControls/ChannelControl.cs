using System;
using System.Drawing;
using System.Windows.Forms;

namespace MidiEditor.UserControls
{
    public partial class ChannelControl : UserControl
    {
        public int ChannelNumber { get; set; }
        public Color ChannelColor { get; set; }
        public bool IsChannelVisible { get; set; } = true;

        public ChannelControl(int channelNumber, Color channelColor)
        {
            InitializeComponent();
            ChannelNumber = channelNumber;
            ChannelColor = channelColor;

            labelChannelNumber.Text = $@"Channel {channelNumber}";
            buttonColor.BackColor = ChannelColor;

            AppSettings.ChannelControls.Add(this);
            AppSettings.EditorsControl.flowLayoutPanelChannels.Controls.Add(this);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = ChannelColor;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                buttonColor.ForeColor = colorDlg.Color;
                ChannelColor = colorDlg.Color;
                AppSettings.ChannelColors[ChannelNumber] = colorDlg.Color;
            }
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            IsChannelVisible = checkBoxShow.Checked;
            AppSettings.PianoRollNotes.ForEach(x => x.Button.Visible = checkBoxShow.Checked);
        }
    }
}
