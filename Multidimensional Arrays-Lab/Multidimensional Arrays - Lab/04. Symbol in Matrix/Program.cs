namespace _04._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size=int.Parse(Console.ReadLine());
            char[,]matrix=ReadMatrix(size);
            char searchSymbol=char.Parse(Console.ReadLine());
            bool isFindCharacter=false;

            int findRow = 0;
            int findColumn = 0;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (searchSymbol == matrix[row, col])
                    {
                        findRow = row;
                        findColumn = col;
                        isFindCharacter = true;
                        break;
                    }
                }
                if (isFindCharacter)
                {
                    break;
                }
            }
            if(isFindCharacter)
            {
                Console.WriteLine($"({findRow}, {findColumn})");
            }
            else
            {
                Console.WriteLine($"{searchSymbol} does not occur in the matrix");
            }

        }
        static char[,] ReadMatrix(int size)
        {
            char[,]matrix=new char[size,size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                 string line=Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            return matrix;

        }
    }
}