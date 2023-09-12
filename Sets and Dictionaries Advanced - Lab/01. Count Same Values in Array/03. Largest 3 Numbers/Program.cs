using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            numbers=numbers.OrderByDescending(num => num).Take(3).ToList();
            Console.WriteLine($"{string.Join(' ',numbers)}");

        }
    }
}