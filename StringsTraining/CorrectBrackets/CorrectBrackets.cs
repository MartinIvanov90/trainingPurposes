using System;
using System.Linq;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {

            string input = Console.ReadLine();
            if (input.Count(x => x =='(')== input.Count(x => x == ')'))
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
