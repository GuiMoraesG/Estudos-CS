namespace Produtos
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Estoque { get; private set; }

        public Produto()
        { }

        public Produto(string nome, double preco, int estoque)
        {
            _nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public string Nome
        {
            get
            { return _nome; }
            set
            {
                if (value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Estoque;
        }

        public override string ToString()
        {
            return $"Dados do Produto: Nome: {_nome}, R$: {Preco.ToString("F2")}, Quantidade {Estoque}. Total: R$ {ValorTotalEmEstoque().ToString("F2")}";
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
