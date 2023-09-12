using System;
namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string,int>parser=p=>int.Parse(p);
            int[]numbers=Console.ReadLine()
           .Split(" ",StringSplitOptions.RemoveEmptyEntries)
           .Select(parser)
           .Reverse()
           .ToArray();
           int n=int.Parse(Console.ReadLine());
           Predicate<int> isDivisible = (int num) => num % n != 0;
           numbers=numbers.Where(num=>isDivisible(num)).ToArray();
            Action<int[]> print = p => 
            { Console.WriteLine($"{string.Join(' ', numbers)}"); };
           print(numbers);

        }
    }
}