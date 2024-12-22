using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMath.Geometry
{
    public class Area
    {
        public static double AreaOfSquare(double side)
        {
            var areaSquare = side * side;
            return areaSquare;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            var areaRectangle = length * width;
            return areaRectangle;
        }

        public static double AreaOfTriangle(double side1, double side2, double side3) // Heron's Formula
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            double areaTriangle = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
            return areaTriangle;
        }

        public static double AreaOfTriangleBaseAndHeight(double triangleBase, double triangleHeight)
        {
            double areaTriangleBaseAndHeight = (triangleBase * triangleHeight) / 2;
            return areaTriangleBaseAndHeight;
        }

        public static double AreaOfCircle(double radius)
        {
            double areaCircle = Math.PI * radius * radius;
            return areaCircle;
        }

        public static double AreaOfSemicircle(double radius)
        {
            double areaSemicircle = (Math.PI * radius * radius) / 2;
            return areaSemicircle;
        }

        public static double AreaOfTrapezoid(double trapezoidBase1, double trapezoidBase2, double trapezoidHeight)
        {
            double areaTrapezoid = ((trapezoidBase1 + trapezoidBase2) / 2) * trapezoidHeight;
            return areaTrapezoid;
        }

        public static double AreaOfParallelogram(double parallelogramBase, double parallelogramHeight)
        {
            double areaParallelogram = (parallelogramBase * parallelogramHeight);
            return areaParallelogram;
        }

        public static double AreaOfEllipse(double ellipseLengthOfSemiMajorAxis, double ellipseLengthOfSemiMinorAxis)
        {
            double areaEllipse = Math.PI * ellipseLengthOfSemiMajorAxis * ellipseLengthOfSemiMinorAxis;
            return areaEllipse;
        }
    }
}
