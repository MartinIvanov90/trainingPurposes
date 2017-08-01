using Jungle.Abstract;
using Jungle.Enums;

namespace Jungle.Bussines
{
    public class TomCat : Cats
    {
        public TomCat(string name, int age, FurColor furColor) : base(name, age, AnimalsSex.male, furColor)
        {
        }

        public override string SaySomething()
        {
            return "RAWR!";
        }
        public override string ToString()
        {
            return base.ToString() + SaySomething();
        }

    }
}
