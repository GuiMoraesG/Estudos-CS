using System;

namespace Exercicios09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanto numeros vc quer digitar? ");
            int num = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i < num; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine($"Valor {i + 1}: {valor}");
                soma += valor;
            }

            Console.WriteLine($"Soma: {soma}");
        }
    }
}
