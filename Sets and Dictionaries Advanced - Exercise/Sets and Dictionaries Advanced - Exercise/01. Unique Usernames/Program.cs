
using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string>uniqueUsernames= new HashSet<string>();
            List<string>usernameInOrderAdd= new List<string>();
            for (int i = 0; i < n; i++)
            {
                string username= Console.ReadLine();
                uniqueUsernames.Add(username);
            }
           foreach (string username in uniqueUsernames)
           {
                Console.WriteLine(username);
           }
        }
    }
}