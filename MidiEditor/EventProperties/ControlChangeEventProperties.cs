using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using System.ComponentModel;

namespace MidiEditor
{
    public class ControlChangeEventProperties
    {
        [Description("Absolute time of the event in units defined by the time division of a MIDI file.")]
        [Category("Control Change Event")]
        public long Time { get; set; }

        [Description("Controller number.")]
        [Category("Control Change Event")]
        public SevenBitNumber ControlNumber { get; set; }

        [Description("Controller value.")]
        [Category("Control Change Event")]
        public SevenBitNumber ControlValue { get; set; }

        [Description("Event channel number.")]
        [Category("Control Change Event")]
        public int Channel { get; set; }

        [Description("Event track number.")]
        [Category("Control Change Event")]
        public int Track { get; set; }

        [Browsable(false)]
        public ControlChangeEvent ControlChangeEvent { get; set; }

        public ControlChangeEventProperties(long time, SevenBitNumber controlNumber, SevenBitNumber controlValue, int channel, int track, ControlChangeEvent controlChangeEvent)
        {
            Time = time;
            ControlNumber = controlNumber;
            ControlValue = controlValue;
            Channel = channel;
            Track = track;
            ControlChangeEvent = controlChangeEvent;
        }
    }
}
