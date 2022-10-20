using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using System.ComponentModel;
using System.Windows.Forms;

namespace MidiEditor
{
    public class NoteOnOffEventProperties
    {
        [Description("Absolute time of the event in units defined by the time division of a MIDI file.")]
        [Category("Note On/Off Event")]
        public long Time { get; set; }

        [Description("Length of the event in units defined by time division of a MIDI file.")]
        [Category("Note On/Off Event")]
        public long Length { get; set; }

        [Description("Number of the note.")]
        [Category("Note On/Off Event")]
        public int Note { get; set; }

        [Description("Velocity.")]
        [Category("Note On/Off Event")]
        public int Velocity { get; set; }

        [Description("Event channel number.")]
        [Category("Note On/Off Event")]
        public FourBitNumber Channel { get; set; }

        [Description("Event track number.")]
        [Category("Note On/Off Event")]
        public int Track { get; set; }

        [Browsable(false)]
        public Button Button { get; set; }

        [Browsable(false)]
        public bool Hide { get; set; }

        [Browsable(false)]
        public NoteOnEvent NoteOnEvent { get; set; }

        [Browsable(false)]
        public NoteOffEvent NoteOffEvent { get; set; }

        public NoteOnOffEventProperties(long time, long length, int note, int velocity, FourBitNumber channel, int track, Button button, bool hide, NoteOnEvent noteOnEvent, NoteOffEvent noteOffEvent)
        {
            Time = time;
            Length = length;
            Note = note;
            Velocity = velocity;
            Channel = channel;
            Track = track;
            Button = button;
            Hide = hide;
            NoteOnEvent = noteOnEvent;
            NoteOffEvent = noteOffEvent;
        }
    }
}
