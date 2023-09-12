namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]players=Console.ReadLine()
             .Split(' ',StringSplitOptions.RemoveEmptyEntries)
             .ToArray();
            Queue<string> queue = new Queue<string>();
            PutInQueue(players, queue);
            int count=int.Parse(Console.ReadLine());
            ProcessHotPatatoGame(queue, count);
            Console.WriteLine($"Last is {queue.Peek()}");
        }
        static void PutInQueue(string[] players, Queue<string> queue)
        {
            foreach (string player in players) 
            {
                queue.Enqueue(player);
            }
        }
        static void ProcessHotPatatoGame(Queue<string> queue, int count)
        {
            while (queue.Count > 1)
            {
                for (int i = 1; i <= count-1; i++)
                {
                    string currentPlayer = queue.Peek();
                    queue.Dequeue();
                    queue.Enqueue(currentPlayer);
                }
                string removedPlayer = queue.Peek();
                Console.WriteLine($"Removed {removedPlayer}");
                queue.Dequeue();
            }
        }
    }
}