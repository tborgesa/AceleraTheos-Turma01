using ClienteAlias = UaiQueijos.Dominio.Cliente.Cliente;

namespace UaiQueijos.Dominio.Produto
{
    public class Produto
    {
        public Produto(string nome, decimal valor, double desconto)
        {
            Nome = nome;
            Desconto = desconto;
            Valor = valor;
        }

        public string Nome { get; }
        public decimal Valor { get; }
        public double Desconto { get; }

        public decimal CalculaPrecoFinalProduto(ClienteAlias cliente)
        {
            decimal desconto = Valor * (decimal)(cliente.ObterDesconto(Desconto) / 100);
            return Valor - desconto;
        }
    }
}
