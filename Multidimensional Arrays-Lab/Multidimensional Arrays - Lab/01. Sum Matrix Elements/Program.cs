using System;

namespace _01._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]info=Console.ReadLine()
           .Split(", ",StringSplitOptions.RemoveEmptyEntries)
           .Select(num => int.Parse(num))
           .ToArray();
            int rows = info[0];
            int cols = info[1];
            int[,]matrix=ReadMatrix(rows, cols);
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            int sum = 0;
            foreach (int currentElement in matrix)
            {
                sum+= currentElement;
            }
            Console.WriteLine(sum);


        }
        static int[,]ReadMatrix(int rows, int cols)
        {
            int[,]matrix= new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[]numbers=Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(num => int.Parse(num))
                 .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            return matrix;
        }
    }
}