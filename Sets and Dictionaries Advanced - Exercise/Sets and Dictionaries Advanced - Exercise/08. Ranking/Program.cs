using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ranking =
                new Dictionary<string, string>();
                AddTaks(ranking);
            Dictionary<string, Dictionary<string, int>> interviewTasks = 
                new Dictionary<string, Dictionary<string, int>>();
            ProcessRanking(ranking, interviewTasks);
            string nameBestCandidate = string.Empty;
            int maxPoints= FindBestCandidate(interviewTasks, ref nameBestCandidate);
            Console.WriteLine($"Best candidate is {nameBestCandidate} " +
                $"with total {maxPoints} points.");
            interviewTasks=interviewTasks.OrderBy(s=>s.Key)
               .ToDictionary(x=>x.Key,x=>x.Value);
            Console.WriteLine("Ranking:");
            foreach (var item in interviewTasks)
            {
                Console.WriteLine(item.Key);
                foreach (var task in item.Value.OrderByDescending(x=>x.Value)) 
                {
                    Console.WriteLine($"#  {task.Key} -> {task.Value}");
                }
            }
          


        }
        static void AddTaks(Dictionary<string, string> ranking)
        {
            string contestAndPassword = Console.ReadLine();
            while (contestAndPassword != "end of contests")
            {
                string[] tokens = contestAndPassword
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contest = tokens[0];
                string password = tokens[1];
                if (!ranking.ContainsKey(contest))
                {
                    ranking.Add(contest, " ");

                }
                ranking[contest] = password;
                contestAndPassword = Console.ReadLine();
            }
        }
        static void ProcessRanking(Dictionary<string, string> ranking, Dictionary<string,
            Dictionary<string, int>> interviewTasks)
        {
            string currentSubmissions = Console.ReadLine();
            while (currentSubmissions != "end of submissions")
            {
                string[] tokens = currentSubmissions
                 .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
                string contest = tokens[0];
                string password = tokens[1];
                string user = tokens[2];
                int points = int.Parse(tokens[3]);
                if (ranking.ContainsKey(contest))
                {
                    if (ranking[contest] == password)
                    {
                        if (!interviewTasks.ContainsKey(user))
                        {
                            interviewTasks.Add(user, new Dictionary<string, int>());
                        }
                        if (!interviewTasks[user].ContainsKey(contest))
                        {
                            interviewTasks[user][contest] = points;
                        }

                        else
                        {
                            if (interviewTasks[user][contest] < points)
                            {
                                interviewTasks[user][contest] = points;
                            }
                        }
                        

                    }
                }
                currentSubmissions = Console.ReadLine();
            }
        }
        static int FindBestCandidate(Dictionary<string, 
            Dictionary<string, int>> interviewTasks,ref string bestCandidate)
        {

            int totalPoints = 0;
            int maxPoints = int.MinValue;
            string lastCandiate=string.Empty;
            foreach(var task in interviewTasks)
            {
                foreach(var currrentCandiate in task.Value)
                {
                    totalPoints += currrentCandiate.Value;
                    lastCandiate = task.Key;
                }
                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    bestCandidate =lastCandiate;
                }
                totalPoints = 0;
            }
            return maxPoints;
        }
    }
}