using System;
using UaiQueijos.Comum.Helpers;
using UaiQueijos.Dominio;
using ClienteAlias = UaiQueijos.Dominio.Cliente.Cliente;
using ClienteGoldAlias = UaiQueijos.Dominio.Cliente.ClienteSilver;
using ClienteSilverAlias = UaiQueijos.Dominio.Cliente.ClienteGold;
using ProdutosAlias = UaiQueijos.Dominio.Produto.Produto;

namespace UaiQueijos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteAlias cliente = new ClienteAlias(
                new DateTime(1987, 07, 24), 
               "Talita",
                "07365412345");

            ClienteAlias clienteSilver = new ClienteSilverAlias(
                new DateTime(1987, 07, 24),
                "Talita Silver",
                "07365412345",
                "Rua Castro Alves, 1390. Maringá - PR");

            ClienteAlias clienteGold = new ClienteGoldAlias(
                new DateTime(1987, 07, 24),
                "Milena Gold",
                "07365412345",
                "Rua Castro Alves, 1390. Maringá - PR");

            ProdutosAlias produto = new ProdutosAlias("Pão de Queijo", 35, 5);

           Console.WriteLine($"Preço do produto para Cliente: R$ {produto.CalculaPrecoFinalProduto(cliente)}");
           Console.WriteLine($"Preço do produto para Cliente Gold: R$ {produto.CalculaPrecoFinalProduto(clienteGold)}");
            Console.WriteLine($"Preço do produto para Cliente Silver: R$ {produto.CalculaPrecoFinalProduto(clienteSilver)}");



            cliente.AlterarEndereco("em cliente");
            clienteGold.AlterarEndereco("em cliente gold 2");
            clienteSilver.AlterarEndereco("em cliente gold");

            Console.WriteLine(cliente.Nome);
            Console.WriteLine(clienteGold.Endereco);
            Console.WriteLine(clienteSilver.Nome);

            //todo instanciar novo cliente

            Console.ReadKey();
        }
    }
}
