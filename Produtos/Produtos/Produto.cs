using System;

namespace Produtos
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Estoque;

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Estoque;
        }

        public override string ToString()
        {
            return $"Dados do Produto: Nome: {Nome}, R$: {Preco.ToString("F2")}, Quantidade {Estoque}. Total: R$ {ValorTotalEmEstoque().ToString("F2")}";
        }

        public void AdicionarProdutos(int quant)
        {
            Estoque += quant;
        }

        public void RemoverProdutos(int quant)
        {
            Estoque -= quant;
        }
    }
}
