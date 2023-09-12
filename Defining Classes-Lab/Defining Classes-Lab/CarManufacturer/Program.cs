using System;
namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Tire[]>tires = ProcessTires(command);
            string nextCommand = Console.ReadLine();

            List<Engine>engines = ProcessEngines(nextCommand);
           
            string finalCommand = Console.ReadLine();
            List<Car> cars = GetCars(finalCommand,tires,engines);
            //{make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}

            foreach(Car car in cars)
            {
               double sumPressure=car.SumTiresPressure();
               if(sumPressure>=9 && sumPressure <= 10)
               {
                    car.Drive(20);
                    Console.WriteLine(car.ShowSpecialCars());
               }
            }
        }
        static List<Tire[]> ProcessTires(string command)
        {
            List<Tire[]> tires = new List<Tire[]>();
            while (command != "No more tires")
            {
                double[] tiresValues = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                Tire[] newTires = new Tire[4]
                {
                    new Tire((int)tiresValues[0],tiresValues[1]),
                    new Tire((int)tiresValues[2],tiresValues[3]),
                    new Tire((int)tiresValues[4],tiresValues[5]),
                    new Tire((int)tiresValues[6],tiresValues[7]),

                };
                tires.Add(newTires);

                command = Console.ReadLine();
            }
            return tires;
        }
        static List<Engine> ProcessEngines(string nextCommand)
        {
            List<Engine>engines = new List<Engine>();
            while (nextCommand != "Engines done")
            {
                double[] tokens = nextCommand
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
                int horsePower = (int)tokens[0];
                double cubicCapacity = tokens[1];
                Engine newEngine = new Engine(horsePower, cubicCapacity);
                engines.Add(newEngine);
                nextCommand = Console.ReadLine();

            }
            return engines;

        }
        static List<Car>GetCars(string finalCommand, List<Tire[]>tires,List<Engine>engines)
        {
            List<Car>cars = new List<Car>();
            while (finalCommand != "Show special")
            {
                string[] parametursForCar = finalCommand
                    .Split()
                    .ToArray();
                string make = parametursForCar[0];
                string model = parametursForCar[1];
                int year = int.Parse(parametursForCar[2]);
                double fuelQuantity = double.Parse(parametursForCar[3]);
                double fuelConsumption = double.Parse(parametursForCar[4]);
                int engineIndex = int.Parse(parametursForCar[5]);
                int tiresIndex = int.Parse(parametursForCar[6]);

                Car currentNewCar = new Car(make, model, year, fuelQuantity, fuelConsumption
                    , engines[engineIndex], tires[tiresIndex]);
                cars.Add(currentNewCar);
                finalCommand = Console.ReadLine();
            }
            return cars;
        }
    }
    
}