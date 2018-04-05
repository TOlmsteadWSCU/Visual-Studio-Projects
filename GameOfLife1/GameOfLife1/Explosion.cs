using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife1
{
    public class Explosion : Circle
    {
        public Explosion(Point2 p) : base(p, 2, Color.DarkOrange) { }


        public override List<GObj> move()
        {
            List<GObj> r = base.move();
            base.r = base.r + 2;
            if (base.r > 65)
            {
                r = new List<GObj>();

            }

            return r;

        }
        public override void interact(GObj o)
        {
            o.envelop(this.center, this.r);

        }
    }
}
