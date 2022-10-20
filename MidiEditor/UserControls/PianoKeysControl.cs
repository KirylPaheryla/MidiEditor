using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class PianoKeysControl : UserControl
    {
        private List<Button> pianoKeys = new List<Button>(128);

        public PianoKeysControl() => InitializeComponent();

        private void PianoKeysControl_Load(object sender, EventArgs e) => CreateAndPlacePianoKeys();

        private void CreateAndPlacePianoKeys()
        {
            int buttonLocationY = 0;
            for (int i = 0; i < 128; i++)
            {
                Button button = new Button();
                button.FlatStyle = FlatStyle.Flat;
                button.Name = "pianoKey_" + i.ToString();
                button.Width = 100;
                button.Height = AppSettings.YScale;
                button.Location = new Point(0, buttonLocationY);
                button.TextAlign = ContentAlignment.MiddleRight;
                button.Text = new NoteOnEvent((SevenBitNumber)i, (SevenBitNumber)0).GetNoteName().ToString() + new NoteOnEvent((SevenBitNumber)i, (SevenBitNumber)0).GetNoteOctave().ToString();
                button.MouseDown += PianoKey_MouseDown;
                button.MouseUp += PianoKey_MouseUp;
                button.BackColor = Color.White;
                this.Controls.Add(button);

                buttonLocationY += AppSettings.YScale;
            }
            pianoKeys = Enumerable.Range(0, 128)
                                  .Select(i => (Button)this.Controls["pianoKey_" + i.ToString()])
                                  .ToList();
        }

        private void PianoKey_MouseDown(object sender, MouseEventArgs e)
        {
            int noteNumber = pianoKeys.IndexOf(sender as Button);
            SoundMaker.PlaySound(noteNumber, 100);
            pianoKeys[noteNumber].BackColor = Color.Gray;
        }

        private void PianoKey_MouseUp(object sender, MouseEventArgs e)
        {
            int noteNumber = pianoKeys.IndexOf(sender as Button);
            SoundMaker.StopSound(noteNumber);
            pianoKeys[noteNumber].BackColor = Color.White;
        }
    }
}
