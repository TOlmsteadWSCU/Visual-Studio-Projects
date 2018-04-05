using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireFrameGraphics
{
    public class Circle
    {
        public Point center;
        public float r;
        public Color color1;
        public Circle(Point center, Color color1, float r)
        {
            this.center = center;
            this.r = r;
            this.color1 = color1;
        }
        public void paint(Graphics g)
        {
            SolidBrush brush = new SolidBrush(color1);
            g.FillEllipse(brush, center.x - r, center.y - r, r * 2, r * 2);
        }
    }
}
