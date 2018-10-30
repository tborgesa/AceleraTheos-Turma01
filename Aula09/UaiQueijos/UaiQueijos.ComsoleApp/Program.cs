using UaiQueijos.Comum.Helpers;
using UaiQueijos.Dominio;
using System;

namespace UaiQueijos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(
                new DateTime(1987, 7, 8), 
                "07346153618", 
                "Thiago");
            
            cliente.Endereco = "Rua Castro Alves, 1390. Maringá - PR";

            Cliente cliente1 = cliente;


            Console.ReadKey();


        }
    }
}
