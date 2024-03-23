﻿using System;
using System.Collections.Generic;
using Heranca_Ex02.Entities;

namespace Heranca_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)?");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manufacture));
                }
                else if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine("Price TAGS: ");

            foreach (Product product in list) 
            {
                Console.Write(product.PriceTag());
            }
        }
    }
}
