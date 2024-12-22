using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMath.Geometry
{
    public class Distance3D
    {
        public static double CoordinateDistance3D(double x1, double x2, double y1, double y2, double z1, double z2) // 3-Dimensional Cartesian Plane Coordinate System
        {
            double coordinateDistance3D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); // Euclidean Method
            return coordinateDistance3D;
        }
    }
}
