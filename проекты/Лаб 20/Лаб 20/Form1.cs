using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб_20
{
    public partial class Form1 : Form
    {
        private int x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6, x7, y7, r;
        private double a,b,c,d,ee,f;
        private Pen pen = new Pen(Color.DarkRed, 2);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            pen = new Pen(Color.DarkRed, 2);
            SolidBrush solidBrush = new SolidBrush(Color.Purple);
            e.Graphics.FillEllipse(solidBrush, x1 - 50, y1 - 50, 100, 100);
            pen = new Pen(Color.Gray, 2);
            g.DrawLine(pen, x1, y1, x2, y2);
            g.DrawLine(pen, x1, y1, x3, y3);
            g.DrawLine(pen,x2,y2,x3,y3);

            g.DrawLine(pen, x1, y1, x4, y4);
            g.DrawLine(pen, x1, y1, x5, y5);
            g.DrawLine(pen, x4, y4, x5, y5);

            g.DrawLine(pen, x1, y1, x6, y6);
            g.DrawLine(pen, x1, y1, x7, y7);
            g.DrawLine(pen, x6, y6, x7, y7);
            
    }
        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            r = 150;
            a = 0;
            b = -1;

            c = -2;
            d = -3;

            ee = -4;
            f = -5;
            ;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            x3 = x1 + (int)(r * Math.Cos(b));
            y3 = y1 - (int)(r * Math.Sin(b));

            x4 = x1 + (int)(r * Math.Cos(c));
            y4 = y1 - (int)(r * Math.Sin(c));
            x5 = x1 + (int)(r * Math.Cos(d));
            y5 = y1 - (int)(r * Math.Sin(d));

            x6 = x1 + (int)(r * Math.Cos(ee));
            y6 = y1 - (int)(r * Math.Sin(ee));
            x7 = x1 + (int)(r * Math.Cos(f));
            y7 = y1 - (int)(r * Math.Sin(f));
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            while (timer1.Interval > 17) timer1.Interval -= 1;
            a -= 0.2;
            b -= 0.2;
            c -= 0.2;
            d -= 0.2;
            ee -= 0.2;
            f -= 0.2;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            x3 = x1 + (int)(r * Math.Cos(b));
            y3 = y1 - (int)(r * Math.Sin(b));

            x4 = x1 + (int)(r * Math.Cos(c));
            y4 = y1 - (int)(r * Math.Sin(c));
            x5 = x1 + (int)(r * Math.Cos(d));
            y5 = y1 - (int)(r * Math.Sin(d));

            x6 = x1 + (int)(r * Math.Cos(ee));
            y6 = y1 - (int)(r * Math.Sin(ee));
            x7 = x1 + (int)(r * Math.Cos(f));
            y7 = y1 - (int)(r * Math.Sin(f));
            Invalidate();
        }
    }
}
