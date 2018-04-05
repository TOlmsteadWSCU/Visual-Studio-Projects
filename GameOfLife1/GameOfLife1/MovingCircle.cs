using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife1
{
    public class MovingCircle : Circle
    {
        public Point2 velocity;

        public MovingCircle(Color c, Point2 start, float r, Point2 velocity) : base(start, r, c)
        {
            this.velocity = velocity;
        }

        public override List<GObj> move()
        {
            center = center.add(velocity);
            return base.move();
        }
    }
}
