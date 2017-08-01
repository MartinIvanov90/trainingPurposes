using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jungle.Enums;

namespace Jungle.Abstract
{
    public abstract class Cats : Animals
    {
        private FurColor furColor;

        public Cats(string name, int age, AnimalsSex sex, FurColor furColor) : base(name, age, sex)
        {
            this.furColor = furColor;
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.furColor}\n";
        }

    }
}
