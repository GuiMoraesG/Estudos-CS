using System;
using System.Globalization;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Guilherme";
            int idade = 23;
            double jogos = 121.222;

            Console.WriteLine("O {0} tem {1} anos e {2:F} jogos na steam", nome, idade, jogos);
            Console.WriteLine($"O {nome} tem {idade} anos e {jogos:F} jogos na steam");
        }
    }
}
