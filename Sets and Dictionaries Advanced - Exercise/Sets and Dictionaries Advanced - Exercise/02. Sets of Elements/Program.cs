using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]lenghtInSets=Console.ReadLine()
             .Split(' ',StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();
            int n = lenghtInSets[0];
            int m = lenghtInSets[1];
           HashSet<int>firstSet=new HashSet<int>();
           HashSet<int>secondSet=new HashSet<int>();
            for (int i = 0; i <n; i++)
            {
                int currentNumberInFirstSet=int.Parse(Console.ReadLine());
                firstSet.Add(currentNumberInFirstSet);
            }
            for (int i = 0; i < m; i++)
            {
                int currentNumberInSecondSet = int.Parse(Console.ReadLine());
                secondSet.Add(currentNumberInSecondSet);
            }
            foreach(int currentElement in firstSet)
            {
                if (secondSet.Contains(currentElement))
                {
                    Console.Write($"{currentElement} ");
                   // secondSet.Remove(currentElement);
                }
            }
        }
    }
}