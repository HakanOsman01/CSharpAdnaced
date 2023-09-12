namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        { 
            FileInfo fileInfo = new FileInfo(sourceFilePath);
            int biggerCount = 0;

            if (fileInfo.Length % 2 !=0)
            {
                biggerCount++;
            }
            FileStream writer = new FileStream(partOneFilePath, FileMode.Create);
            FileStream reader=new FileStream(sourceFilePath, FileMode.Open);
            using (reader)
            {
                byte[] buffer = new byte[1024];
               

                using (writer)
                {
                    while (reader.Length / 2 + biggerCount > reader.Position)
                    {
                        reader.Read(buffer, 0, buffer.Length);
                        writer.Read(buffer,0, buffer.Length);
                        writer.Position=reader.Position;
                    }
                }
               
            }


        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
        }
    }
}