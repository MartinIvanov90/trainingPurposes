using System;

namespace SeriesOfLetters
{
    public class Sequences
    {
        private int startIndex = 0;
        private string input;
        private int inputLen;
        //private int sequenceLen = 1;
        private string output;
        public Sequences(string input)
        {
            this.input = input;
            this.inputLen = input.Length;
        }
        public void Squeeze()
        {
            while (startIndex < inputLen-1)
            {
                if (input[startIndex] == input[startIndex + 1])
                {
                    //Do Nothing
                }
                else
                {

                        output += input[startIndex];
                }

                startIndex++;
            }

            if (output[output.Length-1] != input[inputLen-1])
            {
                output += input[inputLen-1];
            }

        }
        public string Output
        {
            get
            {
                Squeeze();
                return output;
            }
        }
    }
    class SeriesOfLetters
    {
        static void Main()
        {
            
            Sequences seq = new Sequences(Console.ReadLine());
            Console.WriteLine(seq.Output);

        }
    }
}
