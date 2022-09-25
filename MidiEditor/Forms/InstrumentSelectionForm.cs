using MidiEditor.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class InstrumentSelectionForm : Form
    {
        ChannelControl channelControl;
        public InstrumentSelectionForm(ChannelControl channelControl)
        {
            InitializeComponent();
            this.channelControl = channelControl;

            labelChannelNumber.Text = $@"Choose instrument for {channelControl.ChannelNumber}";

            for (int i = 0; i < 128; i++)
            {
                comboBoxInstruments.Items.Add(AppSettings.GetInstrumentName(i));
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            channelControl.labelChannelInstrument.Text = AppSettings.GetInstrumentName(comboBoxInstruments.SelectedIndex);
            channelControl.ChannelInstrument = comboBoxInstruments.SelectedIndex;
            this.Close();
        }
    }
}
