using System;
using System.Linq;

namespace _09._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size=int.Parse(Console.ReadLine());
            string []directions=Console.ReadLine().Split(' ').ToArray();
            char[,] field = ReadField(size);
            int rowMiner = 0;
            int colMiner = 0;
            FindPositionOfMiner(field, size, ref rowMiner, ref colMiner);
            int countOfGoals = CountTheGoalsInField(field);
            bool isGameOver = false;
            bool isCollectAllGoals = false;
           
            for (int cur = 0; cur < directions.Length; cur++)
            {
                if (countOfGoals == 0)
                {
                    isGameOver = true;
                    break;
                }
                string currentDirection = directions[cur];
                if (currentDirection == "right")
                {
                    if (colMiner + 1 < size)
                    {
                        if (field[rowMiner, colMiner + 1] == 'e')
                        {
                            colMiner += 1;
                            isGameOver = true;
                            break;
                        }
                        else if (field[rowMiner, colMiner + 1] == 'c')
                        {
                            --countOfGoals;
                            field[rowMiner, colMiner] = '*';
                            field[rowMiner, colMiner+1] = 's';
                            colMiner += 1;
                        }
                        else
                        {
                            field[rowMiner, colMiner] = '*';
                            field[rowMiner, colMiner + 1] = 's';
                            colMiner += 1;

                        }
                    }
                }
                else if (currentDirection == "left")
                {
                    if (colMiner - 1 >= 0)
                    {
                        if (field[rowMiner, colMiner - 1] == 'e')
                        {
                            colMiner -= 1;
                            isGameOver = true;
                            break;
                        }
                        else if (field[rowMiner, colMiner - 1] == 'c')
                        {
                            --countOfGoals;
                            field[rowMiner, colMiner] = '*';
                            field[rowMiner, colMiner - 1] = 's';
                            colMiner -= 1;
                        }
                        else
                        {
                            field[rowMiner, colMiner] = '*';
                            field[rowMiner, colMiner - 1] = 's';
                            colMiner -= 1;

                        }
                    }
                }
                else  if (currentDirection == "down")
                {
                    if (rowMiner + 1 < size)
                    {
                        if (field[rowMiner+1, colMiner] == 'e')
                        {
                            rowMiner += 1;
                            isGameOver = true;
                            break;
                        }
                        else if (field[rowMiner+1, colMiner] == 'c')
                        {
                            --countOfGoals;
                            field[rowMiner, colMiner] = '*';
                            field[rowMiner+1, colMiner] = 's';
                            rowMiner+= 1;
                        }
                        else
                        {
                            field[rowMiner, colMiner] = '*';
                            field[rowMiner+1, colMiner] = 's';
                            rowMiner += 1;

                        }
                    }
                }
                else
                {
                    if (rowMiner - 1 >= 0)
                    {
                        if (field[rowMiner - 1, colMiner] == 'e')
                        {
                            rowMiner -= 1;
                            isGameOver = true;
                            break;
                        }
                        else if (field[rowMiner - 1, colMiner] == 'c')
                        {
                            --countOfGoals;
                            field[rowMiner, colMiner] = '*';
                            field[rowMiner - 1, colMiner] = 's';
                            rowMiner -= 1;
                        }
                        else
                        {
                            field[rowMiner, colMiner] = '*';
                            field[rowMiner - 1, colMiner] = 's';
                            rowMiner -= 1;

                        }
                    }

                }



            }
            if (isGameOver)
            {
                Console.WriteLine($"Game over! ({rowMiner}, {colMiner})");
            }
            else if (isCollectAllGoals || countOfGoals==0)
            {
                Console.WriteLine($"You collected all coals! ({rowMiner}, {colMiner})");
            }
            else
            {
                Console.WriteLine($"{countOfGoals} coals left. ({rowMiner}, {colMiner})");
            }
        }
        static char[,]ReadField(int size)
        {
            char[,]field=new char[size,size];
            for (int row = 0;row < field.GetLength(0); row++)
            {
                char []currentRow = 
                    Console.ReadLine()
                    .Split(' ')
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0;col < field.GetLength(1); col++)
                {
                    field[row, col] = currentRow[col];
                }
            }
            return field;
        }
        static void FindPositionOfMiner(char[,]field, int size,ref int rowMiner,ref int colMiner)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (field[row, col] == 's')
                    {
                        rowMiner = row;
                        colMiner = col;
                    }
                }
            }
        }
        static int CountTheGoalsInField(char[,]field)
        {
            int count = 0;
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'c')
                    {
                        count++; 
                    }
                }
            }
            return count;

        }
    }
}