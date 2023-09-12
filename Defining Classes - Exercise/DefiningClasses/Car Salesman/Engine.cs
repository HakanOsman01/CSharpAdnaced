using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Car_Salesman
{
    public class Engine
    {
        public Engine(string model,int power)
        {
            this.Model = model;
            this.Power = power;
            this.Efficiency = "n/a";
            this.Displacement = "n/a";
        }
        public Engine(string model, int power, string displacement)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = "n/a";
        }
        public Engine(string model, int power, string displacement, string efficiency )
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }
       

    }
}
