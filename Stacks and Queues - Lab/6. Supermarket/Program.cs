namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string customer=Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                if (customer == "Paid")
                {
                    while(queue.Count > 0)
                    {
                        string currentCustomer=queue.Peek();
                        Console.WriteLine(currentCustomer);
                        queue.Dequeue();
                    }
                    customer = Console.ReadLine();
                    continue;
                    
                }
                if (customer == "End")
                {
                    break;
                }
                customer = Console.ReadLine();
                queue.Enqueue(customer);
                
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}