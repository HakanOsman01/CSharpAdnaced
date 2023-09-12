namespace _03._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,]matrix=new int[size,size];
            ReadMatrix(matrix);
            int sum=FindSumPrimaryDiagonal(matrix);
            Console.WriteLine(sum);

        }
        static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(num => int.Parse(num))
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
           
        }
        static int FindSumPrimaryDiagonal(int[,] matrix)
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