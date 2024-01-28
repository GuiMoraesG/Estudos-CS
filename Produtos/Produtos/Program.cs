using System;

namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
            Console.WriteLine("Entre com os dados dos Produtos");

            string nome = Console.ReadLine();
            double preco = double.Parse(Console.ReadLine());
            int estoque = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, estoque);

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.Estoque);
            /*
            Console.Write("Digite o numero de Produtos no estoque: ");
            quantidade = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(quantidade);
            Console.WriteLine(produto);

            Console.Write("Digite o numero de Produtos a serem removidos do estoque: ");
            quantidade = int.Parse(Console.ReadLine());

            produto.RemoverProdutos(quantidade);
            Console.WriteLine(produto); */
        }
    }
}
