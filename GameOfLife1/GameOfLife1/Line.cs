using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife1
{
    public class Line : GObj
    {
        public Point2 start;
        public Point2 end;
        public float width;
        //public Color c;
        public Random rc = new Random();
        public Color[] c = new Color[] { Color.Blue, Color.Black, Color.Orange, Color.Aqua, Color.Brown, Color.Gold };
        public Line(Point2 start, Point2 end, float width, Color c)
        {
            this.start = start;
            this.end = end;
            this.width = width;
            //this.c = c;
        }

        public override void display(Graphics g)
        {
            int randomColor = rc.Next(6);
            Pen p = new Pen(c[randomColor], width);
            g.DrawLine(p, start.x, start.y, end.x, end.y);
        }
    }
}
