using System;
using Jungle.Abstract;
using Jungle.Bussines;
using System.Collections.Generic;
using System.Linq;

namespace Jungle
{
    public static class AgeCalculator
    {
        public static string CalculateAnimalAge(IEnumerable<Animals> animals)
        {
            int frog = 0;
            int frogCnt = 0;
            int kitten = 0;
            int kittenCnt = 0;
            int tomcat = 0;
            int tomcatCnt = 0;
            int dog = 0;
            int dogCnt = 0;

            foreach (Animals animal in animals)
            {
                if(animal.GetType() == typeof(Frog))
                {
                    frog += animal.Age;
                    frogCnt++;
                }
                else if (animal.GetType() == typeof(Dog))
                {
                    dog += animal.Age;
                    dogCnt++;
                }
                else if (animal.GetType() == typeof(Kitten))
                {
                    kitten += animal.Age;
                    kittenCnt++;
                }
                else if (animal.GetType() == typeof(TomCat))
                {
                    tomcat += animal.Age;
                    tomcatCnt++;
                }
            }
            string result = $"Kittens: {kittenCnt};\n avg age: {(double)kitten / kittenCnt:F2}\n" +
                            $"Dogs: {dogCnt};\n avg age: {(double)dog / dogCnt:F2}\n" +
                            $"Frogs: {frogCnt};\n avg age: {(double)frog / frogCnt:F2}\n" +
                            $"TomCats: {tomcatCnt};\n avg age: {(double)tomcat / tomcatCnt:F2}\n";
            return result;
        }

    }
}
