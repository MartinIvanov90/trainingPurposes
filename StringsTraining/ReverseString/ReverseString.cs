using System;

using System.Linq;
using System.Text;

namespace AppearanceCount
{
    class Program
    {

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            char[] input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            Console.WriteLine(new string(input));


            
        }
    }
}
