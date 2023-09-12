using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Salesman
{
    public class Car
    {
        //"{model} {engine} {weight} {color}
        public Car(string model,Engine engine)
        {
            this.Model=model;
            this.Engine=engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }
        public Car(string model, Engine engine,string weight)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = "n/a";

        }
        public Car(string model, Engine engine, string weight,string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;

        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
        public string PrintCarProps()
        {
            return $"{Model}:\r\n  {Engine.Model}:\r\n" +
                 $" Power: {Engine.Power}\r\n" +
                 $"Displacement: {Engine.Displacement}\r\n" +
                 $"Efficiency: {Engine.Efficiency}\r\n  " +
                 $"Weight: {Weight}\r\n  Color: {Color}\r\n";

        }
    }
}
