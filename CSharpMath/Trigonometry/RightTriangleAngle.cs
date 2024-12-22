using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMath.Trigonometry
{
    public class RightTriangleAngle
    {
        // Using Inverse Trig Functions (sin^-1, cos^-1, tan^-1) to compute the value of angle theta in radians: 
        public static double FindAngleUsingArcsine(double oppositeSideLength, double hypotenuseLength)
        {
            double theta = Math.Asin(oppositeSideLength / hypotenuseLength);
            return theta;
        }

        public static double FindAngleUsingArccosine(double adjacentSideLength, double hypotenuseLength)
        {
            double theta = Math.Acos(adjacentSideLength / hypotenuseLength);
            return theta;
        }

        public static double FindAngleUsingArctangent(double oppositeSideLength, double adjacentSideLength)
        {
            double theta = Math.Atan(oppositeSideLength / adjacentSideLength);
            return theta;
        }
    }
}
