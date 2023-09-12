namespace _02._Blind_Man_s_Buff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]rowSAndCols=Console.ReadLine()
           .Split(" ",StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();
            int rows = rowSAndCols[0];
            int cols = rowSAndCols[1];
            char[,] field = ReadField(rows, cols);
            int colBlindMan = 0;
            int rowBlindMan = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++) 
                {
                    if (field[i, j] == 'B')
                    {
                        rowBlindMan = i;
                        colBlindMan = j;
                    }
                }
            }
            int movesMade = 0;
            int touchPlayersCount = 0;
            int countPlayers = CountPlayers(field);
            string direction = Console.ReadLine();
            while(direction!= "Finish")
            {
                int currentRowBlind = rowBlindMan;
                int currentColBlind = colBlindMan;
                switch(direction)
                {
                 case "up":
                        currentRowBlind--;

                        break;
                    case "down":
                        currentRowBlind++;
                        break;
                    case "left":
                        currentColBlind--;
                        break;
                    case "right":
                        currentColBlind++;
                        break;
                }
                bool IsOutsiedField = FindIsOutside
                    (field, currentRowBlind, currentColBlind);
                if (IsOutsiedField)
                {
                    direction = Console.ReadLine();
                    continue;
                }
                bool isObstacle = FindIsObstacleTheer(field, currentRowBlind, currentColBlind);
                if (isObstacle)
                {
                    direction= Console.ReadLine();
                    continue;
                }
                bool isPlayer = IsTherePlayer(field, currentRowBlind, currentColBlind);
                if (isPlayer)
                {
                    field[currentRowBlind, currentColBlind] = 'B';
                    field[rowBlindMan, colBlindMan] = '-';
                    touchPlayersCount++;
                    movesMade++;
                }
                else
                {
                    field[currentRowBlind, currentColBlind] = 'B';
                    field[rowBlindMan, colBlindMan] = '-';
                    movesMade++;
                }
                if (countPlayers == touchPlayersCount)
                {
                    break;
                }
                if (rowBlindMan < currentRowBlind)
                {
                    rowBlindMan++;
                }
                else if(rowBlindMan>currentRowBlind)
                {
                    rowBlindMan--;
                }
                if(colBlindMan < currentColBlind)
                {
                    colBlindMan++;
                }
                else if(colBlindMan>currentColBlind)
                {
                    colBlindMan--;
                }
               

               direction = Console.ReadLine();
            }
            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {touchPlayersCount} Moves made: {movesMade}");
        }
        static char[,]ReadField(int rows,int cols)
        {
            char[,]field=new char[rows,cols];
            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col <cols; col++)
                {
                    field[row,col] = currentRow[col];
                }
            }
            return field;
        }
        static bool FindIsOutside(char[,] field, int rowBlindMan, int colBlindMan)
        {
            if(colBlindMan<0 || colBlindMan>=field.GetLength(1) 
                || rowBlindMan<0 || rowBlindMan >= field.GetLength(0))
            {
                return true;
            }
            return false;
        }
        static bool FindIsObstacleTheer(char[,] field, int rowBlindMan,int colBlindMan)
        {
            if (field[rowBlindMan, colBlindMan] == 'O')
            {
                return true;
            }
            return false;
        }
        static bool IsTherePlayer(char[,] field, int rowBlindMan, int colBlindMan)
        {
            if (field[rowBlindMan, colBlindMan]=='P')
            {
                return true;
            }
            return false;
            
        }
        
        static int CountPlayers(char[,] field)
        {
            int count= 0;
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'P')
                    {
                        count++;
                    }
                }
            }
            return count;
        }

    }
}