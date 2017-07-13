using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
                string[] source = Console.ReadLine()
                                            .Split(new string[] { "upcase" },StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < source.Length; i++)
            {
                if(i % 2 == 1)
                {
                    source[i] = source[i].ToUpper();
                }
            }
            Console.WriteLine(String.Join("", source).Replace("<>","").Replace("</>", ""));
            }
        }
    }

