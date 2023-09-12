namespace LastDoubleLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(4);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);
            list.AddLast(8);
           foreach (int i in list) 
           {
                Console.WriteLine(i);
           }




        }
    }
}