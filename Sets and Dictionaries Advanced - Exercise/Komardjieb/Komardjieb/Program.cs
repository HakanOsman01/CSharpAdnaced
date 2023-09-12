using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>>noteBook= 
                new Dictionary<string,List<string>>();
            string line = Console.ReadLine();
            string[] words = line
                .Split(" | ")
                .ToArray();
            foreach (string word in words)
            {
                string[]wordByDefinition= word.Split(":");
                string currentWord = wordByDefinition[0];
                string definion = wordByDefinition[1];
                if(!noteBook.ContainsKey(currentWord))
                {
                    noteBook.Add(currentWord, new List<string>());
                }
                noteBook[currentWord].Add(definion.Trim());
            }
            string[] testWords = Console.ReadLine()
                .Split(" | ")
                .ToArray();
            string command = Console.ReadLine();
            if (command == "Test")
            {
              
                TestNotebook(noteBook, testWords);
            }
            else if(command=="Hand Over")
            {
                HandOverNoteBook(noteBook);
            }
           
        }
       
        static void TestNotebook(Dictionary<string, List<string>> noteBook, string[] testWords)
        {
            foreach (string word in testWords)
            {
                if (noteBook.ContainsKey(word))
                {
                    Console.WriteLine($"{word}:");
                    List<string> definitions = noteBook[word].ToList();
                    foreach (string definition in definitions)
                    {
                        Console.WriteLine($"-{definition}");
                    }
                }
            }
        }
        static void HandOverNoteBook(Dictionary<string, List<string>> noteBook)
        {
            foreach(var word in noteBook)
            {
                Console.Write($"{word.Key} ");
            }
        }
    }
    
}