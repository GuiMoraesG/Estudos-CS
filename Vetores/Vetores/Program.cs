using System;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double soma = 0, media;

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
                soma += vet[i];
            }

            media = soma / vet.Length;

            Console.WriteLine(media);
        }
    }
}
