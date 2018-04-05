using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileCommand1
{
    public class Launcher : Rectangle
    {
        public static bool g = false;
        public Launcher(Color c, double center) : base(new Point2((float)(center), 400), 20, 10, c)
        {
        }

        public override bool hit(Point2 p)
        {
            float x = grab.x - width / 2;
            float y = grab.y - height;
            if (p.x >= x && p.x <= x + width && p.y >= y && p.y <= y + height)
            {
                g = true;
                return true;
            }
            return false;
        }
        public override List<GObj> move()
        {
            if (g)
            {
                new List<GObj>();
            }
            return base.move();
        }
    }
}
