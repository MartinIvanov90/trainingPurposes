using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class Program
    {
        public static int GetMax(int alpha, int beta)
        {
            return Math.Max(alpha, beta);
        }
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                    .Split(' ')
                                    .Select(x => int.Parse(x))
                                    .ToArray();
            Console.WriteLine(GetMax(input[0], GetMax(input[1],input[2])));
        }
    }
}
