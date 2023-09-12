using System;
using System.Collections.Generic;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[]numbers=Console.ReadLine()
           .Split(' ',StringSplitOptions.RemoveEmptyEntries)
           .Select(double.Parse)
           .ToArray();
            Dictionary<double, int> numbersByOccurence = new Dictionary<double, int>();
            foreach (double number in numbers)
            {
                if (!numbersByOccurence.ContainsKey(number))
                {
                    numbersByOccurence[number] = 0;
                }
                numbersByOccurence[number]++;
            }
            foreach (KeyValuePair<double,int> item in numbersByOccurence)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}