using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            string wordInput = null;
            try
            {
                wordInput = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }

            string unFormattedInput;
            //using (StreamReader reader = new StreamReader("beta.txt"))
            //{
            //    unFormattedInput = reader.ReadToEnd();
            //}
            string middlePattern = "[^a-zA-Z]+(" + wordInput + ")[^a-zA-Z]+";
            Regex middleReg = new Regex(middlePattern);
            //string startmiddlePattern = "^(?!\\w+)" + wordInput + "\\d*(?!\\w+)\\W*";
            //Regex startReg = new Regex(startmiddlePattern);
            //string endPattern = "\\W+\\d*" + wordInput + "\\d*\\W*$";
            //Regex endReg = new Regex(endPattern);
            int wordInputLen = wordInput.Length;

            string[] sentencesInput = Console.ReadLine()// unFormattedInput
                                          .Split('.')
                                          .Select(x => (" " + x + " "))
                                          .ToArray();

            foreach (string sentence in sentencesInput)
            {
                
                if (middleReg.IsMatch(sentence)) //|| startReg.IsMatch(sentence) || endReg.IsMatch(sentence))
                {
                    sb.Append(sentence.Trim());
                    sb.Append(". ");
                }
            }
            string output = sb.ToString();
            Console.WriteLine(output.Trim());
        }

    }
}

