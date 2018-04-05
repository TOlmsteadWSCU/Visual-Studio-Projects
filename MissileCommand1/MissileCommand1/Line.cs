using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileCommand1
{
    public class Line : GObj
    {
        public Point2 start;
        public Point2 end;
        public float width;
        public Color c;

        public Line(Point2 start, Point2 end, float width, Color c)
        {
            this.start = start;
            this.end = end;
            this.width = width;
            this.c = c;
        }

        public override void display(Graphics g)
        {
            Pen p = new Pen(c, width);
            g.DrawLine(p, start.x, start.y, end.x, end.y);
        }
    }
}
