using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Note = Melanchall.DryWetMidi.Interaction.Note;

namespace MidiEditor
{
    public partial class PianoRollControl : UserControl
    {
        public PictureBox GetPictureBoxBackgroundGrid { get; private set; }

        public PianoRollControl()
        {
            InitializeComponent();
            GetPictureBoxBackgroundGrid = pictureBoxBackgroundGrid;
        }

        private void pictureBoxBackgroundGrid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int numOfCells = (pictureBoxBackgroundGrid.Size.Width * pictureBoxBackgroundGrid.Size.Height) / (AppSettings.XScale * AppSettings.YScale);
            int xScale = AppSettings.XScale;
            int yScale = AppSettings.YScale;
            Pen p = new Pen(Color.Black);

            for (int y = 0; y < numOfCells; ++y)
            {
                g.DrawLine(p, 0, y * yScale, numOfCells * yScale, y * yScale);
            }

            for (int x = 0; x < numOfCells; ++x)
            {
                g.DrawLine(p, x * xScale, 0, x * xScale, numOfCells * xScale);
            }
        }

        private void PianoRollButton_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            SoundMaker.PlaySound(127 - (button.Location.Y / AppSettings.YScale), 100);
        }

        private void PianoRollButton_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            SoundMaker.StopSound(127 - (button.Location.Y / AppSettings.YScale));
        }

        private Button MakeNewButton(int noteNumber, long startTime, long duration, int channel)
        {
            Button button = new Button();

            if (AppSettings.XScale != 100)
            {
                button.Width = (int)(duration * AppSettings.XScale / 100);
                button.Height = AppSettings.YScale;
                button.Location = new Point((int)(startTime * AppSettings.XScale / 100), (127 - noteNumber) * AppSettings.YScale);
            }
            else
            {
                button.Width = (int)duration;
                button.Height = AppSettings.YScale;
                button.Location = new Point((int)(startTime), (127 - noteNumber) * AppSettings.YScale);
            }


            button.MouseDown += PianoRollButton_MouseDown;
            button.MouseUp += PianoRollButton_MouseUp;
            button.FlatStyle = FlatStyle.Flat;

            MakeButtonResizeableAndMovable.Init(button);

            button.BackColor = AppSettings.ChannelColors[channel];

            button.Click += PianoRollButton_Click;

            return button;
        }

        private void PianoRollButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (AppSettings.CurrentCursorStatus)
            {
                case AppSettings.CursorStatus.Default:
                    AppSettings.EditorsControl.propertyGridNoteOnOffEvent.SelectedObject = AppSettings.PianoRollNotes.Where(x => x.Button == button).FirstOrDefault();
                    break;
                case AppSettings.CursorStatus.Erase:
                    AppSettings.PianoRollNotes.RemoveAll(x => x.Button == button);
                    this.Controls.Remove(button);
                    button.Dispose();
                    AppSettings.EditorsControl.propertyGridNoteOnOffEvent.SelectedObject = null;
                    break;
            }
        }

        public void DrawNotes(Note note, int trackNumber)
        {
            Button pianoRollButton = MakeNewButton(note.NoteNumber, note.Time, note.Length, note.Channel);
            NoteOnOffEventProperties noteOnOffEventProperties = new NoteOnOffEventProperties(note.Time, note.Length, note.NoteNumber, note.Velocity, note.Channel, trackNumber, pianoRollButton, false, (NoteOnEvent)note.GetTimedNoteOnEvent().Event, (NoteOffEvent)note.GetTimedNoteOffEvent().Event);
            AppSettings.PianoRollNotes.Add(noteOnOffEventProperties);
            this.Controls.Add(pianoRollButton);
            pictureBoxBackgroundGrid.SendToBack();
            pianoRollButton.BringToFront();
        }

        public void ReDrawNotes()
        {
            if (AppSettings.XScale != 100)
                AppSettings.PianoRollNotes.ForEach(x =>
                {
                    x.Button.Width = (int)(x.Length * AppSettings.XScale / 100);
                    x.Button.Height = AppSettings.YScale;
                    x.Button.Location = new Point((int)(x.Time * AppSettings.XScale / 100), (127 - x.Note) * AppSettings.YScale);
                });
            else
                AppSettings.PianoRollNotes.ForEach(x =>
                {
                    x.Button.Width = (int)x.Length;
                    x.Button.Height = AppSettings.YScale;
                    x.Button.Location = new Point((int)(x.Time), (127 - x.Note) * AppSettings.YScale);
                });
        }

        private void PianoRollControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (AppSettings.CurrentCursorStatus == AppSettings.CursorStatus.Create)
            {
                Note note = new Note((SevenBitNumber)(127 - (e.Y / AppSettings.YScale)), AppSettings.XScale);
                if (AppSettings.XScale != 100)
                {
                    note.Time = e.X * 100 / AppSettings.XScale;
                }
                else
                {
                    note.Time = e.X;
                }
                note.Channel = (FourBitNumber)AppSettings.MainForm.toolStripComboBoxChannels.SelectedIndex;

                DrawNotes(note, AppSettings.MainForm.toolStripComboBoxTracks.SelectedIndex);
            }
        }

        private void pictureBoxBackgroundGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (AppSettings.CurrentCursorStatus == AppSettings.CursorStatus.Create)
            {
                Note note = new Note((SevenBitNumber)(127 - (e.Y / AppSettings.YScale)), AppSettings.XScale);
                if (AppSettings.XScale != 100)
                {
                    note.Time = e.X * 100 / AppSettings.XScale;
                }
                else
                {
                    note.Time = e.X;
                }
                note.Channel = (FourBitNumber)AppSettings.MainForm.toolStripComboBoxChannels.SelectedIndex;

                DrawNotes(note, AppSettings.MainForm.toolStripComboBoxTracks.SelectedIndex);
            }
        }
    }
}
