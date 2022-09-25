using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiEditor
{
    public class SoundMaker
    {
        public static void PlaySound(int noteNumber, int velocity)
        {
            if (AppSettings.OutputDevice != null)
                AppSettings.OutputDevice.SendEvent(new NoteOnEvent((SevenBitNumber)noteNumber, (SevenBitNumber)velocity));
        }

        public static void StopSound(int noteNumber)
        {
            if (AppSettings.OutputDevice != null)
                AppSettings.OutputDevice.SendEvent(new NoteOffEvent((SevenBitNumber)noteNumber, (SevenBitNumber)0));
        }
    }
}
