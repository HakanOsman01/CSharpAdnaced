using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            int capacity=int.Parse(Console.ReadLine());
            Stack<int>clothes=new Stack<int>();
            int countRacks = 0;
            foreach (int value in values) 
            {
                clothes.Push(value);
            }
            int sumClothes = 0;
            while (true) 
            {
               
                if(clothes.Count == 0)
                {
                    if (sumClothes != 0)
                    {
                        ++countRacks;
                    }
                    break;
                }
                int currentClothe = clothes.Peek();
                sumClothes += currentClothe;
                if (sumClothes > capacity)
                {
                    ++countRacks;
                    sumClothes = 0;
                    continue;
                }
                if (sumClothes == capacity)
                {
                    if (clothes.Count > 0)
                    {
                        ++countRacks;
                        sumClothes = 0;
                       
                    }
                }
                clothes.Pop();

            }
            Console.WriteLine(countRacks);
        }
    }
}