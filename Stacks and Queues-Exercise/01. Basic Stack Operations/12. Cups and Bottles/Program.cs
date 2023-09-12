using System;
using System.Linq;
using System.Collections.Generic;
namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] capacityCups = Console.ReadLine()
             .Split(" ",StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();
            int[] capacityBottles = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            Queue<int>cups=new Queue<int>();
            Stack<int>bottles = new Stack<int>();
            PutInStackAndQueue(capacityCups,capacityBottles,cups,bottles);
            int wastedWater = 0;
            while(cups.Count > 0 && bottles.Count>0)
            {
                int currentCup = cups.Peek();
                int currentBottle = bottles.Peek();
                if (currentBottle >= currentCup)
                {
                    wastedWater += currentBottle - currentCup;
                    cups.Dequeue();
                    bottles.Pop();
                }
                else
                {
                   
                    int remainingCupValue=Math.Abs(currentCup - currentBottle);
                    cups.Dequeue();
                    bottles.Pop();
                    cups.Enqueue(remainingCupValue);
                    SortQueue(cups);

                }
            }
            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ',bottles.ToArray())}");
               
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(' ',cups.ToArray())}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
        static void PutInStackAndQueue(int[] capacityCups, 
            int[] capacityBottles, Queue<int> cups, Stack<int> bottles)
        {
            foreach (int capacity in capacityCups)
            {
                cups.Enqueue(capacity);
            }
            foreach(int  capacityBottle in capacityBottles)
            {
                bottles.Push(capacityBottle);
            }
        }
        static void SortQueue(Queue<int> cups)
        {
            for (int i = 0; i < cups.Count-1; i++)
            {
               int currentCup=cups.Dequeue();
                cups.Enqueue(currentCup);
            }
        }
    }
}