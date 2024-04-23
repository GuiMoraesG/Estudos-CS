using System;
using System.Collections.Generic;
using System.Globalization;

namespace CalculationS_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N:");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] value = Console.ReadLine().Split(',');

                string name = value[0];
                double price = double.Parse(value[1], CultureInfo.InvariantCulture);

                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();
            Product max = calculationService.Max(list);

            Console.WriteLine("Most expensive: ");
            Console.WriteLine(max);
        }
    }
}
