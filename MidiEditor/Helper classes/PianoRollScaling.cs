namespace MidiEditor
{
    internal class PianoRollScaling
    {
        public static void ZoomIn_X()
        {
            if (AppSettings.XScale + 25 != 250)
            {
                AppSettings.XScale += 25;
                AppSettings.PianoRollControl.Refresh();
                AppSettings.TimelineControl.Refresh();
                AppSettings.PianoRollControl.ReDrawNotes();
            }

        }

        public static void ZoomOut_X()
        {
            if (AppSettings.XScale - 25 != 0)
            {
                AppSettings.XScale -= 25;
                AppSettings.PianoRollControl.Refresh();
                AppSettings.TimelineControl.Refresh();
                AppSettings.PianoRollControl.ReDrawNotes();
            }
        }

        public static void ZoomIn_Y()
        {
            if (AppSettings.YScale + 5 != 50)
            {
                AppSettings.YScale += 5;
                AppSettings.PianoRollControl.Refresh();
                AppSettings.TimelineControl.Refresh();
                AppSettings.PianoRollControl.ReDrawNotes();
            }
        }

        public static void ZoomOut_Y()
        {
            if (AppSettings.YScale - 5 != 0)
            {
                AppSettings.YScale -= 5;
                AppSettings.PianoRollControl.Refresh();
                AppSettings.TimelineControl.Refresh();
                AppSettings.PianoRollControl.ReDrawNotes();
            }
        }
    }
}
