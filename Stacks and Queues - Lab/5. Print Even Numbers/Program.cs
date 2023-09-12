namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(num=>int.Parse(num))
                .ToArray();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < array.Length; i++)
            {
               int currentNum = array[i];
                if(currentNum%2 == 0)
                {
                    queue.Enqueue(currentNum);
                }
            }
            string output=string.Join(", ", queue.ToArray());
            Console.WriteLine(output);

        }
    }
}