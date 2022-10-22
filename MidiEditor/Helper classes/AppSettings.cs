using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Multimedia;
using MidiEditor.UserControls;
using System.Collections.Generic;
using System.Drawing;

namespace MidiEditor
{
    public class AppSettings
    {
        public static MidiFile MidiFile { get; set; } = new MidiFile();
        public static string PathMidiFile { get; set; } = "";
        public static OutputDevice OutputDevice { get; set; }
        public static int XScale { get; set; } = 100;
        public static int YScale { get; set; } = 25;
        public static bool SaveStatus { get; set; } = true;
        public static bool IsFileCompiled { get; set; } = false;
        public static List<ChannelControl> ChannelControls { get; set; } = new List<ChannelControl>();
        public static List<TrackControl> TrackControls { get; set; } = new List<TrackControl>();
        public static List<ChannelPressureEventControl> ChannelPressureEventControls { get; set; } = new List<ChannelPressureEventControl>();
        public static List<ControlChangeEventControl> ControlChangeEventControls { get; set; } = new List<ControlChangeEventControl>();
        public static List<KeyPressureEventControl> KeyPressureEventControls { get; set; } = new List<KeyPressureEventControl>();
        public static List<KeySignatureEventControl> KeySignatureEventControls { get; set; } = new List<KeySignatureEventControl>();
        public static List<PitchBendEventControl> PitchBendEventControls { get; set; } = new List<PitchBendEventControl>();
        public static List<ProgramChangeEventControl> ProgramChangeEventControls { get; set; } = new List<ProgramChangeEventControl>();
        public static List<SysExEventControl> SysExEventControls { get; set; } = new List<SysExEventControl>();
        public static List<TempoChangeEventControl> TempoChangeEventControls { get; set; } = new List<TempoChangeEventControl>();
        public static List<TextEventControl> TextEventControls { get; set; } = new List<TextEventControl>();
        public static List<TimeSignatureEventControl> TimeSignatureEventControls { get; set; } = new List<TimeSignatureEventControl>();
        public static List<NoteOnOffEventProperties> PianoRollNotes { get; set; } = new List<NoteOnOffEventProperties>();
        public static CursorStatus CurrentCursorStatus { get; set; } = CursorStatus.Default;
        public static MainForm MainForm { get; set; }
        public static PianoRollControl PianoRollControl { get; set; }
        public static TimelineControl TimelineControl { get; set; }
        public static EditorsControl EditorsControl { get; set; }

        public enum CursorStatus
        {
            Default,
            Create,
            Erase
        }

        public static List<Color> ChannelColors { get; } = new List<Color>(15) { Color.Red, Color.Green, Color.Blue, Color.Brown, Color.Chartreuse, Color.Gold, Color.Gainsboro, Color.Fuchsia, Color.LightPink, Color.MediumSpringGreen, Color.SeaShell, Color.Tomato, Color.Turquoise, Color.Violet, Color.Aquamarine };


    }
}
