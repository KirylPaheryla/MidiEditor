using System;
using System.Drawing;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class EditorsControl : UserControl
    {
        public EditorsControl()
        {
            InitializeComponent();
        }

        #region Toolstrip tab tracks
        private void toolStripButtonAddTrack_Click(object sender, EventArgs e)
        {
            new TrackControl(AppSettings.TrackControls.Count, "Untitled track");
        }

        private void toolStripButtonShowAllTracks_Click(object sender, EventArgs e)
        {
            AppSettings.TrackControls.ForEach(x => x.checkBoxShow.Checked = true);
        }

        private void toolStripButtonHideAllTracks_Click(object sender, EventArgs e)
        {
            AppSettings.TrackControls.ForEach(x => x.checkBoxShow.Checked = false);
        }
        #endregion

        #region Tool strip tab channels
        private void toolStripButtonShowAllChannels_Click(object sender, EventArgs e)
        {
            AppSettings.ChannelControls.ForEach(x => x.checkBoxShow.Checked = true);
        }

        private void toolStripButtonHideAllChannels_Click(object sender, EventArgs e)
        {
            AppSettings.ChannelControls.ForEach(x => x.checkBoxShow.Checked = false);
        }

        #endregion

        #region Tool strip tab Events
        private void toolStripButtonAddTempoChangeEvent_Click(object sender, EventArgs e)
        {
            new NewTempoChangeEventForm().ShowDialog();
        }

        private void toolStripButtonAddKeySignatureEvent_Click(object sender, EventArgs e)
        {
            new NewKeySignatureEventForm().ShowDialog();
        }

        private void toolStripButtonAddTimeSignatureEvent_Click(object sender, EventArgs e)
        {
            new NewTimeSignatureEventForm().ShowDialog();
        }

        private void toolStripButtonAddProgramChangeEvent_Click(object sender, EventArgs e)
        {
            new NewProgramChangeEventForm().ShowDialog();
        }

        private void toolStripButtonAddControlChangeEvent_Click(object sender, EventArgs e)
        {
            new NewControlChangeEventForm().ShowDialog();
        }

        private void toolStripButtonAddKeyPressureEvent_Click(object sender, EventArgs e)
        {
            new NewKeyPressureEventForm().ShowDialog();
        }

        private void toolStripButtonAddChannelPressureEvent_Click(object sender, EventArgs e)
        {
            new NewChannelPressureEventForm().ShowDialog();
        }

        private void toolStripButtonAddTextEvent_Click(object sender, EventArgs e)
        {
            new NewTextEventForm().ShowDialog();
        }

        private void toolStripButtonAddPitchBendEvent_Click(object sender, EventArgs e)
        {
            new NewPitchBendEventForm().ShowDialog();
        }

        private void toolStripButtonAddSysExEvent_Click(object sender, EventArgs e)
        {
            new NewSysExEventForm().ShowDialog();
        }
        #endregion

        private void propertyGridNoteOnOffEvent_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            NoteOnOffEventProperties noteOnOffEventProperties = (NoteOnOffEventProperties)s;
            Button button = noteOnOffEventProperties.Button;
            button.Width = (int)noteOnOffEventProperties.Length;
            button.Location = new Point((int)noteOnOffEventProperties.Time, (127 - noteOnOffEventProperties.Note) * AppSettings.YScale);
            button.BackColor = AppSettings.ChannelColors[noteOnOffEventProperties.Channel];
        }
    }
}
