using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiEditor
{
    public class EventProperties
    {
        [Description("Event start time.\nIn simple terms, this is the location of the event on the X axis.")]
        [Category("Event")]
        public int Time { get; set; }

        [Description("Event Duration. \nIn simple terms, this is the event length.")]
        [Category("Event")]
        public int Duration { get; set; }

        [Description("Event note number. \nIn simple terms, this is the placement of the event on the Y axis.")]
        [Category("Event")]
        public int Note { get; set; }

        [Description("Volume level.")]
        [Category("Event")]
        public int Velocity { get; set; }

        [Description("Event channel number.")]
        [Category("Event")]
        public int Channel { get; set; }

        [Description("Event track number.")]
        [Category("Event")]
        public int Track { get; set; }

        [Browsable(false)]
        public Button Button { get; set; }

        [Browsable(false)]
        public bool Hide { get; set; }
    }
}
