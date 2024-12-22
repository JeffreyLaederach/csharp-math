using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMath.Geometry
{
    public class SurfaceArea
    {
        public static double SurfaceAreaOfCube(double side)
        {
            double surfaceAreaCube = 6 * Math.Pow(side, 2);
            return surfaceAreaCube;
        }

        public static double SurfaceAreaOfRectangularPrism(double length, double width, double height)
        {
            double surfaceAreaRectangularPrism = 2 * (width * length + height * length + height * width);
            return surfaceAreaRectangularPrism;
        }

        public static double SurfaceAreaOfTriangularPrism(double baseSideA, double baseSideB, double baseSideC, double prismHeight)
        {
            double surfaceAreaTriangularPrism = baseSideA * prismHeight + baseSideB * prismHeight + baseSideC * prismHeight + 0.5 * Math.Sqrt(-Math.Pow(baseSideA, 4) + 2 * Math.Pow(baseSideA * baseSideB, 2) + 2 * Math.Pow(baseSideA * baseSideC, 2) - Math.Pow(baseSideB, 4) + 2 * Math.Pow(baseSideB * baseSideC, 2) - Math.Pow(baseSideC, 4));
            return surfaceAreaTriangularPrism;
        }

        public static double SurfaceAreaOfCylinder(double radius, double height)
        {
            double surfaceAreaCylinder = 2 * Math.PI * radius * (radius + height);
            return surfaceAreaCylinder;
        }

        public static double SurfaceAreaOfCone(double radius, double height)
        {
            double surfaceAreaCone = Math.PI * radius * (radius + Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius, 2)));
            return surfaceAreaCone;
        }

        public static double SurfaceAreaOfPyramid(double length, double width, double pyramidHeight)
        {
            double surfaceAreaPyramid = length * width + length * Math.Sqrt(Math.Pow(width / 2, 2) + Math.Pow(pyramidHeight, 2)) + width * Math.Sqrt(Math.Pow(length / 2, 2) + Math.Pow(pyramidHeight, 2));
            return surfaceAreaPyramid;
        }

        public static double SurfaceAreaOfHemisphere(double radius)
        {
            double surfaceAreaHemisphere = 3 * Math.PI * Math.Pow(radius, 2);
            return surfaceAreaHemisphere;
        }
    }
}
