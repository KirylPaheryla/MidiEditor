using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidiEditor
{
    public partial class TrackControl : UserControl
    {
        public string TrackName { get; set; }
        public string TrackNumber { get; set; }
        public bool IsTrackVisible { get; set; }

        public TrackControl(string trackNumber, string trackName)
        {
            InitializeComponent();
            TrackNumber = trackNumber;
            TrackName = trackName;
            IsTrackVisible = true;
        }

        private void labelTrackName_Click(object sender, EventArgs e)
        {
            ChangeTrackNameForm changeTrackNameForm = new ChangeTrackNameForm(this);
            changeTrackNameForm.MdiParent = AppSettings.ParentForm;
            changeTrackNameForm.Show();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            IsTrackVisible = checkBoxShow.Checked;
        }
    }
}
