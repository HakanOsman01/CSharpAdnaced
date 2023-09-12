using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> submessionsLanguage = 
                new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> languageByCountSubmissons = new Dictionary<string, int>();
            string content = Console.ReadLine();
            while (content!= "exam finished")
            {
               
                string[] tokens = content
                    .Split('-', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string username = tokens[0];
                string language = tokens[1];
                
                if (language== "banned")
                {
                    BanUsernames(submessionsLanguage, username);
                    content = Console.ReadLine();
                    continue;
                }
                int points = int.Parse(tokens[2]);
                if (!submessionsLanguage.ContainsKey(username)) 
                {
                    submessionsLanguage.Add(username, new Dictionary<string, int>());
                    
                }
                
                if (!submessionsLanguage[username].ContainsKey(language))
                {
                    submessionsLanguage[username].Add(language, points);
                    
                  
                }
                else
                {
                    if (submessionsLanguage[username][language] < points)
                    {
                        submessionsLanguage[username][language] = points;
                    }
                }
                if (!languageByCountSubmissons.ContainsKey(language))
                {
                    languageByCountSubmissons.Add(language, 0);
                }
                languageByCountSubmissons[language]++;
                
                
                content=Console.ReadLine();
            }
            submessionsLanguage=submessionsLanguage
            .OrderByDescending(p=>p.Value.Values.Single())
            .ThenBy(username=>username.Key).ToDictionary(x=>x.Key,x=>x.Value);
            Console.WriteLine("Results:");
           
            foreach(var username in  submessionsLanguage)
            {
                Console.Write($"{username.Key} | ");
                foreach(var currnetPoints in username.Value)
                {
                    Console.Write($"{currnetPoints.Value}");
                }
                Console.WriteLine();



            }
            languageByCountSubmissons=languageByCountSubmissons
                .OrderByDescending(t=>t.Value)
                .ThenBy(l=>l.Key)
                .ToDictionary(x=>x.Key, x=>x.Value);
            Console.WriteLine("Submissions:");
            foreach (var language in languageByCountSubmissons)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }

        }
        static void BanUsernames(Dictionary<string, Dictionary<string, int>>
            submessionsLanguage, string username)
        {
            if (submessionsLanguage.ContainsKey(username))
            {
                submessionsLanguage.Remove(username);
            }
        }
        
    }
   
}