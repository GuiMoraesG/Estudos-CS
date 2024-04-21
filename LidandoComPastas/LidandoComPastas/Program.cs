using System;
using System.IO;
using System.Collections.Generic;

namespace LidandoComPastas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Teste";

            try
            {
                IEnumerable<String> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");

                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                IEnumerable<String> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");

                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
