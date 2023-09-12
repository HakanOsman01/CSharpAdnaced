using System;
using System.Linq;

namespace _05._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]data=Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
            int rows = data[0];
            int cols = data[1];
            string snake = Console.ReadLine();
            char[,] isle = new char[rows, cols];

            int lastIndex = 0;
            for (int row = 0; row < isle.GetLength(0); row++)
            {
                
                if (row==0 || row % 2 == 0)
                {
                    for (int col = 0; col < isle.GetLength(1); col++)
                    {

                        if (lastIndex >= snake.Length)
                        {
                            lastIndex = 0;

                        }
                        isle[row, col] = snake[lastIndex];
                        ++lastIndex;

                    }

                }
                else
                {
                    for (int col = isle.GetLength(1)-1; col >= 0; col--)
                    {
                        if (lastIndex >= snake.Length)
                        {
                            lastIndex = 0;
                        }
                        isle[row, col] = snake[lastIndex];
                        ++lastIndex;
                    }
                }
               
               
             
            }
            PrintMatrix(isle);
        }
        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}