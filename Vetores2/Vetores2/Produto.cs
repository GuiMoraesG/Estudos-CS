namespace Vetores2
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Price { get; set; }

        public Produto(string nome, double price)
        {
            Nome = nome;
            Price = price;
        }
    }
}
