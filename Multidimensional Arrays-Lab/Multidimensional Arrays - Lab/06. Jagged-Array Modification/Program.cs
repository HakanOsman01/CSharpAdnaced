using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][]jaggedArray=ReadJaggaedArray(rows);
            string command = Console.ReadLine().ToLower();
            while(command!= "end")
            {
                string[] tokens = command
                .Split()
                .ToArray();
               
                string action = tokens[0];
                int rowCordinate = int.Parse(tokens[1]);
                int colCordinate = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);
                if(rowCordinate<0 || rowCordinate>=rows || colCordinate<0 ||
                    colCordinate >= jaggedArray[rowCordinate].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine().ToLower();
                    continue;
                   
                }
                if (action == "add")
                {
                    jaggedArray[rowCordinate][colCordinate] += value;
                }
                else
                {
                    jaggedArray[rowCordinate][colCordinate] -= value;
                }
                command= Console.ReadLine().ToLower();
               

            }
            foreach (int[]array in jaggedArray)
            {
                Console.WriteLine($"{string.Join(' ',array)}");
            }

        }
        static int[][]ReadJaggaedArray(int rows)
        {
            int[][] jaggedArray = new int[rows][];
            for(int row = 0; row < rows; row++)
            {
                int[]currentRow=Console.ReadLine()
               .Split(' ',StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
                jaggedArray[row]=currentRow;
            }
            return jaggedArray;
        }
    }
}