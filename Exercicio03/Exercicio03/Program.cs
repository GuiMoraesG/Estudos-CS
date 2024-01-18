using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, multiAB, multiCD, diferenca;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            multiAB = a * b;
            multiCD = c * d;
            diferenca = multiAB - multiCD;

            Console.WriteLine($"Diferenca = {diferenca}");
        }
    }
}
