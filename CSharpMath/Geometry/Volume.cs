using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMath.Geometry
{
    public class Volume
    {
        public static double VolumeOfCube(double side1, double side2, double side3)
        {
            double volumeCube = side1 + side2 + side3;
            return volumeCube;
        }

        public static double VolumeOfRectangularPrism(double length, double width, double height)
        {
            double volumeRectangularPrism = length * width * height;
            return volumeRectangularPrism;
        }

        public static double VolumeOfTriangularPrism(double baseSideA, double baseSideB, double baseSideC, double prismHeight)
        {
            double volumeTriangularPrism = (0.25 * prismHeight * Math.Sqrt(-Math.Pow(baseSideA, 4) + 2 * Math.Pow(baseSideA * baseSideB, 2) + 2 * Math.Pow(baseSideA * baseSideC, 2) - Math.Pow(baseSideB, 4) + 2 * Math.Pow(baseSideB * baseSideC, 2) - Math.Pow(baseSideC, 4)));
            return volumeTriangularPrism;
        }

        public static double VolumeOfTriangularPrismBaseAndHeight(double triangleBase, double triangleHeight, double prismHeight)
        {
            double volumeTriangularPrismBaseAndHeight = (triangleBase * triangleHeight * prismHeight) / 2;
            return volumeTriangularPrismBaseAndHeight;
        }

        public static double VolumeOfCylinder(double radius, double height)
        {
            double volumeCylinder = Math.PI * (radius * radius) * height;
            return volumeCylinder;
        }

        public static double VolumeOfCone(double radius, double height)
        {
            double volumeCone = Math.PI * (radius * radius) * (height / 3);
            return volumeCone;
        }

        public static double VolumeOfPyramid(double length, double width, double height)
        {
            double volumePyramid = (length * width * height) / 3;
            return volumePyramid;
        }

        public static double VolumeOfHemisphere(double radius)
        {
            double volumeHemisphere = (2 / 3) * Math.PI * (radius * radius * radius);
            return volumeHemisphere;
        }
    }
}
