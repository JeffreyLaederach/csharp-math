using System;

using CSharpMath.Geometry;
using CSharpMath.Trigonometry;

namespace CSharpMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example Usage: Calculate and display the perimeter of a square
            double squareSide = 5; 
            double squarePerimeter = Perimeter.PerimeterOfSquare(squareSide); 
            Console.WriteLine($"The perimeter of a square with side {squareSide} is {squarePerimeter}.");
        }
    }
}