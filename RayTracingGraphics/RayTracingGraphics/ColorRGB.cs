using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracingGraphics
{
    public class ColorRGB
    {
        public float R, G, B;
        public float scalar;
        public ColorRGB(float R, float G, float B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
        }
        public float add(float R, float G, float B)
        {
            return R + G + B;
        }
        public float scalarMult()
        {
            return scalar * R + scalar * G + scalar * B;
        }
    }
}
