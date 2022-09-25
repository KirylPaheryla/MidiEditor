using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Multimedia;
using Melanchall.DryWetMidi.MusicTheory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace MidiEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            AppSettings.OutputDevice = OutputDevice.GetByName("Microsoft GS Wavetable Synth");
            AppSettings.ParentForm = this;
            AppSettings.PianoRollControl = pianoRollControl;
            AppSettings.TimelineControl = timelineControl;

            pianoRollControl.AutoScrollMinSize = new Size(pianoRollControl.Width, 127 * AppSettings.YScale);
            pianoRollControl.GetPictureBoxBackgroundGrid.Paint += GetPictureBoxBackgroundGrid_Paint;
            pianoRollControl.MouseWheel += PianoRollControl_MouseWheel;
        }

        private void PianoRollControl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (pianoRollControl.VerticalScroll.Value % AppSettings.YScale != 0)
                pianoRollControl.VerticalScroll.Value = (int)(Math.Round((decimal)(pianoRollControl.VerticalScroll.Value / AppSettings.YScale)) * AppSettings.YScale);
        }

        private void GetPictureBoxBackgroundGrid_Paint(object sender, PaintEventArgs e)
        {
            pianoKeysControl.VerticalScroll.Value = pianoRollControl.VerticalScroll.Value;
        }

        private void pianoRollControl_Paint(object sender, PaintEventArgs e)
        {
            pianoKeysControl.VerticalScroll.Value = pianoRollControl.VerticalScroll.Value;
        }

        private void pianoRollControl_Scroll(object sender, ScrollEventArgs e)
        {
            if (pianoRollControl.VerticalScroll.Value % AppSettings.YScale != 0)
                pianoRollControl.VerticalScroll.Value = (int)(Math.Round((decimal)(pianoRollControl.VerticalScroll.Value / AppSettings.YScale)) * AppSettings.YScale);

            pianoKeysControl.VerticalScroll.Value = pianoRollControl.VerticalScroll.Value;

            timelineControl.GetPictureBoxTimeline().Width = pianoRollControl.PreferredSize.Width;
            timelineControl.HorizontalScroll.Minimum = pianoRollControl.HorizontalScroll.Minimum;
            timelineControl.HorizontalScroll.Maximum = pianoRollControl.HorizontalScroll.Maximum;
            timelineControl.HorizontalScroll.Value = pianoRollControl.HorizontalScroll.Value;
        }

        private void pianoKeysControl_Scroll(object sender, ScrollEventArgs e)
        {
            pianoRollControl.VerticalScroll.Value = pianoKeysControl.VerticalScroll.Value;
        }

        private void pianoKeysControl_Paint(object sender, PaintEventArgs e)
        {
            pianoRollControl.VerticalScroll.Value = pianoKeysControl.VerticalScroll.Value;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MIDI Files (*.mid)|*.mid|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pianoRollControl.DrawNotes(MidiFile.Read(openFileDialog.FileName));
            }
        }

        private void timelineControl_Load(object sender, EventArgs e)
        {
            timelineControl.GetPictureBoxTimeline().Width = pianoRollControl.Width;
        }

        private Size m_CurrentPreferedSize;
        private void pianoRollControl_Layout(object sender, LayoutEventArgs e)
        {
            Size newSize = pianoRollControl.PreferredSize;
            if (m_CurrentPreferedSize != newSize)
            {
                m_CurrentPreferedSize = newSize;

                timelineControl.GetPictureBoxTimeline().Width = pianoRollControl.PreferredSize.Width;
            }
        }

        private void timelineControl_Resize(object sender, EventArgs e)
        {
            if (pianoRollControl.PreferredSize.Width == 0)
                timelineControl.GetPictureBoxTimeline().Width = pianoRollControl.Width;
            else
                timelineControl.GetPictureBoxTimeline().Width = pianoRollControl.PreferredSize.Width;
        }

        private void toolStripButtonZoomHorIn_Click(object sender, EventArgs e)
        {
            Scaling.ZoomIn_X();
        }

        private void toolStripButtonZoomHorOut_Click(object sender, EventArgs e)
        {
            Scaling.ZoomOut_X();
        }
    }
}
