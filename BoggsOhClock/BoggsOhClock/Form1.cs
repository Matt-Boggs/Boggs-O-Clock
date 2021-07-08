using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoggsOhClock
{
    public partial class Form1 : Form
    {
        public int MidX { get; set; }
        public int MidY { get; set; }
        public Point MidPt { get; set; }
        public Point DrawPt { get; set; }
        public Double Angle { get; set; }
        public int Length { get; set; }
        public Graphics ClockGraphics { get; set; }
        public Pen PenW { get; set; }
        public Pen PenB { get; set; }
        public Pen PenR { get; set; }
        public Pen PenHr { get; set; }
        public Brush Brush { get; set; }
        public Rectangle Rectangle { get; set; }

        public Form1()
        {
            InitializeComponent();

            //Set up and start the timer
            Timer ticktock = new Timer
            {
                Interval = 1000
            };
            ticktock.Tick += Ticktock_Tick;
            ticktock.Start();
            //ClockPanel.BackColor = Color.White;

            //Set up DrawLine parameters, Angle will be passed around for the three clock hands
            Length = ClockPanel.Height / 2;
            //Angle will be in radians (2Pi Radians is one circle)
            Angle = 0;
            MidX = ClockPanel.Width / 2;
            MidY = ClockPanel.Height / 2;
            MidPt = new Point(MidX, MidY);
            DrawPt = new Point(Convert.ToInt32(MidX + Math.Cos(Angle) * Length), Convert.ToInt32(MidY + Math.Sin(Angle) * Length));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Set up graphics area
            ClockGraphics = ClockPanel.CreateGraphics();
            ClockGraphics.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle = ClockPanel.ClientRectangle;

            //Set up Pens for hands, brush for bg
            PenB = new Pen(Color.Black,2);
            PenHr = new Pen(Color.Black, 4);
            PenW = new Pen(Color.White, 4);
            PenR = new Pen(Color.Red, 2);
            Brush = Brushes.White;

            //Fill in bg
            ClockGraphics.FillEllipse(Brush, Rectangle);
            ClockGraphics.DrawEllipse(PenB, Rectangle);
            //ClockGraphics.DrawLine(Pen,MidPt,DrawPt);

        }

        private void Ticktock_Tick(object sender, EventArgs e)
        {
            //Start with a whitefilled circle, then draw the hands on top of that
            ClockGraphics.FillEllipse(Brush, Rectangle);
            ClockGraphics.DrawEllipse(PenB, Rectangle);

            //TextBox Display
            var time = DateTime.Now;
            TimeDisplayBox.Text = time.ToString();

            //Draw hour hand
            //ClockGraphics.DrawLine(PenW, MidPt, DrawPt); //This method originally drew a white line over the previously made line
                    //30 : 360dg / 12hr = 30 dg
            Angle = ((30 * time.Hour - 90) * Math.PI / 180);
            DrawPt = new Point(Convert.ToInt32(MidX + Math.Cos(Angle) * Length), Convert.ToInt32(MidY + Math.Sin(Angle) * Length));
            ClockGraphics.DrawLine(PenHr, MidPt, DrawPt);

            //Draw minute hand
            //ClockGraphics.DrawLine(PenW, MidPt, DrawPt);
                    //6 : 360dg / 60Min = 6dg
            Angle = ((6 * time.Minute - 90) * Math.PI / 180);
            DrawPt = new Point(Convert.ToInt32(MidX + Math.Cos(Angle) * Length), Convert.ToInt32(MidY + Math.Sin(Angle) * Length));
            ClockGraphics.DrawLine(PenB, MidPt, DrawPt);

            //Draw Second Hand
            //ClockGraphics.DrawLine(PenW, MidPt, DrawPt);
                    //6 : 360dg / 60Sec = 6dg   
            Angle = ((6 * time.Second - 90) * Math.PI / 180);
            DrawPt = new Point(Convert.ToInt32(MidX + Math.Cos(Angle) * Length), Convert.ToInt32(MidY + Math.Sin(Angle) * Length));
            ClockGraphics.DrawLine(PenR, MidPt, DrawPt);

        }

    }
}
