using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireFrameGraphics
{
    public class Line
    {
        public float x, y, z;
        public Point start;
        public Point end;
        public Color c;
        public float width;
        public Line(Point start, Point end, float width, Color c)
        {
            this.start = start;//new Point(x, y, z);
            this.end = end;// new Point(x, y, z);
            this.width = width;
            this.c = c;
        }
        public void paint(Graphics g, Matrix m)
        {
            Pen pen = new Pen(c, width);
            Point start1 = m.multPoint(start);
            Point end1 = m.multPoint(end);
            //g.DrawLine(pen, 0,0,50,50);
           // g.DrawLine(pen, start.x, start.y, end.x, end.y);
            
            g.DrawLine(pen, start1.x + 200, start1.y + 200, end1.x + 200, end1.y + 200);
            

        }
        //color
        //list of points
        //draw function--- think of bezier drawing for lines
    }
}
