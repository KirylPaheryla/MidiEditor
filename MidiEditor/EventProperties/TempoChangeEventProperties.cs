using Melanchall.DryWetMidi.Core;
using System.ComponentModel;

namespace MidiEditor
{
    public class TempoChangeEventProperties
    {
        [Description("Absolute time of the event in units defined by the time division of a MIDI file.")]
        [Category("Tempo Change Event")]
        public long Time { get; set; }

        [Description("Number of microseconds per quarter note.")]
        [Category("Tempo Change Event")]
        public long MicrosecondsPerQuarterNote { get; set; }

        [Description("Event track number.")]
        [Category("Tempo Change Event")]
        public int Track { get; set; }

        [Browsable(false)]
        public SetTempoEvent SetTempoEvent { get; set; }

        public TempoChangeEventProperties(long time, long microsecondsPerQuarterNote, int track, SetTempoEvent setTempoEvent)
        {
            Time = time;
            MicrosecondsPerQuarterNote = microsecondsPerQuarterNote;
            Track = track;
            SetTempoEvent = setTempoEvent;
        }
    }
}
