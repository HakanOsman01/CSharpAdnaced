using System;
using System.Linq;
using System.Collections.Generic;
namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Func<string, int, bool> getSum = (name, sum) => name.Sum(ch => ch) >= sum;
            Func<string[], int, Func<string, int, bool>, string> getFirstName = (names, sum, match) =>
            {
               return names.FirstOrDefault(name => match(name, sum));
            };
            int num = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(getFirstName(names,num,getSum));
            FileStream reader=Fi
        }
      
    }
}