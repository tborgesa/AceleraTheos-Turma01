using System;
using UaiQueijos.Comum.Helpers;
using UaiQueijos.Dominio;

namespace UaiQueijos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHelper.MensagemUsuario("Acessando o comum");

            Cliente cliente = new Cliente(new DateTime(1994, 7, 29), "42120768889", "Caroline");
            cliente.Endereco = "Rua Urano, 229. Maringá - PR";

            Cliente cliente1 = cliente;
            

            Console.ReadKey();
        }
    }
}
