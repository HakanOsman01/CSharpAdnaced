using System;
using System.Linq;

namespace _08._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] field = ReadMatrix(size);
            string info = Console.ReadLine();

            string[] bombsCordinates = info.
             Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<int> bombCordibatesByPair = SplitBombsCordinates(bombsCordinates);
         
            for (int cur = 0; cur < bombCordibatesByPair.Count; cur+=2)
            {
                int rowCordinate = bombCordibatesByPair[cur];
                int colCordinate = bombCordibatesByPair[cur + 1];
                if (field[rowCordinate,colCordinate] <= 0)
                {
                    continue;
                }
                int value = field[rowCordinate, colCordinate];
                field[rowCordinate, colCordinate] = 0;
                ExplodeProcess(field, rowCordinate, colCordinate, value,size);

            }
          
            int countAliveCells = CountAliveCells(field);
            Console.WriteLine($"Alive cells: {countAliveCells}");
            int sum=GetSumOfAliveCells(field);
            Console.WriteLine($"Sum: {sum}");
            PrintField(field);
        }
        static int[,] ReadMatrix(int size)
        {
            int[,] matrix = new int[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(num => int.Parse(num))
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            return matrix;
        }
        static List<int> SplitBombsCordinates(string[] bombsCordinates) 
        {

            List<int> bombCordibatesByPair = new List<int>();
            for (int cur = 0; cur < bombsCordinates.Length; cur++)
            {
                string[]currentCordinate= bombsCordinates[cur]
                    .Split(",")
                    .ToArray();

                bombCordibatesByPair.Add(int.Parse(currentCordinate[0]));
                bombCordibatesByPair.Add(int.Parse(currentCordinate[1]));


            }
            return bombCordibatesByPair;
        }
        static void ExplodeProcess(int[,]field,int rowCordinate
            ,int colCordinate,int value, int size)
        {
            if (rowCordinate - 1 >= 0)
            {
                if (!isCellZeroOrLower(field, rowCordinate - 1, colCordinate))
                {
                    field[rowCordinate - 1, colCordinate] -= value;

                }
            }
            if (rowCordinate + 1 < size)
            {
                if (!isCellZeroOrLower(field, rowCordinate + 1, colCordinate))
                {
                    field[rowCordinate + 1, colCordinate] -= value;

                }
            }
            if (colCordinate + 1 < size)
            {
               
                if (!isCellZeroOrLower(field, rowCordinate, colCordinate+1))
                {
                    field[rowCordinate, colCordinate + 1] -= value;

                }
            }
            if (colCordinate - 1 >= 0)
            {
              
                if (!isCellZeroOrLower(field, rowCordinate, colCordinate - 1))
                {
                    field[rowCordinate, colCordinate - 1] -= value;

                }
            }
            if(rowCordinate-1>=0 && colCordinate + 1 < size)
            {
               
                if (!isCellZeroOrLower(field, rowCordinate-1, colCordinate + 1))
                {

                    field[rowCordinate - 1, colCordinate + 1] -= value;

                }
            }
            if(rowCordinate+1<size && colCordinate + 1 <size)
            {
               
                if (!isCellZeroOrLower(field, rowCordinate + 1, colCordinate + 1))
                {

                    field[rowCordinate + 1, colCordinate + 1] -= value;

                }

            }
            if(rowCordinate+1 <size  && colCordinate - 1 >= 0)
            {
              
                if (!isCellZeroOrLower(field, rowCordinate + 1, colCordinate - 1))
                {

                    field[rowCordinate + 1, colCordinate - 1] -= value;

                }
            }
            if(rowCordinate-1>=0 && colCordinate -1 >= 0)
            {
               
                if (!isCellZeroOrLower(field, rowCordinate - 1, colCordinate - 1))
                {


                    field[rowCordinate - 1, colCordinate - 1] -= value;
                }
            }

        }
        static int CountAliveCells(int[,] field)
        {
            int count = 0;
            for (int row = 0; row <field.GetLength(0) ; row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] > 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static int GetSumOfAliveCells(int[,] field)
        {
            int sum = 0;
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] > 0)
                    {
                        sum += field[row, col];
                    }
                }
            }
            return sum;
        }
        static void PrintField(int[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write($"{field[row,col]} ");
                }
                Console.WriteLine();
            }

        }
        static bool isCellZeroOrLower(int[,] field,int row, int col)
        {
            if (field[row, col] <= 0)
            {
                return true;
            }
            return false;
        }
     
    }
}