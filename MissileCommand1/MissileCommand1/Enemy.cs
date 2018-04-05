using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileCommand1
{
    public class Enemy : GObj
    {
        int delay = 0;
        public int aim;
        Random random1 = new Random();

        public override List<GObj> move()
        {
            List<GObj> r = base.move();
            if (delay <= 0)
            {
                delay = random1.Next(1, 20);
                aim = (random1.Next(7) + 1) * 100;
                r.Add(new Shell(Color.White, random1.Next(800), aim, 3));

            }
            delay = delay - 1;
            return r;
        }
        public override void display(Graphics g) { }

    }
}
