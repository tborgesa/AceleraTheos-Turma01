using System;
using UaiQueijos.Comum.Helpers;
using UaiQueijos.Dominio;
using ClienteAlias = UaiQueijos.Dominio.Cliente;
using ClienteGoldAlias = UaiQueijos.Dominio.Cliente;

namespace UaiQueijos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteAlias cliente = new ClienteAlias(new DateTime(187, 7, 8), "9876543210", "Alexandre", "Av 19 de dezembro, 369. Maringá - PR");

            ClienteAlias clienteGold = new ClienteGoldAlias(new DateTime(187, 7, 8), "012345789", "Carlos", "Rua Castro Alvez, 1390. Maringá - PR");

            cliente.AlterarEndereco("end cliente");
            clienteGold.AlterarEndereco("end cliente Gold");

            var teste = cliente.Nome;

            Console.WriteLine($"Preço do produto para Cliente: {CalculaPrecoFinalProduto(100,cliente)}");
            Console.WriteLine($"Preço do produto para Cliente Gold: {CalculaPrecoFinalProduto(100, clienteGold)}");

            Console.ReadKey();            
        }

        public static double CalculaPrecoFinalProduto(double precoBase, ClienteAlias cliente)
        {
            var desconto = precoBase * (cliente.ObterDesconto(10) / 100);
            return precoBase - desconto;
        }
    }
}
