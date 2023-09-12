using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = ProcessWardrobe(n);
            PrintOutput(wardrobe);
        }
        static Dictionary<string, Dictionary<string, int>> ProcessWardrobe(int n)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe =
                new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new string[] {" -> ",","}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string color = tokens[0];
               
               
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j = 1; j < tokens.Length; j++)
                {
                    string currentClothing = tokens[j];
                    if (!wardrobe[color].ContainsKey(currentClothing))
                    {
                        wardrobe[color].Add(currentClothing ,0);
                    }
                    wardrobe[color][currentClothing]++;

                }


            }
            return wardrobe;
        }
        static void PrintOutput(Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            string[] searchInWardrobe = Console.ReadLine()
             .Split(" ",StringSplitOptions.RemoveEmptyEntries)
             .ToArray();
            string searchColor = searchInWardrobe[0];
            string searchClothe = searchInWardrobe[1];
            foreach (var clothByColor in wardrobe)
            {
                Console.WriteLine($"{clothByColor.Key} clothes:");
                foreach (var cloth in clothByColor.Value)
                {
                    string printItem=$"* {cloth.Key} - {cloth.Value}";
                    if (clothByColor.Key == searchColor && cloth.Key==searchClothe)
                    {
                        printItem += " (found!)";
                    }
                    Console.WriteLine(printItem);

                }
            }
        }
    }
}