using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife1
{
    public class Rectangle : GObj
    {
        public Point2 grab;
        public float width;
        public float height;
        public Color c;

        public Rectangle(Point2 grab, float width, float height, Color c)
        {
            this.grab = grab;
            this.width = width;
            this.height = height;
            this.c = c;
        }

        public override void display(Graphics g)
        {
            SolidBrush br = new SolidBrush(c);
            g.FillRectangle(br, grab.x - width / 2, grab.y - height, width, height);
        }
    }
}
