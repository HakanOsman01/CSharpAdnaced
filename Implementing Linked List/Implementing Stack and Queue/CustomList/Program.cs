using System.Threading.Channels;

namespace CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomList list=new CustomList();
            list.Add(10);
            list.Add(100);
            list.Add(234);
            Action<int>print=(x)=>Console.Write($"{x} ");
            list.ForEach(print);
            Console.WriteLine();
            list.RemoveAt(0);
            list.ForEach(print);
        }
    }
}