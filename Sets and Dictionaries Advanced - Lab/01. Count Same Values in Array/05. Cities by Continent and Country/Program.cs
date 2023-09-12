using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>>continetsByContryAndCities=
                new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] currentInformation = Console.ReadLine()
                    .Split()
                    .ToArray();
                string continent = currentInformation[0];
                string contry = currentInformation[1];
                string city = currentInformation[2];
                if (!continetsByContryAndCities.ContainsKey(continent))
                {
                    continetsByContryAndCities
                    .Add(continent, new Dictionary<string, List<string>>());
                   
                }
                if (!continetsByContryAndCities[continent].ContainsKey(contry))
                {
                    continetsByContryAndCities[continent].Add(contry, new List<string>());
                }
                continetsByContryAndCities[continent][contry].Add(city);
               
            }
            foreach(var continent in continetsByContryAndCities)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach(var contryByCities in continent.Value)
                {
                    Console.WriteLine($"  {contryByCities.Key} -> " +
                        $"{string.Join(", ",contryByCities.Value)}");
                }
            }
        }
    }
}