using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Files_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Teste\produtos.txt";
            string finalPath = @"C:\Teste\produtos2.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] data = line.Split(',');

                        string nome = data[0];
                        double valor = double.Parse(data[1]);
                        int qtde = int.Parse(data[2]);

                        string produtoF = $"{nome}, {valor * qtde}";

                        using (StreamWriter sw = File.AppendText(finalPath))
                        {
                            sw.WriteLine(produtoF);
                        }
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
