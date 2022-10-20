using Melanchall.DryWetMidi.Core;
using System.ComponentModel;

namespace MidiEditor
{
    public class ChannelPressureEventProperties
    {
        [Description("Absolute time of the event in units defined by the time division of a MIDI file.")]
        [Category("Channel Pressure Event")]
        public long Time { get; set; }

        [Description("Aftertouch (pressure) value.")]
        [Category("Channel Pressure Event")]
        public int Value { get; set; }

        [Description("Event channel number.")]
        [Category("Channel Pressure Event")]
        public int Channel { get; set; }

        [Description("Event track number.")]
        [Category("Channel Pressure Event")]
        public int Track { get; set; }

        [Browsable(false)]
        public ChannelAftertouchEvent ChannelAftertouchEvent { get; set; }

        public ChannelPressureEventProperties(long time, int value, int channel, int track, ChannelAftertouchEvent channelAftertouchEvent)
        {
            Time = time;
            Value = value;
            Channel = channel;
            Track = track;
            ChannelAftertouchEvent = channelAftertouchEvent;
        }
    }
}
