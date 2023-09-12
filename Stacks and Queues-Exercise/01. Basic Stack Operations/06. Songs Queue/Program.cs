using System;
using System.Collections;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfSongs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Queue<string> songs = new Queue<string>();
            foreach (string currentSong in arrayOfSongs) 
            {
                songs.Enqueue(currentSong);
            }
            while(songs.Count > 0)
            {
                string command = Console.ReadLine();
                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ",songs.ToArray()));
                }
                else
                {
                
                    string addSong = command.Substring(3).Trim();
                    if (songs.Contains(addSong))
                    {
                        Console.WriteLine($"{addSong} is already contained!");
                        continue;
                    }
                    songs.Enqueue (addSong);
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}