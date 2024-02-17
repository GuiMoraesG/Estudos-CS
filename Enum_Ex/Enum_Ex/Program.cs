using Enum_Ex.Entities;
using Enum_Ex.Entities.Enums;
using System;

namespace Enum_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkLevel level = (WorkLevel)Enum.Parse(typeof(WorkLevel), Console.ReadLine());

            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Department department = new Department(departmentName);
            Worker worker = new Worker(name, level, salary, department);

            Console.Write("How many contracts to this worker? ");
            int contracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= contracts; i++)
            {
                Console.WriteLine($"Enter #{i} Contract data: ");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHours, hours);

                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthYear}: {worker.Income(year, month)}");

        }
    }
}
