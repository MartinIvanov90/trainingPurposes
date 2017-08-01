using System;
using Jungle.Abstract;
using Jungle.Bussines;
using Jungle.Enums;
using System.Collections.Generic;

namespace Jungle
{
    class AnimalsMain
    {
        static void Main()
        {
            List<Animals> animals = new List<Animals>();
            animals.Add(new Dog("Murdjo", 5, AnimalsSex.male));
            animals.Add(new Frog("Krastava", 7, AnimalsSex.female));
            animals.Add(new Kitten("Purko", 1, FurColor.black));
            animals.Add(new Kitten("Semplicita", 2, FurColor.white));
            animals.Add(new TomCat("Pencho", 1, FurColor.ginger));
            foreach(Animals animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine(AgeCalculator.CalculateAnimalAge(animals));
        }
    }
}
