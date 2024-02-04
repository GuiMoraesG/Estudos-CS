using System;
using System.Collections.Generic;

namespace Lista_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                int j = i;
                Console.WriteLine($"Emplyoee #{j += 1}: ");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Funcionario(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary incrise: ");
            int idFunc = int.Parse(Console.ReadLine());

            Console.Write("Percent: ");
            int percent = int.Parse(Console.ReadLine());

            Console.WriteLine("Update: ");

            foreach (Funcionario funcionario in list)
            {
                if (funcionario.Id == idFunc)
                {
                    funcionario.Aumento(percent);
                }
                else
                {
                    Console.WriteLine("ID not find");
                }

                Console.WriteLine($"{funcionario.Id}, {funcionario.Name}, R$ {funcionario.Salary.ToString("F2")}");
            }
        }
    }
}
