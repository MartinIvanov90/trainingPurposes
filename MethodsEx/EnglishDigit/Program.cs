using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class Program
    {
        public static void WriteMeh(char input)
        {
            Dictionary<char, string> myDict = new Dictionary<char, string>
        {
            { '0', "zero" },
            { '1', "one" },
            { '2', "two" },
            { '3', "three" },
            { '4', "four" },
            { '5', "five" },
            { '6', "six" },
            { '7', "seven" },
            { '8', "eight" },
            { '9', "nine" }
        };
            Console.WriteLine(myDict[input]);
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            WriteMeh(input[input.Length - 1]);


        }
    }
}
