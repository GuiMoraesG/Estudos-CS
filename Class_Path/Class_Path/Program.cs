using System;
using System.IO;
using System.Security.Cryptography;

namespace Class_Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Teste\teste1.txt";

            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine(Path.PathSeparator);
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFullPath(path));
            Console.WriteLine(Path.GetTempPath());
        }
    }
}
