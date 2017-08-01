using Jungle.Enums;
using Jungle.Abstract;

namespace Jungle.Bussines
{
    public class Dog : Animals
    {
        public Dog(string name, int age, AnimalsSex sex) : base(name, age, sex)
        {

        }

        public override string SaySomething()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            return base.ToString() + SaySomething();
        }
    }
}