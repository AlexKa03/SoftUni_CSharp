﻿namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using (var archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(inputFilePath, Path.GetFileName(inputFilePath));
            }
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            using (ZipArchive archive = ZipFile.OpenRead(zipArchiveFilePath))
            {
                var entry = archive.GetEntry(Path.GetFileName(fileName));

                if (entry != null)
                {
                    entry.ExtractToFile(outputFilePath, true);
                }
            }

            DirectoryInfo dirInfo = new DirectoryInfo(zipArchiveFilePath);
            FileInfo[] fileInfo = dirInfo.Parent.GetFiles();

            foreach (var file in fileInfo)
            {
                if (file.Extension.ToLower() == ".zip")
                {
                    file.Delete();
                }
            }
        }
    }
}
