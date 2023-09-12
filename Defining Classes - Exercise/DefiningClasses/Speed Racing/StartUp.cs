using System;
using System.Runtime.InteropServices;

namespace Speed_Racing
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
          
           int n = int.Parse(Console.ReadLine());
           for (int i = 0; i < n; i++)
           {
                string[]carsParams=Console.ReadLine()
               .Split(" ",StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
                string model = carsParams[0];
                double fuelAmount = double.Parse(carsParams[1]);
                double fuelConsumptionPerKilometer = double.Parse(carsParams[2]);
                Car newCurrentCar = new Car(fuelAmount, fuelConsumptionPerKilometer);
                catalog.AddCar(model, newCurrentCar);
            
           }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmdTokens = command
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
                string carModel = cmdTokens[1];
                int amountKm = int.Parse(cmdTokens[2]);
                catalog.DriveCar(carModel, amountKm);
                command= Console.ReadLine();
               
            }
            catalog.PrintCars();


        }
    }
}