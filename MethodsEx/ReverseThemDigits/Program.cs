using System;

using System.Linq;


namespace AppearanceCount
{
    class Program
    {

        static void Main(string[] args)
        {
            
            string input = Console.ReadLine()
                        .Select(x=>x.ToString())
                        .Reverse()
                        .ToArray()
                        .Aggregate((current, next) => current + string.Empty + next);

            Console.WriteLine(input);
        }
    }
}
