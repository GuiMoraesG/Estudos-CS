using System;
using System.IO;

namespace Bloco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Teste\teste.txt";

            try
            {

                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
