using System;
using System.IO;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Teste\Teste-CS.txt";
            string targetPath = @"C:\Teste\Teste-CS2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
        }
    }
}
