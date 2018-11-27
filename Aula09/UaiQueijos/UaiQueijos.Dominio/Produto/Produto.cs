using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteAlias = UaiQueijos.Dominio.Cliente.Cliente;


namespace UaiQueijos.Dominio.Produto
{
    public class Produto
    {
        public Produto(string nome, decimal valor, double desconto)
        {
            Nome = nome;
            Valor = valor;
            Desconto = desconto;
        }

        public string Nome { get; }
        public decimal Valor { get; set; }
        public double Desconto { get; }




        public Decimal CalculaPrecoFinalProduto(ClienteAlias cliente)
        {
            var desconto = Valor *(decimal)(cliente.ObterDesconto(10) / 100);
            return Valor - desconto;
        }
    }
}
