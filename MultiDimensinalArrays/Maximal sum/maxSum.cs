using System;
using System.Collections.Generic;
using System.Linq;
namespace Maximal_sum
{
    class maxSum
    {
        public static long SumRectangleArea(int[,] inputMatrix, int rowIndex, int colIndex)
        {
            int result;
            result = inputMatrix[rowIndex, colIndex] + inputMatrix[rowIndex-1, colIndex-1] +
                inputMatrix[rowIndex-1, colIndex] + inputMatrix[rowIndex-1, colIndex+1] +
                inputMatrix[rowIndex, colIndex-1] + inputMatrix[rowIndex, colIndex+1] +
                inputMatrix[rowIndex+1, colIndex-1] + inputMatrix[rowIndex+1, colIndex] +
                inputMatrix[rowIndex+1, colIndex+1];



            return result;
        }

#region printItAll
        public static void PrintItAll(int[,] inputArr)
        {
            int rowLength = inputArr.GetLength(0);
            int colLength = inputArr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (j == colLength - 1)
                    {
                        Console.Write(string.Format("{0}", inputArr[i, j]));
                    }
                    else
                    {
                        Console.Write(string.Format("{0} ", inputArr[i, j]));
                    }

                }
                Console.Write(Environment.NewLine);
            }
            // Console.ReadLine();
        }
#endregion
        static void Main()
        {

#region inputField

        
        List<int> inputNM = Console.ReadLine()
                                    .Split(' ')
                                    .Select(x => int.Parse(x))
                                    .ToList<int>();
            int N = inputNM[0];
            int M = inputNM[1];
            int[,] matrix = new int[N, M];
            for(int i = 0; i < N; i++)
            {
                int[] temp = Console.ReadLine()
                                    .Split(' ')
                                    .Select(x => int.Parse(x))
                                    .ToArray();
                for(int j = 0; j< M; j++)
                {
                    matrix[i, j] = temp[j];
                }
            }

            #endregion


            long sumChecker = int.MinValue;


        for(int i = 1; i < matrix.GetLength(0)-1; i++)
            {
                for(int j = 1; j < matrix.GetLength(1) - 1; j++)
                {
                    long rectSumTemp = SumRectangleArea(matrix,i,j);
                    if (sumChecker < rectSumTemp)
                    {
                        sumChecker = rectSumTemp;
                    }
                }
            }
            Console.WriteLine(sumChecker);
        }
    }
}
