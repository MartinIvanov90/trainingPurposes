using Jungle.Enums;
using Jungle.Abstract;

namespace Jungle.Bussines
{
    public class Frog : Animals
    {
        public Frog(string name, int age, AnimalsSex sex) : base(name, age, sex)
        {

        }

        public override string SaySomething()
        {
            return "Ribbit!";
        }
        public override string ToString()
        {
            return base.ToString() + SaySomething();
        }
    }
}
