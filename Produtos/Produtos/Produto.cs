namespace Produtos
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _estoque;

        public Produto()
        { }

        public Produto(string nome, double preco, int estoque)
        {
            _nome = nome;
            _preco = preco;
            _estoque = estoque;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _estoque;
        }

        public override string ToString()
        {
            return $"Dados do Produto: Nome: {_nome}, R$: {_preco.ToString("F2")}, Quantidade {_estoque}. Total: R$ {ValorTotalEmEstoque().ToString("F2")}";
        }

        public void AdicionarProdutos(int quant)
        {
            _estoque += quant;
        }

        public void RemoverProdutos(int quant)
        {
            _estoque -= quant;
        }
    }
}
