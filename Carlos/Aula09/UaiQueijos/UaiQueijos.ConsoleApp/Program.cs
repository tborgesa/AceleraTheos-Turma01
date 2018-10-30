using System;
using UaiQueijos.Comum.Helpers;
using UaiQueijos.Dominio;

namespace UaiQueijos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {            
            Cliente cliente = new Cliente(new DateTime(187, 7, 8), "012345789", "Carlos");
            cliente.Endereco = "Rua Castro Alvez, 1390. Maringá - PR";



            Console.ReadKey();
            
        }
    }
}
