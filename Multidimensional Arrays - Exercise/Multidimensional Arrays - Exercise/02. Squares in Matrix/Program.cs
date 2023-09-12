namespace _02._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine()
           .Split(' ', StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();
            int rowSize = info[0];
            int colSize = info[1];
            char[,]matrix=ReadMatrix(rowSize, colSize);
            int countSquaresEqual = FindCountSquaresEqual(matrix,rowSize,colSize);
            Console.WriteLine(countSquaresEqual);
        }

        static int FindCountSquaresEqual(char[,] matrix,int countRows,int countCols)
        {
            int count = 0;
            for (int row = 0; row < countRows; row++)
            {
                for (int col = 0; col < countCols; col++)
                {
                    char currentSymbol= matrix[row,col];
                    if (col + 1 < countCols && row+1<countRows)
                    {
                        if (currentSymbol == matrix[row,col+1]
                            && currentSymbol == matrix[row+1,col] 
                            && currentSymbol == matrix[row+1,col+1])
                        {
                            ++count;
                        }
                    }
                }

            }
            return count;
        }
        

        static char[,] ReadMatrix(int rowSize,int colSize)
        {
            char[,] matrix = new char[rowSize, colSize];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(symbol => char.Parse(symbol))
                .ToArray();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            return matrix;
        }
    }
}