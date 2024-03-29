﻿using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;

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
