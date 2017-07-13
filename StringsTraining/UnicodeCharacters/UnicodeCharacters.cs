using System;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {

        static void Main()
        {
            string input = Console.ReadLine();
            foreach(char word in input)
            {
                Console.Write("\\u"+Convert.ToByte(word).ToString("x4").ToUpper());
            }
            Console.WriteLine();
        }
    }
}
