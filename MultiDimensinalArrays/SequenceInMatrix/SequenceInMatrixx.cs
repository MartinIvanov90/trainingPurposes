using System;
using System.Collections.Generic;
using System.Linq;

namespace SequenceInMatrix
{
    class SequenceInMatrixx
    {
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
#region LongestColumnSequence
        public static int LongestColumnSequence(int[,] inputMatrix)
        {
            int sequenceLength = 1;
            int rowLength = inputMatrix.GetLength(0);
            int colLength = inputMatrix.GetLength(1);
            List<int> columnSequenceCount = new List<int>();

            for (int colIndex = 0; colIndex < colLength; colIndex++)
            {
                
                int currentCellValue = inputMatrix[0, colIndex];
                for (int rowIndex = 1; rowIndex < rowLength; rowIndex++)
                {
                    if (currentCellValue == inputMatrix[rowIndex, colIndex])
                    {
                        sequenceLength++;
                    }
                    else
                    {
                        columnSequenceCount.Add(sequenceLength);
                        sequenceLength = 1;
                        currentCellValue = inputMatrix[rowIndex, colIndex];
                    }
                    columnSequenceCount.Add(sequenceLength);
                }
            }

            
            return columnSequenceCount.Max();
        }
        #endregion
#region LongestRowSequence
        public static int LongestRowSequence(int[,] inputMatrix)
        {
            int sequenceLength = 1;
            int rowLength = inputMatrix.GetLength(0);
            int colLength = inputMatrix.GetLength(1);
            List<int> rowSequenceCount = new List<int>();

            for (int rowIndex = 0; rowIndex < rowLength; rowIndex++)
            {

                int currentCellValue = inputMatrix[rowIndex, 0];
                for (int colIndex = 1; colIndex < colLength; colIndex++)
                {
                    if (currentCellValue == inputMatrix[rowIndex, colIndex])
                    {
                        sequenceLength++;
                    }
                    else
                    {
                        rowSequenceCount.Add(sequenceLength);
                        sequenceLength = 1;
                        currentCellValue = inputMatrix[rowIndex, colIndex];
                    }
                    rowSequenceCount.Add(sequenceLength);
                }
            }


            return rowSequenceCount.Max();
        }
        #endregion
#region LongestStraightDiagSequence
        public static int LongestStraightDiagSequence(int[,] inputMatrix)
        {
            int sequenceLength = 1;
            int matrixRowLength = inputMatrix.GetLength(0);
            int matrixColLength = inputMatrix.GetLength(1);
            int diagonalCount = matrixRowLength + matrixColLength - 2;
            int rowIndex = matrixRowLength - 2;
            int colIndex = 0;
            int columnMover = matrixColLength - 1;
            List<int> rowSequenceCount = new List<int>();
            while (diagonalCount > 0)
            {
                
                int currentCellValue = inputMatrix[rowIndex, colIndex];
                while ((rowIndex != matrixRowLength-1 && colIndex != matrixColLength - 1))
                {
                    if (currentCellValue == inputMatrix[rowIndex+1, colIndex+1])
                    {
                        sequenceLength++;
                    }
                    else
                    {
                        rowSequenceCount.Add(sequenceLength);
                        sequenceLength = 1;
                        currentCellValue = inputMatrix[rowIndex+1, colIndex+1];
                    }

                    rowIndex++;
                    colIndex++;
                }
                rowSequenceCount.Add(sequenceLength);
                sequenceLength =1;
                if (diagonalCount +1>= matrixColLength)
                {
                    colIndex = 0;
                    rowIndex = diagonalCount + 1 - matrixColLength;
                }
                else
                {
                    rowIndex = 0;
                    colIndex = columnMover;
                    columnMover--;
                }
                diagonalCount--;
                //трябва да поставя rowIndex и colIndex в началото на диагонала с проверка

            }

            return rowSequenceCount.Max();
        }
        #endregion
#region LongestCrossDiagSequence
        public static int LongestCrossDiagSequence(int[,] inputMatrix)
        {
            int sequenceLength = 1;
            int matrixRowLength = inputMatrix.GetLength(0);
            int matrixColLength = inputMatrix.GetLength(1);
            int diagonalCount = matrixRowLength + matrixColLength - 2;
            int rowIndex = matrixRowLength - 2;
            int colIndex = matrixColLength - 1;
            int columnMover = 0;
            List<int> rowSequenceCount = new List<int>();
            while (diagonalCount > 0)
            {
                
                int currentCellValue = inputMatrix[rowIndex, colIndex];
                while ((rowIndex < matrixRowLength-1 && colIndex > 0))
                {
                    
                    if (currentCellValue == inputMatrix[rowIndex + 1, colIndex -1])
                    {
                        sequenceLength++;
                    }
                    else
                    {
                        rowSequenceCount.Add(sequenceLength);
                        sequenceLength = 1;
                        currentCellValue = inputMatrix[rowIndex + 1, colIndex -1];
                    }

                    rowIndex++;
                    colIndex--;

                    
                }
                rowSequenceCount.Add(sequenceLength);
                sequenceLength = 1;
                if (diagonalCount + 1 >= matrixColLength)
                {
                    colIndex = matrixColLength-1;
                    rowIndex = diagonalCount + 1 - matrixColLength;
                }
                else
                {
                    rowIndex = 0;
                    colIndex = columnMover;
                    columnMover++;
                }
                diagonalCount--;
                //трябва да поставя rowIndex и colIndex в началото на диагонала с проверка
               
            }

            return rowSequenceCount.Max();
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

            int result = Math.Max(Math.Max(LongestColumnSequence(matrix), LongestRowSequence(matrix)), 
                Math.Max(LongestStraightDiagSequence(matrix), LongestCrossDiagSequence(matrix)));
           
            Console.WriteLine(result);
        }
    }
}
