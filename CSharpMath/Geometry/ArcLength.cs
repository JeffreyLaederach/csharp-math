using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMath.Geometry
{
    public class ArcLength
    {
        public static double ArcLengthRadians(double radius, double centralAngleRadians)
        {
            double arcLength = centralAngleRadians * radius;
            return arcLength;
        }

        public static double ArcLengthDegrees(double radius, double centralAngle)
        {
            double arcLength = 2 * Math.PI * radius * (centralAngle / 360);
            return arcLength;
        }
    }
}
