using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            SortedDictionary<char,int>ocurrensInText=new SortedDictionary<char,int>();
            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (!ocurrensInText.ContainsKey(currentSymbol))
                {
                    ocurrensInText.Add(currentSymbol, 0);
                }
                ocurrensInText[currentSymbol]++;

            }
            foreach (var item in ocurrensInText)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}