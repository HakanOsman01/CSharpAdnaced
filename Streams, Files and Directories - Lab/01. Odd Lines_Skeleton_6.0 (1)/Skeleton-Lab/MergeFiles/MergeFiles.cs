namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, 
            string secondInputFilePath, string outputFilePath)
        {
            string[]linesFirstFilePath=File.ReadAllLines(firstInputFilePath);
            string[]linesSecondFilePath=File.ReadAllLines(secondInputFilePath);
            int minLenght=Math.Min(linesFirstFilePath.Length, linesSecondFilePath.Length);
           
           using(StreamWriter writer = new StreamWriter(outputFilePath))
           {
                for (int i = 0; i < minLenght; i++)
                {
                    writer.WriteLine(linesFirstFilePath[i]);
                    writer.WriteLine(linesSecondFilePath[i]);
                }
                for (int i = minLenght; i < linesSecondFilePath.Length; i++)
                {
                    writer.WriteLine(linesSecondFilePath[i]);
                }
              
           }
        }
    }
}
