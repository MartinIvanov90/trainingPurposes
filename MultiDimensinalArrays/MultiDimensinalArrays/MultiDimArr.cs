using System;

namespace MultiDimensinalArrays
{
    class MultiDimArr
    {
        static void Main()
        {

            int inputN = int.Parse(Console.ReadLine());
            string inputType = Console.ReadLine();
            

            switch (inputType)
            {
                case "a":
                    PrintItAll(CaseA(inputN));
                    break;
                case "b":
                    PrintItAll(CaseB(inputN));
                    break;
                case "c":
                    PrintItAll(CaseC(inputN));
                    break;
                case "d":
                    PrintItAll(CaseD(inputN));
                    break;
                default:
                    break;
            }

        }

        public static void PrintItAll(int[,] inputArr)
        {
            int rowLength = inputArr.GetLength(0);
            int colLength = inputArr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if(j == colLength - 1)
                    {
                        Console.Write(string.Format("{0}", inputArr[i, j]));
                    } else
                    {
                        Console.Write(string.Format("{0} ", inputArr[i, j]));
                    }
                    
                }
                Console.Write(Environment.NewLine);
            }
           // Console.ReadLine();
        }
        public static int[,] CaseA(int arraySize)
        {
            int[,] outputArr = new int[arraySize, arraySize];
            int begining = 1;
            for(int i = 0; i<arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    outputArr[j, i] = begining;
                    begining++;
                }
            }
            return outputArr;
        }
        public static int[,] CaseB(int arraySize)
        {
            int[,] outputArr = new int[arraySize, arraySize];
            int begining = 1;
            for (int i = 0; i < arraySize; i++)
            {
                if(!(i % 2 > 0))
                {
                    for (int j = 0; j < arraySize; j++)
                    {

                        outputArr[j, i] = begining;
                        begining++;
                    }
                }
                else
                {
                    for (int j = arraySize-1; j >= 0; j--)
                    {

                        outputArr[j, i] = begining;
                        begining++;
                    }
                }


            }
            return outputArr;
        }
        public static int[,] CaseC(int arraySize)
        {
            int[,] outputArr = new int[arraySize, arraySize];
            int begining = 1;

            for (int i = arraySize-1; i >= 0; i--)
            {
                int tempCnt = i;
                for (int j = 0; j < arraySize - i-1; j++)
                {
                    tempCnt++;
                    outputArr[tempCnt, j] = begining++;
                    
                }
            }

            for (int i = 0; i < arraySize; i++)
            { 
                outputArr[i, i] = begining;
                begining++;
            }
            for(int i = 0; i < arraySize - 1; i++)
            {
                int tempCnt = i;
                for (int j = 0; j < arraySize - i -1; j++)
                {
                    tempCnt++;
                    outputArr[j, tempCnt] = begining;
                    begining++;
                }
            }


            return outputArr;
        }
        public static int[,] CaseD(int arraySize)
        {
            int[,] outputArr = new int[arraySize, arraySize];
            int begining = 1;
            //for (int i = 0; i < arraySize - 1; i++)
            //{
            //    outputArr[i, 0] = begining;
            //    begining++;
            //}
            string way = "down";
            var snake = 2 * arraySize - 1;
            int row = 0;
            int column = 0;
            for (int j = 0; j < arraySize; j++)
            {
                outputArr[row, 0] = begining;
                begining++;
                row++;
            }
            


            for (int i = snake-1; i > 0; i--)
            {
                int quantifier = (int)Math.Ceiling( (double)i / (double)2);

                if (way == "down")
                {
                    column++;
                    row--;
                    
                    for (int j = 0;j< quantifier; j++)
                    {
                        outputArr[row, column] = begining;
                        
                        begining++;
                        column++;
                    }
                    
                    way = "right";
                }
                else if (way =="left")
                {
                    column++;
                    row++;
                    
                    for (int j = 0; j <quantifier; j++)
                    {
                        outputArr[row, column] = begining;
                        
                       begining++;
                        row++;
                    }
                   
                    way = "down";


                }
                else if (way == "up")
                {
                    int temp = column - quantifier;
                    column--;
                    row++;
                   
                    for (int j = column; j >= temp; j--)
                    {
                        outputArr[row, j] = begining;
                      
                        begining++;
                        column--;
                    }
                   
                    way = "left";
                }
                else if (way == "right")
                {
                    int temp = row - quantifier;
                    column--;
                    row--;
                    
                    for (int j = row; j >= temp; j--)
                    {
                        outputArr[j, column] = begining;
                       
                        begining++;
                        row--;
                    }
                   
                    way = "up";
                }
            }
            return outputArr;
        }
    }
}
