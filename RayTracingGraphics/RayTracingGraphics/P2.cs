using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracingGraphics
{
    public class P2
    {
        public float x, y;
        public P2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public String toString()
        {
            return "(" + x + "," + y + ")";
        }
    }
}
