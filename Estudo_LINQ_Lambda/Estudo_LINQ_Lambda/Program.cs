using System;
using System.Collections.Generic;
using System.Linq;
using Estudo_LINQ_Lambda.Entities;

namespace Estudo_LINQ_Lambda
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);

            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Electronics", 1);

            List<Product> products = new List<Product>()
            {
                new Product(1, "Computer", 1100, c2),
                new Product(2, "Hammer", 13440, c1),
                new Product(3, "Tv", 1220, c3),
                new Product(4, "Notebook", 20, c2),
                new Product(5, "Saw", 80, c1),
                new Product(6, "Tablet", 1200, c2),
                new Product(7, "Camera", 580, c3),
                new Product(8, "Printer", 4000, c3),
                new Product(9, "Sound Bar", 1100, c3),
                new Product(10, "Lever", 350, c1),
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            Print("Tier 1 AND PRICE < 900: ", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS: ", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH C", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE AND NAME", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("SKIP 2 AND TAKE 4", r5);

            var r6 = products.First();
            Console.WriteLine("First: " + r6);

            var r7 = products.Max(p => p.Price);
            Console.WriteLine("MAX PRICE: " + r7);

            var r8 = products.Min(p => p.Price);
            Console.WriteLine("MIN PRICE: " + r8);

            var r9 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("SUM: " + r9);

            var r10 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("Aggregate:" + r10);
        }
    }
}
