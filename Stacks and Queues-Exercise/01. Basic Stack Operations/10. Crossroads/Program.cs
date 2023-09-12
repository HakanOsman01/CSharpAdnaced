using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            while (input != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }
                int currentGreenLight = greenLight;
                while (currentGreenLight > 0 && cars.Count > 0)
                {
                    string currentCar = cars.Dequeue();
                    if (currentGreenLight - currentCar.Length >= 0)
                    {
                        currentGreenLight -= currentCar.Length;
                        passedCars++;
                        continue;
                    }
                    if (currentGreenLight + freeWindow - currentCar.Length >= 0)
                    {
                        currentGreenLight = 0;
                        passedCars++;
                        continue;
                    }
                    //Hammer
                    int hittetChar = currentGreenLight + freeWindow;

                    Console.WriteLine("A crash happened!");

                    Console.WriteLine($"{currentCar} was hit at {currentCar[hittetChar]}.");

                    Environment.Exit(0);
                }


                input = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}