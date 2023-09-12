using System;
using System.Linq;

namespace _07._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size=int.Parse(Console.ReadLine());
            char[,]matrix=new char[size,size];
            ReadMatrix(matrix);
            int knightsRomoved = 0;
            while(true)
            {
                int countMostAttacking = 0;
                int rowsMostAttacking = 0;
                int columnsMostAttacking = 0;
                for(int row = 0; row < size; row++)
                {
                    for(int col = 0; col < size; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int attackKnights = CountAttacksKnights(matrix,row, col,size);
                             if (countMostAttacking < attackKnights)
                             {
                                countMostAttacking = attackKnights;
                                rowsMostAttacking = row;
                                columnsMostAttacking = col;
                             }
                        }

                    }
                }
                if (columnsMostAttacking == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowsMostAttacking, columnsMostAttacking] = '0';
                    knightsRomoved++;
                }

            }
            Console.WriteLine(knightsRomoved);
        }

        static int CountAttacksKnights(char[,]matrix,int row, int col,int size)
        {
            int attakedKnights = 0;

            //horisontal left-up
            if (CellIsValid(row - 1, col - 2,size))
            {
                if (matrix[row - 1, col - 2] == 'K')
                {
                    attakedKnights++;

                }
                
            }
            //horisontal left-down
            if (CellIsValid(row + 1, col - 2,size))
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    attakedKnights++;
                }
            }
            //horisontal right-up
            if (CellIsValid(row - 1, col + 2, size))
            {
                if (matrix[row - 1, col + 2]=='K')
                {
                    attakedKnights++;

                }
                
            }
            //horisontal right-down
            if (CellIsValid(row +1, col + 2, size))
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    attakedKnights++;

                }

            }
            //vertical up-left
            if (CellIsValid(row - 2, col - 1, size))
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    attakedKnights++;

                }

            }
            //vertical up-left
            if (CellIsValid(row + 2, col - 1, size))
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    attakedKnights++;

                }

            }
            //vertical up-right
            if (CellIsValid(row - 2, col + 1, size))
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    attakedKnights++;

                }

            }
            //vertical down-right
            if (CellIsValid(row + 2, col + 1, size))
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    attakedKnights++;

                }

            }
            return attakedKnights;
        }

        static void ReadMatrix(char[,]matrix)
        {
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            
        }
        static  bool CellIsValid(int row, int col,int size)
        {
            return row>=0 && row<size && col>=0 && col<size;
        }
    }
}