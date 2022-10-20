using Melanchall.DryWetMidi.Core;
using System;
using System.ComponentModel;

namespace MidiEditor
{
    public class PitchBendEventProperties
    {
        [Description("Absolute time of the event in units defined by the time division of a MIDI file.")]
        [Category("Pitch Bend Event")]
        public long Time { get; set; }

        [Description("Pitch value.")]
        [Category("Pitch Bend Event")]
        public UInt16 Value { get; set; }

        [Description("Event channel number.")]
        [Category("Pitch Bend Event")]
        public int Channel { get; set; }

        [Description("Event track number.")]
        [Category("Pitch Bend Event")]
        public int Track { get; set; }

        [Browsable(false)]
        public PitchBendEvent PitchBendEvent { get; set; }

        public PitchBendEventProperties(long time, ushort value, int channel, int track, PitchBendEvent pitchBendEvent)
        {
            Time = time;
            Value = value;
            Channel = channel;
            Track = track;
            PitchBendEvent = pitchBendEvent;
        }
    }
}
