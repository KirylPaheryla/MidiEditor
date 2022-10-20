using Melanchall.DryWetMidi.Core;
using System.ComponentModel;

namespace MidiEditor
{
    public class KeyPressureEventProperties
    {
        [Description("Absolute time of the event in units defined by the time division of a MIDI file.")]
        [Category("Key Pressure Event")]
        public long Time { get; set; }

        [Description("Event note number.")]
        [Category("Key Pressure Event")]
        public int Note { get; set; }

        [Description("Aftertouch (pressure) value.")]
        [Category("Key Pressure Event")]
        public int Value { get; set; }

        [Description("Event channel number.")]
        [Category("Key Pressure Event")]
        public int Channel { get; set; }

        [Description("Event track number.")]
        [Category("Key Pressure Event")]
        public int Track { get; set; }

        [Browsable(false)]
        public NoteAftertouchEvent NoteAftertouchEvent { get; set; }

        public KeyPressureEventProperties(long time, int note, int value, int channel, int track, NoteAftertouchEvent noteAftertouchEvent)
        {
            Time = time;
            Note = note;
            Value = value;
            Channel = channel;
            Track = track;
            NoteAftertouchEvent = noteAftertouchEvent;
        }
    }
}
