using System;
using System.Security.Cryptography.X509Certificates;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = p => int.Parse(p);
            int[] input = Console.ReadLine()
           .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(parser)
            .ToArray();
            Console.WriteLine(input.Length);
            Console.WriteLine(input.Sum());

        }
       
    }
}