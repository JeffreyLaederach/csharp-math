using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMath.Trigonometry
{
    public class PythagoreanTheorem
    {
        public static double LengthOfHypotenuse(double triangleBase, double triangleHeight)
        {
            double hypotenuseLength = Math.Sqrt(triangleBase * triangleBase + triangleHeight * triangleHeight);
            return hypotenuseLength;
        }

        public static double LengthOfRightTriangleBase(double hypotenuseLength, double triangleHeight)
        {
            double triangleBase = Math.Sqrt(hypotenuseLength * hypotenuseLength - triangleHeight * triangleHeight);
            return triangleBase;
        }

        public static double LengthOfRightTriangleHeight(double hypotenuseLength, double triangleBase)
        {
            double triangleHeight = Math.Sqrt(hypotenuseLength * hypotenuseLength - triangleBase * triangleBase);
            return triangleHeight;
        }
    }
}
