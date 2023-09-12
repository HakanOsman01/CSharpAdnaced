using System;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine()
           .Split(", ", StringSplitOptions.RemoveEmptyEntries)
           .Select(num => int.Parse(num))
           .ToArray();
            int rows = info[0];
            int cols = info[1];
            int[,] matrix = ReadMatrix(rows, cols);
            GetSumOfCol(matrix);
        }
        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(num => int.Parse(num))
                 .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            return matrix;
        }
        static void GetSumOfCol(int[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentColSum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    currentColSum+= matrix[row, col];
                }
                Console.WriteLine(currentColSum);
            }
        }
    }
}