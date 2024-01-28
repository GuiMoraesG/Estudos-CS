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

        public double Preco
        {
            get { return _preco; }
        }

        public int Estoque
        {
            get { return _estoque; }
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
