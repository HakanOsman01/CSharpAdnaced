namespace OddLines
{
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath)) 
            {
                using(StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string line=reader.ReadLine();
                    int count = 0;
                    while (line != null)
                    {
                        ++count;
                        if(count % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }

                        line= reader.ReadLine();
                    }
                }
            }
        }
    }
}
