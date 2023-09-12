namespace Basic_Algorithms___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]array=Console.ReadLine()
           .Split(' ',StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();
            Console.WriteLine(RecursiveSum(array,0));

        }

        static int RecursiveSum(int[] array, int index)
        {
            if(index == array.Length-1)
            {
                return array[index];
            }
            int currentSum = array[index]+RecursiveSum(array,index+1);
            return currentSum;
        }
    }
}