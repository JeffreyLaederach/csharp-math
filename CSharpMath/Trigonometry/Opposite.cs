using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMath.Trigonometry
{
    public class Opposite // theta is in radians
    {
        public static double FindOppositeSideLengthSine(double theta, double hypotenuseLength)
        {
            double oppositeSideLength = Math.Sin(theta) * hypotenuseLength;
            return oppositeSideLength;
        }

        public static double FindOppositeSideLengthTangent(double theta, double adjacentSideLength)
        {
            double oppositeSideLength = Math.Tan(theta) * adjacentSideLength;
            return oppositeSideLength;
        }
    }
}
