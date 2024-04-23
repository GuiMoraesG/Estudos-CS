using System;
using System.IO;
using System.Collections.Generic;
using HashSet_Ex01.Entities;

namespace HashSet_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime data = DateTime.Parse(line[1]);
                        set.Add(new LogRecord() { UserName = name, Instant = data });
                    }

                    Console.WriteLine("Total Users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
