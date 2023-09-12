using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array =
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int N = array[0];
            int S = array[1];
            int X = array[2];
            Queue<int> queue = new Queue<int>();
            ReadTheQueue(queue, N);
            for (int cur = 1; cur <= S; cur++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (queue.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int smallestElement = FindSmallestElementInQueue(queue);
                    Console.WriteLine(smallestElement);

                }
            }

        }
        static void ReadTheQueue(Queue<int> queue, int N)
        {
            int[] readArray = new int[N];
            int[] theArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < N; i++)
            {
                readArray[i] = theArray[i];
            }
            foreach (int currentNumber in readArray)
            {
                queue.Enqueue(currentNumber);
            }
        }
        static int FindSmallestElementInQueue(Queue<int> queue)
        {
            int smallestElement = int.MaxValue;
            foreach (int currentNumber in queue)
            {
                if (smallestElement > currentNumber)
                {
                    smallestElement = currentNumber;
                }
            }
            return smallestElement;
        }
    }
}
