using System;
using UaiQueijos.Comum.Helpers;
using UaiQueijos.Dominio;
using ClienteAlias = UaiQueijos.Dominio.Cliente;

namespace UaiQueijos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteAlias cliente = new ClienteAlias(new DateTime(187, 7, 8), "9876543210", "Alexandre", "Av 19 de dezembro, 369. Maringá - PR");

            ClienteAlias outroCliente = new ClienteAlias(new DateTime(187, 7, 8), "012345789", "Carlos", "Rua Castro Alvez, 1390. Maringá - PR");

            var teste = cliente.Nome;

            Console.ReadKey();            
        }
    }
}
