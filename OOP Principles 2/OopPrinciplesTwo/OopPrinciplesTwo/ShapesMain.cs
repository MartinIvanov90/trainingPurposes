using OopPrinciplesTwo.Abstract;
using OopPrinciplesTwo.Bussines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main()
        {
            Shape[] shapesArr = new Shape[3];
            shapesArr[0] = new Rectangle(4, 5);
            shapesArr[1] = new Triangle(4, 4);
            shapesArr[2] = new Square(7, 7);
            foreach(Shape shape in shapesArr)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
