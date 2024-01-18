using System;

namespace exercecios02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;

            Console.WriteLine("Digite dois valores para assim pegar: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;

            Console.WriteLine("A soma dos numeros são: ");
            Console.WriteLine(soma);
        }
    }
}
