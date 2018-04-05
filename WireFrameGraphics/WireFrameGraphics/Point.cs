using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireFrameGraphics
{
    public class Point
    {
        public Color color;
        //x,y,z coord
        public float x, y, z;
        public Point(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.color = new Color();
        }

    }
}
