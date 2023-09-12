using System.Runtime.CompilerServices;

namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder bulder = new StringBuilder();
           
            using (StreamReader reader = new StreamReader(inputFilePath)) 
            {
               
              string currentLine=reader.ReadLine();
            
              int count = 0;
                while (currentLine != null)
                {
                    if (count % 2 == 0)
                    {
                       currentLine=ReplaceSymbols(currentLine);
                       currentLine=ReverseLine(currentLine);

                    }
                    bulder.Append(currentLine);
                    ++count;
                    currentLine = reader.ReadLine();

                } 
              
                
            }
            return bulder.ToString();
         
           
        }

        private static string ReverseLine(string currentLine)
        {
            string[] reverseLine = currentLine
                .Split(" ")
                .Reverse()
                .ToArray();
            return string.Join(" ", reverseLine);
        }

        private static string ReplaceSymbols(string line)
        {
            StringBuilder builder=new StringBuilder(line);
            string[] symbolsToReplce= { "-", ",", ".", "!", "?" };

            foreach (var symbol in symbolsToReplce)
            {
                builder.Replace(symbol, "@");
            }
            return builder.ToString();
        }
    }
   
}

