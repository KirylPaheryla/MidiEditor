using Melanchall.DryWetMidi.Core;
using System.ComponentModel;

namespace MidiEditor
{
    public class TimeSignatureEventProperties
    {
        [Description("Absolute time of the event in units defined by the time division of a MIDI file.")]
        [Category("Time Signature Event")]
        public long Time { get; set; }

        [Description("Numerator.")]
        [Category("Time Signature Event")]
        public int Numerator { get; set; }

        [Description("Denominator.")]
        [Category("Time Signature Event")]
        public int Denominator { get; set; }

        [Description("Event track number.")]
        [Category("Time Signature Event")]
        public int Track { get; set; }

        [Browsable(false)]
        public TimeSignatureEvent TimeSignatureEvent { get; set; }

        public TimeSignatureEventProperties(long time, int numerator, int denominator, int track, TimeSignatureEvent timeSignatureEvent)
        {
            Time = time;
            Numerator = numerator;
            Denominator = denominator;
            Track = track;
            TimeSignatureEvent = timeSignatureEvent;
        }
    }
}
