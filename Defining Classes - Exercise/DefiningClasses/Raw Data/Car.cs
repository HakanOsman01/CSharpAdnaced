using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raw_Data
{
    public class Car
    {


        public Car(string model,int speed,int power,
            int weight,string type, double tire1Pressure, 
            int tyre1Age,double tyre2Pressure,int tyre2Age
            ,double tyre3Pressure,int tyre3Age,double tyre4Pressure,
            int tyre4Age) 
        {
            this.Model = model;
            this.Engine=new Engine { Power = power,Speed=speed };
            this.Cargo=new Cargo { Type = type,Weight=weight };
            this.Tires = new Tyre[4];
            Tires[0]=new Tyre { Pressure= tire1Pressure ,Age=tyre1Age};
            Tires[1] = new Tyre { Pressure = tyre2Pressure, Age = tyre2Age };
            Tires[2] = new Tyre { Pressure = tyre3Pressure, Age = tyre3Age };
            Tires[3] = new Tyre { Pressure = tyre4Pressure, Age = tyre4Age };

        }
        public string Model { get; set; }
        public Tyre[] Tires { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        
       
       

    }
}
