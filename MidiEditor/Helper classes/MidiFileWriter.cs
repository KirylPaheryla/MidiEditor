using Melanchall.DryWetMidi.Core;
using System.Linq;
using System.Windows.Forms;

namespace MidiEditor
{
    public class MidiFileWriter
    {
        public static void SaveMidiFile()
        {
            if (AppSettings.PathMidiFile != null && AppSettings.PathMidiFile != "")
                WriteMidiFile(AppSettings.PathMidiFile);
            else
                SaveAsMidiFile();
        }

        public static void SaveAsMidiFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "MIDI Files (*.mid)|*.mid|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                WriteMidiFile(saveFileDialog.FileName);
            }
        }

        public static void WriteMidiFile(string path)
        {
            if (!AppSettings.SaveStatus)
            {
                CompileMidiFile();
                AppSettings.MidiFile.Write(path, true);
                AppSettings.PathMidiFile = path;
                AppSettings.SaveStatus = true;
            }
        }

        public static void CompileMidiFile()
        {
            if (!AppSettings.IsFileCompiled)
            {
                MidiFile midiFile = new MidiFile();
                WriteMidiTrackChunks(midiFile);
                AppSettings.MidiFile = midiFile;
                AppSettings.IsFileCompiled = true;
            }
        }

        private static void WriteMidiTrackChunks(MidiFile midiFile)
        {
            foreach (var track in AppSettings.TrackControls)
            {
                TrackChunk trackChunk = new TrackChunk();

                WriteChannelPressureEvents(track, trackChunk);
                WriteControlChangeEvents(track, trackChunk);
                WriteKeyPressureEvents(track, trackChunk);
                WriteKeySignatureEvents(track, trackChunk);
                WritetPitchBendEvents(track, trackChunk);
                WriteProgramChangeEvents(track, trackChunk);
                WriteSysExEvents(track, trackChunk);
                WriteTempoChangeEvents(track, trackChunk);
                WriteTextEvents(track, trackChunk);
                WriteTimeSignatureEvents(track, trackChunk);
                WriteNotes(track, trackChunk);

                midiFile.Chunks.Add(trackChunk);
            }
        }

        private static void WriteNotes(TrackControl track, TrackChunk trackChunk)
        {
            foreach (var pianoRollNote in AppSettings.PianoRollNotes.Where(x => x.Track == track.TrackNumber))
            {
                trackChunk.Events.Add(pianoRollNote.NoteOffEvent);
                trackChunk.Events.Add(pianoRollNote.NoteOnEvent);
            }
        }

        private static void WriteTimeSignatureEvents(TrackControl track, TrackChunk trackChunk)
        {
            foreach (var timeSignatureEventControl in AppSettings.TimeSignatureEventControls.Where(x => x.TimeSignatureEventProperties.Track == track.TrackNumber))
            {
                trackChunk.Events.Add(timeSignatureEventControl.TimeSignatureEventProperties.TimeSignatureEvent);
            }
        }

        private static void WriteTextEvents(TrackControl track, TrackChunk trackChunk)
        {
            foreach (var textEventControl in AppSettings.TextEventControls.Where(x => x.TextEventProperties.Track == track.TrackNumber))
            {
                trackChunk.Events.Add(textEventControl.TextEventProperties.BaseTextEvent);
            }
        }

        private static void WriteTempoChangeEvents(TrackControl track, TrackChunk trackChunk)
        {
            foreach (var tempoChangeEventControl in AppSettings.TempoChangeEventControls.Where(x => x.TempoChangeEventProperties.Track == track.TrackNumber))
            {
                trackChunk.Events.Add(tempoChangeEventControl.TempoChangeEventProperties.SetTempoEvent);
            }
        }

        private static void WriteSysExEvents(TrackControl track, TrackChunk trackChunk)
        {
            foreach (var sysExEventControl in AppSettings.SysExEventControls.Where(x => x.SysExEventProperties.Track == track.TrackNumber))
            {
                trackChunk.Events.Add(sysExEventControl.SysExEventProperties.SysExEvent);
            }
        }

        private static void WriteProgramChangeEvents(TrackControl track, TrackChunk trackChunk)
        {
            foreach (var programChangeEventControl in AppSettings.ProgramChangeEventControls.Where(x => x.ProgramChangeEventProperties.Track == track.TrackNumber))
            {
                trackChunk.Events.Add(programChangeEventControl.ProgramChangeEventProperties.ProgramChangeEvent);
            }
        }

        private static void WritetPitchBendEvents(TrackControl track, TrackChunk trackChunk)
        {
            foreach (var pitchBendEventControl in AppSettings.PitchBendEventControls.Where(x => x.PitchBendEventProperties.Track == track.TrackNumber))
            {
                trackChunk.Events.Add(pitchBendEventControl.PitchBendEventProperties.PitchBendEvent);
            }
        }

        private static void WriteKeySignatureEvents(TrackControl track, TrackChunk trackChunk)
        {
            foreach (var keySignatureEventControl in AppSettings.KeySignatureEventControls.Where(x => x.KeySignatureEventProperties.Track == track.TrackNumber))
            {
                trackChunk.Events.Add(keySignatureEventControl.KeySignatureEventProperties.KeySignatureEvent);
            }
        }

        private static void WriteKeyPressureEvents(TrackControl track, TrackChunk trackChunk)
        {
            foreach (var keyPressureEventControl in AppSettings.KeyPressureEventControls.Where(x => x.KeyPressureEventProperties.Track == track.TrackNumber))
            {
                trackChunk.Events.Add(keyPressureEventControl.KeyPressureEventProperties.NoteAftertouchEvent);
            }
        }

        private static void WriteControlChangeEvents(TrackControl track, TrackChunk trackChunk)
        {
            foreach (var controlChangeEventControl in AppSettings.ControlChangeEventControls.Where(x => x.ControlChangeEventProperties.Track == track.TrackNumber))
            {
                trackChunk.Events.Add(controlChangeEventControl.ControlChangeEventProperties.ControlChangeEvent);
            }
        }

        private static void WriteChannelPressureEvents(TrackControl track, TrackChunk trackChunk)
        {
            foreach (var channelPressureEventControl in AppSettings.ChannelPressureEventControls.Where(x => x.ChannelPressureEventProperties.Track == track.TrackNumber))
            {
                trackChunk.Events.Add(channelPressureEventControl.ChannelPressureEventProperties.ChannelAftertouchEvent);
            }
        }
    }
}
