using System;

using System.Linq;


namespace AppearanceCount
{
    class Program
    {
        public static int CountOccurancies(string[] inputArr, string searchedValue)
        {
            int result = 0;
            for(int i = 0; i < inputArr.Length; i++)
            {
                if(searchedValue== inputArr[i])
                {
                    result++;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.ReadLine();
            string[] input = Console.ReadLine()
                        .Split(' ')

                        .ToArray();
            string whatToLookFor = Console.ReadLine();
            Console.WriteLine(CountOccurancies(input, whatToLookFor));
        }
    }
}
