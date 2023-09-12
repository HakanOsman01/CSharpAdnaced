
using System;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] infoAboutRowAndCol = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = infoAboutRowAndCol[0];
            int cols = infoAboutRowAndCol[1];
            char[,]lair= new char[rows, cols];
            ReadLair(lair);
            int rowPlayer = 0;
            int colPlayer = 0;
            FindPositonOfPlayer(lair, ref rowPlayer, ref colPlayer);
            string directions = Console.ReadLine();
            bool isEscapePlayer = false;
            bool isPlayerDead = false;
            List<int> cordinates = CordinatesOfBunnies(lair);
            int rowDead = 0;
            int colDead = 0;
            for (int cur = 0; cur < directions.Length; cur++)
            {
                char currentDirection = directions[cur];
                if (currentDirection == 'R')
                {
                    if (!isCordinateValid(lair, rowPlayer, colPlayer + 1))
                    {
                       
                        lair[rowPlayer, colPlayer] = '.';
                        isEscapePlayer = true;


                    }
                    else   if (lair[rowPlayer, colPlayer + 1] == 'B')
                    {
                        lair[rowPlayer, colPlayer] = '.';
                        isPlayerDead= true;
                        rowDead = rowPlayer;
                        colDead=colPlayer+1;
                        
                     
                        
                    }
                    else
                    {
                        lair[rowPlayer, colPlayer] = '.';
                        lair[rowPlayer, colPlayer + 1] = 'P';
                        colPlayer += 1;
                    }

                    MultiplayeBunnies(lair, cordinates,ref isPlayerDead);
                }
                else if (currentDirection == 'L')
                {
                    if (!isCordinateValid(lair, rowPlayer, colPlayer - 1))
                    {
                     
                        lair[rowPlayer, colPlayer] = '.';
                        isEscapePlayer = true;


                    }
                    else if (lair[rowPlayer, colPlayer - 1] == 'B')
                    {
                        lair[rowPlayer, colPlayer] = '.';
                        isPlayerDead = true;
                        rowDead = rowPlayer;
                        colDead = colPlayer - 1;

                    }
                    else
                    {
                        lair[rowPlayer, colPlayer] = '.';
                        lair[rowPlayer, colPlayer - 1] = 'P';
                        colPlayer -= 1;
                    }

                    MultiplayeBunnies(lair, cordinates, ref isPlayerDead);

                }
                else if (currentDirection == 'U')
                {
                    if (!isCordinateValid(lair, rowPlayer-1, colPlayer))
                    {
                       
                        lair[rowPlayer-1, colPlayer] = '.';
                        isEscapePlayer = true;


                    }
                    else  if (lair[rowPlayer-1, colPlayer] == 'B')
                    {
                        lair[rowPlayer, colPlayer] = '.';
                        isPlayerDead = true;
                        rowDead = rowPlayer-1;
                        colDead = colPlayer;

                    }
                    else
                    {
                        lair[rowPlayer, colPlayer] = '.';
                        lair[rowPlayer-1, colPlayer] = 'P';
                        rowPlayer -= 1;
                    }

                    MultiplayeBunnies(lair, cordinates, ref isPlayerDead);
                }
                else
                {
                    if (!isCordinateValid(lair, rowPlayer + 1, colPlayer))
                    {
                       
                        lair[rowPlayer +1, colPlayer] = '.';
                        isEscapePlayer = true;


                    }
                    else  if (lair[rowPlayer + 1, colPlayer] == 'B')
                    {
                        lair[rowPlayer, colPlayer] = '.';
                        isPlayerDead = true;
                        rowDead = rowPlayer+1;
                        colDead = colPlayer;


                    }
                    else
                    {
                        lair[rowPlayer, colPlayer] = '.';
                        lair[rowPlayer + 1, colPlayer] = 'P';
                        rowPlayer += 1;
                    }

                    MultiplayeBunnies(lair, cordinates, ref isPlayerDead);

                }
                if(isPlayerDead || isEscapePlayer)
                {
                    break;
                }
                cordinates = CordinatesOfBunnies(lair);

            }
            PrintLair(lair);
            if (isPlayerDead) 
            {
                Console.WriteLine($"dead: {rowDead} {colDead}");
            }
            else
            {
                Console.WriteLine($"won: {rowPlayer} {colPlayer}");
            }
          

        }
        static void ReadLair(char[,] lair)
        {
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < lair.GetLength(1); col++)
                {

                    lair[row, col] = currentRow[col];
                    
                }
            }

        }
        static void FindPositonOfPlayer(char[,]lair,ref int rowPlayer,ref int colPlayer)
        {
            bool isFind = false;
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    if (lair[row, col] == 'P')
                    {
                        rowPlayer = row;
                        colPlayer=col;
                        isFind = true;
                        break;
                    }
                }
                if (isFind)
                {
                    break;
                }
            }
        }
        static bool isCordinateValid(char[,]lair,int rowPlayer,int colPlayer)
        {
            if(rowPlayer<0 || rowPlayer>=lair.GetLength(0) 
                || colPlayer<0 || colPlayer >= lair.GetLength(1))
            {
                return false;
            }
            return true;

        }
        static List<int> CordinatesOfBunnies(char[,] lair)
        {
            List<int> cordinates = new List<int>();
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    if (lair[row, col] == 'B')
                    {
                        cordinates.Add(row);
                        cordinates.Add(col);
                    }
                }
            }
            return cordinates;
        }
        static void MultiplayeBunnies(char[,] lair, List<int> cordinates,
            ref bool isPlayerDead)
        {
            for (int cur = 0; cur < cordinates.Count; cur+=2)
            {
                int rowBunnie = cordinates[cur];
                int colBunnie = cordinates[cur+1];
                if (isCordinateValid(lair, rowBunnie, colBunnie + 1))
                {
                    if (lair[rowBunnie, colBunnie+1] != 'B')
                    {
                        if (lair[rowBunnie, colBunnie + 1]=='P')
                        {
                            lair[rowBunnie, colBunnie + 1] = 'B';
                            isPlayerDead = true;

                        }
                        else
                        {
                            lair[rowBunnie, colBunnie + 1] = 'B';
                        }
                    }
                }
                if (isCordinateValid(lair, rowBunnie, colBunnie - 1))
                {
                    if (lair[rowBunnie, colBunnie-1] != 'B')
                    {
                        if (lair[rowBunnie, colBunnie - 1] == 'P')
                        {
                            lair[rowBunnie, colBunnie - 1] = 'B';
                            isPlayerDead = true;

                        }
                        else
                        {
                            lair[rowBunnie, colBunnie - 1] = 'B';
                        }
                    }
                }
                if (isCordinateValid(lair, rowBunnie+1, colBunnie))
                {
                    if (lair[rowBunnie+1, colBunnie] != 'B')
                    {
                        if (lair[rowBunnie+1, colBunnie] == 'P')
                        {
                            lair[rowBunnie+1, colBunnie] = 'B';
                            isPlayerDead = true;

                        }
                        else
                        {
                            lair[rowBunnie+1, colBunnie] = 'B';
                        }
                    }
                }
                if (isCordinateValid(lair, rowBunnie - 1, colBunnie))
                {
                    if (lair[rowBunnie - 1, colBunnie] != 'B')
                    {
                        if (lair[rowBunnie -1, colBunnie] == 'P')
                        {
                            lair[rowBunnie-1, colBunnie] = 'B';
                            isPlayerDead = true;

                        }
                        else
                        {
                            lair[rowBunnie - 1, colBunnie] = 'B';
                        }
                    }
                }
            }
        }
        static void PrintLair(char[,] lair)
        {
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    Console.Write($"{lair[row,col]}");
                }
                Console.WriteLine();
            }
        }
    }
}