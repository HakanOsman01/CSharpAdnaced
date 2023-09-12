using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Statistics
            string command = Console.ReadLine();
          Dictionary<string,Vloger>vlogers = new Dictionary<string,Vloger>();
            while (command != "Statistics") 
            {
                string[]tokens=command
               .Split(' ',StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
                string firstVloger = tokens[0];
                string typeOfAction = tokens[1];
                string secondVloger = tokens[2];
                if(typeOfAction== "joined")
                {
                    JoinTLoggers(vlogers, firstVloger);
                }
                else
                {
                    if(vlogers.ContainsKey(firstVloger) && vlogers.ContainsKey(secondVloger))
                    {
                        FollowingVlogers(vlogers, firstVloger, secondVloger);

                    }
                   
                }
                command = Console.ReadLine();
            }
           
            Console.WriteLine($"The V-Logger has a total of {vlogers.Keys.Count} " +
                $"vloggers in its logs.");
            FindTheMostFallowedVloger(vlogers);
            int count = 1;
            vlogers=vlogers.OrderByDescending(f=>f.Value.fallowers.Count)
            .ThenBy(f=>f.Value.fallowing.Count)
            .ToDictionary(x => x.Key, x => x.Value);
            foreach(var item in vlogers)
            {
                Console.WriteLine($"{++count}. {item.Key} : " +
                    $"{item.Value.fallowers.Count} followers, " +
                    $"{item.Value.fallowing.Count} following");
            }
        }
        static void JoinTLoggers(Dictionary<string, Vloger> vlogers, string vlogerName)
        {
            bool checkIsOneWord = true;
            for (int i = 0; i < vlogerName.Length; i++)
            {
                char currentChar = vlogerName[i];
                if(char.IsWhiteSpace(currentChar)) 
                {
                    checkIsOneWord = false;
                    break;
                }
              

            }
            if (!vlogers.ContainsKey(vlogerName) && checkIsOneWord)
            {
                vlogers.Add(vlogerName,new Vloger());
            }
        }
        static void FollowingVlogers(Dictionary<string, Vloger> vlogers, string firstVloger, string secondVloger)
        {

            if (firstVloger!=secondVloger)
            {
                vlogers[firstVloger].AddFallowing(secondVloger);
                vlogers[secondVloger].AddFallowers(firstVloger);
                

            }
            
        }
        static void FindTheMostFallowedVloger(Dictionary<string, Vloger> vlogers)
        {
            int maxFallowers = int.MinValue;
            string mostFamousVloger = string.Empty;
            foreach (var currentVloger in vlogers)
            {
                if (currentVloger.Value.fallowers.Count>maxFallowers)
                {
                    mostFamousVloger = currentVloger.Key;
                    maxFallowers = currentVloger.Value.fallowers.Count;

                }
                else if(currentVloger.Value.fallowers.Count == maxFallowers)
                {

                    if (currentVloger.Value.fallowing.Count 
                        < vlogers[mostFamousVloger].fallowing.Count)
                    {
                        mostFamousVloger=currentVloger.Key;
                    }
                }
             
            }
            Console.WriteLine($"1. {mostFamousVloger} : {vlogers[mostFamousVloger].fallowers.Count} " +
                 $"followers, {vlogers[mostFamousVloger].fallowing.Count} following");
            string[] arrayOfFollowing = vlogers[mostFamousVloger]
                .fallowers.OrderBy(f => f)
                .ToArray();
            for (int i = 0; i < arrayOfFollowing.Length; i++)
            {
                Console.WriteLine($"*  {arrayOfFollowing[i]}");
            }
            vlogers.Remove(mostFamousVloger);
        }
    }
    class Vloger
    {
        public Vloger()
        {
            this.fallowers = new HashSet<string>();
            this.fallowing=new HashSet<string>();
        }
        public HashSet<string> fallowers { get; set; }
        public HashSet<string> fallowing { get; set; }
        public void AddFallowers(string fallower)
        {
            this.fallowers.Add(fallower);
        }
        public void AddFallowing(string fallowing)
        {
            this.fallowing.Add(fallowing);
        }

    }
}