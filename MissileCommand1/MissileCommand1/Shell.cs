using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileCommand1
{
    public class Shell : MovingCircle
    {
        public Color tail;
        public float topX;
        public bool dead = false;
        public Shell(Color tail, float topX, float bottomX, float v)
            : base(Color.White, new Point2(topX, 0), 2, new Point2(bottomX - topX, 380))
        {
            this.topX = topX;
            this.tail = tail;
            float h = (float)Math.Sqrt(Math.Pow(topX - velocity.x, 2) + Math.Pow(380, 2));
            velocity.x *= v;
            velocity.y *= v;
            velocity.x /= h;
            velocity.y /= h;
        }

        public override void display(Graphics g)
        {
            Pen p = new Pen(Color.White, 2);
            g.DrawLine(p, topX, 0, center.x + r, center.y + r);
            base.display(g);
        }

        public override List<GObj> move()
        {
            List<GObj> r = base.move();
            if (center.y > 400 || dead)
            {
                r = new List<GObj>();
            }
            return r;
        }
        public override void interact(GObj o)
        {
            if (o.hit(center))
            { dead = true; }
        }
        public override void envelop(Point2 p, double r)
        {
            float dist = (float)p.dist(center);
            if (dist < r)
            {
                Form1.score++;
                dead = true;
            }
        }
    }
}
