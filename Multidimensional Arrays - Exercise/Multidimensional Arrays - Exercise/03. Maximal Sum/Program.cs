using System;
using System.Linq;

namespace _03._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine()
          .Split(' ', StringSplitOptions.RemoveEmptyEntries)
          .Select(int.Parse)
          .ToArray();
            int rows = rowsAndCols[0];

            int cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];

            ReadMatrix(matrix);

            int maxRowIndex = 0;
            int maxColIndex = 0;
            int sum = GetMaxSumOfRectangeMatrix(matrix, ref maxRowIndex, ref maxColIndex);

            Console.WriteLine($"Sum = {sum}");

            for (int curRow = maxRowIndex; curRow < maxRowIndex + 3; curRow++)
            {
                for (int curCol = maxColIndex; curCol < maxColIndex + 3; curCol++)
                {
                    Console.Write($"{matrix[curRow, curCol]} ");
                }

                Console.WriteLine();
            }



        }
        static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
        }
        static int GetMaxSumOfRectangeMatrix(int[,] rectangeMatrix
            , ref int maxRowIndex, ref int maxColIndex)
        {
            int maxSum = int.MinValue;

            int rows = rectangeMatrix.GetLength(0);

            int cols = rectangeMatrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row + 3 - 1 < rows && col + 3 - 1 < cols)
                    {
                        int currentSum = rectangeMatrix[row, col]
                        + rectangeMatrix[row, col + 1] + rectangeMatrix[row, col + 2]
                        + rectangeMatrix[row + 1, col] + rectangeMatrix[row + 1, col + 1]
                        + rectangeMatrix[row + 1, col + 2] + rectangeMatrix[row + 2, col] +
                        rectangeMatrix[row + 2, col + 1] + rectangeMatrix[row + 2, col + 2];
                        if (maxSum < currentSum)
                        {
                            maxSum = currentSum;
                            maxRowIndex = row;
                            maxColIndex = col;
                        }
                    }
                }

            }
            return maxSum;
        }
    }
}
