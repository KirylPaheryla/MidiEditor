using System;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class TrackControl : UserControl
    {
        public string TrackName { get { return labelTrackName.Text; } set { labelTrackName.Text = value; } }
        public int TrackNumber { get; private set; }
        public bool IsTrackVisible { get; set; }

        public TrackControl(int trackNumber, string trackName)
        {
            InitializeComponent();

            TrackNumber = trackNumber;
            TrackName = trackName;
            IsTrackVisible = true;

            labelTrackNumber.Text = $@"Track {trackNumber}";
            labelTrackName.Text = trackName;

            AppSettings.TrackControls.Add(this);
            AppSettings.EditorsControl.flowLayoutPanelTracks.Controls.Add(this);
            AppSettings.MainForm.toolStripComboBoxTracks.Items.Add($@"Track {TrackNumber} ({TrackName})");
        }

        private void labelTrackName_Click(object sender, EventArgs e)
        {
            ChangeTrackNameForm changeTrackNameForm = new ChangeTrackNameForm(this);
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            IsTrackVisible = checkBoxShow.Checked;
            AppSettings.PianoRollNotes.ForEach(x => x.Button.Visible = checkBoxShow.Checked);
        }

        private void buttonTrash_Click(object sender, EventArgs e)
        {
            if (AppSettings.TrackControls.Count > 1)
            {
                AppTools.DeleteAllEventsByTrackNumber(TrackNumber);
                AppSettings.EditorsControl.flowLayoutPanelTracks.Controls.Remove(this);
                AppSettings.TrackControls.Remove(this);
                Dispose();
                AppTools.RefreshToolStripComboBoxTracks();
            }
            else
            {
                MessageBox.Show("The selected track can't be removed!\nIt's the last track of the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
