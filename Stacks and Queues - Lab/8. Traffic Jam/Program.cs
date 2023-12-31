﻿namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string car=Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int passedCars = 0;
            while (car != "end")
            {
                if (car == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        ++passedCars;
                    }
                }
                else
                {
                    queue.Enqueue(car);
                }
                car = Console.ReadLine();

            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}