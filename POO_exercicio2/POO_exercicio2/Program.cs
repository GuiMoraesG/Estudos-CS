using System;
using System.Net.Http.Headers;

namespace POO_exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media;
            Funcionarios func1, func2;
            func1 = new Funcionarios();
            func2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionarioa: ");
            func1.nomeFuncionario = Console.ReadLine();
            func1.salarioFuncionario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionarioa: ");
            func2.nomeFuncionario = Console.ReadLine();
            func2.salarioFuncionario = double.Parse(Console.ReadLine());

            media = (func2.salarioFuncionario + func1.salarioFuncionario) / 2;

            Console.WriteLine($"A média dos salarios é {media.ToString("F2")}");
        }
    }
}
