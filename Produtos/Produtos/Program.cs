using System;

namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
            Produto produto = new Produto();
            Console.WriteLine("Entre com os dados dos Produtos");

            produto.Nome = Console.ReadLine();
            produto.Preco = double.Parse(Console.ReadLine());
            produto.Estoque = int.Parse(Console.ReadLine());

            Console.WriteLine(produto);

            Console.Write("Digite o numero de Produtos a serem adicionados no estoque: ");
            quantidade = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(quantidade);
            Console.WriteLine(produto);

            Console.Write("Digite o numero de Produtos a serem removidos do estoque: ");
            quantidade = int.Parse(Console.ReadLine());

            produto.RemoverProdutos(quantidade);
            Console.WriteLine(produto);
        }
    }
}
