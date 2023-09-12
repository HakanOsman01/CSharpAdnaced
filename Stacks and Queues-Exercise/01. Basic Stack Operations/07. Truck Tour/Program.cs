using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();
            for (int i = 1; i <= n; i++)
            {
                int[] array = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                queue.Enqueue(array);
            }
            int startIndex = 0;


            while (true)
            {
                int totalLitters = 0;
                bool isComplete = true;
                foreach (int[] item in queue)
                {
                    int litters = item[0];

                    int distance = item[1];

                    totalLitters += litters;
                    if (totalLitters - distance < 0)
                    {
                        startIndex++;
                        int[] currentPump = queue.Dequeue();
                        queue.Enqueue(currentPump);
                        isComplete = false;
                        break;
                    }
                    totalLitters -= distance;
                }
                if (isComplete)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }

        }
    }
}