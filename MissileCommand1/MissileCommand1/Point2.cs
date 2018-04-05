using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileCommand1
{
    public class Point2
    {
        public float x = 0;
        public float y = 0;

        public Point2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Point2 add(Point2 p)
        {
            return new Point2(this.x + p.x, this.y + p.y);
        }

        public Point2 sub(Point2 p)
        {
            return new Point2(this.x - p.x, this.y - p.y);
        }

        public double dist(Point2 p)
        {
            return Math.Sqrt(Math.Pow(this.x - p.x, 2) + Math.Pow(this.y - p.y, 2));
        }

        public String toString()
        {
            return ("(" + this.x + ", " + this.y + ")");
        }
    }
}
