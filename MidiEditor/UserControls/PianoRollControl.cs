using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
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
    public partial class PianoRollControl : UserControl
    {
        public PictureBox GetPictureBoxBackgroundGrid { get; private set; }

        public MidiFile MidiFile;

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

        private Button MakeNewButton(int noteNumber, long startTime, long duration, int channel, int trackNumber)
        {
            Button button = new Button();
            button.Width = (int)(duration);
            button.Height = AppSettings.YScale;
            button.Location = new Point((int)(startTime), (127 - noteNumber) * AppSettings.YScale);
            button.MouseDown += PianoRollButton_MouseDown;
            button.MouseUp += PianoRollButton_MouseUp;
            button.FlatStyle = FlatStyle.Flat; 

            MakeButtonResizeableAndMovable.Init(button);

            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            button.BackColor = randomColor;

            return button;
        }

        public void DrawNotes(MidiFile midiFile)
        {
            if (midiFile != null)
            {
                this.MidiFile = midiFile;

                int trackNumber = 0;
                foreach (TrackChunk trackChunk in midiFile.GetTrackChunks())
                {
                    foreach (var note in trackChunk.GetNotes())
                    {
                        Button button = MakeNewButton(note.NoteNumber, note.Time, note.Length, note.Channel, trackNumber);
                        this.Controls.Add(button);
                        button.BringToFront();
                        //
                        // add MyEvent object
                        // add to event list
                        //
                    }
                    trackNumber++;
                }
            }
        }

        public void ReDrawNotes()
        {
            if(MidiFile != null)
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.Width -= button.Width * 1 / 4;
                    button.Location = new Point(button.Location.X - 25, button.Location.Y);
                }
            }
        }
    }
}
