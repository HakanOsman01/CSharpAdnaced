using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._The_Squirrel
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int size=int.Parse(Console.ReadLine());
           string[]directions=Console.ReadLine()
           .Split(", ",StringSplitOptions.RemoveEmptyEntries)
           .ToArray();
            char[,] field = ReadField(size);
            int squareRow = 0;
            int squareCol = 0;
            FindSquarePosition(field, ref squareRow, ref squareCol);
            int hazzelnutCount = FindHazzelnutCount(field);
            int collectedHazzlnuts = 0;
            bool isTrapSquared = false;
            bool isOutField=false;
            for (int cur = 0; cur < directions.Length; cur++)
            {
                string currentDirection = directions[cur];
                if(currentDirection== "down")
                {
                    if (squareRow + 1 >= size)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        Console.WriteLine($"Hazelnuts collected: {collectedHazzlnuts}");
                        isOutField = true;
                        break;
                    }
                    //squareRow += 1;
                    if (field[squareRow+1, squareCol] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel " +
                            "stepped on a trap...");
                        Console.WriteLine($"Hazelnuts collected: {collectedHazzlnuts}");
                        isTrapSquared = true;
                        break;
                    }
                    if (field[squareRow + 1, squareCol] == 'h')
                    {
                        field[squareRow, squareCol] = '*';
                        squareRow =squareRow+1;
                        field[squareRow, squareCol] = 's';
                        collectedHazzlnuts++;
                        continue;
                    }
                    if (field[squareRow + 1, squareCol] == '*')
                    {
                        field[squareRow, squareCol] = '*';
                        squareRow = squareRow + 1;
                        field[squareRow, squareCol] = 's';

                    }
                }
                else if (currentDirection == "up")
                {
                    if (squareRow - 1 < 0)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        Console.WriteLine($"Hazelnuts collected: {collectedHazzlnuts}");
                        isOutField=true;
                        break;
                    }
                    //squareRow += 1;
                    if (field[squareRow - 1, squareCol] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel " +
                            "stepped on a trap...");
                        Console.WriteLine($"Hazelnuts collected: {collectedHazzlnuts}");
                        isTrapSquared=true;
                        break;
                    }
                    if (field[squareRow - 1, squareCol] == 'h')
                    {
                        field[squareRow, squareCol] = '*';
                        squareRow = squareRow - 1;
                        field[squareRow, squareCol] = 's';
                        collectedHazzlnuts++;
                        continue;
                    }
                    if (field[squareRow-1, squareCol] == '*')
                    {
                        field[squareRow, squareCol] = '*';
                        squareRow = squareRow - 1;
                        field[squareRow, squareCol] = 's';

                    }

                }
                else if (currentDirection == "right")
                {
                    if (squareCol + 1 >= size)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        Console.WriteLine($"Hazelnuts collected: {collectedHazzlnuts}");
                        isOutField=true;
                        break;
                    }
                    //squareRow += 1;
                    if (field[squareRow , squareCol+1] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel " +
                            "stepped on a trap...");
                        Console.WriteLine($"Hazelnuts collected: {collectedHazzlnuts}");
                        isTrapSquared  =true;
                        break;
                    }
                    if (field[squareRow, squareCol+1] == 'h')
                    {
                        field[squareRow, squareCol] = '*';
                        squareCol = squareCol + 1;
                        field[squareRow, squareCol] = 's';
                        collectedHazzlnuts++;
                        continue;
                    }
                    if (field[squareRow, squareCol + 1] == '*')
                    {
                        field[squareRow, squareCol] = '*';
                        squareCol = squareCol + 1;
                        field[squareRow, squareCol] = 's';

                    }

                }
                else if (currentDirection == "left")
                {
                    if (squareCol - 1 < 0)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        Console.WriteLine($"Hazelnuts collected: {collectedHazzlnuts}");
                        isOutField=true;
                        break;
                    }
                    //squareRow += 1;
                    if (field[squareRow, squareCol - 1] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel " +
                            "stepped on a trap...");
                        Console.WriteLine($"Hazelnuts collected: {collectedHazzlnuts}");
                        isTrapSquared=true;
                        break;
                    }
                    if (field[squareRow, squareCol - 1] == 'h')
                    {
                        field[squareRow, squareCol] = '*';
                        squareCol = squareCol - 1;
                        field[squareRow, squareCol] = 's';
                        collectedHazzlnuts++;
                        continue;
                    }
                    if (field[squareRow, squareCol - 1] == '*')
                    {
                        field[squareRow, squareCol] = '*';
                        squareCol = squareCol - 1;
                        field[squareRow, squareCol] = 's';

                    }

                }
            }
            if (!isTrapSquared && !isOutField)
            {
                if (collectedHazzlnuts == hazzelnutCount)
                {
                    Console.WriteLine("Good job! You have collected all hazelnuts!");
                    Console.WriteLine($"Hazelnuts collected: {collectedHazzlnuts}");
                }
                else if (collectedHazzlnuts < hazzelnutCount)
                {
                    Console.WriteLine("There are more hazelnuts to collect.");
                    Console.WriteLine($"Hazelnuts collected: {collectedHazzlnuts}");
                }

            }
           
        }
        static char[,]ReadField(int size)
        {
            char[,]field=new char[size,size];
            for (int row = 0; row <size; row++)
            {
                string currentRow=Console.ReadLine();
                for (int col = 0; col <size; col++)
                {
                    field[row, col] = currentRow[col];
                }
            }
            return field;
        }
        static void FindSquarePosition(char[,] field,ref int squareRow,ref int squareCol)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row,col]== 's')
                    {
                        squareRow = row;
                        squareCol=col;
                        return;
                    }
                }
            }
        }
        static int FindHazzelnutCount(char[,] field)
        {
            int count = 0;
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row,col]== 'h')
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}