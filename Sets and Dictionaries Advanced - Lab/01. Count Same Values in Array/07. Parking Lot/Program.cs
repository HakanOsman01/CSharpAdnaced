using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directionAndCarNumber=Console.ReadLine();
            HashSet<string> carNumbers = new HashSet<string>();
            while(directionAndCarNumber != "END")
            {
                string[]tokens=directionAndCarNumber
                 .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
                string inOrOut = tokens[0];
                string carNumber = tokens[1];
                if(inOrOut == "IN")
                {
                    if (!carNumbers.Contains(carNumber))
                    {
                        carNumbers.Add(carNumber);
                    }
                }
                else
                {
                    if(carNumbers.Contains(carNumber))
                    {
                        carNumbers.Remove(carNumber);
                    }
                }
                directionAndCarNumber = Console.ReadLine();
            }
            if (carNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach(string currentCarNumber in carNumbers)
                {
                    Console.WriteLine(currentCarNumber);
                }
            }
        }
    }
}