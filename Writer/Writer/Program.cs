using System;
using System.IO;

namespace Writer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Teste\teste1.txt";
            string targetPath = @"C:\Teste\teste2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
