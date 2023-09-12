namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood=int.Parse(Console.ReadLine());
            int[] ordersInArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> orders = new Queue<int>();
            foreach(int order in ordersInArray)
            {
                orders.Enqueue(order);
            }
            int maxOrder=orders.Max();
            bool isOrdersCompleted = true;

            while(orders.Count>0) 
            {
                int currentOrder = orders.Peek();
                if (quantityOfFood < currentOrder)
                {
                    Console.WriteLine(maxOrder);
                    Console.Write("Orders left: ");
                    Console.WriteLine(string.Join(' ',orders.ToArray()));
                    isOrdersCompleted = false;
                    break;
                }
                quantityOfFood -= currentOrder;
                orders.Dequeue();
            }
            if(isOrdersCompleted)
            {
                Console.WriteLine(maxOrder);
                Console.WriteLine("Orders complete");
            }
        }
        
    }
}