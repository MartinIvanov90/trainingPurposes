using System;
using System.Linq;


namespace ExceptionsEnterNumbers
{
    class EnterNumbers
    {
        static void ReadNumbers(int start, int end)
        {
            int[] input = new int[10];
            input[0] = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                int tempHolder = int.Parse(Console.ReadLine());
                if (tempHolder > input[i - 1] && tempHolder > start && tempHolder < end)
                {
                    input[i] = tempHolder;
                }
                else
                {
                    throw new Exception("Exception");
                }
            }
            string output = "1 < ";
            output += String.Join(" < ",input);
            output += " < 100";
            Console.WriteLine(output);

        }
        static void Main()
        {
            try
            {
                ReadNumbers(1, 100);
            }
            catch(Exception)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
