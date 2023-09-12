using System;
using System.Linq;
using System.Collections.Generic;
namespace _10._ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Force> forceApp = new Dictionary<string, Force>();
          
            while (command != "Lumpawaroo")
            {
                string[] tokens = command.Split(new string[] {"|","->"}
                , StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                bool isFirstType = FindTypeCommand(command);
                if (isFirstType)
                {
                    string forceSide = tokens[0].Trim();
                    string forceUser = tokens[1].Trim();
                    if (!forceApp.ContainsKey(forceSide))
                    {
                        forceApp.Add(forceSide, new Force());
                    }
                    forceApp[forceSide].ForceUsers.Add(forceUser);
                }
                else
                {
                    string forceUser = tokens[0].Trim();
                    string forceSide = tokens[1].Trim();
                    string findForceSide = string.Empty;
                    if (forceApp.ContainsKey(forceSide))
                    {
                        bool isFindForceUser = FindForceUser(forceApp,
                            forceUser, ref findForceSide);
                        if (isFindForceUser)
                        {
                            forceApp[findForceSide].ForceUsers.Remove(forceUser);
                            forceApp[forceSide].ForceUsers.Add(forceUser);
                        }
                        else
                        {
                            forceApp[forceSide].ForceUsers.Add(forceUser);
                        }
                       
                    }
                    else
                    {
                        forceApp.Add(forceSide, new Force());
                        forceApp[forceSide].ForceUsers.Add(forceUser);
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");

                }
                command = Console.ReadLine();
            }
            PrintOutput(forceApp);
        }
        static bool FindForceUser(Dictionary<string, Force> forceApp,
            string forceUser, ref string findforceSide)
        {
            bool isFindForceUser = false;
            foreach (var currentForceUser in forceApp)
            {
                HashSet<string> forceMembers = currentForceUser.Value.ForceUsers;
                if (forceMembers.Contains(forceUser))
                {
                    findforceSide = currentForceUser.Key;
                    isFindForceUser = true;
                    break;
                }
            }
            return isFindForceUser;
        }
        static bool FindTypeCommand(string command)
        {
            bool isFirstType= false;
            for (int i = 0; i < command.Length-1; i++)
            {
                if (command[i]=='|')
                {
                    isFirstType= true;
                    break;
                }
                if (command[i]=='-' && command[i+1]=='>') 
                {
                    break;
                }
            }
            return isFirstType;
        }
       
        static void PrintOutput(Dictionary<string, Force> forceApp)
        {
            forceApp = forceApp
            .OrderByDescending(u => u.Value.ForceUsers.Count)
            .ThenBy(name => name.Key)
            .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in forceApp)
            {

                List<string> forceMembers = item.Value.ForceUsers
                .OrderBy(x => x)
                .ToList();

                if (item.Value.ForceUsers.Count != 0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: " +
                $"{item.Value.ForceUsers.Count}");
                    for (int i = 0; i < forceMembers.Count; i++)
                    {
                        Console.WriteLine($"! {forceMembers[i]}");
                    }

                }
               
                

            }
        }
    }
    class Force
    {
        public Force()
        {
            this.ForceUsers = new HashSet<string>();
        }

        public HashSet<string> ForceUsers { get; set; }

    }
}   

    
