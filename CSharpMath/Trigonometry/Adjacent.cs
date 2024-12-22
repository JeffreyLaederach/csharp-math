using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMath.Trigonometry
{
    public class Adjacent // theta is in radians
    {
        public static double FindAdjacentSideLengthCosine(double theta, double hypotenuseLength)
        {
            double adjacentSideLength = Math.Cos(theta) * hypotenuseLength;
            return adjacentSideLength;
        }

        public static double FindAdjacentSideLengthTangent(double theta, double oppositeSideLength)
        {
            double adjacentSideLength = oppositeSideLength / Math.Tan(theta);
            return adjacentSideLength;
        }
    }
}
