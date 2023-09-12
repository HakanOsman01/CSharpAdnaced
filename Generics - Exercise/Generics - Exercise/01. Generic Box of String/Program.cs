namespace _01._Generic_Box_of_String
{
    public class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                box.Items.Add(value);
               
            }
            Console.WriteLine(box.ToString());
        }
       
    }
}