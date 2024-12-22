using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMath.Trigonometry
{
    public class Hypotenuse // theta is in radians
    {
        public static double FindHypotenuseLengthSine(double theta, double oppositeSideLength)
        {
            double hypotenuseLength = oppositeSideLength / Math.Sin(theta);
            return hypotenuseLength;
        }

        public static double FindHypotenuseLengthCosine(double theta, double adjacentSideLength)
        {
            double hypotenuseLength = adjacentSideLength / Math.Cos(theta);
            return hypotenuseLength;
        }
    }
}
