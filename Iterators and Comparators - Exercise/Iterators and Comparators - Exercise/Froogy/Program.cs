namespace Froogy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Func<string,int>parser=(s)=>int.Parse(s);
            int[]valuesInLake=Console.ReadLine()
            .Split(", ",StringSplitOptions.RemoveEmptyEntries)
            .Select(parser)
            .ToArray();
            Lake lake = new Lake(valuesInLake);
            int count = 0;
            int[]outputLake=new int[valuesInLake.Length];
            foreach (var item in lake)
            {
                outputLake[count] = item;
                count++;
            }
            string output = string.Join(", ", outputLake);
            Console.WriteLine(output);
        }
    }
}