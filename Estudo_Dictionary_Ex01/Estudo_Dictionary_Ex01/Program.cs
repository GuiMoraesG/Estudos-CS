using System;
using System.Collections.Generic;
using System.IO;

namespace Estudo_Dictionary_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Path: ");
            string path = Console.ReadLine();
            Console.WriteLine();


            using (StreamReader sr = File.OpenText(path))
            {
                Dictionary<string, int> list = new Dictionary<string, int>();

                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string nome = line[0];
                    int votos = int.Parse(line[1]);

                    if (list.ContainsKey(nome))
                    {
                        list[nome] += votos;
                    }
                    else
                    {
                        list[nome] = votos;
                    }
                }

                foreach (KeyValuePair<string, int> pair in list)
                {
                    Console.WriteLine(pair);
                }
            }
        }
    }
}
