namespace _03._Sum_of_Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //int fibonacii=int.Parse(Console.ReadLine());
           int[]array=new int[5];
            //int index = 0;
            int countCombination = 0;
           BruteForce(ref countCombination,array, 0);
           Console.WriteLine(countCombination);

        }

        static void BruteForce(ref int count,int[] array, int index)
        {
            if (index >= array.Length)
            {
                Console.WriteLine($"{string.Join(string.Empty,array)}");
                count++;
                return;
            }
            for (int i = 0; i <= 9; i++) 
            {
                array[index] = i;
                BruteForce(ref count,array, index + 1);
            }
        }

    }
}