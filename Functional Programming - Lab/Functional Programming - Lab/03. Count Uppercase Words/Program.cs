using System.Net;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Predicate<string> isUpperCase = word => char.IsUpper(word[0]);
            string []words = Console.ReadLine()
            .Split(' ',StringSplitOptions.RemoveEmptyEntries)
            .Where(x=>isUpperCase(x))
            .ToArray();
            Console.WriteLine($"{string.Join(Environment.NewLine,words)}");



        }
    }
}