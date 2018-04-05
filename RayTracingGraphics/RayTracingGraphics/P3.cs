using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracingGraphics
{
    public class P3
    {
        public float x, y, z;
        public P3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }//Constructor
        public P3 add(P3 p)
        {
            return new P3(x + p.x, y + p.y, z + p.z);
        }//add method
        public P3 sub(P3 p)
        {
            return new P3(x - p.x, y - p.y, z - p.z);
        }//subtraction method
        public float abs()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
        public P3 mul(float d)
        {
            return new P3(x * d, y * d, z * d);
        }//multiply method
        public P3 rmul(float d)
        {
            return new P3(x * d, y * d, z * d);
        }//rmul method
        public P3 norm()
        {
            double d = abs();
            if (d == 0)
            {
                return new P3(0, 0, 0);
            }
            return rmul((float)(1 / d));
        }//norm method
        public float dot(P3 p)
        {
            return x * p.x + y * p.y + z * p.z;
        }//dot product method
        public P3 cross(P3 p)
        {
            return new P3(y * p.z - z * p.y, z * p.x - x * p.z, x * p.y - y * p.x);
        }
        public String toString()
        {
            return "(" + x + ", " + y + ", " + z + ")";
        }//toString
    }
}
