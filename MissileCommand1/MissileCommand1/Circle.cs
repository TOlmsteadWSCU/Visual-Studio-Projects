using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileCommand1
{
    public class Circle : GObj
    {
        public Point2 center;
        public float r;
        public Color c;

        public Circle(Point2 center, float r, Color c)
        {
            this.center = center;
            this.r = r;
            this.c = c;
        }

        public override void display(Graphics g)
        {
            SolidBrush br = new SolidBrush(c);
            g.FillEllipse(br, center.x - r, center.y - r, r * 2, r * 2);
        }
    }
}
