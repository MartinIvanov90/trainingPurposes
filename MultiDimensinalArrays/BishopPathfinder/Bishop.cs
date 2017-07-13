using System;
using System.Collections.Generic;
using System.Linq;

namespace BishopPathfinder
{
    class Program
    {

        public static int pathSumator;
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
                        Console.Write(string.Format("{0}", inputArr[i, j].ToString("00")));
                    }
                    else
                    {
                        Console.Write(string.Format("{0} ", inputArr[i, j].ToString("00")));
                    }

                }
                Console.Write(Environment.NewLine);
            }
            // Console.ReadLine();
        }
        #endregion
#region upRight
        public static int[] UpRight(int [,] inputMatrix, int row, int col, int movesCount)
        {
            int[] resultSum = new int[2];
            int matrixRowLen = inputMatrix.GetLength(0);
            int matrixColLen = inputMatrix.GetLength(1);
            

            while (row > -1 && row < matrixRowLen && col > -1 && col < matrixColLen && movesCount > 0)
            {
                pathSumator += inputMatrix[row, col];
                inputMatrix[row, col] = 0;
                row--;
                col++;
                movesCount--;
            }
            row++;
            col--;
            resultSum[0] = row;
            resultSum[1] = col;
            return resultSum;
        }
        #endregion
#region downRight
        public static int[] DownRight(int[,] inputMatrix, int row, int col, int movesCount)
        {
            int[] resultSum = new int[2];
            int matrixRowLen = inputMatrix.GetLength(0);
            int matrixColLen = inputMatrix.GetLength(1);


            while (row > -1 && row < matrixRowLen && col > -1 && col < matrixColLen && movesCount > 0)
            {
                pathSumator += inputMatrix[row, col];
                inputMatrix[row, col] = 0;
                row++;
                col++;
                movesCount--;
            }
            row--;
            col--;
            resultSum[0] = row;
            resultSum[1] = col;
            return resultSum;
        }
        #endregion
#region upLeft
        public static int[] UpLeft(int[,] inputMatrix, int row, int col, int movesCount)
        {
            int[] resultSum = new int[2];
            int matrixRowLen = inputMatrix.GetLength(0);
            int matrixColLen = inputMatrix.GetLength(1);


            while (row > -1 && row < matrixRowLen && col > -1 && col < matrixColLen && movesCount > 0)
            {
                pathSumator += inputMatrix[row, col];
                inputMatrix[row, col] = 0;
                row--;
                col--;
                movesCount--;
            }
            row++;
            col++;
            resultSum[0] = row;
            resultSum[1] = col;
            return resultSum;
        }
        #endregion
#region downLeft
        public static int[] DownLeft(int[,] inputMatrix, int row, int col, int movesCount)
        {
            int[] resultSum = new int[2];
            int matrixRowLen = inputMatrix.GetLength(0);
            int matrixColLen = inputMatrix.GetLength(1);


            while (row > -1 && row < matrixRowLen && col > -1 && col < matrixColLen && movesCount > 0)
            {
                pathSumator += inputMatrix[row, col];
                inputMatrix[row, col] = 0;
                row++;
                col--;
                movesCount--;
            }
            row--;
            col++;
            resultSum[0] = row;
            resultSum[1] = col;
            return resultSum;
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
            int inputQuantifier = 0;
            int[,] matrix = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                int temp = inputQuantifier;
                for (int j = 0; j < M; j++)
                {
                    
                    matrix[N-i-1, j] = temp;
                    temp += 3;
                }
                inputQuantifier += 3;
            }
            int commandCount = int.Parse(Console.ReadLine());

            #endregion
            #region inputCommands

            pathSumator = 0;
            int[] currentPos = new int[2] { N-1,0 };

            for (int i = 0; i < commandCount; i++)
            {
                string[] comInputArr = Console.ReadLine()
                                                     .Split(' ')
                                                     .ToArray();

                switch (comInputArr[0])
                {
                    case "UR":
                        currentPos = UpRight(matrix, currentPos[0], currentPos[1], int.Parse(comInputArr[1]));
                        break;
                    case "RU":
                        currentPos = UpRight(matrix, currentPos[0], currentPos[1], int.Parse(comInputArr[1]));
                        break;
                    case "LU":
                        currentPos = UpLeft(matrix, currentPos[0], currentPos[1], int.Parse(comInputArr[1]));
                        break;
                    case "UL":
                        currentPos = UpLeft(matrix, currentPos[0], currentPos[1], int.Parse(comInputArr[1]));
                        break;
                    case "DL":
                        currentPos = DownLeft(matrix, currentPos[0], currentPos[1], int.Parse(comInputArr[1]));
                        break;
                    case "LD":
                        currentPos = DownLeft(matrix, currentPos[0], currentPos[1], int.Parse(comInputArr[1]));
                        break;
                    case "RD":
                        currentPos = DownRight(matrix, currentPos[0], currentPos[1], int.Parse(comInputArr[1]));
                        break;
                    case "DR":
                        currentPos = DownRight(matrix, currentPos[0], currentPos[1], int.Parse(comInputArr[1]));
                        break;

                    default:

                        break;
                }
            }
            
            //PrintItAll(matrix);
            Console.WriteLine(pathSumator);

            #endregion

        }
    }
}
