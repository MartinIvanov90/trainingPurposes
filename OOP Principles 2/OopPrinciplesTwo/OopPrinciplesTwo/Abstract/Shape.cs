using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciplesTwo.Abstract
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException($"value cannot be negative!");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"value cannot be negative!");
                }
                this.height = value;
            }
        }

        public Shape(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        public abstract double CalculateSurface();
    }
}
