using System;
using OopPrinciplesTwo.Abstract;

namespace OopPrinciplesTwo.Bussines
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return Height * Width;
        }
    }
}
