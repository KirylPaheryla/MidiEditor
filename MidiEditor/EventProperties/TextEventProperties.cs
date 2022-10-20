using Melanchall.DryWetMidi.Core;
using System.ComponentModel;

namespace MidiEditor
{
    public class TextEventProperties
    {
        [Description("Absolute time of the event in units defined by the time division of a MIDI file.")]
        [Category("Text Event")]
        public long Time { get; set; }

        [Description("The type of Text event.")]
        [Category("Text Event")]
        public MidiEventType Type { get; set; }

        [Description("Text contained in the event.")]
        [Category("Text Event")]
        public string Text { get; set; }

        [Description("Event track number.")]
        [Category("Text Event")]
        public int Track { get; set; }

        [Browsable(false)]
        public BaseTextEvent BaseTextEvent { get; set; }

        public TextEventProperties(long time, MidiEventType type, string text, int track, BaseTextEvent baseTextEvent)
        {
            Time = time;
            Type = type;
            Text = text;
            Track = track;
            BaseTextEvent = baseTextEvent;
        }
    }
}
