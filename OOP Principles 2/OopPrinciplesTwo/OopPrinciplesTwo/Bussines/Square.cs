using System;
using OopPrinciplesTwo.Abstract;

namespace OopPrinciplesTwo.Bussines
{
    public class Square : Shape
    {
        public Square(double width, double height) : base(width, height)
        {
            if(height != width)
            {
                throw new ArgumentException($"width and height must be equal in a square!");
            }
        }

        public override double CalculateSurface()
        {
            return Height * Width;
        }
    }
}
