using System;
using ClienteAlias = UaiQueijos.Dominio.Cliente.Cliente;
using ClienteGoldAlias = UaiQueijos.Dominio.Cliente.ClienteGold;
using ClienteSilverAlias = UaiQueijos.Dominio.Cliente.ClienteSilver;
using ProdutoAlias = UaiQueijos.Dominio.Produto.Produto;

namespace UaiQueijos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteAlias cliente = new ClienteAlias(
                new DateTime(1987, 7, 8),
                "07346153618",
                "Thiago");

            ClienteSilverAlias clienteSilver = new ClienteSilverAlias(new DateTime(1987, 7, 8),
                "07346153618",
                "Thiago Silver");

            ClienteGoldAlias clienteGold = new ClienteGoldAlias(new DateTime(1987, 7, 8),
                "07346153618",
                "Thiago Gold");

            ProdutoAlias produto = new ProdutoAlias("Pão de Queijo", 100, 10);


            Console.WriteLine($"Preço do produto para Cliente: {produto.CalculaPrecoFinalProduto(cliente)}");
            Console.WriteLine($"Preço do produto para Cliente Silver: {produto.CalculaPrecoFinalProduto(clienteSilver)}");
            Console.WriteLine($"Preço do produto para Cliente Gold: {produto.CalculaPrecoFinalProduto(clienteGold)}");

            Console.ReadKey();
        }

        
    }
}
