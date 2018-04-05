using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife1
{
    public class Missile : MovingCircle
    {
        public float time;
        public Point2 target;

        public Missile(Point2 start, Point2 target)
            : base(Color.Yellow, start, 2, new Point2(target.x - start.x, target.y - start.y))
        {
            float b = (float)start.dist(target);
            this.time = b / 20;
            this.velocity.x *= 20;
            this.velocity.y *= 20;
            this.velocity.x /= b;
            this.velocity.y /= b;

            this.target = target;

        }
        public override List<GObj> move()
        {

            List<GObj> r = new List<GObj>();
            if (time > 0)
            {
                r.AddRange(base.move());
                time--;
                return r;
            }

            r = new List<GObj>();
            r.Add(new Explosion(target));
            return r;
        }
    }
}
