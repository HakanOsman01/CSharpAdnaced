namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            StringBuilder builder = new StringBuilder();
            SortedDictionary<string,Dictionary<string,double>>directoryInfo=
                new SortedDictionary<string, Dictionary<string, double>>();
            string[]files=Directory.GetFiles(inputFolderPath);
            foreach (string file in files)
            {
                FileInfo newFile= new FileInfo(file);
                if (!directoryInfo.ContainsKey(newFile.Extension))
                {
                    directoryInfo.Add(newFile.Extension, new Dictionary<string,double>());
                }
                if (!directoryInfo[newFile.Extension].ContainsKey(newFile.Name))
                {
                    directoryInfo[newFile.Extension].Add(newFile.Name, 0.00);
                    directoryInfo[newFile.Extension][newFile.Name] =newFile.Length / 1024.00;
                }
            }
            foreach (var item in directoryInfo)
            {
                builder.AppendLine(item.Key);
                foreach (var nameByLenght in item.Value)
                {
                    builder.AppendLine($"--{nameByLenght.Key} - {nameByLenght.Value:f3}kb");
                }
            }
            return builder.ToString();
        }
        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
          string path=Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+reportFileName;
          File.WriteAllText(path, textContent);

        }
    }
}
