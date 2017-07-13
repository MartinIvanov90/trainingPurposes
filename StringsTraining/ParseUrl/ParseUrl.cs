using System;
using System.Text.RegularExpressions;

namespace ParseUrl
{
    class ParseUrl
    {
        static void Main()
        {

            string input = Console.ReadLine();
            string patternFirst = "://";

            string[] firstSplitString = Regex.Split(input, patternFirst);
            string[] secondSplitString = Regex.Split(firstSplitString[1], "/");
            //[protocol] = https
            //[server] = github.com
            //[resource] = /gentoo/gentoo.git
            string resourceOutput = "/";
            for (int i = 1; i < secondSplitString.Length; i++)
            {
                resourceOutput += secondSplitString[i] + "/";
            } 
            resourceOutput = resourceOutput.Remove(resourceOutput.Length - 1);
            Console.WriteLine("[protocol] = "+ firstSplitString[0]);
            Console.WriteLine("[server] = "+ secondSplitString[0]);
            Console.WriteLine("[resource] = "+ resourceOutput);


        }
    }
}
