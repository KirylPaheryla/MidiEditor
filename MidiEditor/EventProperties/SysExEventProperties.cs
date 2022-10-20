using Melanchall.DryWetMidi.Core;
using System;
using System.ComponentModel;

namespace MidiEditor
{
    public class SysExEventProperties
    {
        [Description("Absolute time of the event in units defined by the time division of a MIDI file.")]
        [Category("SysEx Event")]
        public long Time { get; set; }

        [Description("The type of SysEx event.")]
        [Category("SysEx Event")]
        public MidiEventType Type { get; set; }

        [Description("Data of the sysex event.")]
        [Category("SysEx Event")]
        public Byte[] Data { get; set; }

        [Description("Event track number.")]
        [Category("SysEx Event")]
        public int Track { get; set; }

        [Browsable(false)]
        public SysExEvent SysExEvent { get; set; }

        public SysExEventProperties(long time, MidiEventType type, byte[] data, int track, SysExEvent sysExEvent)
        {
            Time = time;
            Type = type;
            Data = data;
            Track = track;
            SysExEvent = sysExEvent;
        }
    }
}
