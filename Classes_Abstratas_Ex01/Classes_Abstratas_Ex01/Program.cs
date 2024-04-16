using Classes_Abstratas_Ex01.Entities;
using System;
using System.Collections.Generic;

namespace Classes_Abstratas_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");

                Console.Write("Individual or company (i/c): ");
                char ans = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine());

                if (ans == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine());

                    taxPayers.Add(new IndividualTaxPayer(name, annualIncome, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new LegalEntityTaxPayer(name, annualIncome, employees));
                }
            }

            Console.WriteLine("TAXES PAID: ");

            foreach (TaxPayer tax in taxPayers)
            {
                Console.WriteLine($"{tax.Name}: $ {tax.TotalTax()}");
            }
        }
    }
}
