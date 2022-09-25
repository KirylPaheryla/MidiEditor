using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiEditor
{
    internal class Scaling
    {
        public static void ZoomIn_X()
        {
            AppSettings.XScale += 25;
            AppSettings.PianoRollControl.Refresh();
            AppSettings.TimelineControl.Refresh();
        }

        public static void ZoomOut_X()
        {
            AppSettings.XScale -= 25;
            AppSettings.PianoRollControl.Refresh();
            AppSettings.TimelineControl.Refresh();
            AppSettings.PianoRollControl.ReDrawNotes();
        }

        public static void ZoomIn_Y()
        {

        }

        public static void ZoomOut_Y()
        {

        }
    }
}
