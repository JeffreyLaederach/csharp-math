using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMath.Geometry
{
    public class Perimeter
    {
        public static double PerimeterOfSquare(double side)
        {
            double perimeterSquare = 4 * side;
            return perimeterSquare;
        }

        public static double PerimeterOfRectangle(double length, double width)
        {
            double perimeterRectangle = 2 * (length + width);
            return perimeterRectangle;
        }

        public static double PerimeterOfTriangle(double sideA, double sideB, double sideC)
        {
            double perimeterTriangle = sideA + sideB + sideC;
            return perimeterTriangle;
        }

        public static double PerimeterOfCircle(double radius)
        {
            double perimeterCircle = 2 * Math.PI * radius;
            return perimeterCircle;
        }
    }
}
