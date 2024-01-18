using System;
using System.Globalization;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa";

            int idade = 23;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.123456;

            Console.WriteLine("Produto:");
            Console.WriteLine($"{produto1}, cujo o preço é {preco1}");
            Console.WriteLine($"{produto2}, cujo o preço é {preco2}");

            Console.WriteLine($"Registro: {idade}, código {codigo} e genero {genero}");

            Console.WriteLine($"Medida com 8 casas: {medida:F8}");
            Console.WriteLine($"Medida com 2 casas: {medida:F2}");
            Console.WriteLine($"Número universal: {medida.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
