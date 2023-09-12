using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(\$|\%)(?<tag>[A-Z][a-z]{3,})\1\: (?<numbers>(\[\d+\]\|){3})$";
            for (int i = 0; i < n; i++)
            {
                string currentLine = Console.ReadLine();
                Match match = Regex.Match(currentLine, pattern);
                if(match.Success)
                {
                    MatchCollection matches = Regex.Matches(currentLine, pattern);
                    foreach (Match matcheCollection in matches)
                    {
                        string currentMessage = match.Groups[4].Value;
                        string currentDecrypthMessage = DecrypthMessage(currentMessage);
                        Console.WriteLine($"{matcheCollection.Groups[3].Value}: {currentDecrypthMessage}");
                    }
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
              
            }
        }
        static string DecrypthMessage(string message)
        {
            int[] numbers = message
                .Split(new char[] { '[', ']', '|' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string decrypthMessage = string.Empty;
            foreach (int currentNum in numbers)
            {
                char currentSymbol = (char)currentNum;
                decrypthMessage = decrypthMessage+currentSymbol;
            }

            return decrypthMessage;
        }
    }
}