using System;
using System.Collections.Generic;
using Estudo_Comparison.Entities;

namespace Estudo_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900));
            list.Add(new Product("Celular", 1200));
            list.Add(new Product("Tablet", 400));

            Comparison<Product> comp = (p1,p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            list.Sort(comp);

            foreach (Product p in list) 
            {
                Console.WriteLine(p);
            }
        }
    }
}
