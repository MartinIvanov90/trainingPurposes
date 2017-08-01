using System;
using OopPartTwo.Resources;

namespace OopPartTwo
{   
    [Version(versionNumber = "NIKAKVA PREDSTAVA KAK RABOTI TVA")]
    class EuclidianMain
    {
        static void Main(string[] args)
        {
            var version = (VersionAttribute[])typeof(EuclidianMain).GetCustomAttributes(typeof(VersionAttribute), true);
            var versione = version[0];
            string ver = versione.versionNumber;
            Console.WriteLine(ver);
            try
            {
                Matrix<double> matrixA = Matrix<double>.matrixAGenerator();
                Matrix<double> matrixB = Matrix<double>.matrixBGenerator();
                Console.WriteLine(matrixA);
                Console.WriteLine(matrixB);
                Console.WriteLine(matrixA + matrixB);
                Console.WriteLine(matrixA - matrixB);
                Console.WriteLine(matrixA * matrixB);
                if(new Matrix<int>(5, 6))
                {
                    Console.WriteLine("TRUE - SQUARE");
                }
                else
                {
                    Console.WriteLine("FALSE - NOT SQUARE");
                }
                if (new Matrix<int>(7, 7))
                {
                    Console.WriteLine("TRUE - SQUARE");
                }
                else
                {
                    Console.WriteLine("FALSE - NOT SQUARE");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        

    }
}

