using Melanchall.DryWetMidi.Multimedia;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            AppSettings.OutputDevice = OutputDevice.GetByName("Microsoft GS Wavetable Synth");
            AppSettings.MainForm = this;
            AppSettings.PianoRollControl = pianoRollControl;
            AppSettings.TimelineControl = timelineControl;
            AppSettings.EditorsControl = editorsControl;

            pianoRollControl.AutoScrollMinSize = new Size(pianoRollControl.Width, 128 * AppSettings.YScale);
            pianoRollControl.GetPictureBoxBackgroundGrid.Paint += GetPictureBoxBackgroundGrid_Paint;
            pianoRollControl.MouseWheel += PianoRollControl_MouseWheel;

            AppTools.CreateNewMidiFile();
        }

        private void PianoRollControl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (pianoRollControl.VerticalScroll.Value % AppSettings.YScale != 0)
                pianoRollControl.VerticalScroll.Value = (int)(Math.Round((decimal)(pianoRollControl.VerticalScroll.Value / AppSettings.YScale)) * AppSettings.YScale);
        }

        private void GetPictureBoxBackgroundGrid_Paint(object sender, PaintEventArgs e)
        {
            pianoKeysControl.AutoScrollMinSize = pianoRollControl.AutoScrollMinSize;
            pianoKeysControl.VerticalScroll.Value = pianoRollControl.VerticalScroll.Value;
        }

        private void pianoRollControl_Paint(object sender, PaintEventArgs e)
        {
            pianoKeysControl.AutoScrollMinSize = pianoRollControl.AutoScrollMinSize;
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
            timelineControl.AutoScrollMinSize = pianoRollControl.AutoScrollMinSize;
            timelineControl.HorizontalScroll.Value = pianoRollControl.HorizontalScroll.Value;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) => MidiFileReader.ReadMidiFile();

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

        private void toolStripButtonZoomHorIn_Click(object sender, EventArgs e) => PianoRollScaling.ZoomIn_X();

        private void toolStripButtonZoomHorOut_Click(object sender, EventArgs e) => PianoRollScaling.ZoomOut_X();

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x0112) // WM_SYSCOMMAND
            {
                // Check your window state here
                if (m.WParam == new IntPtr(0xF030)) // Maximize event - SC_MAXIMIZE from Winuser.h
                {
                    // THe window is being maximized
                    timelineControl.GetPictureBoxTimeline().Width = pianoRollControl.Width;
                }
            }
        }

        private void pianoRollControl_ClientSizeChanged(object sender, EventArgs e)
        {
            if (pianoRollControl.Height == pianoRollControl.ClientSize.Height + SystemInformation.HorizontalScrollBarHeight)
            {
                pianoKeysControl.Height = pianoRollControl.ClientSize.Height;
            }

            if (pianoRollControl.Height == pianoRollControl.ClientSize.Height)
            {
                pianoKeysControl.Height = pianoRollControl.Height;
            }
        }

        private void toolStripButtonZoomVerOut_Click(object sender, EventArgs e) => PianoRollScaling.ZoomOut_Y();

        private void toolStripButtonZoomVerIn_Click(object sender, EventArgs e) => PianoRollScaling.ZoomIn_Y();

        private void toolStripButtonPlay_Click(object sender, EventArgs e) => AppTools.OpenPlaybackForm();

        private void toolStripButtonSelectEvent_Click(object sender, EventArgs e)
        {
            AppSettings.CurrentCursorStatus = AppSettings.CursorStatus.Default;
            AppSettings.PianoRollControl.Cursor = Cursors.Default;
        }

        private void toolStripButtonCreateNewEvent_Click(object sender, EventArgs e)
        {
            AppSettings.CurrentCursorStatus = AppSettings.CursorStatus.Create;
            AppSettings.PianoRollControl.Cursor = new Cursor(Properties.Resources.Pencil.Handle);
        }

        private void toolStripButtonDeleteEvent_Click(object sender, EventArgs e)
        {
            AppSettings.CurrentCursorStatus = AppSettings.CursorStatus.Erase;
            AppSettings.PianoRollControl.Cursor = new Cursor(Properties.Resources.Eraser.Handle);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) => AppTools.CreateNewMidiFile();

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => MidiFileWriter.SaveMidiFile();

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) => MidiFileWriter.SaveAsMidiFile();

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void playbackToolStripMenuItem1_Click(object sender, EventArgs e) => AppTools.OpenPlaybackForm();

        private void selectEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettings.CurrentCursorStatus = AppSettings.CursorStatus.Default;
            AppSettings.PianoRollControl.Cursor = Cursors.Default;
        }

        private void createNewEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettings.CurrentCursorStatus = AppSettings.CursorStatus.Create;
            AppSettings.PianoRollControl.Cursor = new Cursor(Properties.Resources.Pencil.Handle);
        }

        private void deleteEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettings.CurrentCursorStatus = AppSettings.CursorStatus.Erase;
            AppSettings.PianoRollControl.Cursor = new Cursor(Properties.Resources.Eraser.Handle);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TrackControl(AppSettings.TrackControls.Count, "Untitled track");
        }

        private void horizToolStripMenuItem_Click(object sender, EventArgs e) => PianoRollScaling.ZoomOut_X();

        private void horizontalInToolStripMenuItem_Click(object sender, EventArgs e) => PianoRollScaling.ZoomIn_X();

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e) => PianoRollScaling.ZoomOut_Y();

        private void verticalInToolStripMenuItem_Click(object sender, EventArgs e) => PianoRollScaling.ZoomIn_Y();

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e) => AppSettings.TrackControls.ForEach(x => x.checkBoxShow.Checked = true);

        private void hideAllTracksToolStripMenuItem_Click(object sender, EventArgs e) => AppSettings.TrackControls.ForEach(x => x.checkBoxShow.Checked = false);

        private void showAllChannelsToolStripMenuItem_Click(object sender, EventArgs e) => AppSettings.ChannelControls.ForEach(x => x.checkBoxShow.Checked = true);

        private void hideAllChannelsToolStripMenuItem_Click(object sender, EventArgs e) => AppSettings.ChannelControls.ForEach(x => x.checkBoxShow.Checked = false);
    }
}
