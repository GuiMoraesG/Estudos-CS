using Estudo_LINQ_Ex01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Estudo_LINQ_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Path: ");
            string path = Console.ReadLine();
            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] produto = sr.ReadLine().Split(',');
                    string name = produto[0];
                    double price = double.Parse(produto[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }
            }

            var r1 = list.Select(x => x.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Average price: {r1}");

            var names = list.Where(p => p.Price <= r1).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
