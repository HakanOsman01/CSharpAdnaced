namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
           long resultSize=GetFolderSize(folderPath);
            File.WriteAllText(outputFilePath, $"{resultSize/1024} KB");
        }
        public static long GetFolderSize(string folderPath)
        {
            string[] filesPath = Directory.GetFiles(folderPath);
            long size = 0;
            foreach (string file in filesPath)
            {
                FileInfo fileInfo = new FileInfo(file);
                size += fileInfo.Length;
                //Console.WriteLine(file);
            }
            foreach (var dirPath in Directory.GetDirectories(folderPath))
            {
                size += GetFolderSize(dirPath);
            }
            //Console.WriteLine(size);
            //return size;
            //FileStream fileStream = new FileStream("../", FileMode.Create);


        }
    }
}
