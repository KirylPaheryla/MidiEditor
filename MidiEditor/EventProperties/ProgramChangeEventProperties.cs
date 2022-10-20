using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using System.ComponentModel;

namespace MidiEditor
{
    public class ProgramChangeEventProperties
    {
        [Description("Absolute time of the event in units defined by the time division of a MIDI file.")]
        [Category("Program Change Event")]
        public long Time { get; set; }

        [Description("Program number.")]
        [Category("Program Change Event")]
        public SevenBitNumber ProgramNumber { get; set; }

        [Description("Event channel number.")]
        [Category("Program Change Event")]
        public int Channel { get; set; }

        [Description("Event track number.")]
        [Category("Program Change Event")]
        public int Track { get; set; }

        [Browsable(false)]
        public ProgramChangeEvent ProgramChangeEvent { get; set; }

        public ProgramChangeEventProperties(long time, SevenBitNumber programNumber, int channel, int track, ProgramChangeEvent programChangeEvent)
        {
            Time = time;
            ProgramNumber = programNumber;
            Channel = channel;
            Track = track;
            ProgramChangeEvent = programChangeEvent;
        }
    }
}
