using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestAreaInMatrix
{
    class LargestAreaInMatrixx
    {
        public static List<int> areaLengths;

        public static int matchCounter;
        public static int currentNumber = 0;

        #region checkSides
        public static bool CheckUp(int row, int col,int current, int[,] inputMatrix)
        {
            if(row > 0)
            {
                if (current == inputMatrix[row - 1, col] && current != 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public static bool CheckRight(int row, int col, int current, int[,] inputMatrix)
        {
            if (col < inputMatrix.GetLength(1) - 1)
            {
                if (current == inputMatrix[row, col + 1] && current != 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool CheckLow(int row, int col, int current, int[,] inputMatrix)
        {
            if (row < inputMatrix.GetLength(0) - 1)
            {
                if (current == inputMatrix[row + 1, col] && current != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool CheckLeft(int row, int col, int current, int[,] inputMatrix)
        {
            if (col > 0)
            {
                if (current == inputMatrix[row, col - 1] && current != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
#endregion
        public static void CheckNeighbours(int row, int col,int[,] inputMatrix)
        {
            currentNumber = inputMatrix[row, col];
            inputMatrix[row, col] = 0;           
            if (currentNumber != 0)
            {
                matchCounter++;
               // Console.WriteLine($"branch {row} {col}; {matchCounter}");
                if (CheckUp(row, col, currentNumber, inputMatrix))
                {
                    CheckNeighbours(row - 1, col, inputMatrix);
                }
                if (CheckRight(row, col, currentNumber, inputMatrix))
                {
                    CheckNeighbours(row, col + 1, inputMatrix);
                }
                if (CheckLow(row, col, currentNumber, inputMatrix))
                {
                    CheckNeighbours(row + 1, col, inputMatrix);
                }
                if (CheckLeft(row, col, currentNumber, inputMatrix))
                {
                    CheckNeighbours(row, col - 1, inputMatrix);
                }
            }            
        }
        static void Main()
        {
#region inputField


            List<int> inputNM = Console.ReadLine()
                                        .Split(' ')
                                        .Select(x => int.Parse(x))
                                        .ToList<int>();
            int[,] matrix;
            int N = inputNM[0];
            int M = inputNM[1];
            matrix = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                int[] temp = Console.ReadLine()
                                    .Split(' ')
                                    .Select(x => int.Parse(x))
                                    .ToArray();
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = temp[j];
                }
            }

            #endregion
            
            int matrixRowLength = matrix.GetLength(0);
            int matrixColLength = matrix.GetLength(1);
            areaLengths = new List<int>();
            matchCounter = 0;
            int cycleCounter = 0;
            int matrixSize = matrixRowLength * matrixColLength;
            int halfOfMatrix =(int) ( matrixSize / 2.5);
            for (int i = 0;i < matrixRowLength; i++)
            {
                for (int j = 0; j < matrixColLength; j++)
                {
                    if (matrix[i,j]!=0)
                    {
                        CheckNeighbours(i, j,matrix);
                        areaLengths.Add(matchCounter);
                        //GC.Collect();
                        matchCounter = 0;
                        cycleCounter++;
                    }       
                    if(cycleCounter> halfOfMatrix)
                    {
                        break;
                        
                    }
                }
            }      
            Console.WriteLine(areaLengths.Max());
        }
    }
}
