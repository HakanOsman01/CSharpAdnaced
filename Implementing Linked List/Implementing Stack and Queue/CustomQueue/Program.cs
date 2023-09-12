namespace CustomQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
           CustomQueue queue = new CustomQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Action<int>print=(q)=>Console.Write($"{q} ");
            queue.ForEach(print);
            // queue.Clear();
            int firstElement=queue.Dequeue();
            int secondElement=queue.Dequeue();
            Console.WriteLine();
            queue.ForEach(print);
            int thirdElement=queue.Peek();
            Console.WriteLine();
            Console.WriteLine(thirdElement);
        }
    }
}