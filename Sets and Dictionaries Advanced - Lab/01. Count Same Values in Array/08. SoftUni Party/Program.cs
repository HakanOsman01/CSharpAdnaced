using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guestNumber = Console.ReadLine();
            HashSet<string> guests = new HashSet<string>();
            bool isEndCommandIsGiven = false;
            while (guestNumber != "END")
            {
              
                if(guestNumber == "PARTY")
                {
                    guestNumber = Console.ReadLine();
                    while(guestNumber != "END")
                    {
                        if (guests.Contains(guestNumber))
                        {
                            guests.Remove(guestNumber);
                        }
                        guestNumber = Console.ReadLine();

                    }
                    isEndCommandIsGiven = true;
                    
                }
               
                if (isEndCommandIsGiven)
                {
                    break;
                }
                guests.Add(guestNumber);
                guestNumber = Console.ReadLine();
            }
                guests = guests
                .OrderByDescending(g => char.IsDigit(g[0]))
                .ToHashSet();
            Console.WriteLine($"{guests.Count}");
            foreach  (string currentGuestNumber in guests)
            {
                Console.WriteLine(currentGuestNumber);
            }
        }
    }
}