﻿using System;

namespace Bizruntime
{
    internal class Program10
    {
        public static void Main()
        {
            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();

            file1.ReadFile();
            file1.WriteFile("content");

            file2.ReadFile();
            file2.WriteFile("content");
        }
    }

    internal interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }

    internal class FileInfo : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile(string text)
        {
            Console.WriteLine("Writing to file");
        }
    }
}

