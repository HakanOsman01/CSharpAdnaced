using System.Text;

namespace Car_Salesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car>cars = new List<Car>();
            List<Engine>engines=new List<Engine>();
            int N=int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[]engineProps=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                if (engineProps.Length == 2)
                {
                    

                    Engine newEngine=new Engine(engineProps[0], int.Parse(engineProps[1]));
                    engines.Add(newEngine);
                    

                }
                else if(engineProps.Length == 3) 
                {
                    Engine newEngine = new Engine(engineProps[0], int.Parse(engineProps[1]), 
                        engineProps[2]);
                    engines.Add(newEngine);
                }
                else
                {
                    Engine newEngine = new Engine(engineProps[0], int.Parse(engineProps[1]),
                        engineProps[2], engineProps[3]);
                    engines.Add(newEngine);
                }
            }
            int M = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                string[] carsProps = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string carModel = carsProps[0];
                string engineModel = carsProps[1];
                if (carsProps.Length == 2)
                {
                    Engine searchEngine = GetEngine(engineModel,engines);
                    Car newCar = new Car(carModel, searchEngine);
                    cars.Add(newCar);
                }
                else if (carsProps.Length == 3)
                {
                    Engine searchEngine = GetEngine(engineModel, engines);
                    Car newCar = new Car(carModel, searchEngine, carsProps[2]);
                    cars.Add(newCar);
                }
                else
                {
                    Engine searchEngine = GetEngine(engineModel, engines);
                    Car newCar = new Car(carModel, searchEngine, carsProps[2], carsProps[3]);
                    cars.Add(newCar);
                }
            }
            foreach (Car car in cars)
            {
                string currentCar=car.PrintCarProps();
                Console.WriteLine(currentCar);
            }
        }
        static Engine GetEngine(string engineModel,List<Engine> engines)
        {
            Engine searchEngine=null;
            foreach (var item in engines)
            {
                if(item.Model== engineModel)
                {
                    searchEngine=item;
                }
            }
            return searchEngine;
        }
    }
   
}