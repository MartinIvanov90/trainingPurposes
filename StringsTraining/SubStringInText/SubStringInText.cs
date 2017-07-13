using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SubStringInText
{
    class SubStringInText
    {
        static void Main()
        {
            string substring = Console.ReadLine();
            string source = Console.ReadLine();

            int count = 0, n = 0;

            if (substring != "")
            {
                while ((n = source.IndexOf(substring, n, StringComparison.CurrentCultureIgnoreCase)) != -1)
                {
                    n += substring.Length;
                    ++count;
                }
            }
            Console.WriteLine(count);
        }
    }
}
