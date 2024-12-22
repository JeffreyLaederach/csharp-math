using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMath.Geometry
{
    public class Distance2D
    {
        public static double CoordinateDistance2D(double x1, double x2, double y1, double y2) // 2-Dimensional Cartesian Plane Coordinate System
        {
            double coordinateDistance2D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // Euclidean Method
            return coordinateDistance2D;
        }
    }
}
