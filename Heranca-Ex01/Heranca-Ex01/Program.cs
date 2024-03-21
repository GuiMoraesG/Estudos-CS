using Heranca_Ex01.Entities;
using System;
using System.Collections.Generic;

namespace Heranca_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Lista = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.WriteLine("Outsourced (y/n)? ");
                char answer = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valueperhours = double.Parse(Console.ReadLine());

                if (answer == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    Lista.Add(new OutsourcedEmployee(name, hours, valueperhours, additionalCharge));
                }
                else
                {
                    Lista.Add(new Employee(name, hours, valueperhours));
                }
            }

            Console.WriteLine("PAYMENT: ");

            foreach (Employee emp in Lista)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment()}");
            }
        }
    }
}
