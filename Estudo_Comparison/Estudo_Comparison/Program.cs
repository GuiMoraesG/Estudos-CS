using System;
using System.Linq;
using System.Collections.Generic;
using Estudo_Comparison.Entities;

namespace Estudo_Comparison
{
    internal class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900));
            list.Add(new Product("Tablet", 40));
            list.Add(new Product("Celular", 1200));
            list.Add(new Product("Mouse", 80));

            Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(func).ToList();

            foreach (string product in result)
            {
                Console.WriteLine(product);
            }
        }

        public static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
