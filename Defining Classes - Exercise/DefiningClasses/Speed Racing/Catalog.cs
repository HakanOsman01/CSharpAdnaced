using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Speed_Racing
{
    public class Catalog
    {
        public Dictionary<string,Car>Cars { get; set; }
        public Catalog()
        {
            this.Cars = new Dictionary<string, Car>();
        }
        public void AddCar(string carModel,Car car)
        {
            if (!this.Cars.ContainsKey(carModel))
            {
                this.Cars.Add(carModel, car);
            }
        }
        public void DriveCar(string carModel,int amountKm)
        {
            if(Cars.ContainsKey(carModel))
            {
                double consume = (amountKm*this.Cars[carModel].FuelConsumptionPerKilometer);
                if (consume > this.Cars[carModel].FuelAmount)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                    
                }
                else
                {
                    this.Cars[carModel].FuelAmount -= consume;
                    this.Cars[carModel].TravelledDistance += amountKm;

                }
            }
        }
        public void PrintCars()
        {
            foreach (var car in this.Cars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} " +
                    $"{car.Value.TravelledDistance}");
            }
        }
    }
}
