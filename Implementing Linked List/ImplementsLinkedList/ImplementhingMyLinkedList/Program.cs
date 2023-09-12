using System.Threading.Channels;

namespace ImplementhingMyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DoubleLinkedList linkedList = new DoubleLinkedList();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(6);
            Action<int>print=p=>Console.WriteLine(p);
            linkedList.ForEach(print);
            //linkedList.ForEach(print);
            //linkedList.ForEach(print);
        }
    }
}