using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int countElements = tokens[0];
            int countPopElements = tokens[1];
            int searchElement = tokens[2];
            Queue<int> queue = new Queue<int>();
            PutElementsInQueue(queue, countElements);
            bool isEmptyQueue = PopElementsInQueue(queue, countPopElements);
            if (isEmptyQueue)
            {
                Console.WriteLine(0);
            }
            else
            {
                if(queue.Contains(searchElement))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int minElement = queue.Min();
                    Console.WriteLine(minElement);
                }
            }

          
        }
        static void PutElementsInQueue(Queue<int>queue, int countElements)
        {
            int[] array = new int[countElements];
             array=Console.ReadLine()
             .Split(' ',StringSplitOptions.RemoveEmptyEntries)
             .Select(num=>int.Parse(num))
             .ToArray();
            foreach(int num in array)
            {
                queue.Enqueue(num);
            }
        }
        static bool PopElementsInQueue( Queue<int>queue, int countPopElements)
        {
            bool isEmptyStack = false;
            for(int i = 0; i < countPopElements; i++)
            {
               
                queue.Dequeue();
                if (queue.Count == 0)
                {
                    isEmptyStack = true;
                    break;
                }
            }
            return isEmptyStack;
        }

    }
}