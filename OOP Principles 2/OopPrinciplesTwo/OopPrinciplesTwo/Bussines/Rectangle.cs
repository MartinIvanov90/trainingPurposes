using System;
using OopPrinciplesTwo.Abstract;

namespace OopPrinciplesTwo.Bussines
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return (Height * Width)/2;
        }
    }
}
