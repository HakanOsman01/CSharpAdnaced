using Problem03.Queue;
using System.Linq;

namespace AnotherQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CustomQueue<int> queue = new CustomQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(queue.Peek());
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            bool isElementThere = queue.Contains(7);
            Console.WriteLine(isElementThere);
        }
    }
}