using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine()
         .Split(' ', StringSplitOptions.RemoveEmptyEntries)
         .Select(int.Parse)
         .ToArray();
            int rows = rowsAndCols[0];

            int cols = rowsAndCols[1];

            string[,] matrix = new string[rows, cols];
            ReadMatrix(matrix);
            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] tokens = command.Split(' ').ToArray();
                bool lenghtTokens=CheckLenghtCommandParams(tokens);
                string action = tokens[0];
                bool isActionSwap = CheckAction(action);
                if(lenghtTokens && isActionSwap)
                {
                    int firstRowCordinate = int.Parse(tokens[1]);
                    int firstColCordinate = int.Parse(tokens[2]);
                    int secondRowCordinate = int.Parse(tokens[3]);
                    int secondColCordinate = int.Parse(tokens[4]);
                    bool isValid = IsValidCordinates(matrix, firstRowCordinate, 
                        firstColCordinate, secondRowCordinate, secondColCordinate);
                    if(!isValid)
                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine().ToLower();
                        continue;
                    }
                    SwapTwoValuesInMatrix(matrix, firstRowCordinate, firstColCordinate, 
                        secondRowCordinate, secondColCordinate);
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                
                command=Console.ReadLine().ToLower();
            }
        }
        static void ReadMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] values = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values[col];
                }
            }
        }
        static bool CheckLenghtCommandParams(string[] tokens)
        {
            if (tokens.Length == 5)
            {
                return true;
            }
            return false;
        }
        static bool CheckAction(string action)
        {
            if (action == "swap")
            {
                return true;
            }
            return false;
        }
        static bool IsValidCordinates(string[,]matrix, int firstRowCordinate
            ,int firstColCordinate, int secondRowCordinate, int secondColCordinate)
        {
            bool isValid = false;
            if(firstRowCordinate<0 || firstRowCordinate>=matrix.GetLength(0) 
                || firstColCordinate<0 || firstColCordinate >= matrix.GetLength(1) 
                || secondRowCordinate<0 || secondRowCordinate>=matrix.GetLength(0) 
                || secondColCordinate<0 || secondColCordinate>=matrix.GetLength(1))
            {
                return isValid;
            }
            isValid = true;
            return isValid;
        }
        static void SwapTwoValuesInMatrix(string[,]matrix, int firstRowCordinate
            , int firstColCordinate, int secondRowCordinate, int secondColCordinate)
        {
            string swap = matrix[firstRowCordinate, firstColCordinate];
                matrix[firstRowCordinate,firstColCordinate ] = 
                matrix[secondRowCordinate,secondColCordinate];
                matrix[secondRowCordinate,secondColCordinate ] = swap;

        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}