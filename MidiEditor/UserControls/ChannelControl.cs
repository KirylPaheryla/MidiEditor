using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiEditor.UserControls
{
    public partial class ChannelControl : UserControl
    {
        public string ChannelNumber { get; set; }
        public int ChannelInstrument { get; set; }
        public Color ChannelColor { get; set; }
        public bool IsChannelVisible { get; set; }

        public ChannelControl(string channelNumber, int channelInstrument, Color channelColor)
        {
            InitializeComponent();
            ChannelNumber = channelNumber;
            ChannelInstrument = channelInstrument;
            ChannelColor = channelColor;
        }

        private void buttonInstrumentSelection_Click(object sender, EventArgs e)
        {
            InstrumentSelectionForm instrumentSelectionForm = new InstrumentSelectionForm(this);
            instrumentSelectionForm.MdiParent = AppSettings.ParentForm;
            instrumentSelectionForm.Show();
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
            }
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            IsChannelVisible = checkBoxShow.Checked;
        }
    }
}
