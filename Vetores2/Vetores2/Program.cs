using System;

namespace Vetores2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double soma = 0, media;

            Produto[] produtos = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                produtos[i] = new Produto(nome, price);

                soma += produtos[i].Price;
            }

            media = soma / n;

            Console.WriteLine(media);
        }
    }
}
