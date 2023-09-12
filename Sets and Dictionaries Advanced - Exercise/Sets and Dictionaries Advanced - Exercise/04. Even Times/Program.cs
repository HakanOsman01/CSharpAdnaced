using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            HashSet<int> numbers = new HashSet<int>();
            List<int>evenTimeInSet=new List<int>();
            for (int i = 0; i < n; i++)
            {
                int number=int.Parse(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    evenTimeInSet.Add(number);
                }
                numbers.Add(number);

            }
            int count = 0;
            foreach (int number in numbers) 
            {
                foreach(int evenTime in evenTimeInSet)
                {
                    if (number == evenTime)
                    {
                        count++;
                    }
                }
                if (count % 2 != 0)
                {
                    Console.WriteLine(number);
                }
                count = 0;
            }
            
        }
    }
}