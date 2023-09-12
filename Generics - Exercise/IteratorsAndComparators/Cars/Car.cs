using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
     class Car:IComparable<Car>
     {
        public int HorsePower { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public int CompareTo(Car other)
        {
            return HorsePower.CompareTo(other.HorsePower);
        }

  
     }
}
