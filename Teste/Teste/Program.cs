using System;
using System.Globalization;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char x = char.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string dados = Console.ReadLine();
            string[] dadosLista = dados.Split(' ');

            string nome = dadosLista[0];
            int idade = int.Parse(dadosLista[1]);
            char gen = char.Parse(dadosLista[2]);
            float altura = float.Parse(dadosLista[3], CultureInfo.InvariantCulture);

            Console.WriteLine(n1);
            Console.WriteLine(x);
            Console.WriteLine(n2);

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(gen);
            Console.WriteLine(altura.ToString("F2"));
        }
    }
}
