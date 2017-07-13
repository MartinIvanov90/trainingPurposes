using System;

using System.Linq;


namespace AppearanceCount
{
    class Program
    {
        public static int LargerThanLife(int[] inputArr, int lengthOfArr)
        {
            int result = -1;
            for (int i = 1; i < lengthOfArr - 1; i++)
            {
                if (inputArr[i] > inputArr[i - 1] && inputArr[i] > inputArr[i + 1])
                {
                    result = i;
                    break;
                } 
            }
            return result;
        }
        static void Main(string[] args)
        {
            int arrLen = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine()
                        .Split(' ')
                        .Select(x => int.Parse(x))
                        .ToArray();

            Console.WriteLine(LargerThanLife(input, arrLen));
        }
    }
}
