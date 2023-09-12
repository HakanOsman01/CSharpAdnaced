namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(inputPath))
            {
                Directory.Delete(inputPath,true);
            }
            Directory.CreateDirectory(outputPath);
            string[]files=Directory.GetFiles(inputPath);
            foreach ( var fileName in files)
            {
                Console.WriteLine(fileName);
            }
        }
    }
}
