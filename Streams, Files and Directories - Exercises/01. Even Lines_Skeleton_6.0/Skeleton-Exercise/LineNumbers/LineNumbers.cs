namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {

            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);
            int count = 0;
            
            
            using (reader)
            {
                string line = reader.ReadLine();
                using (writer)
                {
                    while (line != null)
                    {
                        int lettersCount = CountLetters(line);
                        int punctionCount = CountPunctuation(line);
                        writer.WriteLine($"Line {++count}: {line} ({lettersCount})({punctionCount})");
                        line= reader.ReadLine();
                    }
                 
                }
            }
        }
        
        
        public static int CountLetters(string line)
        {
            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (char.IsLetter(currentSymbol))
                {
                    count++;
                }
            }
            return count;
        }
        public static int CountPunctuation(string line)
        {
            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (char.IsPunctuation(currentSymbol))
                {
                    count++;
                }
            }
            return count;

        }
    }
}
