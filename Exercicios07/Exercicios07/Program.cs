using System;

namespace Exercicios07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de vezes que você quer ver a mensagem");

            int num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                Console.WriteLine($"{Math.Sqrt(num)}");

                num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("NEGATIVO");
                }
            }
        }
    }
}
