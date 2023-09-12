using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        
        public string Make 
        {
            get
            { 
                return make; 
            }
            set
            {
                make = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            set
            {
                fuelQuantity = value;
            }
        }
        public double FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }
            set
            {
                fuelConsumption = value;
            }
        }
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }
        public Car(string make,string model,int year)
            :this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;

        }
        public Car(string make, string model, int year,double fuelQuantity, 
            double fuelConsumption)
            :this(make,model,year)
        {
            this.FuelQuantity=fuelQuantity;
            this.FuelConsumption=fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity,
          double fuelConsumption,Engine engine, Tire[]tires)
          : this(make, model, year)
        {
            this.Engine= engine;
            this.Tires=tires;
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = fuelQuantity;
        }
        private Engine engine;

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        private Tire[] tires;

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        public double SumTiresPressure()
        {
            double sum = 0.00;
            for (int i = 0; i < Tires.Length; i++)
            {
                sum += Tires[i].Pressure;
            }
            return sum;
        }
        public void Drive(double distance)
        {
          
            bool isSpecialCar =this.Year >= 2017 && this.Engine.HorsePower > 330;
            if (isSpecialCar)
            {
                
                this.fuelQuantity-=(distance/100.00)*this.fuelConsumption;


            }
            
        }
       
        public string WhoAmI()
        {
            return $"Make: {this.Make}\r\nModel: " +
                $"{this.Model}\r\nYear: {this.Year}\r\nFuel: " +
                $"{this.FuelQuantity:F2}\r\n";
        }
        public string ShowSpecialCars()
        {
            return $"Make: {this.Make}\r\nModel: " +
                $"{this.Model}\r\nYear: {this.Year}\r\nHorsePowers: " +
                $"{this.Engine.HorsePower}" +
                $"\r\nFuelQuantity: {this.FuelQuantity}\r\n";
        }
    }
}
