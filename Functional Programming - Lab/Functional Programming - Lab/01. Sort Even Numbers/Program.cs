
using Microsoft.VisualBasic;
using System;
using System.Linq.Expressions;
namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ",
                 Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(num => int.Parse(num))
                .Where(num => num % 2 == 0)
                .OrderBy(num=>num).ToArray())); 
           
           
            

        }
        
    }
}