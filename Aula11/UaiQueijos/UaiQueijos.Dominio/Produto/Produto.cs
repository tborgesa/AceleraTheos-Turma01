using System;
using ClienteAlias = UaiQueijos.Dominio.Cliente.Cliente;

namespace UaiQueijos.Dominio.Produto
{
    public class Produto
    {
        public Produto(string nome, double desconto, decimal valor)
        {
            Nome = nome;
            Desconto = desconto;
            Valor = valor;
        }

        public string Nome { get; }
        public double Desconto { get; }
        public decimal Valor { get; }

        public decimal CalculaPrecoFinalProduto(ClienteAlias cliente)
        {
            decimal desconto = Valor * (decimal)(cliente.ObterDesconto(Desconto) / 100);
            return Valor - desconto;
        }
    }
}
