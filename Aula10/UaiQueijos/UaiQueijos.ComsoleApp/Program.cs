using System;
using ClienteAlias = UaiQueijos.Dominio.Cliente.Cliente;

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

            ClienteAlias outroCliente = new ClienteAlias(
                new DateTime(1987, 7, 8),
                "07346153618",
                "Thiago",
                "Rua Castro Alves, 1390. Maringá - PR");

            var teste = cliente.Nome;
            
            Console.ReadKey();
        }
    }
}
