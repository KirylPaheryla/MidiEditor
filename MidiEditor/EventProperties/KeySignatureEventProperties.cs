using Melanchall.DryWetMidi.Core;
using System;
using System.ComponentModel;

namespace MidiEditor
{
    public class KeySignatureEventProperties
    {
        [Description("Absolute time of the event in units defined by the time division of a MIDI file.")]
        [Category("Key Signature Event")]
        public long Time { get; set; }

        [Description("The number of flats (if negative) or sharps (if positive).\nThe smallest possible key value: -7.\nThe largest possible key value: 7.")]
        [Category("Key Signature Event")]
        public SByte Key { get; set; }

        [Description("The scale (0 for major or 1 for minor).")]
        [Category("Key Signature Event")]
        public Byte Scale { get; set; }

        [Description("Event track number.")]
        [Category("Key Signature Event")]
        public int Track { get; set; }

        [Browsable(false)]
        public KeySignatureEvent KeySignatureEvent { get; set; }

        public KeySignatureEventProperties(long time, sbyte key, byte scale, int track, KeySignatureEvent keySignatureEvent)
        {
            Time = time;
            Key = key;
            Scale = scale;
            Track = track;
            KeySignatureEvent = keySignatureEvent;
        }
    }
}
