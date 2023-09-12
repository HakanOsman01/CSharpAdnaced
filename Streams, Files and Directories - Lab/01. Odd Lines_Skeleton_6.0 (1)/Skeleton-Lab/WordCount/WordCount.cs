namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            string words = string.Empty;
            using(StreamReader reader = new StreamReader(wordsFilePath))
            {
                words=reader.ReadToEnd();
            }
            string[] wordsArray = words
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string text = string.Empty;
            using (StreamReader reader = new StreamReader(textFilePath))
            {
                text= reader.ReadToEnd();
            }
            string[]textArray= text
                .Split(new string[] {" ","-",", ","."}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Dictionary<string, int> wordOccurences = new Dictionary<string, int>();
            for(int i = 0;i < wordsArray.Length; i++)
            {
                string currentWord = wordsArray[i].ToLower();
                for (int j = 0; j < textArray.Length; j++)
                {
                    if(currentWord== textArray[j].ToLower())
                    {
                        if (!wordOccurences.ContainsKey(currentWord))
                        {
                            wordOccurences.Add(currentWord, 0);
                        }
                        wordOccurences[currentWord]++;
                    }
                }
            }
            wordOccurences=wordOccurences
                .OrderByDescending(w=>w.Value)
                .ToDictionary(x=>x.Key,x=>x.Value);
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach(var kvp in wordOccurences)
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}
