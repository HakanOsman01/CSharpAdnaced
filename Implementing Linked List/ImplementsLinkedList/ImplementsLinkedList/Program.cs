using System.Threading.Channels;

namespace ImplementsLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> linkedList = new DoubleLinkedList<int>();
            linkedList.AddHead(1);
            linkedList.AddHead(2);
            linkedList.AddHead(3);
            linkedList.AddTail(4);
            linkedList.AddTail(5);
            linkedList.AddTail(6);
            //Console.WriteLine($"{linkedList.Head.Value}");
            //Console.WriteLine($"{linkedList.Tail.Value}");
            //linkedList.ForEach(x=>Console.WriteLine(x));
            
            Console.WriteLine("=============");
            linkedList.Reverse();
            linkedList.ForEach(x=> Console.WriteLine(x));

        }
    }
}