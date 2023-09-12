namespace _03._Generic_Swap_Method_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Box<string>box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                string currentElement=Console.ReadLine();
                box.AddItem(currentElement);

            }
            int[]swapParams=Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int firstIndex = swapParams[0];
            int secondIndex = swapParams[1];
            box.Swap(firstIndex, secondIndex);
            Console.WriteLine(box.ToString());

        }
    }
}