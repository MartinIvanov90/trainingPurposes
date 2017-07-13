using System;


namespace ExceptionsSquareRoot
{
    class ExceptionsSquareRoot
    {
        static void Main()
        {
            try
            {
                double input = double.Parse(Console.ReadLine());
                if(input < 0)
                {
                    throw new ArgumentException("Invalid number");
                }
                Console.WriteLine("{0:F3}", Math.Sqrt(input));
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number");
            }

            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
