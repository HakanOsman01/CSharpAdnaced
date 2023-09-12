using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Dictionary<string,Dictionary<string,double>>foodShop=
                new Dictionary<string,Dictionary<string,double>>();
            string informatin = Console.ReadLine();
            while(informatin!= "Revision")
            {
                string[] tokensInfo = informatin
                    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string shop = tokensInfo[0];
                string product = tokensInfo[1];
                double price = double.Parse(tokensInfo[2]);
                if(!foodShop.ContainsKey(shop) ) 
                {
                    foodShop.Add(shop, new Dictionary<string, double>());
                }
                foodShop[shop].Add(product, price);
                informatin = Console.ReadLine();
            }
            Dictionary<string,Dictionary<string,double>>orderFoodShop=foodShop
             .OrderBy(x=>x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var currentShop in orderFoodShop)
            {
                Console.WriteLine($"{currentShop.Key}->");
                foreach (var currentProductByPrice in currentShop.Value)
                {
                    Console.WriteLine($"Product: {currentProductByPrice.Key}, Price: " +
                        $"{currentProductByPrice.Value}");
                }
            }
        }
    }
}