using System;

namespace POO_exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string maisVelho;
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Insira os dados da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira os dados da segunda pessoa: ");
            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = int.Parse(Console.ReadLine());

            if(pessoa1.idade > pessoa2.idade)
            {
                maisVelho = pessoa1.nome;
            }
            else
            {
                maisVelho = pessoa2.nome;
            }

            Console.WriteLine($"A pessoa mais velha é {maisVelho}");
        }
    }
}
