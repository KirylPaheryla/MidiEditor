using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MidiEditor
{
    internal class MidiFileReader
    {
        public static void ReadMidiFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MIDI Files (*.mid)|*.mid|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AppTools.ClearWorkplace();
                MidiFile midiFile = MidiFile.Read(openFileDialog.FileName);
                AppSettings.MidiFile = midiFile;
                AppSettings.PathMidiFile = openFileDialog.FileName;
                AppSettings.SaveStatus = true;
                AppSettings.IsFileCompiled = true;
                ReadMidiTrackChunks(midiFile.GetTrackChunks());
                AppTools.RefreshToolStripComboBoxTracks();
            }
        }

        private static void ReadTrackChunkEvents(ICollection<TimedEvent> TimedEvents, int TrackChunkNumber)
        {
            foreach (var timedEvent in TimedEvents)
            {
                switch (timedEvent.Event.EventType)
                {
                    case MidiEventType.ChannelAftertouch:
                        ChannelAftertouchEvent channelAftertouchEvent = (ChannelAftertouchEvent)timedEvent.Event;
                        new ChannelPressureEventControl(channelAftertouchEvent.DeltaTime, channelAftertouchEvent.AftertouchValue, channelAftertouchEvent.Channel, TrackChunkNumber, channelAftertouchEvent);
                        break;
                    case MidiEventType.ControlChange:
                        ControlChangeEvent controlChangeEvent = (ControlChangeEvent)timedEvent.Event;
                        new ControlChangeEventControl(controlChangeEvent.DeltaTime, controlChangeEvent.ControlNumber, controlChangeEvent.ControlValue, controlChangeEvent.Channel, TrackChunkNumber, controlChangeEvent);
                        break;
                    case MidiEventType.NoteAftertouch:
                        NoteAftertouchEvent noteAftertouchEvent = (NoteAftertouchEvent)timedEvent.Event;
                        new KeyPressureEventControl(noteAftertouchEvent.DeltaTime, noteAftertouchEvent.NoteNumber, noteAftertouchEvent.AftertouchValue, noteAftertouchEvent.Channel, TrackChunkNumber, noteAftertouchEvent);
                        break;
                    case MidiEventType.KeySignature:
                        KeySignatureEvent keySignatureEvent = (KeySignatureEvent)timedEvent.Event;
                        new KeySignatureEventControl(keySignatureEvent.DeltaTime, keySignatureEvent.Key, keySignatureEvent.Scale, TrackChunkNumber, keySignatureEvent);
                        break;
                    case MidiEventType.PitchBend:
                        PitchBendEvent pitchBendEvent = (PitchBendEvent)timedEvent.Event;
                        new PitchBendEventControl(pitchBendEvent.DeltaTime, pitchBendEvent.PitchValue, pitchBendEvent.Channel, TrackChunkNumber, pitchBendEvent);
                        break;
                    case MidiEventType.ProgramChange:
                        ProgramChangeEvent programChangeEvent = (ProgramChangeEvent)timedEvent.Event;
                        new ProgramChangeEventControl(programChangeEvent.DeltaTime, programChangeEvent.ProgramNumber, programChangeEvent.Channel, TrackChunkNumber, programChangeEvent);
                        break;
                    case MidiEventType.EscapeSysEx:
                        EscapeSysExEvent escapeSysExEvent = (EscapeSysExEvent)timedEvent.Event;
                        new SysExEventControl(escapeSysExEvent.DeltaTime, MidiEventType.EscapeSysEx, escapeSysExEvent.Data, TrackChunkNumber, escapeSysExEvent);
                        break;
                    case MidiEventType.NormalSysEx:
                        NormalSysExEvent normalSysExEvent = (NormalSysExEvent)timedEvent.Event;
                        new SysExEventControl(normalSysExEvent.DeltaTime, MidiEventType.NormalSysEx, normalSysExEvent.Data, TrackChunkNumber, normalSysExEvent);
                        break;
                    case MidiEventType.SetTempo:
                        SetTempoEvent setTempoEvent = (SetTempoEvent)timedEvent.Event;
                        new TempoChangeEventControl(setTempoEvent.DeltaTime, setTempoEvent.MicrosecondsPerQuarterNote, TrackChunkNumber, setTempoEvent);
                        break;
                    case MidiEventType.TimeSignature:
                        TimeSignatureEvent timeSignatureEvent = (TimeSignatureEvent)timedEvent.Event;
                        new TimeSignatureEventControl(timeSignatureEvent.DeltaTime, timeSignatureEvent.Numerator, timeSignatureEvent.Denominator, TrackChunkNumber, timeSignatureEvent);
                        break;
                    case MidiEventType.CopyrightNotice:
                        CopyrightNoticeEvent copyrightNoticeEvent = (CopyrightNoticeEvent)timedEvent.Event;
                        new TextEventControl(copyrightNoticeEvent.DeltaTime, MidiEventType.CopyrightNotice, copyrightNoticeEvent.Text, TrackChunkNumber, copyrightNoticeEvent);
                        break;
                    case MidiEventType.CuePoint:
                        CuePointEvent cuePointEvent = (CuePointEvent)timedEvent.Event;
                        new TextEventControl(cuePointEvent.DeltaTime, MidiEventType.CuePoint, cuePointEvent.Text, TrackChunkNumber, cuePointEvent);
                        break;
                    case MidiEventType.DeviceName:
                        DeviceNameEvent deviceNameEvent = (DeviceNameEvent)timedEvent.Event;
                        new TextEventControl(deviceNameEvent.DeltaTime, MidiEventType.DeviceName, deviceNameEvent.Text, TrackChunkNumber, deviceNameEvent);
                        break;
                    case MidiEventType.InstrumentName:
                        InstrumentNameEvent instrumentNameEvent = (InstrumentNameEvent)timedEvent.Event;
                        new TextEventControl(instrumentNameEvent.DeltaTime, MidiEventType.InstrumentName, instrumentNameEvent.Text, TrackChunkNumber, instrumentNameEvent);
                        break;
                    case MidiEventType.Lyric:
                        LyricEvent lyricEvent = (LyricEvent)timedEvent.Event;
                        new TextEventControl(lyricEvent.DeltaTime, MidiEventType.Lyric, lyricEvent.Text, TrackChunkNumber, lyricEvent);
                        break;
                    case MidiEventType.Marker:
                        MarkerEvent markerEvent = (MarkerEvent)timedEvent.Event;
                        new TextEventControl(markerEvent.DeltaTime, MidiEventType.Marker, markerEvent.Text, TrackChunkNumber, markerEvent);
                        break;
                    case MidiEventType.ProgramName:
                        ProgramNameEvent programNameEvent = (ProgramNameEvent)timedEvent.Event;
                        new TextEventControl(programNameEvent.DeltaTime, MidiEventType.ProgramName, programNameEvent.Text, TrackChunkNumber, programNameEvent);
                        break;
                    case MidiEventType.SequenceTrackName:
                        SequenceTrackNameEvent sequenceTrackNameEvent = (SequenceTrackNameEvent)timedEvent.Event;
                        new TextEventControl(sequenceTrackNameEvent.DeltaTime, MidiEventType.SequenceTrackName, sequenceTrackNameEvent.Text, TrackChunkNumber, sequenceTrackNameEvent);
                        AppSettings.EditorsControl.flowLayoutPanelTracks.Controls.OfType<TrackControl>().Where(x => x.TrackNumber == TrackChunkNumber).First().TrackName = sequenceTrackNameEvent.Text;
                        break;
                    case MidiEventType.Text:
                        TextEvent textEvent = (TextEvent)timedEvent.Event;
                        new TextEventControl(textEvent.DeltaTime, MidiEventType.Text, textEvent.Text, TrackChunkNumber, textEvent);
                        break;
                }
            }
        }

        private static void ReadTrackChunkNotes(ICollection<Note> Notes, int TrackChunkNumber)
        {
            foreach (Note note in Notes)
            {
                AppSettings.PianoRollControl.DrawNotes(note, TrackChunkNumber);
            }
        }

        private static void ReadMidiTrackChunks(IEnumerable<TrackChunk> TrackChunks)
        {
            int trackChunkNumber = 0;
            foreach (TrackChunk trackChunk in TrackChunks)
            {
                new TrackControl(trackChunkNumber, "Untitled track");
                ReadTrackChunkNotes(trackChunk.GetNotes(), trackChunkNumber);
                ReadTrackChunkEvents(trackChunk.GetTimedEvents(), trackChunkNumber);
                trackChunkNumber++;
            }
        }
    }
}
