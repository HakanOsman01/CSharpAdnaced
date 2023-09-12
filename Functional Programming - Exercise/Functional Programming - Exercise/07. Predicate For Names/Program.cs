namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n=int.Parse(Console.ReadLine());
            Func<string, int, bool> isLessOrEqual = (string word, int lenght) 
                => word.Length <= lenght;
            Console.WriteLine(string.Join(Environment.NewLine,Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Where(x=>isLessOrEqual(x,n))
                .ToArray()));
        }
    }
}