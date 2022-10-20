using System.Drawing;
using System.Windows.Forms;

namespace MidiEditor
{
    public partial class TimelineControl : UserControl
    {
        public PictureBox GetPictureBoxTimeline() { return pictureBoxTimeline; }

        public TimelineControl()
        {
            InitializeComponent();
        }

        private void pictureBoxTimeline_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int numOfCells = (pictureBoxTimeline.Size.Width * pictureBoxTimeline.Size.Height) / (AppSettings.XScale * AppSettings.YScale);
            int xScale = AppSettings.XScale;
            Pen p = new Pen(Color.Black);

            for (int x = 0; x < numOfCells; ++x)
            {
                g.DrawLine(p, x * xScale, 0, x * xScale, numOfCells * xScale);

                //DateTime time = new DateTime();
                //g.DrawString(time.AddSeconds(x).ToString("HH:mm:ss"), this.Font, new SolidBrush(Color.Black), x * xScale, 0);
                var time = x * xScale;
                g.DrawString(time.ToString(), this.Font, new SolidBrush(Color.Black), x * xScale, 0);
            }
        }
    }
}
