using Jungle.Interfaces;
using Jungle.Enums;
using System;

namespace Jungle.Abstract
{
    public abstract class Animals : ISound
    {
        private readonly string name;
        private int age;
        private readonly AnimalsSex animalsSex;

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException($"Age cannot be negative!");
                }
                this.age = value;
            }
        }

        public Animals(string name, int age, AnimalsSex sex)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"Name cannot be blank!");
            }
            
            this.name = name;
            this.Age = age;
            this.animalsSex = sex;
        }

        public abstract string SaySomething();
        public override string ToString()
        {
            return $"{this.name}\n{this.Age}\n{this.animalsSex}\n";
        }
    }
}
