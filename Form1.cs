using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centro = PBOXclock.Location.X + (PBOXclock.Size.Width / 2);
            raio = (PBOXclock.Size.Width / 2 - 70);

            Tseg.Start();
            sw.Start();
        }
        private bool start = true;

        private const double pi = 3.14159265359;
        private const double piMeio = 3.14159265359 / 2;
        int centro = 0;
        double raio = 0;

        double t = 0;
        double sen = 0;
        double cos = 0;

        private readonly Stopwatch sw = new Stopwatch();

        private TimeSpan time = DateTime.Now.TimeOfDay;
        private void Tseg_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now.TimeOfDay;
            t = time.Seconds * pi / 30  - piMeio;
            sen = Math.Sin(t);
            cos = Math.Cos(t);

            LABsec1.Location = new Point((int)(centro + raio * cos), (int)(centro + raio * sen));
            LABsec2.Location = new Point((int)(centro + (raio - 30) * cos), (int)(centro + (raio - 30) * sen));
            LABsec3.Location = new Point((int)(centro + (raio - 60) * cos), (int)(centro + (raio - 60) * sen));
            LABsec4.Location = new Point((int)(centro + (raio - 90) * cos), (int)(centro + (raio - 90) * sen));
            LABsec5.Location = new Point((int)(centro + (raio - 120) * cos), (int)(centro + (raio - 120) * sen));
            LABsec6.Location = new Point((int)(centro + (raio - 150) * cos), (int)(centro + (raio - 150) * sen));

            LABsec1.Text = LABsec2.Text = LABsec3.Text = LABsec4.Text = LABsec5.Text = LABsec6.Text = time.Seconds.ToString();



            if (start || time.Seconds == 0)
            {

                t = time.Minutes * pi / 30 - piMeio;
                sen = Math.Sin(t);
                cos = Math.Cos(t);

                LABmin1.Location = new Point((int)(centro + (raio - 30) * cos), (int)(centro + (raio - 30) * sen));
                LABmin2.Location = new Point((int)(centro + (raio - 60) * cos), (int)(centro + (raio - 60) * sen));
                LABmin3.Location = new Point((int)(centro + (raio - 90) * cos), (int)(centro + (raio - 90) * sen));
                LABmin4.Location = new Point((int)(centro + (raio - 120) * cos), (int)(centro + (raio - 120) * sen));
                LABmin5.Location = new Point((int)(centro + (raio - 150) * cos), (int)(centro + (raio - 150) * sen));

                LABmin1.Text = LABmin2.Text = LABmin3.Text = LABmin4.Text = LABmin5.Text = time.Minutes.ToString();

                if (start || time.Minutes == 0)
                {
                    t = time.TotalHours * pi / 6 - piMeio;
                    sen = Math.Sin(t);
                    cos = Math.Cos(t);

                    LABhor1.Location = new Point((int)(centro + (raio - 90) * cos), (int)(centro + (raio - 90) * sen));
                    LABhor2.Location = new Point((int)(centro + (raio - 120) * cos), (int)(centro + (raio - 120) * sen));
                    LABhor3.Location = new Point((int)(centro + (raio - 150) * cos), (int)(centro + (raio - 150) * sen));

                    LABhor1.Text = LABhor2.Text = LABhor3.Text = time.Hours.ToString();

                    start = false;
                }
            }
            LABtime.Text = time.ToString();
        }
    }
}
