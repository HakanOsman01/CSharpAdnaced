using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Racing
{
    public class Car
    {
		private string model;
		private double fuelAmount;
		private double fuelConsumptionPerKilometer;
		private double travelledDistance;

        public Car(double fuelAmount,double fuelConsumptionFor1km)
        {
			
			this.fuelAmount = fuelAmount;
			this.fuelConsumptionPerKilometer=fuelConsumptionFor1km;
			this.travelledDistance = 0;
        }
        public string Model
		{
			get { return this.model; }
			set { this.model = value; }
		}
		

		public double FuelAmount
		{
			get { return this.fuelAmount; }
			set { this.fuelAmount = value; }
		}
		public double FuelConsumptionPerKilometer
		{
			get { return this.fuelConsumptionPerKilometer;}
			set { this.fuelConsumptionPerKilometer=value;}
		}
        public double TravelledDistance
        {
            get { return this.travelledDistance; }
            set { this.travelledDistance = value; }
        }

	


    }
}
