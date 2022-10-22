using MidiEditor.UserControls;
using System.Linq;

namespace MidiEditor
{
    internal class AppTools
    {
        public static string GetInstrumentName(int InstrumentNumber)
        {
            switch (InstrumentNumber)
            {
                case 0: return "Acoustic Grand Piano";
                case 1: return "Bright Acoustic Piano";
                case 2: return "Electric Grand Piano";
                case 3: return "Honky-tonk Piano";
                case 4: return "Rhodes Piano";
                case 5: return "Chorused Piano";
                case 6: return "Harpsichord";
                case 7: return "Clavinet";
                case 8: return "Celesta";
                case 9: return "Glockenspiel";
                case 10: return "Music box";
                case 11: return "Vibraphone";
                case 12: return "Marimba";
                case 13: return "Xylophone";
                case 14: return "Tubular Bells";
                case 15: return "Dulcimer";
                case 16: return "Hammond Organ";
                case 17: return "Percussive Organ";
                case 18: return "Rock Organ";
                case 19: return "Church Organ";
                case 20: return "Reed Organ";
                case 21: return "Accordion";
                case 22: return "Harmonica";
                case 23: return "Tango Accordion";
                case 24: return "Acoustic Guitar (nylon)";
                case 25: return "Acoustic Guitar (steel)";
                case 26: return "Electric Guitar (jazz)";
                case 27: return "Electric Guitar (clean)";
                case 28: return "Electric Guitar (muted)";
                case 29: return "Overdriven Guitar";
                case 30: return "Distortion Guitar";
                case 31: return "Guitar Harmonics";
                case 32: return "Acoustic Bass";
                case 33: return "Electric Bass (finger)";
                case 34: return "Electric Bass (pick)";
                case 35: return "Fretless Bass";
                case 36: return "Slap Bass 1";
                case 37: return "Slap Bass 2";
                case 38: return "Synth Bass 1";
                case 39: return "Synth Bass 2";
                case 40: return "Violin";
                case 41: return "Viola";
                case 42: return "Cello";
                case 43: return "Contrabass";
                case 44: return "Tremolo Strings";
                case 45: return "Pizzicato Strings";
                case 46: return "Orchestral Harp";
                case 47: return "Timpani";
                case 48: return "String Ensemble 1";
                case 49: return "String Ensemble 2";
                case 50: return "Synth Strings 1";
                case 51: return "Synth Strings 2";
                case 52: return "Choir Aahs";
                case 53: return "Voice Oohs";
                case 54: return "Synth Voice";
                case 55: return "Orchestra Hit";
                case 56: return "Trumpet";
                case 57: return "Trombone";
                case 58: return "Tuba";
                case 59: return "Muted Trumpet";
                case 60: return "French Horn";
                case 61: return "Brass Section";
                case 62: return "Synth Brass 1";
                case 63: return "Synth Brass 2";
                case 64: return "Soprano Sax";
                case 65: return "Alto Sax";
                case 66: return "Tenor Sax";
                case 67: return "Baritone Sax";
                case 68: return "Oboe";
                case 69: return "English Horn";
                case 70: return "Bassoon";
                case 71: return "Clarinet";
                case 72: return "Piccolo";
                case 73: return "Flute";
                case 74: return "Recorder";
                case 75: return "Pan Flute";
                case 76: return "Bottle Blow";
                case 77: return "Shakuhachi";
                case 78: return "Whistle";
                case 79: return "Ocarina";
                case 80: return "Lead 1 (square)";
                case 81: return "Lead 2 (sawtooth)";
                case 82: return "Lead 3 (calliope lead)";
                case 83: return "Lead 4 (chiffer lead)";
                case 84: return "Lead 5 (charang)";
                case 85: return "Lead 6 (voice)";
                case 86: return "Lead 7 (fifths)";
                case 87: return "Lead 8 (brass + lead)";
                case 88: return "Pad 1 (new age)";
                case 89: return "Pad 2 (warm)";
                case 90: return "Pad 3 (polysynth)";
                case 91: return "Pad 4 (choir)";
                case 92: return "Pad 5 (bowed)";
                case 93: return "Pad 6 (metallic)";
                case 94: return "Pad 7 (halo)";
                case 95: return "Pad 8 (sweep)";
                case 96: return "FX 1 (rain)";
                case 97: return "FX 2 (soundtrack)";
                case 98: return "FX 3 (crystal)";
                case 99: return "FX 4 (atmosphere)";
                case 100: return "FX 5 (brightness)";
                case 101: return "FX 6 (goblins)";
                case 102: return "FX 7 (echoes)";
                case 103: return "FX 8 (sci-fi)";
                case 104: return "Sitar";
                case 105: return "Banjo";
                case 106: return "Shamisen";
                case 107: return "Koto";
                case 108: return "Kalimba";
                case 109: return "Bagpipe";
                case 110: return "Fiddle";
                case 111: return "Shana";
                case 112: return "Tinkle Bell";
                case 113: return "Agogo";
                case 114: return "Steel Drums";
                case 115: return "Woodblock";
                case 116: return "Taiko Drum";
                case 117: return "Melodic Tom";
                case 118: return "Synth Drum";
                case 119: return "Reverse Cymbal";
                case 120: return "Guitar Fret Noise";
                case 121: return "Breath Noise";
                case 122: return "Seashore";
                case 123: return "Bird Tweet";
                case 124: return "Telephone Ring";
                case 125: return "Helicopter";
                case 126: return "Applause";
                case 127: return "Gunshot";
            }
            return "Error";
        }
        public static void RefreshToolStripComboBoxTracks()
        {
            AppSettings.MainForm.toolStripComboBoxTracks.Items.Clear();
            foreach (var track in AppSettings.TrackControls)
            {
                AppSettings.MainForm.toolStripComboBoxTracks.Items.Add($@"Track {track.TrackNumber} ({track.TrackName})");
            }
            AppSettings.MainForm.toolStripComboBoxTracks.SelectedIndex = 0;
        }

        #region DeleteAllEventsByTrackNumber
        public static void DeleteAllEventsByTrackNumber(int trackNumber)
        {
            DeleteAllTimeSignatureEventControlsByTrackNumber(trackNumber);
            DeleteAllTextEventControlsByTrackNumber(trackNumber);
            DeleteAllTempoChangeEventControlsByTrackNumber(trackNumber);
            DeleteAllSysExEventControlsByTrackNumber(trackNumber);
            DeleteAllProgramChangeEventControlsByTrackNumber(trackNumber);
            DeleteAllPitchBendEventControlsByTrackNumber(trackNumber);
            DeleteAllKeySignatureEventControlsByTrackNumber(trackNumber);
            DeleteAllKeyPressureEventControlsByTrackNumber(trackNumber);
            DeleteAllControlChangeEventControlsBYTrackNumber(trackNumber);
            DeleteAllChannelPressureEventControlsByTrackNumber(trackNumber);
            DeleteAllPianoRollNotesByTrackNumber(trackNumber);
        }

        private static void DeleteAllPianoRollNotesByTrackNumber(int trackNumber)
        {
            foreach (var note in AppSettings.PianoRollNotes.Where(x => x.Track == trackNumber))
            {
                AppSettings.PianoRollNotes.Remove(note);
                AppSettings.PianoRollControl.Controls.Remove(note.Button);
                note.Button.Dispose();
            }
        }

        private static void DeleteAllChannelPressureEventControlsByTrackNumber(int trackNumber)
        {
            foreach (var channelPressureEventControl in AppSettings.ChannelPressureEventControls.Where(x => x.ChannelPressureEventProperties.Track == trackNumber))
            {
                AppSettings.ChannelPressureEventControls.Remove(channelPressureEventControl);
                AppSettings.EditorsControl.flowLayoutPanelTabPageChannelPressureEvents.Controls.Remove(channelPressureEventControl);
                channelPressureEventControl.Dispose();
            }
        }

        private static void DeleteAllControlChangeEventControlsBYTrackNumber(int trackNumber)
        {
            foreach (var controlChangeEventControl in AppSettings.ControlChangeEventControls.Where(x => x.ControlChangeEventProperties.Track == trackNumber))
            {
                AppSettings.ControlChangeEventControls.Remove(controlChangeEventControl);
                AppSettings.EditorsControl.flowLayoutPanelTabPageControlChangeEvents.Controls.Remove(controlChangeEventControl);
                controlChangeEventControl.Dispose();
            }
        }

        private static void DeleteAllKeyPressureEventControlsByTrackNumber(int trackNumber)
        {
            foreach (var keyPressureEventControl in AppSettings.KeyPressureEventControls.Where(x => x.KeyPressureEventProperties.Track == trackNumber))
            {
                AppSettings.KeyPressureEventControls.Remove(keyPressureEventControl);
                AppSettings.EditorsControl.flowLayoutPanelTabPageKeyPressureEvents.Controls.Remove(keyPressureEventControl);
                keyPressureEventControl.Dispose();
            }
        }

        private static void DeleteAllKeySignatureEventControlsByTrackNumber(int trackNumber)
        {
            foreach (var keySignatureEventControl in AppSettings.KeySignatureEventControls.Where(x => x.KeySignatureEventProperties.Track == trackNumber))
            {
                AppSettings.KeySignatureEventControls.Remove(keySignatureEventControl);
                AppSettings.EditorsControl.flowLayoutPanelTabPageKeySignatureEvents.Controls.Remove(keySignatureEventControl);
                keySignatureEventControl.Dispose();
            }
        }

        private static void DeleteAllPitchBendEventControlsByTrackNumber(int trackNumber)
        {
            foreach (var pitchBendEventControl in AppSettings.PitchBendEventControls.Where(x => x.PitchBendEventProperties.Track == trackNumber))
            {
                AppSettings.PitchBendEventControls.Remove(pitchBendEventControl);
                AppSettings.EditorsControl.flowLayoutPanelTabPagePitchBendEvents.Controls.Remove(pitchBendEventControl);
                pitchBendEventControl.Dispose();
            }
        }

        private static void DeleteAllProgramChangeEventControlsByTrackNumber(int trackNumber)
        {
            foreach (var programChangeEventControl in AppSettings.ProgramChangeEventControls.Where(x => x.ProgramChangeEventProperties.Track == trackNumber))
            {
                AppSettings.ProgramChangeEventControls.Remove(programChangeEventControl);
                AppSettings.EditorsControl.flowLayoutPanelTabPageProgramChangeEvens.Controls.Remove(programChangeEventControl);
                programChangeEventControl.Dispose();
            }
        }

        private static void DeleteAllSysExEventControlsByTrackNumber(int trackNumber)
        {
            foreach (var sysExEventControl in AppSettings.SysExEventControls.Where(x => x.SysExEventProperties.Track == trackNumber))
            {
                AppSettings.SysExEventControls.Remove(sysExEventControl);
                AppSettings.EditorsControl.flowLayoutPanelTabPageSysExEvents.Controls.Remove(sysExEventControl);
                sysExEventControl.Dispose();
            }
        }

        private static void DeleteAllTempoChangeEventControlsByTrackNumber(int trackNumber)
        {
            foreach (var tempoChangeEventControl in AppSettings.TempoChangeEventControls.Where(x => x.TempoChangeEventProperties.Track == trackNumber))
            {
                AppSettings.TempoChangeEventControls.Remove(tempoChangeEventControl);
                AppSettings.EditorsControl.flowLayoutPanelTabPageTempoChangeEvents.Controls.Remove(tempoChangeEventControl);
                tempoChangeEventControl.Dispose();
            }
        }

        private static void DeleteAllTextEventControlsByTrackNumber(int trackNumber)
        {
            foreach (var textEventControl in AppSettings.TextEventControls.Where(x => x.TextEventProperties.Track == trackNumber))
            {
                AppSettings.TextEventControls.Remove(textEventControl);
                AppSettings.EditorsControl.flowLayoutPanelTabPageTextEvents.Controls.Remove(textEventControl);
                textEventControl.Dispose();
            }
        }

        private static void DeleteAllTimeSignatureEventControlsByTrackNumber(int trackNumber)
        {
            foreach (var timeSignatureEventControl in AppSettings.TimeSignatureEventControls.Where(x => x.TimeSignatureEventProperties.Track == trackNumber))
            {
                AppSettings.TimeSignatureEventControls.Remove(timeSignatureEventControl);
                AppSettings.EditorsControl.flowLayoutPanelTabPageTimeSignatureEvents.Controls.Remove(timeSignatureEventControl);
                timeSignatureEventControl.Dispose();
            }
        }
        #endregion

        public static void OpenPlaybackForm()
        {
            PlaybackForm playbackForm = new PlaybackForm();
            playbackForm.ShowDialog();
        }

        #region ClearWorkplace
        public static void ClearWorkplace()
        {
            ClearAllTrackControls();
            ClearAllChannelControls();
            ClearAllPianoRollNotes();
            ClearAllChannelPressureEventControls();
            ClearAllControlChangeEventControls();
            ClearAllKeyPressureEventControls();
            ClearAllKeySignatureEventControls();
            ClearAllPitchBendEventControls();
            ClearAllProgramChangeEventControls();
            ClearAllSysExEventControls();
            ClearAllTempoChangeEventControls();
            ClearAllTextEventControls();
            ClearAllTimeSignatureEventControls();
        }

        private static void ClearAllTimeSignatureEventControls()
        {
            foreach (var timeSignatureEventControl in AppSettings.TimeSignatureEventControls)
            {
                AppSettings.EditorsControl.flowLayoutPanelTabPageTimeSignatureEvents.Controls.Remove(timeSignatureEventControl);
                timeSignatureEventControl.Dispose();
            }
            AppSettings.TimeSignatureEventControls.Clear();
        }

        private static void ClearAllTextEventControls()
        {
            foreach (var textEventControl in AppSettings.TextEventControls)
            {
                AppSettings.EditorsControl.flowLayoutPanelTabPageTextEvents.Controls.Remove(textEventControl);
                textEventControl.Dispose();
            }
            AppSettings.TextEventControls.Clear();
        }

        private static void ClearAllTempoChangeEventControls()
        {
            foreach (var tempoChangeEventControl in AppSettings.TempoChangeEventControls)
            {
                AppSettings.EditorsControl.flowLayoutPanelTabPageTempoChangeEvents.Controls.Remove(tempoChangeEventControl);
                tempoChangeEventControl.Dispose();
            }
            AppSettings.TempoChangeEventControls.Clear();
        }

        private static void ClearAllSysExEventControls()
        {
            foreach (var sysExEventControl in AppSettings.SysExEventControls)
            {
                AppSettings.EditorsControl.flowLayoutPanelTabPageSysExEvents.Controls.Remove(sysExEventControl);
                sysExEventControl.Dispose();
            }
            AppSettings.SysExEventControls.Clear();
        }

        private static void ClearAllProgramChangeEventControls()
        {
            foreach (var programChangeEventControl in AppSettings.ProgramChangeEventControls)
            {
                AppSettings.EditorsControl.flowLayoutPanelTabPageProgramChangeEvens.Controls.Remove(programChangeEventControl);
                programChangeEventControl.Dispose();
            }
            AppSettings.ProgramChangeEventControls.Clear();
        }

        private static void ClearAllPitchBendEventControls()
        {
            foreach (var pitchBendEventControl in AppSettings.PitchBendEventControls)
            {
                AppSettings.EditorsControl.flowLayoutPanelTabPagePitchBendEvents.Controls.Remove(pitchBendEventControl);
                pitchBendEventControl.Dispose();
            }
            AppSettings.PitchBendEventControls.Clear();
        }

        private static void ClearAllKeySignatureEventControls()
        {
            foreach (var keySignatureEventControl in AppSettings.KeySignatureEventControls)
            {
                AppSettings.EditorsControl.flowLayoutPanelTabPageKeySignatureEvents.Controls.Remove(keySignatureEventControl);
                keySignatureEventControl.Dispose();
            }
            AppSettings.KeySignatureEventControls.Clear();
        }

        private static void ClearAllKeyPressureEventControls()
        {
            foreach (var keyPressureEventControl in AppSettings.KeyPressureEventControls)
            {
                AppSettings.EditorsControl.flowLayoutPanelTabPageKeyPressureEvents.Controls.Remove(keyPressureEventControl);
                keyPressureEventControl.Dispose();
            }
            AppSettings.KeyPressureEventControls.Clear();
        }

        private static void ClearAllControlChangeEventControls()
        {
            foreach (var controlChangeEventControl in AppSettings.ControlChangeEventControls)
            {
                AppSettings.EditorsControl.flowLayoutPanelTabPageControlChangeEvents.Controls.Remove(controlChangeEventControl);
                controlChangeEventControl.Dispose();
            }
            AppSettings.ControlChangeEventControls.Clear();
        }

        private static void ClearAllChannelPressureEventControls()
        {
            foreach (var channelPressureEventControl in AppSettings.ChannelPressureEventControls)
            {
                AppSettings.EditorsControl.flowLayoutPanelTabPageChannelPressureEvents.Controls.Remove(channelPressureEventControl);
                channelPressureEventControl.Dispose();
            }
            AppSettings.ChannelPressureEventControls.Clear();
        }

        private static void ClearAllPianoRollNotes()
        {
            foreach (var note in AppSettings.PianoRollNotes)
            {
                AppSettings.PianoRollControl.Controls.Remove(note.Button);
                note.Button.Dispose();
            }
            AppSettings.PianoRollNotes.Clear();
        }

        private static void ClearAllChannelControls()
        {
            foreach (var channelControl in AppSettings.ChannelControls)
            {
                AppSettings.EditorsControl.flowLayoutPanelChannels.Controls.Remove(channelControl);
                channelControl.Dispose();
            }
            AppSettings.ChannelControls.Clear();
        }

        private static void ClearAllTrackControls()
        {
            foreach (var trackControl in AppSettings.TrackControls)
            {
                AppSettings.EditorsControl.flowLayoutPanelTracks.Controls.Remove(trackControl);
                trackControl.Dispose();
            }
            AppSettings.TrackControls.Clear();
        }
        #endregion

        public static void CreateNewMidiFile()
        {
            ClearWorkplace();

            for (int i = 0; i < 15; i++)
            {
                new ChannelControl(i, AppSettings.ChannelColors[i]);
            }

            new TrackControl(0, "Untitled track");

            AppSettings.IsFileCompiled = false;
            AppSettings.SaveStatus = false;
            AppSettings.PathMidiFile = "";

            AppTools.RefreshToolStripComboBoxTracks();

            foreach (var channel in AppSettings.ChannelControls)
            {
                AppSettings.MainForm.toolStripComboBoxChannels.Items.Add($@"Channel {channel.ChannelNumber}");
            }

            AppSettings.MainForm.toolStripComboBoxChannels.SelectedIndex = 0;
        }
    }
}
