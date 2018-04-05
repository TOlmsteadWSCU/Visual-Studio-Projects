using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracingGraphics
{
    public class Vector
    {
        public float x, y, z;
        public static float radius;
        public static Vector center;
        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }//Constructor
        public static Vector add(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }//add method
        public static Vector sub(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }//subtraction method
        public static Vector mult(Vector v1, Vector v2)
        {
            return new Vector(v1.z * v2.x, v1.y * v2.y, v1.z * v2.z);
        }//multiply method
        public static Vector div(Vector v1, float k)
        {
            return new Vector(v1.x / k, v1.y / k, v1.z / k);
        }//division method
        public static Vector normalize(Vector v, float b)
        {
            b = length(v);
            return div(v, b);
        }
        public static float length(Vector p1)
        {
            return (float)(Math.Sqrt((p1.x * p1.x) + (p1.y * p1.y) + (p1.z * p1.z)));
        }
        public double dotProduct(Vector p1, Vector p2)
        {
            return p1.x * p2.x + p1.y * p2.y + p1.z * p2.z;
        }
        public static float crossProduct(Vector p1, Vector p2)
        {
            return (p1.x * p2.y) + (p1.x * p2.z) + (p1.y * p2.z) + (p1.z * p2.y) + (p1.z * p2.x);
        }

    }
}
