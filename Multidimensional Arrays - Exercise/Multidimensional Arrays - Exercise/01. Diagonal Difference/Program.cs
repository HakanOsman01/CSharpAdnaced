namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix=ReadMatrix(size);
            int leftDiagonaSum=FindLeftDiagonalSum(matrix);
            int rightDiagonalSum = FindRightDiagonalSum(matrix);
            int diffrence=Math.Abs(leftDiagonaSum-rightDiagonalSum);
            Console.WriteLine(diffrence);

        }

        static int FindRightDiagonalSum(int[,] matrix)
        {
            int sum = 0;
            for (int row = 0;row< matrix.GetLength(0); row++)
            {
                sum += matrix[row, matrix.GetLength(0) - row - 1];
            }
            return sum;
        }

        static int[,] ReadMatrix(int size)
        {
            int [,]matrix=new int[size,size];
            for (int row = 0;row<matrix.GetLength(0);row++ )
            {
                 int[] currentRow = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(num => int.Parse(num))
                 .ToArray();
                for (int col = 0; col <matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }   
            }
            return matrix;
        }
        static int FindLeftDiagonalSum(int[,] matrix)
        {
            int sum = 0;
            for (int cur = 0; cur < matrix.GetLength(0); cur++)
            {
                sum += matrix[cur, cur];
            }
            return sum;
        }
    }
}