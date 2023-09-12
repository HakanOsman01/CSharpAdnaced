using System;
using System.Collections.Generic;
namespace _01._Rubber_Duck_Debugers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> times = new Queue<int>(Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse));

            Stack<int> tasks = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Dictionary<string, int> ducks = new Dictionary<string, int>()
             {
             { "Darth Vader Ducky", 0 },
             { "Thor Ducky", 0 },
             { "Big Blue Rubber Ducky", 0 },
             { "Small Yellow Rubber Ducky", 0 }
            };
            ProcessDucky(times, tasks, ducks);
            Console.WriteLine("Congratulations, all tasks have been completed! " +
                "Rubber ducks rewarded:");
            foreach (var kvp in ducks)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
        static void ProcessDucky(Queue<int> times, Stack<int> tasks, Dictionary<string, int> ducks)
        {
            while(times.Count>0 || tasks.Count > 0)
            {
                int currentTime=times.Peek();
                int currentTask = tasks.Peek();
                int result = currentTask * currentTime;
                if(result>=0 && result <= 60)
                {
                    ducks["Darth Vader Ducky"]++;
                    RemoveTaskAndTime(times, tasks);
                }
                else if(result>=61 && result <= 120)
                {
                    ducks["Thor Ducky"]++;
                    RemoveTaskAndTime(times, tasks);

                }
                else if(result>=121 && result <= 180)
                {
                    ducks["Big Blue Rubber Ducky"]++;
                    RemoveTaskAndTime(times, tasks);
                }
                else if (result>=181 && result<=240)
                {
                    ducks["Small Yellow Rubber Ducky"]++;
                    RemoveTaskAndTime(times, tasks);
                }
                else
                {
                   times= HighterRangeCase(times, tasks); 

                }
            }
        }
        static void RemoveTaskAndTime(Queue<int> times, Stack<int> tasks)
        {
            times.Dequeue();
            tasks.Pop();
        }
        static Queue<int> HighterRangeCase(Queue<int> times, Stack<int> tasks)
        {
            int currentTask=tasks.Peek()-2;
            tasks.Pop();
            tasks.Push(currentTask);
            int currentTime = times.Peek();
            times.Dequeue();
            Queue<int> newTimes = times;
            newTimes.Enqueue(currentTime);
            return newTimes;
        }

    }
}