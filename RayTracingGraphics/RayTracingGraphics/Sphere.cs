﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracingGraphics
{
    public class Sphere : Geometry
    {
        public float rad;
        P3 center;
        public Sphere(P3 center, float rad)
        {
            this.rad = rad;
            this.center = center;
        }
        public float intersect(Ray r)
        {
            float d;
            P3 e = r.origin;
            P3 o = center;
            P3 v = r.direction;
            P3 eo = o.sub(e);
            float v1 = eo.dot(v);
            float disc = (float)(Math.Pow(rad, 2) - ((eo.dot(eo)) - (Math.Pow(v1, 2))));
            if (disc < 0)
                return -1;
            else
            {
                d = (float)(Math.Sqrt(disc));
                return v1 - d;
            }
        }//intersect method

        public P3 normal(P3 p)
        {
            throw new NotImplementedException();
            //vector point to the center and normalize it
        }

        public P2 toP2(P3 p)
        {
            throw new NotImplementedException();
        }
    }
}
