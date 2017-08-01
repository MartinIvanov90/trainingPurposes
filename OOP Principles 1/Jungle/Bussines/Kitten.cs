using Jungle.Abstract;
using Jungle.Enums;

namespace Jungle.Bussines
{
    public class Kitten : Cats
    {
        public Kitten(string name, int age, FurColor furColor) : base(name, age, AnimalsSex.female, furColor)
        {
        }

        public override string SaySomething()
        {
            return "Purrrr!";
        }
        public override string ToString()
        {
            return base.ToString() + SaySomething();
        }
    }
}
