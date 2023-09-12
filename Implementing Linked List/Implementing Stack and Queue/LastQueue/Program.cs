using Problem01.FasterQueue;

namespace LastQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
           FastQueue<int>queue = new FastQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            //Console.WriteLine($"{queue.Peek()}");
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }


        }
    }
}