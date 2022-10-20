using MidiEditor.UserControls;
using System.Linq;

namespace MidiEditor
{
    internal class AppTools
    {
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
