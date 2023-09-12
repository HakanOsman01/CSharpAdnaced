using System;
using System.Reflection;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> appendSir = (string msg) => 
            { Console.WriteLine(msg = "Sir " + msg); };
            string[] lines = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            foreach (string line in lines)
            {
                appendSir(line);
            }
        }
    }
}