using System;

namespace Exercicios04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, horasTrabalhadas;
            float valorHora, salario;

            Console.WriteLine("Digite o número do funcionario as horas trabalhadas e o valor por hora:");
            number = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorHora = float.Parse(Console.ReadLine());

            salario = horasTrabalhadas * valorHora;

            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2")}");
        }
    }
}
