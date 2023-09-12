namespace _02._Generic_Box_of_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Box<int> box = new Box<int>();
           int n=int.Parse(Console.ReadLine()); 
           for (int i = 0; i < n; i++)
           {
                int num=int.Parse((Console.ReadLine()));
                box.Items.Add(num);
           }
            Console.WriteLine(box.ToString());
        }
    }
}