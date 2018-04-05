using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracingGraphics
{
    public interface Skin
    {
        RColor color(P3 p, Ray r, SceneObject o);
    }
}
