using System;

namespace Produtos
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Estoque;

        public double ValorTotalEmEstoque()
        {
            return Preco * Estoque;
        }

        public void AdicionarProdutos(int Quant)
        {
            Estoque += Quant;
            Console.WriteLine($"Dados do Produto: Nome: {Nome}, R$: {Preco.ToString("F2")}, Quantidade {Estoque}. Total: R$ {ValorTotalEmEstoque().ToString("F2")}");
        }

        public void RemoverProdutos(int Quant)
        {
            Estoque -= Quant;
            Console.WriteLine($"Dados do Produto: Nome: {Nome}, R$: {Preco.ToString("F2")}, Quantidade {Estoque}. Total: R$ {ValorTotalEmEstoque().ToString("F2")}");
        }
    }
}
