using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayTracingGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public static P3 cameraPosition = new P3(0, -5, 0);
        public const int pixels = 100;
        public static RColor[,] image = new RColor[pixels, pixels];
        public void shootRay()
        {

        }

        public void traceRays()
        {
            for (int i = 0; i < pixels; i++)
            {
                for (int j = 0; j < pixels; j++)
                {
                    P3 projPoint = new P3((float)(2 * (((float)i) / pixels - 0.5)), 0, (float)(2 * (((float)j) / pixels - 0.5)));
                    P3 dir = projPoint.sub(cameraPosition).norm();
                    Ray r = new Ray(cameraPosition, dir);
                    float dist;
                    SceneObject o = shootRay(r, out dist);  // You need to write shootRay.  -1 indicates that no object was intersected.
                    if (dist == -1)
                    {
                        image[i, j] = new RColor(0, 0, 0);
                    }
                    else
                    {

                        P3 p = r.travel(dist);
                        image[i, j] = o.color(p, r);
                    }


                }
            }
        }
    }
}
