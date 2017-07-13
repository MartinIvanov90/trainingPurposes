using System;
using System.Text;

namespace StringLength
{
    class StringLength
    {
        static void Main()
        {

            var input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append(input).Append(new string('*', 20 - input.Length));
            Console.WriteLine(sb.ToString());
        }
    }
}
