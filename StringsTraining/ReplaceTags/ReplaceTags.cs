using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ReplaceTags
{
    class ReplaceTags
    {
        static void Main()
        {
            //string input = Console.ReadLine();
            //StringBuilder inputOutput = new StringBuilder(input);
            //StringBuilder newStBuilder = new StringBuilder();
            //int urlStartLocation = 0;
            //int urlEndLocation = 0;
            //int textStartLocation = 0;
            //int textEndLocation = 0;
            //int wholeStringStart = 0;
            //int wholeStringEnd = 0;
            //urlStartLocation = input.IndexOf("<a href=\"", urlEndLocation);

            //do
            //{
            //    newStBuilder.Clear();
            //    urlEndLocation = input.IndexOf("\">", urlStartLocation,StringComparison.Ordinal);
            //    textStartLocation = urlEndLocation + 2;
            //    textEndLocation = input.IndexOf("</a>", urlStartLocation,StringComparison.Ordinal);
            //    wholeStringStart = urlStartLocation;
            //    wholeStringEnd = textEndLocation + 4;
            //    string wholeString = input.Substring(wholeStringStart, wholeStringEnd - wholeStringStart);
            //    string url = input.Substring(urlStartLocation + 9, urlEndLocation - urlStartLocation-9);
            //    string text = input.Substring(textStartLocation, textEndLocation - textStartLocation);
            //    newStBuilder.Append("[").Append(text).Append("]").Append("(").Append(url).Append(")");
            //    //Console.WriteLine(wholeString);
            //    //Console.WriteLine(newString);
            //    inputOutput.Replace(wholeString, newStBuilder.ToString());

            //    urlStartLocation = input.IndexOf("<a href=\"", urlEndLocation, StringComparison.Ordinal);
            //} while (urlStartLocation != -1);
            //Console.WriteLine(inputOutput);


            string input = Console.ReadLine();

            string pattern = "<a href=\"(.*?)\">(.*?)<\\/a>";
            string replacePattern = "[$2]($1)";
            Console.WriteLine(Regex.Replace(input, pattern, replacePattern));

        }

    }
}

